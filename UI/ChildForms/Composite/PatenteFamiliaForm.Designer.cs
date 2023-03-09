namespace UI.ChildForms.Composite
{
    partial class PatenteFamiliaForm
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
            btn_agregar = new System.Windows.Forms.Button();
            btn_configurar = new System.Windows.Forms.Button();
            cb_familia = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btn_crearFamilia = new System.Windows.Forms.Button();
            tb_CrearFamilia = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            btn_agregarPatente = new System.Windows.Forms.Button();
            cb_patentes = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            btn_crearPatente = new System.Windows.Forms.Button();
            treeView = new System.Windows.Forms.TreeView();
            btn_guardarConfig = new System.Windows.Forms.Button();
            tb_Patente = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            cb_permisos = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new System.Drawing.Point(42, 113);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new System.Drawing.Size(75, 23);
            btn_agregar.TabIndex = 0;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_configurar
            // 
            btn_configurar.Location = new System.Drawing.Point(146, 113);
            btn_configurar.Name = "btn_configurar";
            btn_configurar.Size = new System.Drawing.Size(75, 23);
            btn_configurar.TabIndex = 1;
            btn_configurar.Text = "Configurar";
            btn_configurar.UseVisualStyleBackColor = true;
            btn_configurar.Click += btn_configurar_Click;
            // 
            // cb_familia
            // 
            cb_familia.FormattingEnabled = true;
            cb_familia.Location = new System.Drawing.Point(42, 71);
            cb_familia.Name = "cb_familia";
            cb_familia.Size = new System.Drawing.Size(179, 23);
            cb_familia.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label1.Location = new System.Drawing.Point(41, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(50, 15);
            label1.TabIndex = 3;
            label1.Text = "Familias";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label2.Location = new System.Drawing.Point(41, 200);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 15);
            label2.TabIndex = 7;
            label2.Text = "Crear Familia";
            // 
            // btn_crearFamilia
            // 
            btn_crearFamilia.Location = new System.Drawing.Point(41, 291);
            btn_crearFamilia.Name = "btn_crearFamilia";
            btn_crearFamilia.Size = new System.Drawing.Size(75, 23);
            btn_crearFamilia.TabIndex = 4;
            btn_crearFamilia.Text = "Crear";
            btn_crearFamilia.UseVisualStyleBackColor = true;
            btn_crearFamilia.Click += btn_crearFamilia_Click;
            // 
            // tb_CrearFamilia
            // 
            tb_CrearFamilia.Location = new System.Drawing.Point(42, 233);
            tb_CrearFamilia.Name = "tb_CrearFamilia";
            tb_CrearFamilia.Size = new System.Drawing.Size(179, 23);
            tb_CrearFamilia.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label3.Location = new System.Drawing.Point(320, 39);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 15);
            label3.TabIndex = 10;
            label3.Text = "Patentes";
            // 
            // btn_agregarPatente
            // 
            btn_agregarPatente.Location = new System.Drawing.Point(320, 113);
            btn_agregarPatente.Name = "btn_agregarPatente";
            btn_agregarPatente.Size = new System.Drawing.Size(75, 23);
            btn_agregarPatente.TabIndex = 9;
            btn_agregarPatente.Text = "Agregar";
            btn_agregarPatente.UseVisualStyleBackColor = true;
            btn_agregarPatente.Click += btn_agregarPatente_Click;
            // 
            // cb_patentes
            // 
            cb_patentes.FormattingEnabled = true;
            cb_patentes.Location = new System.Drawing.Point(320, 71);
            cb_patentes.Name = "cb_patentes";
            cb_patentes.Size = new System.Drawing.Size(121, 23);
            cb_patentes.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label4.Location = new System.Drawing.Point(320, 206);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(78, 15);
            label4.TabIndex = 14;
            label4.Text = "Crear Patente";
            // 
            // btn_crearPatente
            // 
            btn_crearPatente.Location = new System.Drawing.Point(320, 291);
            btn_crearPatente.Name = "btn_crearPatente";
            btn_crearPatente.Size = new System.Drawing.Size(75, 23);
            btn_crearPatente.TabIndex = 13;
            btn_crearPatente.Text = "Crear";
            btn_crearPatente.UseVisualStyleBackColor = true;
            btn_crearPatente.Click += btn_crearPatente_Click;
            // 
            // treeView
            // 
            treeView.Location = new System.Drawing.Point(489, 65);
            treeView.Name = "treeView";
            treeView.Size = new System.Drawing.Size(291, 289);
            treeView.TabIndex = 17;
            treeView.MouseClick += treeView_MouseClick;
            // 
            // btn_guardarConfig
            // 
            btn_guardarConfig.Location = new System.Drawing.Point(588, 360);
            btn_guardarConfig.Name = "btn_guardarConfig";
            btn_guardarConfig.Size = new System.Drawing.Size(75, 23);
            btn_guardarConfig.TabIndex = 18;
            btn_guardarConfig.Text = "Guardar";
            btn_guardarConfig.UseVisualStyleBackColor = true;
            btn_guardarConfig.Click += btn_guardarConfig_Click;
            // 
            // tb_Patente
            // 
            tb_Patente.Location = new System.Drawing.Point(320, 233);
            tb_Patente.Name = "tb_Patente";
            tb_Patente.Size = new System.Drawing.Size(121, 23);
            tb_Patente.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label5.Location = new System.Drawing.Point(268, 237);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(51, 15);
            label5.TabIndex = 20;
            label5.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label6.Location = new System.Drawing.Point(268, 265);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(50, 15);
            label6.TabIndex = 21;
            label6.Text = "Permiso";
            // 
            // cb_permisos
            // 
            cb_permisos.FormattingEnabled = true;
            cb_permisos.Location = new System.Drawing.Point(320, 262);
            cb_permisos.Name = "cb_permisos";
            cb_permisos.Size = new System.Drawing.Size(121, 23);
            cb_permisos.TabIndex = 22;
            // 
            // PatenteFamiliaForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(129, 136, 205);
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(cb_permisos);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tb_Patente);
            Controls.Add(btn_guardarConfig);
            Controls.Add(treeView);
            Controls.Add(label4);
            Controls.Add(btn_crearPatente);
            Controls.Add(cb_patentes);
            Controls.Add(label3);
            Controls.Add(btn_agregarPatente);
            Controls.Add(tb_CrearFamilia);
            Controls.Add(label2);
            Controls.Add(btn_crearFamilia);
            Controls.Add(label1);
            Controls.Add(cb_familia);
            Controls.Add(btn_configurar);
            Controls.Add(btn_agregar);
            Name = "PatenteFamiliaForm";
            Text = "Administración de roles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_configurar;
        private System.Windows.Forms.ComboBox cb_familia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_crearFamilia;
        private System.Windows.Forms.TextBox tb_CrearFamilia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_agregarPatente;
        private System.Windows.Forms.ComboBox cb_patentes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_crearPatente;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button btn_guardarConfig;
        private System.Windows.Forms.TextBox tb_Patente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_permisos;
    }
}