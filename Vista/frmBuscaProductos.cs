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
       private frmPuntoVenta frmPos; 
       ProductosModel producto = new ProductosModel();

       public frmBuscaProductos()
       {
           InitializeComponent();
       }
        public frmBuscaProductos(frmPuntoVenta frmPOS)
        {
            InitializeComponent();
            this.frmPos = frmPOS;
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
                if (dtgwBuscaProductos.RowCount != 0)
                {
                    this.dtgwBuscaProductos.Select();
                }
                else
                {
                    MessageBox.Show("No se encuentra el producto");
                    this.txtCodigo.Select();
                    this.txtCodigo.SelectAll();
                }
            }
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

                this.dtgwBuscaProductos.DataSource = new ProductosModel().getProdXNombre(this.txtNombre.Text.ToUpper());
                this.dtgwBuscaProductos.Select();

            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgwBuscaProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)13)
            {
                e.Handled = true;
                textBoxCantidad.Select();
                textBoxCantidad.TextAlign = HorizontalAlignment.Center;
                textBoxCantidad.BackColor = Color.GreenYellow;
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

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            this.dtgwBuscaProductos.DataSource = new ProductosModel().getProdXNombre(this.txtNombre.Text);
            this.dtgwBuscaProductos.Select();
        }

        private void buttonAgrega_Click(object sender, EventArgs e)
        {
           if(textBoxCantidad.Text !="")
           {
               Decimal precio = (Decimal)this.dtgwBuscaProductos.CurrentRow.Cells["precioNeto"].Value;
            producto.codigoInt = (String)this.dtgwBuscaProductos.CurrentRow.Cells["codigoInt"].Value;
            producto.nombre = (String)this.dtgwBuscaProductos.CurrentRow.Cells["nombre"].Value;
            producto.precioNeto = Decimal.Round(precio, 0);
            frmPos.AddProducto(producto, Convert.ToInt32(textBoxCantidad.Text), labelTotalLinea.Text);
            this.Close();
           } 
           else
           {
               MessageBox.Show("Tiene que ingresar Cantidad");
               textBoxCantidad.Select();
               textBoxCantidad.SelectAll();
               textBoxCantidad.TextAlign = HorizontalAlignment.Center;
               textBoxCantidad.BackColor = Color.GreenYellow;
           }

        }

        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {
                textBoxCantidad.Select();
                Decimal precio = (Decimal)this.dtgwBuscaProductos.CurrentRow.Cells["precioNeto"].Value;
                Int32 cantidad = Convert.ToInt32(textBoxCantidad.Text);
                labelTotalLinea.Text = "" + cantidad * decimal.Round(precio,0);          
        }

        private void textBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)13)
            {
                e.Handled = true;
                buttonAgrega.Select();
            }
        }


        private void dtgwBuscaProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.txtCodigo.Text = (String)this.dtgwBuscaProductos.CurrentRow.Cells["codigoInt"].Value;
            this.txtNombre.Text = (String)this.dtgwBuscaProductos.CurrentRow.Cells["nombre"].Value;

        }



 
    
 

 








    }
}
