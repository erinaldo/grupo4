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
    public partial class frmPrincipalPoliza : Form
    {
        public frmPrincipalPoliza()
        {
            InitializeComponent();
            ActualizarGrid();
        }

        public void ActualizarGrid()
        {
            grdPoliza.DataSource= CapaEntidad.con.getSQL("SELECT rtrim(idpoliza) as ID, rtrim(detallepoliza.nombre) as Nombre, rtrim(total) as Total, rtrim(fecha) as Fecha, rtrim(concat(cuentacontable.idcuentacontable,'.',cuentacontable.nombre)) as CuentaContable, rtrim(concat(empresa.idempresa,'.',empresa.nombre_empresa)) as Empresa FROM DETALLEPOLIZA, Empresa, CUENTACONTABLE where DETALLEPOLIZA.idempresa = Empresa.idempresa AND DETALLEPOLIZA.idcuentacontable = CUENTACONTABLE.idcuentacontable AND detallepoliza.stat <> '0'");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmPoliza faf = new frmPoliza();
            faf.Show();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void grdEmpresa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sid = grdPoliza.Rows[grdPoliza.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sNombre = grdPoliza.Rows[grdPoliza.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string sTotal = grdPoliza.Rows[grdPoliza.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string sFecha = grdPoliza.Rows[grdPoliza.CurrentCell.RowIndex].Cells[3].Value.ToString();
            string sCuenta = grdPoliza.Rows[grdPoliza.CurrentCell.RowIndex].Cells[4].Value.ToString();
            string sEmpresa = grdPoliza.Rows[grdPoliza.CurrentCell.RowIndex].Cells[5].Value.ToString();
            frmPoliza temp = new frmPoliza(sid, sNombre, sTotal,sFecha,sCuenta,sEmpresa);
            temp.Show();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if(cmbBuscar.Text == "Nombre")
            {
                grdPoliza.DataSource = CapaEntidad.con.getSQL("SELECT rtrim(idpoliza) as ID, rtrim(detallepoliza.nombre) as Nombre, rtrim(total) as Total, rtrim(fecha) as Fecha, rtrim(concat(cuentacontable.idcuentacontable,'.',cuentacontable.nombre)) as CuentaContable, rtrim(concat(empresa.idempresa,'.',empresa.nombre_empresa)) as Empresa FROM DETALLEPOLIZA, Empresa, CUENTACONTABLE where DETALLEPOLIZA.idempresa = Empresa.idempresa AND DETALLEPOLIZA.idcuentacontable = CUENTACONTABLE.idcuentacontable AND detallepoliza.stat <> '0'AND detallepoliza.nombre LIKE '" + txtBuscar.Text + "%'");
            }else if(cmbBuscar.Text == "Codigo")
            {
                grdPoliza.DataSource = CapaEntidad.con.getSQL("SELECT rtrim(idpoliza) as ID, rtrim(detallepoliza.nombre) as Nombre, rtrim(total) as Total, rtrim(fecha) as Fecha, rtrim(concat(cuentacontable.idcuentacontable,'.',cuentacontable.nombre)) as CuentaContable, rtrim(concat(empresa.idempresa,'.',empresa.nombre_empresa)) as Empresa FROM DETALLEPOLIZA, Empresa, CUENTACONTABLE where DETALLEPOLIZA.idempresa = Empresa.idempresa AND DETALLEPOLIZA.idcuentacontable = CUENTACONTABLE.idcuentacontable AND detallepoliza.stat <> '0'AND detallepoliza.idpoliza LIKE '" + txtBuscar.Text + "%'");
            }
            else if (cmbBuscar.Text == "Total")
            {
                grdPoliza.DataSource = CapaEntidad.con.getSQL("SELECT rtrim(idpoliza) as ID, rtrim(detallepoliza.nombre) as Nombre, rtrim(total) as Total, rtrim(fecha) as Fecha, rtrim(concat(cuentacontable.idcuentacontable,'.',cuentacontable.nombre)) as CuentaContable, rtrim(concat(empresa.idempresa,'.',empresa.nombre_empresa)) as Empresa FROM DETALLEPOLIZA, Empresa, CUENTACONTABLE where DETALLEPOLIZA.idempresa = Empresa.idempresa AND DETALLEPOLIZA.idcuentacontable = CUENTACONTABLE.idcuentacontable AND detallepoliza.stat <> '0'AND detallepoliza.total LIKE '" + txtBuscar.Text + "%'");
            }
            else if (cmbBuscar.Text == "Fecha")
            {
                grdPoliza.DataSource = CapaEntidad.con.getSQL("SELECT rtrim(idpoliza) as ID, rtrim(detallepoliza.nombre) as Nombre, rtrim(total) as Total, rtrim(fecha) as Fecha, rtrim(concat(cuentacontable.idcuentacontable,'.',cuentacontable.nombre)) as CuentaContable, rtrim(concat(empresa.idempresa,'.',empresa.nombre_empresa)) as Empresa FROM DETALLEPOLIZA, Empresa, CUENTACONTABLE where DETALLEPOLIZA.idempresa = Empresa.idempresa AND DETALLEPOLIZA.idcuentacontable = CUENTACONTABLE.idcuentacontable AND detallepoliza.stat <> '0'AND detallepoliza.fecha LIKE '" + txtBuscar.Text + "%'");
            }
            else if (cmbBuscar.Text == "Cuenta")
            {
                grdPoliza.DataSource = CapaEntidad.con.getSQL("SELECT rtrim(idpoliza) as ID, rtrim(detallepoliza.nombre) as Nombre, rtrim(total) as Total, rtrim(fecha) as Fecha, rtrim(concat(cuentacontable.idcuentacontable,'.',cuentacontable.nombre)) as CuentaContable, rtrim(concat(empresa.idempresa,'.',empresa.nombre_empresa)) as Empresa FROM DETALLEPOLIZA, Empresa, CUENTACONTABLE where DETALLEPOLIZA.idempresa = Empresa.idempresa AND DETALLEPOLIZA.idcuentacontable = CUENTACONTABLE.idcuentacontable AND detallepoliza.stat <> '0'AND cuentacontable.nombre LIKE '" + txtBuscar.Text + "%'");
            }
            else if (cmbBuscar.Text == "Empresa")
            {
                grdPoliza.DataSource = CapaEntidad.con.getSQL("SELECT rtrim(idpoliza) as ID, rtrim(detallepoliza.nombre) as Nombre, rtrim(total) as Total, rtrim(fecha) as Fecha, rtrim(concat(cuentacontable.idcuentacontable,'.',cuentacontable.nombre)) as CuentaContable, rtrim(concat(empresa.idempresa,'.',empresa.nombre_empresa)) as Empresa FROM DETALLEPOLIZA, Empresa, CUENTACONTABLE where DETALLEPOLIZA.idempresa = Empresa.idempresa AND DETALLEPOLIZA.idcuentacontable = CUENTACONTABLE.idcuentacontable AND detallepoliza.stat <> '0'AND empresa.nombre_empresa LIKE '" + txtBuscar.Text + "%'");
            }


        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            grdPoliza.Rows[0].Selected = true;
            grdPoliza.CurrentCell = grdPoliza.Rows[0].Cells[0];
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            int valor = grdPoliza.CurrentCell.RowIndex;
            int max = grdPoliza.Rows.Count - 2;
            valor = valor - 1;
            if (valor >= 0)
            {
                grdPoliza.Rows[valor].Selected = true;
                grdPoliza.CurrentCell = grdPoliza.Rows[valor].Cells[0];
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int valor = grdPoliza.CurrentCell.RowIndex;
            int max = grdPoliza.Rows.Count - 2;
            valor = valor + 1;
            if (valor <= max)
            {
                grdPoliza.Rows[valor].Selected = true;
                grdPoliza.CurrentCell = grdPoliza.Rows[valor].Cells[0];
            }
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            int max = grdPoliza.Rows.Count - 2;
            grdPoliza.Rows[max].Selected = true;
            grdPoliza.CurrentCell = grdPoliza.Rows[max].Cells[0];
        }
    }
}
