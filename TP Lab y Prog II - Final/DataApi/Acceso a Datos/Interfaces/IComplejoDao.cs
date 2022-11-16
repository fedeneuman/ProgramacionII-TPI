using DataApi.Dominio;
using DataApi.Dominios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Acceso_a_Datos
{
     public interface IComplejoDao
    {
        List<Usuarios> ConsultarUsuario(Usuarios usuario);
        List<Usuarios> ConsultarUsuarios();
        int CargarUsuarios(Usuarios usuarios);
        int EditarUsuario(Usuarios usuarios);
        int EliminarUsuario(Usuarios usuarios);
        List<Parametros> Consultar(string Valor, string referencia);
        List<Parametros> CargarcomboComprobante(string valor, string referencia);
        int Insertar(string nombreTabla, string nombreValor, int id);
        bool GuardarMaestroDetalle(Comprobantes comprobante);
        bool EditarMaestroDetalle(Comprobantes comprobante);
        bool EliminarMaestroDetalle(Comprobantes c);
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
