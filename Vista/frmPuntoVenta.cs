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
    public partial class frmPuntoVenta : Form
    {
        int n = 0;
        ContribuyenteModel cliente= new ContribuyenteModel();
        DataTable dataTableCliente = new DataTable();
        
        public frmPuntoVenta()
        {
            InitializeComponent();
            
        }

        private void tblpMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            new frmBuscaCliente(this).ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscaProducto_Click(object sender, EventArgs e)
        {
            new frmBuscaProductos(this).ShowDialog();
           
        }

        public DataGridView getDGVDetalle()
        {
            return this.dtgwDetalle;
        }


        private void frmPuntoVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {

                MessageBox.Show("F1");
            }
            if (e.KeyData == Keys.F7)
            {
                new frmBuscaProductos(this).ShowDialog();
               
            }

            if (e.KeyData == Keys.F9)
            {
                MessageBox.Show("Agrega cliente");
            }
        }

        private void btnGeneraDoc_Click(object sender, EventArgs e)
        {
            new frmSelecVenta().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dtgwDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        private void button4_Click(object sender, EventArgs e)
        {
           n = this.dtgwDetalle.Rows.Add();
           this.dtgwDetalle.Rows[n].Cells[0].Value = "-";
           this.dtgwDetalle.Rows[n].Cells[1].Value =  n+1;
           this.dtgwDetalle.Rows[n].Cells[2].Value = "120658";
           this.dtgwDetalle.Rows[n].Cells[3].Value = "PRODUCTO DE PRUEBA 1 58594256854";
           this.dtgwDetalle.Rows[n].Cells[4].Value = "1000";
           this.dtgwDetalle.Rows[n].Cells[5].Value = "1";
           this.dtgwDetalle.Rows[n].Cells[6].Value = "0";
           this.dtgwDetalle.Rows[n].Cells[7].Value =  "1000";
           dtgwDetalle.Focus();
           dtgwDetalle.CurrentCell =this.dtgwDetalle.Rows[n].Cells[5];

        }

     public void frmPuntoVenta_Load(object sender, EventArgs e)
        {
            this.textBoxRut.Select(); 
        }


     private void dtgwDetalle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
     {

    }

     private void dtgwDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
     {
         try
         {
            
            decimal num1 = Convert.ToDecimal(this.dtgwDetalle.CurrentRow.Cells["precio"].Value);
            int num2 = Convert.ToInt32(this.dtgwDetalle.CurrentRow.Cells["cantidad"].Value) ;
            this.dtgwDetalle.CurrentRow.Cells["total"].Value = num1 * num2;
         }
             
         catch (Exception ex)
         {
             Console.WriteLine("" + ex);
         }
     }

     public void textBoxRut_KeyPress(object sender, KeyPressEventArgs e)
     {
         if (e.KeyChar == (int)13)
         {
             if (textBoxRut.Text != "")
             {
                 dataTableCliente = cliente.getContribuyente(textBoxRut.Text);
                 if (dataTableCliente.Rows.Count != 0)
                 {
                     labelNombre.Text = dataTableCliente.Rows[0][1].ToString();
                     labelGiro.Text = dataTableCliente.Rows[0][2].ToString();
                     labelDireccion.Text = dataTableCliente.Rows[0][3].ToString();
                     labelCiudad.Text = dataTableCliente.Rows[0][8].ToString();
                     labelComuna.Text = dataTableCliente.Rows[0][11].ToString();              
                     labelTelefono.Text = dataTableCliente.Rows[0][6].ToString();
                     buttonBuscaProducto.Select();
                     textBoxRut.Enabled = false;

                 }
                 else
                 {
                     MessageBox.Show("No esta Registrado el cliente");
                     textBoxRut.Text = "";
                     // TODO verificar rut
                 }
             }
         }

}

     private void textBoxRut_KeyDown(object sender, KeyEventArgs e)
     {

     }

     private void textBoxRut_Validated(object sender, EventArgs e)
     {
         //textBoxRut.Text = new MetodosComunes().formatearRut(textBoxRut.Text);
     }


     private void buttonBuscaCliente_Click(object sender, EventArgs e)
     
{
         new frmBuscaCliente(this).ShowDialog(); 
    
     }




    }
}
