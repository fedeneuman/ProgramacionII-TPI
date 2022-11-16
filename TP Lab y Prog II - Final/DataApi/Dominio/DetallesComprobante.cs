using System;
using System.Collections.Generic;
namespace DataApi.Dominios
{
    public class DetallesComprobante
    {
        public int IdDetalleComprobante { get; set; }
        public int IdButaca { get; set; }
        public int Cantidad { get; set; }
        public int IdPelicula { get; set; }
        public double Precio { get; set; }
        public int IdSala { get; set; }
        public int IdFuncion { get; set; }

        public double CalcularSubtotal()
        {
            return Precio * Cantidad;
        }
    }
}
