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
    public partial class frmPrincipalEstadoDeCuenta : Form
    {
        public frmPrincipalEstadoDeCuenta()
        {
            InitializeComponent();
            ActualizarGrid();
        }

        public void ActualizarGrid()
        {
            grdEmpresa.DataSource = CapaEntidad.con.getSQL("select idcuenta as Codigo, nombre_cuenta as Nombre, numero_cuenta as Numero , banco as Banco, saldo as Saldo from cuenta where status = 1");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEstadoDeCuenta estado = new frmEstadoDeCuenta();
            estado.StartPosition = FormStartPosition.CenterScreen;
            estado.Show();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            grdEmpresa.Rows[0].Selected = true;
            grdEmpresa.CurrentCell = grdEmpresa.Rows[0].Cells[0];
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            int valor = grdEmpresa.CurrentCell.RowIndex;
            int max = grdEmpresa.Rows.Count - 2;
            valor = valor - 1;
            if (valor >= 0)
            {
                grdEmpresa.Rows[valor].Selected = true;
                grdEmpresa.CurrentCell = grdEmpresa.Rows[valor].Cells[0];
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int valor = grdEmpresa.CurrentCell.RowIndex;
            int max = grdEmpresa.Rows.Count - 2;
            valor = valor + 1;
            if (valor <= max)
            {
                grdEmpresa.Rows[valor].Selected = true;
                grdEmpresa.CurrentCell = grdEmpresa.Rows[valor].Cells[0];
            }
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            int max = grdEmpresa.Rows.Count - 2;
            grdEmpresa.Rows[max].Selected = true;
            grdEmpresa.CurrentCell = grdEmpresa.Rows[max].Cells[0];
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (cmbBuscar.Text == "Codigo")
            {
                grdEmpresa.DataSource = CapaEntidad.con.getSQL("select idcuenta as Codigo, nombre_cuenta as Nombre, numero_cuenta as Numero , banco as Banco, saldo as Saldo from cuenta where status = 1 and idcuenta LIKE '" + txtBuscar.Text + "%'  ");
            }
            else if (cmbBuscar.Text == "Nombre")
            {
                grdEmpresa.DataSource = CapaEntidad.con.getSQL("select idcuenta as Codigo, nombre_cuenta as Nombre, numero_cuenta as Numero , banco as Banco, saldo as Saldo from cuenta where status = 1 and nombre_cuenta LIKE '" + txtBuscar.Text + "%'  ");
            }
            else if (cmbBuscar.Text == "Numero")
            {
                grdEmpresa.DataSource = CapaEntidad.con.getSQL("select idcuenta as Codigo, nombre_cuenta as Nombre, numero_cuenta as Numero , banco as Banco, saldo as Saldo from cuenta where status = 1 and numero_cuenta LIKE '" + txtBuscar.Text + "%' ");
            }
            else if (cmbBuscar.Text == "Banco")
            {
                grdEmpresa.DataSource = CapaEntidad.con.getSQL("select idcuenta as Codigo, nombre_cuenta as Nombre, numero_cuenta as Numero , banco as Banco, saldo as Saldo from cuenta where status = 1 and banco LIKE '" + txtBuscar.Text + "%' ");
            }
        }

        private void grdEmpresa_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sid = grdEmpresa.Rows[grdEmpresa.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sNombre = grdEmpresa.Rows[grdEmpresa.CurrentCell.RowIndex].Cells[1].Value.ToString();
            frmEstadoDeCuenta temp = new frmEstadoDeCuenta(sid, sNombre);
            temp.StartPosition = FormStartPosition.CenterScreen;
            temp.Show();
        }
    }
}
