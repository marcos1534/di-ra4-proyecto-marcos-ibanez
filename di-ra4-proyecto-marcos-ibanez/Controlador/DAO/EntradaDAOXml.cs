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
    public class EntradaDAOXml
    {
        public static void escribirXml(List<Entrada> entrada)
        {
            //escribir en xml
            try
            {
                using (var writer = new StreamWriter("entradas.xml"))
                {
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(entrada.GetType());
                    serializer.Serialize(writer, entrada, namespaces);
                }
            }
            catch (Exception eii)
            {
                MessageBox.Show($"Error al escribir XML: {eii.Message}\n{eii.InnerException}");
            }
        }

        public static void leerXml(List<Entrada> entradas)
        {
            if (File.Exists("entradasLeer.xml"))
            {
                try
                {
                    using (var reader = new StreamReader("entradasLeer.xml"))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<Entrada>));
                        List<Entrada> entradasLeidas = (List<Entrada>)serializer.Deserialize(reader);

                        if (entradasLeidas != null)
                        {
                            entradas.Clear(); // Limpia la lista original
                            entradas.AddRange(entradasLeidas); // Agrega los nuevos datos
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
                MessageBox.Show("El archivo entradasLeer.xml no existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
