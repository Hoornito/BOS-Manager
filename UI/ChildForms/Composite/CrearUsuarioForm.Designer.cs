namespace UI.ChildForms.Composite
{
    partial class CrearUsuarioForm
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
            this.btn_Crear = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_DNI = new System.Windows.Forms.TextBox();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Crear
            // 
            this.btn_Crear.Location = new System.Drawing.Point(319, 298);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(75, 23);
            this.btn_Crear.TabIndex = 0;
            this.btn_Crear.Text = "Crear";
            this.btn_Crear.UseVisualStyleBackColor = true;
            this.btn_Crear.Click += new System.EventHandler(this.btn_Crear_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(165, 59);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(141, 23);
            this.txt_Nombre.TabIndex = 1;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(165, 88);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(141, 23);
            this.txt_Apellido.TabIndex = 2;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(165, 146);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(141, 23);
            this.txt_Telefono.TabIndex = 4;
            // 
            // txt_DNI
            // 
            this.txt_DNI.Location = new System.Drawing.Point(165, 117);
            this.txt_DNI.Name = "txt_DNI";
            this.txt_DNI.Size = new System.Drawing.Size(141, 23);
            this.txt_DNI.TabIndex = 3;
            // 
            // txt_pw
            // 
            this.txt_pw.Location = new System.Drawing.Point(523, 88);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.Size = new System.Drawing.Size(141, 23);
            this.txt_pw.TabIndex = 6;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(523, 59);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(141, 23);
            this.txt_Usuario.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(67, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(67, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(427, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(427, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(67, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(67, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "DNI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(67, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mail";
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(165, 175);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(141, 23);
            this.txt_Mail.TabIndex = 13;
            // 
            // CrearUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(136)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(737, 372);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Mail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_DNI);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.btn_Crear);
            this.Name = "CrearUsuarioForm";
            this.Text = "CrearUsuarioForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Crear;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_DNI;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Mail;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}