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

namespace FrbaCommerce.Abm_Cliente
{
    public partial class EditarCliente : Form
    {
        private ClienteDAO dao = new ClienteDAO(BD.Instance.Conexion);
        private string usuario;
        private string password;

        public EditarCliente(string accion, DataGridViewRow linea, string user, string pass)
        {
            InitializeComponent();
            this.usuario = user;
            this.password = pass;
            comboBoxTipoDocumento.Items.AddRange(dao.TipoDocumento().ToArray());
            if (accion == "modificacion")
                this.Modificacion(linea);
            else
                this.Alta();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Alta()
        {
            this.Text = "AgregarCliente";
            if (this.usuario != null)
            {
                comboBoxEstado.SelectedItem = "ACTIVO";
                labelEstado.Hide();
                comboBoxEstado.Hide();
            }
            labelID.Hide();
            textBoxID.Hide();

        }

        private void Modificacion(DataGridViewRow linea)
        {
            textBoxID.Text = linea.Cells["ID"].Value.ToString();
            textBoxNombre.Text = linea.Cells["Nombre"].Value.ToString();
            textBoxApellido.Text = linea.Cells["Apellido"].Value.ToString();
            textBoxDocumento.Text = linea.Cells["Nro_Doc"].Value.ToString();
            textBoxCUIL.Text = linea.Cells["Cuil"].Value.ToString();
            textBoxMail.Text = linea.Cells["Mail"].Value.ToString();
            textBoxFechaNacimiento.Text = ((DateTime)linea.Cells["Fecha_Nac"].Value).ToString("dd/MM/yyyy");
            comboBoxTipoDocumento.SelectedItem = linea.Cells["Tipo_Doc"].Value.ToString();
            textBoxTelefono.Text = linea.Cells["Telefono"].Value.ToString();
            textBoxCalle.Text = linea.Cells["Calle"].Value.ToString();
            textBoxNumero.Text = linea.Cells["Nro"].Value.ToString();
            textBoxPiso.Text = linea.Cells["Piso"].Value.ToString();
            textBoxLocalidad.Text = linea.Cells["Localidad"].Value.ToString();
            textBoxDepto.Text = linea.Cells["Depto"].Value.ToString();
            textBoxCodPostal.Text = linea.Cells["Cod_Postal"].Value.ToString();
            comboBoxEstado.SelectedItem = linea.Cells["Estado"].Value.ToString();
        }

        private void buttonFechaNacimiento_Click(object sender, EventArgs e)
        {
            buttonFecha.Show();
            monthCalendarFechaNacimiento.Show();
        }

        private void buttonFecha_Click(object sender, EventArgs e)
        {
            textBoxFechaNacimiento.Text = monthCalendarFechaNacimiento.SelectionRange.Start.ToString("dd/MM/yyyy");
            monthCalendarFechaNacimiento.Hide();
            buttonFecha.Hide();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (this.validarcampos() == true)
                if (dao.GuardarCliente(textBoxID.Text,
                    textBoxNombre.Text,
                    textBoxApellido.Text,
                    comboBoxTipoDocumento.SelectedItem.ToString(),
                    textBoxDocumento.Text,
                    textBoxCUIL.Text,
                    textBoxFechaNacimiento.Text,
                    textBoxMail.Text,
                    textBoxCalle.Text,
                    textBoxNumero.Text,
                    textBoxPiso.Text,
                    textBoxCodPostal.Text,
                    textBoxDepto.Text,
                    textBoxLocalidad.Text,
                    textBoxTelefono.Text,
                    comboBoxEstado.SelectedItem.ToString()
                    , this.usuario
                    , this.password) == true)
                    this.Close();
        }

        private bool validarcampos()
        {
            if (Regex.Match(textBoxNombre.Text, @"^[a-zA-Z]+", RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace).Success == false)
            {
                MessageBox.Show(null, "El nombre no es valido.", "Error");
                return false;
            }
            if (Regex.Match(textBoxApellido.Text, @"^[a-zA-Z]+", RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace).Success == false)
            {
                MessageBox.Show(null, "El apellido no es valido.", "Error");
                return false;
            }
            if (Regex.Match(textBoxCUIL.Text, @"^[0-9]+-[0-9]+-[0-9]+$", RegexOptions.Compiled).Success == false)
            {
                MessageBox.Show(null, "El CUIL no es valido.", "Error");
                return false;
            }
            if (Regex.Match(textBoxDocumento.Text, @"^[0-9]+$", RegexOptions.Compiled).Success == false)
            {
                MessageBox.Show(null, "El documento no es valido.", "Error");
                return false;
            }
            if (Regex.Match(textBoxMail.Text, @"^[0-9a-zA-Z]+([0-9a-zA-Z]*[-._+])*[0-9a-zA-Z]+@[0-9a-zA-Z]+([-.][0-9a-zA-Z]+)*([0-9a-zA-Z]*[.])[a-zA-Z]{2,6}$", RegexOptions.Compiled).Success == false)
            {
                MessageBox.Show(null, "El mail no es valido.", "Error");
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
            if (comboBoxTipoDocumento.SelectedItem == null)
            {
                MessageBox.Show(null, "Debe elegir un tipo de documento.", "Error");
                return false;
            }
            if (textBoxFechaNacimiento.Text.Length < 1 )
            {
                MessageBox.Show(null, "Debe seleccionar una fecha de nacimiento.", "Error");
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
