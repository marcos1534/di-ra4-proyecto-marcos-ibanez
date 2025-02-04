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
    public partial class FormGraficosSalas : Form
    {
        private static List<Sala> auxiliar = new List<Sala>();
        public FormGraficosSalas()
        {
            InitializeComponent();
            Controlador.DAO.SalaDAOXml.leerXml(auxiliar);
        }

        private void FormGraficosSalas_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "ReportGraficosSalas.rdlc";

            ReportDataSource source = new ReportDataSource("DataSet3", auxiliar);

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
    }
}
