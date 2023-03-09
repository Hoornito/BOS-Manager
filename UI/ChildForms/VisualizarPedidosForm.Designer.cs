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
            components = new System.ComponentModel.Container();
            dataGridViewPedidoId = new System.Windows.Forms.DataGridView();
            btnRefrescar = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            dataGridViewPedidoDetalle = new System.Windows.Forms.DataGridView();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPedidoId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPedidoDetalle).BeginInit();
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
            dataGridViewPedidoId.Location = new System.Drawing.Point(60, 131);
            dataGridViewPedidoId.Name = "dataGridViewPedidoId";
            dataGridViewPedidoId.RowTemplate.Height = 25;
            dataGridViewPedidoId.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dataGridViewPedidoId.Size = new System.Drawing.Size(163, 271);
            dataGridViewPedidoId.TabIndex = 0;
            dataGridViewPedidoId.RowHeaderMouseClick += dataGridViewPedidoId_RowHeaderMouseClick;
            // 
            // btnRefrescar
            // 
            btnRefrescar.FlatAppearance.BorderSize = 0;
            btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefrescar.ForeColor = System.Drawing.Color.White;
            btnRefrescar.IconChar = FontAwesome.Sharp.IconChar.Sync;
            btnRefrescar.IconColor = System.Drawing.Color.White;
            btnRefrescar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefrescar.Location = new System.Drawing.Point(654, 351);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new System.Drawing.Size(130, 51);
            btnRefrescar.TabIndex = 1;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // iconButton2
            // 
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton2.ForeColor = System.Drawing.Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.FastForward;
            iconButton2.IconColor = System.Drawing.Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new System.Drawing.Point(654, 131);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new System.Drawing.Size(130, 50);
            iconButton2.TabIndex = 2;
            iconButton2.Text = "Terminar";
            iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // dataGridViewPedidoDetalle
            // 
            dataGridViewPedidoDetalle.AllowUserToAddRows = false;
            dataGridViewPedidoDetalle.AllowUserToDeleteRows = false;
            dataGridViewPedidoDetalle.AllowUserToResizeColumns = false;
            dataGridViewPedidoDetalle.AllowUserToResizeRows = false;
            dataGridViewPedidoDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPedidoDetalle.BackgroundColor = System.Drawing.Color.FromArgb(129, 136, 205);
            dataGridViewPedidoDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewPedidoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPedidoDetalle.Location = new System.Drawing.Point(259, 131);
            dataGridViewPedidoDetalle.Name = "dataGridViewPedidoDetalle";
            dataGridViewPedidoDetalle.RowTemplate.Height = 25;
            dataGridViewPedidoDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dataGridViewPedidoDetalle.Size = new System.Drawing.Size(363, 271);
            dataGridViewPedidoDetalle.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label5.Location = new System.Drawing.Point(135, 28);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(567, 51);
            label5.TabIndex = 36;
            label5.Text = "Módulo Visualizar Pedidos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(60, 113);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(47, 15);
            label1.TabIndex = 37;
            label1.Text = "Pedido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(259, 113);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 15);
            label2.TabIndex = 38;
            label2.Text = "Detalle:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 60000;
            timer1.Tick += timer1_Tick;
            // 
            // VisualizarPedidosForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(129, 136, 205);
            ClientSize = new System.Drawing.Size(838, 454);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(dataGridViewPedidoDetalle);
            Controls.Add(iconButton2);
            Controls.Add(btnRefrescar);
            Controls.Add(dataGridViewPedidoId);
            Name = "VisualizarPedidosForm";
            Text = "Visualizar Pedidos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPedidoId).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPedidoDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPedidoId;
        private FontAwesome.Sharp.IconButton btnRefrescar;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.DataGridView dataGridViewPedidoDetalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}