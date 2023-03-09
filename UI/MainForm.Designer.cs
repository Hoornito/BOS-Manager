
namespace UI
{
    partial class MainForm
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
            panelMenu = new System.Windows.Forms.Panel();
            btnVisualizar = new FontAwesome.Sharp.IconButton();
            btnAdministracion = new FontAwesome.Sharp.IconButton();
            btnClientes = new FontAwesome.Sharp.IconButton();
            btnReportes = new FontAwesome.Sharp.IconButton();
            btnFacturacion = new FontAwesome.Sharp.IconButton();
            btnPedidos = new FontAwesome.Sharp.IconButton();
            btnStock = new FontAwesome.Sharp.IconButton();
            panelLogo = new System.Windows.Forms.Panel();
            btnHome = new System.Windows.Forms.PictureBox();
            panelTitleBar = new System.Windows.Forms.Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            lblTitleChildForm = new System.Windows.Forms.Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconButton();
            panelShadow = new System.Windows.Forms.Panel();
            panelDesktop = new System.Windows.Forms.Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(iconButton2);
            panelMenu.Controls.Add(btnVisualizar);
            panelMenu.Controls.Add(btnAdministracion);
            panelMenu.Controls.Add(btnClientes);
            panelMenu.Controls.Add(btnReportes);
            panelMenu.Controls.Add(btnFacturacion);
            panelMenu.Controls.Add(btnPedidos);
            panelMenu.Controls.Add(btnStock);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            panelMenu.Location = new System.Drawing.Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new System.Drawing.Size(222, 634);
            panelMenu.TabIndex = 1;
            // 
            // btnVisualizar
            // 
            btnVisualizar.Dock = System.Windows.Forms.DockStyle.Top;
            btnVisualizar.FlatAppearance.BorderSize = 0;
            btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVisualizar.ForeColor = System.Drawing.Color.Gainsboro;
            btnVisualizar.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btnVisualizar.IconColor = System.Drawing.Color.Gainsboro;
            btnVisualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVisualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnVisualizar.Location = new System.Drawing.Point(0, 488);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new System.Drawing.Size(222, 60);
            btnVisualizar.TabIndex = 7;
            btnVisualizar.Text = "Visualizar pedidos";
            btnVisualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnVisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // btnAdministracion
            // 
            btnAdministracion.Dock = System.Windows.Forms.DockStyle.Top;
            btnAdministracion.FlatAppearance.BorderSize = 0;
            btnAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdministracion.ForeColor = System.Drawing.Color.Gainsboro;
            btnAdministracion.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            btnAdministracion.IconColor = System.Drawing.Color.Gainsboro;
            btnAdministracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdministracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAdministracion.Location = new System.Drawing.Point(0, 428);
            btnAdministracion.Name = "btnAdministracion";
            btnAdministracion.Size = new System.Drawing.Size(222, 60);
            btnAdministracion.TabIndex = 6;
            btnAdministracion.Text = "Administración";
            btnAdministracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAdministracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAdministracion.UseVisualStyleBackColor = true;
            btnAdministracion.Click += btnAdministracion_Click;
            // 
            // btnClientes
            // 
            btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClientes.ForeColor = System.Drawing.Color.Gainsboro;
            btnClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnClientes.IconColor = System.Drawing.Color.Gainsboro;
            btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnClientes.Location = new System.Drawing.Point(0, 368);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new System.Drawing.Size(222, 60);
            btnClientes.TabIndex = 5;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnReportes
            // 
            btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReportes.ForeColor = System.Drawing.Color.Gainsboro;
            btnReportes.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            btnReportes.IconColor = System.Drawing.Color.Gainsboro;
            btnReportes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnReportes.Location = new System.Drawing.Point(0, 308);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new System.Drawing.Size(222, 60);
            btnReportes.TabIndex = 4;
            btnReportes.Text = "Reportes";
            btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnFacturacion
            // 
            btnFacturacion.Dock = System.Windows.Forms.DockStyle.Top;
            btnFacturacion.FlatAppearance.BorderSize = 0;
            btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFacturacion.ForeColor = System.Drawing.Color.Gainsboro;
            btnFacturacion.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            btnFacturacion.IconColor = System.Drawing.Color.Gainsboro;
            btnFacturacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnFacturacion.Location = new System.Drawing.Point(0, 248);
            btnFacturacion.Name = "btnFacturacion";
            btnFacturacion.Size = new System.Drawing.Size(222, 60);
            btnFacturacion.TabIndex = 3;
            btnFacturacion.Text = "Facturación";
            btnFacturacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnFacturacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnFacturacion.UseVisualStyleBackColor = true;
            btnFacturacion.Click += btnFacturacion_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            btnPedidos.FlatAppearance.BorderSize = 0;
            btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPedidos.ForeColor = System.Drawing.Color.Gainsboro;
            btnPedidos.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            btnPedidos.IconColor = System.Drawing.Color.Gainsboro;
            btnPedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPedidos.Location = new System.Drawing.Point(0, 188);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new System.Drawing.Size(222, 60);
            btnPedidos.TabIndex = 2;
            btnPedidos.Text = "Pedidos";
            btnPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // btnStock
            // 
            btnStock.Dock = System.Windows.Forms.DockStyle.Top;
            btnStock.FlatAppearance.BorderSize = 0;
            btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStock.ForeColor = System.Drawing.Color.Gainsboro;
            btnStock.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            btnStock.IconColor = System.Drawing.Color.Gainsboro;
            btnStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnStock.Location = new System.Drawing.Point(0, 128);
            btnStock.Name = "btnStock";
            btnStock.Size = new System.Drawing.Size(222, 60);
            btnStock.TabIndex = 1;
            btnStock.Text = "Productos";
            btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = System.Drawing.Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(btnHome);
            panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            panelLogo.Location = new System.Drawing.Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new System.Drawing.Size(222, 128);
            panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Image = Properties.Resources.Pizza;
            btnHome.Location = new System.Drawing.Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new System.Drawing.Size(222, 128);
            btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += pictureBox1_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            panelTitleBar.Controls.Add(iconButton1);
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            panelTitleBar.Location = new System.Drawing.Point(222, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new System.Drawing.Size(1172, 65);
            panelTitleBar.TabIndex = 2;
            // 
            // iconButton1
            // 
            iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            iconButton1.IconColor = System.Drawing.SystemColors.ButtonFace;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new System.Drawing.Point(1067, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new System.Drawing.Size(105, 65);
            iconButton1.TabIndex = 2;
            iconButton1.Text = "Salir";
            iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            lblTitleChildForm.Location = new System.Drawing.Point(62, 25);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new System.Drawing.Size(40, 15);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            iconCurrentChildForm.FlatAppearance.BorderSize = 0;
            iconCurrentChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconCurrentChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            iconCurrentChildForm.IconColor = System.Drawing.Color.Gainsboro;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            iconCurrentChildForm.Location = new System.Drawing.Point(0, 0);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new System.Drawing.Size(56, 65);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            iconCurrentChildForm.UseVisualStyleBackColor = true;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = System.Drawing.Color.FromArgb(51, 51, 85);
            panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            panelShadow.Location = new System.Drawing.Point(222, 65);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new System.Drawing.Size(1172, 9);
            panelShadow.TabIndex = 3;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = System.Drawing.Color.FromArgb(129, 136, 205);
            panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            panelDesktop.Location = new System.Drawing.Point(222, 74);
            panelDesktop.MinimumSize = new System.Drawing.Size(1095, 525);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new System.Drawing.Size(1172, 560);
            panelDesktop.TabIndex = 4;
            // 
            // iconButton2
            // 
            iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton2.ForeColor = System.Drawing.Color.Gainsboro;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Cog;
            iconButton2.IconColor = System.Drawing.Color.Gainsboro;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            iconButton2.Location = new System.Drawing.Point(0, 548);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new System.Drawing.Size(222, 60);
            iconButton2.TabIndex = 8;
            iconButton2.Text = "Configuración de Usuario";
            iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1394, 634);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            MinimumSize = new System.Drawing.Size(1225, 623);
            Name = "MainForm";
            Text = "BOS Manager";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnAdministracion;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnReportes;
        private FontAwesome.Sharp.IconButton btnFacturacion;
        private FontAwesome.Sharp.IconButton btnPedidos;
        private FontAwesome.Sharp.IconButton btnStock;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton iconCurrentChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconButton btnVisualizar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}