using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void BtnIngresoEmpleado_Click(object sender, EventArgs e)
        {
            Form ingresoempleado = new INGRESO_DE_EMPLEADO();
            ingresoempleado.Show();
        }

        private void BtnConsultalEmpleado_Click(object sender, EventArgs e)
        {
            Form consultaEmpleado = new ConsultaDeEmpleado();
            consultaEmpleado.Show();
        }
    }
}
