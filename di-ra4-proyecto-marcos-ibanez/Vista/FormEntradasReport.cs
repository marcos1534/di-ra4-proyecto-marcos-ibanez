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

namespace di_ra4_proyecto_marcos_ibanez.Vista
{
    public partial class FormEntradasReport : Form
    {
        private static List<Entrada> auxiliar = new List<Entrada>();
        public FormEntradasReport()
        {
            InitializeComponent();
            Controlador.DAO.EntradaDAOJson.leerJson(auxiliar);
        }

        private void FormEntradasReport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "ReportEntradas.rdlc";

            ReportDataSource source = new ReportDataSource("DataSet1", auxiliar = (auxiliar == null) ? ControladorEntradas.listaEntradas : auxiliar);

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

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            var entradasFiltradas = ControladorEntradas.listaEntradas.Where(entrada => entrada.Precio > (double)numUpDownPrecio.Value);

            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", entradasFiltradas));
            reportViewer1.RefreshReport();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ReportDataSource source = new ReportDataSource("DataSet1", ControladorEntradas.listaEntradas);

            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }
    }
}
