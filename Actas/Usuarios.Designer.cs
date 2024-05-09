namespace Actas
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.btnEliminarUsuarios = new System.Windows.Forms.Button();
            this.btnActuUsuarios = new System.Windows.Forms.Button();
            this.btnCrearUsuarios = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxRolUsuarios = new System.Windows.Forms.ComboBox();
            this.txtCorreoUsu = new System.Windows.Forms.TextBox();
            this.txtContUsu = new System.Windows.Forms.TextBox();
            this.lblDescRoles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.cbxEstatusUs = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxNomUsu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarUsuarios
            // 
            this.btnEliminarUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuarios.Location = new System.Drawing.Point(356, 516);
            this.btnEliminarUsuarios.Name = "btnEliminarUsuarios";
            this.btnEliminarUsuarios.Size = new System.Drawing.Size(138, 33);
            this.btnEliminarUsuarios.TabIndex = 15;
            this.btnEliminarUsuarios.Text = "Eliminar";
            this.btnEliminarUsuarios.UseVisualStyleBackColor = true;
            this.btnEliminarUsuarios.Click += new System.EventHandler(this.btnEliminarUsuarios_Click);
            // 
            // btnActuUsuarios
            // 
            this.btnActuUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActuUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActuUsuarios.Location = new System.Drawing.Point(187, 516);
            this.btnActuUsuarios.Name = "btnActuUsuarios";
            this.btnActuUsuarios.Size = new System.Drawing.Size(138, 33);
            this.btnActuUsuarios.TabIndex = 14;
            this.btnActuUsuarios.Text = "Actualizar ";
            this.btnActuUsuarios.UseVisualStyleBackColor = true;
            this.btnActuUsuarios.Click += new System.EventHandler(this.btnActuUsuarios_Click);
            // 
            // btnCrearUsuarios
            // 
            this.btnCrearUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUsuarios.Location = new System.Drawing.Point(19, 516);
            this.btnCrearUsuarios.Name = "btnCrearUsuarios";
            this.btnCrearUsuarios.Size = new System.Drawing.Size(138, 33);
            this.btnCrearUsuarios.TabIndex = 13;
            this.btnCrearUsuarios.Text = "Crear";
            this.btnCrearUsuarios.UseVisualStyleBackColor = true;
            this.btnCrearUsuarios.Click += new System.EventHandler(this.btnCrearUsuarios_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-25, -40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 170);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cbxRolUsuarios
            // 
            this.cbxRolUsuarios.FormattingEnabled = true;
            this.cbxRolUsuarios.Location = new System.Drawing.Point(84, 346);
            this.cbxRolUsuarios.Name = "cbxRolUsuarios";
            this.cbxRolUsuarios.Size = new System.Drawing.Size(300, 24);
            this.cbxRolUsuarios.TabIndex = 18;
            this.cbxRolUsuarios.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // txtCorreoUsu
            // 
            this.txtCorreoUsu.Location = new System.Drawing.Point(84, 282);
            this.txtCorreoUsu.Name = "txtCorreoUsu";
            this.txtCorreoUsu.Size = new System.Drawing.Size(300, 22);
            this.txtCorreoUsu.TabIndex = 21;
            this.txtCorreoUsu.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // txtContUsu
            // 
            this.txtContUsu.Location = new System.Drawing.Point(84, 215);
            this.txtContUsu.Name = "txtContUsu";
            this.txtContUsu.PasswordChar = '*';
            this.txtContUsu.Size = new System.Drawing.Size(300, 22);
            this.txtContUsu.TabIndex = 22;
            this.txtContUsu.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // lblDescRoles
            // 
            this.lblDescRoles.AutoSize = true;
            this.lblDescRoles.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescRoles.Location = new System.Drawing.Point(79, 117);
            this.lblDescRoles.Name = "lblDescRoles";
            this.lblDescRoles.Size = new System.Drawing.Size(84, 27);
            this.lblDescRoles.TabIndex = 26;
            this.lblDescRoles.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 27);
            this.label1.TabIndex = 27;
            this.label1.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 27);
            this.label2.TabIndex = 28;
            this.label2.Text = "Rol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 27);
            this.label3.TabIndex = 29;
            this.label3.Text = "Contraseña";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(425, 123);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(708, 359);
            this.dgvUsuarios.TabIndex = 30;
            // 
            // cbxEstatusUs
            // 
            this.cbxEstatusUs.FormattingEnabled = true;
            this.cbxEstatusUs.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cbxEstatusUs.Location = new System.Drawing.Point(84, 417);
            this.cbxEstatusUs.Name = "cbxEstatusUs";
            this.cbxEstatusUs.Size = new System.Drawing.Size(300, 24);
            this.cbxEstatusUs.TabIndex = 31;
            this.cbxEstatusUs.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 27);
            this.label4.TabIndex = 32;
            this.label4.Text = "Estatus";
            // 
            // cbxNomUsu
            // 
            this.cbxNomUsu.FormattingEnabled = true;
            this.cbxNomUsu.Location = new System.Drawing.Point(84, 158);
            this.cbxNomUsu.Name = "cbxNomUsu";
            this.cbxNomUsu.Size = new System.Drawing.Size(300, 24);
            this.cbxNomUsu.TabIndex = 33;
            this.cbxNomUsu.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(368, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(385, 94);
            this.label5.TabIndex = 34;
            this.label5.Text = "USUARIOS";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(287, 243);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 20);
            this.checkBox1.TabIndex = 35;
            this.checkBox1.Text = "MOSTRAR";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 628);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxNomUsu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxEstatusUs);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescRoles);
            this.Controls.Add(this.txtContUsu);
            this.Controls.Add(this.txtCorreoUsu);
            this.Controls.Add(this.cbxRolUsuarios);
            this.Controls.Add(this.btnEliminarUsuarios);
            this.Controls.Add(this.btnActuUsuarios);
            this.Controls.Add(this.btnCrearUsuarios);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminarUsuarios;
        private System.Windows.Forms.Button btnActuUsuarios;
        private System.Windows.Forms.Button btnCrearUsuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbxRolUsuarios;
        private System.Windows.Forms.TextBox txtCorreoUsu;
        private System.Windows.Forms.TextBox txtContUsu;
        private System.Windows.Forms.Label lblDescRoles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.ComboBox cbxEstatusUs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxNomUsu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}