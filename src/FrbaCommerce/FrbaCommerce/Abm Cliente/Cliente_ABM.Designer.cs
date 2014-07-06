namespace FrbaCommerce.Abm_Cliente
{
    partial class Cliente_ABM
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
            this.textBoxDocumento = new System.Windows.Forms.TextBox();
            this.labelDocumento = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.labelTipoDocumento = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.groupBoxClientes = new System.Windows.Forms.GroupBox();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxFiltros.SuspendLayout();
            this.groupBoxClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.Controls.Add(this.textBoxDocumento);
            this.groupBoxFiltros.Controls.Add(this.labelDocumento);
            this.groupBoxFiltros.Controls.Add(this.textBoxMail);
            this.groupBoxFiltros.Controls.Add(this.label1);
            this.groupBoxFiltros.Controls.Add(this.comboBoxTipoDocumento);
            this.groupBoxFiltros.Controls.Add(this.labelTipoDocumento);
            this.groupBoxFiltros.Controls.Add(this.textBoxApellido);
            this.groupBoxFiltros.Controls.Add(this.labelApellido);
            this.groupBoxFiltros.Controls.Add(this.textBoxNombre);
            this.groupBoxFiltros.Controls.Add(this.labelNombre);
            this.groupBoxFiltros.Location = new System.Drawing.Point(11, 11);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(502, 123);
            this.groupBoxFiltros.TabIndex = 0;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "Filtros";
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.Location = new System.Drawing.Point(375, 51);
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(101, 20);
            this.textBoxDocumento.TabIndex = 9;
            // 
            // labelDocumento
            // 
            this.labelDocumento.AutoSize = true;
            this.labelDocumento.Location = new System.Drawing.Point(263, 54);
            this.labelDocumento.Name = "labelDocumento";
            this.labelDocumento.Size = new System.Drawing.Size(104, 13);
            this.labelDocumento.TabIndex = 8;
            this.labelDocumento.Text = "Documento (Exacto)";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(128, 83);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(101, 20);
            this.textBoxMail.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mail (Contiene)";
            // 
            // comboBoxTipoDocumento
            // 
            this.comboBoxTipoDocumento.FormattingEnabled = true;
            this.comboBoxTipoDocumento.Location = new System.Drawing.Point(375, 18);
            this.comboBoxTipoDocumento.Name = "comboBoxTipoDocumento";
            this.comboBoxTipoDocumento.Size = new System.Drawing.Size(102, 21);
            this.comboBoxTipoDocumento.TabIndex = 5;
            // 
            // labelTipoDocumento
            // 
            this.labelTipoDocumento.AutoSize = true;
            this.labelTipoDocumento.Location = new System.Drawing.Point(263, 21);
            this.labelTipoDocumento.Name = "labelTipoDocumento";
            this.labelTipoDocumento.Size = new System.Drawing.Size(86, 13);
            this.labelTipoDocumento.TabIndex = 4;
            this.labelTipoDocumento.Text = "Tipo Documento";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(128, 51);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(101, 20);
            this.textBoxApellido.TabIndex = 3;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(14, 56);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(95, 13);
            this.labelApellido.TabIndex = 2;
            this.labelApellido.Text = "Apellido (Contiene)";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(129, 21);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(14, 24);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(86, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre (Exacto)";
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Location = new System.Drawing.Point(28, 140);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(76, 22);
            this.buttonNuevo.TabIndex = 1;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(119, 140);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 22);
            this.buttonLimpiar.TabIndex = 2;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(212, 140);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 22);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // groupBoxClientes
            // 
            this.groupBoxClientes.Controls.Add(this.dataGridViewClientes);
            this.groupBoxClientes.Location = new System.Drawing.Point(12, 178);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Size = new System.Drawing.Size(500, 252);
            this.groupBoxClientes.TabIndex = 4;
            this.groupBoxClientes.TabStop = false;
            this.groupBoxClientes.Text = "Clientes";
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AllowUserToDeleteRows = false;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellido,
            this.Tipo_Doc,
            this.Nro_Doc,
            this.Cuil,
            this.Fecha_Nac,
            this.Mail,
            this.Calle,
            this.Nro,
            this.Piso,
            this.Cod_Postal,
            this.Depto,
            this.Localidad,
            this.Telefono,
            this.Estado,
            this.Editar,
            this.Eliminar});
            this.dataGridViewClientes.Location = new System.Drawing.Point(14, 29);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.RowTemplate.Height = 24;
            this.dataGridViewClientes.Size = new System.Drawing.Size(470, 210);
            this.dataGridViewClientes.TabIndex = 0;
            this.dataGridViewClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientes_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Cli_Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Cli_Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Cli_Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Tipo_Doc
            // 
            this.Tipo_Doc.DataPropertyName = "Des_Corta";
            this.Tipo_Doc.HeaderText = "Tipo_Doc";
            this.Tipo_Doc.Name = "Tipo_Doc";
            this.Tipo_Doc.ReadOnly = true;
            // 
            // Nro_Doc
            // 
            this.Nro_Doc.DataPropertyName = "Cli_Doc";
            this.Nro_Doc.HeaderText = "Nro_Doc";
            this.Nro_Doc.Name = "Nro_Doc";
            this.Nro_Doc.ReadOnly = true;
            // 
            // Cuil
            // 
            this.Cuil.DataPropertyName = "Cli_Cuil";
            this.Cuil.HeaderText = "Cuil";
            this.Cuil.Name = "Cuil";
            this.Cuil.ReadOnly = true;
            // 
            // Fecha_Nac
            // 
            this.Fecha_Nac.DataPropertyName = "Cli_Fecha_Nac";
            this.Fecha_Nac.HeaderText = "Fecha_Nac";
            this.Fecha_Nac.Name = "Fecha_Nac";
            this.Fecha_Nac.ReadOnly = true;
            // 
            // Mail
            // 
            this.Mail.DataPropertyName = "Cli_Mail";
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            // 
            // Calle
            // 
            this.Calle.DataPropertyName = "Cli_Dir_Calle";
            this.Calle.HeaderText = "Calle";
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            // 
            // Nro
            // 
            this.Nro.DataPropertyName = "Cli_Dir_Nro";
            this.Nro.HeaderText = "Nro";
            this.Nro.Name = "Nro";
            this.Nro.ReadOnly = true;
            // 
            // Piso
            // 
            this.Piso.DataPropertyName = "Cli_Dir_Piso";
            this.Piso.HeaderText = "Piso";
            this.Piso.Name = "Piso";
            this.Piso.ReadOnly = true;
            // 
            // Cod_Postal
            // 
            this.Cod_Postal.DataPropertyName = "Cli_Dir_CodPostal";
            this.Cod_Postal.HeaderText = "Cod_Postal";
            this.Cod_Postal.Name = "Cod_Postal";
            this.Cod_Postal.ReadOnly = true;
            // 
            // Depto
            // 
            this.Depto.DataPropertyName = "Cli_Dir_Depto";
            this.Depto.HeaderText = "Depto";
            this.Depto.Name = "Depto";
            this.Depto.ReadOnly = true;
            // 
            // Localidad
            // 
            this.Localidad.DataPropertyName = "Cli_Dir_Localidad";
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.Name = "Localidad";
            this.Localidad.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Cli_Telefono";
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
            // Cliente_ABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 451);
            this.Controls.Add(this.groupBoxClientes);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.groupBoxFiltros);
            this.Name = "Cliente_ABM";
            this.Text = "Cliente_ABM";
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
            this.groupBoxClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFiltros;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.ComboBox comboBoxTipoDocumento;
        private System.Windows.Forms.Label labelTipoDocumento;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.GroupBox groupBoxClientes;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.TextBox textBoxDocumento;
        private System.Windows.Forms.Label labelDocumento;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Nac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}