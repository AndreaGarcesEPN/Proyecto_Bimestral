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
    public partial class ConsultaDeEmpleado : Form
    {
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
    }
}
