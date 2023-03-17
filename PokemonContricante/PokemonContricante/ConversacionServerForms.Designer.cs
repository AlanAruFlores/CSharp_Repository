
namespace Pokemon
{
    partial class ConversacionServerForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversacionServerForms));
            this.panelInicio = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mensajePersonaje = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPersonaje = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelInformation = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInicio
            // 
            this.panelInicio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelInicio.Controls.Add(this.bunifuImageButton1);
            this.panelInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInicio.Location = new System.Drawing.Point(0, 0);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(800, 53);
            this.panelInicio.TabIndex = 1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(756, 0);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(44, 53);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-24, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Black;
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(348, 202);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(165, 56);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 6;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(617, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 223);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // mensajePersonaje
            // 
            this.mensajePersonaje.AutoSize = true;
            this.mensajePersonaje.Font = new System.Drawing.Font("Papyrus", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensajePersonaje.ForeColor = System.Drawing.Color.White;
            this.mensajePersonaje.Location = new System.Drawing.Point(191, 113);
            this.mensajePersonaje.Name = "mensajePersonaje";
            this.mensajePersonaje.Size = new System.Drawing.Size(59, 30);
            this.mensajePersonaje.TabIndex = 9;
            this.mensajePersonaje.Text = "texto";
            // 
            // txtPersonaje
            // 
            this.txtPersonaje.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonaje.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPersonaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPersonaje.HintForeColor = System.Drawing.Color.Empty;
            this.txtPersonaje.HintText = "";
            this.txtPersonaje.isPassword = false;
            this.txtPersonaje.LineFocusedColor = System.Drawing.Color.White;
            this.txtPersonaje.LineIdleColor = System.Drawing.Color.White;
            this.txtPersonaje.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtPersonaje.LineThickness = 3;
            this.txtPersonaje.Location = new System.Drawing.Point(554, 369);
            this.txtPersonaje.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonaje.Name = "txtPersonaje";
            this.txtPersonaje.Size = new System.Drawing.Size(246, 33);
            this.txtPersonaje.TabIndex = 10;
            this.txtPersonaje.Text = "Mensaje";
            this.txtPersonaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformation.ForeColor = System.Drawing.Color.White;
            this.labelInformation.Location = new System.Drawing.Point(332, 79);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(0, 30);
            this.labelInformation.TabIndex = 11;
            // 
            // ConversacionServerForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.txtPersonaje);
            this.Controls.Add(this.mensajePersonaje);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConversacionServerForms";
            this.Text = "ConversacionServerForms";
            this.panelInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelInicio;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel mensajePersonaje;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPersonaje;
        private Bunifu.Framework.UI.BunifuCustomLabel labelInformation;
    }
}