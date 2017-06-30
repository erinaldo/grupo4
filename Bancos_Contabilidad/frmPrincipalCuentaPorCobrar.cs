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
    public partial class frmPrincipalCuentaPorCobrar : Form
    {
        public frmPrincipalCuentaPorCobrar()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCuentaPorCobrar cxc = new frmCuentaPorCobrar();
            cxc.StartPosition = FormStartPosition.CenterScreen;
            cxc.Show();
        }
    }
}
