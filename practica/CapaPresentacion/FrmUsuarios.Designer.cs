namespace CapaPresentacion
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigoU = new System.Windows.Forms.TextBox();
            this.cbProfesional = new System.Windows.Forms.ComboBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnprofesionales = new System.Windows.Forms.Button();
            this.btnNewU = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDeleteU = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbAcceso = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "..::MANTENIMIENTO USUARIOS::..";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(33)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(567, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(33)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(57, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Profesional";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(72, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Acceso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(21, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Contraseña";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(57, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Usuario";
            // 
            // txtCodigoU
            // 
            this.txtCodigoU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoU.Location = new System.Drawing.Point(153, 84);
            this.txtCodigoU.Name = "txtCodigoU";
            this.txtCodigoU.ReadOnly = true;
            this.txtCodigoU.Size = new System.Drawing.Size(220, 27);
            this.txtCodigoU.TabIndex = 10;
            // 
            // cbProfesional
            // 
            this.cbProfesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProfesional.FormattingEnabled = true;
            this.cbProfesional.Location = new System.Drawing.Point(153, 120);
            this.cbProfesional.Name = "cbProfesional";
            this.cbProfesional.Size = new System.Drawing.Size(363, 28);
            this.cbProfesional.TabIndex = 5;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(153, 154);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(220, 27);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(153, 187);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(220, 27);
            this.txtContraseña.TabIndex = 2;
            // 
            // btnprofesionales
            // 
            this.btnprofesionales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnprofesionales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprofesionales.ForeColor = System.Drawing.Color.White;
            this.btnprofesionales.Image = ((System.Drawing.Image)(resources.GetObject("btnprofesionales.Image")));
            this.btnprofesionales.Location = new System.Drawing.Point(522, 122);
            this.btnprofesionales.Name = "btnprofesionales";
            this.btnprofesionales.Size = new System.Drawing.Size(38, 25);
            this.btnprofesionales.TabIndex = 22;
            this.btnprofesionales.UseVisualStyleBackColor = false;
            this.btnprofesionales.Click += new System.EventHandler(this.btnprofesionales_Click);
            // 
            // btnNewU
            // 
            this.btnNewU.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnNewU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnNewU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewU.BorderRadius = 3;
            this.btnNewU.ButtonText = "GUARDAR";
            this.btnNewU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewU.DisabledColor = System.Drawing.Color.Gray;
            this.btnNewU.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold);
            this.btnNewU.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNewU.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNewU.Iconimage")));
            this.btnNewU.Iconimage_right = null;
            this.btnNewU.Iconimage_right_Selected = null;
            this.btnNewU.Iconimage_Selected = null;
            this.btnNewU.IconMarginLeft = 0;
            this.btnNewU.IconMarginRight = 0;
            this.btnNewU.IconRightVisible = true;
            this.btnNewU.IconRightZoom = 0D;
            this.btnNewU.IconVisible = true;
            this.btnNewU.IconZoom = 50D;
            this.btnNewU.IsTab = false;
            this.btnNewU.Location = new System.Drawing.Point(164, 292);
            this.btnNewU.Margin = new System.Windows.Forms.Padding(6);
            this.btnNewU.Name = "btnNewU";
            this.btnNewU.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnNewU.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNewU.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNewU.selected = false;
            this.btnNewU.Size = new System.Drawing.Size(192, 61);
            this.btnNewU.TabIndex = 8;
            this.btnNewU.Text = "GUARDAR";
            this.btnNewU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewU.Textcolor = System.Drawing.Color.White;
            this.btnNewU.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewU.Click += new System.EventHandler(this.btnNewU_Click);
            // 
            // btnDeleteU
            // 
            this.btnDeleteU.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnDeleteU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnDeleteU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteU.BorderRadius = 3;
            this.btnDeleteU.ButtonText = "CANCELAR";
            this.btnDeleteU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteU.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteU.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold);
            this.btnDeleteU.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteU.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeleteU.Iconimage")));
            this.btnDeleteU.Iconimage_right = null;
            this.btnDeleteU.Iconimage_right_Selected = null;
            this.btnDeleteU.Iconimage_Selected = null;
            this.btnDeleteU.IconMarginLeft = 0;
            this.btnDeleteU.IconMarginRight = 0;
            this.btnDeleteU.IconRightVisible = true;
            this.btnDeleteU.IconRightZoom = 0D;
            this.btnDeleteU.IconVisible = true;
            this.btnDeleteU.IconZoom = 50D;
            this.btnDeleteU.IsTab = false;
            this.btnDeleteU.Location = new System.Drawing.Point(368, 292);
            this.btnDeleteU.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteU.Name = "btnDeleteU";
            this.btnDeleteU.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnDeleteU.OnHovercolor = System.Drawing.Color.Red;
            this.btnDeleteU.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeleteU.selected = false;
            this.btnDeleteU.Size = new System.Drawing.Size(192, 61);
            this.btnDeleteU.TabIndex = 9;
            this.btnDeleteU.Text = "CANCELAR";
            this.btnDeleteU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteU.Textcolor = System.Drawing.Color.White;
            this.btnDeleteU.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteU.Click += new System.EventHandler(this.btnDeleteU_Click);
            // 
            // cbAcceso
            // 
            this.cbAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAcceso.FormattingEnabled = true;
            this.cbAcceso.Items.AddRange(new object[] {
            "Ingeniero",
            "Cajero",
            "Operador",
            "Administrador"});
            this.cbAcceso.Location = new System.Drawing.Point(153, 224);
            this.cbAcceso.Name = "cbAcceso";
            this.cbAcceso.Size = new System.Drawing.Size(363, 28);
            this.cbAcceso.TabIndex = 23;
            this.cbAcceso.Text = "Ingeniero";
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(609, 379);
            this.Controls.Add(this.cbAcceso);
            this.Controls.Add(this.btnDeleteU);
            this.Controls.Add(this.btnNewU);
            this.Controls.Add(this.btnprofesionales);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.cbProfesional);
            this.Controls.Add(this.txtCodigoU);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListadoProfesionales";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnprofesionales;
        private Bunifu.Framework.UI.BunifuFlatButton btnNewU;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteU;
        public System.Windows.Forms.TextBox txtCodigoU;
        public System.Windows.Forms.ComboBox cbProfesional;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.TextBox txtContraseña;
        public System.Windows.Forms.ComboBox cbAcceso;
    }
}