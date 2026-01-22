namespace Controlador
{
    partial class BarraBotones
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnPermitirModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInfo.Font = new System.Drawing.Font("MV Boli", 9.75F);
            this.btnInfo.Image = global::Controlador.Properties.Resources.info;
            this.btnInfo.Location = new System.Drawing.Point(304, -1);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(110, 40);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "Mas Info";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnMasInfo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.Font = new System.Drawing.Font("MV Boli", 9.75F);
            this.btnGuardar.Image = global::Controlador.Properties.Resources.guardar;
            this.btnGuardar.Location = new System.Drawing.Point(188, -1);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 40);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnPermitirModificar
            // 
            this.btnPermitirModificar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnPermitirModificar.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermitirModificar.Image = global::Controlador.Properties.Resources.modificar;
            this.btnPermitirModificar.Location = new System.Drawing.Point(-1, -1);
            this.btnPermitirModificar.Name = "btnPermitirModificar";
            this.btnPermitirModificar.Size = new System.Drawing.Size(180, 40);
            this.btnPermitirModificar.TabIndex = 0;
            this.btnPermitirModificar.Text = "Permitir Modificar";
            this.btnPermitirModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPermitirModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPermitirModificar.UseVisualStyleBackColor = false;
            this.btnPermitirModificar.Click += new System.EventHandler(this.btnPermitirModificar_Click);
            // 
            // BarraBotones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnPermitirModificar);
            this.Name = "BarraBotones";
            this.Size = new System.Drawing.Size(413, 41);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPermitirModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnInfo;
    }
}
