using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            this.btnPedidos.Select();
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {

            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }


        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmPaises().ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            new frmPuntoVenta().ShowDialog();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            new frmArchivosMaestros().ShowDialog();
        }
    }
}
