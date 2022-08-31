using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCasaleSP1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            //frmLogin miFormulario ---> declarar un objeto del molde (clase) frmLogin
            frmLogin miFormulario = new frmLogin();
            //= new frmLogin(); --->crear en memoria el formulario para ser utilizado
            //.....
            //mostrar el formulario en pantalla
            miFormulario.ShowDialog();
        }
    }
}
