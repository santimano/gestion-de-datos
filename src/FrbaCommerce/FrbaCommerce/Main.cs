using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Login;

namespace FrbaCommerce
{
    public partial class Main : Form
    {
        public static Rol Rol { get; set; }
        public static DateTime FechaSistema { get; set; }
        public static int Usuario { get; set; }
        public static String UsuarioNombre { get; set; }

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
            this.cambiarPasswordToolStripMenuItem.Visible = Rol != null;
            this.aBMToolStripMenuItem.Visible = Rol != null && Rol.Name.Equals("Administrativo");
            this.clienteToolStripMenuItem.Visible = Rol != null && Rol.Name.Equals("Cliente");
            this.empresaToolStripMenuItem.Visible = Rol != null && Rol.Name.Equals("Empresa");
            this.adminFacturar.Visible = Rol != null && Rol.Name.Equals("Administrativo");
            this.estadisticasToolStripMenuItem.Visible = Rol != null && Rol.Name.Equals("Administrativo");
            actualizarSubMenus();
        }

        private void actualizarSubMenus()
        {
            this.abmClientes.Visible = Rol != null && Rol.Funciones.Contains("ABM Clientes");
            this.abmEmpresas.Visible = Rol != null && Rol.Funciones.Contains("ABM Empresas");
            this.abmRoles.Visible = Rol != null && Rol.Funciones.Contains("ABM Roles");
            this.abmVisibilidad.Visible = Rol != null && Rol.Funciones.Contains("ABM Visibilidad");

            this.nuevaPubCli.Visible = Rol != null && Rol.Funciones.Contains("Cliente Publicacion Nueva");
            this.editarPubCli.Visible = Rol != null && Rol.Funciones.Contains("Cliente Publicacion Editar");
            this.ofertasCli.Visible = Rol != null && Rol.Funciones.Contains("Cliente Historial Ofertas");
            this.comprasCli.Visible = Rol != null && Rol.Funciones.Contains("Cliente Historial Compras");
            this.califCli.Visible = Rol != null && Rol.Funciones.Contains("Cliente Historial Calificaciones");
            this.califVen.Visible = Rol != null && Rol.Funciones.Contains("Cliente Calificar Vendedor");
            this.cliPregRec.Visible = Rol != null && Rol.Funciones.Contains("Cliente Preguntas Recibidas");
            this.cliPregHechas.Visible = Rol != null && Rol.Funciones.Contains("Cliente Preguntas Hechas");
            this.cliFacturar.Visible = Rol != null && Rol.Funciones.Contains("Cliente Facturar Publicaciones");

            this.nuevaPubEmp.Visible = Rol != null && Rol.Funciones.Contains("Empresa Publicacion Nueva");
            this.editarPubEmp.Visible = Rol != null && Rol.Funciones.Contains("Empresa Publicacion Editar");
            this.califEmp.Visible = Rol != null && Rol.Funciones.Contains("Empresa Historial Calificaciones");
            this.empPregRec.Visible = Rol != null && Rol.Funciones.Contains("Empresa Preguntas Recibidas");
            this.empFacturar.Visible = Rol != null && Rol.Funciones.Contains("Empresa Facturar Publicaciones");

            this.adminFacturar.Visible = Rol != null && Rol.Funciones.Contains("Admin Facturar Publicaciones");

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

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abm_Empresa.Empresa_ABM abmEmpresaForm = new Abm_Empresa.Empresa_ABM();
            abmEmpresaForm.ShowDialog();
            this.Show();
		}
		
        private void facturarPublicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Facturar_Publicaciones.Facturar form = new FrbaCommerce.Facturar_Publicaciones.Facturar(Main.Usuario);
            form.ShowDialog();
            this.Show();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Facturar_Publicaciones.FacturarInhabilitados form = new FrbaCommerce.Facturar_Publicaciones.FacturarInhabilitados();
            form.ShowDialog();
            this.Show();
        }

        private void cambiarPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Login.LoginNuevoPass(Main.UsuarioNombre).ShowDialog();
        }

        private void facturarPublicacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            facturarPublicacionesToolStripMenuItem_Click(sender, e);
        }

        private void nuevaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nuevaToolStripMenuItem_Click(sender, e);
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editarToolStripMenuItem_Click(sender, e);
        }

        private void buscarPublicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrbaCommerce.Comprar_Ofertar.Comprar form = new FrbaCommerce.Comprar_Ofertar.Comprar();
            form.ShowDialog();
            this.Show();
        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listado_Estadistico.ListadoEstadistico form = new FrbaCommerce.Listado_Estadistico.ListadoEstadistico();
            form.ShowDialog();
            this.Show();
        }

    }
}
