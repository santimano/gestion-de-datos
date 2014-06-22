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
        public Roles(List<String> roles)
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
            Main.Rol = (String)comboBoxRoles.SelectedItem;
            this.Close();
        }

    }
}
