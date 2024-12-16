namespace course_DB
{
    partial class Frm_ViewZvit
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
            tBox_output = new TextBox();
            btn_CreateSave = new Button();
            SuspendLayout();
            // 
            // tBox_output
            // 
            tBox_output.Location = new Point(12, 13);
            tBox_output.Multiline = true;
            tBox_output.Name = "tBox_output";
            tBox_output.Size = new Size(776, 364);
            tBox_output.TabIndex = 0;
            // 
            // btn_CreateSave
            // 
            btn_CreateSave.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_CreateSave.Location = new Point(622, 383);
            btn_CreateSave.Name = "btn_CreateSave";
            btn_CreateSave.Size = new Size(166, 55);
            btn_CreateSave.TabIndex = 1;
            btn_CreateSave.Text = "Зберегти";
            btn_CreateSave.UseVisualStyleBackColor = true;
            btn_CreateSave.Click += btn_CreateSave_Click;
            // 
            // Frm_ViewZvit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_CreateSave);
            Controls.Add(tBox_output);
            Name = "Frm_ViewZvit";
            Text = "Frm_ViewZvit";
            Load += Frm_ViewZvit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tBox_output;
        private Button btn_CreateSave;
    }
}