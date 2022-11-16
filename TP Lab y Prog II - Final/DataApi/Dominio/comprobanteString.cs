using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    public class comprobanteString
    {
        public int IdComprobante { get; set; }
        public string Vendedor { get; set; }
        public string Cliente { get; set; }
        public string Cine { get; set; }
        public DateTime FechaReserva  { get; set; }
        public string FormaCompra { get; set; }
        public string Descuento { get; set; }
    }
}
