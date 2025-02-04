using di_ra4_proyecto_marcos_ibanez.Controlador;
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
    public partial class FormArchivosPeliculasReport : Form
    {
        public FormArchivosPeliculasReport()
        {
            InitializeComponent();
        }

        private void FormPeliculasReport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "ReportArchivosPeliculas.rdlc";

            ReportDataSource source = new ReportDataSource("DataSet2", ControladorPeliculas.listaPeliculas);

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

        private void btnEscribirJson_Click(object sender, EventArgs e)
        {
            Controlador.DAO.PeliculaDAOJson.escribirJson(ControladorPeliculas.listaPeliculas);
            MessageBox.Show("Se guardaron los datos correctamente en /bin/Debug/peliculas.json", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLeerJson_Click(object sender, EventArgs e)
        {
            Controlador.DAO.PeliculaDAOJson.leerJson(ControladorPeliculas.listaPeliculasAux);

            ReportDataSource source = new ReportDataSource("DataSet2", ControladorPeliculas.listaPeliculasAux);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();

            MessageBox.Show("Datos actualizados desde peliculasLeer.json", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEscribirXml_Click(object sender, EventArgs e)
        {
            Controlador.DAO.PeliculaDAOXml.escribirXml(ControladorPeliculas.listaPeliculas);
            MessageBox.Show("Se guardaron los datos correctamente en /bin/Debug/peliculas.xml", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLeerXml_Click(object sender, EventArgs e)
        {
            Controlador.DAO.PeliculaDAOXml.leerXml(ControladorPeliculas.listaPeliculasAux);

            ReportDataSource source = new ReportDataSource("DataSet2", ControladorPeliculas.listaPeliculasAux);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
            MessageBox.Show("Datos actualizados desde peliculasLeer.xml", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
