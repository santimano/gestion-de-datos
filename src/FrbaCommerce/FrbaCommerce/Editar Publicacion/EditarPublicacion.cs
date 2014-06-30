using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Generar_Publicacion;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.Editar_Publicacion
{
    public partial class EditarPublicacion : Form
    {
        private PublicacionDAO dao = new PublicacionDAO(BD.Instance.Conexion);

        public EditarPublicacion()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            dataGridView1.DataSource = dao.Publicaciones_Grilla(cbEstado.Text, tbDescripcion.Text).Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            int Codigo = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());
            GenPublicacion form = new GenPublicacion(Codigo);
            form.ShowDialog();
            buscar();
            this.Show();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            tbDescripcion.Text = null;
            cbEstado.Text = null;
        }
    }
}
