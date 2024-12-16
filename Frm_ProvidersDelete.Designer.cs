namespace course_DB
{
    partial class Frm_ProvidersDelete
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
            btn_delete = new Button();
            label1 = new Label();
            tbox_ID = new TextBox();
            SuspendLayout();
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_delete.Location = new Point(226, 65);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(173, 41);
            btn_delete.TabIndex = 0;
            btn_delete.Text = "Видалити";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(208, 32);
            label1.TabIndex = 1;
            label1.Text = "ID постачальника";
            // 
            // tbox_ID
            // 
            tbox_ID.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_ID.Location = new Point(226, 20);
            tbox_ID.Name = "tbox_ID";
            tbox_ID.Size = new Size(173, 39);
            tbox_ID.TabIndex = 2;
            // 
            // Frm_ProvidersDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 124);
            Controls.Add(tbox_ID);
            Controls.Add(label1);
            Controls.Add(btn_delete);
            Name = "Frm_ProvidersDelete";
            Text = "Frm_ProvidersDdelete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_delete;
        private Label label1;
        private TextBox tbox_ID;
    }
}