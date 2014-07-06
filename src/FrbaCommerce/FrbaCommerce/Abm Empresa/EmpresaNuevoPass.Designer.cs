namespace FrbaCommerce.Abm_Empresa
{
    partial class EmpresaNuevoPass
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
            this.checkBoxCambioPass = new System.Windows.Forms.CheckBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textBoxConfirmaPassword = new System.Windows.Forms.TextBox();
            this.labelConfirmaPassword = new System.Windows.Forms.Label();
            this.textBoxNuevoPassword = new System.Windows.Forms.TextBox();
            this.labelNuevoPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxCambioPass
            // 
            this.checkBoxCambioPass.AutoSize = true;
            this.checkBoxCambioPass.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCambioPass.Checked = true;
            this.checkBoxCambioPass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCambioPass.Location = new System.Drawing.Point(37, 76);
            this.checkBoxCambioPass.Name = "checkBoxCambioPass";
            this.checkBoxCambioPass.Size = new System.Drawing.Size(203, 17);
            this.checkBoxCambioPass.TabIndex = 29;
            this.checkBoxCambioPass.Text = "Cambio de password en proximo login";
            this.checkBoxCambioPass.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(155, 110);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 28;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(62, 110);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 27;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // textBoxConfirmaPassword
            // 
            this.textBoxConfirmaPassword.Location = new System.Drawing.Point(155, 46);
            this.textBoxConfirmaPassword.Name = "textBoxConfirmaPassword";
            this.textBoxConfirmaPassword.PasswordChar = '*';
            this.textBoxConfirmaPassword.Size = new System.Drawing.Size(96, 20);
            this.textBoxConfirmaPassword.TabIndex = 26;
            // 
            // labelConfirmaPassword
            // 
            this.labelConfirmaPassword.AutoSize = true;
            this.labelConfirmaPassword.Location = new System.Drawing.Point(39, 49);
            this.labelConfirmaPassword.Name = "labelConfirmaPassword";
            this.labelConfirmaPassword.Size = new System.Drawing.Size(97, 13);
            this.labelConfirmaPassword.TabIndex = 25;
            this.labelConfirmaPassword.Text = "Confirma Password";
            // 
            // textBoxNuevoPassword
            // 
            this.textBoxNuevoPassword.Location = new System.Drawing.Point(155, 20);
            this.textBoxNuevoPassword.Name = "textBoxNuevoPassword";
            this.textBoxNuevoPassword.PasswordChar = '*';
            this.textBoxNuevoPassword.Size = new System.Drawing.Size(96, 20);
            this.textBoxNuevoPassword.TabIndex = 24;
            // 
            // labelNuevoPassword
            // 
            this.labelNuevoPassword.AutoSize = true;
            this.labelNuevoPassword.Location = new System.Drawing.Point(39, 23);
            this.labelNuevoPassword.Name = "labelNuevoPassword";
            this.labelNuevoPassword.Size = new System.Drawing.Size(88, 13);
            this.labelNuevoPassword.TabIndex = 23;
            this.labelNuevoPassword.Text = "Nuevo Password";
            // 
            // EmpresaNuevoPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 146);
            this.Controls.Add(this.checkBoxCambioPass);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxConfirmaPassword);
            this.Controls.Add(this.labelConfirmaPassword);
            this.Controls.Add(this.textBoxNuevoPassword);
            this.Controls.Add(this.labelNuevoPassword);
            this.Name = "EmpresaNuevoPass";
            this.Text = "EmpresaNuevoPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxCambioPass;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.TextBox textBoxConfirmaPassword;
        private System.Windows.Forms.Label labelConfirmaPassword;
        private System.Windows.Forms.TextBox textBoxNuevoPassword;
        private System.Windows.Forms.Label labelNuevoPassword;
    }
}