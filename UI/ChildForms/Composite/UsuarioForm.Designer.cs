namespace UI.ChildForms.Composite
{
    partial class UsuarioForm
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
            label1 = new System.Windows.Forms.Label();
            cb_Usuario = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            cb_Permisos = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            cb_Familia = new System.Windows.Forms.ComboBox();
            btn_ConfigurarUsuario = new System.Windows.Forms.Button();
            treeView1 = new System.Windows.Forms.TreeView();
            btn_AgregarPermiso = new System.Windows.Forms.Button();
            btn_AgregarFamilia = new System.Windows.Forms.Button();
            btn_Guardar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label1.Location = new System.Drawing.Point(38, 59);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Seleccionar usuario";
            // 
            // cb_Usuario
            // 
            cb_Usuario.FormattingEnabled = true;
            cb_Usuario.Location = new System.Drawing.Point(153, 56);
            cb_Usuario.Name = "cb_Usuario";
            cb_Usuario.Size = new System.Drawing.Size(121, 23);
            cb_Usuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label2.Location = new System.Drawing.Point(38, 128);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 15);
            label2.TabIndex = 2;
            label2.Text = "Agregar permisos";
            // 
            // cb_Permisos
            // 
            cb_Permisos.FormattingEnabled = true;
            cb_Permisos.Location = new System.Drawing.Point(153, 125);
            cb_Permisos.Name = "cb_Permisos";
            cb_Permisos.Size = new System.Drawing.Size(121, 23);
            cb_Permisos.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label3.Location = new System.Drawing.Point(38, 193);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(84, 15);
            label3.TabIndex = 4;
            label3.Text = "Agregar grupo";
            // 
            // cb_Familia
            // 
            cb_Familia.FormattingEnabled = true;
            cb_Familia.Location = new System.Drawing.Point(153, 190);
            cb_Familia.Name = "cb_Familia";
            cb_Familia.Size = new System.Drawing.Size(121, 23);
            cb_Familia.TabIndex = 5;
            // 
            // btn_ConfigurarUsuario
            // 
            btn_ConfigurarUsuario.Location = new System.Drawing.Point(294, 56);
            btn_ConfigurarUsuario.Name = "btn_ConfigurarUsuario";
            btn_ConfigurarUsuario.Size = new System.Drawing.Size(75, 23);
            btn_ConfigurarUsuario.TabIndex = 6;
            btn_ConfigurarUsuario.Text = "Configurar";
            btn_ConfigurarUsuario.UseVisualStyleBackColor = true;
            btn_ConfigurarUsuario.Click += btn_ConfigurarUsuario_Click;
            // 
            // treeView1
            // 
            treeView1.Location = new System.Drawing.Point(440, 48);
            treeView1.Name = "treeView1";
            treeView1.Size = new System.Drawing.Size(294, 292);
            treeView1.TabIndex = 7;
            treeView1.MouseClick += treeView1_MouseClick;
            // 
            // btn_AgregarPermiso
            // 
            btn_AgregarPermiso.Location = new System.Drawing.Point(294, 125);
            btn_AgregarPermiso.Name = "btn_AgregarPermiso";
            btn_AgregarPermiso.Size = new System.Drawing.Size(75, 23);
            btn_AgregarPermiso.TabIndex = 8;
            btn_AgregarPermiso.Text = "Agregar";
            btn_AgregarPermiso.UseVisualStyleBackColor = true;
            btn_AgregarPermiso.Click += btn_AgregarPermiso_Click;
            // 
            // btn_AgregarFamilia
            // 
            btn_AgregarFamilia.Location = new System.Drawing.Point(294, 190);
            btn_AgregarFamilia.Name = "btn_AgregarFamilia";
            btn_AgregarFamilia.Size = new System.Drawing.Size(75, 23);
            btn_AgregarFamilia.TabIndex = 9;
            btn_AgregarFamilia.Text = "Agregar";
            btn_AgregarFamilia.UseVisualStyleBackColor = true;
            btn_AgregarFamilia.Click += btn_AgregarFamilia_Click;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Location = new System.Drawing.Point(550, 346);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new System.Drawing.Size(75, 23);
            btn_Guardar.TabIndex = 10;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // UsuarioForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(129, 136, 205);
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btn_Guardar);
            Controls.Add(btn_AgregarFamilia);
            Controls.Add(btn_AgregarPermiso);
            Controls.Add(treeView1);
            Controls.Add(btn_ConfigurarUsuario);
            Controls.Add(cb_Familia);
            Controls.Add(label3);
            Controls.Add(cb_Permisos);
            Controls.Add(label2);
            Controls.Add(cb_Usuario);
            Controls.Add(label1);
            Name = "UsuarioForm";
            Text = "Administración de usuario";
            Load += UsuarioForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Permisos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Familia;
        private System.Windows.Forms.Button btn_ConfigurarUsuario;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn_AgregarPermiso;
        private System.Windows.Forms.Button btn_AgregarFamilia;
        private System.Windows.Forms.Button btn_Guardar;
    }
}