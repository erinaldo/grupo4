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
    public partial class frmPoliza : Form
    {

        public string estado = "";
        public frmPoliza()
        {
            InitializeComponent();
            llenarCombo();
        }

        public void limpiar()
        {
            txtNombre.Clear();
            txtTotal.Clear();
            cmbCuenta.SelectedIndex = -1;
        }

        public void llenarCombo()
        {
            PruebaConexion.Conexion con = new PruebaConexion.Conexion();
            try
            {
                con.cmd = new SqlCommand("Select idcuentacontable, nombre from CUENTACONTABLE", con.cn);
                con.dr = con.cmd.ExecuteReader();
                DataTable dt = new DataTable();
                cmbCuenta.Items.Clear();
                while (con.dr.Read())
                {
                    cmbCuenta.Items.Add(con.dr.GetInt32(0).ToString() + "." + con.dr.GetString(1));
                }
                con.dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
        }

        public frmPoliza(string id,string nom, string tot, string fecha, string cuenta, string emp)
        {
            InitializeComponent();
            llenarCombo();
            txtNombre.Text = nom;
            txtTotal.Text = tot;
            fecha.Replace('-', '/');
            dtpFecha.Value = DateTime.Parse(fecha);
            cmbCuenta.Text = cuenta;
            textBox1.Text = id;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estado = "insertar";
            limpiar();
            btnGuardar.Enabled = btnCancelar.Enabled = txtNombre.Enabled = txtTotal.Enabled = cmbCuenta.Enabled = dtpFecha.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(estado == "insertar")
            {
                CapaEntidad.poliza p = new CapaEntidad.poliza();
                p.Nombre = txtNombre.Text;
                p.Total = txtTotal.Text;
                p.Fecha = dtpFecha.Text;
                string[] cortador = cmbCuenta.Text.Split('.');
                string idcuenta = cortador[0];
                p.Cuenta = idcuenta;
                p.Empresa = CapaEntidad.idemp;
                p.Status = "1";
                CapaNegocio cn = new CapaNegocio();
                cn.insertPoliza(p);
            }else if(estado == "editar")
            {
                CapaEntidad.poliza p = new CapaEntidad.poliza();
                p.ID1 = textBox1.Text;
                p.Nombre = txtNombre.Text;
                p.Total = txtTotal.Text;
                p.Fecha = dtpFecha.Text;
                string[] cortador = cmbCuenta.Text.Split('.');
                string idcuenta = cortador[0];
                p.Cuenta = idcuenta;
                p.Empresa = CapaEntidad.idemp;
                CapaNegocio cn = new CapaNegocio();
                p.Status = "1";
                cn.actualizarPoliza(p);
            }
            else if (estado == "eliminar")
            {

                if (MessageBox.Show("Desea eliminar el registro", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CapaEntidad.poliza p = new CapaEntidad.poliza();
                    p.ID1 = textBox1.Text;
                    CapaNegocio cn = new CapaNegocio();
                    cn.eliminarPoliza(p);
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            btnGuardar.Enabled = btnCancelar.Enabled = txtNombre.Enabled = txtTotal.Enabled = cmbCuenta.Enabled = dtpFecha.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estado = "editar";
            btnGuardar.Enabled = btnCancelar.Enabled = txtNombre.Enabled = txtTotal.Enabled = cmbCuenta.Enabled = dtpFecha.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            estado = "eliminar";
            btnGuardar.Enabled = btnCancelar.Enabled = true;
        }
    }
}
