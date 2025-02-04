using di_ra4_proyecto_marcos_ibanez.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace di_ra4_proyecto_marcos_ibanez.Controlador
{
    public static class ControladorEntradas
    {
        private static int id = 51;
        public static List<Entrada> listaEntradas = new List<Entrada>
        {
            new Entrada(1, "Paco", ControladorPeliculas.listaPeliculas[2], ControladorSalas.listaSalas[3], new DateTime(2025, 01, 16), 5, 6.70),
            new Entrada(2, "Amigo de Paco", ControladorPeliculas.listaPeliculas[2], ControladorSalas.listaSalas[3], new DateTime(2025, 1, 16), 6, 6.70),
            new Entrada(3, "Ana", ControladorPeliculas.listaPeliculas[1], ControladorSalas.listaSalas[2], new DateTime(2025, 02, 10), 12, 7.50),
            new Entrada(4, "Luis", ControladorPeliculas.listaPeliculas[1], ControladorSalas.listaSalas[2], new DateTime(2025, 02, 12), 13, 8.00),
            new Entrada(5, "María", ControladorPeliculas.listaPeliculas[5], ControladorSalas.listaSalas[5], new DateTime(2025, 03, 05), 20, 15.50),
            new Entrada(6, "Carlos", ControladorPeliculas.listaPeliculas[5], ControladorSalas.listaSalas[5], new DateTime(2025, 01, 30), 10, 6.30),
            new Entrada(7, "Lucía", ControladorPeliculas.listaPeliculas[7], ControladorSalas.listaSalas[7], new DateTime(2025, 03, 01), 9, 7.00),
            new Entrada(8, "Fernando", ControladorPeliculas.listaPeliculas[7], ControladorSalas.listaSalas[7], new DateTime(2025, 03, 14), 8, 16.90),
            new Entrada(9, "Clara", ControladorPeliculas.listaPeliculas[9], ControladorSalas.listaSalas[9], new DateTime(2025, 02, 18), 3, 5.20),
            new Entrada(10, "Sofía", ControladorPeliculas.listaPeliculas[9], ControladorSalas.listaSalas[9], new DateTime(2025, 01, 25), 17, 6.80),
            new Entrada(11, "Roberto", ControladorPeliculas.listaPeliculas[10], ControladorSalas.listaSalas[11], new DateTime(2025, 02, 28), 22, 7.10),
            new Entrada(12, "Laura", ControladorPeliculas.listaPeliculas[11], ControladorSalas.listaSalas[12], new DateTime(2025, 01, 23), 7, 5.90),
            new Entrada(13, "Jorge", ControladorPeliculas.listaPeliculas[11], ControladorSalas.listaSalas[12], new DateTime(2025, 02, 15), 11, 6.50),
            new Entrada(14, "Paula", ControladorPeliculas.listaPeliculas[11], ControladorSalas.listaSalas[12], new DateTime(2025, 03, 12), 13, 7.20),
            new Entrada(15, "Diego", ControladorPeliculas.listaPeliculas[11], ControladorSalas.listaSalas[12], new DateTime(2025, 02, 08), 4, 5.70),
            new Entrada(16, "Raúl", ControladorPeliculas.listaPeliculas[11], ControladorSalas.listaSalas[12], new DateTime(2025, 01, 19), 18, 7.80),
            new Entrada(17, "Marta", ControladorPeliculas.listaPeliculas[14], ControladorSalas.listaSalas[16], new DateTime(2025, 02, 25), 14, 6.40),
            new Entrada(18, "Alberto", ControladorPeliculas.listaPeliculas[14], ControladorSalas.listaSalas[16], new DateTime(2025, 03, 03), 19, 7.00),
            new Entrada(19, "Sara", ControladorPeliculas.listaPeliculas[16], ControladorSalas.listaSalas[18], new DateTime(2025, 01, 27), 6, 11.80),
            new Entrada(20, "Andrés", ControladorPeliculas.listaPeliculas[16], ControladorSalas.listaSalas[18], new DateTime(2025, 03, 07), 21, 7.90),
            new Entrada(21, "Elena", ControladorPeliculas.listaPeliculas[17], ControladorSalas.listaSalas[19], new DateTime(2025, 02, 22), 9, 6.60),
            new Entrada(22, "Daniel", ControladorPeliculas.listaPeliculas[17], ControladorSalas.listaSalas[19], new DateTime(2025, 01, 29), 16, 7.30),
            new Entrada(23, "Ángela", ControladorPeliculas.listaPeliculas[20], ControladorSalas.listaSalas[22], new DateTime(2025, 03, 18), 5, 12.20),
            new Entrada(24, "Hugo", ControladorPeliculas.listaPeliculas[21], ControladorSalas.listaSalas[23], new DateTime(2025, 01, 20), 2, 11.90),
            new Entrada(25, "Noelia", ControladorPeliculas.listaPeliculas[19], ControladorSalas.listaSalas[21], new DateTime(2025, 02, 14), 20, 7.60),
            new Entrada(26, "Javier", ControladorPeliculas.listaPeliculas[19], ControladorSalas.listaSalas[21], new DateTime(2025, 03, 02), 10, 6.10),
            new Entrada(27, "Isabel", ControladorPeliculas.listaPeliculas[23], ControladorSalas.listaSalas[25], new DateTime(2025, 01, 24), 23, 7.70),
            new Entrada(28, "Víctor", ControladorPeliculas.listaPeliculas[23], ControladorSalas.listaSalas[25], new DateTime(2025, 02, 11), 8, 6.90),
            new Entrada(29, "Alicia", ControladorPeliculas.listaPeliculas[26], ControladorSalas.listaSalas[28], new DateTime(2025, 03, 04), 11, 11.30),
            new Entrada(30, "Enrique", ControladorPeliculas.listaPeliculas[25], ControladorSalas.listaSalas[26], new DateTime(2025, 01, 26), 13, 7.40),
            new Entrada(31, "Sergio", ControladorPeliculas.listaPeliculas[29], ControladorSalas.listaSalas[31], new DateTime(2025, 02, 20), 12, 6.20),
            new Entrada(32, "Carmen", ControladorPeliculas.listaPeliculas[30], ControladorSalas.listaSalas[33], new DateTime(2025, 01, 17), 14, 7.10),
            new Entrada(33, "Manuel", ControladorPeliculas.listaPeliculas[28], ControladorSalas.listaSalas[30], new DateTime(2025, 02, 13), 18, 6.50),
            new Entrada(34, "Patricia", ControladorPeliculas.listaPeliculas[28], ControladorSalas.listaSalas[30], new DateTime(2025, 03, 09), 7, 11.80),
            new Entrada(35, "Álvaro", ControladorPeliculas.listaPeliculas[32], ControladorSalas.listaSalas[34], new DateTime(2025, 02, 19), 22, 7.90),
            new Entrada(36, "Beatriz", ControladorPeliculas.listaPeliculas[34], ControladorSalas.listaSalas[36], new DateTime(2025, 01, 31), 3, 6.40),
            new Entrada(37, "Iván", ControladorPeliculas.listaPeliculas[35], ControladorSalas.listaSalas[37], new DateTime(2025, 02, 21), 5, 7.30),
            new Entrada(38, "Julia", ControladorPeliculas.listaPeliculas[36], ControladorSalas.listaSalas[39], new DateTime(2025, 03, 06), 15, 6.20),
            new Entrada(39, "Marcos", ControladorPeliculas.listaPeliculas[38], ControladorSalas.listaSalas[40], new DateTime(2025, 01, 28), 6, 12.70),
            new Entrada(40, "Rosa", ControladorPeliculas.listaPeliculas[39], ControladorSalas.listaSalas[42], new DateTime(2025, 02, 16), 4, 7.80),
            new Entrada(41, "Pedro", ControladorPeliculas.listaPeliculas[41], ControladorSalas.listaSalas[43], new DateTime(2025, 01, 18), 10, 6.50),
            new Entrada(42, "Gloria", ControladorPeliculas.listaPeliculas[42], ControladorSalas.listaSalas[45], new DateTime(2025, 02, 26), 11, 7.00),
            new Entrada(43, "Adrián", ControladorPeliculas.listaPeliculas[44], ControladorSalas.listaSalas[46], new DateTime(2025, 01, 30), 14, 6.40),
            new Entrada(44, "Lorena", ControladorPeliculas.listaPeliculas[45], ControladorSalas.listaSalas[48], new DateTime(2025, 02, 05), 19, 12.20),
            new Entrada(45, "Sebastián", ControladorPeliculas.listaPeliculas[45], ControladorSalas.listaSalas[48], new DateTime(2025, 03, 15), 3, 7.50),
            new Entrada(46, "Lourdes", ControladorPeliculas.listaPeliculas[45], ControladorSalas.listaSalas[48], new DateTime(2025, 01, 22), 8, 6.60),
            new Entrada(47, "Óscar", ControladorPeliculas.listaPeliculas[48], ControladorSalas.listaSalas[49], new DateTime(2025, 03, 13), 20, 7.40),
            new Entrada(48, "Inés", ControladorPeliculas.listaPeliculas[48], ControladorSalas.listaSalas[49], new DateTime(2025, 01, 29), 12, 6.30),
            new Entrada(49, "Mario", ControladorPeliculas.listaPeliculas[48], ControladorSalas.listaSalas[49], new DateTime(2025, 02, 03), 16, 13.60),
            new Entrada(50, "Victoria", ControladorPeliculas.listaPeliculas[48], ControladorSalas.listaSalas[49], new DateTime(2025, 03, 08), 9, 7.00)
        };

        public static List<Entrada> listaEntradasAux = new List<Entrada>();

        public static bool modificarUsu = false;

        public static void aniadirEntrada(List<Entrada> nuevasEntradas)
        {
            foreach (var entrada in nuevasEntradas)
            {
                entrada.CodigoEntrada = id++;
                listaEntradas.Add(entrada);
            }
        }

        public static Entrada buscarEntrada(int id)
        {
            return listaEntradas.Find(e => e.CodigoEntrada == id);
        }

        public static bool eliminarEntrada(int id)
        {
            var entrada = buscarEntrada(id);
            if (entrada != null)
            {
                listaEntradas.Remove(entrada);
                return true;
            }
            return false;
        }

        public static List<Entrada> ObtenerEntradas()
        {
            return listaEntradas;
        }
    }
}
