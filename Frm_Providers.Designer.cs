namespace course_DB
{
    partial class Frm_Providers
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
            dataGridView = new DataGridView();
            btn_AddProvider = new Button();
            btn_UpdateProvider = new Button();
            btn_DeleteProvider = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(234, 30);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(609, 455);
            dataGridView.TabIndex = 0;
            // 
            // btn_AddProvider
            // 
            btn_AddProvider.Font = new Font("Segoe UI", 14F);
            btn_AddProvider.Location = new Point(12, 93);
            btn_AddProvider.Name = "btn_AddProvider";
            btn_AddProvider.Size = new Size(193, 73);
            btn_AddProvider.TabIndex = 1;
            btn_AddProvider.Text = "Додати почтачальника";
            btn_AddProvider.UseVisualStyleBackColor = true;
            btn_AddProvider.Click += btn_AddProvider_Click;
            // 
            // btn_UpdateProvider
            // 
            btn_UpdateProvider.Font = new Font("Segoe UI", 14F);
            btn_UpdateProvider.Location = new Point(12, 203);
            btn_UpdateProvider.Name = "btn_UpdateProvider";
            btn_UpdateProvider.Size = new Size(193, 73);
            btn_UpdateProvider.TabIndex = 2;
            btn_UpdateProvider.Text = "Редагувати дані";
            btn_UpdateProvider.UseVisualStyleBackColor = true;
            btn_UpdateProvider.Click += btn_UpdateProvider_Click;
            // 
            // btn_DeleteProvider
            // 
            btn_DeleteProvider.Font = new Font("Segoe UI", 14F);
            btn_DeleteProvider.Location = new Point(12, 314);
            btn_DeleteProvider.Name = "btn_DeleteProvider";
            btn_DeleteProvider.Size = new Size(193, 73);
            btn_DeleteProvider.TabIndex = 3;
            btn_DeleteProvider.Text = "Вилучити постачальника";
            btn_DeleteProvider.UseVisualStyleBackColor = true;
            btn_DeleteProvider.Click += btn_DeleteProvider_Click;
            // 
            // Frm_Providers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 525);
            Controls.Add(btn_DeleteProvider);
            Controls.Add(btn_UpdateProvider);
            Controls.Add(btn_AddProvider);
            Controls.Add(dataGridView);
            Name = "Frm_Providers";
            Text = "Frm_Providers";
            Load += Frm_Providers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private Button btn_AddProvider;
        private Button btn_UpdateProvider;
        private Button btn_DeleteProvider;
    }
}