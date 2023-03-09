
namespace UI.ChildForms
{
    partial class PedidosForm
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
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtPedido = new System.Windows.Forms.TextBox();
            txtDireccion = new System.Windows.Forms.TextBox();
            cbCliente = new System.Windows.Forms.ComboBox();
            cboTipoProducto = new System.Windows.Forms.ComboBox();
            btnMenos = new FontAwesome.Sharp.IconButton();
            btnMAS = new FontAwesome.Sharp.IconButton();
            txtCant = new System.Windows.Forms.TextBox();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            btnQuitar = new FontAwesome.Sharp.IconButton();
            btnComenzar = new FontAwesome.Sharp.IconButton();
            label5 = new System.Windows.Forms.Label();
            txtDescripción = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            btnFinalizar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            label7 = new System.Windows.Forms.Label();
            radioLocal = new System.Windows.Forms.RadioButton();
            radioRepartidor = new System.Windows.Forms.RadioButton();
            label8 = new System.Windows.Forms.Label();
            cboProducto = new System.Windows.Forms.ComboBox();
            label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(39, 91);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Pedido #:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(49, 120);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Cliente:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(36, 149);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Dirección:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(11, 178);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(85, 15);
            label4.TabIndex = 3;
            label4.Text = "Tipo producto:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPedido
            // 
            txtPedido.Location = new System.Drawing.Point(117, 88);
            txtPedido.Name = "txtPedido";
            txtPedido.ReadOnly = true;
            txtPedido.Size = new System.Drawing.Size(90, 23);
            txtPedido.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new System.Drawing.Point(117, 146);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.ReadOnly = true;
            txtDireccion.Size = new System.Drawing.Size(235, 23);
            txtDireccion.TabIndex = 5;
            // 
            // cbCliente
            // 
            cbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbCliente.Enabled = false;
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new System.Drawing.Point(117, 117);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new System.Drawing.Size(235, 23);
            cbCliente.TabIndex = 6;
            cbCliente.SelectedIndexChanged += cbCliente_SelectedIndexChanged;
            cbCliente.KeyPress += cbCliente_KeyPress;
            cbCliente.Leave += cbCliente_Leave;
            // 
            // cboTipoProducto
            // 
            cboTipoProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cboTipoProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cboTipoProducto.Enabled = false;
            cboTipoProducto.FormattingEnabled = true;
            cboTipoProducto.Items.AddRange(new object[] { "Empanadas", "Pizzas" });
            cboTipoProducto.Location = new System.Drawing.Point(117, 175);
            cboTipoProducto.Name = "cboTipoProducto";
            cboTipoProducto.Size = new System.Drawing.Size(235, 23);
            cboTipoProducto.TabIndex = 7;
            cboTipoProducto.SelectedIndexChanged += cbProducto_SelectedIndexChanged;
            // 
            // btnMenos
            // 
            btnMenos.FlatAppearance.BorderSize = 0;
            btnMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMenos.IconChar = FontAwesome.Sharp.IconChar.Minus;
            btnMenos.IconColor = System.Drawing.Color.White;
            btnMenos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenos.IconSize = 22;
            btnMenos.Location = new System.Drawing.Point(117, 242);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new System.Drawing.Size(25, 23);
            btnMenos.TabIndex = 8;
            btnMenos.UseVisualStyleBackColor = true;
            btnMenos.Click += btnMenos_Click;
            // 
            // btnMAS
            // 
            btnMAS.FlatAppearance.BorderSize = 0;
            btnMAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMAS.ForeColor = System.Drawing.Color.White;
            btnMAS.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnMAS.IconColor = System.Drawing.Color.White;
            btnMAS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMAS.IconSize = 22;
            btnMAS.Location = new System.Drawing.Point(213, 242);
            btnMAS.Name = "btnMAS";
            btnMAS.Size = new System.Drawing.Size(25, 23);
            btnMAS.TabIndex = 9;
            btnMAS.UseVisualStyleBackColor = true;
            btnMAS.Click += btnMAS_Click;
            // 
            // txtCant
            // 
            txtCant.Enabled = false;
            txtCant.Location = new System.Drawing.Point(148, 242);
            txtCant.Name = "txtCant";
            txtCant.Size = new System.Drawing.Size(59, 23);
            txtCant.TabIndex = 10;
            txtCant.Text = "1";
            txtCant.KeyPress += txtCant_KeyPress;
            // 
            // btnAgregar
            // 
            btnAgregar.Enabled = false;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAgregar.ForeColor = System.Drawing.Color.White;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            btnAgregar.IconColor = System.Drawing.Color.White;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.IconSize = 22;
            btnAgregar.Location = new System.Drawing.Point(367, 235);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(86, 37);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
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
            dataGridView1.Location = new System.Drawing.Point(36, 300);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dataGridView1.Size = new System.Drawing.Size(681, 232);
            dataGridView1.TabIndex = 12;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // btnQuitar
            // 
            btnQuitar.Enabled = false;
            btnQuitar.FlatAppearance.BorderSize = 0;
            btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnQuitar.ForeColor = System.Drawing.Color.White;
            btnQuitar.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            btnQuitar.IconColor = System.Drawing.Color.White;
            btnQuitar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQuitar.IconSize = 22;
            btnQuitar.Location = new System.Drawing.Point(459, 234);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new System.Drawing.Size(86, 37);
            btnQuitar.TabIndex = 13;
            btnQuitar.Text = "Quitar";
            btnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnComenzar
            // 
            btnComenzar.FlatAppearance.BorderSize = 0;
            btnComenzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnComenzar.ForeColor = System.Drawing.Color.White;
            btnComenzar.IconChar = FontAwesome.Sharp.IconChar.PizzaSlice;
            btnComenzar.IconColor = System.Drawing.Color.White;
            btnComenzar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnComenzar.IconSize = 24;
            btnComenzar.Location = new System.Drawing.Point(358, 79);
            btnComenzar.Name = "btnComenzar";
            btnComenzar.Size = new System.Drawing.Size(95, 29);
            btnComenzar.TabIndex = 15;
            btnComenzar.Text = "Comenzar";
            btnComenzar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnComenzar.UseVisualStyleBackColor = true;
            btnComenzar.Click += btnComenzar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label5.Location = new System.Drawing.Point(49, 7);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(354, 51);
            label5.TabIndex = 30;
            label5.Text = "Módulo Pedidos";
            // 
            // txtDescripción
            // 
            txtDescripción.Location = new System.Drawing.Point(572, 107);
            txtDescripción.Multiline = true;
            txtDescripción.Name = "txtDescripción";
            txtDescripción.Size = new System.Drawing.Size(145, 125);
            txtDescripción.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(572, 86);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(72, 15);
            label6.TabIndex = 32;
            label6.Text = "Descripción:";
            // 
            // btnFinalizar
            // 
            btnFinalizar.Enabled = false;
            btnFinalizar.FlatAppearance.BorderSize = 0;
            btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFinalizar.ForeColor = System.Drawing.Color.White;
            btnFinalizar.IconChar = FontAwesome.Sharp.IconChar.PizzaSlice;
            btnFinalizar.IconColor = System.Drawing.Color.White;
            btnFinalizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFinalizar.IconSize = 24;
            btnFinalizar.Location = new System.Drawing.Point(358, 114);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new System.Drawing.Size(95, 29);
            btnFinalizar.TabIndex = 33;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.ForeColor = System.Drawing.Color.White;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Frown;
            btnCancelar.IconColor = System.Drawing.Color.White;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 24;
            btnCancelar.Location = new System.Drawing.Point(358, 149);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(95, 29);
            btnCancelar.TabIndex = 34;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(38, 246);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(58, 15);
            label7.TabIndex = 35;
            label7.Text = "Cantidad:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioLocal
            // 
            radioLocal.AutoSize = true;
            radioLocal.ForeColor = System.Drawing.Color.White;
            radioLocal.Location = new System.Drawing.Point(465, 109);
            radioLocal.Name = "radioLocal";
            radioLocal.Size = new System.Drawing.Size(53, 19);
            radioLocal.TabIndex = 36;
            radioLocal.Text = "Local";
            radioLocal.UseVisualStyleBackColor = true;
            // 
            // radioRepartidor
            // 
            radioRepartidor.AutoSize = true;
            radioRepartidor.Checked = true;
            radioRepartidor.ForeColor = System.Drawing.Color.White;
            radioRepartidor.Location = new System.Drawing.Point(465, 134);
            radioRepartidor.Name = "radioRepartidor";
            radioRepartidor.Size = new System.Drawing.Size(80, 19);
            radioRepartidor.TabIndex = 37;
            radioRepartidor.TabStop = true;
            radioRepartidor.Text = "Repartidor";
            radioRepartidor.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(465, 88);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(40, 15);
            label8.TabIndex = 38;
            label8.Text = "Retira:";
            // 
            // cboProducto
            // 
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new System.Drawing.Point(117, 204);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new System.Drawing.Size(235, 23);
            cboProducto.TabIndex = 39;
            cboProducto.SelectedIndexChanged += cboProducto_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label9.Location = new System.Drawing.Point(37, 207);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(59, 15);
            label9.TabIndex = 40;
            label9.Text = "Producto:";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PedidosForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(129, 136, 205);
            ClientSize = new System.Drawing.Size(830, 617);
            Controls.Add(label9);
            Controls.Add(cboProducto);
            Controls.Add(label8);
            Controls.Add(radioRepartidor);
            Controls.Add(radioLocal);
            Controls.Add(label7);
            Controls.Add(btnCancelar);
            Controls.Add(btnFinalizar);
            Controls.Add(label6);
            Controls.Add(txtDescripción);
            Controls.Add(label5);
            Controls.Add(btnComenzar);
            Controls.Add(btnQuitar);
            Controls.Add(dataGridView1);
            Controls.Add(btnAgregar);
            Controls.Add(txtCant);
            Controls.Add(btnMAS);
            Controls.Add(btnMenos);
            Controls.Add(cboTipoProducto);
            Controls.Add(cbCliente);
            Controls.Add(txtDireccion);
            Controls.Add(txtPedido);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PedidosForm";
            Text = "Pedidos";
            FormClosing += PedidosForm_FormClosing;
            FormClosed += PedidosForm_FormClosed;
            Load += PedidosForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cboTipoProducto;
        private FontAwesome.Sharp.IconButton btnMenos;
        private FontAwesome.Sharp.IconButton btnMAS;
        private System.Windows.Forms.TextBox txtCant;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnQuitar;
        private FontAwesome.Sharp.IconButton btnComenzar;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtDescripción;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnFinalizar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioLocal;
        private System.Windows.Forms.RadioButton radioRepartidor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label label9;
    }
}