using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DigitalTerminal
{
    public partial class frmLogin : Form
    {
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
            Login_controller log = new Login_controller();
            log.validPass(txtNombreUsuario.Text, txtContrasena.Text);
        }
    }
}
