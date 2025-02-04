using di_ra4_proyecto_marcos_ibanez.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace di_ra4_proyecto_marcos_ibanez.Controlador
{
    public class ControladorSalas
    {
        public static List<Sala> listaSalas = new List<Sala>
        {
            new Sala(1, 20, "InSense", true),
            new Sala(2, 25, "2D", false),
            new Sala(3, 40, "3D", true),
            new Sala(4, 25, "IMAX", true),
            new Sala(5, 18, "Deluxe", true),
            new Sala(6, 50, "Normal", true),
            new Sala(7, 30, "VIP", false),
            new Sala(8, 45, "4D", true),
            new Sala(9, 35, "Premium", false),
            new Sala(10, 20, "Standard", true),
            new Sala(11, 60, "Normal", false),
            new Sala(12, 40, "IMAX", true),
            new Sala(13, 15, "Compact", true),
            new Sala(14, 70, "Ultra", false),
            new Sala(15, 50, "2D", true),
            new Sala(16, 25, "3D", false),
            new Sala(17, 55, "InSense", true),
            new Sala(18, 30, "Deluxe", false),
            new Sala(19, 20, "Standard", true),
            new Sala(20, 65, "Premium", true),
            new Sala(21, 35, "VIP", false),
            new Sala(22, 50, "Normal", true),
            new Sala(23, 40, "IMAX", true),
            new Sala(24, 45, "4D", true),
            new Sala(25, 25, "Standard", false),
            new Sala(26, 60, "Deluxe", true),
            new Sala(27, 30, "Compact", true),
            new Sala(28, 55, "Ultra", false),
            new Sala(29, 45, "3D", true),
            new Sala(30, 20, "2D", false),
            new Sala(31, 35, "VIP", true),
            new Sala(32, 50, "Premium", true),
            new Sala(33, 40, "4D", false),
            new Sala(34, 25, "IMAX", true),
            new Sala(35, 70, "Normal", true),
            new Sala(36, 60, "Deluxe", false),
            new Sala(37, 20, "Standard", true),
            new Sala(38, 15, "Compact", true),
            new Sala(39, 55, "Ultra", false),
            new Sala(40, 30, "2D", true),
            new Sala(41, 50, "3D", true),
            new Sala(42, 25, "VIP", false),
            new Sala(43, 45, "Premium", true),
            new Sala(44, 65, "4D", true),
            new Sala(45, 35, "InSense", false),
            new Sala(46, 20, "Deluxe", true),
            new Sala(47, 60, "Ultra", true),
            new Sala(48, 40, "IMAX", false),
            new Sala(49, 55, "Normal", true),
            new Sala(50, 30, "Standard", true)
        };

        public static List<Sala> listaSalaAux = new List<Sala>();
    }
}