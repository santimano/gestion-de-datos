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
    public partial class Preguntas : Form
    {
        private PreguntasDAO dao = new PreguntasDAO(BD.Instance.Conexion);

        public Preguntas()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dao.Preguntas_Grilla().Tables[0];
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pregunta = (int)dataGridView1.Rows[e.RowIndex].Cells["IdPregunta"].Value;
            new Responder(pregunta).ShowDialog();
            dataGridView1.DataSource = dao.Preguntas_Grilla().Tables[0];
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
