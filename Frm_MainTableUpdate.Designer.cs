namespace course_DB
{
    partial class Frm_MainTableUpdate
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
            label1 = new Label();
            tbox_id = new TextBox();
            btn_Update = new Button();
            tbox_number = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(37, 32);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // tbox_id
            // 
            tbox_id.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_id.Location = new Point(128, 2);
            tbox_id.Name = "tbox_id";
            tbox_id.Size = new Size(173, 39);
            tbox_id.TabIndex = 2;
            // 
            // btn_Update
            // 
            btn_Update.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Update.Location = new Point(128, 96);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(173, 49);
            btn_Update.TabIndex = 3;
            btn_Update.Text = "Змінити";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // tbox_number
            // 
            tbox_number.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_number.Location = new Point(128, 51);
            tbox_number.Name = "tbox_number";
            tbox_number.Size = new Size(173, 39);
            tbox_number.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(110, 32);
            label2.TabIndex = 5;
            label2.Text = "Кількість";
            // 
            // Frm_MainTableUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 150);
            Controls.Add(tbox_number);
            Controls.Add(label2);
            Controls.Add(btn_Update);
            Controls.Add(tbox_id);
            Controls.Add(label1);
            Name = "Frm_MainTableUpdate";
            Text = "Frm_MainTableUpdate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbox_id;
        private Button btn_Update;
        private TextBox tbox_number;
        private Label label2;
    }
}