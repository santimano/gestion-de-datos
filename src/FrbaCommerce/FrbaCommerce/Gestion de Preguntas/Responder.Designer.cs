namespace FrbaCommerce.Gestion_de_Preguntas
{
    partial class Responder
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
            this.tbRespuesta = new System.Windows.Forms.TextBox();
            this.btResponder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbRespuesta
            // 
            this.tbRespuesta.Location = new System.Drawing.Point(12, 12);
            this.tbRespuesta.Multiline = true;
            this.tbRespuesta.Name = "tbRespuesta";
            this.tbRespuesta.Size = new System.Drawing.Size(260, 77);
            this.tbRespuesta.TabIndex = 0;
            // 
            // btResponder
            // 
            this.btResponder.Location = new System.Drawing.Point(102, 134);
            this.btResponder.Name = "btResponder";
            this.btResponder.Size = new System.Drawing.Size(75, 23);
            this.btResponder.TabIndex = 1;
            this.btResponder.Text = "Responder";
            this.btResponder.UseVisualStyleBackColor = true;
            this.btResponder.Click += new System.EventHandler(this.btResponder_Click);
            // 
            // Responder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 189);
            this.Controls.Add(this.btResponder);
            this.Controls.Add(this.tbRespuesta);
            this.Name = "Responder";
            this.Text = "Responder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRespuesta;
        private System.Windows.Forms.Button btResponder;
    }
}