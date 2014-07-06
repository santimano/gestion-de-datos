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
            dataGridViewClientes.Columns["Fecha_Nac"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridViewClientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void limpiar()
        {
            textBoxApellido.Clear();
            textBoxNombre.Clear();
            textBoxMail.Clear();
            textBoxDocumento.Clear();
            comboBoxTipoDocumento.SelectedIndex = -1;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            this.actualizar();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                new EditarCliente("modificacion", dataGridViewClientes.Rows[e.RowIndex], null, null).ShowDialog();
                this.actualizar();
            }
            else if (e.ColumnIndex == 1)
            {
                DialogResult resultado = MessageBox.Show("Esta seguro que desea eliminar el cliente ?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    dao.EliminarCliente(dataGridViewClientes.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                }
                this.actualizar();
            }
            else if (e.ColumnIndex == 2)
                new ClienteNuevoPass(dataGridViewClientes.Rows[e.RowIndex].Cells["ID"].Value.ToString()).ShowDialog();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            new EditarCliente("alta", null, null, null).ShowDialog();
            this.actualizar();
        }
    }
}
