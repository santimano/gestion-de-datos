using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.Gestion_de_Preguntas
{
    public partial class Respuestas : Form
    {
        PreguntasDAO dao = new PreguntasDAO(BD.Instance.Conexion);

        public Respuestas()
        {
            InitializeComponent();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            rbRespondidas.Checked = false;
            rbSinResponder.Checked = false;
            cbEstado.Text = null;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dao.Respuestas_Grilla(cbEstado.Text, rbRespondidas.Checked, rbSinResponder.Checked).Tables[0];
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
