﻿namespace menu
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
            this.btnIngresoEmpleado = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnModificarEmpleado = new System.Windows.Forms.Button();
            this.btnConsultalEmpleado = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIngresoEmpleado
            // 
            this.btnIngresoEmpleado.Location = new System.Drawing.Point(62, 74);
            this.btnIngresoEmpleado.Name = "btnIngresoEmpleado";
            this.btnIngresoEmpleado.Size = new System.Drawing.Size(173, 23);
            this.btnIngresoEmpleado.TabIndex = 0;
            this.btnIngresoEmpleado.Text = "INGRESAR EMPLEADO";
            this.btnIngresoEmpleado.UseVisualStyleBackColor = true;
            this.btnIngresoEmpleado.Click += new System.EventHandler(this.BtnIngresoEmpleado_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(62, 139);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(173, 23);
            this.btnEliminarEmpleado.TabIndex = 1;
            this.btnEliminarEmpleado.Text = "ELIMINAR EMPLEADO";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = true;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.BtnEliminarEmpleado_Click);
            // 
            // btnModificarEmpleado
            // 
            this.btnModificarEmpleado.Location = new System.Drawing.Point(312, 139);
            this.btnModificarEmpleado.Name = "btnModificarEmpleado";
            this.btnModificarEmpleado.Size = new System.Drawing.Size(168, 23);
            this.btnModificarEmpleado.TabIndex = 2;
            this.btnModificarEmpleado.Text = "MODIFICAR EMPLEADO";
            this.btnModificarEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnConsultalEmpleado
            // 
            this.btnConsultalEmpleado.Location = new System.Drawing.Point(312, 74);
            this.btnConsultalEmpleado.Name = "btnConsultalEmpleado";
            this.btnConsultalEmpleado.Size = new System.Drawing.Size(168, 23);
            this.btnConsultalEmpleado.TabIndex = 3;
            this.btnConsultalEmpleado.Text = "CONSULTAR EMPLEDADO";
            this.btnConsultalEmpleado.UseVisualStyleBackColor = true;
            this.btnConsultalEmpleado.Click += new System.EventHandler(this.BtnConsultalEmpleado_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(270, 235);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(210, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "CERRAR  SESION ADMINISTRADOR";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "MODULO ADMINISTRATIDO , REGISTRO DE EMPLEADOS";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnConsultalEmpleado);
            this.Controls.Add(this.btnModificarEmpleado);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(this.btnIngresoEmpleado);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresoEmpleado;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Button btnModificarEmpleado;
        private System.Windows.Forms.Button btnConsultalEmpleado;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
    }
}

