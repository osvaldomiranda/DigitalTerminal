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
    public partial class frmBuscaProductos : Form
    {
       frmPuntoVenta frm = new frmPuntoVenta();

       public frmBuscaProductos()
       {
           InitializeComponent();
       }
        public frmBuscaProductos(frmPuntoVenta frmPOS)
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
            if (this.txtCodigo.Text == "")
            {
            }
            else
            {

                
                this.Close();
            }
        }

        private void frmBuscaCliente_Load(object sender, EventArgs e)
        {
            this.txtCodigo.Select();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        
             if (e.KeyChar == (char)13)
            {

                this.dtgwBuscaProductos.DataSource = new ProductosModel().getProdXCod(this.txtCodigo.Text);
                this.dtgwBuscaProductos.Select();

            }
        }


        private void dtgwBuscaProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           // this.txtCodigo.Text = (String)this.dtgwBuscaProductos.CurrentRow.Cells["codigoInt"].Value;
           // this.txtNombre.Text = (String)this.dtgwBuscaProductos.CurrentRow.Cells["nombre"].Value;
        }

        private void frmBuscaProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {

                MessageBox.Show("F1");
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                this.dtgwBuscaProductos.DataSource = new ProductosModel().getProdXNombre(this.txtNombre.Text);
                this.dtgwBuscaProductos.Select();

            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgwBuscaProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void dtgwBuscaProductos_KeyDown(object sender, KeyEventArgs e)
        {
           /* if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                frm.dtgwDetalle.Rows.Add();

            }
            */

            if (e.KeyCode == Keys.Tab && this.dtgwBuscaProductos.CurrentCell.ColumnIndex == 2)
            {
                e.Handled = true; DataGridViewCell cell = this.dtgwBuscaProductos.Rows[0].Cells[0];
                this.dtgwBuscaProductos.CurrentCell = cell; 
                this.dtgwBuscaProductos.BeginEdit(true);
            } 

        }

        private void button3_Click(object sender, EventArgs e)
        {

     

            foreach (DataGridViewRow row in this.dtgwBuscaProductos.Rows)
            {
                String nombre = row.Cells["nombre"].Value.ToString();
                Console.WriteLine(nombre);
            }


                
        }

 

 








    }
}
