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
    public partial class frmArchivosMaestros : Form
    {
        public frmArchivosMaestros()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmPaises().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            new frmContribuyente().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmCiudades().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new frmComunas().ShowDialog();
        }

        private void frmArchivosMaestros_Load(object sender, EventArgs e)
        {

        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            new frmProductos().ShowDialog();
        }
    }
}
