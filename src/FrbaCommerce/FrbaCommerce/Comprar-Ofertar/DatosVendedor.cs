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
    public partial class DatosVendedor : Form
    {
        private CompraDAO dao = new CompraDAO(BD.Instance.Conexion);

        public DatosVendedor(int Vendedor)
        {
            InitializeComponent();
            Vendedor vendedor = dao.Vendedor(Vendedor);
            tbNombre.Text = vendedor.Nombre;
            tbMail.Text = vendedor.Mail;
            tbTelefono.Text = vendedor.Telefono;
        }
    }
}
