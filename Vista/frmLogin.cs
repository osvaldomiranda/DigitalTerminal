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
    public partial class frmLogin : Form
    {
        UsuarioModel userModel = new UsuarioModel();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           txtContrasena.PasswordChar = '*';

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (userModel.validaUser(txtNombreUsuario.Text, txtContrasena.Text) == "true")
            {
                new frmInicio().Show();
                this.Hide();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }
    }
}
