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
            this.btnMostrarUsuarios = new System.Windows.Forms.Button();
            this.btnEliminarUsuarios = new System.Windows.Forms.Button();
            this.btnActuUsuarios = new System.Windows.Forms.Button();
            this.btnCrearUsuarios = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxRolUsuarios = new System.Windows.Forms.ComboBox();
            this.txtNombreUsu = new System.Windows.Forms.TextBox();
            this.txtCorreoUsu = new System.Windows.Forms.TextBox();
            this.txtContUsu = new System.Windows.Forms.TextBox();
            this.lblDescRoles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.cbxEstatusUs = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarUsuarios
            // 
            this.btnMostrarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarUsuarios.Location = new System.Drawing.Point(510, 514);
            this.btnMostrarUsuarios.Name = "btnMostrarUsuarios";
            this.btnMostrarUsuarios.Size = new System.Drawing.Size(138, 33);
            this.btnMostrarUsuarios.TabIndex = 16;
            this.btnMostrarUsuarios.Text = "Mostrar";
            this.btnMostrarUsuarios.UseVisualStyleBackColor = true;
            this.btnMostrarUsuarios.Click += new System.EventHandler(this.btnMostrarUsuarios_Click);
            // 
            // btnEliminarUsuarios
            // 
            this.btnEliminarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuarios.Location = new System.Drawing.Point(350, 514);
            this.btnEliminarUsuarios.Name = "btnEliminarUsuarios";
            this.btnEliminarUsuarios.Size = new System.Drawing.Size(138, 33);
            this.btnEliminarUsuarios.TabIndex = 15;
            this.btnEliminarUsuarios.Text = "Eliminar";
            this.btnEliminarUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnActuUsuarios
            // 
            this.btnActuUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActuUsuarios.Location = new System.Drawing.Point(181, 514);
            this.btnActuUsuarios.Name = "btnActuUsuarios";
            this.btnActuUsuarios.Size = new System.Drawing.Size(138, 33);
            this.btnActuUsuarios.TabIndex = 14;
            this.btnActuUsuarios.Text = "Actualizar ";
            this.btnActuUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnCrearUsuarios
            // 
            this.btnCrearUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUsuarios.Location = new System.Drawing.Point(13, 514);
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
            this.pictureBox1.Location = new System.Drawing.Point(931, 398);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 268);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // cbxRolUsuarios
            // 
            this.cbxRolUsuarios.FormattingEnabled = true;
            this.cbxRolUsuarios.Location = new System.Drawing.Point(121, 172);
            this.cbxRolUsuarios.Name = "cbxRolUsuarios";
            this.cbxRolUsuarios.Size = new System.Drawing.Size(146, 24);
            this.cbxRolUsuarios.TabIndex = 18;
            // 
            // txtNombreUsu
            // 
            this.txtNombreUsu.Location = new System.Drawing.Point(121, 45);
            this.txtNombreUsu.Name = "txtNombreUsu";
            this.txtNombreUsu.Size = new System.Drawing.Size(146, 22);
            this.txtNombreUsu.TabIndex = 20;
            // 
            // txtCorreoUsu
            // 
            this.txtCorreoUsu.Location = new System.Drawing.Point(121, 129);
            this.txtCorreoUsu.Name = "txtCorreoUsu";
            this.txtCorreoUsu.Size = new System.Drawing.Size(146, 22);
            this.txtCorreoUsu.TabIndex = 21;
            // 
            // txtContUsu
            // 
            this.txtContUsu.Location = new System.Drawing.Point(121, 84);
            this.txtContUsu.Name = "txtContUsu";
            this.txtContUsu.Size = new System.Drawing.Size(146, 22);
            this.txtContUsu.TabIndex = 22;
            this.txtContUsu.UseSystemPasswordChar = true;
            // 
            // lblDescRoles
            // 
            this.lblDescRoles.AutoSize = true;
            this.lblDescRoles.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescRoles.Location = new System.Drawing.Point(21, 43);
            this.lblDescRoles.Name = "lblDescRoles";
            this.lblDescRoles.Size = new System.Drawing.Size(71, 24);
            this.lblDescRoles.TabIndex = 26;
            this.lblDescRoles.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Rol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Contraseña";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(287, 12);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(827, 442);
            this.dgvUsuarios.TabIndex = 30;
            // 
            // cbxEstatusUs
            // 
            this.cbxEstatusUs.FormattingEnabled = true;
            this.cbxEstatusUs.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cbxEstatusUs.Location = new System.Drawing.Point(121, 213);
            this.cbxEstatusUs.Name = "cbxEstatusUs";
            this.cbxEstatusUs.Size = new System.Drawing.Size(146, 24);
            this.cbxEstatusUs.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "Estatus";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1126, 599);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxEstatusUs);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescRoles);
            this.Controls.Add(this.txtContUsu);
            this.Controls.Add(this.txtCorreoUsu);
            this.Controls.Add(this.txtNombreUsu);
            this.Controls.Add(this.cbxRolUsuarios);
            this.Controls.Add(this.btnMostrarUsuarios);
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

        private System.Windows.Forms.Button btnMostrarUsuarios;
        private System.Windows.Forms.Button btnEliminarUsuarios;
        private System.Windows.Forms.Button btnActuUsuarios;
        private System.Windows.Forms.Button btnCrearUsuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbxRolUsuarios;
        private System.Windows.Forms.TextBox txtNombreUsu;
        private System.Windows.Forms.TextBox txtCorreoUsu;
        private System.Windows.Forms.TextBox txtContUsu;
        private System.Windows.Forms.Label lblDescRoles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.ComboBox cbxEstatusUs;
        private System.Windows.Forms.Label label4;
    }
}