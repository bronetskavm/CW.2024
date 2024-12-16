namespace course_DB
{
    partial class Frm_StorageDelete
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
            tBox_Id = new TextBox();
            label1 = new Label();
            btn_delete = new Button();
            SuspendLayout();
            // 
            // tBox_Id
            // 
            tBox_Id.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tBox_Id.Location = new Point(136, 12);
            tBox_Id.Name = "tBox_Id";
            tBox_Id.Size = new Size(173, 39);
            tBox_Id.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 12);
            label1.Name = "label1";
            label1.Size = new Size(119, 32);
            label1.TabIndex = 4;
            label1.Text = "ID товару";
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_delete.Location = new Point(136, 57);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(173, 41);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "Видалити";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // Frm_StorageDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 110);
            Controls.Add(tBox_Id);
            Controls.Add(label1);
            Controls.Add(btn_delete);
            Name = "Frm_StorageDelete";
            Text = "Frm_StorageDelete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tBox_Id;
        private Label label1;
        private Button btn_delete;
    }
}