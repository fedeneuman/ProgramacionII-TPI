using System;
namespace DataApi.Dominios
{
    public class Funciones
    {
        public Funciones(int idFuncion, string horaFuncion)
        {
            IdFuncion = idFuncion;
            HoraFuncion = horaFuncion;
        }
        public Funciones()
        {
            IdFuncion = 0;
            Fechafuncion = DateTime.Now;
            HoraFuncion = "";
        }

        public int IdFuncion { get; set; }
        public DateTime Fechafuncion { get; set; }
        public string HoraFuncion { get; set; }
    }
}
