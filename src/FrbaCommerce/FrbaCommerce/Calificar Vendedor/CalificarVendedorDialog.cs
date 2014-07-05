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
    public partial class CalificarVendedorDialog : Form
    {
        private decimal venta;
        private CalificacionDAO dao = new CalificacionDAO(BD.Instance.Conexion);

        public CalificarVendedorDialog(string publicacion, decimal monto, decimal cantidad, DateTime fecha, string vendedor, decimal venta)
        {
            InitializeComponent();
            tbPublicacion.Text = publicacion;
            tbMonto.Text = monto.ToString();
            tbCantidad.Text = cantidad.ToString();
            tbFecha.Text = fecha.ToString();
            tbVendedor.Text = vendedor;
            this.venta = venta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (null == tbDescripcion.Text || tbDescripcion.Text.Trim() == "") 
            {
                MessageBox.Show("Debe escribir una descripcion");
                return;
            }
            dao.Insertar_Calificacion(venta, tbEstrellas.Value, tbDescripcion.Text);
            this.Close();
        }
    }
}
