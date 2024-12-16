namespace course_DB
{
    partial class Frm_AddItems
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
            dataGridOutputStorage = new DataGridView();
            tBox_inputId = new TextBox();
            label1 = new Label();
            btn_addItems = new Button();
            numUpDowm = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridOutputStorage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpDowm).BeginInit();
            SuspendLayout();
            // 
            // dataGridOutputStorage
            // 
            dataGridOutputStorage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOutputStorage.Location = new Point(12, 12);
            dataGridOutputStorage.Name = "dataGridOutputStorage";
            dataGridOutputStorage.RowHeadersWidth = 51;
            dataGridOutputStorage.RowTemplate.Height = 29;
            dataGridOutputStorage.Size = new Size(518, 422);
            dataGridOutputStorage.TabIndex = 0;
            // 
            // tBox_inputId
            // 
            tBox_inputId.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tBox_inputId.Location = new Point(225, 442);
            tBox_inputId.Name = "tBox_inputId";
            tBox_inputId.Size = new Size(187, 39);
            tBox_inputId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 445);
            label1.Name = "label1";
            label1.Size = new Size(207, 32);
            label1.TabIndex = 2;
            label1.Text = "Введіть ID товару";
            // 
            // btn_addItems
            // 
            btn_addItems.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_addItems.Location = new Point(428, 440);
            btn_addItems.Name = "btn_addItems";
            btn_addItems.Size = new Size(102, 41);
            btn_addItems.TabIndex = 3;
            btn_addItems.Text = "Додати товар";
            btn_addItems.UseVisualStyleBackColor = true;
            btn_addItems.Click += btn_addItems_Click;
            // 
            // numUpDowm
            // 
            numUpDowm.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            numUpDowm.Location = new Point(225, 487);
            numUpDowm.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUpDowm.Name = "numUpDowm";
            numUpDowm.Size = new Size(85, 39);
            numUpDowm.TabIndex = 4;
            numUpDowm.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 494);
            label2.Name = "label2";
            label2.Size = new Size(192, 32);
            label2.TabIndex = 5;
            label2.Text = "Кількість товару";
            // 
            // Frm_AddItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 535);
            Controls.Add(label2);
            Controls.Add(numUpDowm);
            Controls.Add(btn_addItems);
            Controls.Add(label1);
            Controls.Add(tBox_inputId);
            Controls.Add(dataGridOutputStorage);
            Name = "Frm_AddItems";
            Text = "Frm_AddItems";
            Load += Frm_AddItems_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridOutputStorage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpDowm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridOutputStorage;
        private TextBox tBox_inputId;
        private Label label1;
        private Button btn_addItems;
        private NumericUpDown numUpDowm;
        private Label label2;
    }
}