namespace Actas
{
    partial class Roles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roles));
            this.btnEliminarRoles = new System.Windows.Forms.Button();
            this.btnActuRoles = new System.Windows.Forms.Button();
            this.btnCrearRoles = new System.Windows.Forms.Button();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.lblDescRoles = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEstatusRoles = new System.Windows.Forms.Label();
            this.cbxEstRoles = new System.Windows.Forms.ComboBox();
            this.cbxDescRoles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarRoles
            // 
            this.btnEliminarRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRoles.Location = new System.Drawing.Point(355, 558);
            this.btnEliminarRoles.Name = "btnEliminarRoles";
            this.btnEliminarRoles.Size = new System.Drawing.Size(138, 33);
            this.btnEliminarRoles.TabIndex = 8;
            this.btnEliminarRoles.Text = "Eliminar";
            this.btnEliminarRoles.UseVisualStyleBackColor = true;
            this.btnEliminarRoles.Click += new System.EventHandler(this.btnEliminarRoles_Click);
            // 
            // btnActuRoles
            // 
            this.btnActuRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActuRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActuRoles.Location = new System.Drawing.Point(186, 558);
            this.btnActuRoles.Name = "btnActuRoles";
            this.btnActuRoles.Size = new System.Drawing.Size(138, 33);
            this.btnActuRoles.TabIndex = 7;
            this.btnActuRoles.Text = "Actualizar ";
            this.btnActuRoles.UseVisualStyleBackColor = true;
            this.btnActuRoles.Click += new System.EventHandler(this.btnActuRoles_Click);
            // 
            // btnCrearRoles
            // 
            this.btnCrearRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearRoles.Location = new System.Drawing.Point(18, 558);
            this.btnCrearRoles.Name = "btnCrearRoles";
            this.btnCrearRoles.Size = new System.Drawing.Size(138, 33);
            this.btnCrearRoles.TabIndex = 6;
            this.btnCrearRoles.Text = "Crear";
            this.btnCrearRoles.UseVisualStyleBackColor = true;
            this.btnCrearRoles.Click += new System.EventHandler(this.btnCrearRoles_Click);
            // 
            // dgvRoles
            // 
            this.dgvRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoles.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(387, 146);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.RowHeadersWidth = 51;
            this.dgvRoles.RowTemplate.Height = 24;
            this.dgvRoles.Size = new System.Drawing.Size(726, 346);
            this.dgvRoles.TabIndex = 5;
            // 
            // lblDescRoles
            // 
            this.lblDescRoles.AutoSize = true;
            this.lblDescRoles.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescRoles.Location = new System.Drawing.Point(20, 141);
            this.lblDescRoles.Name = "lblDescRoles";
            this.lblDescRoles.Size = new System.Drawing.Size(121, 27);
            this.lblDescRoles.TabIndex = 11;
            this.lblDescRoles.Text = "Descripcion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-25, -40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 170);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblEstatusRoles
            // 
            this.lblEstatusRoles.AutoSize = true;
            this.lblEstatusRoles.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusRoles.Location = new System.Drawing.Point(20, 224);
            this.lblEstatusRoles.Name = "lblEstatusRoles";
            this.lblEstatusRoles.Size = new System.Drawing.Size(79, 27);
            this.lblEstatusRoles.TabIndex = 13;
            this.lblEstatusRoles.Text = "Estatus";
            // 
            // cbxEstRoles
            // 
            this.cbxEstRoles.FormattingEnabled = true;
            this.cbxEstRoles.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cbxEstRoles.Location = new System.Drawing.Point(24, 254);
            this.cbxEstRoles.Name = "cbxEstRoles";
            this.cbxEstRoles.Size = new System.Drawing.Size(300, 24);
            this.cbxEstRoles.TabIndex = 14;
            this.cbxEstRoles.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // cbxDescRoles
            // 
            this.cbxDescRoles.FormattingEnabled = true;
            this.cbxDescRoles.Location = new System.Drawing.Point(24, 173);
            this.cbxDescRoles.Name = "cbxDescRoles";
            this.cbxDescRoles.Size = new System.Drawing.Size(300, 24);
            this.cbxDescRoles.TabIndex = 15;
            this.cbxDescRoles.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 94);
            this.label1.TabIndex = 17;
            this.label1.Text = "ROLES";
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 628);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxDescRoles);
            this.Controls.Add(this.cbxEstRoles);
            this.Controls.Add(this.lblEstatusRoles);
            this.Controls.Add(this.lblDescRoles);
            this.Controls.Add(this.btnEliminarRoles);
            this.Controls.Add(this.btnActuRoles);
            this.Controls.Add(this.btnCrearRoles);
            this.Controls.Add(this.dgvRoles);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Roles";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.Roles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminarRoles;
        private System.Windows.Forms.Button btnActuRoles;
        private System.Windows.Forms.Button btnCrearRoles;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.Label lblDescRoles;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEstatusRoles;
        private System.Windows.Forms.ComboBox cbxEstRoles;
        private System.Windows.Forms.ComboBox cbxDescRoles;
        private System.Windows.Forms.Label label1;
    }
}