using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class ComprarItem : Form
    {
        private int Vendedor;
        private decimal Pub_Codigo;
        private CompraDAO dao = new CompraDAO(BD.Instance.Conexion);
        private string Tipo;
        private List<Oferta> ofertas;

        public ComprarItem(decimal Id, string Descripcion, string Precio, string Stock, string Vencimiento, int Vendedor, string Tipo, bool Preguntas)
        {
            InitializeComponent();
            this.Pub_Codigo = Id;
            this.Vendedor = Vendedor;
            tbDescripcion.Text = Descripcion;
            tbPrecio.Text = Precio;
            tbStock.Text = Stock;
            tbVencimiento.Text = Vencimiento;
            this.Tipo = Tipo;
            gbPreguntas.Visible = Preguntas;
            if (Tipo == "Subasta")
            {
                gbOfertas.Visible = true;
                btComprar.Text = "Ofertar";
                tbOferta.Visible = true;
                numCantidad.Visible = false;
                labelCantidad.Visible = false;
                ofertas = dao.Ofertas(Pub_Codigo);
                lbOfertas.Items.AddRange(ofertas.ToArray());
            }
            else
            {
                numCantidad.Maximum = decimal.Parse(Stock);
            }

        }

        private void btComprar_Click(object sender, EventArgs e)
        {
            decimal oferta = -1;
            if (tbOferta.Visible)
            {
                if ("" == tbOferta.Text)
                {
                    MessageBox.Show("La oferta esta vacia");
                    return;
                }
                try
                {
                    oferta = decimal.Parse(tbOferta.Text);
                    if (oferta <= ofertas[0].Monto)
                    {
                        MessageBox.Show("La oferta debe ser mayor a la ultima oferta hecha");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("La oferta no es un numero");
                    return;
                }

            }

            dao.Comprar(Pub_Codigo, Main.Usuario, numCantidad.Value, oferta, Tipo);
            string mensaje = Tipo == "Subasta" ? "Oferta realizada exitosamente" : "Compra realizada exitosamente";
            MessageBox.Show(mensaje);
            if (Tipo != "Subasta")
            {
                new DatosVendedor(Vendedor).ShowDialog();
            }
            this.Close();
        }

        private void btPreguntar_Click(object sender, EventArgs e)
        {
            if ("" == tbPregunta.Text)
            {
                MessageBox.Show("La pregunta esta vacia");
                return;
            }
            dao.Preguntar(Pub_Codigo, tbPregunta.Text, Main.Usuario);
            MessageBox.Show("Pregunta realizada exitosamente");
            tbPregunta.Text = "";
        }

        private void btRespuestas_Click(object sender, EventArgs e)
        {
            new FrbaCommerce.Gestion_de_Preguntas.Respuestas().ShowDialog();
        }
    }
}
