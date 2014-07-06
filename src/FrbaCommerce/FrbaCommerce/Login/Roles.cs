using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Login
{
    public partial class Roles : Form
    {
        public Roles(List<Rol> roles)
        {
            InitializeComponent();
            comboBoxRoles.Items.AddRange(roles.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxRoles.SelectedItem == null)
                MessageBox.Show(null, "No se ha seleccionado opcion. Por favor elija una opcion de las disponibles.", "Error");
            else
            {
                Main.Rol = (Rol) comboBoxRoles.SelectedItem;
                this.Close();
            }
        }

    }
}
