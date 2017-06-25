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
    public partial class frmTipoCuenta : Form
    {
        public string estado = "";
        public string id = "";
        public frmTipoCuenta()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            txtNombre.Clear();
            cmbEstadoFinanciero.SelectedIndex = -1;
            cmbClasificacion.SelectedIndex = -1;
        }

        public frmTipoCuenta(string sId, string sNombre, string sEstadoFinanciero, string sClasificacion)
        {
            InitializeComponent();
            id = sId;
            txtNombre.Text = sNombre;
            cmbEstadoFinanciero.Text = sEstadoFinanciero;
            cmbClasificacion.Text = sClasificacion;
                
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estado = "insertar";
            limpiar();
            btnGuardar.Enabled = btnCancelar.Enabled = txtNombre.Enabled = cmbEstadoFinanciero.Enabled = cmbClasificacion.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estado = "editar";
            btnGuardar.Enabled = btnCancelar.Enabled = txtNombre.Enabled = cmbEstadoFinanciero.Enabled = cmbClasificacion.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            estado = "eliminar";
            btnGuardar.Enabled = btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (estado == "insertar")
            {
                CapaEntidad.cuentacontable p = new CapaEntidad.cuentacontable();
                p.Nombre = txtNombre.Text;
                p.Estadofinanciero = cmbEstadoFinanciero.Text;
                p.Clasificacion = cmbClasificacion.Text;
                p.Status = "1";
                CapaNegocio cn = new CapaNegocio();
                cn.insertCuentaContable(p);
            }
            else if (estado == "editar")
            {
                CapaEntidad.cuentacontable p = new CapaEntidad.cuentacontable();
                p.ID1 = id;
                p.Nombre = txtNombre.Text;
                p.Estadofinanciero = cmbEstadoFinanciero.Text;
                p.Clasificacion = cmbClasificacion.Text;
                CapaNegocio cn = new CapaNegocio();
                p.Status = "1";
                cn.actualizarCuentaContable(p);
            }
            else if (estado == "eliminar")
             {
                 CapaEntidad.cuentacontable p = new CapaEntidad.cuentacontable();
                 p.ID1 = id;
                 CapaNegocio cn = new CapaNegocio();
                 cn.eliminarCuentaContable(p);
             }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
