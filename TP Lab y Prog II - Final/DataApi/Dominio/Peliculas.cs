using System;
namespace DataApi.Dominios
{
    public class Peliculas
    {
        public int IdPelicula { get; set; }
        public string Nombre { get; set; }
        public int Duracion { get; set; }
        public int IdGenero { get; set; }
        public int IdClasificacion { get; set; }
        public string Descripcion { get; set; }
        public int IdIdioma { get; set; }
        public int IdSubtitulo { get; set; }
    }
}
