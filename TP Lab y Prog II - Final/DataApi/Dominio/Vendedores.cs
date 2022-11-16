using System;
namespace DataApi
{
    public class Vendedores
    {
        public int NroVendedor { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int TipoDocumento { get; set; }
        public int Documento { get; set; }
        public int Telefono { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public int Barrio { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
