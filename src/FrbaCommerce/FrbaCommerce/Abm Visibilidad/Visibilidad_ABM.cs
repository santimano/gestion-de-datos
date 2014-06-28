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

    
        

     
    }
}
