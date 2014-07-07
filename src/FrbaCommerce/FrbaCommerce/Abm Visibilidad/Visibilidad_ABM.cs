using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.Abm_Visibilidad
{
    public partial class Visibilidad_ABM : Form
    {
        private VisibilidadDAO dao = new VisibilidadDAO(BD.Instance.Conexion);

        public Visibilidad_ABM()
        {
            InitializeComponent();
            Load_Grilla();
        }

        protected void Load_Grilla()
        {

            DGVisibilidades.DataSource = dao.Productos_Visibilidad_Grilla().Tables[0];
            DGVisibilidades.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void DGVisibilidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                GbEdicion.Visible = true;
                TbCodigo.Text = DGVisibilidades.Rows[e.RowIndex].Cells["Pub_Visible_Cod"].Value.ToString();
                TbCodigo.Enabled = false;
                TbDesc.Text = DGVisibilidades.Rows[e.RowIndex].Cells["Pub_Visible_Descripcion"].Value.ToString();
                TbPrecio.Text = DGVisibilidades.Rows[e.RowIndex].Cells["Pub_Visible_Precio"].Value.ToString();
                TbPorcentaje.Text = DGVisibilidades.Rows[e.RowIndex].Cells["Pub_Visible_Porcentaje"].Value.ToString();
                CbEstado.SelectedItem = DGVisibilidades.Rows[e.RowIndex].Cells["Pub_Visible_Estado"].Value.ToString();
                TbDuracion.Text = DGVisibilidades.Rows[e.RowIndex].Cells["Pub_Visible_Duracion"].Value.ToString();
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            GbEdicion.Visible = true;
            BtnNuevo.Visible = false;
            //BtnEliminar.Visible = false;
            //BtnEliminar.Visible = true;
            TbCodigo.Text = "Nuevo";
            Limpiadatos();
        }

        private void Limpiadatos()
        {
            TbDesc.Text = "";
            TbPorcentaje.Text = "";
            TbPrecio.Text = "";
            TbDuracion.Text = "";
            CbEstado.SelectedIndex = -1;
            LbError.Text = "";
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Limpiadatos();
            GbEdicion.Visible = false;
            BtnNuevo.Visible = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (EsValido())
            {
                if (TbCodigo.Text.Contains("Nuevo"))
                {
                    dao.Productos_Visibilidad_SAVE(-1, TbDesc.Text, Convert.ToDecimal(TbPrecio.Text), Convert.ToDecimal(TbPorcentaje.Text), CbEstado.SelectedItem.ToString(), Convert.ToInt32(TbDuracion.Text));
                }
                else
                {
                    dao.Productos_Visibilidad_SAVE(Convert.ToInt32(TbCodigo.Text), TbDesc.Text, Convert.ToDecimal(TbPrecio.Text), Convert.ToDecimal(TbPorcentaje.Text), CbEstado.SelectedItem.ToString(), Convert.ToInt32(TbDuracion.Text));
                }
                GbEdicion.Visible = false;
                BtnNuevo.Visible = true;
                Load_Grilla();
            }
        }

        protected bool EsValido()
        {
            Boolean RTA = true;
            if (TbDesc.Text.Trim().Length < 1)
            {
                LbError.Text = LbError.Text + " * El Campo Descripcion esta vacio" + "\r\n";
                RTA = false;
            }
            try
            {
                Convert.ToDecimal(TbPorcentaje.Text);
            }
            catch
            {
                LbError.Text = LbError.Text + " * El Campo Pocentaje no es de tipo decimal" + "\r\n";
                RTA = false;
            }

            try
            {
                Convert.ToDecimal(TbPrecio.Text);
            }
            catch
            {
                LbError.Text = LbError.Text + " * El Campo Precio no es de tipo decimal" + "\r\n";
                RTA = false;
            }

            try
            {
                Convert.ToDecimal(TbDuracion.Text);
            }
            catch
            {
                LbError.Text = LbError.Text + " * El Campo Duracion no es de tipo entero" + "\r\n";
                RTA = false;
            }

            return RTA;
        }










    }
}
