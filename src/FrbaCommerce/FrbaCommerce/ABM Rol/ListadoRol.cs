using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.ABM_Rol
{
    public partial class ListadoRol : Form
    {

        private RolDAO dao = new RolDAO(BD.Instance.Conexion);

        public ListadoRol()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            rolDAOBindingSource = new BindingSource();
            dao.obtenerRoles().ForEach(delegate(Rol rol) { rolDAOBindingSource.Add(rol); });
            dataGridView1.DataSource = rolDAOBindingSource;
            Estado.DataPropertyName = "Estado";
            Descripcion.DataPropertyName = "Descripcion";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           //rolDAOBindingSource.
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            new AgregarRol(dao).ShowDialog();
            buscar();
        }
    }
}
