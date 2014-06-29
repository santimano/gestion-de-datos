using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelo;
using FrbaCommerce.Abm_Visibilidad;
using FrbaCommerce.Abm_Rubro;

namespace FrbaCommerce.Generar_Publicacion
{
    public partial class GenPublicacion : Form
    {
        private VisibilidadDAO visibilidadDao = new VisibilidadDAO(BD.Instance.Conexion);
        private TipoPublicacionDAO tipoPublicacionDao = new TipoPublicacionDAO(BD.Instance.Conexion);
        private PublicacionDAO publicacionDao = new PublicacionDAO(BD.Instance.Conexion);
        private RubroDAO rubroDao = new RubroDAO(BD.Instance.Conexion);
        private int codigo = -1;

        public GenPublicacion()
        {
            InitializeComponent();
            btFinalizada.Enabled = false;
            btPausada.Enabled = false;
            cbVisibilidad.Items.AddRange(visibilidadDao.FindAll().ToArray());
            cbTipo.Items.AddRange(tipoPublicacionDao.FindAll().ToArray());
            lbRubros.Items.AddRange(rubroDao.FindAll().ToArray());
            cargarAcciones("Borrador");
        }

        public GenPublicacion(int codigo)
            : this()
        {
            this.codigo = codigo;

            Publicacion pub = publicacionDao.FindById(codigo);
            cargarCampos(pub);
            cargarAcciones(pub.Estado);

        }

        private bool cargarPublicacion(string Estado)
        {
            if (tbDescripcion.Text == null || tbDescripcion.Text == "")
            {
                MessageBox.Show("Descripcion vacia");
                return false;
            }
            try
            {
                int.Parse(tbStock.Text);
            }
            catch
            {
                MessageBox.Show("Stock vacio o no es un numero");
                return false;
            }
            if (dtpInicio.Value == null || dtpInicio.Text == "" || dtpInicio.Value < Main.FechaSistema)
            {
                MessageBox.Show("Fecha inicio debe ser mayor a " + Main.FechaSistema.ToString());
                return false;
            }
            if (dtpVencimiento.Value == null || dtpVencimiento.Text == "" || dtpVencimiento.Value < Main.FechaSistema)
            {
                MessageBox.Show("Fecha inicio debe ser mayor a " + Main.FechaSistema.ToString());
                return false;
            }
            try
            {
                decimal.Parse(tbPrecio.Text);
            }
            catch
            {
                MessageBox.Show("Precio vacio o no es un numero");
                return false;
            }
            if (cbVisibilidad.Text == null || cbVisibilidad.Text == "")
            {
                MessageBox.Show("Visibilidad vacia");
                return false;
            }
            if (lbRubros.Text == null || lbRubros.Text == "")
            {
                MessageBox.Show("Debe seleccionar rubro");
                return false;
            }
            if (cbTipo.Text == null || cbTipo.Text == "")
            {
                MessageBox.Show("Debe seleccionar un tipo");
                return false;
            }

            publicacionDao.Persist(codigo, tbDescripcion.Text, int.Parse(tbStock.Text), dtpInicio.Value
                , dtpVencimiento.Value, decimal.Parse(tbPrecio.Text), cbVisibilidad.Text
                , lbRubros.Text, cbTipo.Text, Estado, Main.Usuario);

            return true;
        }

        private void btBorrador_Click(object sender, EventArgs e)
        {
            bool exitoso = cargarPublicacion("Borrador");
            if (exitoso)
            {
                MessageBox.Show("Guardada como borrador");
                this.Close();
            }
        }

        private void btActiva_Click(object sender, EventArgs e)
        {
            bool exitoso = cargarPublicacion("Activa");
            if (exitoso)
            {
                MessageBox.Show("Publicacion Activada");
                this.Close();
            }
        }

        private void btPausada_Click(object sender, EventArgs e)
        {
            bool exitoso = cargarPublicacion("Pausada");
            if (exitoso)
            {
                MessageBox.Show("Publicacion Pausada");
                this.Close();
            }
        }

        private void btFinalizada_Click(object sender, EventArgs e)
        {
            bool exitoso = cargarPublicacion("Finalizada");
            if (exitoso)
            {
                MessageBox.Show("Publicacion Finalizada");
                this.Close();
            }
        }

        private void cargarAcciones(string estado)
        {
            switch (estado)
            {
                case "Borrador":
                    estadoBorrador();
                    break;
                case "Activa":
                    estadoActiva();
                    break;
                case "Pausada":
                    estadoPausada();
                    break;
                case "Finalizada":
                    estadoFinalizada();
                    break;
            }
        }

        private void estadoBorrador()
        {
            btPausada.Enabled = false;
            btFinalizada.Enabled = false;
        }
        private void estadoPausada()
        {
            btBorrador.Enabled = false;
            btPausada.Text = "Guardar";
            tbDescripcion.Enabled = false;
            tbStock.Enabled = false;
            dtpVencimiento.Enabled = false;
            dtpInicio.Enabled = false;
            tbPrecio.Enabled = false;
            lbRubros.Enabled = false;
            cbVisibilidad.Enabled = false;
            cbTipo.Enabled = false;
            cbPreguntas.Enabled = false;

        }
        private void estadoFinalizada()
        {
            btBorrador.Enabled = false;
            btPausada.Enabled = false;
            btActiva.Enabled = false;
            btFinalizada.Text = "Salir";
            tbDescripcion.Enabled = false;
            tbStock.Enabled = false;
            dtpVencimiento.Enabled = false;
            dtpInicio.Enabled = false;
            tbPrecio.Enabled = false;
            lbRubros.Enabled = false;
            cbVisibilidad.Enabled = false;
            cbTipo.Enabled = false;
            cbPreguntas.Enabled = false;
        }

        private void estadoActiva()
        {
            btBorrador.Enabled = false;
            btActiva.Text = "Guardar";
            dtpVencimiento.Enabled = false;
            dtpInicio.Enabled = false;
            tbPrecio.Enabled = false;
            lbRubros.Enabled = false;
            cbVisibilidad.Enabled = false;
            cbTipo.Enabled = false;
            cbPreguntas.Enabled = false;
        }

        private void cargarCampos(Publicacion pub)
        {
            tbDescripcion.Text = pub.Descripcion;
            tbStock.Text = pub.Stock.ToString();
            dtpVencimiento.Value = pub.FechaVenc;
            dtpInicio.Value = pub.Fecha;
            tbPrecio.Text = pub.Precio.ToString();
            lbRubros.Text = pub.Rubro;
            cbVisibilidad.Text = pub.Visibilidad;
            cbTipo.Text = pub.Tipo;
        }

    }
}
