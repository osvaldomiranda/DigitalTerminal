using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;

namespace Vista
{
    public partial class frmClientePrecio : Form
    {
        frmContribuyente frmCli;
        public frmClientePrecio()
        {
            InitializeComponent();
        }
        public frmClientePrecio(frmContribuyente frmCli)
        {
            InitializeComponent();
            this.frmCli = frmCli;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.dataGridView1.DataSource = new ClienteProductoModel().getProdClient(labelRutCli.Text);
            }
               
        }

        private void frmClientePrecio_Load(object sender, EventArgs e)
        {
            labelRutCli.Text = frmCli.textBoxRutCliente.Text;
            labelRznCli.Text = frmCli.textBoxRazonSocial.Text;
            this.dataGridView1.DataSource = new ClienteProductoModel().getProdClient(labelRutCli.Text);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAgrega_Click(object sender, EventArgs e)
        {
            new frmClienteProducto(this).ShowDialog();
        }
    }
}
