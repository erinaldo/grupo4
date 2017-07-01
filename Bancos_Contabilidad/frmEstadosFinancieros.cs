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
    public partial class frmEstadosFinancieros : Form
    {
        public frmEstadosFinancieros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbBalance.Checked)
            {
                frmBalanceGeneral fbg = new frmBalanceGeneral();
                fbg.Show();
                this.Hide();
            }else
            {
                frmEstadoResultado fbg = new frmEstadoResultado();
                fbg.Show();
                this.Hide();
            }
        }
    }
}
