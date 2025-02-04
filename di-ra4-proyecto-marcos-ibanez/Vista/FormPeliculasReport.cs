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
    public partial class FormPeliculasReport : Form
    {
        private static List<Pelicula> auxiliar = new List<Pelicula>();
        public FormPeliculasReport()
        {
            InitializeComponent();
            Controlador.DAO.PeliculaDAOJson.leerJson(auxiliar);
        }

        private void FormPeliculasReport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "ReportPeliculas.rdlc";

            ReportDataSource source = new ReportDataSource("DataSet2", auxiliar = (auxiliar == null) ? ControladorPeliculas.listaPeliculas : auxiliar);

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
            var peliculasFiltradas = ControladorPeliculas.listaPeliculas.Where(p => p.Titulo == textBox1.Text);

            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", peliculasFiltradas));
            reportViewer1.RefreshReport();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ReportDataSource source = new ReportDataSource("DataSet2", ControladorPeliculas.listaPeliculas);

            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }
    }
}
