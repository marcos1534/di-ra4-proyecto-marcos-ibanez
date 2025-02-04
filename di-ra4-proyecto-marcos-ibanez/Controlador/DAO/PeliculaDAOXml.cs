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
    public class PeliculaDAOXml
    {
        public static void escribirXml(List<Pelicula> peliculas)
        {
            //escribir en xml
            try
            {
                using (var writer = new StreamWriter("peliculas.xml"))
                {
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(peliculas.GetType());
                    serializer.Serialize(writer, peliculas, namespaces);
                }
            }
            catch (Exception eii)
            {
                MessageBox.Show($"Error al escribir XML: {eii.Message}\n{eii.InnerException}");
            }
        }

        public static void leerXml(List<Pelicula> peliculas)
        {
            if (File.Exists("peliculasLeer.xml"))
            {
                try
                {
                    using (var reader = new StreamReader("peliculasLeer.xml"))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<Pelicula>));
                        List<Pelicula> peliculasLeidas = (List<Pelicula>)serializer.Deserialize(reader);

                        if (peliculasLeidas != null)
                        {
                            peliculas.Clear(); // Limpia la lista original
                            peliculas.AddRange(peliculasLeidas); // Agrega los nuevos datos
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
                MessageBox.Show("El archivo peliculasLeer.xml no existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
