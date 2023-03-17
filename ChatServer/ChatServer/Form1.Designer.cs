
namespace ChatServer
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
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelInicio = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.botonCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelLista = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelOpciones = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.labelAdministrador = new System.Windows.Forms.Label();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnExpulsar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelInicio
            // 
            this.panelInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelInicio.BackgroundImage")));
            this.panelInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelInicio.Controls.Add(this.pictureBox2);
            this.panelInicio.Controls.Add(this.botonCerrar);
            this.panelInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInicio.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(85)))));
            this.panelInicio.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(85)))));
            this.panelInicio.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(85)))));
            this.panelInicio.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(85)))));
            this.panelInicio.Location = new System.Drawing.Point(0, 0);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Quality = 10;
            this.panelInicio.Size = new System.Drawing.Size(892, 33);
            this.panelInicio.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // botonCerrar
            // 
            this.botonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.botonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("botonCerrar.Image")));
            this.botonCerrar.ImageActive = null;
            this.botonCerrar.Location = new System.Drawing.Point(855, 0);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(34, 32);
            this.botonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botonCerrar.TabIndex = 0;
            this.botonCerrar.TabStop = false;
            this.botonCerrar.Zoom = 4;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click_1);
            // 
            // labelLista
            // 
            this.labelLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(120)))));
            this.labelLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelLista.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLista.ForeColor = System.Drawing.SystemColors.Info;
            this.labelLista.Location = new System.Drawing.Point(0, 99);
            this.labelLista.Name = "labelLista";
            this.labelLista.ReadOnly = true;
            this.labelLista.Size = new System.Drawing.Size(254, 462);
            this.labelLista.TabIndex = 16;
            this.labelLista.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.labelTitulo);
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 54);
            this.panel1.TabIndex = 17;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTitulo.Location = new System.Drawing.Point(59, 11);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(143, 31);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "USUARIOS";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.White;
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(373, 307);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(511, 43);
            this.bunifuSeparator1.TabIndex = 21;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(120)))));
            this.panel3.Controls.Add(this.labelOpciones);
            this.panel3.Location = new System.Drawing.Point(373, 281);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(511, 41);
            this.panel3.TabIndex = 22;
            // 
            // labelOpciones
            // 
            this.labelOpciones.AutoSize = true;
            this.labelOpciones.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelOpciones.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelOpciones.Location = new System.Drawing.Point(22, 5);
            this.labelOpciones.Name = "labelOpciones";
            this.labelOpciones.Size = new System.Drawing.Size(310, 31);
            this.labelOpciones.TabIndex = 19;
            this.labelOpciones.Text = "Opciones Administrador";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(120)))));
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.btnExpulsar);
            this.panel2.Controls.Add(this.bunifuFlatButton1);
            this.panel2.Location = new System.Drawing.Point(373, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(511, 221);
            this.panel2.TabIndex = 23;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Enviar Archivo";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(79, 18);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Silver;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(356, 68);
            this.bunifuFlatButton1.TabIndex = 15;
            this.bunifuFlatButton1.Text = "Enviar Archivo";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(682, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 212);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 180;
            this.bunifuElipse2.TargetControl = this.pictureBox1;
            // 
            // labelAdministrador
            // 
            this.labelAdministrador.AutoSize = true;
            this.labelAdministrador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdministrador.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAdministrador.Location = new System.Drawing.Point(688, 36);
            this.labelAdministrador.Name = "labelAdministrador";
            this.labelAdministrador.Size = new System.Drawing.Size(179, 28);
            this.labelAdministrador.TabIndex = 25;
            this.labelAdministrador.Text = "Administrador";
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panelInicio;
            this.bunifuDragControl2.Vertical = true;
            // 
            // btnExpulsar
            // 
            this.btnExpulsar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.btnExpulsar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExpulsar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExpulsar.Location = new System.Drawing.Point(165, 118);
            this.btnExpulsar.Name = "btnExpulsar";
            this.btnExpulsar.Size = new System.Drawing.Size(270, 38);
            this.btnExpulsar.TabIndex = 16;
            this.btnExpulsar.Text = "Expulsar";
            this.btnExpulsar.UseVisualStyleBackColor = false;
            this.btnExpulsar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(85)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.SystemColors.Info;
            this.txtId.Location = new System.Drawing.Point(79, 118);
            this.txtId.MaxLength = 2;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(63, 38);
            this.txtId.TabIndex = 17;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(892, 561);
            this.Controls.Add(this.labelAdministrador);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelLista);
            this.Controls.Add(this.panelInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.RichTextBox labelLista;
        private Bunifu.Framework.UI.BunifuGradientPanel panelInicio;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuImageButton botonCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelOpciones;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label labelAdministrador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Button btnExpulsar;
        private System.Windows.Forms.TextBox txtId;
    }
}

