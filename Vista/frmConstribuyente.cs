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
    public partial class frmConstribuyente : Form
    {
        CiudadesModel ciudad = new CiudadesModel();
        ComunasModel comuna = new ComunasModel();
        frmCiudades frmciudad = new frmCiudades();
        frmComunas frmcomuna = new frmComunas();

        public frmConstribuyente()
        {
            InitializeComponent();
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
           // txtRut.Text = new MetodosComunes().formatearRut(txtRut.Text);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxRutCliente_Validated(object sender, EventArgs e)
        {
            textBoxRutCliente.Text = new MetodosComunes().formatearRut(textBoxRutCliente.Text);
        }

        private void frmConstribuyente_Load(object sender, EventArgs e)
        {
            textBoxRutCliente.Select();
            comboBoxCiudad.ValueMember = "codCiudad";
            comboBoxCiudad.DisplayMember = "nomCiudad";
            comboBoxCiudad.DataSource = ciudad.getCiudades();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void comboBoxCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelCodCiudad.Text = comboBoxCiudad.SelectedValue.ToString();
           
        }

        private void comboBoxCiudad_TextChanged(object sender, EventArgs e)
        {
            comboBoxCiudad.FindString(comboBoxCiudad.Text);
        }

        private void buttonNuevaCiudad_Click(object sender, EventArgs e)
        {
            frmciudad.ShowDialog();
        }

        private void buttonNuevaComuna_Click(object sender, EventArgs e)
        {
            frmcomuna.ShowDialog();
        }


            
        



    }
}
