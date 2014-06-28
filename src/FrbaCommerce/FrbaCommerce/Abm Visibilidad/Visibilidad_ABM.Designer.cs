﻿namespace FrbaCommerce.Abm_Visibilidad
{
    partial class Visibilidad_ABM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGVisibilidades = new System.Windows.Forms.DataGridView();
            this.GbEdicion = new System.Windows.Forms.GroupBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.LbPorcentaje = new System.Windows.Forms.Label();
            this.LbPrecio = new System.Windows.Forms.Label();
            this.LbDescripcion = new System.Windows.Forms.Label();
            this.LbCodigo = new System.Windows.Forms.Label();
            this.TbDesc = new System.Windows.Forms.TextBox();
            this.TbCodigo = new System.Windows.Forms.TextBox();
            this.Pub_Visible_Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pub_Visible_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pub_Visible_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pub_Visible_Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TbPrecio = new System.Windows.Forms.TextBox();
            this.TbPorcentaje = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVisibilidades)).BeginInit();
            this.GbEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVisibilidades);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visibilidades Existentes";
            // 
            // DGVisibilidades
            // 
            this.DGVisibilidades.AllowUserToAddRows = false;
            this.DGVisibilidades.AllowUserToOrderColumns = true;
            this.DGVisibilidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVisibilidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pub_Visible_Cod,
            this.Pub_Visible_Descripcion,
            this.Pub_Visible_Precio,
            this.Pub_Visible_Porcentaje,
            this.Editar});
            this.DGVisibilidades.Location = new System.Drawing.Point(6, 19);
            this.DGVisibilidades.Name = "DGVisibilidades";
            this.DGVisibilidades.Size = new System.Drawing.Size(650, 150);
            this.DGVisibilidades.TabIndex = 0;
            this.DGVisibilidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVisibilidades_CellContentClick);
            // 
            // GbEdicion
            // 
            this.GbEdicion.Controls.Add(this.TbPorcentaje);
            this.GbEdicion.Controls.Add(this.TbPrecio);
            this.GbEdicion.Controls.Add(this.BtnEliminar);
            this.GbEdicion.Controls.Add(this.BtnGuardar);
            this.GbEdicion.Controls.Add(this.LbPorcentaje);
            this.GbEdicion.Controls.Add(this.LbPrecio);
            this.GbEdicion.Controls.Add(this.LbDescripcion);
            this.GbEdicion.Controls.Add(this.LbCodigo);
            this.GbEdicion.Controls.Add(this.TbDesc);
            this.GbEdicion.Controls.Add(this.TbCodigo);
            this.GbEdicion.Location = new System.Drawing.Point(12, 206);
            this.GbEdicion.Name = "GbEdicion";
            this.GbEdicion.Size = new System.Drawing.Size(656, 121);
            this.GbEdicion.TabIndex = 1;
            this.GbEdicion.TabStop = false;
            this.GbEdicion.Text = "Edicion Visibilidad";
            this.GbEdicion.Visible = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(541, 80);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 9;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(541, 25);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 8;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // LbPorcentaje
            // 
            this.LbPorcentaje.AutoSize = true;
            this.LbPorcentaje.Location = new System.Drawing.Point(379, 25);
            this.LbPorcentaje.Name = "LbPorcentaje";
            this.LbPorcentaje.Size = new System.Drawing.Size(58, 13);
            this.LbPorcentaje.TabIndex = 7;
            this.LbPorcentaje.Text = "Porcentaje";
            // 
            // LbPrecio
            // 
            this.LbPrecio.AutoSize = true;
            this.LbPrecio.Location = new System.Drawing.Point(286, 25);
            this.LbPrecio.Name = "LbPrecio";
            this.LbPrecio.Size = new System.Drawing.Size(37, 13);
            this.LbPrecio.TabIndex = 6;
            this.LbPrecio.Text = "Precio";
            // 
            // LbDescripcion
            // 
            this.LbDescripcion.AutoSize = true;
            this.LbDescripcion.Location = new System.Drawing.Point(119, 25);
            this.LbDescripcion.Name = "LbDescripcion";
            this.LbDescripcion.Size = new System.Drawing.Size(63, 13);
            this.LbDescripcion.TabIndex = 5;
            this.LbDescripcion.Text = "Descripción";
            // 
            // LbCodigo
            // 
            this.LbCodigo.AutoSize = true;
            this.LbCodigo.Location = new System.Drawing.Point(17, 25);
            this.LbCodigo.Name = "LbCodigo";
            this.LbCodigo.Size = new System.Drawing.Size(40, 13);
            this.LbCodigo.TabIndex = 4;
            this.LbCodigo.Text = "Código";
            // 
            // TbDesc
            // 
            this.TbDesc.Location = new System.Drawing.Point(113, 54);
            this.TbDesc.Name = "TbDesc";
            this.TbDesc.Size = new System.Drawing.Size(170, 20);
            this.TbDesc.TabIndex = 1;
            // 
            // TbCodigo
            // 
            this.TbCodigo.Location = new System.Drawing.Point(20, 54);
            this.TbCodigo.Name = "TbCodigo";
            this.TbCodigo.Size = new System.Drawing.Size(87, 20);
            this.TbCodigo.TabIndex = 0;
            // 
            // Pub_Visible_Cod
            // 
            this.Pub_Visible_Cod.DataPropertyName = "Pub_Visible_Cod";
            this.Pub_Visible_Cod.HeaderText = "Codigo";
            this.Pub_Visible_Cod.Name = "Pub_Visible_Cod";
            this.Pub_Visible_Cod.ReadOnly = true;
            // 
            // Pub_Visible_Descripcion
            // 
            this.Pub_Visible_Descripcion.DataPropertyName = "Pub_Visible_Descripcion";
            this.Pub_Visible_Descripcion.HeaderText = "Descripcion";
            this.Pub_Visible_Descripcion.Name = "Pub_Visible_Descripcion";
            this.Pub_Visible_Descripcion.ReadOnly = true;
            // 
            // Pub_Visible_Precio
            // 
            this.Pub_Visible_Precio.DataPropertyName = "Pub_Visible_Precio";
            this.Pub_Visible_Precio.HeaderText = "Precio";
            this.Pub_Visible_Precio.Name = "Pub_Visible_Precio";
            this.Pub_Visible_Precio.ReadOnly = true;
            // 
            // Pub_Visible_Porcentaje
            // 
            this.Pub_Visible_Porcentaje.DataPropertyName = "Pub_Visible_Porcentaje";
            this.Pub_Visible_Porcentaje.HeaderText = "Porcentaje";
            this.Pub_Visible_Porcentaje.Name = "Pub_Visible_Porcentaje";
            this.Pub_Visible_Porcentaje.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Text = "Editar";
            this.Editar.ToolTipText = "Permite editar un item de visibilidad";
            this.Editar.UseColumnTextForButtonValue = true;
            // 
            // TbPrecio
            // 
            this.TbPrecio.Location = new System.Drawing.Point(289, 53);
            this.TbPrecio.Name = "TbPrecio";
            this.TbPrecio.Size = new System.Drawing.Size(87, 20);
            this.TbPrecio.TabIndex = 12;
            // 
            // TbPorcentaje
            // 
            this.TbPorcentaje.Location = new System.Drawing.Point(382, 54);
            this.TbPorcentaje.Name = "TbPorcentaje";
            this.TbPorcentaje.Size = new System.Drawing.Size(87, 20);
            this.TbPorcentaje.TabIndex = 13;
            // 
            // Visibilidad_ABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 359);
            this.Controls.Add(this.GbEdicion);
            this.Controls.Add(this.groupBox1);
            this.Name = "Visibilidad_ABM";
            this.Text = "Visibilidad ABM";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVisibilidades)).EndInit();
            this.GbEdicion.ResumeLayout(false);
            this.GbEdicion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGVisibilidades;
        private System.Windows.Forms.GroupBox GbEdicion;
        private System.Windows.Forms.Label LbPorcentaje;
        private System.Windows.Forms.Label LbPrecio;
        private System.Windows.Forms.Label LbDescripcion;
        private System.Windows.Forms.Label LbCodigo;
        private System.Windows.Forms.TextBox TbDesc;
        private System.Windows.Forms.TextBox TbCodigo;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pub_Visible_Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pub_Visible_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pub_Visible_Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pub_Visible_Porcentaje;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.TextBox TbPorcentaje;
        private System.Windows.Forms.TextBox TbPrecio;

    }
}