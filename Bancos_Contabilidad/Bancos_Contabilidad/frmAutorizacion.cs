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
    public partial class frmAutorizacion : Form
    {
        public string estado = "";
        CapaEntidad.Autorizacion p = new CapaEntidad.Autorizacion();
        public frmAutorizacion()
        {
            InitializeComponent();
            
            comboBox1.SelectedIndex = 0;
            ActualizarGrid();
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = btnEditar.Enabled = btnEliminar.Enabled = false;
            estado = "insertar";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTotal.Text = "0.00";
            checkBox1.Checked = false;
            ActualizarGrid();
        }
        public void ActualizarGrid()
        {

            if (comboBox1.SelectedIndex == 0)
            {
                p.Tipopago = "3";
                p.Estado = "cxc";
                
                dataGridView1.DataSource = CapaEntidad.con.getSQL("select idordencompra as Codigo, observacion as Observacion, fecha_creacion as Fecha, total as Total from OrdenCompra where idAutorizacion is null;");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                p.Tipopago = "3";

                p.Estado = "orderserv";
                dataGridView1.DataSource = CapaEntidad.con.getSQL("select idordenserv as Codigo, facturataller as Observacion, fechaservicio as Fecha, monto as Total from mordenserviciov where idAutorizacion is null;");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                p.Tipopago = "3";
                p.Estado = "capa";
                
                dataGridView1.DataSource = CapaEntidad.con.getSQL("select idcapacitacion as Codigo, nombre as Observacion, fechapago as Fecha, costo as Total from capacitacion where idautorizacion is null;");
            }
            //}else if (comboBox1.SelectedIndex == 3)
            //{
            //    p.Tipopago = "3";
            //    p.Estado = "camp";
            //    dataGridView1.DataSource = CapaEntidad.con.getSQL("select idcampania as Codigo, nomcampania as Observacion, fechainicio as Fecha, costcampania as Total from campania where idautorizacion is null;");
            //}
            else if (comboBox1.SelectedIndex == 3)
            {
                p.Tipopago = "1";
                p.Estado = "planilla";
                
                dataGridView1.DataSource = CapaEntidad.con.getSQL("select a.iddetalleplanilla as Codigo, Concat(c.nombre1, ' ',c.nombre2, ' ', c.apellido1, ' ', c.apellido2) as Nombre, getdate() as Fecha ,a.total as Total from detalleplanilla a inner join empleado b on a.idempleado = b.idempleado inner join detallepersonal c on b.idempleado = c.idempleado where a.idAutorizacion is null; ");
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                p.Tipopago = "3";
                p.Estado = "trans";
                dataGridView1.DataSource = CapaEntidad.con.getSQL("");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            double total = Convert.ToDouble(lblTotal.Text);
            if (e.RowIndex == -1)
                return;

            if (dataGridView1.Columns[e.ColumnIndex].Index == 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                DataGridViewCheckBoxCell cellSelecion = row.Cells[0] as DataGridViewCheckBoxCell;

        
                if (Convert.ToBoolean(cellSelecion.Value) == true)
                {
                        total = total + Convert.ToDouble(row.Cells[4].Value);
                        lblTotal.Text = Convert.ToString(total);
                }
                else
                {
                        total = total - Convert.ToDouble(row.Cells[4].Value);
                        lblTotal.Text = Convert.ToString(total);
                    checkBox1.CheckState = CheckState.Unchecked;
                }
            }

        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (estado == "insertar")
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        if (comboBox1.SelectedIndex == 3)
                        {
                            p.Beneficiario = row.Cells[2].Value.ToString();
                            p.Descripcion = "pago planilla";
                        }
                        else
                        {
                            p.Beneficiario = "";
                            p.Descripcion = row.Cells[2].Value.ToString();
                        }
                       // CapaEntidad.Autorizacion p = new CapaEntidad.Autorizacion();
                        p.Id = row.Cells[1].Value.ToString();
                        
                        p.Monto = row.Cells[4].Value.ToString();
                        CapaNegocio cn = new CapaNegocio();
                        cn.insertarAutorizacion(p);
                        btnNuevo.Enabled = true;
                        btnEditar.Enabled = btnEliminar.Enabled = btnGuardar.Enabled = btnCancelar.Enabled = comboBox1.Enabled = false;
                    }
                }
            }
            checkBox1.Checked = false;
            lblTotal.Text = "0.00";
            ActualizarGrid();
        }

        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            double total = 0;
            if (checkBox1.Checked == true)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[0].Value = true;
                    total = total + Convert.ToDouble(row.Cells[4].Value);
                    lblTotal.Text = Convert.ToString(total);
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[0].Value = false;
                    lblTotal.Text = "0.00";
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            comboBox1.Enabled = true;
            estado = "insertar";
        }
    }
}
