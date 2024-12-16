namespace course_DB
{
    partial class Frm_LogIn
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
            tBox_Surname = new TextBox();
            tBox_Password = new TextBox();
            label2 = new Label();
            btn_login = new Button();
            link_newAccount = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 0;
            label1.Text = "Прізвище:";
            label1.Click += label1_Click;
            // 
            // tBox_Surname
            // 
            tBox_Surname.Font = new Font("Segoe UI", 14F);
            tBox_Surname.Location = new Point(148, 21);
            tBox_Surname.Name = "tBox_Surname";
            tBox_Surname.Size = new Size(293, 39);
            tBox_Surname.TabIndex = 1;
            // 
            // tBox_Password
            // 
            tBox_Password.Font = new Font("Segoe UI", 14F);
            tBox_Password.HideSelection = false;
            tBox_Password.Location = new Point(148, 66);
            tBox_Password.Name = "tBox_Password";
            tBox_Password.Size = new Size(293, 39);
            tBox_Password.TabIndex = 3;
            tBox_Password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(101, 32);
            label2.TabIndex = 2;
            label2.Text = "Пароль:";
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 14F);
            btn_login.Location = new Point(39, 123);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(156, 42);
            btn_login.TabIndex = 4;
            btn_login.Text = "Увійти";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // link_newAccount
            // 
            link_newAccount.AutoSize = true;
            link_newAccount.Location = new Point(235, 138);
            link_newAccount.Name = "link_newAccount";
            link_newAccount.Size = new Size(206, 20);
            link_newAccount.TabIndex = 5;
            link_newAccount.TabStop = true;
            link_newAccount.Text = "Зареєструвати новий акаунт";
            link_newAccount.LinkClicked += link_newAccount_LinkClicked;
            // 
            // Frm_LogIn
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(460, 177);
            Controls.Add(link_newAccount);
            Controls.Add(btn_login);
            Controls.Add(tBox_Password);
            Controls.Add(label2);
            Controls.Add(tBox_Surname);
            Controls.Add(label1);
            Name = "Frm_LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            TopMost = true;
            Load += Frm_LogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tBox_Surname;
        private TextBox tBox_Password;
        private Label label2;
        private Button btn_login;
        private LinkLabel link_newAccount;
    }
}