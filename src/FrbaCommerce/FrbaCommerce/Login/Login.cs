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
                login = BD.Instance.Login(this.textBoxUsuario.Text, this.textBoxPassword.Text); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(null,ex.Message,"Error");
                BD.Instance.Conexion.Close();
                return;
            }
            if (login == 8)
            {
                MessageBox.Show(null, "La contrasenia no es correcta", "Error");
                return;
            }
            else if ( login == 4 )
            {
                MessageBox.Show(null, "La contrasenia no puede ser en blanco", "Error");
                return;
            }
            else
            {
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
