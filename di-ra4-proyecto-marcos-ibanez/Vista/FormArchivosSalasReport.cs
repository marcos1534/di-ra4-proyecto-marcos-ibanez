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
    public partial class FormArchivosSalasReport : Form
    {
        public FormArchivosSalasReport()
        {
            InitializeComponent();
        }

        private void FormSalasReport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "ReportArchivosSalas.rdlc";

            ReportDataSource source = new ReportDataSource("DataSet3", ControladorSalas.listaSalas);

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
            Controlador.DAO.SalaDAOJson.escribirJson(ControladorSalas.listaSalas);
            MessageBox.Show("Se guardaron los datos correctamente en /bin/Debug/salas.json", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLeerJson_Click(object sender, EventArgs e)
        {
            Controlador.DAO.SalaDAOJson.leerJson(ControladorSalas.listaSalaAux);

            ReportDataSource source = new ReportDataSource("DataSet3", ControladorSalas.listaSalaAux);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();

            MessageBox.Show("Datos actualizados desde salasLeer.json", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEscribirXml_Click(object sender, EventArgs e)
        {
            Controlador.DAO.SalaDAOXml.escribirXml(ControladorSalas.listaSalas);
            MessageBox.Show("Se guardaron los datos correctamente en /bin/Debug/salas.xml", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLeerXml_Click(object sender, EventArgs e)
        {
            Controlador.DAO.SalaDAOXml.leerXml(ControladorSalas.listaSalaAux);

            ReportDataSource source = new ReportDataSource("DataSet3", ControladorSalas.listaSalaAux);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
            MessageBox.Show("Datos actualizados desde salasLeer.xml", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
