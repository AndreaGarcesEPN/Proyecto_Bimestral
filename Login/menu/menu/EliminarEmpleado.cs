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

namespace menu
{
    public partial class EliminarEmpleado : Form
    {
        public EliminarEmpleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               // string path = @"C:\prueba\empleados.txt";
               string path = @"D:\Proyectos progra\Proyecto_Bimestral\Proyecto_Bimestral\Login\empleados\empleados.txt";
                string id = textBox1.Text;
                //int idEntero = Convert.ToInt32(id);
                string[] registroArray = File.ReadAllLines(path);
                int posicion = -1;
                for (int i = 0; i < registroArray.Length; i++)
                {
                    if (registroArray[i].Contains(id))
                    {
                        posicion = i;
                        break;
                    }
                }
                int finalString = registroArray[posicion].Length;
                registroArray[posicion] = registroArray[posicion].Replace(registroArray[posicion], " ");
                File.Delete(path);
                File.WriteAllLines(path, registroArray);
                MessageBox.Show(" Empleado eliminado ");
            }
            catch (Exception)
            {
                MessageBox.Show("Error:  No se pudo completar la acción");

            }
        }
    }
}
