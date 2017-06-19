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
    public partial class frmPrincipalCuentasxPagar : Form
    {
        public frmPrincipalCuentasxPagar()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCuentasxPagar obj = new frmCuentasxPagar();
            obj.Show();
        }
    }
}
