using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelo;
using System.Text.RegularExpressions;

namespace FrbaCommerce.Facturar_Publicaciones
{
    public partial class Facturar : Form
    {
        private FacturaDAO dao = new FacturaDAO(BD.Instance.Conexion);
        private int usuario;

        public Facturar(int usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ReadOnly = false;
            buscar();
        }

        private void buscar()
        {
            dataGridView1.DataSource = dao.Ventas_Grilla(usuario).Tables[0];
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tarjeta = "";
            if ("".Equals(tbPubAFact.Text) || int.Parse(tbPubAFact.Text) < 1)
            {
                MessageBox.Show("Debe indicar cantidad de publicaciones a facturar");
                return;
            }
            else
                if (int.Parse(tbPubAFact.Text) > dataGridView1.Rows.Count)
                {
                    MessageBox.Show("No se pueden facturar mas publicaciones de las pendientes");
                    return;
                }
            if ("".Equals(cbFormaPago.Text))
            {
                MessageBox.Show("Debe seleccionar una forma de pago");
                return;
            }
            else
                if (cbFormaPago.Text == "Tarjeta")
                {
                    if ("".Equals(tbTarjeta.Text))
                    {
                        MessageBox.Show("Debe ingresar numero de tarjeta");
                        return;
                    }
                    else
                    {
                        tarjeta = tbTarjeta.Text.Replace("_", "").Replace(" ", "");
                        if (tarjeta.Length < 16)
                        {
                            MessageBox.Show("Debe ingresar numero de tarjeta de 16 digitos");
                            return;
                        }
                    }
                    if ("".Equals(tbTitular.Text))
                    {
                        MessageBox.Show("Debe ingresar titular");
                        return;
                    }
                    string vencimiento = tbVencimiento.Text.Replace("_", "").Replace(" ", "");
                    if ("".Equals(vencimiento) || vencimiento.Length < 7)
                    {
                        MessageBox.Show("Debe ingresar un vencimiento");
                        return;
                    }
                }

            List<Item> items = new List<Item>();
            int aFacturar = int.Parse(tbPubAFact.Text);

            for (int i = 0; i < aFacturar; i++)
            {
                items.Add(toItem(dataGridView1.Rows[i].Cells));
            }
            if (cbFormaPago.Text == "Tarjeta")
            {
                dao.Facturar(items, cbFormaPago.Text, tbTitular.Text, long.Parse(tarjeta), tbVencimiento.Text, usuario);
            }
            else 
            {
                dao.Facturar(items, cbFormaPago.Text, null, 0, null, usuario);
            }
            
            buscar();
        }

        private void cbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbDatosTarjeta.Visible = cbFormaPago.Text == "Tarjeta";
        }

        private Item toItem(DataGridViewCellCollection cells)
        {
            string publicacion = cells[0].Value.ToString();
            DateTime fecha = (DateTime)cells[1].Value;
            decimal vendidos = (decimal)cells[2].Value;
            decimal unitario = (decimal)cells[3].Value;
            decimal total = (decimal)cells[4].Value;
            decimal pubCodigo = (decimal)cells[5].Value;
            decimal visibilidad = (decimal)cells[6].Value;
            Item item = new Item(publicacion, fecha, vendidos, unitario, total, pubCodigo, visibilidad);
            return item;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if ("".Equals(tbPubAFact.Text) || int.Parse(tbPubAFact.Text) < 1)
            {
                MessageBox.Show("Debe indicar cantidad de publicaciones a facturar");
                return;
            }
            else
                if (int.Parse(tbPubAFact.Text) > dataGridView1.Rows.Count)
                {
                    MessageBox.Show("No se pueden facturar mas publicaciones de las pendientes");
                    return;
                }

            int aFacturar = int.Parse(tbPubAFact.Text);
            decimal total = 0;
            for (int i = 0; i < aFacturar; i++)
            {
                total += (decimal)dataGridView1.Rows[i].Cells[4].Value;
            }
            tbTotalAFact.Text = total.ToString();
        }

    }
}
