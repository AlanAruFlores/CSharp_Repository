
namespace TablaSQL
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
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.tablaGrid = new System.Windows.Forms.DataGridView();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.txtBusqqueda = new System.Windows.Forms.TextBox();
            this.groupPersona = new System.Windows.Forms.GroupBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labelEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personaBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.personaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.personaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.personaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personaBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.personaBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.IdGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaGrid)).BeginInit();
            this.groupPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(309, 48);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(174, 45);
            this.btnSeleccionar.TabIndex = 0;
            this.btnSeleccionar.Text = "Buscar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // tablaGrid
            // 
            this.tablaGrid.AllowUserToAddRows = false;
            this.tablaGrid.AllowUserToDeleteRows = false;
            this.tablaGrid.AutoGenerateColumns = false;
            this.tablaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.IdGenero});
            this.tablaGrid.DataSource = this.personaBindingSource6;
            this.tablaGrid.Location = new System.Drawing.Point(32, 109);
            this.tablaGrid.Name = "tablaGrid";
            this.tablaGrid.ReadOnly = true;
            this.tablaGrid.RowHeadersWidth = 51;
            this.tablaGrid.RowTemplate.Height = 24;
            this.tablaGrid.Size = new System.Drawing.Size(521, 324);
            this.tablaGrid.TabIndex = 1;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.Location = new System.Drawing.Point(25, 9);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(123, 39);
            this.labelBuscar.TabIndex = 2;
            this.labelBuscar.Text = "Buscar";
            this.labelBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBusqqueda
            // 
            this.txtBusqqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqqueda.Location = new System.Drawing.Point(32, 48);
            this.txtBusqqueda.Name = "txtBusqqueda";
            this.txtBusqqueda.Size = new System.Drawing.Size(242, 45);
            this.txtBusqqueda.TabIndex = 3;
            // 
            // groupPersona
            // 
            this.groupPersona.Controls.Add(this.cbGenero);
            this.groupPersona.Controls.Add(this.label1);
            this.groupPersona.Controls.Add(this.btnLimpiar);
            this.groupPersona.Controls.Add(this.btnGuardar);
            this.groupPersona.Controls.Add(this.txtId);
            this.groupPersona.Controls.Add(this.txtEdad);
            this.groupPersona.Controls.Add(this.labelEdad);
            this.groupPersona.Controls.Add(this.txtNombre);
            this.groupPersona.Controls.Add(this.labelNombre);
            this.groupPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPersona.Location = new System.Drawing.Point(569, 85);
            this.groupPersona.Name = "groupPersona";
            this.groupPersona.Size = new System.Drawing.Size(488, 443);
            this.groupPersona.TabIndex = 4;
            this.groupPersona.TabStop = false;
            this.groupPersona.Text = "Datos";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(36, 70);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(101, 29);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(170, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(228, 34);
            this.txtNombre.TabIndex = 1;
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(36, 141);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(70, 29);
            this.labelEdad.TabIndex = 2;
            this.labelEdad.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(170, 136);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(228, 34);
            this.txtEdad.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(68, 314);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(97, 34);
            this.txtId.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(68, 367);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(152, 57);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(274, 367);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(160, 57);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(32, 534);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(266, 62);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(355, 534);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(234, 62);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Genero";
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(170, 212);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(228, 37);
            this.cbGenero.TabIndex = 8;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            this.edadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personaBindingSource4
            // 
            this.personaBindingSource4.DataSource = typeof(TablaSQL.Persona);
            // 
            // personaBindingSource3
            // 
            this.personaBindingSource3.DataSource = typeof(TablaSQL.Persona);
            // 
            // personaBindingSource2
            // 
            this.personaBindingSource2.DataSource = typeof(TablaSQL.Persona);
            // 
            // personaBindingSource1
            // 
            this.personaBindingSource1.DataSource = typeof(TablaSQL.Persona);
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataSource = typeof(TablaSQL.Persona);
            // 
            // personaBindingSource5
            // 
            this.personaBindingSource5.DataSource = typeof(TablaSQL.Persona);
            // 
            // personaBindingSource6
            // 
            this.personaBindingSource6.DataSource = typeof(TablaSQL.Persona);
            // 
            // IdGenero
            // 
            this.IdGenero.DataPropertyName = "IdGenero";
            this.IdGenero.HeaderText = "IdGenero";
            this.IdGenero.MinimumWidth = 6;
            this.IdGenero.Name = "IdGenero";
            this.IdGenero.ReadOnly = true;
            this.IdGenero.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 666);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupPersona);
            this.Controls.Add(this.txtBusqqueda);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.tablaGrid);
            this.Controls.Add(this.btnSeleccionar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tablaGrid)).EndInit();
            this.groupPersona.ResumeLayout(false);
            this.groupPersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView tablaGrid;
        private System.Windows.Forms.Label labelBuscar;
        public System.Windows.Forms.TextBox txtBusqqueda;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private System.Windows.Forms.BindingSource personaBindingSource1;
        private System.Windows.Forms.BindingSource personaBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupPersona;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource personaBindingSource3;
        private System.Windows.Forms.BindingSource personaBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGenero;
        private System.Windows.Forms.BindingSource personaBindingSource6;
        private System.Windows.Forms.BindingSource personaBindingSource5;
    }
}

