namespace CapaPresentacion
{
    partial class FrmListadoUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoUsuarios));
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewUsuario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditUsuario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDeleteUsuario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsuario.Image")));
            this.pictureBoxUsuario.Location = new System.Drawing.Point(903, 12);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(39, 31);
            this.pictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxUsuario.TabIndex = 0;
            this.pictureBoxUsuario.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listado de Usuarios";
            // 
            // btnNewUsuario
            // 
            this.btnNewUsuario.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNewUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnNewUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewUsuario.BorderRadius = 3;
            this.btnNewUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnNewUsuario.ButtonText = "NUEVO";
            this.btnNewUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewUsuario.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNewUsuario.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUsuario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNewUsuario.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNewUsuario.Iconimage")));
            this.btnNewUsuario.Iconimage_right = null;
            this.btnNewUsuario.Iconimage_right_Selected = null;
            this.btnNewUsuario.Iconimage_Selected = null;
            this.btnNewUsuario.IconMarginLeft = 0;
            this.btnNewUsuario.IconMarginRight = 0;
            this.btnNewUsuario.IconRightVisible = true;
            this.btnNewUsuario.IconRightZoom = 0D;
            this.btnNewUsuario.IconVisible = true;
            this.btnNewUsuario.IconZoom = 90D;
            this.btnNewUsuario.IsTab = false;
            this.btnNewUsuario.Location = new System.Drawing.Point(740, 62);
            this.btnNewUsuario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnNewUsuario.Name = "btnNewUsuario";
            this.btnNewUsuario.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnNewUsuario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNewUsuario.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNewUsuario.selected = false;
            this.btnNewUsuario.Size = new System.Drawing.Size(221, 78);
            this.btnNewUsuario.TabIndex = 6;
            this.btnNewUsuario.Text = "NUEVO";
            this.btnNewUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewUsuario.Textcolor = System.Drawing.Color.White;
            this.btnNewUsuario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUsuario.Click += new System.EventHandler(this.btnNewUsuario_Click);
            // 
            // btnEditUsuario
            // 
            this.btnEditUsuario.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(53)))));
            this.btnEditUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditUsuario.BorderRadius = 3;
            this.btnEditUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnEditUsuario.ButtonText = "EDITAR";
            this.btnEditUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditUsuario.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditUsuario.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUsuario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditUsuario.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditUsuario.Iconimage")));
            this.btnEditUsuario.Iconimage_right = null;
            this.btnEditUsuario.Iconimage_right_Selected = null;
            this.btnEditUsuario.Iconimage_Selected = null;
            this.btnEditUsuario.IconMarginLeft = 0;
            this.btnEditUsuario.IconMarginRight = 0;
            this.btnEditUsuario.IconRightVisible = true;
            this.btnEditUsuario.IconRightZoom = 0D;
            this.btnEditUsuario.IconVisible = true;
            this.btnEditUsuario.IconZoom = 90D;
            this.btnEditUsuario.IsTab = false;
            this.btnEditUsuario.Location = new System.Drawing.Point(740, 147);
            this.btnEditUsuario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEditUsuario.Name = "btnEditUsuario";
            this.btnEditUsuario.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(53)))));
            this.btnEditUsuario.OnHovercolor = System.Drawing.Color.Gray;
            this.btnEditUsuario.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditUsuario.selected = false;
            this.btnEditUsuario.Size = new System.Drawing.Size(221, 78);
            this.btnEditUsuario.TabIndex = 7;
            this.btnEditUsuario.Text = "EDITAR";
            this.btnEditUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditUsuario.Textcolor = System.Drawing.Color.White;
            this.btnEditUsuario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUsuario.Click += new System.EventHandler(this.BtnEditUsuario_Click);
            // 
            // btnDeleteUsuario
            // 
            this.btnDeleteUsuario.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDeleteUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnDeleteUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteUsuario.BorderRadius = 3;
            this.btnDeleteUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnDeleteUsuario.ButtonText = "ELIMINAR";
            this.btnDeleteUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUsuario.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDeleteUsuario.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUsuario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteUsuario.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeleteUsuario.Iconimage")));
            this.btnDeleteUsuario.Iconimage_right = null;
            this.btnDeleteUsuario.Iconimage_right_Selected = null;
            this.btnDeleteUsuario.Iconimage_Selected = null;
            this.btnDeleteUsuario.IconMarginLeft = 0;
            this.btnDeleteUsuario.IconMarginRight = 0;
            this.btnDeleteUsuario.IconRightVisible = true;
            this.btnDeleteUsuario.IconRightZoom = 0D;
            this.btnDeleteUsuario.IconVisible = true;
            this.btnDeleteUsuario.IconZoom = 90D;
            this.btnDeleteUsuario.IsTab = false;
            this.btnDeleteUsuario.Location = new System.Drawing.Point(740, 232);
            this.btnDeleteUsuario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDeleteUsuario.Name = "btnDeleteUsuario";
            this.btnDeleteUsuario.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnDeleteUsuario.OnHovercolor = System.Drawing.Color.Red;
            this.btnDeleteUsuario.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeleteUsuario.selected = false;
            this.btnDeleteUsuario.Size = new System.Drawing.Size(221, 78);
            this.btnDeleteUsuario.TabIndex = 8;
            this.btnDeleteUsuario.Text = "ELIMINAR";
            this.btnDeleteUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteUsuario.Textcolor = System.Drawing.Color.White;
            this.btnDeleteUsuario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUsuario.Click += new System.EventHandler(this.btnDeleteUsuario_Click);
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(12, 62);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.RowHeadersWidth = 51;
            this.dgvUsuario.RowTemplate.Height = 24;
            this.dgvUsuario.Size = new System.Drawing.Size(710, 423);
            this.dgvUsuario.TabIndex = 10;
            // 
            // FrmListadoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(975, 539);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.btnDeleteUsuario);
            this.Controls.Add(this.btnEditUsuario);
            this.Controls.Add(this.btnNewUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmListadoUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxUsuario;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnNewUsuario;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditUsuario;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteUsuario;
        private System.Windows.Forms.DataGridView dgvUsuario;
    }
}