using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    public class ReporteButacas
    {
     public string Nombre { get; set; }
     public int NroSala { get; set; }
     public double PrecioActual { get; set; }
     public double PrecioModificado { get; set; }
     public double PrecioTotalActual { get; set; }
     public double PrecioTotalModificado { get; set; }
     public int CantidadButacas { get; set; }
    }
}
