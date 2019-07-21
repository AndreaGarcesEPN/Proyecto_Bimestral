namespace Proyecto_Login
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkMostrar = new System.Windows.Forms.CheckBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.Label();
            this.imgUsuario = new System.Windows.Forms.PictureBox();
            this.ImgContraseña = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // checkMostrar
            // 
            this.checkMostrar.AutoSize = true;
            this.checkMostrar.BackColor = System.Drawing.Color.Transparent;
            this.checkMostrar.ForeColor = System.Drawing.SystemColors.Menu;
            this.checkMostrar.Location = new System.Drawing.Point(135, 109);
            this.checkMostrar.Name = "checkMostrar";
            this.checkMostrar.Size = new System.Drawing.Size(91, 17);
            this.checkMostrar.TabIndex = 11;
            this.checkMostrar.Text = "Mostrar Clave";
            this.checkMostrar.UseVisualStyleBackColor = false;
            this.checkMostrar.CheckedChanged += new System.EventHandler(this.CheckMostrar_CheckedChanged);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.Transparent;
            this.BtnIngresar.Location = new System.Drawing.Point(135, 148);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(75, 23);
            this.BtnIngresar.TabIndex = 10;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // textBoxClave
            // 
            this.textBoxClave.Location = new System.Drawing.Point(135, 83);
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.Size = new System.Drawing.Size(164, 20);
            this.textBoxClave.TabIndex = 9;
            this.textBoxClave.TextChanged += new System.EventHandler(this.TextBoxClave_TextChanged);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(135, 36);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(164, 20);
            this.textBoxUsuario.TabIndex = 8;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.BackColor = System.Drawing.Color.Transparent;
            this.Usuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Usuario.Location = new System.Drawing.Point(36, 39);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(43, 13);
            this.Usuario.TabIndex = 6;
            this.Usuario.Text = "Usuario";
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.BackColor = System.Drawing.Color.Transparent;
            this.Contraseña.ForeColor = System.Drawing.SystemColors.Control;
            this.Contraseña.Location = new System.Drawing.Point(36, 86);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(61, 13);
            this.Contraseña.TabIndex = 7;
            this.Contraseña.Text = "Contraseña";
            // 
            // imgUsuario
            // 
            this.imgUsuario.BackColor = System.Drawing.Color.Transparent;
            this.imgUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgUsuario.BackgroundImage")));
            this.imgUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgUsuario.Location = new System.Drawing.Point(101, 36);
            this.imgUsuario.Name = "imgUsuario";
            this.imgUsuario.Size = new System.Drawing.Size(28, 20);
            this.imgUsuario.TabIndex = 12;
            this.imgUsuario.TabStop = false;
            // 
            // ImgContraseña
            // 
            this.ImgContraseña.BackColor = System.Drawing.Color.Transparent;
            this.ImgContraseña.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgContraseña.BackgroundImage")));
            this.ImgContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgContraseña.Location = new System.Drawing.Point(103, 86);
            this.ImgContraseña.Name = "ImgContraseña";
            this.ImgContraseña.Size = new System.Drawing.Size(26, 17);
            this.ImgContraseña.TabIndex = 13;
            this.ImgContraseña.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Invitado";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(359, 227);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ImgContraseña);
            this.Controls.Add(this.imgUsuario);
            this.Controls.Add(this.checkMostrar);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.textBoxClave);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Usuario);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgContraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkMostrar;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.TextBox textBoxClave;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.PictureBox imgUsuario;
        private System.Windows.Forms.PictureBox ImgContraseña;
        private System.Windows.Forms.Button button1;
    }
}

