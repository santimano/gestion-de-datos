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
    public partial class Responder : Form
    {
        private PreguntasDAO dao = new PreguntasDAO(BD.Instance.Conexion);

        private int pregunta;

        public Responder(int pregunta)
        {
            InitializeComponent();
            this.pregunta = pregunta;
        }

        private void btResponder_Click(object sender, EventArgs e)
        {
            if (null == tbRespuesta.Text || "".Equals(tbRespuesta.Text))
            {
                MessageBox.Show("Debe escribir una respuesta");
                return;
            }

            dao.Guardar_Respuesta(pregunta, tbRespuesta.Text);
            this.Close();
        }
    }
}
