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
        public string codPoliza = "";

        #region Constructores del formulario
        public frmPoliza()
        {
            InitializeComponent();
            llenarCombo();
            dgvDetalle.Enabled = rbDebe.Enabled = rbHaber.Enabled = btnQuitar.Enabled = btnAgregar.Enabled = btnGuardar.Enabled = txtValor.Enabled = txtNombre.Enabled = txtDescripcion.Enabled = cmbCuenta.Enabled = dtpFecha.Enabled = true;
            btnNuevo.Enabled = btnEditar.Enabled = btnEliminar.Enabled = false;
            estado = "insertar";
        }

        public frmPoliza(string id, string nom, string desc, string fecha)
        {
            InitializeComponent();
            llenarCombo();
            txtNombre.Text = nom;
            txtDescripcion.Text = desc;
            fecha.Replace('-', '/');
            dtpFecha.Value = DateTime.Parse(fecha);
            codPoliza = id;
            PruebaConexion.Conexion con = new PruebaConexion.Conexion();
            try
            {
                con.cmd = new SqlCommand("select concat(RTRIM(CUENTACONTABLE.nomenclatura),'-',RTRIM(CUENTACONTABLE.nombre)), RTRIM(detallepoliza.clasificacion), RTRIM(valor) from DETALLEPOLIZA, CUENTACONTABLE where idPoliza = '"+codPoliza+"' and detallepoliza.idcuenta = cuentacontable.idcuenta", con.cn);
                con.dr = con.cmd.ExecuteReader();
                int i = 0;
                while (con.dr.Read())
                {

                    if(con.dr.GetString(1) == "Debe")
                    {
                        dgvDetalle.Rows.Add(con.dr.GetString(0), con.dr.GetString(2),"");
                    }
                    else if (con.dr.GetString(1) == "Haber")
                    {
                        dgvDetalle.Rows.Add(con.dr.GetString(0),"", con.dr.GetString(2));
                    }
                    i++;
                }
                con.dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar los registros del detalle " + ex);
            }
        }
        #endregion

        #region Funciones visuales - Eventos
        public void limpiar()
        {
            txtNombre.Clear();
            txtValor.Clear();
            txtDescripcion.Clear();
            cmbCuenta.SelectedIndex = -1;
            rbDebe.Checked = rbHaber.Checked = false;
            dgvDetalle.Rows.Clear();
            dgvDetalle.Refresh();
        }

        public void llenarCombo()
        {
            PruebaConexion.Conexion con = new PruebaConexion.Conexion();
            try
            {
                con.cmd = new SqlCommand("Select rtrim(nomenclatura), rtrim(nombre) from CUENTACONTABLE", con.cn);
                con.dr = con.cmd.ExecuteReader();
                cmbCuenta.Items.Clear();
                while (con.dr.Read())
                {
                    cmbCuenta.Items.Add(con.dr.GetString(0) + "-" + con.dr.GetString(1));
                }
                con.dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar las cuentas contables "+ex);
            }
        }

        private void dgvDetalle_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblDebe.Text = lblHaber.Text = "0";
            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                if (row.Cells[1].Value.ToString() != "")
                    lblDebe.Text = (Double.Parse(lblDebe.Text) + Double.Parse(row.Cells[1].Value.ToString())).ToString();
                if (row.Cells[2].Value.ToString() != "")
                    lblHaber.Text = (Double.Parse(lblHaber.Text) + Double.Parse(row.Cells[2].Value.ToString())).ToString();
            }
        }

        private void dgvDetalle_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblDebe.Text = lblHaber.Text = "0";
            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                if (row.Cells[1].Value.ToString() != "")
                    lblDebe.Text = (Double.Parse(lblDebe.Text) + Double.Parse(row.Cells[1].Value.ToString())).ToString();
                if (row.Cells[2].Value.ToString() != "")
                    lblHaber.Text = (Double.Parse(lblHaber.Text) + Double.Parse(row.Cells[2].Value.ToString())).ToString();
            }
        }
        #endregion

        #region Botones Navegador
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estado = "insertar";
            limpiar();
            dgvDetalle.Enabled = rbDebe.Enabled = rbHaber.Enabled = btnQuitar.Enabled = btnAgregar.Enabled = btnGuardar.Enabled = btnCancelar.Enabled = txtValor.Enabled = txtNombre.Enabled = txtDescripcion.Enabled = cmbCuenta.Enabled = dtpFecha.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(estado == "insertar")
            {
                CapaEntidad.poliza p = new CapaEntidad.poliza();
                CapaEntidad.DetallePoliza dp = new CapaEntidad.DetallePoliza();
                p.Nombre = txtNombre.Text;
                p.Descripcion = txtDescripcion.Text;
                p.Fecha = dtpFecha.Text;
                p.Empresa = CapaEntidad.idemp;
                p.Status = "1";

                if(lblDebe.Text != lblHaber.Text)
                {
                    if (MessageBox.Show("La poliza no cuadra aun desea guardar el registro?", "Descuadre!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        CapaNegocio cn = new CapaNegocio();
                        cn.insertPoliza(p);

                        PruebaConexion.Conexion con = new PruebaConexion.Conexion();
                        try
                        {
                            con.cmd = new SqlCommand("select max(idpoliza) from POLIZA", con.cn);
                            con.dr = con.cmd.ExecuteReader();
                            if (con.dr.Read())
                                dp.Poliza1 = con.dr.GetInt32(0).ToString();
                            con.dr.Close();
                            cn.insertDetallePoliza(dp, dgvDetalle);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se pudo obtener el encabezado de la poliza " + ex);
                        }

                        limpiar();
                        btnNuevo.Enabled = true;
                        dgvDetalle.Enabled = rbDebe.Enabled = rbHaber.Enabled = btnQuitar.Enabled = btnAgregar.Enabled = btnEditar.Enabled = btnEliminar.Enabled = btnGuardar.Enabled = btnCancelar.Enabled = txtValor.Enabled = txtNombre.Enabled = txtDescripcion.Enabled = cmbCuenta.Enabled = dtpFecha.Enabled = false;
                    }
                }else
                {
                    CapaNegocio cn = new CapaNegocio();
                    cn.insertPoliza(p);

                    PruebaConexion.Conexion con = new PruebaConexion.Conexion();
                    try
                    {
                        con.cmd = new SqlCommand("select max(idpoliza) from POLIZA", con.cn);
                        con.dr = con.cmd.ExecuteReader();
                        if (con.dr.Read())
                            dp.Poliza1 = con.dr.GetInt32(0).ToString();
                        con.dr.Close();
                        cn.insertDetallePoliza(dp, dgvDetalle);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo obtener el encabezado de la poliza " + ex);
                    }

                    limpiar();
                    btnNuevo.Enabled = true;
                    dgvDetalle.Enabled = rbDebe.Enabled = rbHaber.Enabled = btnQuitar.Enabled = btnAgregar.Enabled = btnEditar.Enabled = btnEliminar.Enabled = btnGuardar.Enabled = btnCancelar.Enabled = txtValor.Enabled = txtNombre.Enabled = txtDescripcion.Enabled = cmbCuenta.Enabled = dtpFecha.Enabled = false;
                }
                
            }
            else if(estado == "editar")
            {
                CapaEntidad.poliza p = new CapaEntidad.poliza();
                CapaEntidad.DetallePoliza dp = new CapaEntidad.DetallePoliza();
                p.ID1 = codPoliza;
                dp.Poliza1 = codPoliza;
                p.Nombre = txtNombre.Text;
                p.Descripcion = txtDescripcion.Text;
                p.Fecha = dtpFecha.Text;
                p.Empresa = CapaEntidad.idemp;
                p.Status = "1";
                
                CapaNegocio cn = new CapaNegocio();
                cn.actualizarPoliza(p);
                cn.editarDetallePoliza(dp,dgvDetalle);

                btnEditar.Enabled = btnEliminar.Enabled = btnNuevo.Enabled = true;
                dgvDetalle.Enabled = btnAgregar.Enabled = btnGuardar.Enabled = btnCancelar.Enabled = txtValor.Enabled = txtNombre.Enabled = txtDescripcion.Enabled = cmbCuenta.Enabled = dtpFecha.Enabled = false;
            }
            else if (estado == "eliminar")
            {

                if (MessageBox.Show("Desea eliminar el registro", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CapaEntidad.poliza p = new CapaEntidad.poliza();
                    p.ID1 = codPoliza;
                    CapaNegocio cn = new CapaNegocio();
                    cn.eliminarPoliza(p);
                    limpiar();
                    btnNuevo.Enabled = true;
                    dgvDetalle.Enabled = btnAgregar.Enabled = btnEditar.Enabled = btnEliminar.Enabled = btnGuardar.Enabled = btnCancelar.Enabled = txtValor.Enabled = txtNombre.Enabled = txtDescripcion.Enabled = cmbCuenta.Enabled = dtpFecha.Enabled = false;
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled= true;
            dgvDetalle.Enabled = rbDebe.Enabled = rbHaber.Enabled = btnQuitar.Enabled = btnAgregar.Enabled = btnEditar.Enabled = btnGuardar.Enabled = btnEliminar.Enabled = btnCancelar.Enabled = txtValor.Enabled = txtNombre.Enabled = txtDescripcion.Enabled = cmbCuenta.Enabled = dtpFecha.Enabled = false;
            limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estado = "editar";
            dgvDetalle.Enabled = rbDebe.Enabled = rbHaber.Enabled = btnQuitar.Enabled = btnAgregar.Enabled = btnGuardar.Enabled = btnCancelar.Enabled = txtValor.Enabled = txtNombre.Enabled = txtDescripcion.Enabled = cmbCuenta.Enabled = dtpFecha.Enabled = true;
            btnNuevo.Enabled = btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            estado = "eliminar";
            btnGuardar.Enabled = btnCancelar.Enabled = true;
            dgvDetalle.Enabled = rbDebe.Enabled = rbHaber.Enabled = btnQuitar.Enabled = btnAgregar.Enabled = btnNuevo.Enabled = btnEditar.Enabled = false;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            llenarCombo();
            dgvDetalle.Refresh();
        }
        #endregion

        #region Botones Detalle
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbCuenta.Text) || string.IsNullOrWhiteSpace(txtValor.Text) || (!rbDebe.Checked && !rbHaber.Checked))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Boolean estado = false;
                foreach (DataGridViewRow row in dgvDetalle.Rows)
                {
                    if(row.Cells[0].Value.ToString() == cmbCuenta.Text)
                    {
                        estado = true;
                    }
                    else
                    {
                        estado = false;
                    }
                }

                if(estado == false)
                {
                    if (rbHaber.Checked)
                    {
                        dgvDetalle.Rows.Add(cmbCuenta.Text, "", txtValor.Text);
                    }
                    else if (rbDebe.Checked)
                    {
                        dgvDetalle.Rows.Add(cmbCuenta.Text, txtValor.Text, "");
                    }
                }
                else
                {
                    MessageBox.Show("Esa cuenta ya esta en la partida");
                }
                
            }
            txtValor.Clear();
            cmbCuenta.SelectedIndex = -1;
            rbDebe.Checked = rbHaber.Checked = false;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dgvDetalle.SelectedCells)
            {
                if (oneCell.Selected)
                    dgvDetalle.Rows.RemoveAt(oneCell.RowIndex);
            }
        }
        #endregion
    }
}
