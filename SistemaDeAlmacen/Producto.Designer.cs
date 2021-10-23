
namespace SistemaDeAlmacen
{
    partial class Producto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTitProductos = new System.Windows.Forms.Label();
            this.lbDatosP = new System.Windows.Forms.Label();
            this.lbLista = new System.Windows.Forms.Label();
            this.lbDCP = new System.Windows.Forms.Label();
            this.lbDPA = new System.Windows.Forms.Label();
            this.lbDPCa = new System.Windows.Forms.Label();
            this.lbDPD = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtAlmacen = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnGuardarP = new System.Windows.Forms.Button();
            this.btnLimpiarP = new System.Windows.Forms.Button();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbBuscarPor = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.lblTitProductos);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 36);
            this.panel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSalir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(694, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 28);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // lblTitProductos
            // 
            this.lblTitProductos.AutoSize = true;
            this.lblTitProductos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitProductos.Location = new System.Drawing.Point(371, 8);
            this.lblTitProductos.Name = "lblTitProductos";
            this.lblTitProductos.Size = new System.Drawing.Size(115, 24);
            this.lblTitProductos.TabIndex = 0;
            this.lblTitProductos.Text = "Productos";
            // 
            // lbDatosP
            // 
            this.lbDatosP.AutoSize = true;
            this.lbDatosP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatosP.ForeColor = System.Drawing.Color.Navy;
            this.lbDatosP.Location = new System.Drawing.Point(12, 55);
            this.lbDatosP.Name = "lbDatosP";
            this.lbDatosP.Size = new System.Drawing.Size(155, 19);
            this.lbDatosP.TabIndex = 1;
            this.lbDatosP.Text = "Datos del producto";
            // 
            // lbLista
            // 
            this.lbLista.AutoSize = true;
            this.lbLista.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLista.ForeColor = System.Drawing.Color.Navy;
            this.lbLista.Location = new System.Drawing.Point(295, 55);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(46, 19);
            this.lbLista.TabIndex = 2;
            this.lbLista.Text = "Lista";
            // 
            // lbDCP
            // 
            this.lbDCP.AutoSize = true;
            this.lbDCP.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDCP.Location = new System.Drawing.Point(13, 93);
            this.lbDCP.Name = "lbDCP";
            this.lbDCP.Size = new System.Drawing.Size(42, 16);
            this.lbDCP.TabIndex = 3;
            this.lbDCP.Text = "Código";
            // 
            // lbDPA
            // 
            this.lbDPA.AutoSize = true;
            this.lbDPA.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDPA.Location = new System.Drawing.Point(13, 260);
            this.lbDPA.Name = "lbDPA";
            this.lbDPA.Size = new System.Drawing.Size(48, 16);
            this.lbDPA.TabIndex = 4;
            this.lbDPA.Text = "Almacen";
            // 
            // lbDPCa
            // 
            this.lbDPCa.AutoSize = true;
            this.lbDPCa.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDPCa.Location = new System.Drawing.Point(13, 206);
            this.lbDPCa.Name = "lbDPCa";
            this.lbDPCa.Size = new System.Drawing.Size(54, 16);
            this.lbDPCa.TabIndex = 5;
            this.lbDPCa.Text = "Categoría";
            // 
            // lbDPD
            // 
            this.lbDPD.AutoSize = true;
            this.lbDPD.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDPD.Location = new System.Drawing.Point(13, 150);
            this.lbDPD.Name = "lbDPD";
            this.lbDPD.Size = new System.Drawing.Size(66, 16);
            this.lbDPD.TabIndex = 6;
            this.lbDPD.Text = "Descripción:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 112);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(155, 20);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtAlmacen
            // 
            this.txtAlmacen.Location = new System.Drawing.Point(12, 279);
            this.txtAlmacen.Name = "txtAlmacen";
            this.txtAlmacen.Size = new System.Drawing.Size(155, 20);
            this.txtAlmacen.TabIndex = 8;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(12, 225);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(155, 20);
            this.txtCategoria.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(12, 169);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(155, 20);
            this.txtDescripcion.TabIndex = 10;
            // 
            // btnGuardarP
            // 
            this.btnGuardarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGuardarP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarP.Location = new System.Drawing.Point(12, 327);
            this.btnGuardarP.Name = "btnGuardarP";
            this.btnGuardarP.Size = new System.Drawing.Size(155, 33);
            this.btnGuardarP.TabIndex = 11;
            this.btnGuardarP.Text = "Guardar";
            this.btnGuardarP.UseVisualStyleBackColor = false;
            this.btnGuardarP.Click += new System.EventHandler(this.btnGuardarP_Click);
            // 
            // btnLimpiarP
            // 
            this.btnLimpiarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLimpiarP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarP.Location = new System.Drawing.Point(12, 405);
            this.btnLimpiarP.Name = "btnLimpiarP";
            this.btnLimpiarP.Size = new System.Drawing.Size(155, 33);
            this.btnLimpiarP.TabIndex = 12;
            this.btnLimpiarP.Text = "Limpiar";
            this.btnLimpiarP.UseVisualStyleBackColor = false;
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEliminarP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarP.Location = new System.Drawing.Point(12, 366);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(155, 33);
            this.btnEliminarP.TabIndex = 13;
            this.btnEliminarP.Text = "Eliminar";
            this.btnEliminarP.UseVisualStyleBackColor = false;
            this.btnEliminarP.Click += new System.EventHandler(this.btnEliminarP_Click);
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.AllowUserToDeleteRows = false;
            this.dgvProducto.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column,
            this.Column2,
            this.Column1,
            this.Column3});
            this.dgvProducto.Location = new System.Drawing.Point(242, 77);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.Size = new System.Drawing.Size(520, 361);
            this.dgvProducto.TabIndex = 14;
            // 
            // Column
            // 
            this.Column.HeaderText = "Código";
            this.Column.Name = "Column";
            this.Column.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripción";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Categoria";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Almacen";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // lbBuscarPor
            // 
            this.lbBuscarPor.AutoSize = true;
            this.lbBuscarPor.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscarPor.Location = new System.Drawing.Point(387, 58);
            this.lbBuscarPor.Name = "lbBuscarPor";
            this.lbBuscarPor.Size = new System.Drawing.Size(63, 16);
            this.lbBuscarPor.TabIndex = 15;
            this.lbBuscarPor.Text = "Buscar por:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Código",
            "Descripción",
            "Categoria",
            "Almacen"});
            this.comboBox1.Location = new System.Drawing.Point(468, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(650, 53);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(63, 21);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbBuscarPor);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.btnEliminarP);
            this.Controls.Add(this.btnLimpiarP);
            this.Controls.Add(this.btnGuardarP);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtAlmacen);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lbDPD);
            this.Controls.Add(this.lbDPCa);
            this.Controls.Add(this.lbDPA);
            this.Controls.Add(this.lbDCP);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.lbDatosP);
            this.Controls.Add(this.panel1);
            this.Name = "Producto";
            this.Text = "Producto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitProductos;
        private System.Windows.Forms.Label lbDatosP;
        private System.Windows.Forms.Label lbLista;
        private System.Windows.Forms.Label lbDCP;
        private System.Windows.Forms.Label lbDPA;
        private System.Windows.Forms.Label lbDPCa;
        private System.Windows.Forms.Label lbDPD;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtAlmacen;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnGuardarP;
        private System.Windows.Forms.Button btnLimpiarP;
        private System.Windows.Forms.Button btnEliminarP;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lbBuscarPor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnBuscar;
    }
}