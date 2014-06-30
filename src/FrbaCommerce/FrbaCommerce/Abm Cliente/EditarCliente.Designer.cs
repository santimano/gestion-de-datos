namespace FrbaCommerce.Abm_Cliente
{
    partial class EditarCliente
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
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonFecha = new System.Windows.Forms.Button();
            this.monthCalendarFechaNacimiento = new System.Windows.Forms.MonthCalendar();
            this.buttonFechaNacimiento = new System.Windows.Forms.Button();
            this.textBoxFechaNacimiento = new System.Windows.Forms.TextBox();
            this.labelFechaNacimiento = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.textBoxDocumento = new System.Windows.Forms.TextBox();
            this.labelDocumento = new System.Windows.Forms.Label();
            this.labelTipoDocumento = new System.Windows.Forms.Label();
            this.comboBoxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.groupBoxDireccion = new System.Windows.Forms.GroupBox();
            this.textBoxDepto = new System.Windows.Forms.TextBox();
            this.labelDepto = new System.Windows.Forms.Label();
            this.textBoxLocalidad = new System.Windows.Forms.TextBox();
            this.labelLocalidad = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxCodPostal = new System.Windows.Forms.TextBox();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelCodPostal = new System.Windows.Forms.Label();
            this.textBoxPiso = new System.Windows.Forms.TextBox();
            this.labelPiso = new System.Windows.Forms.Label();
            this.textBoxCalle = new System.Windows.Forms.TextBox();
            this.labelCalle = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelEstado = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxDireccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFecha);
            this.groupBox1.Controls.Add(this.monthCalendarFechaNacimiento);
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.buttonFechaNacimiento);
            this.groupBox1.Controls.Add(this.textBoxFechaNacimiento);
            this.groupBox1.Controls.Add(this.labelFechaNacimiento);
            this.groupBox1.Controls.Add(this.textBoxTelefono);
            this.groupBox1.Controls.Add(this.labelTelefono);
            this.groupBox1.Controls.Add(this.textBoxMail);
            this.groupBox1.Controls.Add(this.labelMail);
            this.groupBox1.Controls.Add(this.textBoxDocumento);
            this.groupBox1.Controls.Add(this.labelDocumento);
            this.groupBox1.Controls.Add(this.labelTipoDocumento);
            this.groupBox1.Controls.Add(this.comboBoxTipoDocumento);
            this.groupBox1.Controls.Add(this.textBoxApellido);
            this.groupBox1.Controls.Add(this.labelApellido);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Controls.Add(this.comboBoxEstado);
            this.groupBox1.Controls.Add(this.labelEstado);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(354, 119);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(93, 20);
            this.textBoxID.TabIndex = 17;
            // 
            // buttonFecha
            // 
            this.buttonFecha.Location = new System.Drawing.Point(105, 165);
            this.buttonFecha.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFecha.Name = "buttonFecha";
            this.buttonFecha.Size = new System.Drawing.Size(199, 28);
            this.buttonFecha.TabIndex = 16;
            this.buttonFecha.Text = "Aceptar";
            this.buttonFecha.UseVisualStyleBackColor = true;
            this.buttonFecha.Visible = false;
            this.buttonFecha.Click += new System.EventHandler(this.buttonFecha_Click);
            // 
            // monthCalendarFechaNacimiento
            // 
            this.monthCalendarFechaNacimiento.Location = new System.Drawing.Point(105, 5);
            this.monthCalendarFechaNacimiento.MaxSelectionCount = 1;
            this.monthCalendarFechaNacimiento.Name = "monthCalendarFechaNacimiento";
            this.monthCalendarFechaNacimiento.TabIndex = 13;
            this.monthCalendarFechaNacimiento.Visible = false;
            // 
            // buttonFechaNacimiento
            // 
            this.buttonFechaNacimiento.Location = new System.Drawing.Point(131, 156);
            this.buttonFechaNacimiento.Name = "buttonFechaNacimiento";
            this.buttonFechaNacimiento.Size = new System.Drawing.Size(89, 22);
            this.buttonFechaNacimiento.TabIndex = 15;
            this.buttonFechaNacimiento.Text = "Seleccionar";
            this.buttonFechaNacimiento.UseVisualStyleBackColor = true;
            this.buttonFechaNacimiento.Click += new System.EventHandler(this.buttonFechaNacimiento_Click);
            // 
            // textBoxFechaNacimiento
            // 
            this.textBoxFechaNacimiento.Location = new System.Drawing.Point(128, 122);
            this.textBoxFechaNacimiento.Name = "textBoxFechaNacimiento";
            this.textBoxFechaNacimiento.ReadOnly = true;
            this.textBoxFechaNacimiento.Size = new System.Drawing.Size(92, 20);
            this.textBoxFechaNacimiento.TabIndex = 14;
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Location = new System.Drawing.Point(14, 126);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(108, 13);
            this.labelFechaNacimiento.TabIndex = 12;
            this.labelFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(355, 86);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(92, 20);
            this.textBoxTelefono.TabIndex = 11;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(242, 89);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(49, 13);
            this.labelTelefono.TabIndex = 10;
            this.labelTelefono.Text = "Telefono";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(128, 86);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(93, 20);
            this.textBoxMail.TabIndex = 9;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(16, 89);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(26, 13);
            this.labelMail.TabIndex = 8;
            this.labelMail.Text = "Mail";
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.Location = new System.Drawing.Point(355, 58);
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(92, 20);
            this.textBoxDocumento.TabIndex = 7;
            // 
            // labelDocumento
            // 
            this.labelDocumento.AutoSize = true;
            this.labelDocumento.Location = new System.Drawing.Point(242, 61);
            this.labelDocumento.Name = "labelDocumento";
            this.labelDocumento.Size = new System.Drawing.Size(62, 13);
            this.labelDocumento.TabIndex = 6;
            this.labelDocumento.Text = "Documento";
            // 
            // labelTipoDocumento
            // 
            this.labelTipoDocumento.AutoSize = true;
            this.labelTipoDocumento.Location = new System.Drawing.Point(16, 61);
            this.labelTipoDocumento.Name = "labelTipoDocumento";
            this.labelTipoDocumento.Size = new System.Drawing.Size(86, 13);
            this.labelTipoDocumento.TabIndex = 5;
            this.labelTipoDocumento.Text = "Tipo Documento";
            // 
            // comboBoxTipoDocumento
            // 
            this.comboBoxTipoDocumento.FormattingEnabled = true;
            this.comboBoxTipoDocumento.Location = new System.Drawing.Point(128, 58);
            this.comboBoxTipoDocumento.Name = "comboBoxTipoDocumento";
            this.comboBoxTipoDocumento.Size = new System.Drawing.Size(92, 21);
            this.comboBoxTipoDocumento.TabIndex = 4;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(355, 27);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(92, 20);
            this.textBoxApellido.TabIndex = 3;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(242, 30);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 2;
            this.labelApellido.Text = "Apellido";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(128, 27);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(93, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(16, 30);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(243, 122);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 16;
            this.labelID.Text = "ID";
            // 
            // groupBoxDireccion
            // 
            this.groupBoxDireccion.Controls.Add(this.textBoxDepto);
            this.groupBoxDireccion.Controls.Add(this.labelDepto);
            this.groupBoxDireccion.Controls.Add(this.textBoxLocalidad);
            this.groupBoxDireccion.Controls.Add(this.labelLocalidad);
            this.groupBoxDireccion.Controls.Add(this.textBoxNumero);
            this.groupBoxDireccion.Controls.Add(this.textBoxCodPostal);
            this.groupBoxDireccion.Controls.Add(this.labelNumero);
            this.groupBoxDireccion.Controls.Add(this.labelCodPostal);
            this.groupBoxDireccion.Controls.Add(this.textBoxPiso);
            this.groupBoxDireccion.Controls.Add(this.labelPiso);
            this.groupBoxDireccion.Controls.Add(this.textBoxCalle);
            this.groupBoxDireccion.Controls.Add(this.labelCalle);
            this.groupBoxDireccion.Location = new System.Drawing.Point(15, 235);
            this.groupBoxDireccion.Name = "groupBoxDireccion";
            this.groupBoxDireccion.Size = new System.Drawing.Size(475, 117);
            this.groupBoxDireccion.TabIndex = 1;
            this.groupBoxDireccion.TabStop = false;
            this.groupBoxDireccion.Text = "Direccion";
            // 
            // textBoxDepto
            // 
            this.textBoxDepto.Location = new System.Drawing.Point(358, 46);
            this.textBoxDepto.Name = "textBoxDepto";
            this.textBoxDepto.Size = new System.Drawing.Size(93, 20);
            this.textBoxDepto.TabIndex = 13;
            // 
            // labelDepto
            // 
            this.labelDepto.AutoSize = true;
            this.labelDepto.Location = new System.Drawing.Point(246, 49);
            this.labelDepto.Name = "labelDepto";
            this.labelDepto.Size = new System.Drawing.Size(36, 13);
            this.labelDepto.TabIndex = 12;
            this.labelDepto.Text = "Depto";
            // 
            // textBoxLocalidad
            // 
            this.textBoxLocalidad.Location = new System.Drawing.Point(126, 74);
            this.textBoxLocalidad.Name = "textBoxLocalidad";
            this.textBoxLocalidad.Size = new System.Drawing.Size(93, 20);
            this.textBoxLocalidad.TabIndex = 15;
            // 
            // labelLocalidad
            // 
            this.labelLocalidad.AutoSize = true;
            this.labelLocalidad.Location = new System.Drawing.Point(15, 77);
            this.labelLocalidad.Name = "labelLocalidad";
            this.labelLocalidad.Size = new System.Drawing.Size(53, 13);
            this.labelLocalidad.TabIndex = 14;
            this.labelLocalidad.Text = "Localidad";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(358, 19);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(93, 20);
            this.textBoxNumero.TabIndex = 13;
            // 
            // textBoxCodPostal
            // 
            this.textBoxCodPostal.Location = new System.Drawing.Point(357, 74);
            this.textBoxCodPostal.Name = "textBoxCodPostal";
            this.textBoxCodPostal.Size = new System.Drawing.Size(93, 20);
            this.textBoxCodPostal.TabIndex = 13;
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(247, 22);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(44, 13);
            this.labelNumero.TabIndex = 12;
            this.labelNumero.Text = "Numero";
            // 
            // labelCodPostal
            // 
            this.labelCodPostal.AutoSize = true;
            this.labelCodPostal.Location = new System.Drawing.Point(245, 77);
            this.labelCodPostal.Name = "labelCodPostal";
            this.labelCodPostal.Size = new System.Drawing.Size(72, 13);
            this.labelCodPostal.TabIndex = 12;
            this.labelCodPostal.Text = "Codigo Postal";
            // 
            // textBoxPiso
            // 
            this.textBoxPiso.Location = new System.Drawing.Point(127, 46);
            this.textBoxPiso.Name = "textBoxPiso";
            this.textBoxPiso.Size = new System.Drawing.Size(93, 20);
            this.textBoxPiso.TabIndex = 7;
            // 
            // labelPiso
            // 
            this.labelPiso.AutoSize = true;
            this.labelPiso.Location = new System.Drawing.Point(15, 49);
            this.labelPiso.Name = "labelPiso";
            this.labelPiso.Size = new System.Drawing.Size(27, 13);
            this.labelPiso.TabIndex = 6;
            this.labelPiso.Text = "Piso";
            // 
            // textBoxCalle
            // 
            this.textBoxCalle.Location = new System.Drawing.Point(127, 19);
            this.textBoxCalle.Name = "textBoxCalle";
            this.textBoxCalle.Size = new System.Drawing.Size(93, 20);
            this.textBoxCalle.TabIndex = 3;
            // 
            // labelCalle
            // 
            this.labelCalle.AutoSize = true;
            this.labelCalle.Location = new System.Drawing.Point(15, 22);
            this.labelCalle.Name = "labelCalle";
            this.labelCalle.Size = new System.Drawing.Size(30, 13);
            this.labelCalle.TabIndex = 2;
            this.labelCalle.Text = "Calle";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(129, 373);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(92, 24);
            this.buttonAceptar.TabIndex = 2;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(253, 373);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(92, 24);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(242, 155);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(40, 13);
            this.labelEstado.TabIndex = 16;
            this.labelEstado.Text = "Estado";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.comboBoxEstado.Location = new System.Drawing.Point(354, 152);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(92, 21);
            this.comboBoxEstado.TabIndex = 18;
            // 
            // EditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 409);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.groupBoxDireccion);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditarCliente";
            this.Text = "EditarCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxDireccion.ResumeLayout(false);
            this.groupBoxDireccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTipoDocumento;
        private System.Windows.Forms.ComboBox comboBoxTipoDocumento;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxDocumento;
        private System.Windows.Forms.Label labelDocumento;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.MonthCalendar monthCalendarFechaNacimiento;
        private System.Windows.Forms.Button buttonFechaNacimiento;
        private System.Windows.Forms.TextBox textBoxFechaNacimiento;
        private System.Windows.Forms.GroupBox groupBoxDireccion;
        private System.Windows.Forms.TextBox textBoxCodPostal;
        private System.Windows.Forms.Label labelCodPostal;
        private System.Windows.Forms.TextBox textBoxPiso;
        private System.Windows.Forms.Label labelPiso;
        private System.Windows.Forms.TextBox textBoxCalle;
        private System.Windows.Forms.Label labelCalle;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.TextBox textBoxDepto;
        private System.Windows.Forms.Label labelDepto;
        private System.Windows.Forms.TextBox textBoxLocalidad;
        private System.Windows.Forms.Label labelLocalidad;
        private System.Windows.Forms.Button buttonFecha;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.ComboBox comboBoxEstado;
    }
}