
using menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Proyecto_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string clave = textBoxClave.Text;
            string clave_valida;
            string usuarios = @"D:\Proyectos progra\Proyecto_Bimestral\Proyecto_Bimestral\Login\admin\" + usuario + @".txt";
            if (File.Exists(usuarios))
            {
                clave_valida = File.ReadAllText(usuarios);
                if (clave.Equals(clave_valida))
                {
                    MenuPrincipal menu = new MenuPrincipal();
                    menu.Visible = true;
                    Visible = false;



                }
                else
                {
                    MessageBox.Show("contraseña erronea");
                }

            }
            else
            {
                MessageBox.Show("usuario no registrado");
            }

        


    }



        private void TextBoxClave_TextChanged(object sender, EventArgs e)
        {
            textBoxClave.UseSystemPasswordChar = true;
        }

        private void CheckMostrar_CheckedChanged(object sender, EventArgs e)
        {
            string clave = textBoxClave.Text;
            if (checkMostrar.Checked)
            {
                textBoxClave.UseSystemPasswordChar = false;
                textBoxClave.Text = clave;
            }
            else
            {
                textBoxClave.UseSystemPasswordChar = true;
                textBoxClave.Text = clave;
            }
        }

       
        

        
    }
}
