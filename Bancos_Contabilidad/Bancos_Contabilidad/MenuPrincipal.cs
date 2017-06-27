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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            DateTime thisDay = DateTime.Now;
            toolStripStatusLabel3.Text = thisDay.ToString();
        }

        public static DateTime Today { get; }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void ordenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalOrdenCompra fpoc = new frmPrincipalOrdenCompra();
            fpoc.WindowState = FormWindowState.Maximized;
            fpoc.MdiParent = this;
            fpoc.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPrincipalEstadosFinancieros fpef = new frmPrincipalEstadosFinancieros();
            fpef.WindowState = FormWindowState.Maximized;
            fpef.MdiParent = this;
            fpef.Show();
        }

        private void activosFijosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalPoliza fpaf = new frmPrincipalPoliza();
            fpaf.WindowState = FormWindowState.Maximized;
            fpaf.MdiParent = this;
            fpaf.Show();
        }

        private void pasivosFijosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalPasivoFijo fppf = new frmPrincipalPasivoFijo();
            fppf.WindowState = FormWindowState.Maximized;
            fppf.MdiParent = this;
            fppf.Show();
        }

        private void cuentasPorPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalCuentaPorPagar cxp = new frmPrincipalCuentaPorPagar();
            cxp.WindowState = FormWindowState.Maximized;
            cxp.MdiParent = this;
            cxp.Show();
        }

        private void cuentasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalCuentaPorCobrar cxc = new frmPrincipalCuentaPorCobrar();
            cxc.WindowState = FormWindowState.Maximized;
            cxc.MdiParent = this;
            cxc.Show();
        }

        private void actividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalCtaBancaria cuenta = new frmPrincipalCtaBancaria();
            cuenta.WindowState = FormWindowState.Maximized;
            cuenta.MdiParent = this;
            cuenta.Show();
        }

        private void autorizacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPrincipalAutorizacion autorizacion = new frmPrincipalAutorizacion();
            autorizacion.WindowState = FormWindowState.Maximized;
            autorizacion.MdiParent = this;
            autorizacion.Show();
        }

        private void estadoDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalEstadoDeCuenta cuenta = new frmPrincipalEstadoDeCuenta();
            cuenta.WindowState = FormWindowState.Maximized;
            cuenta.MdiParent = this;
            cuenta.Show();
        }

        private void cuotaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalVentas cuenta = new frmPrincipalVentas();
            cuenta.WindowState = FormWindowState.Maximized;
            cuenta.MdiParent = this;
            cuenta.Show();
        }

        private void planillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalPlanilla cuenta = new frmPrincipalPlanilla();
            cuenta.WindowState = FormWindowState.Maximized;
            cuenta.MdiParent = this;
            cuenta.Show();
        }

        private void estadoDeResultadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPrincipalEstadoDeCuenta cuenta = new frmPrincipalEstadoDeCuenta();
            cuenta.WindowState = FormWindowState.Maximized;
            cuenta.MdiParent = this;
            cuenta.Show();
        }

        private void cuentasContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalTipoCuenta cuenta = new frmPrincipalTipoCuenta();
            cuenta.WindowState = FormWindowState.Maximized;
            cuenta.MdiParent = this;
            cuenta.Show();
        }

        private void cierreContableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea realizar el cierre contable para el mes de Junio 2017", "Cierre Contable", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void documentoRefToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalDocRef cuenta = new frmPrincipalDocRef();
            cuenta.WindowState = FormWindowState.Maximized;
            cuenta.MdiParent = this;
            cuenta.Show();
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void polizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalPoliza cuenta = new frmPrincipalPoliza();
            cuenta.WindowState = FormWindowState.Maximized;
            cuenta.MdiParent = this;
            cuenta.Show();
        }

        private void monedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalMoneda cuenta = new frmPrincipalMoneda();
            cuenta.WindowState = FormWindowState.Maximized;
            cuenta.MdiParent = this;
            cuenta.Show();
        }
    }
}
