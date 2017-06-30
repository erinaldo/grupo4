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
    public partial class PrincipalOrdenCompra : Form
    {
        public PrincipalOrdenCompra()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("ACTIVO","");
            dataGridView1.Rows.Add("ACTIVO CORRIENTE","");
            dataGridView1.Rows.Add("Caja", "1,000,000.00");
            dataGridView1.Rows.Add("ACTIVO NO CORRIENTE", "");
            dataGridView1.Rows.Add("Vehiculo", "209,209.09");
            dataGridView1.Rows.Add("TOTAL ACTIVO", "1,209,800.09");
            dataGridView1.Rows.Add("PASIVO", "");
            dataGridView1.Rows.Add("PASIVO CORRIENTE", "");
            dataGridView1.Rows.Add("Proveedores", "209,800.09");
            dataGridView1.Rows.Add("TOTAL PASIVO", "1,000,000.00");
            dataGridView1.Rows.Add("PATRIMONIO", "");
            dataGridView1.Rows.Add("Capital Pagado", "1,000,000.00");
            dataGridView1.Rows.Add("TOTAL PASIVO Y PATRIMONIO", "1,209,800.09");
        }
    }
}
