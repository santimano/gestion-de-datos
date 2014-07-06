using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class EmpresaNuevoPass : Form
    {
        private EmpresaDAO dao = new EmpresaDAO(BD.Instance.Conexion);
        private string id_empresa;

        public EmpresaNuevoPass(string id)
        {
            InitializeComponent();
            this.id_empresa = id;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxNuevoPassword.Text.Length < 1)
                MessageBox.Show(null, "El password no puede ser vacio.", "Error");
            else if (textBoxNuevoPassword.Text != textBoxConfirmaPassword.Text)
                MessageBox.Show(null, "Los password no coincinden.", "Error");
            else
            {
                dao.CambiarPassword(this.id_empresa, textBoxNuevoPassword.Text, checkBoxCambioPass.Checked);
                this.Close();
            }

        }
    }
}
