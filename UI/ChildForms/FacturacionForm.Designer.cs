namespace UI.ChildForms
{
    partial class FacturacionForm
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
            dataGridViewPedidoId = new System.Windows.Forms.DataGridView();
            listBox1 = new System.Windows.Forms.ListBox();
            btnFacturar = new FontAwesome.Sharp.IconButton();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPedidoId).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPedidoId
            // 
            dataGridViewPedidoId.AllowUserToAddRows = false;
            dataGridViewPedidoId.AllowUserToDeleteRows = false;
            dataGridViewPedidoId.AllowUserToResizeColumns = false;
            dataGridViewPedidoId.AllowUserToResizeRows = false;
            dataGridViewPedidoId.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPedidoId.BackgroundColor = System.Drawing.Color.FromArgb(129, 136, 205);
            dataGridViewPedidoId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewPedidoId.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPedidoId.Location = new System.Drawing.Point(30, 113);
            dataGridViewPedidoId.Name = "dataGridViewPedidoId";
            dataGridViewPedidoId.ReadOnly = true;
            dataGridViewPedidoId.RowTemplate.Height = 25;
            dataGridViewPedidoId.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dataGridViewPedidoId.Size = new System.Drawing.Size(180, 259);
            dataGridViewPedidoId.TabIndex = 0;
            dataGridViewPedidoId.RowHeaderMouseClick += dataGridViewPedidoId_RowHeaderMouseClick;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new System.Drawing.Point(239, 113);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(242, 259);
            listBox1.TabIndex = 1;
            // 
            // btnFacturar
            // 
            btnFacturar.FlatAppearance.BorderSize = 0;
            btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFacturar.ForeColor = System.Drawing.Color.White;
            btnFacturar.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            btnFacturar.IconColor = System.Drawing.Color.White;
            btnFacturar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFacturar.Location = new System.Drawing.Point(539, 113);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new System.Drawing.Size(137, 56);
            btnFacturar.TabIndex = 2;
            btnFacturar.Text = "Facturar";
            btnFacturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnFacturar.UseVisualStyleBackColor = true;
            btnFacturar.Click += btnFacturar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label5.Location = new System.Drawing.Point(117, 9);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(430, 51);
            label5.TabIndex = 36;
            label5.Text = "Módulo Facturación";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(30, 95);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(47, 15);
            label1.TabIndex = 37;
            label1.Text = "Pedido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(239, 95);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 15);
            label2.TabIndex = 38;
            label2.Text = "Factura:";
            // 
            // FacturacionForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(129, 136, 205);
            ClientSize = new System.Drawing.Size(719, 384);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(btnFacturar);
            Controls.Add(listBox1);
            Controls.Add(dataGridViewPedidoId);
            Name = "FacturacionForm";
            Text = "Facturacion";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPedidoId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPedidoId;
        private System.Windows.Forms.ListBox listBox1;
        private FontAwesome.Sharp.IconButton btnFacturar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}