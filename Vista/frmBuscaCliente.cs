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
    public partial class frmBuscaCliente : Form
    {
       frmPuntoVenta frm;
       ContribuyenteModel cliente = new ContribuyenteModel();
       frmContribuyente frmconstribuyente = new frmContribuyente();
            
        public frmBuscaCliente(frmPuntoVenta frmPOS)
        {
           InitializeComponent();
           frm = frmPOS;

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmBuscaCliente_Load(object sender, EventArgs e)
        {
            textBoxNombreCliente.Select();
        }




      /*  private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }*/


        private void buttonAcepta_Click(object sender, EventArgs e)
        {
            try
            {
                //frm.textBoxRut.Select();
                frm.textBoxRutRecep.Text = (String)this.dataGridView1.CurrentRow.Cells["rutRecep"].Value;
                frm.textBoxRut_KeyPress(frm, new KeyPressEventArgs((char)(Keys.Enter)));
                frm.buttonBuscaProducto.Select(); // TODO foco boton 
                this.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClientesSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void textBoxNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)13)
            {
                // MessageBox.Show("Busca Cliente");
                dataGridView1.DataSource = cliente.getContribuyenteXNombre(textBoxNombreCliente.Text.ToUpper());
                dataGridView1.Select();
                
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)13)
            {
                e.Handled = true;
                buttonAcepta.Select();
            }
        }

        private void buttonNuevoCliente_Click(object sender, EventArgs e)
        {
            frmconstribuyente.ShowDialog();
        }






    }
}
