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
    public partial class frmPrincipalConfiguracion : Form
    {
        public frmPrincipalConfiguracion()
        {
            InitializeComponent();
            ActualizarGrid();
        }

        public void ActualizarGrid()
        {
            grdPoliza.DataSource = CapaEntidad.con.getSQL("SELECT rtrim(idempresa) as ID, rtrim(empresa.nombre_empresa) as Nombre, rtrim(empresa.razonsocial) as RazonSocial, rtrim(empresa.direccion) as Direccion, rtrim(empresa.telefono) as Telefono, rtrim(empresa.identificaciontributaria) as IdentificacionTrib, rtrim(concat(moneda.id_moneda,'.',moneda.nombre_moneda)) as Moneda, rtrim(concat(sede.id_sede,'.',sede.nombre_sede)) as Pais FROM Moneda, Empresa, Sede where empresa.id_moneda = moneda.id_moneda AND empresa.id_sede = sede.id_sede AND empresa.activo <> '0'");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmConfiguracion fc = new frmConfiguracion();
            fc.Show();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void grdPoliza_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sid = grdPoliza.Rows[grdPoliza.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sNombre = grdPoliza.Rows[grdPoliza.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string sRazon = grdPoliza.Rows[grdPoliza.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string sDireccion = grdPoliza.Rows[grdPoliza.CurrentCell.RowIndex].Cells[3].Value.ToString();
            string sTelefono = grdPoliza.Rows[grdPoliza.CurrentCell.RowIndex].Cells[4].Value.ToString();
            string sIdent = grdPoliza.Rows[grdPoliza.CurrentCell.RowIndex].Cells[5].Value.ToString();
            string sMoneda = grdPoliza.Rows[grdPoliza.CurrentCell.RowIndex].Cells[6].Value.ToString();
            string sPais = grdPoliza.Rows[grdPoliza.CurrentCell.RowIndex].Cells[7].Value.ToString();
            frmConfiguracion temp = new frmConfiguracion(sid, sNombre, sRazon, sDireccion, sTelefono, sIdent, sMoneda, sPais);
            temp.Show();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (cmbBuscar.Text == "Nombre")
            {
                grdPoliza.DataSource = CapaEntidad.con.getSQL("SELECT rtrim(idempresa) as ID, rtrim(empresa.nombre_empresa) as Nombre, rtrim(empresa.razonsocial) as RazonSocial, rtrim(empresa.direccion) as Direccion, rtrim(empresa.telefono) as Telefono, rtrim(empresa.identificaciontributaria) as IdentificacionTrib., rtrim(concat(moneda.id_moneda,'.',moneda.nombre_moneda)) as Moneda, rtrim(concat(sede.id_sede,'.',sede.nombre_sede)) as Pais FROM Moneda, Empresa, Sede where empresa.id_moneda = moneda.id_moneda AND empresa.id_sede = sede.id_sede AND empresa.activo <> '0' AND empresa.nombre_empresa LIKE '" + txtBuscar.Text + "%'");
            }
            else if (cmbBuscar.Text == "Razon Social")
            {
                grdPoliza.DataSource = CapaEntidad.con.getSQL("SELECT rtrim(idempresa) as ID, rtrim(empresa.nombre_empresa) as Nombre, rtrim(empresa.razonsocial) as RazonSocial, rtrim(empresa.direccion) as Direccion, rtrim(empresa.telefono) as Telefono, rtrim(empresa.identificaciontributaria) as IdentificacionTrib., rtrim(concat(moneda.id_moneda, '.', moneda.nombre_moneda)) as Moneda, rtrim(concat(sede.id_sede, '.', sede.nombre_sede)) as Pais FROM Moneda, Empresa, Sede where empresa.id_moneda = moneda.id_moneda AND empresa.id_sede = sede.id_sede AND empresa.activo <> '0' AND empresa.razonsocial LIKE '" + txtBuscar.Text + "%'");
            }
            else if (cmbBuscar.Text == "Direccion")
            {
                grdPoliza.DataSource = CapaEntidad.con.getSQL("SELECT rtrim(idempresa) as ID, rtrim(empresa.nombre_empresa) as Nombre, rtrim(empresa.razonsocial) as RazonSocial, rtrim(empresa.direccion) as Direccion, rtrim(empresa.telefono) as Telefono, rtrim(empresa.identificaciontributaria) as IdentificacionTrib., rtrim(concat(moneda.id_moneda, '.', moneda.nombre_moneda)) as Moneda, rtrim(concat(sede.id_sede, '.', sede.nombre_sede)) as Pais FROM Moneda, Empresa, Sede where empresa.id_moneda = moneda.id_moneda AND empresa.id_sede = sede.id_sede AND empresa.activo <> '0' AND empresa.direccion LIKE '" + txtBuscar.Text + "%'");
            }
            else if (cmbBuscar.Text == "Telefono")
            {
                grdPoliza.DataSource = CapaEntidad.con.getSQL("SELECT rtrim(idempresa) as ID, rtrim(empresa.nombre_empresa) as Nombre, rtrim(empresa.razonsocial) as RazonSocial, rtrim(empresa.direccion) as Direccion, rtrim(empresa.telefono) as Telefono, rtrim(empresa.identificaciontributaria) as IdentificacionTrib., rtrim(concat(moneda.id_moneda, '.', moneda.nombre_moneda)) as Moneda, rtrim(concat(sede.id_sede, '.', sede.nombre_sede)) as Pais FROM Moneda, Empresa, Sede where empresa.id_moneda = moneda.id_moneda AND empresa.id_sede = sede.id_sede AND empresa.activo <> '0' AND empresa.telefono LIKE '" + txtBuscar.Text + "%'");
            }
            else if (cmbBuscar.Text == "Identificacion Trib.")
            {
                grdPoliza.DataSource = CapaEntidad.con.getSQL("SELECT rtrim(idempresa) as ID, rtrim(empresa.nombre_empresa) as Nombre, rtrim(empresa.razonsocial) as RazonSocial, rtrim(empresa.direccion) as Direccion, rtrim(empresa.telefono) as Telefono, rtrim(empresa.identificaciontributaria) as IdentificacionTrib., rtrim(concat(moneda.id_moneda, '.', moneda.nombre_moneda)) as Moneda, rtrim(concat(sede.id_sede, '.', sede.nombre_sede)) as Pais FROM Moneda, Empresa, Sede where empresa.id_moneda = moneda.id_moneda AND empresa.id_sede = sede.id_sede AND empresa.activo <> '0' AND empresa.identificaciontributaria LIKE '" + txtBuscar.Text + "%'");
            }
            else if (cmbBuscar.Text == "Moneda")
            {
                grdPoliza.DataSource = CapaEntidad.con.getSQL("SELECT rtrim(idempresa) as ID, rtrim(empresa.nombre_empresa) as Nombre, rtrim(empresa.razonsocial) as RazonSocial, rtrim(empresa.direccion) as Direccion, rtrim(empresa.telefono) as Telefono, rtrim(empresa.identificaciontributaria) as IdentificacionTrib., rtrim(concat(moneda.id_moneda, '.', moneda.nombre_moneda)) as Moneda, rtrim(concat(sede.id_sede, '.', sede.nombre_sede)) as Pais FROM Moneda, Empresa, Sede where empresa.id_moneda = moneda.id_moneda AND empresa.id_sede = sede.id_sede AND empresa.activo <> '0' AND moneda.nombre_moneda LIKE '" + txtBuscar.Text + "%'");
            }
            else if (cmbBuscar.Text == "Pais")
            {
                grdPoliza.DataSource = CapaEntidad.con.getSQL("SELECT rtrim(idempresa) as ID, rtrim(empresa.nombre_empresa) as Nombre, rtrim(empresa.razonsocial) as RazonSocial, rtrim(empresa.direccion) as Direccion, rtrim(empresa.telefono) as Telefono, rtrim(empresa.identificaciontributaria) as IdentificacionTrib., rtrim(concat(moneda.id_moneda, '.', moneda.nombre_moneda)) as Moneda, rtrim(concat(sede.id_sede, '.', sede.nombre_sede)) as Pais FROM Moneda, Empresa, Sede where empresa.id_moneda = moneda.id_moneda AND empresa.id_sede = sede.id_sede AND empresa.activo <> '0' AND sede.nombre_sede LIKE '" + txtBuscar.Text + "%'");
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
