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
    public static class EntradaDAOJson
    {
        public static void escribirJson(List<Entrada> entrada)
        {
            try
            {
                if (!File.Exists("entradas.json"))
                {
                    string jsonString = JsonSerializer.Serialize(entrada);
                    File.WriteAllText("entradas.json", jsonString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("No se puedo escribir en el Json", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void leerJson(List<Entrada> listaEntradas)
        {
            try
            {
                if (File.Exists("entradasLeer.json"))
                {
                    string jsonString = File.ReadAllText("entradasLeer.json");
                    List<Entrada> entradasLeidas = JsonSerializer.Deserialize<List<Entrada>>(jsonString);

                    if (listaEntradas != null)
                    {
                        listaEntradas.Clear();
                        listaEntradas.AddRange(entradasLeidas);
                    }
                }
                else
                {
                    MessageBox.Show("El archivo entradasLeer.json no existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
