using System;
namespace DataApi.Dominios
{
    public class FormasPagoPorComprobante
    {
        public int IdFpagoPorComprobante { get; set; }
        public int IdComprobante { get; set; }
        public int IdFormaPago { get; set; }
        public float MontoAbonado { get; set; }

        public FormasPagoPorComprobante()
        {

        }
    }
}
