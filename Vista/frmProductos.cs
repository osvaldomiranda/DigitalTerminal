﻿using System;
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
    public partial class frmProductos : Form
    {
        MetodosComunes metodoscomunes = new MetodosComunes();
        public frmProductos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ProductosModel producto = new ProductosModel();
                producto.nombre = textBoxNombre.Text;
                producto.codigoInt = textBoxCodInt.Text;
                producto.precioNeto = Convert.ToDecimal(textBoxPrecioNeto.Text);
                producto.precioventa = Convert.ToInt32(textBoxPrecioBruto.Text);
                producto.exento = checkBoxExento.Checked.ToString() ;
                producto.save(producto);
                MessageBox.Show(" El Producto se Guardo con Exito");
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar: "+ ex);
  
            }
        }


        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {

        }

    }
}
