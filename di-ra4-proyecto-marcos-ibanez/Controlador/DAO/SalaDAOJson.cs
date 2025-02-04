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
    public class SalaDAOJson
    {
        public static void escribirJson(List<Sala> salas)
        {
            try
            {
                if (!File.Exists("salas.json"))
                {
                    string jsonString = JsonSerializer.Serialize(salas);
                    File.WriteAllText("salas.json", jsonString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("No se puedo escribir en el Json", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void leerJson(List<Sala> listaSalas)
        {
            try
            {
                if (File.Exists("salasLeer.json"))
                {
                    string jsonString = File.ReadAllText("salasLeer.json");
                    List<Sala> salasLeidas = JsonSerializer.Deserialize<List<Sala>>(jsonString);

                    if (listaSalas != null)
                    {
                        listaSalas.Clear();
                        listaSalas.AddRange(salasLeidas);
                    }
                }
                else
                {
                    MessageBox.Show("El archivo salasLeer.json no existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
