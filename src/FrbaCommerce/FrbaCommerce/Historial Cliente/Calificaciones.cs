using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.Historial_Cliente
{
    public partial class Calificaciones : Form
    {
        private CalificacionDAO dao = new CalificacionDAO(BD.Instance.Conexion);

        public Calificaciones(bool isEmpresa)
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            rbOtorgadas.Enabled = !isEmpresa;
            rbOtorgadas.Visible = !isEmpresa;
            rbRecibidas.Visible = !isEmpresa;
            rbRecibidas.Checked = isEmpresa;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            bool otorgadas;
            if (!rbOtorgadas.Checked && !rbRecibidas.Checked)
            { 
                MessageBox.Show("Debe seleccionar un tipo de calificacion"); 
                return; 
            }
            else 
            { 
                otorgadas = rbOtorgadas.Checked; 
            }
            if (otorgadas)
            {
                this.Usuario.DataPropertyName = "Vendedor";
            }
            else
            {
                this.Usuario.DataPropertyName = "Comprador";
            }
            dataGridView1.DataSource = dao.Calificaciones_Grilla(otorgadas).Tables[0];

            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
