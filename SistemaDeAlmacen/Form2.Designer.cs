
namespace SistemaDeAlmacen
{
    partial class MenuProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuProductos));
            this.btnCargarP = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCerrarMP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargarP
            // 
            this.btnCargarP.BackColor = System.Drawing.Color.White;
            this.btnCargarP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCargarP.BackgroundImage")));
            this.btnCargarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCargarP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarP.ForeColor = System.Drawing.Color.Black;
            this.btnCargarP.Location = new System.Drawing.Point(12, 12);
            this.btnCargarP.Name = "btnCargarP";
            this.btnCargarP.Size = new System.Drawing.Size(106, 147);
            this.btnCargarP.TabIndex = 8;
            this.btnCargarP.Text = "Cargar";
            this.btnCargarP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargarP.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnNuevo.Location = new System.Drawing.Point(134, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(103, 147);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCerrarMP
            // 
            this.btnCerrarMP.BackColor = System.Drawing.Color.Red;
            this.btnCerrarMP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarMP.ForeColor = System.Drawing.Color.Black;
            this.btnCerrarMP.Location = new System.Drawing.Point(243, 64);
            this.btnCerrarMP.Name = "btnCerrarMP";
            this.btnCerrarMP.Size = new System.Drawing.Size(106, 36);
            this.btnCerrarMP.TabIndex = 10;
            this.btnCerrarMP.Text = "Cerrar";
            this.btnCerrarMP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrarMP.UseVisualStyleBackColor = false;
            // 
            // MenuProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(363, 171);
            this.Controls.Add(this.btnCerrarMP);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCargarP);
            this.Name = "MenuProductos";
            this.Text = "Menu Productos";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCargarP;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrarMP;
    }
}