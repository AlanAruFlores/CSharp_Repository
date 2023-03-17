
namespace ChatCliente
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelInicio = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtNombre = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this;
            // 
            // panelInicio
            // 
            this.panelInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(85)))));
            this.panelInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelInicio.BackgroundImage")));
            this.panelInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelInicio.Controls.Add(this.pictureBox1);
            this.panelInicio.Controls.Add(this.botonCerrar);
            this.panelInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInicio.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(85)))));
            this.panelInicio.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(80)))));
            this.panelInicio.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(80)))));
            this.panelInicio.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(80)))));
            this.panelInicio.Location = new System.Drawing.Point(0, 0);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Quality = 10;
            this.panelInicio.Size = new System.Drawing.Size(976, 33);
            this.panelInicio.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // botonCerrar
            // 
            this.botonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.botonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("botonCerrar.Image")));
            this.botonCerrar.ImageActive = null;
            this.botonCerrar.Location = new System.Drawing.Point(942, 0);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(34, 32);
            this.botonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botonCerrar.TabIndex = 0;
            this.botonCerrar.TabStop = false;
            this.botonCerrar.Zoom = 4;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelInicio;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 1;
            this.bunifuElipse3.TargetControl = this;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(459, 586);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(504, 43);
            this.bunifuSeparator1.TabIndex = 10;
            this.bunifuSeparator1.Transparency = 140;
            this.bunifuSeparator1.Vertical = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(80)))), ((int)(((byte)(217)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 628);
            this.panel1.TabIndex = 13;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(459, 275);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(504, 43);
            this.bunifuSeparator2.TabIndex = 15;
            this.bunifuSeparator2.Transparency = 140;
            this.bunifuSeparator2.Vertical = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(612, 52);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(212, 225);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.PaleVioletRed;
            this.bunifuFlatButton1.AutoSize = true;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 4;
            this.bunifuFlatButton1.ButtonText = "Entrar";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(556, 497);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.PaleVioletRed;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.PaleVioletRed;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(402, 61);
            this.bunifuFlatButton1.TabIndex = 22;
            this.bunifuFlatButton1.Text = "Entrar";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Yu Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(553, 331);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(95, 32);
            this.label.TabIndex = 23;
            this.label.Text = "Usuario";
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.Black;
            this.bunifuSeparator3.LineThickness = 3;
            this.bunifuSeparator3.Location = new System.Drawing.Point(559, 416);
            this.bunifuSeparator3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(399, 43);
            this.bunifuSeparator3.TabIndex = 26;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(85)))));
            this.txtNombre.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(625, 397);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(333, 34);
            this.txtNombre.TabIndex = 27;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(561, 375);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 56);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(976, 661);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.panelInicio);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuGradientPanel panelInicio;
        private Bunifu.Framework.UI.BunifuImageButton botonCerrar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel label;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtNombre;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
    }
}

