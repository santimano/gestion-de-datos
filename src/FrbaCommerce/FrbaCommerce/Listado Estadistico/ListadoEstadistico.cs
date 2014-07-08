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

namespace FrbaCommerce.Listado_Estadistico
{
    public partial class ListadoEstadistico : Form
    {
        private ListadoEstadisticoDAO dao = new ListadoEstadisticoDAO(BD.Instance.Conexion);
        private VisibilidadDAO visibilidadDao = new VisibilidadDAO(BD.Instance.Conexion);

        public ListadoEstadistico()
        {
            InitializeComponent();
            comboBoxVisibilidad.Items.AddRange(visibilidadDao.FindAll().ToArray());
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            comboBoxAnio.SelectedIndex = -1;
            comboBoxReporte.SelectedIndex = -1;
            comboBoxTrimestre.SelectedIndex = -1;
            groupBoxResultados.Visible = false;
            comboBoxVisibilidad.SelectedIndex = -1;
            tbMes.Text = "";
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (comboBoxAnio.SelectedItem == null)
                MessageBox.Show(null, "Por favor seleccione un año.", "Error");
            else if (comboBoxTrimestre.SelectedItem == null)
                MessageBox.Show(null, "Por favor seleccione un trimestre.", "Error");
            else if (comboBoxReporte.SelectedItem == null)
                MessageBox.Show(null, "Por favor seleccione un reporte.", "Error");
            else Generar_Reporte();

        }

        private void Generar_Reporte()
        {
            string visibilidad = "";
            if (gbFiltros.Visible)
            {
                if (tbMes.Text == null || tbMes.Text == "")
                {
                    MessageBox.Show(null, "Por favor seleccione un mes", "Error");
                    return;
                }
                if (comboBoxVisibilidad.SelectedItem == null)
                {
                    MessageBox.Show(null, "Por favor seleccione una Visibilidad", "Error");
                    return;
                }
                visibilidad = comboBoxVisibilidad.SelectedItem.ToString();
            }
            dataGridViewResultados.DataSource = dao.GenerarReporte(comboBoxAnio.SelectedItem.ToString(), comboBoxTrimestre.SelectedItem.ToString(), comboBoxReporte.SelectedItem.ToString(), tbMes.Text, visibilidad).Tables[0];
            dataGridViewResultados.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            groupBoxResultados.Visible = true;
        }

        private void comboBoxReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxReporte.SelectedItem == null)
            {
                gbFiltros.Visible = false;
            }
            else if (comboBoxReporte.SelectedItem.ToString().ToLower() == "vendedores con mayor cantidad de productos no vendidos")
            {
                gbFiltros.Visible = true;
            }
            else
            {
                gbFiltros.Visible = false;
            }
        }
    }
}
