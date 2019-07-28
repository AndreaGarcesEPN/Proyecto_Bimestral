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
    public partial class ConsultaDeEmpleado : Form
    {
       // string path = @"C:\TEMP\Proyecto_Bimestral\Login\empleados\empleados.txt";
        string path = @"C:\prueba\empleados.txt";
        void Escribir(string tipo, string log, DataGridView dgv)
        {
            int posicionNuevoLog = dgv.Rows.Add();
            dgv.Rows[posicionNuevoLog].Cells[0].Value = tipo;
            dgv.Rows[posicionNuevoLog].Cells[1].Value = log;
            if (tipo == "Error")
            {
                dgv.Rows[posicionNuevoLog].Cells[0].Style.BackColor = Color.Red;
            }
            else
            {
                dgv.Rows[posicionNuevoLog].Cells[0].Style.BackColor = Color.Aquamarine;
            }
        }


        public ConsultaDeEmpleado()
        {
            InitializeComponent();
        }

        private void BtnCancelarConsulta_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ConsultaDeEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultarEmpleado_Click(object sender, EventArgs e)
        {
            string[] registroArray = File.ReadLines(path);
            foreach (string registro in registroArray)
            {
                Escribir("Info", registro, dvgConsulta);
            }
        }


    }
}


