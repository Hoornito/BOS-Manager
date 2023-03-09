namespace UI.ChildForms.Composite
{
    partial class BitacoraForm
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
            LogView = new System.Windows.Forms.DataGridView();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            cb_severidad = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)LogView).BeginInit();
            SuspendLayout();
            // 
            // LogView
            // 
            LogView.AllowUserToAddRows = false;
            LogView.AllowUserToDeleteRows = false;
            LogView.AllowUserToOrderColumns = true;
            LogView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            LogView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            LogView.BackgroundColor = System.Drawing.Color.FromArgb(129, 136, 205);
            LogView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            LogView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LogView.Location = new System.Drawing.Point(47, 99);
            LogView.Name = "LogView";
            LogView.ReadOnly = true;
            LogView.RowTemplate.Height = 25;
            LogView.Size = new System.Drawing.Size(699, 339);
            LogView.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(47, 32);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(241, 23);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // cb_severidad
            // 
            cb_severidad.FormattingEnabled = true;
            cb_severidad.Items.AddRange(new object[] { "Todos", "INFO", "WARN", "ERROR" });
            cb_severidad.Location = new System.Drawing.Point(625, 32);
            cb_severidad.Name = "cb_severidad";
            cb_severidad.Size = new System.Drawing.Size(121, 23);
            cb_severidad.TabIndex = 2;
            cb_severidad.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label1.Location = new System.Drawing.Point(558, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 15);
            label1.TabIndex = 3;
            label1.Text = "Severidad:";
            // 
            // BitacoraForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(129, 136, 205);
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label1);
            Controls.Add(cb_severidad);
            Controls.Add(dateTimePicker1);
            Controls.Add(LogView);
            Name = "BitacoraForm";
            Text = "Bitacora";
            ((System.ComponentModel.ISupportInitialize)LogView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView LogView;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cb_severidad;
        private System.Windows.Forms.Label label1;
    }
}