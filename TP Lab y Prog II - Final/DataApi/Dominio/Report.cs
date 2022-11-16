using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    public class Report
    {
        public int Id1 { get; set; }
        public int Id2 { get; set; }
        public string Nombre { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public bool SinVenta { get; set; }
        public double Decimal { get; set; }

        public Report(int id1, int id2, string nombre, DateTime desde, DateTime hasta, bool sinVenta, double @decimal)
        {
            Id1 = id1;
            Id2 = id2;
            Nombre = nombre;
            Desde = desde;
            Hasta = hasta;
            SinVenta = sinVenta;
            Decimal = @decimal;
        }
    }
}
