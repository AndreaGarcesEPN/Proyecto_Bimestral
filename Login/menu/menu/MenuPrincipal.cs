using Proyecto_Login;
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
        {//abre el menu para consultar un empleado
            Form consultaEmpleado = new ConsultaDeEmpleado();
            consultaEmpleado.Show();
          
        }

        private void BtnEliminarEmpleado_Click(object sender, EventArgs e)
        { // abre el menu de eliminar empleado
            Form eliminarempleado = new EliminarEmpleado();
            eliminarempleado.Visible = true;
            
        }


        //para cerrar secion y volver al login
        //copie la fomr1 que es el login a la solucion menu caso contrario no encontraba la clase 
         private void Button7_Click(object sender, EventArgs e)
        {
            
            Form1 login = new Form1();
            login.Show();
            this.Dispose();//elimina o limpia servicios qque se esten usando


        }
    }
}
