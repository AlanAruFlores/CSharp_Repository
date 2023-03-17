
namespace ChatCliente
{
    partial class Chat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.richChat = new System.Windows.Forms.RichTextBox();
            this.panelInicio = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.labelUsuario = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.textMensaje = new System.Windows.Forms.TextBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(120)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(507, 603);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(51, 46);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // richChat
            // 
            this.richChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(120)))));
            this.richChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richChat.ForeColor = System.Drawing.SystemColors.Info;
            this.richChat.Location = new System.Drawing.Point(29, 132);
            this.richChat.Name = "richChat";
            this.richChat.Size = new System.Drawing.Size(518, 445);
            this.richChat.TabIndex = 3;
            this.richChat.Text = "";
            // 
            // panelInicio
            // 
            this.panelInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelInicio.BackgroundImage")));
            this.panelInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelInicio.Controls.Add(this.pictureBox1);
            this.panelInicio.Controls.Add(this.botonCerrar);
            this.panelInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInicio.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(85)))));
            this.panelInicio.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(85)))));
            this.panelInicio.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(85)))));
            this.panelInicio.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(85)))));
            this.panelInicio.Location = new System.Drawing.Point(0, 0);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Quality = 10;
            this.panelInicio.Size = new System.Drawing.Size(882, 33);
            this.panelInicio.TabIndex = 5;
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
            this.botonCerrar.Location = new System.Drawing.Point(845, 0);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(34, 32);
            this.botonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botonCerrar.TabIndex = 0;
            this.botonCerrar.TabStop = false;
            this.botonCerrar.Zoom = 4;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click_1);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.White;
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(29, 96);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(811, 43);
            this.bunifuSeparator1.TabIndex = 6;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelUsuario.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.White;
            this.labelUsuario.Location = new System.Drawing.Point(31, 57);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(105, 54);
            this.labelUsuario.TabIndex = 7;
            this.labelUsuario.Text = "Chat";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this.richChat;
            // 
            // textMensaje
            // 
            this.textMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(120)))));
            this.textMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMensaje.ForeColor = System.Drawing.SystemColors.Info;
            this.textMensaje.Location = new System.Drawing.Point(29, 612);
            this.textMensaje.Name = "textMensaje";
            this.textMensaje.Size = new System.Drawing.Size(472, 27);
            this.textMensaje.TabIndex = 8;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.textMensaje;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelInicio;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(882, 661);
            this.Controls.Add(this.textMensaje);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.panelInicio);
            this.Controls.Add(this.richChat);
            this.Controls.Add(this.bunifuImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Chat";
            this.Text = "Chat";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panelInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.RichTextBox richChat;
        private Bunifu.Framework.UI.BunifuGradientPanel panelInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton botonCerrar;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel labelUsuario;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TextBox textMensaje;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}