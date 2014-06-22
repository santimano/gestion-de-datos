using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.ABM_Rol
{
    public partial class AgregarRol : Form
    {

        private RolDAO dao;
        
        public AgregarRol(RolDAO dao)
        {
            this.dao = dao;
            InitializeComponent();
            comboBoxEstado.Items.Add("ACTIVO");
            comboBoxEstado.Items.Add("INACTIVO");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dao.agregarRol(new Rol(textBoxDescripcion.Text, comboBoxEstado.SelectedItem.ToString()));
            this.Close();
        }
    }
}
