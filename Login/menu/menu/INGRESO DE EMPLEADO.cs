﻿using System;
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
        //string path = @"C:\TEMP\Proyecto_Bimestral\Login\empleados\empleados.txt";
        string path = @"C:\Prueba\empleados.txt";
        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                string cedula = txbIngresocedula.Text;
                string nombres = txbIngresoNombres.Text;
                string apellidos = txbIngresoApellidos.Text;
                string telfCelular = txbIngresoTelfCelular.Text;
                string telfConvencional = txbIngresoTelfConvencional.Text;
                string diaNacimiento = cmbDia.Text;
                string mesNacimiento = cmbMes.Text;
                string anioNacimiento = cmbAnio.Text;
                string datosEmpleado = "Cedula: " + cedula + " - Nombres: " + nombres + " - Apellidos: " + apellidos + " - Teléfono Celular: "
                    + telfCelular + " - Teléfono Convencional: " + telfConvencional + " - Fecha de nacimiento: " + diaNacimiento
                    + " / " + mesNacimiento + " / " + anioNacimiento;
                string[] registroArray = File.ReadAllLines(path);
                String registroFinal = File.ReadAllText(path);
                StreamWriter escritura = File.CreateText(path);
                escritura.WriteLine(registroFinal + datosEmpleado + "\n");
                escritura.Close();

                string pathclave = @"D:\Proyectos progra\Proyecto_Bimestral\Proyecto_Bimestral\Login\usuarios\" + cedula + @"@miempresa.txt";
                //File.Create(@"D:\Proyectos progra\Proyecto_Bimestral\Proyecto_Bimestral\Login\usuarios\" + cedula + @".txt");
            
                StreamWriter escrituraclave = File.CreateText(pathclave);
                escrituraclave.Write( cedula);
                escrituraclave.Close();
               
            }
            catch (Exception)
            {
                
            }
        }
    }
}
