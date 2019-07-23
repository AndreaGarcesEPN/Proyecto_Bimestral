namespace menu
{
    partial class ConsultaDeEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaDeEmpleado));
            this.label1 = new System.Windows.Forms.Label();
            this.txbConsultaCedula = new System.Windows.Forms.TextBox();
            this.dvgConsulta = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultarEmpleado = new System.Windows.Forms.Button();
            this.bntNuevaConsulta = new System.Windows.Forms.Button();
            this.btnCancelarConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(36, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula de Identidad:";
            // 
            // txbConsultaCedula
            // 
            this.txbConsultaCedula.Location = new System.Drawing.Point(158, 70);
            this.txbConsultaCedula.Name = "txbConsultaCedula";
            this.txbConsultaCedula.Size = new System.Drawing.Size(100, 20);
            this.txbConsultaCedula.TabIndex = 1;
            // 
            // dvgConsulta
            // 
            this.dvgConsulta.AllowUserToAddRows = false;
            this.dvgConsulta.AllowUserToDeleteRows = false;
            this.dvgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Detalle});
            this.dvgConsulta.Location = new System.Drawing.Point(12, 96);
            this.dvgConsulta.Name = "dvgConsulta";
            this.dvgConsulta.ReadOnly = true;
            this.dvgConsulta.Size = new System.Drawing.Size(556, 150);
            this.dvgConsulta.TabIndex = 2;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "TIPO";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalles";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            // 
            // btnConsultarEmpleado
            // 
            this.btnConsultarEmpleado.Location = new System.Drawing.Point(66, 273);
            this.btnConsultarEmpleado.Name = "btnConsultarEmpleado";
            this.btnConsultarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarEmpleado.TabIndex = 3;
            this.btnConsultarEmpleado.Text = "Consultar";
            this.btnConsultarEmpleado.UseVisualStyleBackColor = true;
            this.btnConsultarEmpleado.Click += new System.EventHandler(this.btnConsultarEmpleado_Click);
            // 
            // bntNuevaConsulta
            // 
            this.bntNuevaConsulta.Location = new System.Drawing.Point(158, 273);
            this.bntNuevaConsulta.Name = "bntNuevaConsulta";
            this.bntNuevaConsulta.Size = new System.Drawing.Size(133, 23);
            this.bntNuevaConsulta.TabIndex = 4;
            this.bntNuevaConsulta.Text = "Nueva Consulta";
            this.bntNuevaConsulta.UseVisualStyleBackColor = true;
            // 
            // btnCancelarConsulta
            // 
            this.btnCancelarConsulta.Location = new System.Drawing.Point(437, 313);
            this.btnCancelarConsulta.Name = "btnCancelarConsulta";
            this.btnCancelarConsulta.Size = new System.Drawing.Size(141, 23);
            this.btnCancelarConsulta.TabIndex = 5;
            this.btnCancelarConsulta.Text = "cancelar";
            this.btnCancelarConsulta.UseVisualStyleBackColor = true;
            this.btnCancelarConsulta.Click += new System.EventHandler(this.BtnCancelarConsulta_Click);
            // 
            // ConsultaDeEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 348);
            this.Controls.Add(this.btnCancelarConsulta);
            this.Controls.Add(this.bntNuevaConsulta);
            this.Controls.Add(this.btnConsultarEmpleado);
            this.Controls.Add(this.dvgConsulta);
            this.Controls.Add(this.txbConsultaCedula);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ConsultaDeEmpleado";
            this.Text = "ConsultaDeEmpleado";
            this.Load += new System.EventHandler(this.ConsultaDeEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbConsultaCedula;
        private System.Windows.Forms.DataGridView dvgConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.Button btnConsultarEmpleado;
        private System.Windows.Forms.Button bntNuevaConsulta;
        private System.Windows.Forms.Button btnCancelarConsulta;
    }
}