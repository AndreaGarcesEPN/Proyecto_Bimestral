namespace menu
{
    partial class EditarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarEmpleado));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEditarEmpleado = new System.Windows.Forms.Button();
            this.txbEditarcedula = new System.Windows.Forms.TextBox();
            this.txbEditarNombres = new System.Windows.Forms.TextBox();
            this.txbEditarApellidos = new System.Windows.Forms.TextBox();
            this.txbEditarTelfCelular = new System.Windows.Forms.TextBox();
            this.txbEditarTelfConvencional = new System.Windows.Forms.TextBox();
            this.txbEditarDireccionDomicilio = new System.Windows.Forms.TextBox();
            this.btnCancelarIngresoEmpleado = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDiaEditar = new System.Windows.Forms.ComboBox();
            this.cmbMesEditar = new System.Windows.Forms.ComboBox();
            this.cmbAnioEditar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cédula :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(40, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(40, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(40, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telf. Celular :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(40, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telf. Convencional :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(40, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dirección Domicilio :";
            // 
            // btnEditarEmpleado
            // 
            this.btnEditarEmpleado.Location = new System.Drawing.Point(125, 251);
            this.btnEditarEmpleado.Name = "btnEditarEmpleado";
            this.btnEditarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnEditarEmpleado.TabIndex = 9;
            this.btnEditarEmpleado.Text = "Editar empleado";
            this.btnEditarEmpleado.UseVisualStyleBackColor = true;
            this.btnEditarEmpleado.Click += new System.EventHandler(this.BtnEditarEmpleado_Click_1);
            // 
            // txbEditarcedula
            // 
            this.txbEditarcedula.Location = new System.Drawing.Point(181, 45);
            this.txbEditarcedula.MaxLength = 10;
            this.txbEditarcedula.Name = "txbEditarcedula";
            this.txbEditarcedula.Size = new System.Drawing.Size(212, 20);
            this.txbEditarcedula.TabIndex = 0;
            this.txbEditarcedula.Tag = "";
            // 
            // txbEditarNombres
            // 
            this.txbEditarNombres.Location = new System.Drawing.Point(181, 71);
            this.txbEditarNombres.Name = "txbEditarNombres";
            this.txbEditarNombres.Size = new System.Drawing.Size(212, 20);
            this.txbEditarNombres.TabIndex = 1;
            // 
            // txbEditarApellidos
            // 
            this.txbEditarApellidos.Location = new System.Drawing.Point(181, 97);
            this.txbEditarApellidos.Name = "txbEditarApellidos";
            this.txbEditarApellidos.Size = new System.Drawing.Size(212, 20);
            this.txbEditarApellidos.TabIndex = 2;
            // 
            // txbEditarTelfCelular
            // 
            this.txbEditarTelfCelular.Location = new System.Drawing.Point(181, 123);
            this.txbEditarTelfCelular.Name = "txbEditarTelfCelular";
            this.txbEditarTelfCelular.Size = new System.Drawing.Size(212, 20);
            this.txbEditarTelfCelular.TabIndex = 3;
            // 
            // txbEditarTelfConvencional
            // 
            this.txbEditarTelfConvencional.Location = new System.Drawing.Point(181, 149);
            this.txbEditarTelfConvencional.Name = "txbEditarTelfConvencional";
            this.txbEditarTelfConvencional.Size = new System.Drawing.Size(212, 20);
            this.txbEditarTelfConvencional.TabIndex = 4;
            // 
            // txbEditarDireccionDomicilio
            // 
            this.txbEditarDireccionDomicilio.Location = new System.Drawing.Point(181, 175);
            this.txbEditarDireccionDomicilio.Name = "txbEditarDireccionDomicilio";
            this.txbEditarDireccionDomicilio.Size = new System.Drawing.Size(212, 20);
            this.txbEditarDireccionDomicilio.TabIndex = 5;
            // 
            // btnCancelarIngresoEmpleado
            // 
            this.btnCancelarIngresoEmpleado.Location = new System.Drawing.Point(262, 251);
            this.btnCancelarIngresoEmpleado.Name = "btnCancelarIngresoEmpleado";
            this.btnCancelarIngresoEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarIngresoEmpleado.TabIndex = 10;
            this.btnCancelarIngresoEmpleado.Text = "Cancelar";
            this.btnCancelarIngresoEmpleado.UseVisualStyleBackColor = true;
            this.btnCancelarIngresoEmpleado.Click += new System.EventHandler(this.BtnCancelarIngresoEmpleado_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(40, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha Nacimiento :";
            // 
            // cmbDiaEditar
            // 
            this.cmbDiaEditar.FormattingEnabled = true;
            this.cmbDiaEditar.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbDiaEditar.Location = new System.Drawing.Point(181, 205);
            this.cmbDiaEditar.Name = "cmbDiaEditar";
            this.cmbDiaEditar.Size = new System.Drawing.Size(50, 21);
            this.cmbDiaEditar.TabIndex = 6;
            // 
            // cmbMesEditar
            // 
            this.cmbMesEditar.FormattingEnabled = true;
            this.cmbMesEditar.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbMesEditar.Location = new System.Drawing.Point(237, 205);
            this.cmbMesEditar.Name = "cmbMesEditar";
            this.cmbMesEditar.Size = new System.Drawing.Size(100, 21);
            this.cmbMesEditar.TabIndex = 7;
            // 
            // cmbAnioEditar
            // 
            this.cmbAnioEditar.FormattingEnabled = true;
            this.cmbAnioEditar.Items.AddRange(new object[] {
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "19891",
            "1988",
            "19871",
            "986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960"});
            this.cmbAnioEditar.Location = new System.Drawing.Point(343, 205);
            this.cmbAnioEditar.Name = "cmbAnioEditar";
            this.cmbAnioEditar.Size = new System.Drawing.Size(50, 21);
            this.cmbAnioEditar.TabIndex = 8;
            // 
            // EditarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(444, 320);
            this.Controls.Add(this.cmbAnioEditar);
            this.Controls.Add(this.cmbMesEditar);
            this.Controls.Add(this.cmbDiaEditar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancelarIngresoEmpleado);
            this.Controls.Add(this.txbEditarDireccionDomicilio);
            this.Controls.Add(this.txbEditarTelfConvencional);
            this.Controls.Add(this.txbEditarTelfCelular);
            this.Controls.Add(this.txbEditarApellidos);
            this.Controls.Add(this.txbEditarNombres);
            this.Controls.Add(this.txbEditarcedula);
            this.Controls.Add(this.btnEditarEmpleado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditarEmpleado";
            this.Text = "INGRESO_DE_EMPLEADO";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditarEmpleado;
        private System.Windows.Forms.TextBox txbEditarcedula;
        private System.Windows.Forms.TextBox txbEditarNombres;
        private System.Windows.Forms.TextBox txbEditarApellidos;
        private System.Windows.Forms.TextBox txbEditarTelfCelular;
        private System.Windows.Forms.TextBox txbEditarTelfConvencional;
        private System.Windows.Forms.TextBox txbEditarDireccionDomicilio;
        private System.Windows.Forms.Button btnCancelarIngresoEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDiaEditar;
        private System.Windows.Forms.ComboBox cmbMesEditar;
        private System.Windows.Forms.ComboBox cmbAnioEditar;
    }
}