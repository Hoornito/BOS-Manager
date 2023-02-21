namespace UI.ChildForms.Composite
{
    partial class AdministracionForm
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
            this.btnRoles = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.btn_CrearUsuario = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRoles
            // 
            this.btnRoles.FlatAppearance.BorderSize = 0;
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRoles.IconChar = FontAwesome.Sharp.IconChar.ThList;
            this.btnRoles.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRoles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRoles.Location = new System.Drawing.Point(12, 3);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(106, 103);
            this.btnRoles.TabIndex = 0;
            this.btnRoles.Text = "Administración de roles";
            this.btnRoles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btnUsuarios.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.Location = new System.Drawing.Point(12, 112);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(106, 103);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Administración de usuarios";
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_CrearUsuario);
            this.panel1.Controls.Add(this.btnRoles);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 468);
            this.panel1.TabIndex = 2;
            // 
            // panelAdmin
            // 
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdmin.Location = new System.Drawing.Point(131, 0);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(671, 468);
            this.panelAdmin.TabIndex = 3;
            // 
            // btn_CrearUsuario
            // 
            this.btn_CrearUsuario.FlatAppearance.BorderSize = 0;
            this.btn_CrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CrearUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_CrearUsuario.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btn_CrearUsuario.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_CrearUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CrearUsuario.Location = new System.Drawing.Point(12, 221);
            this.btn_CrearUsuario.Name = "btn_CrearUsuario";
            this.btn_CrearUsuario.Size = new System.Drawing.Size(106, 103);
            this.btn_CrearUsuario.TabIndex = 2;
            this.btn_CrearUsuario.Text = "Creación de usuarios";
            this.btn_CrearUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_CrearUsuario.UseVisualStyleBackColor = true;
            this.btn_CrearUsuario.Click += new System.EventHandler(this.btn_CrearUsuario_Click);
            // 
            // AdministracionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(136)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(802, 468);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.panel1);
            this.Name = "AdministracionForm";
            this.Text = "AdministracionForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnRoles;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelAdmin;
        private FontAwesome.Sharp.IconButton btn_CrearUsuario;
    }
}