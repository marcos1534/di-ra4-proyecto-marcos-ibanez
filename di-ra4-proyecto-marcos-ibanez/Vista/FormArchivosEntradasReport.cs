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
    public partial class FormArchivosEntradasReport : Form
    {
        public FormArchivosEntradasReport()
        {
            InitializeComponent();
        }

        private void FormEntradasReport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "ReportArchivosEntradas.rdlc";

            ReportDataSource source = new ReportDataSource("DataSet1", ControladorEntradas.listaEntradas);

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
            Controlador.DAO.EntradaDAOJson.escribirJson(ControladorEntradas.listaEntradas);
            MessageBox.Show("Se guardaron los datos correctamente en /bin/Debug/entradas.json", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLeerJson_Click(object sender, EventArgs e)
        {
            Controlador.DAO.EntradaDAOJson.leerJson(ControladorEntradas.listaEntradasAux);

            ReportDataSource source = new ReportDataSource("DataSet1", ControladorEntradas.listaEntradasAux);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();

            MessageBox.Show("Datos actualizados desde entradasLeer.json", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEscribirXml_Click(object sender, EventArgs e)
        {
            Controlador.DAO.EntradaDAOXml.escribirXml(ControladorEntradas.listaEntradas);
            MessageBox.Show("Se guardaron los datos correctamente en /bin/Debug/entradas.xml", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLeerXml_Click(object sender, EventArgs e)
        {
            Controlador.DAO.EntradaDAOXml.leerXml(ControladorEntradas.listaEntradasAux);

            ReportDataSource source = new ReportDataSource("DataSet1", ControladorEntradas.listaEntradasAux);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
            MessageBox.Show("Datos actualizados desde entradasLeer.xml", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
