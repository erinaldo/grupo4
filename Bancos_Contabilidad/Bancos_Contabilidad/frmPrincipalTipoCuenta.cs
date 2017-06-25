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
    public partial class frmPrincipalTipoCuenta : Form
    {
        MRP_BD con = new MRP_BD("sa", "Cocodrilo13", "SAD2017", "DYLAN");

        public frmPrincipalTipoCuenta()
        {
            InitializeComponent();
            ActualizarGrid();
        }

        public void ActualizarGrid()
        {
            grdCuentaContable.DataSource = con.getSQL("SELECT rtrim(idcuentacontable) as ID, rtrim(nombre) as Nombre, rtrim(estadofinanciero) as [Estado Financiero], rtrim(clasificacion) as Clasificacion FROM CUENTACONTABLE where stat <> '0'");
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmTipoCuenta obj = new frmTipoCuenta();
            obj.Show();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            grdCuentaContable.Rows[0].Selected = true;
            grdCuentaContable.CurrentCell = grdCuentaContable.Rows[0].Cells[0];
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            int valor = grdCuentaContable.CurrentCell.RowIndex;
            int max = grdCuentaContable.Rows.Count - 2;
            valor = valor - 1;
            if (valor >= 0)
            {
                grdCuentaContable.Rows[valor].Selected = true;
                grdCuentaContable.CurrentCell = grdCuentaContable.Rows[valor].Cells[0];
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int valor = grdCuentaContable.CurrentCell.RowIndex;
            int max = grdCuentaContable.Rows.Count - 2;
            valor = valor + 1;
            if (valor <= max)
            {
                grdCuentaContable.Rows[valor].Selected = true;
                grdCuentaContable.CurrentCell = grdCuentaContable.Rows[valor].Cells[0];
            }
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            int max = grdCuentaContable.Rows.Count - 2;
            grdCuentaContable.Rows[max].Selected = true;
            grdCuentaContable.CurrentCell = grdCuentaContable.Rows[max].Cells[0];
        }

        private void grdCuentaContable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sid = grdCuentaContable.Rows[grdCuentaContable.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sNombre = grdCuentaContable.Rows[grdCuentaContable.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string sEstadoFinanciero = grdCuentaContable.Rows[grdCuentaContable.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string sClasificacion = grdCuentaContable.Rows[grdCuentaContable.CurrentCell.RowIndex].Cells[3].Value.ToString();
            
            frmTipoCuenta temp = new frmTipoCuenta(sid, sNombre, sEstadoFinanciero, sClasificacion);
            temp.Show();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (cmbBuscar.Text == "Nombre")
            {
                grdCuentaContable.DataSource = con.getSQL("SELECT rtrim(idcuentacontable) as ID, rtrim(nombre) as Nombre, rtrim(estadofinanciero) as [Estado Financiero], rtrim(clasificacion) as Clasificacion FROM CUENTACONTABLE where stat <> '0' AND nombre LIKE '" + txtBuscar.Text + "%'");
            }
            else if (cmbBuscar.Text == "Codigo")
            {
                grdCuentaContable.DataSource = con.getSQL("SELECT rtrim(idcuentacontable) as ID, rtrim(nombre) as Nombre, rtrim(estadofinanciero) as [Estado Financiero], rtrim(clasificacion) as Clasificacion FROM CUENTACONTABLE where stat <> '0' AND idcuentacontable LIKE '" + txtBuscar.Text + "%'");
            }
            else if (cmbBuscar.Text == "Estado Financiero")
            {
                grdCuentaContable.DataSource = con.getSQL("SELECT rtrim(idcuentacontable) as ID, rtrim(nombre) as Nombre, rtrim(estadofinanciero) as [Estado Financiero], rtrim(clasificacion) as Clasificacion FROM CUENTACONTABLE where stat <> '0' AND estadofinanciero LIKE '" + txtBuscar.Text + "%'");
            }
            else if (cmbBuscar.Text == "Clasificacion")
            {
                grdCuentaContable.DataSource = con.getSQL("SELECT rtrim(idcuentacontable) as ID, rtrim(nombre) as Nombre, rtrim(estadofinanciero) as [Estado Financiero], rtrim(clasificacion) as Clasificacion FROM CUENTACONTABLE where stat <> '0' AND clasificacion LIKE '" + txtBuscar.Text + "%'");
            }
            
        }
    }
}
