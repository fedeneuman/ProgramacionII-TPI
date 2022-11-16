using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    public class DetallesComprobanteString
    {
        public int IdDetalle { get; set; }
        public string Pelicula { get; set; }
        public string Funcion { get; set; }
        public int Sala { get; set; }
        public string Butaca { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
    }
}
