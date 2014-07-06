namespace FrbaCommerce.Facturar_Publicaciones
{
    partial class Facturar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Publicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pub_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFormaPago = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDatosTarjeta = new System.Windows.Forms.GroupBox();
            this.tbTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.tbVencimiento = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTitular = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPubAFact = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTotalAFact = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbDatosTarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Publicaciones";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Publicacion,
            this.Fecha,
            this.Vendidos,
            this.Unitario,
            this.Total,
            this.Pub_Codigo});
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(732, 269);
            this.dataGridView1.TabIndex = 0;
            // 
            // Publicacion
            // 
            this.Publicacion.DataPropertyName = "Publicacion";
            this.Publicacion.HeaderText = "Publicacion";
            this.Publicacion.Name = "Publicacion";
            this.Publicacion.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha_Finalizacion";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Vendidos
            // 
            this.Vendidos.DataPropertyName = "Vendidos";
            this.Vendidos.HeaderText = "Vendidos";
            this.Vendidos.Name = "Vendidos";
            this.Vendidos.ReadOnly = true;
            // 
            // Unitario
            // 
            this.Unitario.DataPropertyName = "Unitario";
            this.Unitario.HeaderText = "Unitario";
            this.Unitario.Name = "Unitario";
            this.Unitario.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Pub_Codigo
            // 
            this.Pub_Codigo.DataPropertyName = "Pub_Codigo";
            this.Pub_Codigo.HeaderText = "Pub_Codigo";
            this.Pub_Codigo.Name = "Pub_Codigo";
            this.Pub_Codigo.ReadOnly = true;
            this.Pub_Codigo.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Facturar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Forma de Pago";
            // 
            // cbFormaPago
            // 
            this.cbFormaPago.FormattingEnabled = true;
            this.cbFormaPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.cbFormaPago.Location = new System.Drawing.Point(160, 408);
            this.cbFormaPago.Name = "cbFormaPago";
            this.cbFormaPago.Size = new System.Drawing.Size(121, 21);
            this.cbFormaPago.TabIndex = 2;
            this.cbFormaPago.SelectedIndexChanged += new System.EventHandler(this.cbFormaPago_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Publicaciones a facturar";
            // 
            // gbDatosTarjeta
            // 
            this.gbDatosTarjeta.Controls.Add(this.tbTarjeta);
            this.gbDatosTarjeta.Controls.Add(this.tbVencimiento);
            this.gbDatosTarjeta.Controls.Add(this.label5);
            this.gbDatosTarjeta.Controls.Add(this.label4);
            this.gbDatosTarjeta.Controls.Add(this.tbTitular);
            this.gbDatosTarjeta.Controls.Add(this.label3);
            this.gbDatosTarjeta.Location = new System.Drawing.Point(420, 314);
            this.gbDatosTarjeta.Name = "gbDatosTarjeta";
            this.gbDatosTarjeta.Size = new System.Drawing.Size(338, 144);
            this.gbDatosTarjeta.TabIndex = 6;
            this.gbDatosTarjeta.TabStop = false;
            this.gbDatosTarjeta.Text = "Datos Tarjeta";
            this.gbDatosTarjeta.Visible = false;
            // 
            // tbTarjeta
            // 
            this.tbTarjeta.Location = new System.Drawing.Point(90, 59);
            this.tbTarjeta.Mask = "9999 9999 9999 9999";
            this.tbTarjeta.Name = "tbTarjeta";
            this.tbTarjeta.Size = new System.Drawing.Size(118, 20);
            this.tbTarjeta.TabIndex = 4;
            // 
            // tbVencimiento
            // 
            this.tbVencimiento.Location = new System.Drawing.Point(90, 97);
            this.tbVencimiento.Mask = "00/0000";
            this.tbVencimiento.Name = "tbVencimiento";
            this.tbVencimiento.Size = new System.Drawing.Size(100, 20);
            this.tbVencimiento.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Vencimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Numero";
            // 
            // tbTitular
            // 
            this.tbTitular.Location = new System.Drawing.Point(90, 19);
            this.tbTitular.Name = "tbTitular";
            this.tbTitular.Size = new System.Drawing.Size(100, 20);
            this.tbTitular.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Titular";
            // 
            // tbPubAFact
            // 
            this.tbPubAFact.Location = new System.Drawing.Point(160, 333);
            this.tbPubAFact.Mask = "99999";
            this.tbPubAFact.Name = "tbPubAFact";
            this.tbPubAFact.Size = new System.Drawing.Size(100, 20);
            this.tbPubAFact.TabIndex = 0;
            this.tbPubAFact.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total a facturar";
            // 
            // tbTotalAFact
            // 
            this.tbTotalAFact.Enabled = false;
            this.tbTotalAFact.Location = new System.Drawing.Point(160, 370);
            this.tbTotalAFact.Name = "tbTotalAFact";
            this.tbTotalAFact.Size = new System.Drawing.Size(100, 20);
            this.tbTotalAFact.TabIndex = 1;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(318, 333);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(92, 22);
            this.btCalcular.TabIndex = 3;
            this.btCalcular.Text = "Calcular total";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // Facturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 519);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.tbTotalAFact);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPubAFact);
            this.Controls.Add(this.gbDatosTarjeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFormaPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Facturar";
            this.Text = "Facturar";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbDatosTarjeta.ResumeLayout(false);
            this.gbDatosTarjeta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFormaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pub_Codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbDatosTarjeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTitular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox tbVencimiento;
        private System.Windows.Forms.MaskedTextBox tbPubAFact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTotalAFact;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.MaskedTextBox tbTarjeta;
    }
}