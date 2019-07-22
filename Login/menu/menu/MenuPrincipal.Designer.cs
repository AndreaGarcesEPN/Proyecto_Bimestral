namespace menu
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnIngresoEmpleado;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnModificarEmpleado = new System.Windows.Forms.Button();
            this.btnConsultalEmpleado = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            btnIngresoEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresoEmpleado
            // 
            btnIngresoEmpleado.BackColor = System.Drawing.Color.Transparent;
            btnIngresoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnIngresoEmpleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnIngresoEmpleado.Location = new System.Drawing.Point(62, 74);
            btnIngresoEmpleado.Name = "btnIngresoEmpleado";
            btnIngresoEmpleado.Size = new System.Drawing.Size(173, 23);
            btnIngresoEmpleado.TabIndex = 0;
            btnIngresoEmpleado.Text = "INGRESAR EMPLEADO";
            btnIngresoEmpleado.UseVisualStyleBackColor = false;
            btnIngresoEmpleado.Click += new System.EventHandler(this.BtnIngresoEmpleado_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEmpleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(62, 149);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(173, 23);
            this.btnEliminarEmpleado.TabIndex = 1;
            this.btnEliminarEmpleado.Text = "ELIMINAR EMPLEADO";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = false;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.BtnEliminarEmpleado_Click);
            // 
            // btnModificarEmpleado
            // 
            this.btnModificarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarEmpleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarEmpleado.Location = new System.Drawing.Point(312, 149);
            this.btnModificarEmpleado.Name = "btnModificarEmpleado";
            this.btnModificarEmpleado.Size = new System.Drawing.Size(168, 23);
            this.btnModificarEmpleado.TabIndex = 2;
            this.btnModificarEmpleado.Text = "MODIFICAR EMPLEADO";
            this.btnModificarEmpleado.UseVisualStyleBackColor = false;
            // 
            // btnConsultalEmpleado
            // 
            this.btnConsultalEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultalEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultalEmpleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultalEmpleado.Location = new System.Drawing.Point(312, 74);
            this.btnConsultalEmpleado.Name = "btnConsultalEmpleado";
            this.btnConsultalEmpleado.Size = new System.Drawing.Size(168, 23);
            this.btnConsultalEmpleado.TabIndex = 3;
            this.btnConsultalEmpleado.Text = "CONSULTAR EMPLEDADO";
            this.btnConsultalEmpleado.UseVisualStyleBackColor = false;
            this.btnConsultalEmpleado.Click += new System.EventHandler(this.BtnConsultalEmpleado_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.Azure;
            this.button7.Location = new System.Drawing.Point(284, 216);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(210, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "CERRAR  SESION ADMINISTRADOR";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(112, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = " MODULO ADMINISTRATIVO ";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(506, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnConsultalEmpleado);
            this.Controls.Add(this.btnModificarEmpleado);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(btnIngresoEmpleado);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Button btnModificarEmpleado;
        private System.Windows.Forms.Button btnConsultalEmpleado;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
    }
}

