namespace course_DB
{
    partial class Frm_ActionOnProviders
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
            label2 = new Label();
            tBox_Name = new TextBox();
            label3 = new Label();
            tBox_Surname = new TextBox();
            label4 = new Label();
            tBox_Contact = new TextBox();
            btn_Action = new Button();
            btn_search = new Button();
            SuspendLayout();
            // 
            // tBox_Id
            // 
            tBox_Id.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tBox_Id.Location = new Point(138, 15);
            tBox_Id.Name = "tBox_Id";
            tBox_Id.Size = new Size(237, 39);
            tBox_Id.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(44, 32);
            label1.TabIndex = 1;
            label1.Text = "ID ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(55, 32);
            label2.TabIndex = 3;
            label2.Text = "Ім'я";
            // 
            // tBox_Name
            // 
            tBox_Name.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tBox_Name.Location = new Point(138, 60);
            tBox_Name.Name = "tBox_Name";
            tBox_Name.Size = new Size(237, 39);
            tBox_Name.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(122, 32);
            label3.TabIndex = 5;
            label3.Text = "Прізвище";
            // 
            // tBox_Surname
            // 
            tBox_Surname.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tBox_Surname.Location = new Point(138, 105);
            tBox_Surname.Name = "tBox_Surname";
            tBox_Surname.Size = new Size(237, 39);
            tBox_Surname.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 150);
            label4.Name = "label4";
            label4.Size = new Size(100, 32);
            label4.TabIndex = 7;
            label4.Text = "Контакт";
            // 
            // tBox_Contact
            // 
            tBox_Contact.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tBox_Contact.Location = new Point(138, 150);
            tBox_Contact.Name = "tBox_Contact";
            tBox_Contact.Size = new Size(237, 39);
            tBox_Contact.TabIndex = 6;
            // 
            // btn_Action
            // 
            btn_Action.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Action.Location = new Point(138, 212);
            btn_Action.Name = "btn_Action";
            btn_Action.Size = new Size(237, 43);
            btn_Action.TabIndex = 8;
            btn_Action.Text = "Додати";
            btn_Action.UseVisualStyleBackColor = true;
            btn_Action.Click += btn_Action_Click;
            // 
            // btn_search
            // 
            btn_search.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_search.Location = new Point(12, 214);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(110, 41);
            btn_search.TabIndex = 9;
            btn_search.Text = "Шукати";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // Frm_ActionOnProviders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 267);
            Controls.Add(btn_search);
            Controls.Add(btn_Action);
            Controls.Add(label4);
            Controls.Add(tBox_Contact);
            Controls.Add(label3);
            Controls.Add(tBox_Surname);
            Controls.Add(label2);
            Controls.Add(tBox_Name);
            Controls.Add(label1);
            Controls.Add(tBox_Id);
            Name = "Frm_ActionOnProviders";
            Text = "Frm_ActionOnProviders";
            Load += Frm_ActionOnProviders_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tBox_Id;
        private Label label1;
        private Label label2;
        private TextBox tBox_Name;
        private Label label3;
        private TextBox tBox_Surname;
        private Label label4;
        private TextBox tBox_Contact;
        private Button btn_Action;
        private Button btn_search;
    }
}