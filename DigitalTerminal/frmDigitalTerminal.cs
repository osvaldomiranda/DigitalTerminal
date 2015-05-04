using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DigitalTerminal
{
    public partial class frmDigitalTerminal : Form
    {
        public frmDigitalTerminal()
        {
            InitializeComponent();
        }

        private void frmDigitalTerminal_Load(object sender, EventArgs e)
        {
            dtgwDetalle.Rows.Add("1","1234","CUADERNO DE 100 HOJAS","1","1000","0","1000");        
 
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgwDigitalTerminal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
