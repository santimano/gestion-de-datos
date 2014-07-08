namespace FrbaCommerce.Listado_Estadistico
{
    partial class ListadoEstadistico
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
            this.comboBoxAnio = new System.Windows.Forms.ComboBox();
            this.labelAnio = new System.Windows.Forms.Label();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.comboBoxReporte = new System.Windows.Forms.ComboBox();
            this.labelReporte = new System.Windows.Forms.Label();
            this.comboBoxTrimestre = new System.Windows.Forms.ComboBox();
            this.labelTrimestre = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.groupBoxResultados = new System.Windows.Forms.GroupBox();
            this.dataGridViewResultados = new System.Windows.Forms.DataGridView();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxVisibilidad = new System.Windows.Forms.ComboBox();
            this.groupBoxDatos.SuspendLayout();
            this.groupBoxResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxAnio
            // 
            this.comboBoxAnio.FormattingEnabled = true;
            this.comboBoxAnio.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019"});
            this.comboBoxAnio.Location = new System.Drawing.Point(90, 23);
            this.comboBoxAnio.Name = "comboBoxAnio";
            this.comboBoxAnio.Size = new System.Drawing.Size(380, 21);
            this.comboBoxAnio.TabIndex = 0;
            // 
            // labelAnio
            // 
            this.labelAnio.AutoSize = true;
            this.labelAnio.Location = new System.Drawing.Point(13, 26);
            this.labelAnio.Name = "labelAnio";
            this.labelAnio.Size = new System.Drawing.Size(26, 13);
            this.labelAnio.TabIndex = 1;
            this.labelAnio.Text = "Año";
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.comboBoxReporte);
            this.groupBoxDatos.Controls.Add(this.labelReporte);
            this.groupBoxDatos.Controls.Add(this.comboBoxTrimestre);
            this.groupBoxDatos.Controls.Add(this.labelTrimestre);
            this.groupBoxDatos.Controls.Add(this.labelAnio);
            this.groupBoxDatos.Controls.Add(this.comboBoxAnio);
            this.groupBoxDatos.Location = new System.Drawing.Point(18, 12);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(500, 133);
            this.groupBoxDatos.TabIndex = 2;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos";
            // 
            // comboBoxReporte
            // 
            this.comboBoxReporte.FormattingEnabled = true;
            this.comboBoxReporte.Items.AddRange(new object[] {
            "Vendedores con mayor cantidad de productos no vendidos",
            "Vendedores con mayor facturacion",
            "Vendedores con mayores calificaciones",
            "Clientes con mayor cantidad de publicaciones sin calificar"});
            this.comboBoxReporte.Location = new System.Drawing.Point(90, 90);
            this.comboBoxReporte.Name = "comboBoxReporte";
            this.comboBoxReporte.Size = new System.Drawing.Size(380, 21);
            this.comboBoxReporte.TabIndex = 5;
            this.comboBoxReporte.SelectedIndexChanged += new System.EventHandler(this.comboBoxReporte_SelectedIndexChanged);
            // 
            // labelReporte
            // 
            this.labelReporte.AutoSize = true;
            this.labelReporte.Location = new System.Drawing.Point(13, 93);
            this.labelReporte.Name = "labelReporte";
            this.labelReporte.Size = new System.Drawing.Size(45, 13);
            this.labelReporte.TabIndex = 4;
            this.labelReporte.Text = "Reporte";
            // 
            // comboBoxTrimestre
            // 
            this.comboBoxTrimestre.FormattingEnabled = true;
            this.comboBoxTrimestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxTrimestre.Location = new System.Drawing.Point(90, 56);
            this.comboBoxTrimestre.Name = "comboBoxTrimestre";
            this.comboBoxTrimestre.Size = new System.Drawing.Size(380, 21);
            this.comboBoxTrimestre.TabIndex = 3;
            // 
            // labelTrimestre
            // 
            this.labelTrimestre.AutoSize = true;
            this.labelTrimestre.Location = new System.Drawing.Point(13, 59);
            this.labelTrimestre.Name = "labelTrimestre";
            this.labelTrimestre.Size = new System.Drawing.Size(50, 13);
            this.labelTrimestre.TabIndex = 2;
            this.labelTrimestre.Text = "Trimestre";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(34, 161);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(91, 22);
            this.buttonBuscar.TabIndex = 7;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(131, 161);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(91, 22);
            this.buttonLimpiar.TabIndex = 8;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // groupBoxResultados
            // 
            this.groupBoxResultados.Controls.Add(this.dataGridViewResultados);
            this.groupBoxResultados.Location = new System.Drawing.Point(18, 201);
            this.groupBoxResultados.Name = "groupBoxResultados";
            this.groupBoxResultados.Size = new System.Drawing.Size(499, 238);
            this.groupBoxResultados.TabIndex = 9;
            this.groupBoxResultados.TabStop = false;
            this.groupBoxResultados.Text = "Resultados";
            this.groupBoxResultados.Visible = false;
            // 
            // dataGridViewResultados
            // 
            this.dataGridViewResultados.AllowUserToAddRows = false;
            this.dataGridViewResultados.AllowUserToDeleteRows = false;
            this.dataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultados.Location = new System.Drawing.Point(13, 27);
            this.dataGridViewResultados.Name = "dataGridViewResultados";
            this.dataGridViewResultados.ReadOnly = true;
            this.dataGridViewResultados.Size = new System.Drawing.Size(472, 195);
            this.dataGridViewResultados.TabIndex = 0;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.comboBoxVisibilidad);
            this.gbFiltros.Controls.Add(this.label2);
            this.gbFiltros.Controls.Add(this.tbMes);
            this.gbFiltros.Controls.Add(this.label1);
            this.gbFiltros.Location = new System.Drawing.Point(228, 151);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(290, 44);
            this.gbFiltros.TabIndex = 10;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            this.gbFiltros.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mes";
            // 
            // tbMes
            // 
            this.tbMes.Location = new System.Drawing.Point(40, 17);
            this.tbMes.MaxLength = 2;
            this.tbMes.Name = "tbMes";
            this.tbMes.Size = new System.Drawing.Size(22, 20);
            this.tbMes.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Visibilidad";
            // 
            // comboBoxVisibilidad
            // 
            this.comboBoxVisibilidad.FormattingEnabled = true;
            this.comboBoxVisibilidad.Location = new System.Drawing.Point(127, 17);
            this.comboBoxVisibilidad.Name = "comboBoxVisibilidad";
            this.comboBoxVisibilidad.Size = new System.Drawing.Size(157, 21);
            this.comboBoxVisibilidad.TabIndex = 3;
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 464);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.groupBoxResultados);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.groupBoxDatos);
            this.Name = "ListadoEstadistico";
            this.Text = "ListadoEstadistico";
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.groupBoxResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAnio;
        private System.Windows.Forms.Label labelAnio;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.ComboBox comboBoxTrimestre;
        private System.Windows.Forms.Label labelTrimestre;
        private System.Windows.Forms.Label labelReporte;
        private System.Windows.Forms.ComboBox comboBoxReporte;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.GroupBox groupBoxResultados;
        private System.Windows.Forms.DataGridView dataGridViewResultados;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxVisibilidad;
    }
}