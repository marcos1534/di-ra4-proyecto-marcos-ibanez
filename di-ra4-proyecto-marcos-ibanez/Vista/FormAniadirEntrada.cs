using di_ra4_proyecto_marcos_ibanez.Controlador;
using di_ra4_proyecto_marcos_ibanez.Modelo;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace di_ra4_proyecto_marcos_ibanez.Vista
{
    public partial class FormAniadirEntrada : Form
    {
        private static readonly Dictionary<DayOfWeek, double> preciosPorDia = new Dictionary<DayOfWeek, double>()
        {
            { DayOfWeek.Monday, 7.89 },
            { DayOfWeek.Tuesday, 7.89 },
            { DayOfWeek.Wednesday, 7.89 },
            { DayOfWeek.Thursday, 7.89 },
            { DayOfWeek.Friday, 11.90 },
            { DayOfWeek.Saturday, 11.90 },
            { DayOfWeek.Sunday, 10.50 }
        };
        private static readonly Dictionary<string, double> extrasPorSala = new Dictionary<string, double>()
        {
            { "InSense", 2.0 },
            { "2D", 0.0 },
            { "3D", 0.5 },
            { "IMAX", 0.75 },
            { "Deluxe", 1.0 },
            { "Normal", -0.5 }
        };
        public FormAniadirEntrada()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public FormAniadirEntrada(string nombrePelicula, Sala sala) : this()
        {
            comboBPeli.Text = nombrePelicula; // Asigna el texto como lo haces

            // En vez de esto, encontramos el índice de la película por nombre
            var indicePelicula = comboBPeli.Items.IndexOf(nombrePelicula);
            if (indicePelicula != -1)
            {
                comboBPeli.SelectedIndex = indicePelicula; // Selecciona el índice de la película correctamente
            }

            SeleccionarSala(sala);
            comboBoxSala.Enabled = false;
            comboBPeli.Enabled = false;
            numUDButaca.Maximum = sala.Capacidad;
        }


        private void InicializarComponentesAdicionales()
        {
            CargarPeliculas();
            CargarSalas();
            dtpFechyHora.ValueChanged += dateTimePicker_ValueChanged;
            comboBPeli.SelectedIndexChanged += comboBPeli_SelectedIndexChanged;
            comboBoxSala.SelectedIndexChanged += comboBoxSala_SelectedIndexChanged;
        }

        private double CalcularPrecio(DateTime fecha, string tipoSala)
        {
            double precioBase = preciosPorDia.TryGetValue(fecha.DayOfWeek, out double precio) ? precio : 0.0;
            double extraSala = tipoSala != null && extrasPorSala.TryGetValue(tipoSala, out double extra) ? extra : 0.0;
            return precioBase + extraSala;
        }

        private void btCrearEntrada_Click(object sender, EventArgs e)
        {
            if (txtBUsuario.Text.Equals(""))
            {
                MessageBox.Show("El campo usuario debe ser rellenado", "Error en la creación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBPeli.SelectedIndex == -1)
            {
                MessageBox.Show("El campo pelicula debe ser rellenado", "Error en la creación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxSala.SelectedIndex == -1)
            {
                MessageBox.Show("El campo sala debe ser rellenado", "Error en la creación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtpFechyHora.Value < DateTime.Now)
            {
                MessageBox.Show("La fecha/hora debe ser valida, no valen fechas ni horas anteriores a las actuales", "Error en la creación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Entrada nuevaEntrada = new Entrada
                (
                    txtBUsuario.Text,
                    ControladorPeliculas.listaPeliculas.FirstOrDefault(p => p.Titulo == comboBPeli.SelectedItem.ToString()),
                    ControladorSalas.listaSalas.FirstOrDefault(s => $"Sala {s.NumeroSala} - {s.TipoSala}" == comboBoxSala.SelectedItem.ToString()),
                    dtpFechyHora.Value,
                    (int)numUDButaca.Value,
                    (double)numUDPrecio.Value
                );

                // Añadir entrada al controlador
                ControladorEntradas.aniadirEntrada(new List<Entrada> { nuevaEntrada });

                MessageBox.Show("La entrada se creo correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Para consultar tus entradas ves al formulario principal y en el menú delsplegable superior selecciona 'Buscar Entradas' o 'Modificar Entrada' en caso de que quieras cambiar algo de tu entrada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClear_Click(sender, e);
            }
        }

        private void CargarPeliculas()
        {
            comboBPeli.Items.Clear();
            var peliculasDisponibles = ControladorPeliculas.listaPeliculas
                .Where(p => p.Disponible) // Filtra solo las películas que están disponibles
                .Select(p => p.Titulo)
                .ToArray();
            comboBPeli.Items.AddRange(peliculasDisponibles);
        }
        private void CargarSalas()
        {
            comboBoxSala.Items.Clear();
            comboBoxSala.Items.AddRange(ControladorSalas.listaSalas
                .Select(s => $"Sala {s.NumeroSala} - {s.TipoSala}")
                .ToArray());
        }

        private void SeleccionarSala(Sala sala)
        {
            if (sala != null)
            {
                string salaTexto = $"Sala {sala.NumeroSala} - {sala.TipoSala}";
                comboBoxSala.SelectedItem = comboBoxSala.Items.Contains(salaTexto) ? salaTexto : null;
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpFechyHora.Value;

            string salaTexto = comboBoxSala.SelectedItem?.ToString();
            string tipoSala = salaTexto?.Split('-').Last().Trim(); // Extrae el tipo de sala

            if (!numUDPrecio.Enabled)
            {
                numUDPrecio.Enabled = true;
            }

            double precioFinal = CalcularPrecio(selectedDate, tipoSala);

            // Actualiza el valor del NumericUpDown
            numUDPrecio.Value = (decimal)precioFinal;
            numUDPrecio.Enabled = false;
        }   

        private void comboBPeli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string peliculaSeleccionada = comboBPeli.SelectedItem?.ToString();
            Pelicula pelicula = ControladorPeliculas.listaPeliculas
                .FirstOrDefault(p => p.Titulo == peliculaSeleccionada);

            SeleccionarSala(pelicula?.Sala);
        }

        private void comboBoxSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            string salaTexto = comboBoxSala.SelectedItem?.ToString();
            Sala salaSeleccionada = ControladorSalas.listaSalas
                .FirstOrDefault(s => $"Sala {s.NumeroSala} - {s.TipoSala}" == salaTexto);

            if (salaSeleccionada != null)
            {
                var peliculasEnSala = ControladorPeliculas.listaPeliculas
                    .Where(p => p.Sala == salaSeleccionada)
                    .Select(p => p.Titulo)
                    .ToArray();

                comboBPeli.Items.Clear();
                comboBPeli.Items.AddRange(peliculasEnSala);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            numUDPrecio.Enabled = true;
            numUDButaca.Value = 1;
            numUDPrecio.Value = 0; // Precio base restablecido
            txtBUsuario.Text = "";
            dtpFechyHora.Value = DateTime.Now;
            comboBPeli.SelectedIndex = -1;
            comboBoxSala.SelectedIndex = -1; // Esto establece SelectedItem en null
            CargarPeliculas();
            numUDPrecio.Enabled = false;
            comboBoxSala.Enabled = true;
            comboBPeli.Enabled = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item is FormPrincipal)
                {
                    item.BringToFront();
                    item.Show();
                }
            }
            this.Close();
        }

        private void FormAniadirEntrada_Load(object sender, EventArgs e)
        {
            dateTimePicker_ValueChanged(sender, e);
        }

        private void copiarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveControl is TextBox textBox && textBox.SelectedText.Length > 0)
            {
                textBox.Copy();
            }
        }

        private void cortarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveControl is TextBox textBox && textBox.SelectedText.Length > 0)
            {
                textBox.Cut();
            }
        }

        private void pegarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveControl is TextBox textBox)
            {
                textBox.Paste();
            }
        }
    }
}
