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
    public partial class EditarRol : Form
    {

        private RolDAO dao;
        private Rol selected;

        public EditarRol(RolDAO dao, Rol selected, bool delete)
        {
            this.dao = dao;
            this.selected = selected;
            InitializeComponent();
            Enum.GetValues(typeof(Rol.ESTADO)).Cast<Rol.ESTADO>().ToList().ForEach(
                delegate(Rol.ESTADO estado)
                {
                    comboBoxEstado.Items.Add(estado.ToString());
                }
            );
            bool update = null != selected && !delete;
            if (update)
            {
                textBoxDescripcion.Text = selected.Descripcion;
                comboBoxEstado.SelectedItem = selected.Estado;
                buttonActualizar.Visible = true;
            }
            else
                if (delete)
                {
                    textBoxDescripcion.Text = selected.Descripcion;
                    comboBoxEstado.SelectedItem = selected.Estado;
                    textBoxDescripcion.Enabled = false;
                    comboBoxEstado.Enabled = false;
                    buttonBorrar.Visible = true;
                }
                else
                {
                    buttonAceptar.Visible = true;
                }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxEstado.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un estado");
            }
            else
            {
                dao.agregarRol(new Rol(textBoxDescripcion.Text, comboBoxEstado.SelectedItem.ToString()));
                this.Close();
            }
            
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            selected.Descripcion = textBoxDescripcion.Text;
            selected.Estado = comboBoxEstado.SelectedItem.ToString();
            dao.actualizarRol(selected);
            this.Close();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            dao.borrarRol(selected);
            this.Close();
        }
    }
}
