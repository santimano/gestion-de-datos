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

       
    }
}
