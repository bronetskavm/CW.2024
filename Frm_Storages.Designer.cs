namespace course_DB
{
    partial class Frm_Storages
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
            dataGrid = new DataGridView();
            btn_Update = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(12, 12);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 51;
            dataGrid.RowTemplate.Height = 29;
            dataGrid.Size = new Size(886, 427);
            dataGrid.TabIndex = 0;
            // 
            // btn_Update
            // 
            btn_Update.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Update.Location = new Point(12, 456);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(202, 56);
            btn_Update.TabIndex = 2;
            btn_Update.Text = "Редагувати";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_delete.Location = new Point(220, 456);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(202, 56);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "Видалити товар";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // Frm_Storages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 524);
            Controls.Add(btn_delete);
            Controls.Add(btn_Update);
            Controls.Add(dataGrid);
            Name = "Frm_Storages";
            Text = "Frm_Storages";
            Load += Frm_Storages_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGrid;
        private Button btn_Update;
        private Button btn_delete;
    }
}