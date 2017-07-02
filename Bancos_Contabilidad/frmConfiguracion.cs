using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Bancos_Contabilidad
{
    public partial class frmConfiguracion : Form
    {
        public string estado = "", editID;
        public frmConfiguracion()
        {
            InitializeComponent();
            llenarCombo();
            btnGuardar.Enabled = txtIdentificacion.Enabled = txtNombre.Enabled = txtRazon.Enabled = txtDireccion.Enabled = txtTelefono.Enabled = true;
            btnNuevo.Enabled = btnEditar.Enabled = btnEliminar.Enabled = false;
            estado = "insertar";
        }

        public frmConfiguracion(string id, string nom, string razon, string dir, string tel, string iden, string mon, string pais)
        {
            InitializeComponent();
            llenarCombo();
            editID = id;
            txtNombre.Text = nom;
            txtRazon.Text = razon;
            txtDireccion.Text = dir;
            txtTelefono.Text = tel;
            txtIdentificacion.Text = iden;
            cmbMoneda.Text = mon;
            cmbPais.Text = pais;
        }

        public void llenarCombo()
        {
            PruebaConexion.Conexion con = new PruebaConexion.Conexion();
            try
            {
                con.cmd = new SqlCommand("Select id_moneda, nombre_moneda from moneda", con.cn);
                con.dr = con.cmd.ExecuteReader();
                DataTable dt = new DataTable();
                cmbMoneda.Items.Clear();
                while (con.dr.Read())
                {
                    cmbMoneda.Items.Add(con.dr.GetInt32(0).ToString() + "." + con.dr.GetString(1));
                }
                con.dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar la moneda: " + ex.ToString());
            }
            try
            {
                con.cmd = new SqlCommand("Select id_sede, nombre_sede from sede", con.cn);
                con.dr = con.cmd.ExecuteReader();
                DataTable dt = new DataTable();
                cmbPais.Items.Clear();
                while (con.dr.Read())
                {
                    cmbPais.Items.Add(con.dr.GetInt32(0).ToString() + "." + con.dr.GetString(1));
                }
                con.dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar el pais: " + ex.ToString());
            }
        }

        public void limpiar()
        {
            txtNombre.Clear();
            txtRazon.Clear();
            txtDireccion.Clear();
            txtIdentificacion.Clear();
            txtTelefono.Clear();
            cmbMoneda.SelectedIndex = -1;
            cmbPais.SelectedIndex = -1;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estado = "insertar";
            limpiar();
            btnGuardar.Enabled = btnCancelar.Enabled = txtIdentificacion.Enabled = txtNombre.Enabled = txtRazon.Enabled = txtDireccion.Enabled = txtTelefono.Enabled = cmbMoneda.Enabled = cmbPais.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estado = "editar";
            btnGuardar.Enabled = btnCancelar.Enabled = txtIdentificacion.Enabled = txtNombre.Enabled = txtRazon.Enabled = txtDireccion.Enabled = txtTelefono.Enabled = cmbMoneda.Enabled = cmbPais.Enabled = true;
            btnNuevo.Enabled = btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            estado = "eliminar";
            btnGuardar.Enabled = btnCancelar.Enabled = true;
            btnNuevo.Enabled = btnEditar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (estado == "insertar")
            {
                CapaEntidad.configuraion p = new CapaEntidad.configuraion();
                p.Nombre = txtNombre.Text;
                p.Razon = txtRazon.Text;
                p.Direccion = txtDireccion.Text;
                p.Telefono = txtTelefono.Text;
                p.Identificacion = txtIdentificacion.Text;
                string[] cortador = cmbMoneda.Text.Split('.');
                p.Moneda = cortador[0];
                string[] cortador2 = cmbPais.Text.Split('.');
                p.Pais = cortador2[0];
                CapaNegocio cn = new CapaNegocio();
                cn.insertConfig(p);
                limpiar();
                btnNuevo.Enabled = true;
                btnEditar.Enabled = btnEliminar.Enabled = btnGuardar.Enabled = btnCancelar.Enabled = txtIdentificacion.Enabled = txtNombre.Enabled = txtRazon.Enabled = txtDireccion.Enabled = txtTelefono.Enabled = cmbMoneda.Enabled = cmbPais.Enabled = false;
            }
            else if (estado == "editar")
            {
                CapaEntidad.configuraion p = new CapaEntidad.configuraion();
                p.Id = editID;
                p.Nombre = txtNombre.Text;
                p.Razon = txtRazon.Text;
                p.Direccion = txtDireccion.Text;
                p.Telefono = txtTelefono.Text;
                p.Identificacion = txtIdentificacion.Text;
                string[] cortador = cmbMoneda.Text.Split('.');
                p.Moneda = cortador[0];
                string[] cortador2 = cmbPais.Text.Split('.');
                p.Pais = cortador2[0];
                CapaNegocio cn = new CapaNegocio();
                cn.actualizarConfig(p);
                btnEditar.Enabled = btnEliminar.Enabled = btnNuevo.Enabled = true;
                btnGuardar.Enabled = btnCancelar.Enabled = txtIdentificacion.Enabled = txtNombre.Enabled = txtRazon.Enabled = txtDireccion.Enabled = txtTelefono.Enabled = cmbMoneda.Enabled = cmbPais.Enabled = false;
            }
            else if (estado == "eliminar")
            {

                if (MessageBox.Show("Desea eliminar el registro", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CapaEntidad.configuraion p = new CapaEntidad.configuraion();
                    p.Id = editID;
                    CapaNegocio cn = new CapaNegocio();
                    cn.eliminarConfig(p);
                    limpiar();
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = btnEliminar.Enabled = btnGuardar.Enabled = btnCancelar.Enabled = txtIdentificacion.Enabled = txtNombre.Enabled = txtRazon.Enabled = txtDireccion.Enabled = txtTelefono.Enabled = cmbMoneda.Enabled = cmbPais.Enabled = false;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = btnEditar.Enabled = btnEliminar.Enabled = true;
            btnEditar.Enabled = btnGuardar.Enabled = btnCancelar.Enabled = txtIdentificacion.Enabled = txtNombre.Enabled = txtRazon.Enabled = txtDireccion.Enabled = txtTelefono.Enabled = cmbMoneda.Enabled = cmbPais.Enabled = false;
        }
    }
}
