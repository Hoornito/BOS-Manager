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
            btnRoles = new FontAwesome.Sharp.IconButton();
            btnUsuarios = new FontAwesome.Sharp.IconButton();
            panel1 = new System.Windows.Forms.Panel();
            btn_GenerarBackUp = new FontAwesome.Sharp.IconButton();
            btn_Bitacora = new FontAwesome.Sharp.IconButton();
            btn_CrearUsuario = new FontAwesome.Sharp.IconButton();
            panelAdmin = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRoles
            // 
            btnRoles.FlatAppearance.BorderSize = 0;
            btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRoles.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnRoles.IconChar = FontAwesome.Sharp.IconChar.ThList;
            btnRoles.IconColor = System.Drawing.SystemColors.ButtonFace;
            btnRoles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRoles.Location = new System.Drawing.Point(12, 3);
            btnRoles.Name = "btnRoles";
            btnRoles.Size = new System.Drawing.Size(106, 103);
            btnRoles.TabIndex = 0;
            btnRoles.Text = "Administración de roles";
            btnRoles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnRoles.UseVisualStyleBackColor = true;
            btnRoles.Click += btnRoles_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUsuarios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            btnUsuarios.IconColor = System.Drawing.SystemColors.ButtonFace;
            btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuarios.Location = new System.Drawing.Point(12, 112);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new System.Drawing.Size(106, 103);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Administración de usuarios";
            btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_GenerarBackUp);
            panel1.Controls.Add(btn_Bitacora);
            panel1.Controls.Add(btn_CrearUsuario);
            panel1.Controls.Add(btnRoles);
            panel1.Controls.Add(btnUsuarios);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(131, 562);
            panel1.TabIndex = 2;
            // 
            // btn_GenerarBackUp
            // 
            btn_GenerarBackUp.FlatAppearance.BorderSize = 0;
            btn_GenerarBackUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_GenerarBackUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btn_GenerarBackUp.IconChar = FontAwesome.Sharp.IconChar.Database;
            btn_GenerarBackUp.IconColor = System.Drawing.SystemColors.ButtonFace;
            btn_GenerarBackUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_GenerarBackUp.Location = new System.Drawing.Point(12, 439);
            btn_GenerarBackUp.Name = "btn_GenerarBackUp";
            btn_GenerarBackUp.Size = new System.Drawing.Size(106, 103);
            btn_GenerarBackUp.TabIndex = 4;
            btn_GenerarBackUp.Text = "Back up";
            btn_GenerarBackUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btn_GenerarBackUp.UseVisualStyleBackColor = true;
            btn_GenerarBackUp.Click += btn_GenerarBackUp_Click;
            // 
            // btn_Bitacora
            // 
            btn_Bitacora.FlatAppearance.BorderSize = 0;
            btn_Bitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Bitacora.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btn_Bitacora.IconChar = FontAwesome.Sharp.IconChar.Book;
            btn_Bitacora.IconColor = System.Drawing.SystemColors.ButtonFace;
            btn_Bitacora.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Bitacora.Location = new System.Drawing.Point(12, 330);
            btn_Bitacora.Name = "btn_Bitacora";
            btn_Bitacora.Size = new System.Drawing.Size(106, 103);
            btn_Bitacora.TabIndex = 3;
            btn_Bitacora.Text = "Bitácora";
            btn_Bitacora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btn_Bitacora.UseVisualStyleBackColor = true;
            btn_Bitacora.Click += btn_Bitacora_Click;
            // 
            // btn_CrearUsuario
            // 
            btn_CrearUsuario.FlatAppearance.BorderSize = 0;
            btn_CrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_CrearUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btn_CrearUsuario.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            btn_CrearUsuario.IconColor = System.Drawing.SystemColors.ButtonFace;
            btn_CrearUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_CrearUsuario.Location = new System.Drawing.Point(12, 221);
            btn_CrearUsuario.Name = "btn_CrearUsuario";
            btn_CrearUsuario.Size = new System.Drawing.Size(106, 103);
            btn_CrearUsuario.TabIndex = 2;
            btn_CrearUsuario.Text = "Creación de usuarios";
            btn_CrearUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btn_CrearUsuario.UseVisualStyleBackColor = true;
            btn_CrearUsuario.Click += btn_CrearUsuario_Click;
            // 
            // panelAdmin
            // 
            panelAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            panelAdmin.Location = new System.Drawing.Point(131, 0);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new System.Drawing.Size(720, 562);
            panelAdmin.TabIndex = 3;
            // 
            // AdministracionForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(129, 136, 205);
            ClientSize = new System.Drawing.Size(851, 562);
            Controls.Add(panelAdmin);
            Controls.Add(panel1);
            Name = "AdministracionForm";
            Text = "Administración";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnRoles;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelAdmin;
        private FontAwesome.Sharp.IconButton btn_CrearUsuario;
        private FontAwesome.Sharp.IconButton btn_GenerarBackUp;
        private FontAwesome.Sharp.IconButton btn_Bitacora;
    }
}