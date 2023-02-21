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
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_configurar = new System.Windows.Forms.Button();
            this.cb_familia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_crearFamilia = new System.Windows.Forms.Button();
            this.tb_CrearFamilia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_agregarPatente = new System.Windows.Forms.Button();
            this.cb_patentes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_crearPatente = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.btn_guardarConfig = new System.Windows.Forms.Button();
            this.tb_Patente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_permisos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(42, 113);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_configurar
            // 
            this.btn_configurar.Location = new System.Drawing.Point(146, 113);
            this.btn_configurar.Name = "btn_configurar";
            this.btn_configurar.Size = new System.Drawing.Size(75, 23);
            this.btn_configurar.TabIndex = 1;
            this.btn_configurar.Text = "Configurar";
            this.btn_configurar.UseVisualStyleBackColor = true;
            this.btn_configurar.Click += new System.EventHandler(this.btn_configurar_Click);
            // 
            // cb_familia
            // 
            this.cb_familia.FormattingEnabled = true;
            this.cb_familia.Location = new System.Drawing.Point(42, 71);
            this.cb_familia.Name = "cb_familia";
            this.cb_familia.Size = new System.Drawing.Size(179, 23);
            this.cb_familia.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Familias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Crear Familia";
            // 
            // btn_crearFamilia
            // 
            this.btn_crearFamilia.Location = new System.Drawing.Point(41, 291);
            this.btn_crearFamilia.Name = "btn_crearFamilia";
            this.btn_crearFamilia.Size = new System.Drawing.Size(75, 23);
            this.btn_crearFamilia.TabIndex = 4;
            this.btn_crearFamilia.Text = "Crear";
            this.btn_crearFamilia.UseVisualStyleBackColor = true;
            this.btn_crearFamilia.Click += new System.EventHandler(this.btn_crearFamilia_Click);
            // 
            // tb_CrearFamilia
            // 
            this.tb_CrearFamilia.Location = new System.Drawing.Point(42, 233);
            this.tb_CrearFamilia.Name = "tb_CrearFamilia";
            this.tb_CrearFamilia.Size = new System.Drawing.Size(179, 23);
            this.tb_CrearFamilia.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Patentes";
            // 
            // btn_agregarPatente
            // 
            this.btn_agregarPatente.Location = new System.Drawing.Point(320, 113);
            this.btn_agregarPatente.Name = "btn_agregarPatente";
            this.btn_agregarPatente.Size = new System.Drawing.Size(75, 23);
            this.btn_agregarPatente.TabIndex = 9;
            this.btn_agregarPatente.Text = "Agregar";
            this.btn_agregarPatente.UseVisualStyleBackColor = true;
            this.btn_agregarPatente.Click += new System.EventHandler(this.btn_agregarPatente_Click);
            // 
            // cb_patentes
            // 
            this.cb_patentes.FormattingEnabled = true;
            this.cb_patentes.Location = new System.Drawing.Point(320, 71);
            this.cb_patentes.Name = "cb_patentes";
            this.cb_patentes.Size = new System.Drawing.Size(121, 23);
            this.cb_patentes.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Crear Patente";
            // 
            // btn_crearPatente
            // 
            this.btn_crearPatente.Location = new System.Drawing.Point(320, 291);
            this.btn_crearPatente.Name = "btn_crearPatente";
            this.btn_crearPatente.Size = new System.Drawing.Size(75, 23);
            this.btn_crearPatente.TabIndex = 13;
            this.btn_crearPatente.Text = "Crear";
            this.btn_crearPatente.UseVisualStyleBackColor = true;
            this.btn_crearPatente.Click += new System.EventHandler(this.btn_crearPatente_Click);
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(489, 65);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(291, 289);
            this.treeView.TabIndex = 17;
            this.treeView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseClick);
            // 
            // btn_guardarConfig
            // 
            this.btn_guardarConfig.Location = new System.Drawing.Point(588, 360);
            this.btn_guardarConfig.Name = "btn_guardarConfig";
            this.btn_guardarConfig.Size = new System.Drawing.Size(75, 23);
            this.btn_guardarConfig.TabIndex = 18;
            this.btn_guardarConfig.Text = "Guardar";
            this.btn_guardarConfig.UseVisualStyleBackColor = true;
            this.btn_guardarConfig.Click += new System.EventHandler(this.btn_guardarConfig_Click);
            // 
            // tb_Patente
            // 
            this.tb_Patente.Location = new System.Drawing.Point(320, 233);
            this.tb_Patente.Name = "tb_Patente";
            this.tb_Patente.Size = new System.Drawing.Size(121, 23);
            this.tb_Patente.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Permiso";
            // 
            // cb_permisos
            // 
            this.cb_permisos.FormattingEnabled = true;
            this.cb_permisos.Location = new System.Drawing.Point(320, 262);
            this.cb_permisos.Name = "cb_permisos";
            this.cb_permisos.Size = new System.Drawing.Size(121, 23);
            this.cb_permisos.TabIndex = 22;
            // 
            // PatenteFamiliaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(136)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_permisos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Patente);
            this.Controls.Add(this.btn_guardarConfig);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_crearPatente);
            this.Controls.Add(this.cb_patentes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_agregarPatente);
            this.Controls.Add(this.tb_CrearFamilia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_crearFamilia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_familia);
            this.Controls.Add(this.btn_configurar);
            this.Controls.Add(this.btn_agregar);
            this.Name = "PatenteFamiliaForm";
            this.Text = "PatenteFamiliaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

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