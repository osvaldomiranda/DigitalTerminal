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
    public partial class frmPaises : Form
    {
        public frmPaises()
        {
            InitializeComponent();
        }



        private void frmPaises_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new PaisesModel().getPaises();
            this.textBox1.Select();
            this.btnModifica.Enabled = false;
            this.btnElimina.Enabled = false;

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //textBox1.Text = (String)this.dataGridView1.CurrentRow.Cells["nomPais"].Value;
        }

   

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Tiene que ingresar un Nombre", "BUSCAR");
                textBox1.Select();
            }
            else
            {

                dataGridView1.DataSource = new PaisesModel().getPaisXNombre(textBox1.Text.ToUpper());
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("No se encuentra el registros","BUSCAR");
                    textBox1.Select();
                    textBox1.SelectAll();
                }
                else
                {
                    this.textBox1.Text = (String)this.dataGridView1.CurrentRow.Cells["nomPais"].Value;
                    this.textBox1.Select();
                    this.textBox1.SelectAll();
                    this.btnModifica.Enabled = true;
                    this.btnElimina.Enabled = true;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Tiene que ingresar un Nombre","NUEVO");
                textBox1.Select();
            }
            else
            {
                DialogResult result1 = MessageBox.Show(textBox1.Text +" Esta seguro?",
    "NUEVO",
    MessageBoxButtons.YesNo);
                if (result1.ToString() == "No")
                {

                    textBox1.Text = "";
                    textBox1.Select();
                }
                else
                {
                    MessageBox.Show("Los datos se guardaron");
                    new PaisesModel().save(textBox1.Text.ToUpper());
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = new PaisesModel().getPaises();
                    textBox1.Text = "";
                    textBox1.Select();

                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Tiene que ingresar un Nombre", "MODIFICA");
                textBox1.Select();
            }
            else
            {
                DialogResult result1 = MessageBox.Show(textBox1.Text + " Esta seguro?",
    "MODIFICA",
    MessageBoxButtons.YesNo);
                if (result1.ToString() == "No")
                {

                    textBox1.Text = "";
                    textBox1.Select();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = new PaisesModel().getPaises();
                    this.btnModifica.Enabled = false;
                    this.btnElimina.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Los datos se Actualizarón");
                    new PaisesModel().updatepais(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["codPais"].Value), textBox1.Text.ToUpper());
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = new PaisesModel().getPaises();
                    textBox1.Text = "";
                    textBox1.Select();

                }
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.textBox1.Text = (String)this.dataGridView1.CurrentRow.Cells["nomPais"].Value;
        }







    }
}
