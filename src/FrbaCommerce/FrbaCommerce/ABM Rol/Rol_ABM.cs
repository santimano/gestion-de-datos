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
            lbFuncionalidades.Items.AddRange(dao.Funcionalidades().ToArray());
            actualizar();
        }

        private void actualizar()
        {
            dataGridView1.DataSource = dao.Roles_Grilla().Tables[0];
            btCrear.Enabled = false;
            btActualizar.Enabled = false;
            btBorrar.Enabled = false;
            btActivar.Enabled = false;
            tbCodigo.Text = null;
            tbDesc.Text = null;
            tbEstado.Text = null;
            tbCodigo.Enabled = false;
            tbDesc.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbCodigo.Text = dataGridView1.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
            tbDesc.Text = dataGridView1.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
            tbEstado.Text = dataGridView1.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
            List<string> fun = dao.Funcionalidades((int)dataGridView1.Rows[e.RowIndex].Cells["Codigo"].Value);
            lbFuncionalidades.SelectedItems.Clear();
            foreach (string f in fun)
            {
                lbFuncionalidades.SelectedItems.Add(f);   
            }
            btActualizar.Enabled = true;
            btBorrar.Enabled = tbEstado.Text == "ACTIVO";
            btActivar.Enabled = tbEstado.Text == "INACTIVO";
            tbDesc.Enabled = true;
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            dao.guardar(-1, tbDesc.Text, tbEstado.Text, lbFuncionalidades.SelectedItems);
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
            btCrear.Enabled = true;
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            dao.guardar(int.Parse(tbCodigo.Text), tbDesc.Text, tbEstado.Text, lbFuncionalidades.SelectedItems);
            MessageBox.Show("Actualizado");
            actualizar();
        }

        private void btActivar_Click(object sender, EventArgs e)
        {
            dao.guardar(int.Parse(tbCodigo.Text), tbDesc.Text, "ACTIVO", lbFuncionalidades.SelectedItems);
            MessageBox.Show("Actualizado");
            actualizar();
        }
    }
}
