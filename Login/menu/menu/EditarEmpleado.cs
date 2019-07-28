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
    public partial class EditarEmpleado : Form
    {
        public EditarEmpleado()
        {
            InitializeComponent();
        }

        string path = @"C:\Prueba\empleados.txt";



        private void BtnCancelarIngresoEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();


        }
        
        

        

        private void BtnEditarEmpleado_Click(object sender, EventArgs e)
        {   
        }

        private void BtnEditarEmpleado_Click_1(object sender, EventArgs e)
        {
            //string path = @"C:\TEMP\Proyecto_Bimestral\Login\empleados\empleados.txt";
            
            try
            {
                string cedula = txbEditarcedula.Text;
                string nombres = txbEditarNombres.Text;
                string apellidos = txbEditarApellidos.Text;
                string telfCelular = txbEditarTelfCelular.Text;
                string telfConvencional = txbEditarTelfConvencional.Text;
                string diaNacimiento = cmbDiaEditar.Text;
                string mesNacimiento = cmbMesEditar.Text;
                string anioNacimiento = cmbAnioEditar.Text;
                int idcedulaint = Int32.Parse(cedula);
                String[] registroArray = File.ReadAllLines(path);
                int finalcad = registroArray[idcedulaint].Length;
                string datosEmpleado = "Cedula: " + cedula + " - Nombres: " + nombres + " - Apellidos: " + apellidos + " - Teléfono Celular: " + telfCelular + " - Teléfono Convencional: " + telfConvencional + " - Fecha de nacimiento: " + diaNacimiento
                    + " / " + mesNacimiento + " / " + anioNacimiento;
                registroArray[idcedulaint] = registroArray[idcedulaint].Replace(registroArray[idcedulaint], datosEmpleado);
                File.Delete(path);
                File.WriteAllLines(path, registroArray);
            }
            catch (Exception)
            {
                MessageBox.Show(" no se puede editar  ");
            }
        }
    }
}
