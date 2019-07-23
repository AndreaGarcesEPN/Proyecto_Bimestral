namespace menu
{
    partial class INGRESO_DE_EMPLEADO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INGRESO_DE_EMPLEADO));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.txbIngresocedula = new System.Windows.Forms.TextBox();
            this.txbIngresoNombres = new System.Windows.Forms.TextBox();
            this.txbIngresoApellidos = new System.Windows.Forms.TextBox();
            this.txbIngresoTelfCelular = new System.Windows.Forms.TextBox();
            this.txbIngresoTelfConvencional = new System.Windows.Forms.TextBox();
            this.txbIngresoDireccionDomicilio = new System.Windows.Forms.TextBox();
            this.btnCancelarIngresoEmpleado = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
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
            this.label2.Click += new System.EventHandler(this.Label2_Click);
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
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(125, 251);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEmpleado.TabIndex = 9;
            this.btnAgregarEmpleado.Text = "Agregar";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // txbIngresocedula
            // 
            this.txbIngresocedula.Location = new System.Drawing.Point(181, 45);
            this.txbIngresocedula.MaxLength = 10;
            this.txbIngresocedula.Name = "txbIngresocedula";
            this.txbIngresocedula.Size = new System.Drawing.Size(212, 20);
            this.txbIngresocedula.TabIndex = 0;
            this.txbIngresocedula.Tag = "";
            // 
            // txbIngresoNombres
            // 
            this.txbIngresoNombres.Location = new System.Drawing.Point(181, 71);
            this.txbIngresoNombres.Name = "txbIngresoNombres";
            this.txbIngresoNombres.Size = new System.Drawing.Size(212, 20);
            this.txbIngresoNombres.TabIndex = 1;
            // 
            // txbIngresoApellidos
            // 
            this.txbIngresoApellidos.Location = new System.Drawing.Point(181, 97);
            this.txbIngresoApellidos.Name = "txbIngresoApellidos";
            this.txbIngresoApellidos.Size = new System.Drawing.Size(212, 20);
            this.txbIngresoApellidos.TabIndex = 2;
            // 
            // txbIngresoTelfCelular
            // 
            this.txbIngresoTelfCelular.Location = new System.Drawing.Point(181, 123);
            this.txbIngresoTelfCelular.Name = "txbIngresoTelfCelular";
            this.txbIngresoTelfCelular.Size = new System.Drawing.Size(212, 20);
            this.txbIngresoTelfCelular.TabIndex = 3;
            // 
            // txbIngresoTelfConvencional
            // 
            this.txbIngresoTelfConvencional.Location = new System.Drawing.Point(181, 149);
            this.txbIngresoTelfConvencional.Name = "txbIngresoTelfConvencional";
            this.txbIngresoTelfConvencional.Size = new System.Drawing.Size(212, 20);
            this.txbIngresoTelfConvencional.TabIndex = 4;
            this.txbIngresoTelfConvencional.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // txbIngresoDireccionDomicilio
            // 
            this.txbIngresoDireccionDomicilio.Location = new System.Drawing.Point(181, 175);
            this.txbIngresoDireccionDomicilio.Name = "txbIngresoDireccionDomicilio";
            this.txbIngresoDireccionDomicilio.Size = new System.Drawing.Size(212, 20);
            this.txbIngresoDireccionDomicilio.TabIndex = 5;
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
            // cmbDia
            // 
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Items.AddRange(new object[] {
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
            this.cmbDia.Location = new System.Drawing.Point(181, 205);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(50, 21);
            this.cmbDia.TabIndex = 6;
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
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
            this.cmbMes.Location = new System.Drawing.Point(237, 205);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(100, 21);
            this.cmbMes.TabIndex = 7;
            // 
            // cmbAnio
            // 
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Items.AddRange(new object[] {
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
            this.cmbAnio.Location = new System.Drawing.Point(343, 205);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(50, 21);
            this.cmbAnio.TabIndex = 8;
            // 
            // INGRESO_DE_EMPLEADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(444, 320);
            this.Controls.Add(this.cmbAnio);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.cmbDia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancelarIngresoEmpleado);
            this.Controls.Add(this.txbIngresoDireccionDomicilio);
            this.Controls.Add(this.txbIngresoTelfConvencional);
            this.Controls.Add(this.txbIngresoTelfCelular);
            this.Controls.Add(this.txbIngresoApellidos);
            this.Controls.Add(this.txbIngresoNombres);
            this.Controls.Add(this.txbIngresocedula);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "INGRESO_DE_EMPLEADO";
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
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.TextBox txbIngresocedula;
        private System.Windows.Forms.TextBox txbIngresoNombres;
        private System.Windows.Forms.TextBox txbIngresoApellidos;
        private System.Windows.Forms.TextBox txbIngresoTelfCelular;
        private System.Windows.Forms.TextBox txbIngresoTelfConvencional;
        private System.Windows.Forms.TextBox txbIngresoDireccionDomicilio;
        private System.Windows.Forms.Button btnCancelarIngresoEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmbAnio;
    }
}