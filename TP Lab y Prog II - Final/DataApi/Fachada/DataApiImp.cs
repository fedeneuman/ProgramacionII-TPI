using DataApi.Acceso_a_Datos;
using DataApi.Dominio;
using DataApi.Dominios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Fachada
{
    public class DataApiImp : IDataApi
    {
        private IComplejoDao oDao;
        public DataApiImp()
        {
            oDao = new ComplejoDao();
        }
        public List<Usuarios> ConsultarUsuario(Usuarios usuario)
        {
            return oDao.ConsultarUsuario(usuario);
        }
        public List<Usuarios> ConsultarUsuarios()
        {
            return oDao.ConsultarUsuarios();
        }
        public int CargarUsuarios(Usuarios usuario)
        {
            return oDao.CargarUsuarios(usuario);
        }
        public int EditarUsuario(Usuarios usuario)
        {
            return oDao.EditarUsuario(usuario);
        }
        public int EliminarUsuario(Usuarios usuario)
        {
            return oDao.EliminarUsuario(usuario);
        }
        public List<Parametros> CargarCombo(string nombreTabla, string referencia)
        {
            return oDao.Consultar(nombreTabla, referencia);
        }
        public List<Parametros> CargarComboComprobante(string nombreTabla, string referencia)
        {
            return oDao.CargarcomboComprobante(nombreTabla, referencia);
        }
        public List<Parametros> Consultar(string nombreTabla, string referencia)
        {
            return oDao.Consultar(nombreTabla, referencia);
        }
        public int Insertar(string nombreTabla, string nombreValor, int id)
        {
            int aux = 0;
            return aux = oDao.Insertar(nombreTabla, nombreValor, id);
        }
        public bool GuardarComprobante(Comprobantes comprobante)
        {
            return oDao.GuardarMaestroDetalle(comprobante);
        }
        public bool EditarComprobante(Comprobantes comprobante)
        {
            return oDao.EditarMaestroDetalle(comprobante);
        }
        public bool EliminarComprobante(Comprobantes c)
        {
            return oDao.EliminarMaestroDetalle(c);
        }
        public List<comprobanteString> ConsultarComprobantes()
        {
            return oDao.ConsultarComprobantes();
        }
        public List<Comprobantes> ConsultarComprobantesIds()
        {
            return oDao.ConsultarComprobantesIds();
        }
        public List<DetallesComprobanteString> ConsultarDetallesComprobante(int idComprobante)
        {
            return oDao.ConsultarDetallesComprobante(idComprobante);
        }
        public List<DetallesComprobante> ConsultarDetallesComprobanteIds(int idComprobante)
        {
            return oDao.ConsultarDetallesComprobanteIds(idComprobante);
        }
        public List<ReportePeliculas> ConsultarReportePeliculas(Reportes reporte)
        {
            return oDao.ConsultarReportePeliculas(reporte);
        }
        public List<RepoteVendedores> ConsultarReporteVendedores(Reportes reporte)
        {
            return oDao.ConsultarReporteVendedores(reporte);
        }
        public List<ReporteComprobantes> ConsultarReporteComprobantes(Reportes reporte)
        {
            return oDao.ConsultarReporteComprobantes(reporte);
        }
        public List<ReporteClientes> ConsultarReporteClientes(Reportes reporte, string referencia)
        {
            return oDao.ConsultarReporteClientes(reporte, referencia);
        }
        public List<ReporteButacas> ConsultarReporteButacas(Reportes reporte)
        {
            return oDao.ConsultarReporteButacas(reporte);
        }
    }
}