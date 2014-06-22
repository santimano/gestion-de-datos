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
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte login;

            try
            {
                login = BD.Instance.Login(this.textBoxUsuario.Text, this.textBoxPassword.Text, null);
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
                    MessageBox.Show(null, "La contraseña no es correcta.", "Login");
                    return;
                case 4:
                    MessageBox.Show(null, "La contraseña no es correcta. Maxima cantidad de intentos realizados.", "Login");
                    return;
                case 5:
                    MessageBox.Show(null, "El usuario ha sido bloqueado. Contactese con su administrador.", "Login");
                    return;
                case 10:
                    new LoginNuevoPass(this.textBoxUsuario.Text).ShowDialog();
                    break;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
