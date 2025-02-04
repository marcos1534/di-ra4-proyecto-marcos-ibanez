using di_ra4_proyecto_marcos_ibanez.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace di_ra4_proyecto_marcos_ibanez.Controlador.DAO
{
    public class SalaDAOXml
    {
        public static void escribirXml(List<Sala> salas)
        {
            //escribir en xml
            try
            {
                using (var writer = new StreamWriter("salas.xml"))
                {
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(salas.GetType());
                    serializer.Serialize(writer, salas, namespaces);
                }
            }
            catch (Exception eii)
            {
                MessageBox.Show($"Error al escribir XML: {eii.Message}\n{eii.InnerException}");
            }
        }

        public static void leerXml(List<Sala> salas)
        {
            if (File.Exists("salasLeer.xml"))
            {
                try
                {
                    using (var reader = new StreamReader("salasLeer.xml"))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<Sala>));
                        List<Sala> salasLeidas = (List<Sala>)serializer.Deserialize(reader);

                        if (salasLeidas != null)
                        {
                            salas.Clear(); // Limpia la lista original
                            salas.AddRange(salasLeidas); // Agrega los nuevos datos
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Error al leer XML: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El archivo salasLeer.xml no existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
