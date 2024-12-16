namespace course_DB
{
    partial class Frm_AllZvitsStatics
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
            label1 = new Label();
            lb_value = new Label();
            btn_refresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 14);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(542, 381);
            dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 401);
            label1.Name = "label1";
            label1.Size = new Size(174, 32);
            label1.TabIndex = 1;
            label1.Text = "Чистий дохід -";
            // 
            // lb_value
            // 
            lb_value.AutoSize = true;
            lb_value.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lb_value.ForeColor = Color.Red;
            lb_value.Location = new Point(192, 396);
            lb_value.Name = "lb_value";
            lb_value.Size = new Size(0, 37);
            lb_value.TabIndex = 2;
            // 
            // btn_refresh
            // 
            btn_refresh.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_refresh.Location = new Point(389, 401);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(165, 41);
            btn_refresh.TabIndex = 3;
            btn_refresh.Text = "Обновити";
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // Frm_AllZvitsStatics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 450);
            Controls.Add(btn_refresh);
            Controls.Add(lb_value);
            Controls.Add(label1);
            Controls.Add(dataGridView);
            Name = "Frm_AllZvitsStatics";
            Text = "Frm_AllZvitsStatics";
            Load += Frm_AllZvitsStatics_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Label label1;
        private Label lb_value;
        private Button btn_refresh;
    }
}