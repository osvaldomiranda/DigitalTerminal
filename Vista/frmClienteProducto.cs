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
    public partial class frmClienteProducto : Form
    {
        frmClientePrecio frmclienteprecio;
        ClienteProductoModel cliProdModel = new ClienteProductoModel();
        public frmClienteProducto()
        {
            InitializeComponent();
        }
        public frmClienteProducto(frmClientePrecio frmclienteprecio)
        {
            InitializeComponent();
            this.frmclienteprecio = frmclienteprecio;
        }

        private void frmClienteProducto_Load(object sender, EventArgs e)
        {
            labelRznSocCli.Text = frmclienteprecio.labelRznCli.Text;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxCodIntProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.dataGridView1.DataSource = new ProductosModel().getProdXCod(this.textBoxCodIntProd.Text);



                if (dataGridView1.RowCount != 0)
                {
                    this.dataGridView1.Select();
                }
                else
                {
                    MessageBox.Show("No se encuentra el producto");
                    this.textBoxCodIntProd.Select();
                    this.textBoxCodIntProd.SelectAll();
                }
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.textBoxCodIntProd.Text = (String)this.dataGridView1.CurrentRow.Cells["codigoInt"].Value;
            this.textBoxNomProd.Text = (String)this.dataGridView1.CurrentRow.Cells["nombre"].Value;
            this.labelIdProducto.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id"].Value);

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)13)
            {
                e.Handled = true;
                textBoxPrcNeto.Select();
                textBoxPrcNeto.TextAlign = HorizontalAlignment.Center;
                textBoxPrcNeto.BackColor = Color.GreenYellow;
                textBoxprcVenta.TextAlign = HorizontalAlignment.Center;
                textBoxprcVenta.BackColor = Color.GreenYellow;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxPrcNeto.Text == "")
            {
                textBoxPrcNeto.Select();
                textBoxPrcNeto.SelectAll();
            }

            else
            {
                if (textBoxprcVenta.Text == "")
                {
                    textBoxprcVenta.Select();
                    textBoxprcVenta.SelectAll();
                }
                else
                {

                    if (cliProdModel.searchProdxCliente(Convert.ToInt32(labelIdProducto.Text), frmclienteprecio.labelRutCli.Text) == "false")
                    {
                        cliProdModel.idProducto = Convert.ToInt32(labelIdProducto.Text);
                        cliProdModel.rutCliente = frmclienteprecio.labelRutCli.Text.ToUpper();
                        cliProdModel.precioNeto = Convert.ToInt32(textBoxPrcNeto.Text);
                        cliProdModel.precioVenta = Convert.ToInt32(textBoxprcVenta.Text);
                        cliProdModel.save(cliProdModel);
                        MessageBox.Show("El precio se agrego al cliente");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El Producto ya esta asignado al cliente");
                    }

                }


            }


        }

        private void textBoxNomProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.dataGridView1.DataSource = new ProductosModel().getProdXNombre(this.textBoxNomProd.Text);



                if (dataGridView1.RowCount != 0)
                {
                    this.dataGridView1.Select();
                }
                else
                {
                    MessageBox.Show("No se encuentra el producto");
                    this.textBoxNomProd.Select();
                    this.textBoxNomProd.SelectAll();
                }
            }
        }
    }
}
