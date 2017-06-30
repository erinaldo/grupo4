using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bancos_Contabilidad
{
    public partial class frmPrincipalCuenta : Form
    {
        public frmPrincipalCuenta()
        {
            InitializeComponent();
        }

        private void z_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCuenta cuenta = new frmCuenta();
            cuenta.StartPosition = FormStartPosition.CenterScreen;
                cuenta.Show(); 
        }
    }
}
