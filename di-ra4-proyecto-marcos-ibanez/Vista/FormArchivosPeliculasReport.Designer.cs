namespace di_ra4_proyecto_marcos_ibanez.Vista
{
    partial class FormArchivosPeliculasReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnLeerXml = new System.Windows.Forms.Button();
            this.btnLeerJson = new System.Windows.Forms.Button();
            this.btnEscribirXml = new System.Windows.Forms.Button();
            this.btnEscribirJson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1104, 641);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(965, 478);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(107, 52);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnLeerXml
            // 
            this.btnLeerXml.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeerXml.Location = new System.Drawing.Point(965, 371);
            this.btnLeerXml.Name = "btnLeerXml";
            this.btnLeerXml.Size = new System.Drawing.Size(107, 52);
            this.btnLeerXml.TabIndex = 9;
            this.btnLeerXml.Text = "Leer XML";
            this.btnLeerXml.UseVisualStyleBackColor = true;
            this.btnLeerXml.Click += new System.EventHandler(this.btnLeerXml_Click);
            // 
            // btnLeerJson
            // 
            this.btnLeerJson.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeerJson.Location = new System.Drawing.Point(965, 222);
            this.btnLeerJson.Name = "btnLeerJson";
            this.btnLeerJson.Size = new System.Drawing.Size(107, 52);
            this.btnLeerJson.TabIndex = 7;
            this.btnLeerJson.Text = "Leer Json";
            this.btnLeerJson.UseVisualStyleBackColor = true;
            this.btnLeerJson.Click += new System.EventHandler(this.btnLeerJson_Click);
            // 
            // btnEscribirXml
            // 
            this.btnEscribirXml.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscribirXml.Location = new System.Drawing.Point(965, 296);
            this.btnEscribirXml.Name = "btnEscribirXml";
            this.btnEscribirXml.Size = new System.Drawing.Size(107, 52);
            this.btnEscribirXml.TabIndex = 11;
            this.btnEscribirXml.Text = "Guardar XML";
            this.btnEscribirXml.UseVisualStyleBackColor = true;
            this.btnEscribirXml.Click += new System.EventHandler(this.btnEscribirXml_Click);
            // 
            // btnEscribirJson
            // 
            this.btnEscribirJson.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscribirJson.Location = new System.Drawing.Point(965, 152);
            this.btnEscribirJson.Name = "btnEscribirJson";
            this.btnEscribirJson.Size = new System.Drawing.Size(107, 52);
            this.btnEscribirJson.TabIndex = 10;
            this.btnEscribirJson.Text = "Guardar JSON";
            this.btnEscribirJson.UseVisualStyleBackColor = true;
            this.btnEscribirJson.Click += new System.EventHandler(this.btnEscribirJson_Click);
            // 
            // FormArchivosPeliculasReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 641);
            this.Controls.Add(this.btnEscribirXml);
            this.Controls.Add(this.btnEscribirJson);
            this.Controls.Add(this.btnLeerXml);
            this.Controls.Add(this.btnLeerJson);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormArchivosPeliculasReport";
            this.Text = "FormPeliculasReport";
            this.Load += new System.EventHandler(this.FormPeliculasReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnLeerXml;
        private System.Windows.Forms.Button btnLeerJson;
        private System.Windows.Forms.Button btnEscribirXml;
        private System.Windows.Forms.Button btnEscribirJson;
    }
}