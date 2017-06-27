using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bancos_Contabilidad
{
    public partial class frmCuentaBancaria : Form
    {
        public string estado = "";
        public frmCuentaBancaria()
        {
            InitializeComponent();
            llenarCombo();
        }
        public void limpiar()
        {
            txtNombre.Clear();
            txtNumero.Clear();
            txtSaldo.Clear();
            cbBancos.SelectedIndex = -1;
        }

        public frmCuentaBancaria(string id,  string nombre, string numero, string saldoCuenta, string banco,string emp)
        {
            InitializeComponent();
            llenarCombo();
            textBox1.Text = id;
            txtNombre.Text = nombre;
            txtNumero.Text = numero;
            txtSaldo.Text  =  saldoCuenta;
            cbBancos.Text = banco;
            cbEmpresa.Text = emp;
            
            
        }
        public void llenarCombo()
        {
            PruebaConexion.Conexion con = new PruebaConexion.Conexion();
            try
            {
                con.cmd = new SqlCommand("Select idempresa,nombre_empresa  from empresa", con.cn);
                con.dr = con.cmd.ExecuteReader();
                DataTable dt = new DataTable();
                cbBancos.Items.Clear();
                while (con.dr.Read())
                {
                    cbEmpresa.Items.Add(con.dr.GetInt32(0).ToString() + "." + con.dr.GetString(1));
                }
                con.dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
        }
        private void frmCuentaBancaria_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estado = "insertar";
            limpiar();
            btnGuardar.Enabled = btnCancelar.Enabled = txtNombre.Enabled = txtNumero.Enabled = cbBancos.Enabled  = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (estado == "insertar")
            {
                CapaEntidad.cuentaBancos p = new CapaEntidad.cuentaBancos();
                p.Saldo = txtSaldo.Text;
                p.Nombre_cuenta= txtNombre.Text;
                p.Numero_cuenta = txtNumero.Text;
                p.Banco = cbBancos.Text;
                string[] cortador = cbEmpresa.Text.Split('.');
                p.ID_EMP1 = cortador[0];
                p.Activo = cbActivo.Text;
                p.Estado = "1";
                CapaNegocio cn = new CapaNegocio();
                cn.insertCuenta(p);
                limpiar();
            }
            else if (estado == "editar")
            {
                CapaEntidad.cuentaBancos p = new CapaEntidad.cuentaBancos();
                p.ID_CUENTA1 = textBox1.Text;
                p.Saldo = txtSaldo.Text;
                p.Nombre_cuenta = txtNombre.Text;
                p.Numero_cuenta = txtNumero.Text;
                p.Banco = cbBancos.Text;
                string[] cortador = cbEmpresa.Text.Split('.');
                p.ID_EMP1 = cortador[0];
                p.Activo = cbActivo.Text;
                p.Estado = "1";
                CapaNegocio cn = new CapaNegocio();
                cn.actualizarCuenta(p);
            }
            else if (estado == "eliminar")
            {
                CapaEntidad.cuentaBancos p = new CapaEntidad.cuentaBancos();
                p.ID_EMP1 = textBox1.Text;
                CapaNegocio cn = new CapaNegocio();
                cn.eliminarCuenta(p);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            btnGuardar.Enabled = btnCancelar.Enabled = txtNombre.Enabled = txtNumero.Enabled = cbBancos.Enabled = txtSaldo.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estado = "editar";
            btnGuardar.Enabled = btnCancelar.Enabled = txtNombre.Enabled = txtNumero.Enabled = cbBancos.Enabled  = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            estado = "eliminar";
            btnGuardar.Enabled = btnCancelar.Enabled = true;
        }
    }
}
   

