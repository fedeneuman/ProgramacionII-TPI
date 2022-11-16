using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    public class Usuarios
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Jerarquia { get; set; }
        public Usuarios(string usuario, string contraseña, string jerarquia)
        {
            Usuario = usuario;
            Contraseña = contraseña;
            Jerarquia = jerarquia;
        }

        public Usuarios()
        {
        }
    }
}
