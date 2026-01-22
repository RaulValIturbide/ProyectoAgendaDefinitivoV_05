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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.TableLayoutPanel();
            this.BarraBotonesPrincipal = new Controlador.BarraBotones();
            this.button1 = new System.Windows.Forms.Button();
            this.imgContacto = new System.Windows.Forms.PictureBox();
            this.pictureBoxMarco = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarco)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbInfo);
            this.panel1.Controls.Add(this.BarraBotonesPrincipal);
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
            // txtEmail
            // 
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEmail.Location = new System.Drawing.Point(112, 55);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(158, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtApellidos.Location = new System.Drawing.Point(112, 29);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(158, 20);
            this.txtApellidos.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNombre.Location = new System.Drawing.Point(112, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(158, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbEmail.Font = new System.Drawing.Font("MV Boli", 9.75F);
            this.lbEmail.Location = new System.Drawing.Point(3, 52);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(103, 17);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "EMAIL";
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbApellidos.Font = new System.Drawing.Font("MV Boli", 9.75F);
            this.lbApellidos.Location = new System.Drawing.Point(3, 26);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(103, 17);
            this.lbApellidos.TabIndex = 7;
            this.lbApellidos.Text = "APELLIDOS";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNombre.Font = new System.Drawing.Font("MV Boli", 9.75F);
            this.lbNombre.Location = new System.Drawing.Point(3, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(103, 17);
            this.lbNombre.TabIndex = 6;
            this.lbNombre.Text = "NOMBRE";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTelefono.Location = new System.Drawing.Point(112, 81);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(158, 20);
            this.txtTelefono.TabIndex = 13;
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTelefono.Font = new System.Drawing.Font("MV Boli", 9.75F);
            this.lbTelefono.Location = new System.Drawing.Point(3, 78);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(103, 17);
            this.lbTelefono.TabIndex = 12;
            this.lbTelefono.Text = "TELEFONO";
            // 
            // tbInfo
            // 
            this.tbInfo.ColumnCount = 2;
            this.tbInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tbInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tbInfo.Controls.Add(this.lbTelefono, 0, 3);
            this.tbInfo.Controls.Add(this.txtEmail, 1, 2);
            this.tbInfo.Controls.Add(this.txtApellidos, 1, 1);
            this.tbInfo.Controls.Add(this.txtNombre, 1, 0);
            this.tbInfo.Controls.Add(this.txtTelefono, 1, 3);
            this.tbInfo.Controls.Add(this.lbEmail, 0, 2);
            this.tbInfo.Controls.Add(this.lbApellidos, 0, 1);
            this.tbInfo.Controls.Add(this.lbNombre, 0, 0);
            this.tbInfo.Location = new System.Drawing.Point(158, 318);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.RowCount = 4;
            this.tbInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbInfo.Size = new System.Drawing.Size(273, 205);
            this.tbInfo.TabIndex = 14;
            // 
            // BarraBotonesPrincipal
            // 
            this.BarraBotonesPrincipal.Location = new System.Drawing.Point(91, 9);
            this.BarraBotonesPrincipal.Name = "BarraBotonesPrincipal";
            this.BarraBotonesPrincipal.Size = new System.Drawing.Size(413, 41);
            this.BarraBotonesPrincipal.TabIndex = 4;
            this.BarraBotonesPrincipal.VisibilidadGuardar = true;
            this.BarraBotonesPrincipal.VisibilidadMasInfo = true;
            this.BarraBotonesPrincipal.VisibilidadPermitirModificar = true;
            // 
            // button1
            // 
            this.button1.Image = global::Controlador.Properties.Resources.plus;
            this.button1.Location = new System.Drawing.Point(112, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 32);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddTelefono_Click);
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
            this.tbInfo.ResumeLayout(false);
            this.tbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxMarco;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.PictureBox imgContacto;
        private BarraBotones BarraBotonesPrincipal;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.TableLayoutPanel tbInfo;
        private System.Windows.Forms.Button button1;
    }
}