using System;
using System.Collections.Generic;


namespace DataApi.Dominios
{
    public class Comprobantes
    {
        public Comprobantes()
        {
            Detalle = new List<DetallesComprobante>();
        }
        public int IdComprobante { get; set; }
        public int IdVendedor { get; set; }
        public int IdCliente { get; set; }
        public int IdCine { get; set; }
        public DateTime FechaReserva { get; set; }
        public int IdFormaCompra { get; set; }
        public int IdTipoDescuento { get; set; }
        public List<DetallesComprobante> Detalle { get ; set; }
        public bool Baja { get; set; }
        public void AgregarDetalle(DetallesComprobante det)
        {
            Detalle.Add(det);
        }

        public void QuitarDetalle(int posicion)
        {
            Detalle.RemoveAt(posicion);
        }
        public void EditarDetalle(DetallesComprobante d)
        {
            foreach (DetallesComprobante de in Detalle)
            {
                if (de.IdDetalleComprobante == d.IdDetalleComprobante)
                {
                    de.IdPelicula = d.IdPelicula;
                    de.IdFuncion = d.IdFuncion;
                    de.IdSala = d.IdSala;
                    de.Cantidad = 1;
                    de.IdButaca = d.IdButaca;
                    de.Precio = d.Precio;
                }
            }
        }

        public double CalculatTotal()
        {
            double total = 0;
            foreach (DetallesComprobante item in Detalle)
                total += item.CalcularSubtotal();
            return total;
        }
    }
}
