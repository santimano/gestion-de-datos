using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Historial_Cliente;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.Calificar_Vendedor
{
    public partial class CalificarVendedor : Form
    {
        private CalificacionDAO dao = new CalificacionDAO(BD.Instance.Conexion);

        public CalificarVendedor()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dao.Pendientes_Grilla().Tables[0];
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells["Ven_Id"].Value.ToString());
        }
    }
}
