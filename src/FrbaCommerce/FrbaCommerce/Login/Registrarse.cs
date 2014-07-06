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
    public partial class Registrarse : Form
    {
        private LoginDAO dao = new LoginDAO(BD.Instance.Conexion);

        public Registrarse()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {

            if (textBoxUsuario.Text.Length < 1)
                MessageBox.Show(null, "El usuario no puede ser vacio.", "Error");
            else if (textBoxPassword.Text.Length < 1)
                MessageBox.Show(null, "El password no puede ser vacio.", "Error");
            else if (comboBoxRol.SelectedItem == null)
                MessageBox.Show(null, "Por favor seleccione un rol antes de continuar.", "Error");
            else
            {
                if (dao.ValidarUsuario(textBoxUsuario.Text) == false)
                    MessageBox.Show(null, "El nombre de usuario ya existe. Por favor elija otro.", "Error");
                else
                {
                    this.Hide();
                    if (comboBoxRol.SelectedItem.ToString() == "CLIENTE")
                        new Abm_Cliente.EditarCliente("alta", null, textBoxUsuario.Text, Encripcion.CalcularHash(textBoxPassword.Text)).ShowDialog();
                    else
                        new Abm_Empresa.EditarEmpresa("alta", null, textBoxUsuario.Text, Encripcion.CalcularHash(textBoxPassword.Text)).ShowDialog();
                    this.Close();
                }
            }
        }

    }
}
