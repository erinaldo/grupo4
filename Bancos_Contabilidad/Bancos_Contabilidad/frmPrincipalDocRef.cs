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
    public partial class frmPrincipalDocRef : Form
    {
        //MRP_BD con = new MRP_BD("sa", "Cocodrilo13", "SAD2017", "JREVMENPC");
        public frmPrincipalDocRef()
        {
            InitializeComponent();
            ActualizarGrid();
        }
        public void ActualizarGrid()
        {
            grdDoc.DataSource = CapaEntidad.con.getSQL("SELECT rtrim(idDocumento) as ID, rtrim(serieDocumento) as Documento, rtrim(descripcon) as Descripcion, rtrim(fecha) as Fecha, rtrim(MONTO) as Monto  FROM DOCUMENTOREF where stat <> '0';");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmDocumentoReferencia doc = new frmDocumentoReferencia();
            doc.StartPosition = FormStartPosition.CenterScreen;
            doc.Show();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void grdDoc_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sid = grdDoc.Rows[grdDoc.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sDocumento = grdDoc.Rows[grdDoc.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string sDescripcion = grdDoc.Rows[grdDoc.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string sFecha = grdDoc.Rows[grdDoc.CurrentCell.RowIndex].Cells[3].Value.ToString();
            string sMonto = grdDoc.Rows[grdDoc.CurrentCell.RowIndex].Cells[4].Value.ToString();
            frmDocumentoReferencia temp = new frmDocumentoReferencia(sid, sDocumento, sDescripcion, sFecha, sMonto);
            temp.StartPosition = FormStartPosition.CenterScreen;
            temp.Show();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (cmbBuscar.Text == "Codigo")
            {
                grdDoc.DataSource = CapaEntidad.con.getSQL("SELECT rtrim(idDocumento) as ID, rtrim(serieDocumento) as Documento, rtrim(descripcon) as Descripcion, rtrim(fecha) as Fecha, rtrim(MONTO) as Monto  FROM DOCUMENTOREF where stat <> '0' AND idDocumento LIKE '" + txtBuscar.Text + "%'");
            }
            else if (cmbBuscar.Text == "Documento")
            {
                grdDoc.DataSource = CapaEntidad.con.getSQL("SELECT rtrim(idDocumento) as ID, rtrim(serieDocumento) as Documento, rtrim(descripcon) as Descripcion, rtrim(fecha) as Fecha, rtrim(MONTO) as Monto  FROM DOCUMENTOREF where stat <> '0'AND serieDocumento LIKE '" + txtBuscar.Text + "%'");
            }
            else if (cmbBuscar.Text == "Descripcion")
            {
                grdDoc.DataSource = CapaEntidad.con.getSQL("SELECT rtrim(idDocumento) as ID, rtrim(serieDocumento) as Documento, rtrim(descripcon) as Descripcion, rtrim(fecha) as Fecha, rtrim(MONTO) as Monto  FROM DOCUMENTOREF where stat <> '0' AND descripcon LIKE '" + txtBuscar.Text + "%'");
            }
            else if (cmbBuscar.Text == "Monto")
            {
                grdDoc.DataSource = CapaEntidad.con.getSQL("SELECT rtrim(idDocumento) as ID, rtrim(serieDocumento) as Documento, rtrim(descripcon) as Descripcion, rtrim(fecha) as Fecha, rtrim(MONTO) as Monto  FROM DOCUMENTOREF where stat <> '0' AND MONTO LIKE '" + txtBuscar.Text + "%'");
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
