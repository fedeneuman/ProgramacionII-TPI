using System;
using System.Collections.Generic;

namespace DataApi
{
    public class Salas
    {
        private int idSala;
        private int nroSala;
        private int tipoSala;
        private float precio;
        private int idCine;
        private List<Butacas> butacas;
        public Salas(int IdSala, int NroSala)
        {
            this.idSala = IdSala;
            this.nroSala = NroSala;
        }
        public Salas()
        {
            butacas = new List<Butacas>();
        }
        public int IdSala { get; set; }
        public int NroSala { get; set; }
        public int TipoSala { get; set; }
        public float Precio { get; set; }
        public int IdCine { get; set; }
        public List<Butacas> Butacas { get; set; }
    }
}
