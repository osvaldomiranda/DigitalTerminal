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
    public partial class frmComunas : Form
    {
        CiudadesModel ciudades = new CiudadesModel();
        ComunasModel comunas = new ComunasModel();
        public frmComunas()
        {
            InitializeComponent();
             
        }

        private void frmComunas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new ComunasModel().getComunas();
            comboBoxCiudades.ValueMember = "codCiudad";
            comboBoxCiudades.DisplayMember = "nomCiudad";
            comboBoxCiudades.DataSource = ciudades.getCiudades();
            this.txtnomComuna.Select();
            this.btnModifica.Enabled = false;
            this.btnElimina.Enabled = false;

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //textBox1.Text = (String)this.dataGridView1.CurrentRow.Cells["nomPais"].Value;
        }

   

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtnomComuna.Text == "")
            {
                MessageBox.Show("Tiene que ingresar un Nombre", "BUSCAR");
                txtnomComuna.Select();
            }
            else
            {

                dataGridView1.DataSource = new ComunasModel().getComunasXNombre(txtnomComuna.Text.ToUpper());
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("No se encuentra el registros","BUSCAR");
                    txtnomComuna.Select();
                    txtnomComuna.SelectAll();
                }
                else
                {
                    this.txtnomComuna.Text = (String)this.dataGridView1.CurrentRow.Cells["nomComuna"].Value;
                    this.txtnomComuna.Select();
                    this.txtnomComuna.SelectAll();
                    this.btnModifica.Enabled = true;
                    this.btnElimina.Enabled = true;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtnomComuna.Text == "")
            {
                MessageBox.Show("Tiene que ingresar un Nombre", "MODIFICA");
                txtnomComuna.Select();
            }
            else
            {
                DialogResult result1 = MessageBox.Show(txtnomComuna.Text + " Esta seguro?",
    "MODIFICA",
    MessageBoxButtons.YesNo);
                if (result1.ToString() == "No")
                {

                    txtnomComuna.Text = "";
                    txtnomComuna.Select();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = comunas.getComunas();
                    this.btnModifica.Enabled = false;
                    this.btnElimina.Enabled = false;
                }
                else
                {
                    
                    comunas.updateComunas(Convert.ToInt32(lblcodCiudad.Text), txtnomComuna.Text.ToUpper(), Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["codComuna"].Value));
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = comunas.getComunas();
                    txtnomComuna.Text = "";
                    txtnomComuna.Select();
                    MessageBox.Show("Los datos se Actualizarón");
                }
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.txtnomComuna.Text = (String)this.dataGridView1.CurrentRow.Cells["nomComuna"].Value;
            comboBoxCiudades.SelectedValue = (Int32)this.dataGridView1.CurrentRow.Cells["codCiudad"].Value; 
        }



        private void btnElimina_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show(txtnomComuna.Text + " Esta seguro?",
    "ELIMINAR",
    MessageBoxButtons.YesNo);

            if (result1.ToString() == "No")
            {

                txtnomComuna.Text = "";
                txtnomComuna.Select();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = new ComunasModel().getComunas();
                this.btnModifica.Enabled = false;
                this.btnElimina.Enabled = false;
            }
            else
            {
                new ComunasModel().delete((Int32)this.dataGridView1.CurrentRow.Cells["codComuna"].Value);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = new ComunasModel().getComunas();
                txtnomComuna.Text = "";
                txtnomComuna.Select();
                MessageBox.Show("El Registro se Elimino");
            }
        }

        private void comboBoxCiudades_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           lblcodCiudad.Text = comboBoxCiudades.SelectedValue.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtnomComuna.Text == "")
            {
                MessageBox.Show("Tiene que ingresar un Nombre", "NUEVO");
                txtnomComuna.Select();
            }
            else
            {
                DialogResult result1 = MessageBox.Show(txtnomComuna.Text + " Esta seguro?",
    "NUEVO",
    MessageBoxButtons.YesNo);
                if (result1.ToString() == "No")
                {

                    txtnomComuna.Text = "";
                    txtnomComuna.Select();
                }
                else
                {
                    // new ComunasModel().save(

                    new ComunasModel().save(Convert.ToInt32(lblcodCiudad.Text), txtnomComuna.Text.ToUpper());
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = new ComunasModel().getComunas();
                    txtnomComuna.Text = "";
                    txtnomComuna.Select();
                    MessageBox.Show("Los datos se guardaron");

                }
            }
        }


    }
}
