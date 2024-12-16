namespace course_DB
{
    partial class Frm_DelivDelete
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
            tbox_ID = new TextBox();
            btn_delete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 0;
            label1.Text = "ID поставки";
            // 
            // tbox_ID
            // 
            tbox_ID.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_ID.Location = new Point(172, 29);
            tbox_ID.Name = "tbox_ID";
            tbox_ID.Size = new Size(165, 39);
            tbox_ID.TabIndex = 1;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_delete.Location = new Point(172, 86);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(165, 41);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "Видалити";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // Frm_DelivDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 155);
            Controls.Add(btn_delete);
            Controls.Add(tbox_ID);
            Controls.Add(label1);
            Name = "Frm_DelivDelete";
            Text = "Frm_DelivDelete";
            Load += Frm_DelivDelete_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbox_ID;
        private Button btn_delete;
    }
}