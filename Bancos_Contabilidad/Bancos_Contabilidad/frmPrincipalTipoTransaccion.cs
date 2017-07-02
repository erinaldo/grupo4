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
    public partial class frmPrincipalTipoTransaccion : Form
    {
        public static MRP_BD cn = new MRP_BD("usuario", "1234", "xx3", "localhost");
        public frmPrincipalTipoTransaccion()
        {
            InitializeComponent();
            ActualizarGrid();
        }
        public void ActualizarGrid()
        {
            grdTipoTrans.DataSource = cn.getSQL("select T0.idtipotrans, T0.nombre,T0.accion,T0.stat as Estado from tipotrans T0");
        }
    

        private void frmPrincipalTipoTransaccion_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmTipoTransaccion cuenta = new frmTipoTransaccion();
            cuenta.StartPosition = FormStartPosition.CenterScreen;
            cuenta.Show();
        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            grdTipoTrans.Rows[0].Selected = true;
            grdTipoTrans.CurrentCell = grdTipoTrans.Rows[0].Cells[0];
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            int valor = grdTipoTrans.CurrentCell.RowIndex;
            int max = grdTipoTrans.Rows.Count - 2;
            valor = valor - 1;
            if (valor >= 0)
            {
                grdTipoTrans.Rows[valor].Selected = true;
                grdTipoTrans.CurrentCell = grdTipoTrans.Rows[valor].Cells[0];
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int valor = grdTipoTrans.CurrentCell.RowIndex;
            int max = grdTipoTrans.Rows.Count - 2;
            valor = valor - 1;
            if (valor >= 0)
            {
                grdTipoTrans.Rows[valor].Selected = true;
                grdTipoTrans.CurrentCell = grdTipoTrans.Rows[valor].Cells[0];
            }
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            int max = grdTipoTrans.Rows.Count - 2;
            grdTipoTrans.Rows[max].Selected = true;
            grdTipoTrans.CurrentCell = grdTipoTrans.Rows[max].Cells[0];
        }

        private void grdTipoTrans_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sid = grdTipoTrans.Rows[grdTipoTrans.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string snombre = grdTipoTrans.Rows[grdTipoTrans.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string saccion= grdTipoTrans.Rows[grdTipoTrans.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string sestado= grdTipoTrans.Rows[grdTipoTrans.CurrentCell.RowIndex].Cells[3].Value.ToString();
            frmTipoTransaccion temp = new frmTipoTransaccion(sid, snombre, saccion, sestado );
            temp.Show();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (cmbBuscar.Text == "nombre")
            {
                grdTipoTrans.DataSource = cn.getSQL("select T0.idtipotrans, T0.stat,T0.nombre,T0.accion  from tipotrans T0 WHERE T0.nombre LIKE '" + txtBuscar.Text + "%'");
            }
            else if (cmbBuscar.Text == "accion")
            {
                grdTipoTrans.DataSource = cn.getSQL("select T0.idtipotrans, T0.stat,T0.nombre,T0.accion  from tipotrans T0 WHERE T0.accion LIKE '" + txtBuscar.Text + "%'");
            }
            else if (cmbBuscar.Text == "estado")
            {
                grdTipoTrans.DataSource = cn.getSQL("select T0.idtipotrans,T0.stat,T0.nombre,T0.accion from tipotrans T0 WHERE T0.stat LIKE '" + txtBuscar.Text + "%'");
            }


        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void z_Click(object sender, EventArgs e)
        {

        }
    }
}
