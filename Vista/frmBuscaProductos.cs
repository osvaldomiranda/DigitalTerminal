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
       Detalle detalle = new Detalle();
       ConfigModel config = new ConfigModel();
       ClienteProductoModel clienteProdM = new ClienteProductoModel();  
       

       public frmBuscaProductos()
       {
           InitializeComponent();
       }
        public frmBuscaProductos(frmPuntoVenta frmPOS)
        {
            InitializeComponent();
            this.frmPos = frmPOS;
            config.getConfig();
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
                if (config.clienteProducto == "True")
                {
                    this.dtgwBuscaProductos.DataSource = new ClienteProductoModel().getProdClientXCod(frmPos.textBoxRutRecep.Text, this.txtCodigo.Text);
                }
                else
                {
                    this.dtgwBuscaProductos.DataSource = new ProductosModel().getProdXCod(this.txtCodigo.Text);
                }
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
                if (config.clienteProducto == "True")
                {

                    this.dtgwBuscaProductos.DataSource = new ClienteProductoModel().getProdClientXNom(frmPos.textBoxRutRecep.Text,this.txtNombre.Text.ToUpper());
                    this.dtgwBuscaProductos.Select();
                }
                else
                {

                    this.dtgwBuscaProductos.DataSource = new ProductosModel().getProdXNombre(this.txtNombre.Text.ToUpper());
                    this.dtgwBuscaProductos.Select();
                }

                if (dtgwBuscaProductos.RowCount != 0)
                {
                    this.dtgwBuscaProductos.Select();
                }
                else
                {
                    MessageBox.Show("No se encuentra el producto");
                    this.txtNombre.Select();
                    this.txtNombre.SelectAll();
                }
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
            Decimal dctoPrc = 0;
            int descuentoMontoBruto = 0;
           if(textBoxCantidad.Text !="")
           {
            producto.codigoInt = (String)this.dtgwBuscaProductos.CurrentRow.Cells["codigoInt"].Value;
            producto.nombre = (String)this.dtgwBuscaProductos.CurrentRow.Cells["nombre"].Value;
            producto.precioNeto = Convert.ToDecimal(this.dtgwBuscaProductos.CurrentRow.Cells["PrecioNeto"].Value);
            producto.precioventa = Convert.ToInt32(this.dtgwBuscaProductos.CurrentRow.Cells["precioVenta"].Value);
            producto.exento = (String)this.dtgwBuscaProductos.CurrentRow.Cells["exento"].Value;
            detalle.QtyItem = Convert.ToInt32(textBoxCantidad.Text);

            if (textBoxDctoPrc.Text == "" || textBoxDctoPrc.Text == "0")
            {
                dctoPrc = 1;
            }
            else
            {
                dctoPrc = Convert.ToDecimal(textBoxDctoPrc.Text) / 100;
                detalle.DescuentoPct = dctoPrc;
                detalle.DescuentoMonto = Convert.ToInt32(Convert.ToDecimal(labelLineaNeto.Text) * dctoPrc);
                descuentoMontoBruto = Convert.ToInt32(Convert.ToInt32(labelTotalLinea.Text) * dctoPrc);
            }
            
            detalle.MontoItem = Convert.ToInt32( Decimal.Round(Convert.ToDecimal(labelLineaNeto.Text)) - detalle.DescuentoMonto);
            detalle.MontoBruItem = Convert.ToInt32(Convert.ToInt32(labelTotalLinea.Text)) - descuentoMontoBruto; 
            frmPos.AddProducto(producto, detalle);
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
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxCantidad.Text, "[^0-9]"))
            {
                MessageBox.Show("solo se permiten numeros en la cantidad");
                textBoxCantidad.Text = ""; 
                textBoxCantidad.Select();
            }
            else
            {
                if (textBoxCantidad.Text != "" && dtgwBuscaProductos.Rows.Count != 0 )
                {
                    textBoxCantidad.Select();
                    Decimal precioNeto = (Decimal)this.dtgwBuscaProductos.CurrentRow.Cells["precioNeto"].Value;
                    Decimal precio = (Decimal)this.dtgwBuscaProductos.CurrentRow.Cells["precioVenta"].Value;
                    Int32 cantidad = Convert.ToInt32(textBoxCantidad.Text);
                    labelTotalLinea.Text = "" + (cantidad * decimal.Round(precio, 0));
                    labelLineaNeto.Text = "" + (cantidad * precioNeto);
                }
            }
                
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

        private void textBoxCantidad_Validated(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxCantidad.Text, "[^0-9]"))
            {
                MessageBox.Show("LA CANTIDAD SOLO CON NUMEROS ENTEROS");
            }
        }



 
    
 

 








    }
}
