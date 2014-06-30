using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.Historial_Cliente
{
    public partial class Ofertas : Form
    {
        private OfertaDAO dao = new OfertaDAO(BD.Instance.Conexion);

        public Ofertas()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dao.Ofertas_Grilla(tbPub.Text, cbEstado.Text).Tables[0];
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            tbPub.Text = null;
            cbEstado.Text = null;
        }
    }
}
