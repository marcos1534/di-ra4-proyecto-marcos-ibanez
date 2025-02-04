using di_ra4_proyecto_marcos_ibanez.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace di_ra4_proyecto_marcos_ibanez.Controlador
{
    public static class ControladorPeliculas
    {
        public static List<Pelicula> listaPeliculas = new List<Pelicula> {
        /*0*/ new Pelicula(1, "Titanic", "Drama/Romance", 195, new DateTime(1997, 12, 19), true, ControladorSalas.listaSalas[0]),
        /*1*/ new Pelicula(2, "Inception", "Ciencia ficción/Thriller", 148, new DateTime(2010, 7, 16), true, ControladorSalas.listaSalas[2]),
        /*2*/ new Pelicula(3, "The Dark Knight", "Acción/Crimen", 152, new DateTime(2008, 7, 18), true, ControladorSalas.listaSalas[3]),
        /*3*/ new Pelicula(4, "Interstellar", "Ciencia ficción/Aventura", 169, new DateTime(2014, 11, 7), false, null),
        /*4*/ new Pelicula(5, "Avengers: Endgame", "Superhéroes/Acción", 181, new DateTime(2019, 4, 26), true, ControladorSalas.listaSalas[4]),
        /*5*/ new Pelicula(6, "Parasite", "Drama/Thriller", 132, new DateTime(2019, 5, 30), true, ControladorSalas.listaSalas[5]),
        /*6*/ new Pelicula(7, "Joker", "Drama/Crimen", 122, new DateTime(2019, 10, 4), false, null),
        /*7*/ new Pelicula(8, "Frozen II", "Animación/Musical", 103, new DateTime(2019, 11, 22), true, ControladorSalas.listaSalas[7]),
        /*8*/ new Pelicula(9, "Coco", "Animación/Fantástico", 109, new DateTime(2017, 11, 22), false, null),
        /*9*/ new Pelicula(10, "La La Land", "Musical/Romance", 128, new DateTime(2016, 12, 25), true, ControladorSalas.listaSalas[9]),
        /*10*/ new Pelicula(11, "The Matrix", "Ciencia ficción/Acción", 136, new DateTime(1999, 3, 31), true, ControladorSalas.listaSalas[11]),
        /*11*/ new Pelicula(12, "Spider-Man: No Way Home", "Superhéroes/Acción", 148, new DateTime(2021, 12, 17), true, ControladorSalas.listaSalas[12]),
        /*12*/ new Pelicula(13, "Dune", "Ciencia ficción/Aventura", 155, new DateTime(2021, 10, 22), false, null),
        /*13*/ new Pelicula(14, "Black Panther", "Superhéroes/Acción", 134, new DateTime(2018, 2, 16), true, ControladorSalas.listaSalas[14]),
        /*14*/ new Pelicula(15, "Shrek", "Animación/Comedia", 90, new DateTime(2001, 5, 18), true, ControladorSalas.listaSalas[16]),
        /*15*/ new Pelicula(16, "The Lion King", "Animación/Drama", 88, new DateTime(1994, 6, 24), false, null),
        /*16*/ new Pelicula(17, "Finding Nemo", "Animación/Aventura", 100, new DateTime(2003, 5, 30), true, ControladorSalas.listaSalas[18]),
        /*17*/ new Pelicula(18, "The Incredibles", "Animación/Acción", 115, new DateTime(2004, 11, 5), true, ControladorSalas.listaSalas[19]),
        /*18*/ new Pelicula(19, "Soul", "Animación/Drama", 100, new DateTime(2020, 12, 25), false, null),
        /*19*/ new Pelicula(20, "Encanto", "Animación/Fantástico", 102, new DateTime(2021, 11, 24), true, ControladorSalas.listaSalas[21]),
        /*20*/ new Pelicula(21, "Avatar", "Ciencia ficción/Aventura", 162, new DateTime(2009, 12, 18), true, ControladorSalas.listaSalas[22]),
        /*21*/ new Pelicula(22, "Avatar: The Way of Water", "Ciencia ficción/Aventura", 192, new DateTime(2022, 12, 16), true, ControladorSalas.listaSalas[23]),
        /*22*/ new Pelicula(23, "The Batman", "Acción/Crimen", 176, new DateTime(2022, 3, 4), false, null),
        /*23*/ new Pelicula(24, "Thor: Ragnarok", "Superhéroes/Acción", 130, new DateTime(2017, 11, 3), true, ControladorSalas.listaSalas[25]),
        /*24*/ new Pelicula(25, "Doctor Strange", "Superhéroes/Fantasía", 115, new DateTime(2016, 11, 4), false, null),
        /*25*/ new Pelicula(26, "Guardians of the Galaxy", "Superhéroes/Aventura", 121, new DateTime(2014, 8, 1), true, ControladorSalas.listaSalas[26]),
        /*26*/ new Pelicula(27, "Iron Man", "Superhéroes/Acción", 126, new DateTime(2008, 5, 2), true, ControladorSalas.listaSalas[28]),
        /*27*/ new Pelicula(28, "Captain America: The Winter Soldier", "Superhéroes/Acción", 136, new DateTime(2014, 4, 4), false, null),
        /*28*/ new Pelicula(29, "Eternals", "Superhéroes/Fantasía", 157, new DateTime(2021, 11, 5), true, ControladorSalas.listaSalas[30]),
        /*29*/ new Pelicula(30, "Ant-Man", "Superhéroes/Comedia", 117, new DateTime(2015, 7, 17), true, ControladorSalas.listaSalas[31]),
        /*30*/ new Pelicula(31, "The Avengers", "Superhéroes/Acción", 143, new DateTime(2012, 5, 4), true, ControladorSalas.listaSalas[33]),
        /*31*/ new Pelicula(32, "Avengers: Age of Ultron", "Superhéroes/Acción", 141, new DateTime(2015, 5, 1), false, null),
        /*32*/ new Pelicula(33, "Star Wars: A New Hope", "Ciencia ficción/Aventura", 121, new DateTime(1977, 5, 25), true, ControladorSalas.listaSalas[34]),
        /*33*/ new Pelicula(34, "Star Wars: The Empire Strikes Back", "Ciencia ficción/Aventura", 124, new DateTime(1980, 5, 21), false, null),
        /*34*/ new Pelicula(35, "Star Wars: Return of the Jedi", "Ciencia ficción/Aventura", 131, new DateTime(1983, 5, 25), true, ControladorSalas.listaSalas[36]),
        /*35*/ new Pelicula(36, "Harry Potter and the Sorcerer's Stone", "Fantasía/Aventura", 152, new DateTime(2001, 11, 16), true, ControladorSalas.listaSalas[37]),
        /*36*/ new Pelicula(37, "Harry Potter and the Chamber of Secrets", "Fantasía/Aventura", 161, new DateTime(2002, 11, 15), true, ControladorSalas.listaSalas[39]),
        /*37*/ new Pelicula(38, "Harry Potter and the Prisoner of Azkaban", "Fantasía/Aventura", 142, new DateTime(2004, 6, 4), false, null),
        /*38*/ new Pelicula(39, "Harry Potter and the Goblet of Fire", "Fantasía/Aventura", 157, new DateTime(2005, 11, 18), true, ControladorSalas.listaSalas[40]),
        /*39*/ new Pelicula(40, "Fantastic Beasts and Where to Find Them", "Fantasía/Aventura", 132, new DateTime(2016, 11, 18), true, ControladorSalas.listaSalas[42]),
        /*40*/ new Pelicula(41, "Fantastic Beasts: The Crimes of Grindelwald", "Fantasía/Aventura", 134, new DateTime(2018, 11, 16), false, null),
        /*41*/ new Pelicula(42, "The Hobbit: An Unexpected Journey", "Fantasía/Aventura", 169, new DateTime(2012, 12, 14), true, ControladorSalas.listaSalas[43]),
        /*42*/ new Pelicula(43, "The Hobbit: The Desolation of Smaug", "Fantasía/Aventura", 161, new DateTime(2013, 12, 13), true, ControladorSalas.listaSalas[45]),
        /*43*/ new Pelicula(44, "The Hobbit: The Battle of the Five Armies", "Fantasía/Aventura", 144, new DateTime(2014, 12, 17), false, null),
        /*44*/ new Pelicula(45, "The Lord of the Rings: The Fellowship of the Ring", "Fantasía/Aventura", 178, new DateTime(2001, 12, 19), true, ControladorSalas.listaSalas[46]),
        /*45*/ new Pelicula(46, "The Lord of the Rings: The Two Towers", "Fantasía/Aventura", 179, new DateTime(2002, 12, 18), true, ControladorSalas.listaSalas[48]),
        /*46*/ new Pelicula(47, "The Lord of the Rings: The Return of the King", "Fantasía/Aventura", 201, new DateTime(2003, 12, 17), false, null),
        /*47*/ new Pelicula(48, "Frozen", "Animación/Musical", 102, new DateTime(2013, 11, 27), true, null),
        /*48*/ new Pelicula(49, "Moana", "Animación/Aventura", 107, new DateTime(2016, 11, 23), true, ControladorSalas.listaSalas[49]),
        /*49*/ new Pelicula(50, "Raya and the Last Dragon", "Animación/Aventura", 114, new DateTime(2021, 3, 5), true, null)
        };

        public static List<Pelicula> listaPeliculasAux = new List<Pelicula>();

        public static void cargarCartelera(DataGridView dgv)
        {
            try
            {
                dgv.Rows.Clear();

                foreach (var pelicula in listaPeliculas)
                {
                    string sala = (pelicula.Sala != null && pelicula.Disponible)
                        ? $"Sala {pelicula.Sala.NumeroSala} - {pelicula.Sala.TipoSala}"
                        : "Sin sala asignada";

                    dgv.Rows.Add(pelicula.Id, pelicula.Titulo, pelicula.Genero, pelicula.Duracion, pelicula.FechaEstreno, sala, pelicula.Disponible);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la cartelera: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
