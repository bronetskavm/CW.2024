namespace course_DB
{
    partial class Frm_Zvits
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
            dataGridView = new DataGridView();
            btn_CreateZvit = new Button();
            tBox_input = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(656, 426);
            dataGridView.TabIndex = 0;
            // 
            // btn_CreateZvit
            // 
            btn_CreateZvit.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_CreateZvit.Location = new Point(492, 449);
            btn_CreateZvit.Name = "btn_CreateZvit";
            btn_CreateZvit.Size = new Size(176, 47);
            btn_CreateZvit.TabIndex = 1;
            btn_CreateZvit.Text = "Зробити звіт";
            btn_CreateZvit.UseVisualStyleBackColor = true;
            btn_CreateZvit.Click += btn_CreateZvit_Click;
            // 
            // tBox_input
            // 
            tBox_input.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tBox_input.Location = new Point(194, 449);
            tBox_input.Name = "tBox_input";
            tBox_input.Size = new Size(227, 39);
            tBox_input.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 452);
            label1.Name = "label1";
            label1.Size = new Size(165, 32);
            label1.TabIndex = 3;
            label1.Text = "Виберіть дату";
            // 
            // Frm_Zvits
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 515);
            Controls.Add(label1);
            Controls.Add(tBox_input);
            Controls.Add(btn_CreateZvit);
            Controls.Add(dataGridView);
            Name = "Frm_Zvits";
            Text = "Frm_Zvits";
            Load += Frm_Zvits_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button btn_CreateZvit;
        private TextBox tBox_input;
        private Label label1;
    }
}