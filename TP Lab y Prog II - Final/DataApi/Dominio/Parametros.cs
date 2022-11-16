using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    public class Parametros
    {
        public int Codigo { get; set; }
        public string Valor { get; set; }
        public double Precio { get; set; }
        public Parametros(int Codigo, string Valor)
        {
            this.Codigo = Codigo;
            this.Valor = Valor;
        }
        public Parametros(double Precio)
        {
            this.Precio = Precio;
        }
        public Parametros()
        {
            Codigo = 0;
            Valor = "";
        }
    }
}
