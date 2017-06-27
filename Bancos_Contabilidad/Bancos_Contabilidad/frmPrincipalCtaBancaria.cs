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
    public partial class frmPrincipalCtaBancaria : Form
    {
        MRP_BD cn = new MRP_BD("sa", "Cocodrilo13", "SAD2017", "JREVMENPC");
        public frmPrincipalCtaBancaria()
        {
            InitializeComponent();
            ActualizarGrid();
        }

        public void ActualizarGrid()
        {
            grdCuenta.DataSource = cn.getSQL("select T0.idcuenta as ID, T0.nombre_cuenta as Nombre,T0.numero_cuenta as NoCuenta, T0.saldo,T0.banco as Banco, T0.activo as Estado,T1.nombre_empresa from cuenta T0 inner join empresa T1 on T0.idempresa = T1.idempresa" );
        }
        private void frmPrincipalCtaBancaria_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCuentaBancaria cuenta = new frmCuentaBancaria();
            cuenta.StartPosition = FormStartPosition.CenterScreen;
            cuenta.Show();
        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            grdCuenta.Rows[0].Selected = true;
            grdCuenta.CurrentCell = grdCuenta.Rows[0].Cells[0];
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            int valor = grdCuenta.CurrentCell.RowIndex;
            int max = grdCuenta.Rows.Count - 2;
            valor = valor - 1;
            if (valor >= 0)
            {
                grdCuenta.Rows[valor].Selected = true;
                grdCuenta.CurrentCell = grdCuenta.Rows[valor].Cells[0];
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int valor = grdCuenta.CurrentCell.RowIndex;
            int max = grdCuenta.Rows.Count - 2;
            valor = valor - 1;
            if (valor >= 0)
            {
                grdCuenta.Rows[valor].Selected = true;
                grdCuenta.CurrentCell = grdCuenta.Rows[valor].Cells[0];
            }
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            int max = grdCuenta.Rows.Count - 2;
            grdCuenta.Rows[max].Selected = true;
            grdCuenta.CurrentCell = grdCuenta.Rows[max].Cells[0];
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void grdCuenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sid = grdCuenta.Rows[grdCuenta.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sNombre = grdCuenta.Rows[grdCuenta.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string sNumero = grdCuenta.Rows[grdCuenta.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string sSaldo = grdCuenta.Rows[grdCuenta.CurrentCell.RowIndex].Cells[3].Value.ToString();
            string sEmpresa = grdCuenta.Rows[grdCuenta.CurrentCell.RowIndex].Cells[4].Value.ToString();
            string sBanco = grdCuenta.Rows[grdCuenta.CurrentCell.RowIndex].Cells[5].Value.ToString();

            frmCuentaBancaria temp = new frmCuentaBancaria(sid, sNombre, sNumero, sSaldo, sBanco,sEmpresa);
            temp.Show();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (cmbBuscar.Text == "nombre")
            {
                grdCuenta.DataSource = cn.getSQL("select T1., T0.idcuenta as ID, T0.nombre_cuenta as Nombre,T0.numero_cuenta as NoCuenta,T0.banco as Banco, T0.activo as Estado from cuenta T0 inner join empresa T1 on T0.idempresa = T1.idempresa and  T0.nombre_cuenta  LIKE '" + txtBuscar.Text + "%'");
            }
            else if (cmbBuscar.Text == "numero_cuenta")
            {
                grdCuenta.DataSource = cn.getSQL("select T1.nombre_empresa, T0.idcuenta as ID, T0.nombre_cuenta as Nombre,T0.numero_cuenta as NoCuenta,T0.banco as Banco, T0.activo as Estado from cuenta T0 inner join empresa T1 on T0.idempresa =T1.idempresa and T0.numero_cuenta  LIKE '" + txtBuscar.Text + "%'");
            }
            else if (cmbBuscar.Text == "saldo")
            {
                grdCuenta.DataSource = cn.getSQL("select T1.nombre_empresa, T0.idcuenta as ID, T0.nombre_cuenta as Nombre,T0.numero_cuenta as NoCuenta,T0.banco as Banco, T0.activo as Estado from cuenta T0 inner join empresa T1 on T0.idempresa =T1.idempresa and T0.saldo  LIKE '" + txtBuscar.Text + "%'");
            }
            else if (cmbBuscar.Text == "banco")
            {
                grdCuenta.DataSource = cn.getSQL("select  T1.nombre_empresa ,T0.idcuenta as ID, T0.nombre_cuenta as Nombre,T0.numero_cuenta as NoCuenta,T0.banco as Banco, T0.activo as Estado from cuenta T0 inner join empresa T1 on T0.idempresa = T1.idempresa and T0.banco  LIKE '" + txtBuscar.Text + "%'");
            }
            else if (cmbBuscar.Text == "empresa")
            {
                grdCuenta.DataSource = cn.getSQL("select T1.nombre_empresa, T0.idcuenta as ID, T0.nombre_cuenta as Nombre,T0.numero_cuenta as NoCuenta,T0.banco as Banco, T0.activo as Estado from cuenta T0 inner join empresa T1 on T0.idempresa = T1.idempresa and T1.nombre_empresa  LIKE '" + txtBuscar.Text + "%'");
            }


        }

        private void grdCuenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
