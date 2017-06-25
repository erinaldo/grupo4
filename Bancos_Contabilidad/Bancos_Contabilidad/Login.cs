using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dllSeguridadSAD;

namespace Bancos_Contabilidad
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            dllSeguridadSAD.frmLogin.ActiveForm.Activate();

            dllSeguridadSAD.frmMenu temp = new dllSeguridadSAD.frmMenu();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
           
            dllSeguridadSAD.frmMenu.ActiveForm.Close();
           
            frmMenu ir  = new frmMenu();
            ir.Show();

        }
    }
}
