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
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.DGVisibilidades = new System.Windows.Forms.DataGridView();
            this.Pub_Visible_Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pub_Visible_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pub_Visible_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pub_Visible_Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pub_Visible_Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pub_Visible_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GbEdicion = new System.Windows.Forms.GroupBox();
            this.TbDuracion = new System.Windows.Forms.TextBox();
            this.LbDuracion = new System.Windows.Forms.Label();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.LbEstado = new System.Windows.Forms.Label();
            this.LbError = new System.Windows.Forms.Label();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.TbPorcentaje = new System.Windows.Forms.TextBox();
            this.TbPrecio = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.LbPorcentaje = new System.Windows.Forms.Label();
            this.LbPrecio = new System.Windows.Forms.Label();
            this.LbDescripcion = new System.Windows.Forms.Label();
            this.LbCodigo = new System.Windows.Forms.Label();
            this.TbDesc = new System.Windows.Forms.TextBox();
            this.TbCodigo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVisibilidades)).BeginInit();
            this.GbEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnNuevo);
            this.groupBox1.Controls.Add(this.DGVisibilidades);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visibilidades Existentes";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(760, 19);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 1;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // DGVisibilidades
            // 
            this.DGVisibilidades.AllowUserToAddRows = false;
            this.DGVisibilidades.AllowUserToDeleteRows = false;
            this.DGVisibilidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVisibilidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pub_Visible_Cod,
            this.Pub_Visible_Descripcion,
            this.Pub_Visible_Precio,
            this.Pub_Visible_Porcentaje,
            this.Pub_Visible_Duracion,
            this.Pub_Visible_Estado,
            this.Editar});
            this.DGVisibilidades.Location = new System.Drawing.Point(6, 19);
            this.DGVisibilidades.Name = "DGVisibilidades";
            this.DGVisibilidades.Size = new System.Drawing.Size(743, 150);
            this.DGVisibilidades.TabIndex = 0;
            this.DGVisibilidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVisibilidades_CellContentClick);
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
            // Pub_Visible_Duracion
            // 
            this.Pub_Visible_Duracion.DataPropertyName = "Pub_Visible_Duracion";
            this.Pub_Visible_Duracion.HeaderText = "Duracion";
            this.Pub_Visible_Duracion.Name = "Pub_Visible_Duracion";
            // 
            // Pub_Visible_Estado
            // 
            this.Pub_Visible_Estado.DataPropertyName = "Pub_Visible_Estado";
            this.Pub_Visible_Estado.HeaderText = "Estado";
            this.Pub_Visible_Estado.Name = "Pub_Visible_Estado";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Text = "Editar";
            this.Editar.ToolTipText = "Permite editar un item de visibilidad";
            this.Editar.UseColumnTextForButtonValue = true;
            // 
            // GbEdicion
            // 
            this.GbEdicion.Controls.Add(this.TbDuracion);
            this.GbEdicion.Controls.Add(this.LbDuracion);
            this.GbEdicion.Controls.Add(this.BtnGuardar);
            this.GbEdicion.Controls.Add(this.CbEstado);
            this.GbEdicion.Controls.Add(this.LbEstado);
            this.GbEdicion.Controls.Add(this.LbError);
            this.GbEdicion.Controls.Add(this.Btn_Cancelar);
            this.GbEdicion.Controls.Add(this.TbPorcentaje);
            this.GbEdicion.Controls.Add(this.TbPrecio);
            this.GbEdicion.Controls.Add(this.LbPorcentaje);
            this.GbEdicion.Controls.Add(this.LbPrecio);
            this.GbEdicion.Controls.Add(this.LbDescripcion);
            this.GbEdicion.Controls.Add(this.LbCodigo);
            this.GbEdicion.Controls.Add(this.TbDesc);
            this.GbEdicion.Controls.Add(this.TbCodigo);
            this.GbEdicion.Location = new System.Drawing.Point(12, 206);
            this.GbEdicion.Name = "GbEdicion";
            this.GbEdicion.Size = new System.Drawing.Size(841, 131);
            this.GbEdicion.TabIndex = 1;
            this.GbEdicion.TabStop = false;
            this.GbEdicion.Text = "Edicion Visibilidad";
            this.GbEdicion.Visible = false;
            // 
            // TbDuracion
            // 
            this.TbDuracion.Location = new System.Drawing.Point(519, 55);
            this.TbDuracion.Name = "TbDuracion";
            this.TbDuracion.Size = new System.Drawing.Size(87, 20);
            this.TbDuracion.TabIndex = 9;
            // 
            // LbDuracion
            // 
            this.LbDuracion.AutoSize = true;
            this.LbDuracion.Location = new System.Drawing.Point(516, 28);
            this.LbDuracion.Name = "LbDuracion";
            this.LbDuracion.Size = new System.Drawing.Size(50, 13);
            this.LbDuracion.TabIndex = 8;
            this.LbDuracion.Text = "Duracion";
            // 
            // CbEstado
            // 
            this.CbEstado.FormattingEnabled = true;
            this.CbEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.CbEstado.Location = new System.Drawing.Point(612, 55);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(99, 21);
            this.CbEstado.TabIndex = 11;
            // 
            // LbEstado
            // 
            this.LbEstado.AutoSize = true;
            this.LbEstado.Location = new System.Drawing.Point(626, 28);
            this.LbEstado.Name = "LbEstado";
            this.LbEstado.Size = new System.Drawing.Size(40, 13);
            this.LbEstado.TabIndex = 10;
            this.LbEstado.Text = "Estado";
            // 
            // LbError
            // 
            this.LbError.AutoSize = true;
            this.LbError.ForeColor = System.Drawing.Color.Red;
            this.LbError.Location = new System.Drawing.Point(284, 82);
            this.LbError.Name = "LbError";
            this.LbError.Size = new System.Drawing.Size(0, 16);
            this.LbError.TabIndex = 14;
            this.LbError.UseCompatibleTextRendering = true;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(760, 90);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 13;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // TbPorcentaje
            // 
            this.TbPorcentaje.Location = new System.Drawing.Point(425, 55);
            this.TbPorcentaje.Name = "TbPorcentaje";
            this.TbPorcentaje.Size = new System.Drawing.Size(87, 20);
            this.TbPorcentaje.TabIndex = 7;
            // 
            // TbPrecio
            // 
            this.TbPrecio.Location = new System.Drawing.Point(320, 55);
            this.TbPrecio.Name = "TbPrecio";
            this.TbPrecio.Size = new System.Drawing.Size(97, 20);
            this.TbPrecio.TabIndex = 5;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(760, 15);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 12;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LbPorcentaje
            // 
            this.LbPorcentaje.AutoSize = true;
            this.LbPorcentaje.Location = new System.Drawing.Point(422, 28);
            this.LbPorcentaje.Name = "LbPorcentaje";
            this.LbPorcentaje.Size = new System.Drawing.Size(58, 13);
            this.LbPorcentaje.TabIndex = 6;
            this.LbPorcentaje.Text = "Porcentaje";
            // 
            // LbPrecio
            // 
            this.LbPrecio.AutoSize = true;
            this.LbPrecio.Location = new System.Drawing.Point(317, 28);
            this.LbPrecio.Name = "LbPrecio";
            this.LbPrecio.Size = new System.Drawing.Size(37, 13);
            this.LbPrecio.TabIndex = 4;
            this.LbPrecio.Text = "Precio";
            // 
            // LbDescripcion
            // 
            this.LbDescripcion.AutoSize = true;
            this.LbDescripcion.Location = new System.Drawing.Point(110, 28);
            this.LbDescripcion.Name = "LbDescripcion";
            this.LbDescripcion.Size = new System.Drawing.Size(63, 13);
            this.LbDescripcion.TabIndex = 2;
            this.LbDescripcion.Text = "Descripción";
            // 
            // LbCodigo
            // 
            this.LbCodigo.AutoSize = true;
            this.LbCodigo.Location = new System.Drawing.Point(17, 28);
            this.LbCodigo.Name = "LbCodigo";
            this.LbCodigo.Size = new System.Drawing.Size(40, 13);
            this.LbCodigo.TabIndex = 0;
            this.LbCodigo.Text = "Código";
            // 
            // TbDesc
            // 
            this.TbDesc.Location = new System.Drawing.Point(113, 56);
            this.TbDesc.MaxLength = 255;
            this.TbDesc.Name = "TbDesc";
            this.TbDesc.Size = new System.Drawing.Size(201, 20);
            this.TbDesc.TabIndex = 3;
            // 
            // TbCodigo
            // 
            this.TbCodigo.Location = new System.Drawing.Point(20, 56);
            this.TbCodigo.Name = "TbCodigo";
            this.TbCodigo.ReadOnly = true;
            this.TbCodigo.Size = new System.Drawing.Size(87, 20);
            this.TbCodigo.TabIndex = 1;
            // 
            // Visibilidad_ABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 372);
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
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TbPorcentaje;
        private System.Windows.Forms.TextBox TbPrecio;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Label LbError;
        private System.Windows.Forms.ComboBox CbEstado;
        private System.Windows.Forms.Label LbEstado;
        private System.Windows.Forms.TextBox TbDuracion;
        private System.Windows.Forms.Label LbDuracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pub_Visible_Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pub_Visible_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pub_Visible_Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pub_Visible_Porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pub_Visible_Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pub_Visible_Estado;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;

    }
}