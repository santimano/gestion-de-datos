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
    public partial class Rol_ABM : Form
    {
        private RolDAO dao = new RolDAO(BD.Instance.Conexion);

        public Rol_ABM()
        {
            InitializeComponent();
            actualizar();
        }

        private void actualizar()
        {
            dataGridView1.DataSource = dao.Roles_Grilla().Tables[0];
            btCrear.Enabled = false;
            btActualizar.Enabled = false;
            btBorrar.Enabled = false;
            tbCodigo.Text = null;
            tbDesc.Text = null;
            cbEstado.SelectedItem = null;
            tbCodigo.Enabled = false;
            tbDesc.Enabled = false;
            cbEstado.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbCodigo.Text = dataGridView1.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
            tbDesc.Text = dataGridView1.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
            cbEstado.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
            btActualizar.Enabled = true;
            btBorrar.Enabled = true;
            tbDesc.Enabled = true;
            cbEstado.Enabled = true;
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            dao.guardar(-1, tbDesc.Text, cbEstado.Text);
            MessageBox.Show("Creado");
            actualizar();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                dao.borrar(int.Parse(tbCodigo.Text));
            }
            catch
            {
                MessageBox.Show("Codigo invalido");
            }
            MessageBox.Show("Borrado");
            actualizar();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            actualizar();
            tbDesc.Enabled = true;
            cbEstado.Enabled = true;
            btCrear.Enabled = true;
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            dao.guardar(int.Parse(tbCodigo.Text), tbDesc.Text, cbEstado.Text);
            MessageBox.Show("Actualizado");
            actualizar();
        }
    }
}
