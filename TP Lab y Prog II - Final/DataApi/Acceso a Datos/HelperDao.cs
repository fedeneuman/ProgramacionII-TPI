using DataApi.Dominio;
using DataApi.Dominios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Acceso_a_Datos
{
     public class HelperDao
    {
        private static HelperDao instancia;
        private SqlConnection cnn;

        private HelperDao()       
        {
            
            cnn = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = COMPLEJO_DE_CINES; Integrated Security = True");
            
        }
        public static HelperDao ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new HelperDao();
            return instancia;
        }
        public DataTable ConsultarUsuario(string NombreSP, Usuarios usuario)
        {
            DataTable tabla = new DataTable();

            cnn.Open();
            SqlCommand cmd = new SqlCommand(NombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USUARIO", usuario.Usuario);
            cmd.Parameters.AddWithValue("@CONTRASEÑA", usuario.Contraseña);

            tabla.Load(cmd.ExecuteReader());

            cnn.Close();
            return tabla;
        }
        public int CargarUsuario(string NombreSP, Usuarios usuario)
        {
            int aux = 0;

            cnn.Open();
            SqlCommand cmd = new SqlCommand(NombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USUARIO", usuario.Usuario);
            cmd.Parameters.AddWithValue("@CONTRASEÑA", usuario.Contraseña);
            cmd.Parameters.AddWithValue("@JERARQUIA", usuario.Jerarquia);

            aux = cmd.ExecuteNonQuery();

            cnn.Close();
            return aux;
        }
        public int EditarUsuario(string NombreSP, Usuarios usuario)
        {
            int aux = 0;

            cnn.Open();
            SqlCommand cmd = new SqlCommand(NombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USUARIO", usuario.Usuario);
            cmd.Parameters.AddWithValue("@CONTRASEÑA", usuario.Contraseña);
            cmd.Parameters.AddWithValue("@JERARQUIA", usuario.Jerarquia);

            aux = cmd.ExecuteNonQuery();

            cnn.Close();
            return aux;
        }
        public int EliminarUsuario(string NombreSP, Usuarios usuario)
        {
            int aux = 0;

            cnn.Open();
            SqlCommand cmd = new SqlCommand(NombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USUARIO", usuario.Usuario);           

            aux = cmd.ExecuteNonQuery();

            cnn.Close();
            return aux;
        }
        public DataTable ConsultarUsuarios(string NombreSP)
        {
            DataTable tabla = new DataTable();

            cnn.Open();
            SqlCommand cmd = new SqlCommand(NombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            tabla.Load(cmd.ExecuteReader());

            cnn.Close();
            return tabla;
        }
        public DataTable ConsultarAuxiliares(string NombreSP, string Valor)
        {
            DataTable tabla = new DataTable();

            cnn.Open();
            SqlCommand cmd = new SqlCommand(NombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@valor", Valor);

            tabla.Load(cmd.ExecuteReader());

            cnn.Close();
            return tabla;
        }
        public DataTable ConsultarProvXCiud(string NombreSP, string ciudad)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(NombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ciudad", ciudad);

            DataTable aux = new DataTable();
            aux.Load(cmd.ExecuteReader());
            cnn.Close();
            return aux;
        }
        public int InsertarAuxiliares(string nombreSP, string tablaDB, string nombreValor, int id)
        {
            int aux = 0;
            cnn.Open();
            SqlCommand cmd = new SqlCommand(nombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tabla", tablaDB);
            cmd.Parameters.AddWithValue("@valor", nombreValor);
            if (id > 0)
            {
                cmd.Parameters.AddWithValue("valor2", id);
            }

            aux = cmd.ExecuteNonQuery();

            cnn.Close();
            return aux;
        }
        public bool GuardarMaestroDetalle(string spMaestro, string spDetalle, Comprobantes comprobante)
        {
            bool resultado = true;
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand(spMaestro, cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_vendedor", comprobante.IdVendedor);
                cmd.Parameters.AddWithValue("@id_cliente", comprobante.IdCliente);
                cmd.Parameters.AddWithValue("@id_cine", comprobante.IdCine);
                cmd.Parameters.AddWithValue("@fecha_reserva", comprobante.FechaReserva);
                cmd.Parameters.AddWithValue("@id_forma_de_compra", comprobante.IdFormaCompra);
                cmd.Parameters.AddWithValue("@id_tipo_descuento", comprobante.IdTipoDescuento);
                cmd.Parameters.AddWithValue("@BAJA", comprobante.Baja);

                SqlParameter param = new SqlParameter("@id_comprobante", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                int comprobanteNro = Convert.ToInt32(param.Value);

                foreach (DetallesComprobante det in comprobante.Detalle)
                {
                    SqlCommand cmdDet = new
                    SqlCommand(spDetalle, cnn, t);
                    cmdDet.CommandType = CommandType.StoredProcedure;
                    cmdDet.Parameters.AddWithValue("@ID_COMPROBANTE", comprobanteNro);
                    cmdDet.Parameters.AddWithValue("@ID_BUTACA", det.IdButaca);
                    cmdDet.Parameters.AddWithValue("@CANTIDAD", 1);
                    cmdDet.Parameters.AddWithValue("@ID_PELICULA", det.IdPelicula);
                    cmdDet.Parameters.AddWithValue("@PRECIO", det.Precio);
                    cmdDet.Parameters.AddWithValue("@ID_SALA", det.IdSala);
                    cmdDet.Parameters.AddWithValue("@ID_FUNCION", det.IdFuncion);
                    cmdDet.ExecuteNonQuery();
                }
                t.Commit();
                return resultado;
            }
            catch (Exception ex)
            {
                t.Rollback();
                resultado = false;
                return resultado;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }
        public bool EditarMaestroDetalle(string spMaestro, string spDetalle, Comprobantes comprobante)
        {
            bool resultado = true;
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand(spMaestro, cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_VENDEDOR", comprobante.IdVendedor);
                cmd.Parameters.AddWithValue("@ID_CLIENTE", comprobante.IdCliente);
                cmd.Parameters.AddWithValue("@ID_CINE", comprobante.IdCine);
                cmd.Parameters.AddWithValue("@FECHA_RESERVA", comprobante.FechaReserva);
                cmd.Parameters.AddWithValue("@ID_FORMA_DE_COMPRA", comprobante.IdFormaCompra);
                cmd.Parameters.AddWithValue("@ID_TIPO_DESCUENTO", comprobante.IdTipoDescuento);
                cmd.Parameters.AddWithValue("@ID_COMPROBANTE", comprobante.IdComprobante);
                cmd.Parameters.AddWithValue("@BAJA", comprobante.Baja);
                cmd.ExecuteNonQuery();

                foreach (DetallesComprobante det in comprobante.Detalle)
                {
                    SqlCommand cmdDet = new SqlCommand(spDetalle, cnn, t);
                    cmdDet.CommandType = CommandType.StoredProcedure;
                    cmdDet.Parameters.AddWithValue("@ID_DETALLE_COMPROBANTE", det.IdDetalleComprobante);
                    cmdDet.Parameters.AddWithValue("@ID_BUTACA", det.IdButaca);
                    cmdDet.Parameters.AddWithValue("@CANTIDAD", det.Cantidad);
                    cmdDet.Parameters.AddWithValue("@ID_PELICULA", det.IdPelicula);
                    cmdDet.Parameters.AddWithValue("@PRECIO", det.Precio);
                    cmdDet.Parameters.AddWithValue("@ID_SALA", det.IdSala);
                    cmdDet.Parameters.AddWithValue("@ID_FUNCION", det.IdFuncion);
                    cmdDet.ExecuteNonQuery();
                }
                t.Commit();
                return resultado;
            }
            catch (Exception ex)
            {
                t.Rollback();
                resultado = false;
                return resultado;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();

            }


        }
        public bool EliminarMaestroDetalle(string spMaestro, Comprobantes c)
        {
            bool resultado = true;
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand(spMaestro, cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", c.IdComprobante);
                cmd.ExecuteNonQuery();
                t.Commit();
                return resultado;
            }
            catch (Exception ex)
            {
                t.Rollback();
                resultado = false;
                return resultado;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();

            }




        }
        public DataTable ConsultarComprobantes(string NombreSP)
        {
            DataTable tabla = new DataTable();

            cnn.Open();
            SqlCommand cmd = new SqlCommand(NombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public DataTable ConsultarComprobantesIds(string NombreSP)
        {
            DataTable tabla = new DataTable();

            cnn.Open();
            SqlCommand cmd = new SqlCommand(NombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public DataTable ConsultarDetalleComprobante(string NombreSP, int idComprobante)
        {
            DataTable tabla = new DataTable();

            cnn.Open();
            SqlCommand cmd = new SqlCommand(NombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_comprobante", idComprobante);
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public DataTable ConsultarDetalleComprobanteIds(string NombreSP, int idComprobante)
        {
            DataTable tabla = new DataTable();

            cnn.Open();
            SqlCommand cmd = new SqlCommand(NombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_comprobante", idComprobante);
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public DataTable ReporteVendedor(string NombreSP, Reportes reporte)
        {
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(NombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fecha_desde", reporte.Desde);
            cmd.Parameters.AddWithValue("@fecha_hasta", reporte.Hasta);
            cmd.Parameters.AddWithValue("@cantidad", reporte.Id1);
            cmd.Parameters.AddWithValue("@sin_ventas", reporte.SinVenta);
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public DataTable ReportePelicula(string NombreSP, Reportes reporte)
        {
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(NombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Estacion", reporte.Nombre);            
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public DataTable ReporteComprobante(string NombreSP, Reportes reporte)
        {
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(NombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fecha_desde", reporte.Desde);
            cmd.Parameters.AddWithValue("@fecha_hasta", reporte.Hasta);
            cmd.Parameters.AddWithValue("@id_cliente", reporte.Id1);
            cmd.Parameters.AddWithValue("@id_vendedor", reporte.Id2);
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public DataTable ReporteClientePelicula(string NombreSP, Reportes reporte)
        {
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(NombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pelicula", reporte.Id1);
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public DataTable ReporteClienteGenero(string NombreSP, Reportes reporte)
        {
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(NombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@genero", reporte.Id1);
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public DataTable ReporteButacas(string NombreSP, Reportes reporte)
        {
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(NombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cine", reporte.Id1);
            cmd.Parameters.AddWithValue("@sala", reporte.Id2);
            cmd.Parameters.AddWithValue("@porcentaje", reporte.Decimal);
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
    }
}
