using System;
using System.Collections.Generic;

namespace DataApi
{
    public class Cines
    {
        private int idCine;
        private string nombre;
        private int idCondicionIva;
        private int cuit;
        private int telefono;
        private string calle;
        private int altura;
        private int barrio;
        private int ingresosBrutos;
        private List<Salas> salas;

        public Cines()
        {
            salas = new List<Salas>();
        }

        public int IdCine { get; set; }
        public string Nombre { get; set; }
        public int IdCondicionIva { get; set; }
        public int Cuit { get; set; }
        public int Telefono { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public int Barrio { get; set; }
        public int IngresosBrutos { get; set; }
        public List<Salas> Salas { get; set; }

    }
}
