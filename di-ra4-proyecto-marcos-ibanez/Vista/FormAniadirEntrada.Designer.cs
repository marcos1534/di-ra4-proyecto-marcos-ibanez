namespace di_ra4_proyecto_marcos_ibanez.Vista
{
    partial class FormAniadirEntrada
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
            this.components = new System.ComponentModel.Container();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dtpFechyHora = new System.Windows.Forms.DateTimePicker();
            this.txtBUsuario = new System.Windows.Forms.TextBox();
            this.lblnif = new System.Windows.Forms.Label();
            this.lblFech = new System.Windows.Forms.Label();
            this.lblApe2 = new System.Windows.Forms.Label();
            this.lblApe1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btCrearEntrada = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numUDPrecio = new System.Windows.Forms.NumericUpDown();
            this.numUDButaca = new System.Windows.Forms.NumericUpDown();
            this.comboBoxSala = new System.Windows.Forms.ComboBox();
            this.comboBPeli = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copiarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDButaca)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.AccessibleDescription = "boton para volver al formulario princiapl";
            this.btnVolver.AccessibleName = "Boton Volver";
            this.btnVolver.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(481, 282);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 38);
            this.btnVolver.TabIndex = 33;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dtpFechyHora
            // 
            this.dtpFechyHora.AccessibleDescription = "Seleccionar la fecha y hora a la que quiere ir a la pelicula";
            this.dtpFechyHora.AccessibleName = "Fecha y hora de la entrada";
            this.dtpFechyHora.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpFechyHora.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechyHora.Location = new System.Drawing.Point(365, 173);
            this.dtpFechyHora.Name = "dtpFechyHora";
            this.dtpFechyHora.Size = new System.Drawing.Size(264, 26);
            this.dtpFechyHora.TabIndex = 32;
            // 
            // txtBUsuario
            // 
            this.txtBUsuario.AccessibleDescription = "Campo de texto para introducir el nombre de usuario";
            this.txtBUsuario.AccessibleName = "Campo para el usuario";
            this.txtBUsuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBUsuario.Location = new System.Drawing.Point(365, 75);
            this.txtBUsuario.Name = "txtBUsuario";
            this.txtBUsuario.Size = new System.Drawing.Size(121, 26);
            this.txtBUsuario.TabIndex = 28;
            // 
            // lblnif
            // 
            this.lblnif.AutoSize = true;
            this.lblnif.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnif.Location = new System.Drawing.Point(296, 205);
            this.lblnif.Name = "lblnif";
            this.lblnif.Size = new System.Drawing.Size(54, 19);
            this.lblnif.TabIndex = 27;
            this.lblnif.Text = "Butaca:";
            // 
            // lblFech
            // 
            this.lblFech.AutoSize = true;
            this.lblFech.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFech.Location = new System.Drawing.Point(190, 179);
            this.lblFech.Name = "lblFech";
            this.lblFech.Size = new System.Drawing.Size(173, 19);
            this.lblFech.TabIndex = 26;
            this.lblFech.Text = "Fecha y hora de la pelicula:";
            // 
            // lblApe2
            // 
            this.lblApe2.AutoSize = true;
            this.lblApe2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApe2.Location = new System.Drawing.Point(312, 145);
            this.lblApe2.Name = "lblApe2";
            this.lblApe2.Size = new System.Drawing.Size(38, 19);
            this.lblApe2.TabIndex = 25;
            this.lblApe2.Text = "Sala:";
            // 
            // lblApe1
            // 
            this.lblApe1.AutoSize = true;
            this.lblApe1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApe1.Location = new System.Drawing.Point(299, 113);
            this.lblApe1.Name = "lblApe1";
            this.lblApe1.Size = new System.Drawing.Size(58, 19);
            this.lblApe1.TabIndex = 24;
            this.lblApe1.Text = "Pelicula:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(296, 82);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 19);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Usuario:";
            // 
            // btCrearEntrada
            // 
            this.btCrearEntrada.AccessibleDescription = "boton que al clicar crea una entrada";
            this.btCrearEntrada.AccessibleName = "Boton Crear Entrada";
            this.btCrearEntrada.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCrearEntrada.Location = new System.Drawing.Point(235, 282);
            this.btCrearEntrada.Name = "btCrearEntrada";
            this.btCrearEntrada.Size = new System.Drawing.Size(100, 38);
            this.btCrearEntrada.TabIndex = 22;
            this.btCrearEntrada.Text = "Crear Entrada";
            this.btCrearEntrada.UseVisualStyleBackColor = true;
            this.btCrearEntrada.Click += new System.EventHandler(this.btCrearEntrada_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Precio:";
            // 
            // numUDPrecio
            // 
            this.numUDPrecio.AccessibleDescription = "El precio que va a tener la entrada dependiendo de la fecha y la sala";
            this.numUDPrecio.AccessibleName = "Precio de la entrada";
            this.numUDPrecio.DecimalPlaces = 2;
            this.numUDPrecio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDPrecio.Location = new System.Drawing.Point(365, 231);
            this.numUDPrecio.Name = "numUDPrecio";
            this.numUDPrecio.Size = new System.Drawing.Size(100, 26);
            this.numUDPrecio.TabIndex = 35;
            // 
            // numUDButaca
            // 
            this.numUDButaca.AccessibleDescription = "Butaca que va a ocupar en la sala que seleccione";
            this.numUDButaca.AccessibleName = "Butaca de la sala";
            this.numUDButaca.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDButaca.Location = new System.Drawing.Point(365, 203);
            this.numUDButaca.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUDButaca.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDButaca.Name = "numUDButaca";
            this.numUDButaca.Size = new System.Drawing.Size(100, 26);
            this.numUDButaca.TabIndex = 36;
            this.numUDButaca.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxSala
            // 
            this.comboBoxSala.AccessibleDescription = "Las salas que tiene disponible el cine";
            this.comboBoxSala.AccessibleName = "Salas de peliculas";
            this.comboBoxSala.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSala.FormattingEnabled = true;
            this.comboBoxSala.Location = new System.Drawing.Point(365, 137);
            this.comboBoxSala.Name = "comboBoxSala";
            this.comboBoxSala.Size = new System.Drawing.Size(100, 27);
            this.comboBoxSala.TabIndex = 37;
            // 
            // comboBPeli
            // 
            this.comboBPeli.AccessibleDescription = "Un desplegable que muestra las peliculas que estan disponibles en cartelera";
            this.comboBPeli.AccessibleName = "Desplegable de peliculas";
            this.comboBPeli.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBPeli.FormattingEnabled = true;
            this.comboBPeli.Location = new System.Drawing.Point(365, 105);
            this.comboBPeli.Name = "comboBPeli";
            this.comboBPeli.Size = new System.Drawing.Size(153, 27);
            this.comboBPeli.TabIndex = 38;
            // 
            // btnClear
            // 
            this.btnClear.AccessibleDescription = "Boton para limpiar todos los datos del fromulario";
            this.btnClear.AccessibleName = "Boton Limpiar Datos";
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(362, 282);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 38);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "Limpiar campos";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem1,
            this.cortarToolStripMenuItem1,
            this.pegarToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 98);
            // 
            // copiarToolStripMenuItem1
            // 
            this.copiarToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copiarToolStripMenuItem1.Name = "copiarToolStripMenuItem1";
            this.copiarToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.copiarToolStripMenuItem1.Text = "Copiar";
            this.copiarToolStripMenuItem1.Click += new System.EventHandler(this.copiarToolStripMenuItem1_Click);
            // 
            // cortarToolStripMenuItem1
            // 
            this.cortarToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cortarToolStripMenuItem1.Name = "cortarToolStripMenuItem1";
            this.cortarToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.cortarToolStripMenuItem1.Text = "Cortar";
            this.cortarToolStripMenuItem1.Click += new System.EventHandler(this.cortarToolStripMenuItem1_Click);
            // 
            // pegarToolStripMenuItem1
            // 
            this.pegarToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pegarToolStripMenuItem1.Name = "pegarToolStripMenuItem1";
            this.pegarToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.pegarToolStripMenuItem1.Text = "Pegar";
            this.pegarToolStripMenuItem1.Click += new System.EventHandler(this.pegarToolStripMenuItem1_Click);
            // 
            // FormAniadirEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.comboBPeli);
            this.Controls.Add(this.comboBoxSala);
            this.Controls.Add(this.numUDButaca);
            this.Controls.Add(this.numUDPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dtpFechyHora);
            this.Controls.Add(this.txtBUsuario);
            this.Controls.Add(this.lblnif);
            this.Controls.Add(this.lblFech);
            this.Controls.Add(this.lblApe2);
            this.Controls.Add(this.lblApe1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btCrearEntrada);
            this.Name = "FormAniadirEntrada";
            this.Text = "FormAniadirEntrada";
            this.Load += new System.EventHandler(this.FormAniadirEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDButaca)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DateTimePicker dtpFechyHora;
        private System.Windows.Forms.TextBox txtBUsuario;
        private System.Windows.Forms.Label lblnif;
        private System.Windows.Forms.Label lblFech;
        private System.Windows.Forms.Label lblApe2;
        private System.Windows.Forms.Label lblApe1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btCrearEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUDPrecio;
        private System.Windows.Forms.NumericUpDown numUDButaca;
        private System.Windows.Forms.ComboBox comboBoxSala;
        private System.Windows.Forms.ComboBox comboBPeli;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem1;
    }
}