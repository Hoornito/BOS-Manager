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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Usuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Permisos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Familia = new System.Windows.Forms.ComboBox();
            this.btn_ConfigurarUsuario = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_AgregarPermiso = new System.Windows.Forms.Button();
            this.btn_AgregarFamilia = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar usuario";
            // 
            // cb_Usuario
            // 
            this.cb_Usuario.FormattingEnabled = true;
            this.cb_Usuario.Location = new System.Drawing.Point(153, 56);
            this.cb_Usuario.Name = "cb_Usuario";
            this.cb_Usuario.Size = new System.Drawing.Size(121, 23);
            this.cb_Usuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Agregar permisos";
            // 
            // cb_Permisos
            // 
            this.cb_Permisos.FormattingEnabled = true;
            this.cb_Permisos.Location = new System.Drawing.Point(153, 125);
            this.cb_Permisos.Name = "cb_Permisos";
            this.cb_Permisos.Size = new System.Drawing.Size(121, 23);
            this.cb_Permisos.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Agregar grupo";
            // 
            // cb_Familia
            // 
            this.cb_Familia.FormattingEnabled = true;
            this.cb_Familia.Location = new System.Drawing.Point(153, 190);
            this.cb_Familia.Name = "cb_Familia";
            this.cb_Familia.Size = new System.Drawing.Size(121, 23);
            this.cb_Familia.TabIndex = 5;
            // 
            // btn_ConfigurarUsuario
            // 
            this.btn_ConfigurarUsuario.Location = new System.Drawing.Point(294, 56);
            this.btn_ConfigurarUsuario.Name = "btn_ConfigurarUsuario";
            this.btn_ConfigurarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btn_ConfigurarUsuario.TabIndex = 6;
            this.btn_ConfigurarUsuario.Text = "Configurar";
            this.btn_ConfigurarUsuario.UseVisualStyleBackColor = true;
            this.btn_ConfigurarUsuario.Click += new System.EventHandler(this.btn_ConfigurarUsuario_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(440, 48);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(294, 292);
            this.treeView1.TabIndex = 7;
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            // 
            // btn_AgregarPermiso
            // 
            this.btn_AgregarPermiso.Location = new System.Drawing.Point(294, 125);
            this.btn_AgregarPermiso.Name = "btn_AgregarPermiso";
            this.btn_AgregarPermiso.Size = new System.Drawing.Size(75, 23);
            this.btn_AgregarPermiso.TabIndex = 8;
            this.btn_AgregarPermiso.Text = "Agregar";
            this.btn_AgregarPermiso.UseVisualStyleBackColor = true;
            this.btn_AgregarPermiso.Click += new System.EventHandler(this.btn_AgregarPermiso_Click);
            // 
            // btn_AgregarFamilia
            // 
            this.btn_AgregarFamilia.Location = new System.Drawing.Point(294, 190);
            this.btn_AgregarFamilia.Name = "btn_AgregarFamilia";
            this.btn_AgregarFamilia.Size = new System.Drawing.Size(75, 23);
            this.btn_AgregarFamilia.TabIndex = 9;
            this.btn_AgregarFamilia.Text = "Agregar";
            this.btn_AgregarFamilia.UseVisualStyleBackColor = true;
            this.btn_AgregarFamilia.Click += new System.EventHandler(this.btn_AgregarFamilia_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(550, 346);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 10;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // UsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(136)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_AgregarFamilia);
            this.Controls.Add(this.btn_AgregarPermiso);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btn_ConfigurarUsuario);
            this.Controls.Add(this.cb_Familia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Permisos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Usuario);
            this.Controls.Add(this.label1);
            this.Name = "UsuarioForm";
            this.Text = "UsuarioForm";
            this.Load += new System.EventHandler(this.UsuarioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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