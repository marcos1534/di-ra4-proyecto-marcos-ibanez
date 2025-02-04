using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ra4_sesión_1_menús.Controlador
{
    public class ControladorMods
    {
        public static bool primeraCarga = false;
        // Un bolean que diga si hay que actualizar la lista de usuarios.
        public static bool configCambiada = false;
        public static Estilo estiloComun;

        public static bool ConfigCambiada { get => configCambiada; set => configCambiada = value; }

        public static void guardarEstilo(Color foreColor, Font font, Color backColor, int width, int height)
        {
            estiloComun = new Estilo();
            estiloComun.Width = width;
            estiloComun.ForeColor = foreColor;
            estiloComun.Font = font;
            estiloComun.BackColor = backColor;
        }
    }
}
