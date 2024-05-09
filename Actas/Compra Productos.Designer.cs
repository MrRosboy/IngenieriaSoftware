namespace Actas
{
    partial class Compra_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compra_Productos));
            this.cbxProductoComPro = new System.Windows.Forms.ComboBox();
            this.cbxProvComPro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flCompraPro = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnComprarPro = new System.Windows.Forms.Button();
            this.btnLimpiarPro = new System.Windows.Forms.Button();
            this.dvgCarrito = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flCompraPro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxProductoComPro
            // 
            this.cbxProductoComPro.FormattingEnabled = true;
            this.cbxProductoComPro.Location = new System.Drawing.Point(31, 159);
            this.cbxProductoComPro.Name = "cbxProductoComPro";
            this.cbxProductoComPro.Size = new System.Drawing.Size(300, 24);
            this.cbxProductoComPro.TabIndex = 0;
            this.cbxProductoComPro.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // cbxProvComPro
            // 
            this.cbxProvComPro.FormattingEnabled = true;
            this.cbxProvComPro.Location = new System.Drawing.Point(31, 240);
            this.cbxProvComPro.Name = "cbxProvComPro";
            this.cbxProvComPro.Size = new System.Drawing.Size(300, 24);
            this.cbxProvComPro.TabIndex = 1;
            this.cbxProvComPro.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Proveedor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-25, -40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 170);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // flCompraPro
            // 
            this.flCompraPro.AutoScroll = true;
            this.flCompraPro.AutoSize = true;
            this.flCompraPro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flCompraPro.Controls.Add(this.pictureBox2);
            this.flCompraPro.Controls.Add(this.button1);
            this.flCompraPro.Controls.Add(this.textBox1);
            this.flCompraPro.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flCompraPro.Location = new System.Drawing.Point(627, 106);
            this.flCompraPro.Name = "flCompraPro";
            this.flCompraPro.Size = new System.Drawing.Size(383, 365);
            this.flCompraPro.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(187, 105);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 94);
            this.label3.TabIndex = 15;
            this.label3.Text = "COMPRAS";
            // 
            // btnComprarPro
            // 
            this.btnComprarPro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprarPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprarPro.Location = new System.Drawing.Point(12, 554);
            this.btnComprarPro.Name = "btnComprarPro";
            this.btnComprarPro.Size = new System.Drawing.Size(138, 33);
            this.btnComprarPro.TabIndex = 16;
            this.btnComprarPro.Text = "Comprar";
            this.btnComprarPro.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarPro
            // 
            this.btnLimpiarPro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarPro.Location = new System.Drawing.Point(193, 554);
            this.btnLimpiarPro.Name = "btnLimpiarPro";
            this.btnLimpiarPro.Size = new System.Drawing.Size(138, 33);
            this.btnLimpiarPro.TabIndex = 17;
            this.btnLimpiarPro.Text = "Limpiar ";
            this.btnLimpiarPro.UseVisualStyleBackColor = true;
            // 
            // dvgCarrito
            // 
            this.dvgCarrito.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dvgCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCarrito.Location = new System.Drawing.Point(31, 301);
            this.dvgCarrito.Name = "dvgCarrito";
            this.dvgCarrito.RowHeadersWidth = 51;
            this.dvgCarrito.RowTemplate.Height = 24;
            this.dvgCarrito.Size = new System.Drawing.Size(232, 204);
            this.dvgCarrito.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(57, 22);
            this.textBox1.TabIndex = 2;
            // 
            // Compra_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 628);
            this.Controls.Add(this.dvgCarrito);
            this.Controls.Add(this.btnLimpiarPro);
            this.Controls.Add(this.btnComprarPro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flCompraPro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxProvComPro);
            this.Controls.Add(this.cbxProductoComPro);
            this.Name = "Compra_Productos";
            this.Text = "Compra_Productos";
            this.Load += new System.EventHandler(this.Compra_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flCompraPro.ResumeLayout(false);
            this.flCompraPro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxProductoComPro;
        private System.Windows.Forms.ComboBox cbxProvComPro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flCompraPro;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnComprarPro;
        private System.Windows.Forms.Button btnLimpiarPro;
        private System.Windows.Forms.DataGridView dvgCarrito;
        private System.Windows.Forms.TextBox textBox1;
    }
}