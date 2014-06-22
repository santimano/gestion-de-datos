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
            Enum.GetValues(typeof(Rol.ESTADO)).Cast<Rol.ESTADO>().ToList().ForEach(
               delegate(Rol.ESTADO estado)
               {
                   filterEstado.Items.Add(estado.ToString());
               }
           );
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            buscar(this.filtroDescripcion.Text,this.filterEstado.SelectedItem);
        }

        private void buscar(string descripcion, object estado)
        {
            rolDAOBindingSource = new BindingSource();
            dao.obtenerRoles(descripcion, estado != null ? estado.ToString() : null).ForEach(delegate(Rol rol) { rolDAOBindingSource.Add(rol); });
            dataGridView1.DataSource = rolDAOBindingSource;
            Estado.DataPropertyName = "Estado";
            Descripcion.DataPropertyName = "Descripcion";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Rol selected = dataGridView1.Rows[e.RowIndex].DataBoundItem as Rol;
            bool delete = e.ColumnIndex == 3;
            new EditarRol(dao, selected, delete).ShowDialog();
            buscar(this.filtroDescripcion.Text, this.filterEstado.SelectedItem);
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            new EditarRol(dao, null, false).ShowDialog();
            buscar(this.filtroDescripcion.Text, this.filterEstado.SelectedItem);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            filterEstado.SelectedItem = null;
            filtroDescripcion.Text = "";
        }
        
    }
}
