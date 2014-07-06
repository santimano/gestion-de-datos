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
    public partial class Login : Form
    {

        private LoginDAO dao = new LoginDAO(BD.Instance.Conexion);

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (dao.Login(this.textBoxUsuario.Text, this.textBoxPassword.Text, null))
            {
                case 2:
                    MessageBox.Show(null, "Usuario inexsistente.", "Login");
                    return;
                case 3:
                    MessageBox.Show(null, "La contraseña no es correcta.", "Login");
                    return;
                case 4:
                    MessageBox.Show(null, "La contraseña no es correcta. Maxima cantidad de intentos realizados.", "Login");
                    return;
                case 5:
                    MessageBox.Show(null, "El usuario ha sido bloqueado. Contactese con su administrador.", "Login");
                    return;
                case 6:
                    MessageBox.Show(null, "El usuario ha sido eliminado del sistema. Contactese con su administrador.", "Login");
                    return;
                case 10:
                    // hay que cambiar el password
                    new LoginNuevoPass(this.textBoxUsuario.Text).ShowDialog();
                    break;
                case 255:
                    // excepcion
                    return;
            }

            List<String> roles = dao.Roles(this.textBoxUsuario.Text);

            if (roles.Count > 1)
            {
                this.Hide();
                new Roles(roles).ShowDialog();
                Main.Usuario = BD.Instance.FindUsuario(this.textBoxUsuario.Text);
            }
            else if (roles.Count == 1)
            {
                Main.Rol = roles[0];
                Main.Usuario = BD.Instance.FindUsuario(this.textBoxUsuario.Text);
            }
            else
            {// no se encontraron roles
                Main.Rol = "N/A";
            }
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registrarse().ShowDialog();
            this.Show();
        }
    }
}
