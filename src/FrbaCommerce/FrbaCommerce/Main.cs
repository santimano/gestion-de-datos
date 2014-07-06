using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce
{
    public partial class Main : Form
    {
        public static String Rol { get; set; }
        public static DateTime FechaSistema { get; set; }
        public static int Usuario { get; set; }

        public Main()
        {
            InitializeComponent();
        }

        private void accederToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.Login loginForm = new Login.Login();
            loginForm.ShowDialog();
            actualizarMenu();
            this.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rol = null;
            Usuario = -1;
            actualizarMenu();
            MessageBox.Show("Logout exitoso");
        }

        private void actualizarMenu()
        {
            this.accederToolStripMenuItem.Visible = Rol == null;
            this.salirToolStripMenuItem.Visible = Rol != null;
            this.aBMToolStripMenuItem.Visible = Rol != null && Rol.Equals("Administrativo");
            this.clienteToolStripMenuItem.Visible = Rol != null && Rol.Equals("Cliente");
            this.empresaToolStripMenuItem.Visible = Rol != null && Rol.Equals("Empresa");
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABM_Rol.Rol_ABM abmRolForm = new ABM_Rol.Rol_ABM();
            abmRolForm.ShowDialog();
            this.Show();
        }
        private void visibilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abm_Visibilidad.Visibilidad_ABM abmVisiblibidadForm = new FrbaCommerce.Abm_Visibilidad.Visibilidad_ABM();
            abmVisiblibidadForm.ShowDialog();
            this.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abm_Cliente.Cliente_ABM abmClienteForm = new Abm_Cliente.Cliente_ABM();
            abmClienteForm.ShowDialog();
            this.Show();
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Generar_Publicacion.GenPublicacion genPublicacionForm = new FrbaCommerce.Generar_Publicacion.GenPublicacion();
            genPublicacionForm.ShowDialog();
            this.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Editar_Publicacion.EditarPublicacion form = new FrbaCommerce.Editar_Publicacion.EditarPublicacion();
            form.ShowDialog();
            this.Show();
        }

        private void ofertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Historial_Cliente.Ofertas form = new FrbaCommerce.Historial_Cliente.Ofertas();
            form.ShowDialog();
            this.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Historial_Cliente.Compras form = new FrbaCommerce.Historial_Cliente.Compras();
            form.ShowDialog();
            this.Show();
        }

        private void calificacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Historial_Cliente.Calificaciones form = new FrbaCommerce.Historial_Cliente.Calificaciones(false);
            form.ShowDialog();
            this.Show();
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Historial_Cliente.Calificaciones form = new FrbaCommerce.Historial_Cliente.Calificaciones(true);
            form.ShowDialog();
            this.Show();
        }

        private void calificarVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calificar_Vendedor.CalificarVendedor form = new FrbaCommerce.Calificar_Vendedor.CalificarVendedor();
            form.ShowDialog();
            this.Show();
        }

        private void recibidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gestion_de_Preguntas.Preguntas form = new FrbaCommerce.Gestion_de_Preguntas.Preguntas();
            form.ShowDialog();
            this.Show();
        }

        private void preguntasRecibidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recibidasToolStripMenuItem_Click(sender, e);
        }

        private void hechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gestion_de_Preguntas.Respuestas form = new FrbaCommerce.Gestion_de_Preguntas.Respuestas();
            form.ShowDialog();
            this.Show();
        }

        private void facturarPublicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Facturar_Publicaciones.Facturar form = new FrbaCommerce.Facturar_Publicaciones.Facturar(Main.Usuario);
            form.ShowDialog();
            this.Show();
        }

       
    }
}
