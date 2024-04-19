namespace Actas
{
    partial class Proveedores2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores2));
            this.btnCrearProv = new System.Windows.Forms.Button();
            this.btnActProv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.cbxEst = new System.Windows.Forms.ComboBox();
            this.cbxNom = new System.Windows.Forms.ComboBox();
            this.dgvProv = new System.Windows.Forms.DataGridView();
            this.btnELimProv = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearProv
            // 
            this.btnCrearProv.BackColor = System.Drawing.Color.White;
            this.btnCrearProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearProv.Location = new System.Drawing.Point(38, 350);
            this.btnCrearProv.Name = "btnCrearProv";
            this.btnCrearProv.Size = new System.Drawing.Size(98, 37);
            this.btnCrearProv.TabIndex = 0;
            this.btnCrearProv.Text = "Crear";
            this.btnCrearProv.UseVisualStyleBackColor = false;
            this.btnCrearProv.Click += new System.EventHandler(this.btnCrearProv_Click);
            // 
            // btnActProv
            // 
            this.btnActProv.BackColor = System.Drawing.Color.White;
            this.btnActProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActProv.Location = new System.Drawing.Point(166, 350);
            this.btnActProv.Name = "btnActProv";
            this.btnActProv.Size = new System.Drawing.Size(130, 37);
            this.btnActProv.TabIndex = 1;
            this.btnActProv.Text = "Actualizar";
            this.btnActProv.UseVisualStyleBackColor = false;
            this.btnActProv.Click += new System.EventHandler(this.btnActProv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dirección";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descripción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Estatus";
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(136, 105);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(121, 22);
            this.txtDir.TabIndex = 8;
            this.txtDir.TextChanged += new System.EventHandler(this.ComboBox_TextChangedP);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(136, 151);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(121, 22);
            this.txtTel.TabIndex = 9;
            this.txtTel.TextChanged += new System.EventHandler(this.ComboBox_TextChangedP);
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(136, 196);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(121, 22);
            this.txtDes.TabIndex = 10;
            this.txtDes.TextChanged += new System.EventHandler(this.ComboBox_TextChangedP);
            // 
            // cbxEst
            // 
            this.cbxEst.FormattingEnabled = true;
            this.cbxEst.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cbxEst.Location = new System.Drawing.Point(136, 233);
            this.cbxEst.Name = "cbxEst";
            this.cbxEst.Size = new System.Drawing.Size(121, 24);
            this.cbxEst.TabIndex = 11;
            this.cbxEst.SelectedIndexChanged += new System.EventHandler(this.cbxEst_SelectedIndexChanged);
            this.cbxEst.TextChanged += new System.EventHandler(this.ComboBox_TextChangedP);
            // 
            // cbxNom
            // 
            this.cbxNom.FormattingEnabled = true;
            this.cbxNom.Location = new System.Drawing.Point(136, 62);
            this.cbxNom.Name = "cbxNom";
            this.cbxNom.Size = new System.Drawing.Size(121, 24);
            this.cbxNom.TabIndex = 12;
            this.cbxNom.TextChanged += new System.EventHandler(this.ComboBox_TextChangedP);
            // 
            // dgvProv
            // 
            this.dgvProv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProv.Location = new System.Drawing.Point(298, 50);
            this.dgvProv.Name = "dgvProv";
            this.dgvProv.RowHeadersWidth = 51;
            this.dgvProv.RowTemplate.Height = 24;
            this.dgvProv.Size = new System.Drawing.Size(788, 227);
            this.dgvProv.TabIndex = 13;
            // 
            // btnELimProv
            // 
            this.btnELimProv.BackColor = System.Drawing.Color.White;
            this.btnELimProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnELimProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnELimProv.Location = new System.Drawing.Point(314, 350);
            this.btnELimProv.Name = "btnELimProv";
            this.btnELimProv.Size = new System.Drawing.Size(130, 37);
            this.btnELimProv.TabIndex = 14;
            this.btnELimProv.Text = "Eliminar ";
            this.btnELimProv.UseVisualStyleBackColor = false;
            this.btnELimProv.Click += new System.EventHandler(this.btnELimProv_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(929, 292);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 268);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Proveedores2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1126, 480);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnELimProv);
            this.Controls.Add(this.dgvProv);
            this.Controls.Add(this.cbxNom);
            this.Controls.Add(this.cbxEst);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActProv);
            this.Controls.Add(this.btnCrearProv);
            this.Name = "Proveedores2";
            this.Text = "Proveedores2";
            this.Load += new System.EventHandler(this.Proveedores2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearProv;
        private System.Windows.Forms.Button btnActProv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.ComboBox cbxEst;
        private System.Windows.Forms.ComboBox cbxNom;
        private System.Windows.Forms.DataGridView dgvProv;
        private System.Windows.Forms.Button btnELimProv;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}