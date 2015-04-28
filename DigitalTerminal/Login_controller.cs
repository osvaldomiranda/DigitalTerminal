using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DigitalTerminal
{
    class Login_controller
    {
        public void validPass(String email, String password)
        {
            Login login = new Login();
            if (login.isValid(email, password))
            {

                var result = MessageBox.Show("Usuario Valido", "OK",
                MessageBoxButtons.OK,
                MessageBoxIcon.Question);

                // LLAMADO A LA PANTALLA SIGUIENTE
            }
            else
            {
                 var result = MessageBox.Show("Usuario o Password Invalido", "Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Question);

            }
        }
    }
}
