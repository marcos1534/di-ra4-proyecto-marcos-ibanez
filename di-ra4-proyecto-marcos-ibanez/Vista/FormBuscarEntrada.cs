using di_ra4_proyecto_marcos_ibanez.Controlador;
using di_ra4_proyecto_marcos_ibanez.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace di_ra4_proyecto_marcos_ibanez.Vista
{
    public partial class FormBuscarEntrada : Form
    {
        private BindingSource bindingSource = new BindingSource();

        public FormBuscarEntrada()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBusqueda.Text))
            {
                MessageBox.Show("Debe ingresar un ID para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(txtBusqueda.Text, out int id))
            {
                // Busca la entrada con el ID proporcionado.
                Entrada entradaBuscada = ControladorEntradas.buscarEntrada(id);

                if (entradaBuscada != null)
                {
                    // Actualiza el BindingSource para mostrar solo la entrada encontrada.
                    bindingSource.DataSource = new List<Entrada> { entradaBuscada };
                    bindingSource.ResetBindings(false);
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna entrada con el código de entrada proporcionado.",
                                    "Información de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("El código de entrada debe ser un número válido.", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Clear();
            bindingSource.DataSource = ControladorEntradas.ObtenerEntradas(); // Restaura la lista completa.
            bindingSource.ResetBindings(false);
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

        private void FormBuscarEntrada_Load(object sender, EventArgs e)
        {
            // Inicializa el BindingSource con todas las entradas.
            bindingSource.DataSource = ControladorEntradas.ObtenerEntradas();
            dataGridView1.DataSource = bindingSource;

            // Configuración de columnas.
            ConfigurarColumnasDataGridView();
        }

        private void ConfigurarColumnasDataGridView()
        {
            if (dataGridView1.Columns.Count > 0)
            {
                // Mostrar encabezados personalizados
                dataGridView1.Columns["CodigoEntrada"].HeaderText = "Código Entrada";
                dataGridView1.Columns["Usuario"].HeaderText = "Usuario";
                dataGridView1.Columns["FechaYHora"].HeaderText = "Fecha y Hora";
                dataGridView1.Columns["Butaca"].HeaderText = "Butaca";
                dataGridView1.Columns["Precio"].HeaderText = "Precio";

                // Configurar columnas calculadas
                if (!dataGridView1.Columns.Contains("PeliculaTitulo"))
                {
                    DataGridViewTextBoxColumn columnaPelicula = new DataGridViewTextBoxColumn
                    {
                        Name = "PeliculaTitulo",
                        HeaderText = "Película",
                        ReadOnly = true
                    };
                    dataGridView1.Columns.Add(columnaPelicula);
                }

                if (!dataGridView1.Columns.Contains("SalaDescripcion"))
                {
                    DataGridViewTextBoxColumn columnaSala = new DataGridViewTextBoxColumn
                    {
                        Name = "SalaDescripcion",
                        HeaderText = "Sala",
                        ReadOnly = true
                    };
                    dataGridView1.Columns.Add(columnaSala);
                }

                // Ocultar columnas de tipo objeto
                if (dataGridView1.Columns.Contains("Pelicula"))
                    dataGridView1.Columns["Pelicula"].Visible = false;

                if (dataGridView1.Columns.Contains("Sala"))
                    dataGridView1.Columns["Sala"].Visible = false;

                // Rellenar las columnas calculadas con datos
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    var entrada = row.DataBoundItem as Entrada;
                    if (entrada != null)
                    {
                        row.Cells["PeliculaTitulo"].Value = entrada.PeliculaTitulo;
                        row.Cells["SalaDescripcion"].Value = entrada.SalaDescripcion;
                    }
                }

                // Configurar columnas no editables
                dataGridView1.Columns["CodigoEntrada"].ReadOnly = true;
                dataGridView1.Columns["Usuario"].ReadOnly = true;
                dataGridView1.Columns["FechaYHora"].ReadOnly = true;
                dataGridView1.Columns["Butaca"].ReadOnly = true;
                dataGridView1.Columns["Precio"].ReadOnly = true;
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
    }
}
