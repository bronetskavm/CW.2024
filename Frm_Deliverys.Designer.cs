namespace course_DB
{
    partial class Frm_Deliverys
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
            btn_DeleteDeliv = new Button();
            btn_UpdateDeliv = new Button();
            btn_AddDeliv = new Button();
            dataGridView = new DataGridView();
            btn_Scaner = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btn_DeleteDeliv
            // 
            btn_DeleteDeliv.Font = new Font("Segoe UI", 14F);
            btn_DeleteDeliv.Location = new Point(25, 398);
            btn_DeleteDeliv.Name = "btn_DeleteDeliv";
            btn_DeleteDeliv.Size = new Size(193, 73);
            btn_DeleteDeliv.TabIndex = 7;
            btn_DeleteDeliv.Text = "Вилучити поставку";
            btn_DeleteDeliv.UseVisualStyleBackColor = true;
            btn_DeleteDeliv.Click += btn_DeleteDeliv_Click;
            // 
            // btn_UpdateDeliv
            // 
            btn_UpdateDeliv.Font = new Font("Segoe UI", 14F);
            btn_UpdateDeliv.Location = new Point(25, 270);
            btn_UpdateDeliv.Name = "btn_UpdateDeliv";
            btn_UpdateDeliv.Size = new Size(193, 73);
            btn_UpdateDeliv.TabIndex = 6;
            btn_UpdateDeliv.Text = "Редагувати дані";
            btn_UpdateDeliv.UseVisualStyleBackColor = true;
            btn_UpdateDeliv.Click += btn_UpdateDeliv_Click;
            // 
            // btn_AddDeliv
            // 
            btn_AddDeliv.Font = new Font("Segoe UI", 14F);
            btn_AddDeliv.Location = new Point(25, 149);
            btn_AddDeliv.Name = "btn_AddDeliv";
            btn_AddDeliv.Size = new Size(193, 73);
            btn_AddDeliv.TabIndex = 5;
            btn_AddDeliv.Text = "Додати поставку";
            btn_AddDeliv.UseVisualStyleBackColor = true;
            btn_AddDeliv.Click += btn_AddDeliv_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(244, 29);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(591, 461);
            dataGridView.TabIndex = 4;
            // 
            // btn_Scaner
            // 
            btn_Scaner.Font = new Font("Segoe UI", 14F);
            btn_Scaner.Location = new Point(25, 38);
            btn_Scaner.Name = "btn_Scaner";
            btn_Scaner.Size = new Size(193, 73);
            btn_Scaner.TabIndex = 8;
            btn_Scaner.Text = "Сканувати товар";
            btn_Scaner.UseVisualStyleBackColor = true;
            btn_Scaner.Click += btn_Scaner_Click;
            // 
            // Frm_Deliverys
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 524);
            Controls.Add(btn_Scaner);
            Controls.Add(btn_DeleteDeliv);
            Controls.Add(btn_UpdateDeliv);
            Controls.Add(btn_AddDeliv);
            Controls.Add(dataGridView);
            Name = "Frm_Deliverys";
            Text = "Frm_Deliverys";
            Load += Frm_Deliverys_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_DeleteDeliv;
        private Button btn_UpdateDeliv;
        private Button btn_AddDeliv;
        private DataGridView dataGridView;
        private Button btn_Scaner;
    }
}