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
    public interface IDataApi
    {
        List<Usuarios> ConsultarUsuario(Usuarios usuario);
        List<Usuarios> ConsultarUsuarios();
        int CargarUsuarios(Usuarios usuario);
        int EditarUsuario(Usuarios usuarios);
        int EliminarUsuario(Usuarios usuarios);
        List<Parametros> CargarCombo(string nombreTabla, string referencia);
        List<Parametros> CargarComboComprobante(string nombreTabla, string referencia);
        List<Parametros> Consultar(string nombreTabla, string referencia);
        int Insertar(string nombreTabla, string nombreValor, int id);
        bool GuardarComprobante(Comprobantes comprobante);
        bool EditarComprobante(Comprobantes comprobante);
        bool EliminarComprobante(Comprobantes c);
        List<comprobanteString> ConsultarComprobantes();
        List<Comprobantes> ConsultarComprobantesIds();
        List<DetallesComprobanteString> ConsultarDetallesComprobante(int idComprobante);
        List<DetallesComprobante> ConsultarDetallesComprobanteIds(int idComprobante);
        List<ReportePeliculas> ConsultarReportePeliculas(Reportes reporte);
        List<RepoteVendedores> ConsultarReporteVendedores(Reportes reporte);
        List<ReporteComprobantes> ConsultarReporteComprobantes(Reportes reporte);
        List<ReporteClientes> ConsultarReporteClientes(Reportes reporte, string referencia);
        List<ReporteButacas> ConsultarReporteButacas(Reportes reporte);
    }
}
