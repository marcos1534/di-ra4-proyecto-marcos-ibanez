using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace di_ra4_proyecto_marcos_ibanez.Modelo
{
    public class Entrada
    {
        private int codigoEntrada;
        private string usuario;
        private Pelicula pelicula;
        private Sala sala;
        private DateTime fechaYHora;
        private int butaca;
        private double precio;

        public Entrada() { }

        public Entrada(int codigoEntrada, string usuario, Pelicula pelicula, Sala sala, DateTime fechaYHora, int butaca, double precio)
        {
            this.codigoEntrada=codigoEntrada;
            this.usuario=usuario;
            this.pelicula=pelicula;
            this.sala=sala;
            this.fechaYHora=fechaYHora;
            this.butaca=butaca;
            this.precio=precio;
        }

        public Entrada(string usuario, Pelicula pelicula, Sala sala, DateTime fechaYHora, int butaca, double precio)
        {
            Usuario = usuario;
            Pelicula = pelicula;
            Sala = sala;
            FechaYHora = fechaYHora;
            Butaca = butaca;
            Precio = precio;
        }

        public int CodigoEntrada { get => codigoEntrada; set => codigoEntrada=value; }
        public string Usuario { get => usuario; set => usuario= value; }
        public Pelicula Pelicula { get => pelicula; set => pelicula=value; }
        public Sala Sala { get => sala; set => sala=value; }
        public DateTime FechaYHora { get => fechaYHora; set => fechaYHora=value; }
        public int Butaca { get => butaca; set => butaca=value; }
        public double Precio { get => precio; set => precio=value; }

        // Propiedad calculada para el título de la película
        public string PeliculaTitulo => Pelicula != null ? Pelicula.Titulo : "Sin título";

        // Propiedad calculada para la descripción de la sala
        public string SalaDescripcion => Sala != null ? $"Sala {Sala.NumeroSala}" : "Sin sala";
    }
}
