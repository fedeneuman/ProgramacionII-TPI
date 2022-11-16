using DataApi.Dominio;
using DataApi.Dominios;
using DataApi.Fachada;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprobanteController : ControllerBase
    {
        private IDataApi oDataApi; // Punto de Acceso a la Api
        public ComprobanteController()
        {
            oDataApi = new DataApiImp();
        }
        // POST api/<UsuarioController>
        [HttpPost("/Usuario")]
        public IActionResult ConsultarUsuario(Usuarios usuario)
        {
            List<Usuarios> lst = oDataApi.ConsultarUsuario(usuario);
            
            if (lst.Count == 0)
            {
                return BadRequest();
            }
            else
                return Ok(lst);
        }

        // GET: api/<UsuarioController>
        [HttpGet("/Consultar_Usuario")]
        public IActionResult ConsultarUsuarios()
        {
            List<Usuarios> uList = new List<Usuarios>();
            uList = oDataApi.ConsultarUsuarios();
            return Ok(uList);
        }

        // POST api/<UsuarioController>
        [HttpPost("/Insertar_Usuario")]
        public IActionResult CargarUsuarios(Usuarios usuario)
        {
            int respuesta = oDataApi.CargarUsuarios(usuario);

            if (respuesta == 0)
            {
                return BadRequest();
            }
            else
                return Ok("Se registro exitosamente el usuario !");
        }

        // PUT api/<ComprobanteController>
        [HttpPut("/Editar_Usuario")]
        public IActionResult EditarUsuario(Usuarios usuario)
        {
            int respuesta = oDataApi.EditarUsuario(usuario);
            if (usuario == null || respuesta == 0)
            {
                return BadRequest();
            }
            else
                return Ok("Se editó exitosamente !");
        }

        // PUT api/<ComprobanteController>
        [HttpPut("/Eliminar_Usuario")]
        public IActionResult EliminarUsuario(Usuarios usuario)
        {
            int respuesta = oDataApi.EliminarUsuario(usuario);
            if (usuario == null || respuesta == 0)
            {
                return BadRequest();
            }
            else
                return Ok("Se eliminò exitosamente !");
        }

        // POST api/<ComprobanteController>
        [HttpPost("/Comprobante")]
        public IActionResult GetCombosComprobante(string nombreTabla, string referencia)
        {
            List<Parametros> lst = new List<Parametros>();
            if (referencia == "a")
                lst = oDataApi.CargarComboComprobante(nombreTabla, "");
            else
                lst = oDataApi.CargarComboComprobante(nombreTabla, referencia);

            return Ok(lst);
        }

        // POST api/<CargaVariosController>
        [HttpPost("/Carga_Varios")]
        public IActionResult GetCombosCargaVarios(string nombreTabla, string referencia)
        {
            List<Parametros> lst = new List<Parametros>();
            lst = oDataApi.Consultar(nombreTabla, referencia);
            return Ok(lst);
        }

        // POST api/<ComprobanteController>
        [HttpPost("/Guardar_Comprobante")]
        public IActionResult GuardarComprobante(Comprobantes comprobante)
        {
            bool Confirmacion = oDataApi.GuardarComprobante(comprobante);
            if (comprobante == null || Confirmacion == false)
            {
                return BadRequest();
            }
            else
                return Ok("Se añadio exitosamente !");
        }

        // PUT api/<ComprobanteController>
        [HttpPut("/Editar_Comprobante")]
        public IActionResult EditarComprobante(Comprobantes comprobante)
        {
            bool Confirmacion = oDataApi.EditarComprobante(comprobante);
            if (comprobante == null || Confirmacion == false)
            {
                return BadRequest();
            }
            else
                return Ok("Se editó exitosamente !");
        }

        // PUT api/<ComprobanteController>
        [HttpPut("/Eliminar_Comprobante")]

        public IActionResult EliminarComprobante(Comprobantes c)
        {
            bool Confirmacion = oDataApi.EliminarComprobante(c);
            if (c == null || Confirmacion == false)
            {
                return BadRequest();
            }
            else
                return Ok("Se eliminó exitosamente !");
        }

        // GET: api/<ComprobanteController>
        [HttpGet("/Consultar_Comprobante")]
        public IActionResult ConsultarComprobante()
        {
            List<comprobanteString> compList = new List<comprobanteString>();
            compList = oDataApi.ConsultarComprobantes();
            return Ok(compList);
        }

        // GET: api/<ComprobanteController>
        [HttpGet("/Consultar_Comprobante_Ids")]
        public IActionResult ConsultarComprobanteIds()
        {
            List<Comprobantes> compList = new List<Comprobantes>();
            compList = oDataApi.ConsultarComprobantesIds();
            return Ok(compList);
        }

        // POST api/<ComprobantesController>
        [HttpPost("/Consultar_Detalles_Comprobante")]
        public IActionResult ConsultarDetallesComprobante(int idComprobante)
        {
            List<DetallesComprobanteString> lst = new List<DetallesComprobanteString>();
            lst = oDataApi.ConsultarDetallesComprobante(idComprobante);
            return Ok(lst);
        }

        // POST api/<ComprobantesController>
        [HttpPost("/Consultar_Detalles_Comprobante_Ids")]
        public IActionResult ConsultarDetallesComprobanteIds(int idComprobante)
        {
            List<DetallesComprobante> lst = new List<DetallesComprobante>();
            lst = oDataApi.ConsultarDetallesComprobanteIds(idComprobante);
            return Ok(lst);
        }

        // POST api/<ReporteComprobantesController>
        [HttpPost("/Reporte_Comprobantes")]
        public IActionResult CargarReporteComprobantes(Reportes reporte)
        {
            List<ReporteComprobantes> lst = new List<ReporteComprobantes>();
            lst = oDataApi.ConsultarReporteComprobantes(reporte);           
            return Ok(lst);
        }

        // POST api/<ReporteClientesController>
        [HttpPost("/Reporte_Clientes")]
        public IActionResult CargarReporteClientes(Reportes reporte, string referencia)
        {
            List<ReporteClientes> lst = new List<ReporteClientes>();
            lst = oDataApi.ConsultarReporteClientes(reporte, referencia);
            return Ok(lst);
        }
        // POST api/<ReporteVendedoresController>
        [HttpPost("/Reporte_Vendedores")]
        public IActionResult CargarReporteVendedores(Reportes reporte)
        {
            List<RepoteVendedores> lst = new List<RepoteVendedores>();
            lst = oDataApi.ConsultarReporteVendedores(reporte);
            return Ok(lst);
        }
        // POST api/<ReportePeliculasController>
        [HttpPost("/Reporte_Peliculas")]
        public IActionResult CargarReportePeliculas(Reportes reporte)
        {
            List<ReportePeliculas> lst = new List<ReportePeliculas>();
            lst = oDataApi.ConsultarReportePeliculas(reporte);
            return Ok(lst);
        }
        // POST api/<ReporteButacasController>
        [HttpPost("/Reporte_Butacas")]
        public IActionResult CargarReporteButacas(Reportes reporte)
        {
            List<ReporteButacas> lst = new List<ReporteButacas>();
            lst = oDataApi.ConsultarReporteButacas(reporte);
            return Ok(lst);
        }


    }
}
