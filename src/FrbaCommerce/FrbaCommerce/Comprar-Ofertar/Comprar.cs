using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelo;
using FrbaCommerce.Generar_Publicacion;
using FrbaCommerce.Abm_Rubro;

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class Comprar : Form
    {
        private PublicacionDAO dao = new PublicacionDAO(BD.Instance.Conexion);
        private RubroDAO rubroDao = new RubroDAO(BD.Instance.Conexion);

        private DataTable dtSource;
        private int cantidadDePaginas;
        private int maximoRegistro;
        private int tamanioPagina = 15;
        private int paginaActual;
        private int nroRegistro;

        public Comprar()
        {
            InitializeComponent();
            lbRubros.Items.AddRange(rubroDao.FindAll().ToArray());
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            dtSource = dao.Publicaciones_Grilla(tbDescripcion.Text, lbRubros.SelectedItems).Tables[0];
            dataGridView1.AutoGenerateColumns = false;
            maximoRegistro = dtSource.Rows.Count;
            cantidadDePaginas = maximoRegistro / tamanioPagina;

            if ((maximoRegistro % tamanioPagina) > 0)
            {
                cantidadDePaginas += 1;
            }

            paginaActual = 1;
            nroRegistro = 0;

            CargarPagina();
        }

        private void CargarPagina()
        {
            int i;
            int registroInicial;
            int registroFinal;
            DataTable dtTemp;

            dtTemp = dtSource.Clone();

            if (paginaActual == cantidadDePaginas)
            {
                registroFinal = maximoRegistro;
            }
            else
            {
                registroFinal = tamanioPagina * paginaActual;
            }
            registroInicial = nroRegistro;

            for (i = registroInicial; i < registroFinal; i++)
            {
                dtTemp.ImportRow(dtSource.Rows[i]);
                nroRegistro += 1;
            }
            dataGridView1.DataSource = dtTemp;
            CargarPaginaActual();
        }
        private void CargarPaginaActual()
        {
            tbPaginas.Text = paginaActual.ToString() + "/" + cantidadDePaginas.ToString();
        }

        private void btPrimera_Click(object sender, EventArgs e)
        {
            if (paginaActual == 1)
            {
                MessageBox.Show("Se muestra la primera pagina");
                return;
            }

            paginaActual = 1;
            nroRegistro = 0;
            CargarPagina();
        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {
            paginaActual += 1;
            if (paginaActual > cantidadDePaginas)
            {
                paginaActual = cantidadDePaginas;
                if (nroRegistro == maximoRegistro)
                {
                    MessageBox.Show("Se muestra la ultima pagina");
                    return;
                }
            }
            CargarPagina();
        }

        private void btAnterior_Click(object sender, EventArgs e)
        {
            if (paginaActual == cantidadDePaginas)
            {
                nroRegistro = tamanioPagina * (paginaActual - 2);
            }

            paginaActual -= 1;
            if (paginaActual < 1)
            {
                MessageBox.Show("Se muestra la primera pagina");
                paginaActual = 1;
                return;
            }
            else
            {
                nroRegistro = tamanioPagina * (paginaActual - 1);
            }
            CargarPagina();
        }

        private void btUltima_Click(object sender, EventArgs e)
        {
            if (nroRegistro == maximoRegistro)
            {
                MessageBox.Show("Se muestra la ultima pagina");
                return;
            }
            paginaActual = cantidadDePaginas;
            nroRegistro = tamanioPagina * (paginaActual - 1);
            CargarPagina();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
