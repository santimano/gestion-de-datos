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
        public Visibilidad_ABM()
        {
            InitializeComponent();
            DGVisibilidades.DataSource = BD.Instance.Productos_Visibilidad_Grilla().Tables[0];
            DGVisibilidades.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);   
           
        }
        private void Load()
        {
            
            DGVisibilidades.DataSource = BD.Instance.Productos_Visibilidad_Grilla();
            DGVisibilidades.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);           
        }

        private void DGVisibilidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GbEdicion.Visible = true;
            TbCodigo.Text = DGVisibilidades.Rows[e.RowIndex].Cells["Pub_Visible_Cod"].Value.ToString();
            TbCodigo.Enabled = false;
            TbDesc.Text = DGVisibilidades.Rows[e.RowIndex].Cells["Pub_Visible_Descripcion"].Value.ToString();
            TbPrecio.Text = DGVisibilidades.Rows[e.RowIndex].Cells["Pub_Visible_Precio"].Value.ToString();
            TbPorcentaje.Text = DGVisibilidades.Rows[e.RowIndex].Cells["Pub_Visible_Porcentaje"].Value.ToString(); 

          
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            GbEdicion.Visible = true;
            BtnNuevo.Visible = false;
            BtnEliminar.Visible = false;
            BtnEliminar.Visible = true;
            TbCodigo.Text = "Nuevo";
            Limpiadatos();
        }

        private void Limpiadatos()
        {
            TbDesc.Text = "";
            TbPorcentaje.Text = "";
            TbPrecio.Text = "";
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
                    BD.Instance.Productos_Visibilidad_SAVE(-1,TbDesc.Text,Convert.ToDecimal(TbPrecio.Text),Convert.ToDecimal(TbPorcentaje.Text));
                }
                else
                {
                    BD.Instance.Productos_Visibilidad_SAVE(Convert.ToInt32(TbCodigo.Text), TbDesc.Text, Convert.ToDecimal(TbPrecio.Text), Convert.ToDecimal(TbPorcentaje.Text));
                }
            }
        }

        protected bool EsValido()
        {
            Boolean RTA = true;
            if (TbDesc.Text.Trim().Length < 1)
            {
                LbError.Text = LbError.Text + " * El Campo Descripcion esta vacio" + "\r\n";
            }


            try
            {
                Convert.ToDecimal(TbPorcentaje.Text);
            }
            catch{
                LbError.Text = LbError.Text + " * El Campo Pocentaje no es de tipo decimal" + "\r\n";
                RTA = false;
            }

            try
            {
                Convert.ToDecimal( TbPrecio.Text  );
            }
            catch
            {
                LbError.Text = LbError.Text + " * El Campo Precio no es de tipo decimal" + "\r\n";
                RTA = false;
            }
            return RTA;
        }

    

       

     
    
        

     
    }
}
