using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.Login
{
    public partial class LoginNuevoPass : Form
    {
        private String usuario;

        public LoginNuevoPass(String user)
        {
            InitializeComponent();
            usuario = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBoxPassNuevo.Text != this.textBoxPassConfirma.Text)
            {
                MessageBox.Show(null, "Las contraseñas no coinciden. Por favor ingreselas de nuevo.", "Login");
                return;
            }
            if (this.textBoxPassNuevo.Text == this.textBoxPassAnt.Text)
            {
                MessageBox.Show(null, "La nueva contraseña no puede ser igual a la anterior. Por favor ingrese una nueva.", "Login");
                return;
            }

            byte login;
            try
            {
                login = BD.Instance.Login(usuario, this.textBoxPassAnt.Text, this.textBoxPassNuevo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Error");
                BD.Instance.Conexion.Close();
                return;
            }
            switch (login)
            {
                case 2:
                    MessageBox.Show(null, "Usuario inexsistente.", "Login");
                    return;
                case 3:
                    MessageBox.Show(null, "La contraseña anterior no es correcta.", "Login");
                    return;
                case 4:
                    MessageBox.Show(null, "La contraseña anterior no es correcta. Maxima cantidad de intentos realizados.", "Login");
                    return;
                case 5:
                    MessageBox.Show(null, "El usuario ha sido bloqueado. Contactese con su administrador.", "Login");
                    return;
            }

            MessageBox.Show(null, "La contraseña ha sido cambiada", "Login");
            this.Close();
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
