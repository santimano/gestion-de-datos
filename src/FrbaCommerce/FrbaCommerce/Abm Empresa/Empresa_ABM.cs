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
    public partial class Empresa_ABM : Form
    {
        private EmpresaDAO dao = new EmpresaDAO(BD.Instance.Conexion);

        public Empresa_ABM()
        {
            InitializeComponent();
            this.actualizar();
        }

        private void actualizar()
        {
            dataGridViewEmpresas.DataSource = dao.EmpresasGrilla(textBoxCuit.Text, textBoxRazonSocial.Text, textBoxMail.Text).Tables[0];
            dataGridViewEmpresas.Columns["Fecha_Creacion"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridViewEmpresas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }


        private void limpiar()
        {
            textBoxCuit.Clear();
            textBoxMail.Clear();
            textBoxRazonSocial.Clear();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            this.actualizar();
        }

    }
}
