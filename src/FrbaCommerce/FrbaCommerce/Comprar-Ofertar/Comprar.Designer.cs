namespace FrbaCommerce.Comprar_Ofertar
{
    partial class Comprar
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
            this.lbRubros = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btUltima = new System.Windows.Forms.Button();
            this.btAnterior = new System.Windows.Forms.Button();
            this.tbPaginas = new System.Windows.Forms.TextBox();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.btPrimera = new System.Windows.Forms.Button();
            this.Pub_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pub_User_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comprar_Item = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbRubros);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbDescripcion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // lbRubros
            // 
            this.lbRubros.FormattingEnabled = true;
            this.lbRubros.Location = new System.Drawing.Point(353, 19);
            this.lbRubros.Name = "lbRubros";
            this.lbRubros.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbRubros.Size = new System.Drawing.Size(227, 95);
            this.lbRubros.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rubros";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(87, 33);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(100, 20);
            this.tbDescripcion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(13, 158);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(13, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(753, 390);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Publicaciones";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pub_Codigo,
            this.Descripcion,
            this.Stock,
            this.Precio,
            this.Vencimiento,
            this.Pub_User_Id,
            this.Comprar_Item});
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(740, 364);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btUltima);
            this.groupBox3.Controls.Add(this.btAnterior);
            this.groupBox3.Controls.Add(this.tbPaginas);
            this.groupBox3.Controls.Add(this.btSiguiente);
            this.groupBox3.Controls.Add(this.btPrimera);
            this.groupBox3.Location = new System.Drawing.Point(172, 583);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 87);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Navegacion";
            // 
            // btUltima
            // 
            this.btUltima.Location = new System.Drawing.Point(340, 37);
            this.btUltima.Name = "btUltima";
            this.btUltima.Size = new System.Drawing.Size(75, 23);
            this.btUltima.TabIndex = 4;
            this.btUltima.Text = "Ultima";
            this.btUltima.UseVisualStyleBackColor = true;
            this.btUltima.Click += new System.EventHandler(this.btUltima_Click);
            // 
            // btAnterior
            // 
            this.btAnterior.Location = new System.Drawing.Point(100, 37);
            this.btAnterior.Name = "btAnterior";
            this.btAnterior.Size = new System.Drawing.Size(75, 23);
            this.btAnterior.TabIndex = 3;
            this.btAnterior.Text = "Anterior";
            this.btAnterior.UseVisualStyleBackColor = true;
            this.btAnterior.Click += new System.EventHandler(this.btAnterior_Click);
            // 
            // tbPaginas
            // 
            this.tbPaginas.Enabled = false;
            this.tbPaginas.Location = new System.Drawing.Point(181, 37);
            this.tbPaginas.Name = "tbPaginas";
            this.tbPaginas.Size = new System.Drawing.Size(52, 20);
            this.tbPaginas.TabIndex = 2;
            // 
            // btSiguiente
            // 
            this.btSiguiente.Location = new System.Drawing.Point(239, 37);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btSiguiente.TabIndex = 1;
            this.btSiguiente.Text = "Siguiente";
            this.btSiguiente.UseVisualStyleBackColor = true;
            this.btSiguiente.Click += new System.EventHandler(this.btSiguiente_Click);
            // 
            // btPrimera
            // 
            this.btPrimera.Location = new System.Drawing.Point(6, 37);
            this.btPrimera.Name = "btPrimera";
            this.btPrimera.Size = new System.Drawing.Size(75, 23);
            this.btPrimera.TabIndex = 0;
            this.btPrimera.Text = "Primera";
            this.btPrimera.UseVisualStyleBackColor = true;
            this.btPrimera.Click += new System.EventHandler(this.btPrimera_Click);
            // 
            // Pub_Codigo
            // 
            this.Pub_Codigo.DataPropertyName = "Pub_Codigo";
            this.Pub_Codigo.HeaderText = "Pub_Codigo";
            this.Pub_Codigo.Name = "Pub_Codigo";
            this.Pub_Codigo.ReadOnly = true;
            this.Pub_Codigo.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Pub_Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Pub_Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Pub_Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Vencimiento
            // 
            this.Vencimiento.DataPropertyName = "Pub_Fecha_Venc";
            this.Vencimiento.HeaderText = "Vencimiento";
            this.Vencimiento.Name = "Vencimiento";
            this.Vencimiento.ReadOnly = true;
            // 
            // Pub_User_Id
            // 
            this.Pub_User_Id.DataPropertyName = "Pub_User_Id";
            this.Pub_User_Id.HeaderText = "Pub_User_Id";
            this.Pub_User_Id.Name = "Pub_User_Id";
            this.Pub_User_Id.ReadOnly = true;
            this.Pub_User_Id.Visible = false;
            // 
            // Comprar_Item
            // 
            this.Comprar_Item.HeaderText = "Comprar_Item";
            this.Comprar_Item.Name = "Comprar_Item";
            this.Comprar_Item.ReadOnly = true;
            this.Comprar_Item.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Comprar_Item.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Comprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 682);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Comprar";
            this.Text = "Comprar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbRubros;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btPrimera;
        private System.Windows.Forms.TextBox tbPaginas;
        private System.Windows.Forms.Button btSiguiente;
        private System.Windows.Forms.Button btAnterior;
        private System.Windows.Forms.Button btUltima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pub_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pub_User_Id;
        private System.Windows.Forms.DataGridViewButtonColumn Comprar_Item;
    }
}