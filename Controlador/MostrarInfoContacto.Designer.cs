namespace Controlador
{
    partial class MostrarInfoContacto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.barraBotones1 = new Controlador.BarraBotones();
            this.imgContacto = new System.Windows.Forms.PictureBox();
            this.pictureBoxMarco = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarco)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.barraBotones1);
            this.panel1.Controls.Add(this.imgContacto);
            this.panel1.Controls.Add(this.btnAddImage);
            this.panel1.Controls.Add(this.pictureBoxMarco);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 661);
            this.panel1.TabIndex = 0;
            // 
            // btnAddImage
            // 
            this.btnAddImage.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddImage.FlatAppearance.BorderSize = 0;
            this.btnAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAddImage.Location = new System.Drawing.Point(254, 216);
            this.btnAddImage.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(40, 34);
            this.btnAddImage.TabIndex = 2;
            this.btnAddImage.Text = "+";
            this.btnAddImage.UseVisualStyleBackColor = false;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // barraBotones1
            // 
            this.barraBotones1.Location = new System.Drawing.Point(91, 9);
            this.barraBotones1.Name = "barraBotones1";
            this.barraBotones1.Size = new System.Drawing.Size(413, 41);
            this.barraBotones1.TabIndex = 4;
            this.barraBotones1.VisibilidadGuardar = true;
            this.barraBotones1.VisibilidadMasInfo = true;
            this.barraBotones1.VisibilidadPermitirModificar = true;
            // 
            // imgContacto
            // 
            this.imgContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(230)))), ((int)(((byte)(29)))));
            this.imgContacto.Location = new System.Drawing.Point(220, 102);
            this.imgContacto.Name = "imgContacto";
            this.imgContacto.Size = new System.Drawing.Size(105, 107);
            this.imgContacto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgContacto.TabIndex = 3;
            this.imgContacto.TabStop = false;
            // 
            // pictureBoxMarco
            // 
            this.pictureBoxMarco.Image = global::Controlador.Properties.Resources.marco_removebg_preview__1_;
            this.pictureBoxMarco.Location = new System.Drawing.Point(183, 56);
            this.pictureBoxMarco.Name = "pictureBoxMarco";
            this.pictureBoxMarco.Size = new System.Drawing.Size(180, 194);
            this.pictureBoxMarco.TabIndex = 1;
            this.pictureBoxMarco.TabStop = false;
            // 
            // MostrarInfoContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "MostrarInfoContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MostrarInfoContacto";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxMarco;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.PictureBox imgContacto;
        private BarraBotones barraBotones1;
    }
}