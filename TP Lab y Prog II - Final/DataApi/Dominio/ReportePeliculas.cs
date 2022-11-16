using DataApi.Dominios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    public class ReportePeliculas
    {
        public string NombrePelicula { get; set; }
        public int CantidadAsistentes { get; set; }
        public double TotalRecaudado { get; set; }
    }
}
