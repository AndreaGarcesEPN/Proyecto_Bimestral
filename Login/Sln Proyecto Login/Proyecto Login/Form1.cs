
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
            string contraseñaadmin;
            string contraseñauser;

            string admin = @"D:\Proyectos progra\Proyecto_Bimestral\Proyecto_Bimestral\Login\admin\" + usuario + @".txt";
            string usuarios = @"D:\Proyectos progra\Proyecto_Bimestral\Proyecto_Bimestral\Login\usuarios\" + usuario + @".txt";
            if (File.Exists(admin) )
            {
                //si exixte el archivo lo abre y lo lee lo compara con la contraseña y lo acepta
               contraseñaadmin = File.ReadAllText(admin);
                
                if (clave.Equals(contraseñaadmin) )
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
                if (File.Exists(usuarios))
                {
                    //si exixte el archivo lo abre y lo lee lo compara con la contraseña y lo acepta
                    contraseñauser = File.ReadAllText(usuarios);

                    if (clave.Equals(contraseñauser))
                    {
                        MenuPrincipal menu = new MenuPrincipal();
                        menu.Visible = true;
                        Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("contraseña erronea");
                    }
                }else {
                    MessageBox.Show(" no existe el usuario ");

                }
                
            
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
