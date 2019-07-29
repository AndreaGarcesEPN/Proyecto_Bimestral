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
                string path = @"C:\prueba\empleados.txt";
                string id = textBox1.Text;
                int idEntero = System.Convert.ToInt32(id);
                string[] registroArray = File.ReadAllLines(path);

                var a = registroArray.ToList();
                //var z = a.Remove(id);
                // z = z.Substring(8, 10);
                //var k = a.IndexOf(z);
                //var j = a.Find(x => x.Contains(x.Substring(Int32.Parse(id))));
                //a.RemoveAt(j.First());
                string[] emp = a.ToArray();
                //registroArray.Contains()
                int finalString = a[idEntero].Length;
                a[idEntero] = a[idEntero].Replace(a[idEntero], " ");
                File.Delete(path);
                File.WriteAllLines(path, a);
                MessageBox.Show(" Empleado eliminado ");
            }
            catch (Exception)
            {
                MessageBox.Show("Error: No se pudo completar la acción");

            }
        }
    }
}
