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
    public partial class INGRESO_DE_EMPLEADO : Form
    {
        public INGRESO_DE_EMPLEADO()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancelarIngresoEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();


        }
        string path = @"C:\TEMP\Proyecto_Bimestral\Login\empleados\empleados.txt";

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                string Cedula = txbIngresocedula.Text;
                string Nombres = txbIngresoNombres.Text;
                string Apellidos = txbIngresoApellidos.Text;
                string telfCelular = txbIngresoTelfCelular.Text;
                string telfConvencional = txbIngresoTelfConvencional.text;
                string empleado = "Cedula: " + Cedula + "-nombres" + Nombres;
                string[] registroArray = File.ReadAllLines(path);
                String registroFinal = File.ReadAllText(path);
                StreamWriter escritura = File.CreateText(path);
                escritura.WriteLine(registroFinal + empleado);
                escritura.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
