using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bancos_Contabilidad
{
    public partial class frmEstadoDeCuenta : Form
    {
        public frmEstadoDeCuenta()
        {
            InitializeComponent();
            llenarCombo();
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = btnEditar.Enabled = btnEliminar.Enabled = false;
            cmbCuenta.SelectedIndex = 0;
        }
        public frmEstadoDeCuenta(string id, string nom)
        {
            InitializeComponent();
            cmbCuenta.Items.Add(id + "." + nom);
            cmbCuenta.SelectedIndex = 0;
            cmbCuenta.Enabled = false;
            btnNuevo.Enabled = btnEditar.Enabled = btnEliminar.Enabled = false;
        }
        public void llenarCombo()
        {
            PruebaConexion.Conexion con = new PruebaConexion.Conexion();
            try
            {
                con.cmd = new SqlCommand("select idcuenta as Codigo, nombre_cuenta as nombre from cuenta where status = 1;", con.cn);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }
        public void ActualizarGrid()
        {
            string[] cortador = cmbCuenta.Text.Split('.');
            string idcuenta = cortador[0];
            dgvEstado.DataSource = CapaEntidad.con.getSQL("select a.idtransaccion as Codigo, cast(fecha as date) as Fecha, a.docref as Descripcion, beneficiario as Beneficiario  , iif(b.accion = '0', CAST(a.saldo as VARCHAR(50)), '') as Debito, iif(b.accion = '1', cast(a.saldo as varchar(50)), '') as Credito from transaccion a inner join tipotrans b on a.idtipotrans = b.idtipotrans where cast(fecha as date) between '"+dateTimePicker1.Text+"' and '"+dateTimePicker2.Text+"' AND idcuenta = '"+idcuenta+"'; ");
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dgvEstado.DataSource = dt;
            
            llenarCombo();
            cmbCuenta.Enabled = true;
        }
    }
}
