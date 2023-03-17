
namespace PictureCRUD
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureImage = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btnClean);
            this.groupBox.Controls.Add(this.button3);
            this.groupBox.Controls.Add(this.button2);
            this.groupBox.Controls.Add(this.button1);
            this.groupBox.Controls.Add(this.pictureImage);
            this.groupBox.Controls.Add(this.txtName);
            this.groupBox.Controls.Add(this.labelName);
            this.groupBox.Controls.Add(this.txtId);
            this.groupBox.Controls.Add(this.labelId);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(26, 38);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(689, 488);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Formulario";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(216, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 84);
            this.button3.TabIndex = 7;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 54);
            this.button2.TabIndex = 6;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 84);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cargar imagen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureImage
            // 
            this.pictureImage.Location = new System.Drawing.Point(26, 192);
            this.pictureImage.Name = "pictureImage";
            this.pictureImage.Size = new System.Drawing.Size(266, 177);
            this.pictureImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureImage.TabIndex = 4;
            this.pictureImage.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(136, 129);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(224, 30);
            this.txtName.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(21, 129);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(87, 25);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Nombre";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(77, 69);
            this.txtId.MaxLength = 4;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(112, 30);
            this.txtId.TabIndex = 1;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(21, 69);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(33, 25);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "ID";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(452, 398);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(174, 84);
            this.btnClean.TabIndex = 8;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.groupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureImage;
        private System.Windows.Forms.Button btnClean;
    }
}

