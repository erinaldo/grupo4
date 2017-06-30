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
    public partial class frmEstadoResultado : Form
    {
        public frmEstadoResultado()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("Ventas", "1,000,000.00");
            dataGridView1.Rows.Add("Costo de ventas", "500,000.00");
            dataGridView1.Rows.Add("UTILIDAD BRUTA", "500,000.00");
            dataGridView1.Rows.Add("ISR", "155,000.00");
            dataGridView1.Rows.Add("UTILIDAD NETA", "345,000.00");
            
        }
    }
}
