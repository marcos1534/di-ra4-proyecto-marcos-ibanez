using di_ra4_proyecto_marcos_ibanez.Controlador;
using di_ra4_proyecto_marcos_ibanez.Modelo;
using di_ra4_proyecto_marcos_ibanez.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace di_ra4_proyecto_marcos_ibanez
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincial_Load(object sender, EventArgs e)
        {
            recargarDatos();
        }

        public void recargarDatos()
        {
            ControladorPeliculas.cargarCartelera(dgvCartelera);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Novedad de informes
            MessageBox.Show("Hola, le sujerimos probar la nueva funcioanlidad de informes en nuestro cine, agradecemos su visita!!!", "Novedades", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            dgvCartelera.Visible = true;
            btnSeleccion.Visible = true;
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            if (dgvCartelera.SelectedRows.Count > 0)
            {
                var filaSeleccionada = dgvCartelera.SelectedRows[0];
                if (filaSeleccionada.Cells["Sala"].Value.Equals("Sin sala asignada"))
                {
                    MessageBox.Show("Debe seleccionar una pelicula que este disaponible", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int idPelicula = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                    string nombrePelicula = filaSeleccionada.Cells["Titulo"].Value.ToString();
                    Sala sala = ControladorPeliculas.listaPeliculas.First(p => p.Id == idPelicula).Sala;

                    FormAniadirEntrada form = new FormAniadirEntrada(nombrePelicula, sala);
                    this.Hide();
                    form.Show();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una película de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAniadirEntrada form = new FormAniadirEntrada();
            this.Hide();
            form.Show();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuscarEntrada form = new FormBuscarEntrada();
            this.Hide();
            form.Show();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificarEntrada form = new FormModificarEntrada();
            this.Hide();
            form.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var salida = MessageBox.Show("¿Estas seguro de que quieres salir?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salida == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensajeAcercaDe =
                    "Aplicación de Cine\n" +
                    "Versión: 1.0\n" +
                    "Desarrollador: Marcos ibañez\n" +
                    "Fecha: Enero 2025\n\n" +
                    "Gracias por utilizar mi aplicación.";

            MessageBox.Show(mensajeAcercaDe, "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pongase en contacto con el desarrollador", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormArchivosEntradasReport form = new FormArchivosEntradasReport();
            this.Hide();
            form.Show();
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormArchivosPeliculasReport form = new FormArchivosPeliculasReport();
            this.Hide();
            form.Show();
        }

        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormArchivosSalasReport form = new FormArchivosSalasReport();
            this.Hide();
            form.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormEntradasReport form = new FormEntradasReport();
            this.Hide();
            form.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormPeliculasReport form = new FormPeliculasReport();
            this.Hide();
            form.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FormSalasReport form = new FormSalasReport();
            this.Hide();
            form.Show();
        }

        private void entradasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGraficosEntradas form = new FormGraficosEntradas();
            this.Hide();
            form.Show();
        }

        private void peliculasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGraficosPeliculas form = new FormGraficosPeliculas();
            this.Hide();
            form.Show();
        }

        private void salasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGraficosSalas form = new FormGraficosSalas();
            this.Hide();
            form.Show();
        }
    }
}
