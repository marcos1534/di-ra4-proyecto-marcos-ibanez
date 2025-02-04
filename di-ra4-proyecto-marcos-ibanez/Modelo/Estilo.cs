using System.Drawing;

namespace ra4_sesión_1_menús.Controlador
{
    public class Estilo
    {
        Color foreColor;
        Font font;
        Color backColor;
        int width;
        int height;

        public Estilo() { }

        public Estilo(Color foreColor, Font font, Color backColor, int width, int height)
        {
            this.foreColor = foreColor;
            this.font = font;
            this.backColor = backColor;
            this.width = width;
            this.height = height;
        }

        public Color ForeColor { get => foreColor; set => foreColor = value; }
        public Font Font { get => font; set => font = value; }
        public Color BackColor { get => backColor; set => backColor = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
    }
}