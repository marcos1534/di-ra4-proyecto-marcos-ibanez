using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace di_ra4_proyecto_marcos_ibanez.Modelo
{
    public class Pelicula
    {
        private int id;
        private string titulo;
        private string genero;
        private int duracion;
        private DateTime fechaEstreno;
        private bool disponible; //(booleano, si está en cartelera o no)
        private Sala sala;

        public Pelicula() { }

        public Pelicula(int id, string titulo, string genero, int duracion, DateTime fechaEstreno, bool disponible, Sala sala)
        {
            this.id = id;
            this.titulo = titulo;
            this.genero = genero;
            this.duracion = duracion;
            this.fechaEstreno = fechaEstreno;
            this.disponible = disponible;
            this.sala = sala;
        }

        public int Id { get => id; set => id=value; }
        public string Titulo { get => titulo; set => titulo=value; }
        public string Genero { get => genero; set => genero=value; }
        public int Duracion { get => duracion; set => duracion=value; }
        public DateTime FechaEstreno { get => fechaEstreno; set => fechaEstreno=value; }
        public bool Disponible { get => disponible; set => disponible=value; }
        public Sala Sala { get => sala; set => sala = value; }

        public string SalaPelicula => Sala != null ? $"Sala {Sala.NumeroSala}" : "Sin sala";
    }
}
