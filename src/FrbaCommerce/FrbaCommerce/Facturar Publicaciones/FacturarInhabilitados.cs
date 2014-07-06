using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.Facturar_Publicaciones
{
    public partial class FacturarInhabilitados : Form
    {
        private FacturaDAO dao = new FacturaDAO(BD.Instance.Conexion);

        public FacturarInhabilitados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if("".Equals(tbUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un usuario");
                return;
            }

            int usuario = dao.Usuario_A_Facturar(tbUsuario.Text);

            if(usuario == -1)
            {
                MessageBox.Show("Usuario no inhabilitado");
                return;
            }
            if (usuario == -2)
            {
                MessageBox.Show("Usuario no encontrado");
                return;
            }

            this.Hide();
            new Facturar(usuario).ShowDialog();
            this.Show();

        }
    }
}
