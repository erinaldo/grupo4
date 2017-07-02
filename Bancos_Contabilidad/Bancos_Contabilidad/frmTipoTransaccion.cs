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
    public partial class frmTipoTransaccion : Form
    {
        public string estado = "";
        public frmTipoTransaccion()
        {
            InitializeComponent();
            btnGuardar.Enabled = txtNombre.Enabled = txtNombre.Enabled = true;
            btnEditar.Enabled = btnEliminar.Enabled = false;
        
            estado = "insertar";
        }
        public void limpiar()
        {
            txtNombre.Clear();
            txtAccion.Clear();
            cbEstado.SelectedIndex = -1;
        }
        public frmTipoTransaccion(string id, string nombre, string accion, string estado)
        {
            InitializeComponent();
           
            textBox1.Text = id;
            txtNombre.Text = nombre;
            txtAccion.Text = accion;
            cbEstado.Text = estado;
           


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmTipoTransaccion_Load(object sender, EventArgs e)
        {
           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estado = "insertar";
            limpiar();
            btnGuardar.Enabled = btnCancelar.Enabled = txtNombre.Enabled = true;
        }
    
        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            if (estado == "insertar")
            {
                CapaEntidad.tipoTransaccion p = new CapaEntidad.tipoTransaccion();
                p.NombreTrans = txtNombre.Text;
                p.AccionTrans = txtAccion.Text;
                p.EstadoTrans = cbEstado.Text;
                CapaNegocio cn = new CapaNegocio();
                cn.insertTipoTransaccion(p);
                limpiar();
                btnNuevo.Enabled = true;
                btnEditar.Enabled = btnEliminar.Enabled = btnGuardar.Enabled = btnCancelar.Enabled = txtNombre.Enabled = txtNombre.Enabled = false;
                


            }
            else if (estado == "editar")
            {
                CapaEntidad.tipoTransaccion p = new CapaEntidad.tipoTransaccion();
                p.IdTipoTrans = textBox1.Text;
                p.NombreTrans = txtNombre.Text;
                p.AccionTrans = txtAccion.Text;
                p.EstadoTrans = cbEstado.Text;
                CapaNegocio cn = new CapaNegocio();
                cn.actualizarTipoTransaccion(p);
                btnEditar.Enabled = btnEliminar.Enabled = btnNuevo.Enabled = true;
                btnGuardar.Enabled = btnCancelar.Enabled = txtNombre.Enabled = txtNombre.Enabled = false;
            }
            else if (estado == "eliminar")
            {
                CapaEntidad.tipoTransaccion p = new CapaEntidad.tipoTransaccion();
                p.IdTipoTrans = textBox1.Text;
                CapaNegocio cn = new CapaNegocio();
                cn.eliminarTipoTransaccion(p);
                limpiar();
                btnNuevo.Enabled = true;
                btnEditar.Enabled = btnEliminar.Enabled = btnGuardar.Enabled = btnCancelar.Enabled = txtNombre.Enabled = txtNombre.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = btnEditar.Enabled = btnEliminar.Enabled = true;
            btnEditar.Enabled = btnGuardar.Enabled = btnCancelar.Enabled = txtNombre.Enabled = txtAccion.Enabled =  false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estado = "editar";
            btnGuardar.Enabled = btnCancelar.Enabled = txtNombre.Enabled = txtAccion.Enabled  = true;
            btnNuevo.Enabled = btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            estado = "eliminar";
            btnGuardar.Enabled = btnCancelar.Enabled = true;
            btnNuevo.Enabled = btnEditar.Enabled = false;
        }

        private void grupoFiltrar_Enter(object sender, EventArgs e)
        {

        }
    }
    }
    
