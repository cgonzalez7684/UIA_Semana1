namespace App1
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
            this.TxtIdArticulo = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNomArticulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbTipoArticulo = new System.Windows.Forms.ComboBox();
            this.DtRegistro = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCosto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtIva = new System.Windows.Forms.TextBox();
            this.ChkCambiarIVA = new System.Windows.Forms.CheckBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DgProductos = new System.Windows.Forms.DataGridView();
            this.IdArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtIdArticulo
            // 
            this.TxtIdArticulo.Location = new System.Drawing.Point(124, 11);
            this.TxtIdArticulo.Name = "TxtIdArticulo";
            this.TxtIdArticulo.Size = new System.Drawing.Size(168, 20);
            this.TxtIdArticulo.TabIndex = 0;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(12, 317);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(86, 23);
            this.BtnGuardar.TabIndex = 1;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IdArticulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Articulo";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // TxtNomArticulo
            // 
            this.TxtNomArticulo.Location = new System.Drawing.Point(124, 49);
            this.TxtNomArticulo.Name = "TxtNomArticulo";
            this.TxtNomArticulo.Size = new System.Drawing.Size(168, 20);
            this.TxtNomArticulo.TabIndex = 3;
            this.TxtNomArticulo.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo";
            // 
            // CmbTipoArticulo
            // 
            this.CmbTipoArticulo.FormattingEnabled = true;
            this.CmbTipoArticulo.Items.AddRange(new object[] {
            "Alimentos",
            "Entretenimiento",
            "Ferreteria"});
            this.CmbTipoArticulo.Location = new System.Drawing.Point(124, 87);
            this.CmbTipoArticulo.Name = "CmbTipoArticulo";
            this.CmbTipoArticulo.Size = new System.Drawing.Size(168, 21);
            this.CmbTipoArticulo.TabIndex = 6;
            // 
            // DtRegistro
            // 
            this.DtRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtRegistro.Location = new System.Drawing.Point(124, 132);
            this.DtRegistro.Name = "DtRegistro";
            this.DtRegistro.Size = new System.Drawing.Size(168, 20);
            this.DtRegistro.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Registro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Costo";
            // 
            // TxtCosto
            // 
            this.TxtCosto.Location = new System.Drawing.Point(124, 218);
            this.TxtCosto.Name = "TxtCosto";
            this.TxtCosto.Size = new System.Drawing.Size(168, 20);
            this.TxtCosto.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "IVA";
            // 
            // TxtIva
            // 
            this.TxtIva.Location = new System.Drawing.Point(124, 264);
            this.TxtIva.Name = "TxtIva";
            this.TxtIva.Size = new System.Drawing.Size(100, 20);
            this.TxtIva.TabIndex = 12;
            // 
            // ChkCambiarIVA
            // 
            this.ChkCambiarIVA.AutoSize = true;
            this.ChkCambiarIVA.Location = new System.Drawing.Point(239, 267);
            this.ChkCambiarIVA.Name = "ChkCambiarIVA";
            this.ChkCambiarIVA.Size = new System.Drawing.Size(84, 17);
            this.ChkCambiarIVA.TabIndex = 13;
            this.ChkCambiarIVA.Text = "Cambiar IVA";
            this.ChkCambiarIVA.UseVisualStyleBackColor = true;
            this.ChkCambiarIVA.CheckedChanged += new System.EventHandler(this.ChkCambiarIVA_CheckedChanged);
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(124, 170);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(168, 20);
            this.TxtCantidad.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cantidad";
            // 
            // DgProductos
            // 
            this.DgProductos.AllowUserToAddRows = false;
            this.DgProductos.AllowUserToDeleteRows = false;
            this.DgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdArticulo,
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column7});
            this.DgProductos.Location = new System.Drawing.Point(12, 361);
            this.DgProductos.Name = "DgProductos";
            this.DgProductos.ReadOnly = true;
            this.DgProductos.RowHeadersVisible = false;
            this.DgProductos.Size = new System.Drawing.Size(644, 172);
            this.DgProductos.TabIndex = 16;
            // 
            // IdArticulo
            // 
            this.IdArticulo.DataPropertyName = "IdArticulo";
            this.IdArticulo.HeaderText = "IdProducto";
            this.IdArticulo.Name = "IdArticulo";
            this.IdArticulo.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "NomArticulo";
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Costo";
            this.Column2.HeaderText = "Costo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Tipo";
            this.Column5.HeaderText = "Tipo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MontoIVA";
            this.Column3.HeaderText = "IVA";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Cantidad";
            this.Column6.HeaderText = "Cantidad";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TotalCosto";
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "FechaRegistro";
            this.Column7.HeaderText = "FechaRegistro";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 556);
            this.Controls.Add(this.DgProductos);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ChkCambiarIVA);
            this.Controls.Add(this.TxtIva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtCosto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DtRegistro);
            this.Controls.Add(this.CmbTipoArticulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNomArticulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtIdArticulo);
            this.Name = "Form1";
            this.Text = "Gestor de Productos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIdArticulo;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNomArticulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbTipoArticulo;
        private System.Windows.Forms.DateTimePicker DtRegistro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCosto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtIva;
        private System.Windows.Forms.CheckBox ChkCambiarIVA;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DgProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

