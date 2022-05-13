namespace UI.GrandChildForms
{
    partial class ProductoAddForm
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.AgregarProducto = new FontAwesome.Sharp.IconButton();
            this.Add100 = new FontAwesome.Sharp.IconButton();
            this.Add200 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(99, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(118, 23);
            this.txtNombre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(99, 60);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(118, 23);
            this.txtCantidad.TabIndex = 9;
            this.txtCantidad.Text = "0";
            // 
            // AgregarProducto
            // 
            this.AgregarProducto.FlatAppearance.BorderSize = 0;
            this.AgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarProducto.ForeColor = System.Drawing.Color.White;
            this.AgregarProducto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.AgregarProducto.IconColor = System.Drawing.Color.White;
            this.AgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AgregarProducto.IconSize = 30;
            this.AgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarProducto.Location = new System.Drawing.Point(99, 98);
            this.AgregarProducto.Name = "AgregarProducto";
            this.AgregarProducto.Size = new System.Drawing.Size(118, 48);
            this.AgregarProducto.TabIndex = 32;
            this.AgregarProducto.Text = "Agregar";
            this.AgregarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarProducto.UseVisualStyleBackColor = true;
            this.AgregarProducto.Click += new System.EventHandler(this.AgregarProducto_Click);
            // 
            // Add100
            // 
            this.Add100.FlatAppearance.BorderSize = 0;
            this.Add100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add100.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add100.ForeColor = System.Drawing.Color.White;
            this.Add100.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.Add100.IconColor = System.Drawing.Color.White;
            this.Add100.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Add100.IconSize = 30;
            this.Add100.Location = new System.Drawing.Point(256, 30);
            this.Add100.Name = "Add100";
            this.Add100.Size = new System.Drawing.Size(118, 48);
            this.Add100.TabIndex = 33;
            this.Add100.Text = "100";
            this.Add100.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Add100.UseVisualStyleBackColor = true;
            this.Add100.Click += new System.EventHandler(this.Add100_Click);
            // 
            // Add200
            // 
            this.Add200.FlatAppearance.BorderSize = 0;
            this.Add200.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add200.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add200.ForeColor = System.Drawing.Color.White;
            this.Add200.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.Add200.IconColor = System.Drawing.Color.White;
            this.Add200.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Add200.IconSize = 30;
            this.Add200.Location = new System.Drawing.Point(256, 98);
            this.Add200.Name = "Add200";
            this.Add200.Size = new System.Drawing.Size(118, 48);
            this.Add200.TabIndex = 34;
            this.Add200.Text = "200";
            this.Add200.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Add200.UseVisualStyleBackColor = true;
            this.Add200.Click += new System.EventHandler(this.Add200_Click);
            // 
            // ProductoAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(136)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(399, 175);
            this.Controls.Add(this.Add200);
            this.Controls.Add(this.Add100);
            this.Controls.Add(this.AgregarProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Name = "ProductoAddForm";
            this.Text = "ProductoAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad;
        private FontAwesome.Sharp.IconButton AgregarProducto;
        private FontAwesome.Sharp.IconButton Add100;
        private FontAwesome.Sharp.IconButton Add200;
    }
}