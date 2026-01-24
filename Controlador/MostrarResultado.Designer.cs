namespace Controlador
{
    partial class MostrarResultado
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
            this.lbCodigoError = new System.Windows.Forms.Label();
            this.lbMostrarErrores = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCodigoError
            // 
            this.lbCodigoError.AutoSize = true;
            this.lbCodigoError.ForeColor = System.Drawing.Color.DarkRed;
            this.lbCodigoError.Location = new System.Drawing.Point(175, 25);
            this.lbCodigoError.Name = "lbCodigoError";
            this.lbCodigoError.Size = new System.Drawing.Size(102, 13);
            this.lbCodigoError.TabIndex = 0;
            this.lbCodigoError.Text = "{CODIGO_ERROR}";
            // 
            // lbMostrarErrores
            // 
            this.lbMostrarErrores.AutoSize = true;
            this.lbMostrarErrores.BackColor = System.Drawing.SystemColors.Info;
            this.lbMostrarErrores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMostrarErrores.Location = new System.Drawing.Point(151, 76);
            this.lbMostrarErrores.Name = "lbMostrarErrores";
            this.lbMostrarErrores.Size = new System.Drawing.Size(91, 15);
            this.lbMostrarErrores.TabIndex = 1;
            this.lbMostrarErrores.Text = "{Mostrar_Errores}";
            // 
            // picBox
            // 
            this.picBox.Image = global::Controlador.Properties.Resources.error;
            this.picBox.Location = new System.Drawing.Point(12, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(100, 50);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 2;
            this.picBox.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(26, 92);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // MostrarResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.lbMostrarErrores);
            this.Controls.Add(this.lbCodigoError);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MostrarResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MostrarResultado";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodigoError;
        private System.Windows.Forms.Label lbMostrarErrores;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnAceptar;
    }
}