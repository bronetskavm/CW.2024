namespace course_DB
{
    partial class Frm_Scaner
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
            components = new System.ComponentModel.Container();
            pictureBox = new PictureBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            btn_StopScan = new Button();
            btn_StartScan = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_ChangeCamera = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(12, 22);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(554, 372);
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(597, 22);
            label1.Name = "label1";
            label1.Size = new Size(198, 32);
            label1.TabIndex = 1;
            label1.Text = "Виберіть камеру";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(597, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(222, 39);
            comboBox1.TabIndex = 2;
            // 
            // btn_StopScan
            // 
            btn_StopScan.Font = new Font("Segoe UI", 14F);
            btn_StopScan.Location = new Point(597, 338);
            btn_StopScan.Name = "btn_StopScan";
            btn_StopScan.Size = new Size(242, 46);
            btn_StopScan.TabIndex = 3;
            btn_StopScan.Text = "Завершити сканування";
            btn_StopScan.UseVisualStyleBackColor = true;
            btn_StopScan.Click += btn_StopScan_Click;
            // 
            // btn_StartScan
            // 
            btn_StartScan.Font = new Font("Segoe UI", 14F);
            btn_StartScan.Location = new Point(597, 237);
            btn_StartScan.Name = "btn_StartScan";
            btn_StartScan.Size = new Size(242, 68);
            btn_StartScan.TabIndex = 4;
            btn_StartScan.Text = "Почати сканування";
            btn_StartScan.UseVisualStyleBackColor = true;
            btn_StartScan.Click += btn_StartScan_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btn_ChangeCamera
            // 
            btn_ChangeCamera.Font = new Font("Segoe UI", 14F);
            btn_ChangeCamera.Location = new Point(597, 133);
            btn_ChangeCamera.Name = "btn_ChangeCamera";
            btn_ChangeCamera.Size = new Size(205, 39);
            btn_ChangeCamera.TabIndex = 5;
            btn_ChangeCamera.Text = "Вибрати камеру";
            btn_ChangeCamera.UseVisualStyleBackColor = true;
            btn_ChangeCamera.Click += btn_ChangeCamera_Click;
            // 
            // Frm_Scaner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 419);
            Controls.Add(btn_ChangeCamera);
            Controls.Add(btn_StartScan);
            Controls.Add(btn_StopScan);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox);
            Name = "Frm_Scaner";
            Text = "Frm_Scaner";
            Load += Frm_Scaner_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Label label1;
        private ComboBox comboBox1;
        private Button btn_StopScan;
        private Button btn_StartScan;
        private System.Windows.Forms.Timer timer1;
        private Button btn_ChangeCamera;
    }
}