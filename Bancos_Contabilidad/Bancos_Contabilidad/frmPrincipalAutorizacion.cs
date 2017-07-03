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
    public partial class frmPrincipalAutorizacion : Form
    {
        
        //MRP_BD con = new MRP_BD("sa", "Cocodrilo13", "SAD2017", "JREVMENPC");
        public frmPrincipalAutorizacion()
        {
            InitializeComponent();
            ActualizarGrid();
            
        }

        public void ActualizarGrid()
        {
            grdDoc.DataSource = CapaEntidad.con.getSQL("select idautorizacion as Codigo, descripcion as Descripcion, fecha as Fecha, Monto as Total from Autorizacion order by fecha desc;");
        }

        private void frmPrincipalAutorizacion_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmAutorizacion autorizacion = new frmAutorizacion();
            autorizacion.StartPosition = FormStartPosition.CenterScreen;
            autorizacion.Show();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void grdDoc_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (cmbBuscar.Text == "Codigo")
            {
                grdDoc.DataSource = CapaEntidad.con.getSQL("select idautorizacion as Codigo, descripcion as Descripcion, fecha as Fecha, Monto as Total from Autorizacion  Where idautorizacion LIKE '" + txtBuscar.Text + "%'  order by fecha desc");
            }
            else if (cmbBuscar.Text == "Fecha")
            {
                grdDoc.DataSource = CapaEntidad.con.getSQL("select idautorizacion as Codigo, descripcion as Descripcion, fecha as Fecha, Monto as Total from Autorizacion Where fecha LIKE '" + txtBuscar.Text + "%'  order by fecha desc");
            }
            else if (cmbBuscar.Text == "Descripcion")
            {
                grdDoc.DataSource = CapaEntidad.con.getSQL("select idautorizacion as Codigo, descripcion as Descripcion, fecha as Fecha, Monto as Total from Autorizacion Where descripcion LIKE '" + txtBuscar.Text + "%'  order by fecha desc");
            }
            else if (cmbBuscar.Text == "Monto")
            {
                grdDoc.DataSource = CapaEntidad.con.getSQL("select idautorizacion as Codigo, descripcion as Descripcion, fecha as Fecha, Monto as Total from Autorizacion Where Monto LIKE '" + txtBuscar.Text + "%'  order by fecha desc");
            }

        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            grdDoc.Rows[0].Selected = true;
            grdDoc.CurrentCell = grdDoc.Rows[0].Cells[0];
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            int valor = grdDoc.CurrentCell.RowIndex;
            int max = grdDoc.Rows.Count - 2;
            valor = valor - 1;
            if (valor >= 0)
            {
                grdDoc.Rows[valor].Selected = true;
                grdDoc.CurrentCell = grdDoc.Rows[valor].Cells[0];
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int valor = grdDoc.CurrentCell.RowIndex;
            int max = grdDoc.Rows.Count - 2;
            valor = valor + 1;
            if (valor <= max)
            {
                grdDoc.Rows[valor].Selected = true;
                grdDoc.CurrentCell = grdDoc.Rows[valor].Cells[0];
            }
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            int max = grdDoc.Rows.Count - 2;
            grdDoc.Rows[max].Selected = true;
            grdDoc.CurrentCell = grdDoc.Rows[max].Cells[0];
        }
    }
}
