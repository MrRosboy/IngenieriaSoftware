
namespace Actas
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.cbxDescCategorias = new System.Windows.Forms.ComboBox();
            this.lblDescRoles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecioVen = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCrearProductos = new System.Windows.Forms.Button();
            this.btnActualizarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.cmbNombrePro = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxDescCategorias
            // 
            this.cbxDescCategorias.FormattingEnabled = true;
            this.cbxDescCategorias.Location = new System.Drawing.Point(41, 74);
            this.cbxDescCategorias.Name = "cbxDescCategorias";
            this.cbxDescCategorias.Size = new System.Drawing.Size(160, 24);
            this.cbxDescCategorias.TabIndex = 17;
            this.cbxDescCategorias.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // lblDescRoles
            // 
            this.lblDescRoles.AutoSize = true;
            this.lblDescRoles.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescRoles.Location = new System.Drawing.Point(37, 48);
            this.lblDescRoles.Name = "lblDescRoles";
            this.lblDescRoles.Size = new System.Drawing.Size(92, 23);
            this.lblDescRoles.TabIndex = 16;
            this.lblDescRoles.Text = "Categorias";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Precio de venta";
            // 
            // txtPrecioVen
            // 
            this.txtPrecioVen.Location = new System.Drawing.Point(41, 208);
            this.txtPrecioVen.Name = "txtPrecioVen";
            this.txtPrecioVen.Size = new System.Drawing.Size(160, 22);
            this.txtPrecioVen.TabIndex = 23;
            this.txtPrecioVen.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // dgvProductos
            // 
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(271, 48);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(599, 287);
            this.dgvProductos.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 25;
            // 
            // btnCrearProductos
            // 
            this.btnCrearProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearProductos.Location = new System.Drawing.Point(32, 373);
            this.btnCrearProductos.Name = "btnCrearProductos";
            this.btnCrearProductos.Size = new System.Drawing.Size(138, 33);
            this.btnCrearProductos.TabIndex = 26;
            this.btnCrearProductos.Text = "Crear";
            this.btnCrearProductos.UseVisualStyleBackColor = true;
            this.btnCrearProductos.Click += new System.EventHandler(this.btnCrearRoles_Click);
            // 
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProducto.Location = new System.Drawing.Point(200, 373);
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            this.btnActualizarProducto.Size = new System.Drawing.Size(138, 33);
            this.btnActualizarProducto.TabIndex = 27;
            this.btnActualizarProducto.Text = "Actualizar";
            this.btnActualizarProducto.UseVisualStyleBackColor = true;
            this.btnActualizarProducto.Click += new System.EventHandler(this.btnActualizarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.Location = new System.Drawing.Point(372, 373);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(138, 33);
            this.btnEliminarProducto.TabIndex = 28;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbNombrePro
            // 
            this.cmbNombrePro.FormattingEnabled = true;
            this.cmbNombrePro.Location = new System.Drawing.Point(41, 142);
            this.cmbNombrePro.Name = "cmbNombrePro";
            this.cmbNombrePro.Size = new System.Drawing.Size(160, 24);
            this.cmbNombrePro.TabIndex = 29;
            this.cmbNombrePro.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            this.cmbNombrePro.Leave += new System.EventHandler(this.cmbNombrePro_Leave_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(635, 272);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 268);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 450);
            this.Controls.Add(this.cmbNombrePro);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnActualizarProducto);
            this.Controls.Add(this.btnCrearProductos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.txtPrecioVen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxDescCategorias);
            this.Controls.Add(this.lblDescRoles);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Productos";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxDescCategorias;
        private System.Windows.Forms.Label lblDescRoles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecioVen;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCrearProductos;
        private System.Windows.Forms.Button btnActualizarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.ComboBox cmbNombrePro;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}