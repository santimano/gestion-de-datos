namespace FrbaCommerce.Comprar_Ofertar
{
    partial class ComprarItem
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
            this.tbVencimiento = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOfertas = new System.Windows.Forms.GroupBox();
            this.lbOfertas = new System.Windows.Forms.ListBox();
            this.gbPreguntas = new System.Windows.Forms.GroupBox();
            this.btRespuestas = new System.Windows.Forms.Button();
            this.btPreguntar = new System.Windows.Forms.Button();
            this.tbPregunta = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbOferta = new System.Windows.Forms.TextBox();
            this.btComprar = new System.Windows.Forms.Button();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbOfertas.SuspendLayout();
            this.gbPreguntas.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbVencimiento);
            this.groupBox1.Controls.Add(this.tbStock);
            this.groupBox1.Controls.Add(this.tbPrecio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbDescripcion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Publicacion";
            // 
            // tbVencimiento
            // 
            this.tbVencimiento.Enabled = false;
            this.tbVencimiento.Location = new System.Drawing.Point(85, 117);
            this.tbVencimiento.Name = "tbVencimiento";
            this.tbVencimiento.Size = new System.Drawing.Size(100, 20);
            this.tbVencimiento.TabIndex = 7;
            // 
            // tbStock
            // 
            this.tbStock.Enabled = false;
            this.tbStock.Location = new System.Drawing.Point(85, 85);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(100, 20);
            this.tbStock.TabIndex = 6;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Enabled = false;
            this.tbPrecio.Location = new System.Drawing.Point(85, 59);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbPrecio.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vencimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stock";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Enabled = false;
            this.tbDescripcion.Location = new System.Drawing.Point(85, 26);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(164, 20);
            this.tbDescripcion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            // 
            // gbOfertas
            // 
            this.gbOfertas.Controls.Add(this.lbOfertas);
            this.gbOfertas.Location = new System.Drawing.Point(274, 13);
            this.gbOfertas.Name = "gbOfertas";
            this.gbOfertas.Size = new System.Drawing.Size(250, 161);
            this.gbOfertas.TabIndex = 1;
            this.gbOfertas.TabStop = false;
            this.gbOfertas.Text = "Ofertas";
            this.gbOfertas.Visible = false;
            // 
            // lbOfertas
            // 
            this.lbOfertas.FormattingEnabled = true;
            this.lbOfertas.Location = new System.Drawing.Point(7, 20);
            this.lbOfertas.Name = "lbOfertas";
            this.lbOfertas.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbOfertas.Size = new System.Drawing.Size(237, 134);
            this.lbOfertas.TabIndex = 0;
            // 
            // gbPreguntas
            // 
            this.gbPreguntas.Controls.Add(this.btRespuestas);
            this.gbPreguntas.Controls.Add(this.btPreguntar);
            this.gbPreguntas.Controls.Add(this.tbPregunta);
            this.gbPreguntas.Location = new System.Drawing.Point(13, 180);
            this.gbPreguntas.Name = "gbPreguntas";
            this.gbPreguntas.Size = new System.Drawing.Size(511, 124);
            this.gbPreguntas.TabIndex = 2;
            this.gbPreguntas.TabStop = false;
            this.gbPreguntas.Text = "Preguntar";
            // 
            // btRespuestas
            // 
            this.btRespuestas.Location = new System.Drawing.Point(419, 59);
            this.btRespuestas.Name = "btRespuestas";
            this.btRespuestas.Size = new System.Drawing.Size(75, 34);
            this.btRespuestas.TabIndex = 2;
            this.btRespuestas.Text = "Ver Respuestas";
            this.btRespuestas.UseVisualStyleBackColor = true;
            this.btRespuestas.Click += new System.EventHandler(this.btRespuestas_Click);
            // 
            // btPreguntar
            // 
            this.btPreguntar.Location = new System.Drawing.Point(419, 20);
            this.btPreguntar.Name = "btPreguntar";
            this.btPreguntar.Size = new System.Drawing.Size(75, 23);
            this.btPreguntar.TabIndex = 1;
            this.btPreguntar.Text = "Preguntar";
            this.btPreguntar.UseVisualStyleBackColor = true;
            this.btPreguntar.Click += new System.EventHandler(this.btPreguntar_Click);
            // 
            // tbPregunta
            // 
            this.tbPregunta.Location = new System.Drawing.Point(7, 20);
            this.tbPregunta.Multiline = true;
            this.tbPregunta.Name = "tbPregunta";
            this.tbPregunta.Size = new System.Drawing.Size(396, 88);
            this.tbPregunta.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelCantidad);
            this.groupBox4.Controls.Add(this.numCantidad);
            this.groupBox4.Controls.Add(this.tbOferta);
            this.groupBox4.Controls.Add(this.btComprar);
            this.groupBox4.Location = new System.Drawing.Point(13, 310);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(511, 49);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Comprar";
            // 
            // tbOferta
            // 
            this.tbOferta.Location = new System.Drawing.Point(405, 19);
            this.tbOferta.Name = "tbOferta";
            this.tbOferta.Size = new System.Drawing.Size(100, 20);
            this.tbOferta.TabIndex = 1;
            this.tbOferta.Visible = false;
            // 
            // btComprar
            // 
            this.btComprar.Location = new System.Drawing.Point(310, 17);
            this.btComprar.Name = "btComprar";
            this.btComprar.Size = new System.Drawing.Size(75, 23);
            this.btComprar.TabIndex = 0;
            this.btComprar.Text = "Comprar";
            this.btComprar.UseVisualStyleBackColor = true;
            this.btComprar.Click += new System.EventHandler(this.btComprar_Click);
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(65, 20);
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 20);
            this.numCantidad.TabIndex = 2;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(191, 22);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(49, 13);
            this.labelCantidad.TabIndex = 3;
            this.labelCantidad.Text = "Cantidad";
            // 
            // ComprarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 371);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbPreguntas);
            this.Controls.Add(this.gbOfertas);
            this.Controls.Add(this.groupBox1);
            this.Name = "ComprarItem";
            this.Text = "Comprar Item";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbOfertas.ResumeLayout(false);
            this.gbPreguntas.ResumeLayout(false);
            this.gbPreguntas.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.TextBox tbVencimiento;
        private System.Windows.Forms.GroupBox gbOfertas;
        private System.Windows.Forms.ListBox lbOfertas;
        private System.Windows.Forms.GroupBox gbPreguntas;
        private System.Windows.Forms.TextBox tbPregunta;
        private System.Windows.Forms.Button btPreguntar;
        private System.Windows.Forms.Button btRespuestas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btComprar;
        private System.Windows.Forms.TextBox tbOferta;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.NumericUpDown numCantidad;
    }
}