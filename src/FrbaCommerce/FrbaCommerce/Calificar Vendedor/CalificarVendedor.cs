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
            buscar();
        }

        private void buscar()
        {
            dataGridView1.DataSource = dao.Pendientes_Grilla().Tables[0];
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string publicacion = dataGridView1.Rows[e.RowIndex].Cells["Publicacion"].Value.ToString();
            decimal monto = (decimal)dataGridView1.Rows[e.RowIndex].Cells["Monto"].Value;
            decimal cantidad = (decimal)dataGridView1.Rows[e.RowIndex].Cells["Cantidad"].Value;
            DateTime fecha = (DateTime)dataGridView1.Rows[e.RowIndex].Cells["Fecha"].Value;
            string vendedor = dataGridView1.Rows[e.RowIndex].Cells["Vendedor"].Value.ToString();
            decimal venta = (decimal)dataGridView1.Rows[e.RowIndex].Cells["Venta"].Value;
            this.Hide();
            CalificarVendedorDialog form = new CalificarVendedorDialog(publicacion, monto, cantidad, fecha, vendedor, venta);
            form.ShowDialog();
            buscar();
            this.Show();
        }
    }
}
