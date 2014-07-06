using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class EditarEmpresa : Form
    {
        private EmpresaDAO dao = new EmpresaDAO(BD.Instance.Conexion);
        private string usuario;
        private string password;

        public EditarEmpresa(string accion, DataGridViewRow linea, string user, string pass)
        {
            InitializeComponent();
            this.usuario = user;
            this.password = pass;
            if (accion == "modificacion")
                this.Modificacion(linea);
            else
                this.Alta();
        }

        private void Modificacion(DataGridViewRow linea)
        {
            textBoxID.Text = linea.Cells["ID"].Value.ToString();
            textBoxCuit.Text = linea.Cells["Cuit"].Value.ToString();
            textBoxRazonSocial.Text = linea.Cells["Razon_Soc"].Value.ToString();
            textBoxFechaCreacion.Text = ((DateTime)linea.Cells["Fecha_Creacion"].Value).ToString("dd/MM/yyyy");
            textBoxNombreContacto.Text = linea.Cells["Contacto"].Value.ToString();
            textBoxMail.Text = linea.Cells["Mail"].Value.ToString();
            textBoxCalle.Text = linea.Cells["Calle"].Value.ToString();
            textBoxNumero.Text = linea.Cells["Nro"].Value.ToString();
            textBoxPiso.Text = linea.Cells["Piso"].Value.ToString();
            textBoxLocalidad.Text = linea.Cells["Localidad"].Value.ToString();
            textBoxCiudad.Text = linea.Cells["Ciudad"].Value.ToString();
            textBoxDepto.Text = linea.Cells["Depto"].Value.ToString();
            textBoxCodPostal.Text = linea.Cells["Cod_Postal"].Value.ToString();
            textBoxTelefono.Text = linea.Cells["Telefono"].Value.ToString();
            comboBoxEstado.SelectedItem = linea.Cells["Estado"].Value.ToString();
        }

        private void Alta()
        {
            this.Text = "AgregarEmpresa";
            if (this.usuario != null)
            {
                comboBoxEstado.SelectedItem = "ACTIVO";
                labelEstado.Hide();
                comboBoxEstado.Hide();
            }
            labelID.Hide();
            textBoxID.Hide();
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFechaNacimiento_Click(object sender, EventArgs e)
        {
            buttonFecha.Show();
            monthCalendarFechaCreacion.Show();
        }

        private void buttonFecha_Click(object sender, EventArgs e)
        {
            textBoxFechaCreacion.Text = monthCalendarFechaCreacion.SelectionRange.Start.ToString("dd/MM/yyyy");
            monthCalendarFechaCreacion.Hide();
            buttonFecha.Hide();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (this.validarcampos() == true)
                if (dao.GuardarEmpresa(textBoxID.Text,
                    textBoxCuit.Text,
                    textBoxRazonSocial.Text,
                    textBoxFechaCreacion.Text,
                    textBoxMail.Text,
                    textBoxNombreContacto.Text,
                    textBoxTelefono.Text,
                    textBoxCiudad.Text,
                    textBoxCalle.Text,
                    textBoxNumero.Text,
                    textBoxPiso.Text,
                    textBoxCodPostal.Text,
                    textBoxDepto.Text,
                    textBoxLocalidad.Text,
                    comboBoxEstado.SelectedItem.ToString()
                    ,this.usuario
                    ,this.password) == true)
                    this.Close();
        }

        private bool validarcampos()
        {
            if (Regex.Match(textBoxRazonSocial.Text, @"[a-zA-Z0-9]+", RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace).Success == false)
            {
                MessageBox.Show(null, "La razon social no es valida.", "Error");
                return false;
            }
            if (Regex.Match(textBoxNombreContacto.Text, @"^[a-zA-Z]+", RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace).Success == false)
            {
                MessageBox.Show(null, "El nombre de contacto no es valido.", "Error");
                return false;
            }
            if (Regex.Match(textBoxCuit.Text, @"^[0-9]+-[0-9]+-[0-9]+$", RegexOptions.Compiled).Success == false)
            {
                MessageBox.Show(null, "El CUIT no es valido.", "Error");
                return false;
            }
            if (Regex.Match(textBoxMail.Text, @"^[0-9a-zA-Z]+([0-9a-zA-Z]*[-._+])*[0-9a-zA-Z]+@[0-9a-zA-Z]+([-.][0-9a-zA-Z]+)*([0-9a-zA-Z]*[.])[a-zA-Z]{2,6}$", RegexOptions.Compiled).Success == false)
            {
                MessageBox.Show(null, "El mail no es valido.", "Error");
                return false;
            }
            if (Regex.Match(textBoxCiudad.Text, @"[a-zA-Z0-9]+$", RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace).Success == false)
            {
                MessageBox.Show(null, "La ciudad no es valida.", "Error");
                return false;
            }
            if (Regex.Match(textBoxCalle.Text, @"[a-zA-Z0-9]+$", RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace).Success == false)
            {
                MessageBox.Show(null, "La calle no es valida.", "Error");
                return false;
            }
            if (comboBoxEstado.SelectedItem == null)
            {
                MessageBox.Show(null, "Debe elegir un estado para el cliente.", "Error");
                return false;
            }
            if (textBoxFechaCreacion.Text.Length < 1)
            {
                MessageBox.Show(null, "Debe seleccionar una fecha de creacion.", "Error");
                return false;
            }
            if (Regex.Match(textBoxNumero.Text, @"^[0-9]+$", RegexOptions.Compiled).Success == false)
            {
                MessageBox.Show(null, "El numero no es valido.", "Error");
                return false;
            }
            if (Regex.Match(textBoxCodPostal.Text, @"^[a-zA-Z0-9]+$", RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace).Success == false)
            {
                MessageBox.Show(null, "El codigo postal no es valido.", "Error");
                return false;
            }
            if (Regex.Match(textBoxPiso.Text, @"^[0-9]*$", RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace).Success == false)
            {
                MessageBox.Show(null, "El piso no es valido.", "Error");
                return false;
            }
            if (Regex.Match(textBoxDepto.Text, @"^[a-zA-Z]*$", RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace).Success == false)
            {
                MessageBox.Show(null, "El depto no es valido.", "Error");
                return false;
            }
            if (Regex.Match(textBoxTelefono.Text, @"^[a-zA-Z0-9-\.]+$", RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace).Success == false)
            {
                MessageBox.Show(null, "El telefono no es valido.", "Error");
                return false;
            }

            return true;
        }
    }
}
