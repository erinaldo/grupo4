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
    public partial class frmDocumentoReferencia : Form
    {
        public string estado = "";
        public string Sid = string.Empty;
        public frmDocumentoReferencia()
        {
            InitializeComponent();
            txtDescripcion.Enabled = txtDocumento.Enabled = txtMonto.Enabled = btnGuardar.Enabled = true;
            btnNuevo.Enabled = btnEditar.Enabled = btnEliminar.Enabled = false;
            estado = "insertar";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public frmDocumentoReferencia(string id, string doc, string desc, string fecha, string tot)
        {
            InitializeComponent();
            txtDescripcion.Text = desc;
            txtDocumento.Text = doc;
            txtMonto.Text = tot;
             Sid= id;
        }
        public void limpiar()
        {
            txtDocumento.Clear();
            txtDescripcion.Clear();
            txtMonto.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estado = "insertar";
            limpiar();
            btnGuardar.Enabled = btnCancelar.Enabled = txtDocumento.Enabled = txtDescripcion.Enabled = txtMonto.Enabled  = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (estado == "insertar")
            {
                CapaEntidad.DocumentoRef p = new CapaEntidad.DocumentoRef();
                p.Descripcion1 = txtDescripcion.Text;
                p.Documento1 = txtDocumento.Text;
                p.Total = txtMonto.Text;
                p.Estado = "1";
                CapaNegocio cn = new CapaNegocio();
                cn.insertarDocRef(p);
                limpiar();
                btnNuevo.Enabled = true;
                btnEditar.Enabled = btnEliminar.Enabled = btnGuardar.Enabled = btnCancelar.Enabled = txtDescripcion.Enabled = txtMonto.Enabled = txtDocumento.Enabled = false;
            }
            else if (estado == "editar")
            {
                CapaEntidad.DocumentoRef p = new CapaEntidad.DocumentoRef();
                p.Descripcion1 = txtDescripcion.Text;
                p.Documento1 = txtDocumento.Text;
                p.Total = txtMonto.Text;
                p.Estado = "1";
                p.ID1 = Sid;
                CapaNegocio cn = new CapaNegocio();
                cn.actualizarDocRef(p);
                btnEditar.Enabled = btnEliminar.Enabled = btnNuevo.Enabled = true;
                btnGuardar.Enabled = btnCancelar.Enabled = txtDescripcion.Enabled = txtMonto.Enabled = txtDocumento.Enabled = false;
            }
            else if (estado == "eliminar")
            {
                if (MessageBox.Show("Desea eliminar el registro", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CapaEntidad.DocumentoRef p = new CapaEntidad.DocumentoRef();
                    p.ID1 = Sid;
                    CapaNegocio cn = new CapaNegocio();
                    cn.eliminarDocRef(p);
                    limpiar();
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = btnEliminar.Enabled = btnGuardar.Enabled = btnCancelar.Enabled = txtDescripcion.Enabled = txtMonto.Enabled = txtDocumento.Enabled = false;
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            btnNuevo.Enabled = btnEditar.Enabled = btnEliminar.Enabled = true;
            btnEditar.Enabled = btnGuardar.Enabled = btnCancelar.Enabled = txtDescripcion.Enabled = txtMonto.Enabled = txtDocumento.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estado = "editar";
            btnGuardar.Enabled = btnCancelar.Enabled = txtDescripcion.Enabled = txtMonto.Enabled = txtDocumento.Enabled  = true;
            btnNuevo.Enabled = btnEliminar.Enabled = false;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            estado = "eliminar";
            btnGuardar.Enabled = btnCancelar.Enabled = true;
            btnNuevo.Enabled = btnEditar.Enabled = false;
        }
    }
}
