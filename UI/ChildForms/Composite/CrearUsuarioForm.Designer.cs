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
            btn_Crear = new System.Windows.Forms.Button();
            txt_Nombre = new System.Windows.Forms.TextBox();
            txt_Apellido = new System.Windows.Forms.TextBox();
            txt_Telefono = new System.Windows.Forms.TextBox();
            txt_DNI = new System.Windows.Forms.TextBox();
            txt_pw = new System.Windows.Forms.TextBox();
            txt_Usuario = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            txt_Mail = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btn_Crear
            // 
            btn_Crear.Location = new System.Drawing.Point(319, 298);
            btn_Crear.Name = "btn_Crear";
            btn_Crear.Size = new System.Drawing.Size(75, 23);
            btn_Crear.TabIndex = 0;
            btn_Crear.Text = "Crear";
            btn_Crear.UseVisualStyleBackColor = true;
            btn_Crear.Click += btn_Crear_Click;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new System.Drawing.Point(165, 59);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new System.Drawing.Size(141, 23);
            txt_Nombre.TabIndex = 1;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new System.Drawing.Point(165, 88);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new System.Drawing.Size(141, 23);
            txt_Apellido.TabIndex = 2;
            // 
            // txt_Telefono
            // 
            txt_Telefono.Location = new System.Drawing.Point(165, 146);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new System.Drawing.Size(141, 23);
            txt_Telefono.TabIndex = 4;
            // 
            // txt_DNI
            // 
            txt_DNI.Location = new System.Drawing.Point(165, 117);
            txt_DNI.Name = "txt_DNI";
            txt_DNI.Size = new System.Drawing.Size(141, 23);
            txt_DNI.TabIndex = 3;
            // 
            // txt_pw
            // 
            txt_pw.Location = new System.Drawing.Point(523, 88);
            txt_pw.Name = "txt_pw";
            txt_pw.Size = new System.Drawing.Size(141, 23);
            txt_pw.TabIndex = 6;
            // 
            // txt_Usuario
            // 
            txt_Usuario.Location = new System.Drawing.Point(523, 59);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Size = new System.Drawing.Size(141, 23);
            txt_Usuario.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label1.Location = new System.Drawing.Point(67, 62);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 15);
            label1.TabIndex = 7;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label2.Location = new System.Drawing.Point(67, 91);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 15);
            label2.TabIndex = 8;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label3.Location = new System.Drawing.Point(427, 91);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 15);
            label3.TabIndex = 10;
            label3.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label4.Location = new System.Drawing.Point(427, 62);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(47, 15);
            label4.TabIndex = 9;
            label4.Text = "Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label5.Location = new System.Drawing.Point(67, 149);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(52, 15);
            label5.TabIndex = 12;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label6.Location = new System.Drawing.Point(67, 120);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(27, 15);
            label6.TabIndex = 11;
            label6.Text = "DNI";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label7.Location = new System.Drawing.Point(67, 178);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(30, 15);
            label7.TabIndex = 14;
            label7.Text = "Mail";
            // 
            // txt_Mail
            // 
            txt_Mail.Location = new System.Drawing.Point(165, 175);
            txt_Mail.Name = "txt_Mail";
            txt_Mail.Size = new System.Drawing.Size(141, 23);
            txt_Mail.TabIndex = 13;
            // 
            // CrearUsuarioForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(129, 136, 205);
            ClientSize = new System.Drawing.Size(737, 372);
            Controls.Add(label7);
            Controls.Add(txt_Mail);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_pw);
            Controls.Add(txt_Usuario);
            Controls.Add(txt_Telefono);
            Controls.Add(txt_DNI);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Nombre);
            Controls.Add(btn_Crear);
            Name = "CrearUsuarioForm";
            Text = "Cración de usuario";
            ResumeLayout(false);
            PerformLayout();
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