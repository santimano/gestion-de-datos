﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class EditarCliente : Form
    {
        private ClienteDAO dao = new ClienteDAO(BD.Instance.Conexion);
        private string accion;

        public EditarCliente(string a, DataGridViewRow linea)
        {
            InitializeComponent();
            this.accion = a;
            comboBoxTipoDocumento.Items.AddRange(dao.TipoDocumento().ToArray());
            if (this.accion == "modificacion")
                this.Modificacion(linea);
            else
                this.Text = "AgregarCliente";
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                comboBoxEstado.SelectedItem.ToString()) == true)
                this.Close();
        }
    }
}