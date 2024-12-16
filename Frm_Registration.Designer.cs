namespace course_DB
{
    partial class Регістрація
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tBox_Id = new TextBox();
            tBox_Name = new TextBox();
            tBox_Surname = new TextBox();
            tBox_Password = new TextBox();
            tBox_Position = new TextBox();
            btn_registration = new Button();
            tBox_AdminPassword = new TextBox();
            label6 = new Label();
            lb_rec = new Label();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(55, 32);
            label2.TabIndex = 1;
            label2.Text = "Ім'я";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(122, 32);
            label3.TabIndex = 2;
            label3.Text = "Прізвище";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 201);
            label4.Name = "label4";
            label4.Size = new Size(93, 32);
            label4.TabIndex = 3;
            label4.Text = "Посада";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 159);
            label5.Name = "label5";
            label5.Size = new Size(96, 32);
            label5.TabIndex = 4;
            label5.Text = "Пароль";
            // 
            // tBox_Id
            // 
            tBox_Id.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tBox_Id.Location = new Point(137, 6);
            tBox_Id.Name = "tBox_Id";
            tBox_Id.Size = new Size(322, 39);
            tBox_Id.TabIndex = 5;
            // 
            // tBox_Name
            // 
            tBox_Name.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tBox_Name.Location = new Point(137, 71);
            tBox_Name.Name = "tBox_Name";
            tBox_Name.Size = new Size(322, 39);
            tBox_Name.TabIndex = 6;
            // 
            // tBox_Surname
            // 
            tBox_Surname.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tBox_Surname.Location = new Point(137, 114);
            tBox_Surname.Name = "tBox_Surname";
            tBox_Surname.Size = new Size(322, 39);
            tBox_Surname.TabIndex = 7;
            // 
            // tBox_Password
            // 
            tBox_Password.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tBox_Password.Location = new Point(137, 156);
            tBox_Password.Name = "tBox_Password";
            tBox_Password.Size = new Size(322, 39);
            tBox_Password.TabIndex = 8;
            tBox_Password.UseSystemPasswordChar = true;
            // 
            // tBox_Position
            // 
            tBox_Position.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tBox_Position.Location = new Point(137, 198);
            tBox_Position.Name = "tBox_Position";
            tBox_Position.Size = new Size(322, 39);
            tBox_Position.TabIndex = 9;
            // 
            // btn_registration
            // 
            btn_registration.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_registration.Location = new Point(137, 290);
            btn_registration.Name = "btn_registration";
            btn_registration.Size = new Size(322, 41);
            btn_registration.TabIndex = 10;
            btn_registration.Text = "Зареєструвати";
            btn_registration.UseVisualStyleBackColor = true;
            btn_registration.Click += btn_registration_Click;
            // 
            // tBox_AdminPassword
            // 
            tBox_AdminPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tBox_AdminPassword.Location = new Point(269, 245);
            tBox_AdminPassword.Name = "tBox_AdminPassword";
            tBox_AdminPassword.Size = new Size(190, 39);
            tBox_AdminPassword.TabIndex = 13;
            tBox_AdminPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 245);
            label6.Name = "label6";
            label6.Size = new Size(262, 32);
            label6.TabIndex = 12;
            label6.Text = "Пароль адмінстратора";
            // 
            // lb_rec
            // 
            lb_rec.AutoSize = true;
            lb_rec.Location = new Point(137, 48);
            lb_rec.Name = "lb_rec";
            lb_rec.Size = new Size(158, 20);
            lb_rec.TabIndex = 14;
            lb_rec.Text = "*Рекомендоване ID - ";
            // 
            // Регістрація
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 342);
            Controls.Add(lb_rec);
            Controls.Add(tBox_AdminPassword);
            Controls.Add(label6);
            Controls.Add(btn_registration);
            Controls.Add(tBox_Position);
            Controls.Add(tBox_Password);
            Controls.Add(tBox_Surname);
            Controls.Add(tBox_Name);
            Controls.Add(tBox_Id);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Регістрація";
            Text = "Регістрація";
            Load += Регістрація_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tBox_Id;
        private TextBox tBox_Name;
        private TextBox tBox_Surname;
        private TextBox tBox_Password;
        private TextBox tBox_Position;
        private Button btn_registration;
        private TextBox tBox_AdminPassword;
        private Label label6;
        private Label lb_rec;
    }
}