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
    public partial class frmPrincipalCuentaPorPagar : Form
    {
        public frmPrincipalCuentaPorPagar()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCuentaPorPagar cxp = new frmCuentaPorPagar();
            cxp.StartPosition = FormStartPosition.CenterScreen;
            cxp.Show();
        }
    }
}
