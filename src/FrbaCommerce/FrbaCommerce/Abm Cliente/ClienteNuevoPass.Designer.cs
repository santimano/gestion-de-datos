namespace FrbaCommerce.Abm_Cliente
{
    partial class ClienteNuevoPass
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textBoxConfirmaPassword = new System.Windows.Forms.TextBox();
            this.labelConfirmaPassword = new System.Windows.Forms.Label();
            this.textBoxNuevoPassword = new System.Windows.Forms.TextBox();
            this.labelNuevoPassword = new System.Windows.Forms.Label();
            this.checkBoxCambioPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(156, 111);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 21;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(63, 111);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 20;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // textBoxConfirmaPassword
            // 
            this.textBoxConfirmaPassword.Location = new System.Drawing.Point(156, 47);
            this.textBoxConfirmaPassword.Name = "textBoxConfirmaPassword";
            this.textBoxConfirmaPassword.PasswordChar = '*';
            this.textBoxConfirmaPassword.Size = new System.Drawing.Size(96, 20);
            this.textBoxConfirmaPassword.TabIndex = 19;
            // 
            // labelConfirmaPassword
            // 
            this.labelConfirmaPassword.AutoSize = true;
            this.labelConfirmaPassword.Location = new System.Drawing.Point(40, 50);
            this.labelConfirmaPassword.Name = "labelConfirmaPassword";
            this.labelConfirmaPassword.Size = new System.Drawing.Size(97, 13);
            this.labelConfirmaPassword.TabIndex = 18;
            this.labelConfirmaPassword.Text = "Confirma Password";
            // 
            // textBoxNuevoPassword
            // 
            this.textBoxNuevoPassword.Location = new System.Drawing.Point(156, 21);
            this.textBoxNuevoPassword.Name = "textBoxNuevoPassword";
            this.textBoxNuevoPassword.PasswordChar = '*';
            this.textBoxNuevoPassword.Size = new System.Drawing.Size(96, 20);
            this.textBoxNuevoPassword.TabIndex = 17;
            // 
            // labelNuevoPassword
            // 
            this.labelNuevoPassword.AutoSize = true;
            this.labelNuevoPassword.Location = new System.Drawing.Point(40, 24);
            this.labelNuevoPassword.Name = "labelNuevoPassword";
            this.labelNuevoPassword.Size = new System.Drawing.Size(88, 13);
            this.labelNuevoPassword.TabIndex = 16;
            this.labelNuevoPassword.Text = "Nuevo Password";
            // 
            // checkBoxCambioPass
            // 
            this.checkBoxCambioPass.AutoSize = true;
            this.checkBoxCambioPass.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCambioPass.Checked = true;
            this.checkBoxCambioPass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCambioPass.Location = new System.Drawing.Point(38, 77);
            this.checkBoxCambioPass.Name = "checkBoxCambioPass";
            this.checkBoxCambioPass.Size = new System.Drawing.Size(203, 17);
            this.checkBoxCambioPass.TabIndex = 22;
            this.checkBoxCambioPass.Text = "Cambio de password en proximo login";
            this.checkBoxCambioPass.UseVisualStyleBackColor = true;
            // 
            // ClienteNuevoPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 152);
            this.Controls.Add(this.checkBoxCambioPass);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxConfirmaPassword);
            this.Controls.Add(this.labelConfirmaPassword);
            this.Controls.Add(this.textBoxNuevoPassword);
            this.Controls.Add(this.labelNuevoPassword);
            this.Name = "ClienteNuevoPass";
            this.Text = "ClienteNuevoPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.TextBox textBoxConfirmaPassword;
        private System.Windows.Forms.Label labelConfirmaPassword;
        private System.Windows.Forms.TextBox textBoxNuevoPassword;
        private System.Windows.Forms.Label labelNuevoPassword;
        private System.Windows.Forms.CheckBox checkBoxCambioPass;
    }
}