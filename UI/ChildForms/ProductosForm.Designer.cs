
namespace UI.ChildForms
{
    partial class ProductosForm
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
            txtNombre = new System.Windows.Forms.TextBox();
            txtPrecio = new System.Windows.Forms.TextBox();
            txtDescripción = new System.Windows.Forms.TextBox();
            txtCantidad = new System.Windows.Forms.TextBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            AgregarProducto = new FontAwesome.Sharp.IconButton();
            ActualizarProducto = new FontAwesome.Sharp.IconButton();
            EliminarProducto = new FontAwesome.Sharp.IconButton();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            cboTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(103, 98);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(180, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new System.Drawing.Point(103, 127);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new System.Drawing.Size(180, 23);
            txtPrecio.TabIndex = 1;
            txtPrecio.Text = "0";
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // txtDescripción
            // 
            txtDescripción.Location = new System.Drawing.Point(103, 185);
            txtDescripción.Name = "txtDescripción";
            txtDescripción.Size = new System.Drawing.Size(180, 23);
            txtDescripción.TabIndex = 3;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new System.Drawing.Point(103, 156);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new System.Drawing.Size(180, 23);
            txtCantidad.TabIndex = 2;
            txtCantidad.Text = "0";
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(129, 136, 205);
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(289, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dataGridView1.Size = new System.Drawing.Size(825, 341);
            dataGridView1.TabIndex = 4;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(46, 101);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(57, 130);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(40, 15);
            label2.TabIndex = 6;
            label2.Text = "Precio";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(42, 159);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 15);
            label3.TabIndex = 8;
            label3.Text = "Cantidad";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(28, 188);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 15);
            label4.TabIndex = 7;
            label4.Text = "Descripción";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AgregarProducto
            // 
            AgregarProducto.FlatAppearance.BorderSize = 0;
            AgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AgregarProducto.ForeColor = System.Drawing.Color.White;
            AgregarProducto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            AgregarProducto.IconColor = System.Drawing.Color.White;
            AgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AgregarProducto.IconSize = 30;
            AgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            AgregarProducto.Location = new System.Drawing.Point(103, 283);
            AgregarProducto.Name = "AgregarProducto";
            AgregarProducto.Size = new System.Drawing.Size(118, 48);
            AgregarProducto.TabIndex = 31;
            AgregarProducto.Text = "Agregar";
            AgregarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            AgregarProducto.UseVisualStyleBackColor = true;
            AgregarProducto.Click += AgregarProducto_Click;
            // 
            // ActualizarProducto
            // 
            ActualizarProducto.FlatAppearance.BorderSize = 0;
            ActualizarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ActualizarProducto.ForeColor = System.Drawing.Color.White;
            ActualizarProducto.IconChar = FontAwesome.Sharp.IconChar.Redo;
            ActualizarProducto.IconColor = System.Drawing.Color.White;
            ActualizarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ActualizarProducto.IconSize = 30;
            ActualizarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ActualizarProducto.Location = new System.Drawing.Point(103, 337);
            ActualizarProducto.Name = "ActualizarProducto";
            ActualizarProducto.Size = new System.Drawing.Size(118, 48);
            ActualizarProducto.TabIndex = 32;
            ActualizarProducto.Text = "Actualizar";
            ActualizarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ActualizarProducto.UseVisualStyleBackColor = true;
            ActualizarProducto.Click += ActualizarProducto_Click;
            // 
            // EliminarProducto
            // 
            EliminarProducto.FlatAppearance.BorderSize = 0;
            EliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            EliminarProducto.ForeColor = System.Drawing.Color.White;
            EliminarProducto.IconChar = FontAwesome.Sharp.IconChar.Minus;
            EliminarProducto.IconColor = System.Drawing.Color.White;
            EliminarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EliminarProducto.IconSize = 30;
            EliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            EliminarProducto.Location = new System.Drawing.Point(103, 391);
            EliminarProducto.Name = "EliminarProducto";
            EliminarProducto.Size = new System.Drawing.Size(118, 48);
            EliminarProducto.TabIndex = 33;
            EliminarProducto.Text = "Eliminar";
            EliminarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            EliminarProducto.UseVisualStyleBackColor = true;
            EliminarProducto.Click += EliminarProducto_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label5.Location = new System.Drawing.Point(264, 21);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(304, 51);
            label5.TabIndex = 34;
            label5.Text = "Módulo Stock";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label6.Location = new System.Drawing.Point(64, 217);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(30, 15);
            label6.TabIndex = 35;
            label6.Text = "Tipo";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Empanada", "Pizza" });
            cboTipo.Location = new System.Drawing.Point(100, 214);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new System.Drawing.Size(183, 23);
            cboTipo.TabIndex = 36;
            // 
            // ProductosForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(129, 136, 205);
            ClientSize = new System.Drawing.Size(1126, 527);
            Controls.Add(cboTipo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(EliminarProducto);
            Controls.Add(ActualizarProducto);
            Controls.Add(AgregarProducto);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(txtDescripción);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Name = "ProductosForm";
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripción;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton AgregarProducto;
        private FontAwesome.Sharp.IconButton ActualizarProducto;
        private FontAwesome.Sharp.IconButton EliminarProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTipo;
    }
}