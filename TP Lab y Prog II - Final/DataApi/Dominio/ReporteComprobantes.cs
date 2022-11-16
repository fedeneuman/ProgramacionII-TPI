using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    public class ReporteComprobantes
    {
        public DateTime Fecha { get; set; }
        public int NroFactura { get; set; }
        public string Cliente {  get; set; }
        public string Vendedor { get; set; }
        public double ImporteTotal { get; set; }
        public string Pelicula { get; set; }
    }
}
