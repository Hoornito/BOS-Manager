namespace UI.ChildForms
{
    partial class VisualizarPedidosForm
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
            this.dataGridViewPedidoId = new System.Windows.Forms.DataGridView();
            this.btnRefrescar = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.dataGridViewPedidoDetalle = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidoId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidoDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPedidoId
            // 
            this.dataGridViewPedidoId.AllowUserToAddRows = false;
            this.dataGridViewPedidoId.AllowUserToDeleteRows = false;
            this.dataGridViewPedidoId.AllowUserToResizeColumns = false;
            this.dataGridViewPedidoId.AllowUserToResizeRows = false;
            this.dataGridViewPedidoId.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPedidoId.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(136)))), ((int)(((byte)(205)))));
            this.dataGridViewPedidoId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPedidoId.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidoId.Location = new System.Drawing.Point(60, 131);
            this.dataGridViewPedidoId.Name = "dataGridViewPedidoId";
            this.dataGridViewPedidoId.RowTemplate.Height = 25;
            this.dataGridViewPedidoId.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewPedidoId.Size = new System.Drawing.Size(163, 271);
            this.dataGridViewPedidoId.TabIndex = 0;
            this.dataGridViewPedidoId.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPedidoId_RowHeaderMouseClick);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.FlatAppearance.BorderSize = 0;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.ForeColor = System.Drawing.Color.White;
            this.btnRefrescar.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btnRefrescar.IconColor = System.Drawing.Color.White;
            this.btnRefrescar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefrescar.Location = new System.Drawing.Point(571, 351);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(130, 51);
            this.btnRefrescar.TabIndex = 1;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.FastForward;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(571, 131);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(130, 50);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.Text = "Terminar";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // dataGridViewPedidoDetalle
            // 
            this.dataGridViewPedidoDetalle.AllowUserToAddRows = false;
            this.dataGridViewPedidoDetalle.AllowUserToDeleteRows = false;
            this.dataGridViewPedidoDetalle.AllowUserToResizeColumns = false;
            this.dataGridViewPedidoDetalle.AllowUserToResizeRows = false;
            this.dataGridViewPedidoDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPedidoDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(136)))), ((int)(((byte)(205)))));
            this.dataGridViewPedidoDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPedidoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidoDetalle.Location = new System.Drawing.Point(259, 131);
            this.dataGridViewPedidoDetalle.Name = "dataGridViewPedidoDetalle";
            this.dataGridViewPedidoDetalle.RowTemplate.Height = 25;
            this.dataGridViewPedidoDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewPedidoDetalle.Size = new System.Drawing.Size(258, 271);
            this.dataGridViewPedidoDetalle.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(135, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(567, 51);
            this.label5.TabIndex = 36;
            this.label5.Text = "Módulo Visualizar Pedidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "Pedido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(259, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Detalle:";
            // 
            // VisualizarPedidosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(136)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(838, 454);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewPedidoDetalle);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.dataGridViewPedidoId);
            this.Name = "VisualizarPedidosForm";
            this.Text = "VisualizarPedidosForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidoId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidoDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPedidoId;
        private FontAwesome.Sharp.IconButton btnRefrescar;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.DataGridView dataGridViewPedidoDetalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}