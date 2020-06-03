namespace CapaPresentacion
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.btnNewC = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDeleteC = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProfesionales = new System.Windows.Forms.Button();
            this.txtTelefonoC = new System.Windows.Forms.TextBox();
            this.txtCorreoC = new System.Windows.Forms.TextBox();
            this.txtDireccionC = new System.Windows.Forms.TextBox();
            this.txtRazonSocialC = new System.Windows.Forms.TextBox();
            this.txtCioRUCC = new System.Windows.Forms.TextBox();
            this.cbProfesionC = new System.Windows.Forms.ComboBox();
            this.txtCodigoC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCiudadC = new System.Windows.Forms.ComboBox();
            this.btnCiudades = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(645, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "..::MANTENIMIENTO CLIENTES::..";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(33)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // picCerrar
            // 
            this.picCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(33)))));
            this.picCerrar.Image = ((System.Drawing.Image)(resources.GetObject("picCerrar.Image")));
            this.picCerrar.Location = new System.Drawing.Point(603, 0);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(42, 28);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCerrar.TabIndex = 6;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // btnNewC
            // 
            this.btnNewC.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnNewC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnNewC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewC.BorderRadius = 3;
            this.btnNewC.ButtonText = "GUARDAR";
            this.btnNewC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewC.DisabledColor = System.Drawing.Color.Gray;
            this.btnNewC.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold);
            this.btnNewC.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNewC.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNewC.Iconimage")));
            this.btnNewC.Iconimage_right = null;
            this.btnNewC.Iconimage_right_Selected = null;
            this.btnNewC.Iconimage_Selected = null;
            this.btnNewC.IconMarginLeft = 0;
            this.btnNewC.IconMarginRight = 0;
            this.btnNewC.IconRightVisible = true;
            this.btnNewC.IconRightZoom = 0D;
            this.btnNewC.IconVisible = true;
            this.btnNewC.IconZoom = 50D;
            this.btnNewC.IsTab = false;
            this.btnNewC.Location = new System.Drawing.Point(220, 384);
            this.btnNewC.Margin = new System.Windows.Forms.Padding(6);
            this.btnNewC.Name = "btnNewC";
            this.btnNewC.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnNewC.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNewC.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNewC.selected = false;
            this.btnNewC.Size = new System.Drawing.Size(192, 61);
            this.btnNewC.TabIndex = 9;
            this.btnNewC.Text = "GUARDAR";
            this.btnNewC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewC.Textcolor = System.Drawing.Color.White;
            this.btnNewC.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewC.Click += new System.EventHandler(this.btnNewC_Click);
            // 
            // btnDeleteC
            // 
            this.btnDeleteC.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnDeleteC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnDeleteC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteC.BorderRadius = 3;
            this.btnDeleteC.ButtonText = "CANCELAR";
            this.btnDeleteC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteC.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteC.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold);
            this.btnDeleteC.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteC.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeleteC.Iconimage")));
            this.btnDeleteC.Iconimage_right = null;
            this.btnDeleteC.Iconimage_right_Selected = null;
            this.btnDeleteC.Iconimage_Selected = null;
            this.btnDeleteC.IconMarginLeft = 0;
            this.btnDeleteC.IconMarginRight = 0;
            this.btnDeleteC.IconRightVisible = true;
            this.btnDeleteC.IconRightZoom = 0D;
            this.btnDeleteC.IconVisible = true;
            this.btnDeleteC.IconZoom = 50D;
            this.btnDeleteC.IsTab = false;
            this.btnDeleteC.Location = new System.Drawing.Point(438, 384);
            this.btnDeleteC.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteC.Name = "btnDeleteC";
            this.btnDeleteC.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnDeleteC.OnHovercolor = System.Drawing.Color.Red;
            this.btnDeleteC.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeleteC.selected = false;
            this.btnDeleteC.Size = new System.Drawing.Size(192, 61);
            this.btnDeleteC.TabIndex = 10;
            this.btnDeleteC.Text = "CANCELAR";
            this.btnDeleteC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteC.Textcolor = System.Drawing.Color.White;
            this.btnDeleteC.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteC.Click += new System.EventHandler(this.btnDeleteC_Click);
            // 
            // btnProfesionales
            // 
            this.btnProfesionales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProfesionales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnProfesionales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesionales.ForeColor = System.Drawing.Color.White;
            this.btnProfesionales.Image = ((System.Drawing.Image)(resources.GetObject("btnProfesionales.Image")));
            this.btnProfesionales.Location = new System.Drawing.Point(484, 333);
            this.btnProfesionales.Name = "btnProfesionales";
            this.btnProfesionales.Size = new System.Drawing.Size(38, 25);
            this.btnProfesionales.TabIndex = 39;
            this.btnProfesionales.UseVisualStyleBackColor = false;
            this.btnProfesionales.Click += new System.EventHandler(this.btnProfesionales_Click);
            // 
            // txtTelefonoC
            // 
            this.txtTelefonoC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefonoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoC.Location = new System.Drawing.Point(193, 259);
            this.txtTelefonoC.Name = "txtTelefonoC";
            this.txtTelefonoC.Size = new System.Drawing.Size(285, 27);
            this.txtTelefonoC.TabIndex = 30;
            // 
            // txtCorreoC
            // 
            this.txtCorreoC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoC.Location = new System.Drawing.Point(193, 298);
            this.txtCorreoC.Name = "txtCorreoC";
            this.txtCorreoC.Size = new System.Drawing.Size(285, 27);
            this.txtCorreoC.TabIndex = 29;
            // 
            // txtDireccionC
            // 
            this.txtDireccionC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccionC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionC.Location = new System.Drawing.Point(193, 178);
            this.txtDireccionC.Name = "txtDireccionC";
            this.txtDireccionC.Size = new System.Drawing.Size(363, 27);
            this.txtDireccionC.TabIndex = 25;
            // 
            // txtRazonSocialC
            // 
            this.txtRazonSocialC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRazonSocialC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocialC.Location = new System.Drawing.Point(193, 142);
            this.txtRazonSocialC.Name = "txtRazonSocialC";
            this.txtRazonSocialC.Size = new System.Drawing.Size(363, 27);
            this.txtRazonSocialC.TabIndex = 24;
            // 
            // txtCioRUCC
            // 
            this.txtCioRUCC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCioRUCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCioRUCC.Location = new System.Drawing.Point(193, 107);
            this.txtCioRUCC.Name = "txtCioRUCC";
            this.txtCioRUCC.Size = new System.Drawing.Size(172, 27);
            this.txtCioRUCC.TabIndex = 23;
            // 
            // cbProfesionC
            // 
            this.cbProfesionC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProfesionC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProfesionC.FormattingEnabled = true;
            this.cbProfesionC.Location = new System.Drawing.Point(193, 331);
            this.cbProfesionC.Name = "cbProfesionC";
            this.cbProfesionC.Size = new System.Drawing.Size(285, 28);
            this.cbProfesionC.TabIndex = 27;
            // 
            // txtCodigoC
            // 
            this.txtCodigoC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoC.Location = new System.Drawing.Point(193, 69);
            this.txtCodigoC.Name = "txtCodigoC";
            this.txtCodigoC.ReadOnly = true;
            this.txtCodigoC.Size = new System.Drawing.Size(172, 27);
            this.txtCodigoC.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(80, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 23);
            this.label9.TabIndex = 38;
            this.label9.Text = "Correo";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(20, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 23);
            this.label8.TabIndex = 37;
            this.label8.Text = "Profesional";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(56, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 23);
            this.label7.TabIndex = 36;
            this.label7.Text = "CI o RUC";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 23);
            this.label6.TabIndex = 34;
            this.label6.Text = "Razón Social";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(44, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(80, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Ciudad";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(56, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Teléfono";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(80, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Código";
            // 
            // cbCiudadC
            // 
            this.cbCiudadC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCiudadC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCiudadC.FormattingEnabled = true;
            this.cbCiudadC.Location = new System.Drawing.Point(193, 218);
            this.cbCiudadC.Name = "cbCiudadC";
            this.cbCiudadC.Size = new System.Drawing.Size(363, 28);
            this.cbCiudadC.TabIndex = 40;
            // 
            // btnCiudades
            // 
            this.btnCiudades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCiudades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnCiudades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCiudades.ForeColor = System.Drawing.Color.White;
            this.btnCiudades.Image = ((System.Drawing.Image)(resources.GetObject("btnCiudades.Image")));
            this.btnCiudades.Location = new System.Drawing.Point(562, 220);
            this.btnCiudades.Name = "btnCiudades";
            this.btnCiudades.Size = new System.Drawing.Size(38, 25);
            this.btnCiudades.TabIndex = 41;
            this.btnCiudades.UseVisualStyleBackColor = false;
            this.btnCiudades.Click += new System.EventHandler(this.btnCiudades_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(645, 460);
            this.Controls.Add(this.btnCiudades);
            this.Controls.Add(this.cbCiudadC);
            this.Controls.Add(this.btnProfesionales);
            this.Controls.Add(this.txtTelefonoC);
            this.Controls.Add(this.txtCorreoC);
            this.Controls.Add(this.txtDireccionC);
            this.Controls.Add(this.txtRazonSocialC);
            this.Controls.Add(this.txtCioRUCC);
            this.Controls.Add(this.cbProfesionC);
            this.Controls.Add(this.txtCodigoC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteC);
            this.Controls.Add(this.btnNewC);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picCerrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListadoCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picCerrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnNewC;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteC;
        private System.Windows.Forms.Button btnProfesionales;
        public System.Windows.Forms.TextBox txtTelefonoC;
        public System.Windows.Forms.TextBox txtCorreoC;
        public System.Windows.Forms.TextBox txtDireccionC;
        public System.Windows.Forms.TextBox txtRazonSocialC;
        public System.Windows.Forms.TextBox txtCioRUCC;
        public System.Windows.Forms.ComboBox cbProfesionC;
        public System.Windows.Forms.TextBox txtCodigoC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbCiudadC;
        private System.Windows.Forms.Button btnCiudades;
    }
}