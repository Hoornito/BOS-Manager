
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripción = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AgregarProducto = new FontAwesome.Sharp.IconButton();
            this.ActualizarProducto = new FontAwesome.Sharp.IconButton();
            this.EliminarProducto = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(103, 98);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(118, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(103, 127);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(118, 23);
            this.txtPrecio.TabIndex = 1;
            this.txtPrecio.Text = "0";
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtDescripción
            // 
            this.txtDescripción.Location = new System.Drawing.Point(103, 185);
            this.txtDescripción.Name = "txtDescripción";
            this.txtDescripción.Size = new System.Drawing.Size(118, 23);
            this.txtDescripción.TabIndex = 3;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(103, 156);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(118, 23);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.Text = "0";
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(136)))), ((int)(((byte)(205)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(289, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(579, 341);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descripción";
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
            this.AgregarProducto.Location = new System.Drawing.Point(103, 226);
            this.AgregarProducto.Name = "AgregarProducto";
            this.AgregarProducto.Size = new System.Drawing.Size(118, 48);
            this.AgregarProducto.TabIndex = 31;
            this.AgregarProducto.Text = "Agregar";
            this.AgregarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarProducto.UseVisualStyleBackColor = true;
            this.AgregarProducto.Click += new System.EventHandler(this.AgregarProducto_Click);
            // 
            // ActualizarProducto
            // 
            this.ActualizarProducto.FlatAppearance.BorderSize = 0;
            this.ActualizarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActualizarProducto.ForeColor = System.Drawing.Color.White;
            this.ActualizarProducto.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.ActualizarProducto.IconColor = System.Drawing.Color.White;
            this.ActualizarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ActualizarProducto.IconSize = 30;
            this.ActualizarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ActualizarProducto.Location = new System.Drawing.Point(103, 280);
            this.ActualizarProducto.Name = "ActualizarProducto";
            this.ActualizarProducto.Size = new System.Drawing.Size(118, 48);
            this.ActualizarProducto.TabIndex = 32;
            this.ActualizarProducto.Text = "Actualizar";
            this.ActualizarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ActualizarProducto.UseVisualStyleBackColor = true;
            this.ActualizarProducto.Click += new System.EventHandler(this.ActualizarProducto_Click);
            // 
            // EliminarProducto
            // 
            this.EliminarProducto.FlatAppearance.BorderSize = 0;
            this.EliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarProducto.ForeColor = System.Drawing.Color.White;
            this.EliminarProducto.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.EliminarProducto.IconColor = System.Drawing.Color.White;
            this.EliminarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EliminarProducto.IconSize = 30;
            this.EliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarProducto.Location = new System.Drawing.Point(103, 334);
            this.EliminarProducto.Name = "EliminarProducto";
            this.EliminarProducto.Size = new System.Drawing.Size(118, 48);
            this.EliminarProducto.TabIndex = 33;
            this.EliminarProducto.Text = "Eliminar";
            this.EliminarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EliminarProducto.UseVisualStyleBackColor = true;
            this.EliminarProducto.Click += new System.EventHandler(this.EliminarProducto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(264, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 51);
            this.label5.TabIndex = 34;
            this.label5.Text = "Módulo Stock";
            // 
            // ProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(136)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(891, 461);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EliminarProducto);
            this.Controls.Add(this.ActualizarProducto);
            this.Controls.Add(this.AgregarProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDescripción);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Name = "ProductosForm";
            this.Text = "ProductosForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}