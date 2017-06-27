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
    public partial class frmPrincipalMoneda : Form
    {
        MRP_BD con = new MRP_BD("sa", "Cocodrilo13", "SAD2017", "JREVMENPC");
        public frmPrincipalMoneda()
        {
            InitializeComponent();
            ActualizarGrid();
        }

        public void ActualizarGrid()
        {
            grdPoliza.DataSource = con.getSQL("SELECT id_moneda as ID, nombre_moneda as Moneda, simbolo_moneda as Simbolo FROM Moneda where activo = 1'");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {

        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {

        }
    }
}
