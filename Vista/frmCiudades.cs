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
    public partial class frmCiudades : Form
    {
        PaisesModel paises = new PaisesModel();
        CiudadesModel ciudades = new CiudadesModel();
        public frmCiudades()
        {
            InitializeComponent();
             
        }



        private void frmCiudades_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new CiudadesModel().getCiudades();
            comboBoxPaises.ValueMember = "codPais";
            comboBoxPaises.DisplayMember = "nomPais";
            comboBoxPaises.DataSource = paises.getPaises();
            this.txtnomCiudad.Select();
            this.btnModifica.Enabled = false;
            this.btnElimina.Enabled = false;

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //textBox1.Text = (String)this.dataGridView1.CurrentRow.Cells["nomPais"].Value;
        }

   

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtnomCiudad.Text == "")
            {
                MessageBox.Show("Tiene que ingresar un Nombre", "BUSCAR");
                txtnomCiudad.Select();
            }
            else
            {

                dataGridView1.DataSource = ciudades.getCiudadXNombre(txtnomCiudad.Text.ToUpper());
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("No se encuentra el registros","BUSCAR");
                    txtnomCiudad.Select();
                    txtnomCiudad.SelectAll();
                }
                else
                {
                    this.txtnomCiudad.Text = (String)this.dataGridView1.CurrentRow.Cells["nomCiudad"].Value;
                    this.txtnomCiudad.Select();
                    this.txtnomCiudad.SelectAll();
                    this.btnModifica.Enabled = true;
                    this.btnElimina.Enabled = true;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnomCiudad.Text == "")
            {
                MessageBox.Show("Tiene que ingresar un Nombre","NUEVO");
                txtnomCiudad.Select();
            }
            else
            {
                DialogResult result1 = MessageBox.Show(txtnomCiudad.Text +" Esta seguro?",
    "NUEVO",
    MessageBoxButtons.YesNo);
                if (result1.ToString() == "No")
                {

                    txtnomCiudad.Text = "";
                    txtnomCiudad.Select();
                }
                else
                {
                   // new ComunasModel().save(
                    ciudades.save(Convert.ToInt32(lblcodPais.Text), txtnomCiudad.Text.ToUpper());
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = new CiudadesModel().getCiudades();
                    txtnomCiudad.Text = "";
                    txtnomCiudad.Select();
                    MessageBox.Show("Los datos se guardaron");

                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtnomCiudad.Text == "")
            {
                MessageBox.Show("Tiene que ingresar un Nombre", "MODIFICA");
                txtnomCiudad.Select();
            }
            else
            {
                DialogResult result1 = MessageBox.Show(txtnomCiudad.Text + " Esta seguro?",
    "MODIFICA",
    MessageBoxButtons.YesNo);
                if (result1.ToString() == "No")
                {

                    txtnomCiudad.Text = "";
                    txtnomCiudad.Select();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = new CiudadesModel().getCiudades();
                    this.btnModifica.Enabled = false;
                    this.btnElimina.Enabled = false;
                }
                else
                {
                    
                    new CiudadesModel().updateCiudad(Convert.ToInt32(lblcodPais.Text), txtnomCiudad.Text.ToUpper(), Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["codCiudad"].Value));
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = new CiudadesModel().getCiudades();
                    txtnomCiudad.Text = "";
                    txtnomCiudad.Select();
                    MessageBox.Show("Los datos se Actualizarón");
                }
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.txtnomCiudad.Text = (String)this.dataGridView1.CurrentRow.Cells["nomCiudad"].Value;
            comboBoxPaises.SelectedValue = (Int32)this.dataGridView1.CurrentRow.Cells["codPais"].Value; 
        }

        private void comboBoxPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblcodPais.Text = comboBoxPaises.SelectedValue.ToString();
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show(txtnomCiudad.Text + " Esta seguro?",
    "ELIMINAR",
    MessageBoxButtons.YesNo);

            if (result1.ToString() == "No")
            {

                txtnomCiudad.Text = "";
                txtnomCiudad.Select();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = new CiudadesModel().getCiudades();
                this.btnModifica.Enabled = false;
                this.btnElimina.Enabled = false;
            }
            else
            {
                new ComunasModel().delete((Int32)this.dataGridView1.CurrentRow.Cells["codCiudad"].Value);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = new CiudadesModel().getCiudades();
                txtnomCiudad.Text = "";
                txtnomCiudad.Select();
                MessageBox.Show("El Registro se Elimino");
            }
        }


    }
}
