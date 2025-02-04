using di_ra4_proyecto_marcos_ibanez.Controlador;
using di_ra4_proyecto_marcos_ibanez.Modelo;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace di_ra4_proyecto_marcos_ibanez.Vista
{
    public partial class FormSalasReport : Form
    {
        private static List<Sala> auxiliar = new List<Sala>();
        public FormSalasReport()
        {
            InitializeComponent();
            CargarSalas();
            Controlador.DAO.SalaDAOJson.leerJson(auxiliar);
        }

        private void CargarSalas()
        {
            comboBoxTipo.Items.Clear();
            comboBoxTipo.Items.AddRange(ControladorSalas.listaSalas
                .Select(s => s.TipoSala)
                .Distinct()
                .ToArray());
        }

        private void FormSalasReport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "ReportSalas.rdlc";

            ReportDataSource source = new ReportDataSource("DataSet3", auxiliar = (auxiliar == null) ? ControladorSalas.listaSalas : auxiliar);

            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            var salasFiltradas = ControladorSalas.listaSalas.Where(s => s.TipoSala == comboBoxTipo.Text).ToList();

            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet3", salasFiltradas));
            reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportDataSource source = new ReportDataSource("DataSet3", ControladorSalas.listaSalas);

            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }
    }
}
