using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace di_ra4_proyecto_marcos_ibanez.Modelo
{
    public class Sala
    {
        private int numeroSala;
        private int capacidad;
        private string tipoSala; // Sala 2D, 3D, IMAX, InSense, Deluxe
        private bool disponibilidad; //(booleano, si está libre o asignada a una proyección)

        public Sala() { }

        public Sala(int numeroSala, int capacidad, string tipoSala, bool disponibilidad)
        {
            this.numeroSala=numeroSala;
            this.capacidad=capacidad;
            this.tipoSala=tipoSala;
            this.disponibilidad=disponibilidad;
        }

        public int NumeroSala { get => numeroSala; set => numeroSala=value; }
        public int Capacidad { get => capacidad; set => capacidad=value; }
        public string TipoSala { get => tipoSala; set => tipoSala=value; }
        public bool Disponibilidad { get => disponibilidad; set => disponibilidad=value; }
    }
}
