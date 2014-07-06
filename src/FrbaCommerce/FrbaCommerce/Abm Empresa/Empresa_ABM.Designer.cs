namespace FrbaCommerce.Abm_Empresa
{
    partial class Empresa_ABM
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
            this.groupBoxFiltros = new System.Windows.Forms.GroupBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.textBoxCuit = new System.Windows.Forms.TextBox();
            this.labelCuit = new System.Windows.Forms.Label();
            this.textBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.labelRazonSocial = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.groupBoxEmpresas = new System.Windows.Forms.GroupBox();
            this.dataGridViewEmpresas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razon_Soc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxFiltros.SuspendLayout();
            this.groupBoxEmpresas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.Controls.Add(this.textBoxMail);
            this.groupBoxFiltros.Controls.Add(this.labelMail);
            this.groupBoxFiltros.Controls.Add(this.textBoxCuit);
            this.groupBoxFiltros.Controls.Add(this.labelCuit);
            this.groupBoxFiltros.Controls.Add(this.textBoxRazonSocial);
            this.groupBoxFiltros.Controls.Add(this.labelRazonSocial);
            this.groupBoxFiltros.Location = new System.Drawing.Point(16, 17);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(485, 103);
            this.groupBoxFiltros.TabIndex = 0;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "Filtros";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(152, 70);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(101, 20);
            this.textBoxMail.TabIndex = 5;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(16, 73);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(77, 13);
            this.labelMail.TabIndex = 4;
            this.labelMail.Text = "Mail (Contiene)";
            // 
            // textBoxCuit
            // 
            this.textBoxCuit.Location = new System.Drawing.Point(152, 44);
            this.textBoxCuit.Name = "textBoxCuit";
            this.textBoxCuit.Size = new System.Drawing.Size(101, 20);
            this.textBoxCuit.TabIndex = 3;
            // 
            // labelCuit
            // 
            this.labelCuit.AutoSize = true;
            this.labelCuit.Location = new System.Drawing.Point(16, 47);
            this.labelCuit.Name = "labelCuit";
            this.labelCuit.Size = new System.Drawing.Size(74, 13);
            this.labelCuit.TabIndex = 2;
            this.labelCuit.Text = "CUIT (Exacto)";
            // 
            // textBoxRazonSocial
            // 
            this.textBoxRazonSocial.Location = new System.Drawing.Point(152, 18);
            this.textBoxRazonSocial.Name = "textBoxRazonSocial";
            this.textBoxRazonSocial.Size = new System.Drawing.Size(101, 20);
            this.textBoxRazonSocial.TabIndex = 1;
            // 
            // labelRazonSocial
            // 
            this.labelRazonSocial.AutoSize = true;
            this.labelRazonSocial.Location = new System.Drawing.Point(16, 21);
            this.labelRazonSocial.Name = "labelRazonSocial";
            this.labelRazonSocial.Size = new System.Drawing.Size(121, 13);
            this.labelRazonSocial.TabIndex = 0;
            this.labelRazonSocial.Text = "Razon Social (Contiene)";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(214, 126);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 22);
            this.buttonBuscar.TabIndex = 6;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(121, 126);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 22);
            this.buttonLimpiar.TabIndex = 5;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Location = new System.Drawing.Point(30, 126);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(76, 22);
            this.buttonNuevo.TabIndex = 4;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            // 
            // groupBoxEmpresas
            // 
            this.groupBoxEmpresas.Controls.Add(this.dataGridViewEmpresas);
            this.groupBoxEmpresas.Location = new System.Drawing.Point(16, 164);
            this.groupBoxEmpresas.Name = "groupBoxEmpresas";
            this.groupBoxEmpresas.Size = new System.Drawing.Size(484, 273);
            this.groupBoxEmpresas.TabIndex = 7;
            this.groupBoxEmpresas.TabStop = false;
            this.groupBoxEmpresas.Text = "Empresas";
            // 
            // dataGridViewEmpresas
            // 
            this.dataGridViewEmpresas.AllowUserToAddRows = false;
            this.dataGridViewEmpresas.AllowUserToDeleteRows = false;
            this.dataGridViewEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Cuit,
            this.Razon_Soc,
            this.Fecha_Creacion,
            this.Contacto,
            this.Mail,
            this.Calle,
            this.Nro,
            this.Piso,
            this.Cod_Postal,
            this.Depto,
            this.Localidad,
            this.Ciudad,
            this.Telefono,
            this.Estado,
            this.Editar,
            this.Eliminar});
            this.dataGridViewEmpresas.Location = new System.Drawing.Point(14, 26);
            this.dataGridViewEmpresas.Name = "dataGridViewEmpresas";
            this.dataGridViewEmpresas.ReadOnly = true;
            this.dataGridViewEmpresas.Size = new System.Drawing.Size(458, 241);
            this.dataGridViewEmpresas.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Emp_Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Cuit
            // 
            this.Cuit.DataPropertyName = "Emp_Cuit";
            this.Cuit.HeaderText = "Cuit";
            this.Cuit.Name = "Cuit";
            this.Cuit.ReadOnly = true;
            // 
            // Razon_Soc
            // 
            this.Razon_Soc.DataPropertyName = "Emp_RazonSocial";
            this.Razon_Soc.HeaderText = "Razon_Soc";
            this.Razon_Soc.Name = "Razon_Soc";
            this.Razon_Soc.ReadOnly = true;
            // 
            // Fecha_Creacion
            // 
            this.Fecha_Creacion.DataPropertyName = "Emp_Fecha_Creacion";
            this.Fecha_Creacion.HeaderText = "Fecha_Creacion";
            this.Fecha_Creacion.Name = "Fecha_Creacion";
            this.Fecha_Creacion.ReadOnly = true;
            // 
            // Contacto
            // 
            this.Contacto.DataPropertyName = "Emp_Contacto";
            this.Contacto.HeaderText = "Contacto";
            this.Contacto.Name = "Contacto";
            this.Contacto.ReadOnly = true;
            // 
            // Mail
            // 
            this.Mail.DataPropertyName = "Emp_Mail";
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            // 
            // Calle
            // 
            this.Calle.DataPropertyName = "Emp_Dir_Calle";
            this.Calle.HeaderText = "Calle";
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            // 
            // Nro
            // 
            this.Nro.DataPropertyName = "Emp_Dir_Nro";
            this.Nro.HeaderText = "Nro";
            this.Nro.Name = "Nro";
            this.Nro.ReadOnly = true;
            // 
            // Piso
            // 
            this.Piso.DataPropertyName = "Emp_Dir_Piso";
            this.Piso.HeaderText = "Piso";
            this.Piso.Name = "Piso";
            this.Piso.ReadOnly = true;
            // 
            // Cod_Postal
            // 
            this.Cod_Postal.DataPropertyName = "Emp_Dir_CodPostal";
            this.Cod_Postal.HeaderText = "Cod_Postal";
            this.Cod_Postal.Name = "Cod_Postal";
            this.Cod_Postal.ReadOnly = true;
            // 
            // Depto
            // 
            this.Depto.DataPropertyName = "Emp_Dir_Depto";
            this.Depto.HeaderText = "Depto";
            this.Depto.Name = "Depto";
            this.Depto.ReadOnly = true;
            // 
            // Localidad
            // 
            this.Localidad.DataPropertyName = "Emp_Dir_Localidad";
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.Name = "Localidad";
            this.Localidad.ReadOnly = true;
            // 
            // Ciudad
            // 
            this.Ciudad.DataPropertyName = "Emp_Dir_Ciudad";
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Emp_Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "User_Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // Empresa_ABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 449);
            this.Controls.Add(this.groupBoxEmpresas);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.groupBoxFiltros);
            this.Name = "Empresa_ABM";
            this.Text = "Empresa_ABM";
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
            this.groupBoxEmpresas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpresas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFiltros;
        private System.Windows.Forms.Label labelRazonSocial;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox textBoxCuit;
        private System.Windows.Forms.Label labelCuit;
        private System.Windows.Forms.TextBox textBoxRazonSocial;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.GroupBox groupBoxEmpresas;
        private System.Windows.Forms.DataGridView dataGridViewEmpresas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razon_Soc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}