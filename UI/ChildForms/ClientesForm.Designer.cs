
namespace UI.ChildForms
{
    partial class ClientesForm
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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            txtNombre = new System.Windows.Forms.TextBox();
            txtTelefono = new System.Windows.Forms.TextBox();
            txtDNI = new System.Windows.Forms.TextBox();
            txtmail = new System.Windows.Forms.TextBox();
            txtDireccion = new System.Windows.Forms.TextBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            AgregarCliente = new FontAwesome.Sharp.IconButton();
            EliminarCliente = new FontAwesome.Sharp.IconButton();
            ActualizarCliente = new FontAwesome.Sharp.IconButton();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // iconButton1
            // 
            iconButton1.Enabled = false;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconButton1.IconColor = System.Drawing.Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 24;
            iconButton1.Location = new System.Drawing.Point(206, 91);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new System.Drawing.Size(27, 23);
            iconButton1.TabIndex = 11;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            iconButton3.Enabled = false;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            iconButton3.IconColor = System.Drawing.Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton3.IconSize = 24;
            iconButton3.Location = new System.Drawing.Point(206, 120);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new System.Drawing.Size(27, 23);
            iconButton3.TabIndex = 15;
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            iconButton4.Enabled = false;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Phone;
            iconButton4.IconColor = System.Drawing.Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton4.IconSize = 24;
            iconButton4.Location = new System.Drawing.Point(206, 149);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new System.Drawing.Size(27, 23);
            iconButton4.TabIndex = 17;
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton5
            // 
            iconButton5.Enabled = false;
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            iconButton5.IconColor = System.Drawing.Color.White;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton5.IconSize = 24;
            iconButton5.Location = new System.Drawing.Point(206, 178);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new System.Drawing.Size(27, 23);
            iconButton5.TabIndex = 19;
            iconButton5.UseVisualStyleBackColor = true;
            // 
            // iconButton6
            // 
            iconButton6.Enabled = false;
            iconButton6.FlatAppearance.BorderSize = 0;
            iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            iconButton6.IconColor = System.Drawing.Color.White;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton6.IconSize = 24;
            iconButton6.Location = new System.Drawing.Point(206, 207);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new System.Drawing.Size(27, 23);
            iconButton6.TabIndex = 21;
            iconButton6.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(100, 91);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(100, 23);
            txtNombre.TabIndex = 22;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new System.Drawing.Point(100, 149);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(100, 23);
            txtTelefono.TabIndex = 25;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtDNI
            // 
            txtDNI.Location = new System.Drawing.Point(100, 120);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new System.Drawing.Size(100, 23);
            txtDNI.TabIndex = 24;
            txtDNI.KeyPress += txtDNI_KeyPress;
            // 
            // txtmail
            // 
            txtmail.Location = new System.Drawing.Point(100, 207);
            txtmail.Name = "txtmail";
            txtmail.Size = new System.Drawing.Size(100, 23);
            txtmail.TabIndex = 27;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new System.Drawing.Point(100, 178);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new System.Drawing.Size(100, 23);
            txtDireccion.TabIndex = 26;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(129, 136, 205);
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(267, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dataGridView1.Size = new System.Drawing.Size(645, 341);
            dataGridView1.TabIndex = 28;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label1.Location = new System.Drawing.Point(342, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(354, 51);
            label1.TabIndex = 29;
            label1.Text = "Módulo Clientes";
            // 
            // AgregarCliente
            // 
            AgregarCliente.FlatAppearance.BorderSize = 0;
            AgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AgregarCliente.ForeColor = System.Drawing.Color.White;
            AgregarCliente.IconChar = FontAwesome.Sharp.IconChar.Plus;
            AgregarCliente.IconColor = System.Drawing.Color.White;
            AgregarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AgregarCliente.IconSize = 30;
            AgregarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            AgregarCliente.Location = new System.Drawing.Point(100, 236);
            AgregarCliente.Name = "AgregarCliente";
            AgregarCliente.Size = new System.Drawing.Size(100, 48);
            AgregarCliente.TabIndex = 30;
            AgregarCliente.Text = "Agregar";
            AgregarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            AgregarCliente.UseVisualStyleBackColor = true;
            AgregarCliente.Click += AgregarCliente_Click;
            // 
            // EliminarCliente
            // 
            EliminarCliente.FlatAppearance.BorderSize = 0;
            EliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            EliminarCliente.ForeColor = System.Drawing.Color.White;
            EliminarCliente.IconChar = FontAwesome.Sharp.IconChar.Minus;
            EliminarCliente.IconColor = System.Drawing.Color.White;
            EliminarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EliminarCliente.IconSize = 30;
            EliminarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            EliminarCliente.Location = new System.Drawing.Point(100, 344);
            EliminarCliente.Name = "EliminarCliente";
            EliminarCliente.Size = new System.Drawing.Size(100, 48);
            EliminarCliente.TabIndex = 35;
            EliminarCliente.Text = "Eliminar";
            EliminarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            EliminarCliente.UseVisualStyleBackColor = true;
            EliminarCliente.Click += EliminarCliente_Click;
            // 
            // ActualizarCliente
            // 
            ActualizarCliente.FlatAppearance.BorderSize = 0;
            ActualizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ActualizarCliente.ForeColor = System.Drawing.Color.White;
            ActualizarCliente.IconChar = FontAwesome.Sharp.IconChar.Redo;
            ActualizarCliente.IconColor = System.Drawing.Color.White;
            ActualizarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ActualizarCliente.IconSize = 30;
            ActualizarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ActualizarCliente.Location = new System.Drawing.Point(100, 290);
            ActualizarCliente.Name = "ActualizarCliente";
            ActualizarCliente.Size = new System.Drawing.Size(100, 48);
            ActualizarCliente.TabIndex = 34;
            ActualizarCliente.Text = "Actualizar";
            ActualizarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ActualizarCliente.UseVisualStyleBackColor = true;
            ActualizarCliente.Click += ActualizarCliente_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(34, 95);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 15);
            label2.TabIndex = 36;
            label2.Text = "Nombre";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(33, 152);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 15);
            label3.TabIndex = 37;
            label3.Text = "Teléfono";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(28, 181);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(57, 15);
            label4.TabIndex = 38;
            label4.Text = "Dirección";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(55, 211);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(30, 15);
            label5.TabIndex = 39;
            label5.Text = "Mail";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(58, 124);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(27, 15);
            label6.TabIndex = 40;
            label6.Text = "DNI";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClientesForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(129, 136, 205);
            ClientSize = new System.Drawing.Size(984, 486);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(EliminarCliente);
            Controls.Add(ActualizarCliente);
            Controls.Add(AgregarCliente);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(txtmail);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtDNI);
            Controls.Add(txtNombre);
            Controls.Add(iconButton6);
            Controls.Add(iconButton5);
            Controls.Add(iconButton4);
            Controls.Add(iconButton3);
            Controls.Add(iconButton1);
            MinimumSize = new System.Drawing.Size(1000, 525);
            Name = "ClientesForm";
            Text = "Clientes";
            Load += ClientesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton AgregarCliente;
        private FontAwesome.Sharp.IconButton EliminarCliente;
        private FontAwesome.Sharp.IconButton ActualizarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}