using di_ra4_proyecto_marcos_ibanez.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace di_ra4_proyecto_marcos_ibanez.Controlador.DAO
{
    public static class PeliculaDAOJson
    {
        public static void escribirJson(List<Pelicula> peliculas)
        {
            try
            {
                if (!File.Exists("peliculas.json"))
                {
                    string jsonString = JsonSerializer.Serialize(peliculas);
                    File.WriteAllText("peliculas.json", jsonString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("No se puedo escribir en el Json", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void leerJson(List<Pelicula> listaPeliculas)
        {
            try
            {
                if (File.Exists("peliculasLeer.json"))
                {
                    string jsonString = File.ReadAllText("peliculasLeer.json");
                    List<Pelicula> peliculasLeidas = JsonSerializer.Deserialize<List<Pelicula>>(jsonString);

                    if (listaPeliculas != null)
                    {
                        listaPeliculas.Clear();
                        listaPeliculas.AddRange(peliculasLeidas);
                    }
                }
                else
                {
                    MessageBox.Show("El archivo peliculasLeer.json no existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("No se pudo leer el JSON", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
