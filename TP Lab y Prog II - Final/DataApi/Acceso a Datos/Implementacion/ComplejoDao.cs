using DataApi.Dominio;
using DataApi.Dominios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Acceso_a_Datos
{
     public class ComplejoDao : IComplejoDao
    {
        public List<Usuarios> ConsultarUsuario(Usuarios usuario) //Segun el tipo de nombre de tabla va a traer los registros de la misma
        {
            
                List<Usuarios> lst = new List<Usuarios>();
                DataTable dt = HelperDao.ObtenerInstancia().ConsultarUsuario("SP_CONSULTAR_USUARIO", usuario);
                foreach (DataRow dr in dt.Rows)
                {
                    Usuarios aux = new Usuarios(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());                    
                    lst.Add(aux);
                }
                return lst;          
        }
        public List<Usuarios> ConsultarUsuarios() 
        {

            List<Usuarios> lst = new List<Usuarios>();
            DataTable dt = HelperDao.ObtenerInstancia().ConsultarUsuarios("SP_CONSULTAR_USUARIO_ALL");
            foreach (DataRow dr in dt.Rows)
            {
                Usuarios aux = new Usuarios(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                lst.Add(aux);
            }
            return lst;
        }
        public int CargarUsuarios(Usuarios usuarios) 
        {
            return HelperDao.ObtenerInstancia().CargarUsuario("SP_INSERTAR_USUARIO", usuarios );
        }
        public int EditarUsuario(Usuarios usuarios)
        {
            return HelperDao.ObtenerInstancia().EditarUsuario("SP_EDITAR_USUARIO", usuarios);
        }
        public int EliminarUsuario(Usuarios usuarios)
        {
            return HelperDao.ObtenerInstancia().EliminarUsuario("SP_ELIMINAR_USUARIO", usuarios);
        }

        public List<Parametros> Consultar(string valor, string referencia) //Segun el tipo de nombre de tabla va a traer los registros de la misma
        {
            if (referencia == "a")
            {
                List<Parametros> lst = new List<Parametros>();
                DataTable dt = HelperDao.ObtenerInstancia().ConsultarAuxiliares("Consultar_Tabla_Auxiliar", valor);
                foreach (DataRow dr in dt.Rows)
                {
                    Parametros aux = new Parametros();
                    aux.Codigo = Convert.ToInt32(dr[0].ToString());
                    aux.Valor = dr[1].ToString();
                    lst.Add(aux);
                }
                return lst;
            }
            else
            {
                List<Parametros> lst = new List<Parametros>();
                DataTable dt = HelperDao.ObtenerInstancia().ConsultarProvXCiud("sp_ejecutar_funcion_prov_x_ciud", referencia);
                foreach (DataRow dr in dt.Rows)
                {
                    Parametros aux = new Parametros();
                    aux.Codigo = Convert.ToInt32(dr[0].ToString());
                    aux.Valor = dr[1].ToString();
                    lst.Add(aux);
                }
                return lst;
            }


        }
        public List<Parametros> CargarcomboComprobante(string valor, string referencia) //Segun el tipo de nombre de tabla va a traer los registros de la misma
        {

            if (valor == "funciones")
            {
                List<Parametros> lst = new List<Parametros>();
                DataTable dt = HelperDao.ObtenerInstancia().ConsultarAuxiliares("Cargar_combos_comprobante_funciones", referencia);
                foreach (DataRow dr in dt.Rows)
                {
                    Parametros aux = new Parametros();
                    aux.Codigo = Convert.ToInt32(dr[0].ToString());
                    aux.Valor = dr[1].ToString();
                    lst.Add(aux);
                }
                return lst;
            }
            else if (valor == "salas")
            {
                List<Parametros> lst = new List<Parametros>();
                DataTable dt = HelperDao.ObtenerInstancia().ConsultarAuxiliares("Cargar_combos_comprobante_salas", referencia);
                foreach (DataRow dr in dt.Rows)
                {
                    Parametros aux = new Parametros();
                    aux.Codigo = Convert.ToInt32(dr[0].ToString());
                    aux.Valor = dr[1].ToString();
                    lst.Add(aux);
                }
                return lst;
            }            
            else if (valor == "butacas")
            {
                List<Parametros> lst = new List<Parametros>();
                DataTable dt = HelperDao.ObtenerInstancia().ConsultarAuxiliares("Cargar_combos_comprobante_butacas", referencia);
                foreach (DataRow dr in dt.Rows)
                {
                    Parametros aux = new Parametros();
                    aux.Codigo = Convert.ToInt32(dr[0].ToString());
                    aux.Valor = dr[1].ToString();
                    lst.Add(aux);
                }
                return lst;

            }
            else if (valor == "precio")
            {
                List<Parametros> lst = new List<Parametros>();
                DataTable dt = HelperDao.ObtenerInstancia().ConsultarAuxiliares("Cargar_precio", referencia);
                foreach (DataRow dr in dt.Rows)
                {
                    Parametros aux = new Parametros(Convert.ToDouble(dr[0].ToString()));                    
                    lst.Add(aux);
                }
                return lst;

            }
            else
            {
                List<Parametros> lst = new List<Parametros>();
                DataTable dt = HelperDao.ObtenerInstancia().ConsultarAuxiliares("Cargar_combos_comprobante", valor);
                foreach (DataRow dr in dt.Rows)
                {
                    Parametros aux = new Parametros();
                    aux.Codigo = Convert.ToInt32(dr[0].ToString());
                    aux.Valor = dr[1].ToString();
                    lst.Add(aux);
                }
                return lst;
            }


        }
        public int Insertar(string nombreTabla, string nombreValor, int id)
        {
            int aux = 0;
            return aux = HelperDao.ObtenerInstancia().InsertarAuxiliares("insertar_Tabla_Auxiliar", nombreTabla, nombreValor, id);

        }
        public bool GuardarMaestroDetalle(Comprobantes comprobante)
        {
            return HelperDao.ObtenerInstancia().GuardarMaestroDetalle("SP_INSERTAR_MAESTRO", "SP_INSERTAR_DETALLE", comprobante);
        }
        public bool EditarMaestroDetalle(Comprobantes comprobante)
        {
            return HelperDao.ObtenerInstancia().EditarMaestroDetalle("SP_EDITAR_MAESTRO", "SP_EDITAR_DETALLE", comprobante);
        }
        public bool EliminarMaestroDetalle(Comprobantes c)
        {
            return HelperDao.ObtenerInstancia().EliminarMaestroDetalle("SP_ELIMINAR_MAESTRO", c);
        }
        public List<comprobanteString> ConsultarComprobantes()
        {
            List<comprobanteString> compList =  new List<comprobanteString>();
            DataTable dt = HelperDao.ObtenerInstancia().ConsultarComprobantes("SP_CONSULTAR_COMPROBANTES");
            foreach(DataRow dr in dt.Rows)
            {
                comprobanteString comp = new comprobanteString();
                comp.IdComprobante = Convert.ToInt32(dr[0].ToString());
                comp.Vendedor = dr[1].ToString();
                comp.Cliente = dr[2].ToString();
                comp.Cine = dr[3].ToString();
                comp.FechaReserva = Convert.ToDateTime(dr[4].ToString());
                comp.FormaCompra = dr[5].ToString();
                comp.Descuento = dr[6].ToString();
                compList.Add(comp);
            }
            return compList;
        }
        public List<Comprobantes> ConsultarComprobantesIds()
        {
            List<Comprobantes> compList = new List<Comprobantes>();
            DataTable dt = HelperDao.ObtenerInstancia().ConsultarComprobantesIds("SP_CONSULTAR_COMPROBANTES_IDS");
            foreach (DataRow dr in dt.Rows)
            {
                Comprobantes comp = new Comprobantes();
                comp.IdComprobante = Convert.ToInt32(dr[0].ToString());
                comp.IdVendedor = Convert.ToInt32(dr[1].ToString());
                comp.IdCliente = Convert.ToInt32(dr[2].ToString());
                comp.IdCine = Convert.ToInt32(dr[3].ToString());
                comp.FechaReserva = Convert.ToDateTime(dr[4].ToString());
                comp.IdFormaCompra = Convert.ToInt32(dr[5].ToString());
                comp.IdTipoDescuento = Convert.ToInt32(dr[6].ToString());
                compList.Add(comp);
            }
            return compList;
        }
        public List<DetallesComprobanteString> ConsultarDetallesComprobante(int idComprobante)
        {
            List<DetallesComprobanteString> detList = new List<DetallesComprobanteString>();
            DataTable dt = HelperDao.ObtenerInstancia().ConsultarDetalleComprobante("SP_CONSULTAR_DETALLES_COMPROBANTE", idComprobante);
            foreach (DataRow dr in dt.Rows)
            {
                DetallesComprobanteString det = new DetallesComprobanteString();
                det.IdDetalle = Convert.ToInt32(dr[0].ToString());
                det.Pelicula = dr[1].ToString();
                det.Funcion = dr[2].ToString();
                det.Sala = Convert.ToInt32(dr[3].ToString());
                det.Butaca = dr[4].ToString();
                det.Cantidad = Convert.ToInt32(dr[5].ToString());
                det.Precio = Convert.ToDouble(dr[6].ToString());
                detList.Add(det);
            }
            return detList;
        }
        public List<DetallesComprobante> ConsultarDetallesComprobanteIds(int idComprobante)
        {
            List<DetallesComprobante> detList = new List<DetallesComprobante>();
            DataTable dt = HelperDao.ObtenerInstancia().ConsultarDetalleComprobante("SP_CONSULTAR_DETALLES_COMPROBANTE_IDS", idComprobante);
            foreach (DataRow dr in dt.Rows)
            {
                DetallesComprobante det = new DetallesComprobante();
                det.IdDetalleComprobante = Convert.ToInt32(dr[0].ToString());
                det.IdPelicula = Convert.ToInt32(dr[4].ToString());
                det.IdFuncion = Convert.ToInt32(dr[7].ToString());
                det.IdSala = Convert.ToInt32(dr[6].ToString());
                det.IdButaca = Convert.ToInt32(dr[2].ToString());
                det.Cantidad = Convert.ToInt32(dr[3].ToString());
                det.Precio = Convert.ToDouble(dr[5].ToString());
                detList.Add(det);
            }
            return detList;
        }
        public List<ReportePeliculas> ConsultarReportePeliculas(Reportes reporte)
        {
            List<ReportePeliculas> rLst = new List<ReportePeliculas>();
            DataTable tabla = HelperDao.ObtenerInstancia().ReportePelicula("Reporte_Peliculas", reporte);
            foreach(DataRow dr in tabla.Rows)
            {
                ReportePeliculas rp = new ReportePeliculas();
                rp.NombrePelicula = dr[0].ToString();
                rp.CantidadAsistentes = Convert.ToInt32(dr[1].ToString());
                rp.TotalRecaudado = Convert.ToDouble(dr[2].ToString());
                rLst.Add(rp);
            }
            return rLst;
        }
        public List<RepoteVendedores> ConsultarReporteVendedores(Reportes reporte)
        {
            List<RepoteVendedores> rLst = new List<RepoteVendedores>();
            DataTable tabla = HelperDao.ObtenerInstancia().ReporteVendedor("Reporte_Vendedor", reporte);
            foreach (DataRow dr in tabla.Rows)
            {
                RepoteVendedores rv = new RepoteVendedores();
                rv.nombreVendedor = dr[0].ToString();
                rv.CantidadVentas = Convert.ToInt32(dr[1].ToString());
                rLst.Add(rv);
            }
            return rLst;
        }
        public List<ReporteComprobantes> ConsultarReporteComprobantes(Reportes reporte)
        {
            List<ReporteComprobantes> rLst = new List<ReporteComprobantes>();
            DataTable tabla = HelperDao.ObtenerInstancia().ReporteComprobante("Reporte_Comprobante", reporte);
            foreach (DataRow dr in tabla.Rows)
            {
                ReporteComprobantes rc = new ReporteComprobantes();
                rc.Fecha = Convert.ToDateTime(dr[0].ToString());
                rc.NroFactura = Convert.ToInt32(dr[1].ToString());
                rc.Cliente = dr[2].ToString();
                rc.Vendedor = dr[3].ToString();
                rc.ImporteTotal = Convert.ToDouble(dr[4].ToString());
                rc.Pelicula = dr[5].ToString();
                rLst.Add(rc);
            }
            return rLst;
        }
        public List<ReporteClientes> ConsultarReporteClientes(Reportes reporte, string referencia)
        {
            if (referencia == "genero")
            {
                List<ReporteClientes> rLst = new List<ReporteClientes>();
                DataTable tabla = HelperDao.ObtenerInstancia().ReporteClienteGenero("Reporte_Clientes_Genero", reporte);
                foreach (DataRow dr in tabla.Rows)
                {
                    ReporteClientes rc = new ReporteClientes();
                    rc.Cliente = dr[0].ToString();
                    rc.TipoCliente = dr[1].ToString();
                    rLst.Add(rc);
                }
                return rLst;
            }
            else
            {
                List<ReporteClientes> rLst = new List<ReporteClientes>();
                DataTable tabla = HelperDao.ObtenerInstancia().ReporteClientePelicula("Reporte_Clientes_Pelicula", reporte);
                foreach (DataRow dr in tabla.Rows)
                {
                    ReporteClientes rc = new ReporteClientes();
                    rc.Cliente = dr[0].ToString();
                    rc.TipoCliente = dr[1].ToString();
                    rLst.Add(rc);
                }
                return rLst;
            }
        }
        public List<ReporteButacas> ConsultarReporteButacas(Reportes reporte)
        {
            List<ReporteButacas> rLst = new List<ReporteButacas>();
            DataTable tabla = HelperDao.ObtenerInstancia().ReporteButacas("Reporte_Butacas", reporte);
            foreach (DataRow dr in tabla.Rows)
            {
                ReporteButacas rb = new ReporteButacas();
                rb.Nombre = dr[0].ToString();
                rb.NroSala = Convert.ToInt32(dr[1].ToString());
                rb.PrecioActual = Convert.ToDouble(dr[2].ToString()); 
                rb.PrecioModificado = Convert.ToDouble(dr[3].ToString());
                rb.PrecioTotalActual = Convert.ToDouble(dr[4].ToString());
                rb.PrecioTotalModificado = Convert.ToDouble(dr[5].ToString());
                rb.CantidadButacas = Convert.ToInt32(dr[6].ToString());
                rLst.Add(rb);
            }
            return rLst;
        }
    }
}
