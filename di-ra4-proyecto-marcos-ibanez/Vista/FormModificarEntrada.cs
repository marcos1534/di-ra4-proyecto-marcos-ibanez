using di_ra4_proyecto_marcos_ibanez.Controlador;
using di_ra4_proyecto_marcos_ibanez.Modelo;
using ra4_sesión_1_menús.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace di_ra4_proyecto_marcos_ibanez.Vista
{
    public partial class FormModificarEntrada : Form
    {
        public FormModificarEntrada()
        {
            InitializeComponent();
        }
        private void FormModificarEntrada_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true; // El DataGridView es de solo lectura por defecto
            ActualizarListaEntradas();

            // Suscribirse al evento CellEndEdit para guardar cambios
            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;
        }

        private void ActualizarListaEntradas()
        {
            dataGridView1.Rows.Clear(); // Limpiar el DataGridView

            if (ControladorEntradas.listaEntradas == null || ControladorEntradas.listaEntradas.Count == 0)
            {
                MessageBox.Show("No hay entradas para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var item in ControladorEntradas.listaEntradas)
            {
                string peliculaTitulo = item.Pelicula != null ? item.Pelicula.Titulo : "Sin título";
                string salaTexto = item.Sala != null ? $"Sala {item.Sala.NumeroSala}" : "Sin sala";

                dataGridView1.Rows.Add(
                    item.CodigoEntrada,
                    item.Usuario,
                    peliculaTitulo,
                    salaTexto,
                    item.FechaYHora.ToString("g"),
                    item.Butaca,
                    item.Precio.ToString("F2")
                );
            }
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0 && rowIndex < ControladorEntradas.listaEntradas.Count)
            {
                var entrada = ControladorEntradas.listaEntradas[rowIndex];
                var columna = dataGridView1.Columns[e.ColumnIndex].Name;

                if (columna == "FechaYHora")
                {
                    // Intentar convertir la nueva fecha
                    if (DateTime.TryParse(dataGridView1.Rows[rowIndex].Cells["FechaYHora"].Value.ToString(), out DateTime nuevaFecha))
                    {
                        entrada.FechaYHora = nuevaFecha;
                    }
                    else
                    {
                        MessageBox.Show("Fecha no válida. No se ha guardado el cambio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ActualizarListaEntradas(); // Restablecer la fila
                    }
                }
                else if (columna == "Butaca")
                {
                    // Intentar convertir la butaca a entero
                    if (int.TryParse(dataGridView1.Rows[rowIndex].Cells["Butaca"].Value.ToString(), out int nuevaButaca))
                    {
                        // Verificar unicidad de la butaca para la misma película
                        if (!ButacaEsUnica(entrada.Pelicula, nuevaButaca, entrada.CodigoEntrada))
                        {
                            MessageBox.Show("La butaca ya está ocupada para esta película. No se ha guardado el cambio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            ActualizarListaEntradas(); // Restablecer la fila
                        }
                        else
                        {
                            entrada.Butaca = nuevaButaca;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El valor de la butaca no es válido. Ingrese un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ActualizarListaEntradas(); // Restablecer la fila
                    }
                }
            }
        }

        private bool ButacaEsUnica(Pelicula pelicula, int nuevaButaca, int codigoEntrada)
        {
            return !ControladorEntradas.listaEntradas.Any(e =>
                e.Pelicula == pelicula &&
                e.Butaca == nuevaButaca &&
                e.CodigoEntrada != codigoEntrada);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Modo edición activado", "Modo Edición", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.ReadOnly = false;

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    if (column.Name == "FechaYHora" || column.Name == "Butaca")
                        column.ReadOnly = false;
                    else
                        column.ReadOnly = true;
                }
            }
            else
            {
                MessageBox.Show("Modo edición desactivado", "Modo Edición", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.ReadOnly = true;
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                if (rowIndex >= 0 && rowIndex < ControladorEntradas.listaEntradas.Count)
                {
                    var entradaSeleccionada = ControladorEntradas.listaEntradas[rowIndex];

                    var confirmacion = MessageBox.Show(
                        $"¿Está seguro de que desea eliminar la entrada con código: {entradaSeleccionada.CodigoEntrada}?",
                        "Confirmación de Eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (confirmacion == DialogResult.Yes)
                    {
                        bool exito = ControladorEntradas.eliminarEntrada(entradaSeleccionada.CodigoEntrada);
                        if (exito)
                        {
                            MessageBox.Show("La entrada se ha eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ActualizarListaEntradas();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar la entrada. Inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una entrada para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
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

        private void FormModificarEntrada_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item is FormPrincipal)
                {
                    item.BringToFront();
                    item.Show();
                }
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