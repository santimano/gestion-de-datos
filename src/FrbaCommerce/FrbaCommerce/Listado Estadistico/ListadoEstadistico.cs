using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.Listado_Estadistico
{
    public partial class ListadoEstadistico : Form
    {
        private ListadoEstadisticoDAO dao = new ListadoEstadisticoDAO(BD.Instance.Conexion);

        public ListadoEstadistico()
        {
            InitializeComponent();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            comboBoxAnio.SelectedIndex = -1;
            comboBoxReporte.SelectedIndex = -1;
            comboBoxTrimestre.SelectedIndex = -1;
            groupBoxResultados.Visible = false;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (comboBoxAnio.SelectedItem == null)
                MessageBox.Show(null, "Por favor seleccione un año.", "Error");
            else if (comboBoxTrimestre.SelectedItem == null)
                MessageBox.Show(null, "Por favor seleccione un trimestre.", "Error");
            else if (comboBoxReporte.SelectedItem == null)
                MessageBox.Show(null, "Por favor seleccione un reporte.", "Error");
            else
            {
                dataGridViewResultados.DataSource = dao.GenerarReporte(comboBoxAnio.SelectedItem.ToString(), comboBoxTrimestre.SelectedItem.ToString(), comboBoxReporte.SelectedItem.ToString()).Tables[0];
                dataGridViewResultados.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                groupBoxResultados.Visible = true;
            }
                
        }
    }
}
