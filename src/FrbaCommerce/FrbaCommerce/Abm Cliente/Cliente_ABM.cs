using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class Cliente_ABM : Form
    {
        private ClienteDAO dao = new ClienteDAO(BD.Instance.Conexion);

        public Cliente_ABM()
        {
            InitializeComponent();
            comboBoxTipoDocumento.Items.AddRange(dao.TipoDocumento().ToArray());
            this.actualizar();
        }

        private void actualizar()
        {
            dataGridViewClientes.DataSource = dao.ClientesGrilla(textBoxNombre.Text, textBoxApellido.Text, textBoxMail.Text, textBoxDocumento.Text, comboBoxTipoDocumento.SelectedItem == null ? "" : comboBoxTipoDocumento.SelectedItem.ToString()).Tables[0];
            dataGridViewClientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            this.actualizar();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxApellido.Clear();
            textBoxNombre.Clear();
            textBoxMail.Clear();
            textBoxDocumento.Clear();
            comboBoxTipoDocumento.SelectedIndex = -1;
        }
    }
}
