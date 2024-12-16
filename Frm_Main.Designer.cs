namespace course_DB
{
    partial class Frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            структураToolStripMenuItem = new ToolStripMenuItem();
            відкритиТаблицюПостачальниківToolStripMenuItem = new ToolStripMenuItem();
            відкритиТаблицюСкладToolStripMenuItem = new ToolStripMenuItem();
            відкритиТаблицюПоставкиToolStripMenuItem = new ToolStripMenuItem();
            відкритиТаблицюЗвітиToolStripMenuItem = new ToolStripMenuItem();
            відкритиТаблицюСтасистикаToolStripMenuItem = new ToolStripMenuItem();
            btn_AddItems = new Button();
            btn_UpdateItems = new Button();
            btn_CreateReceipt = new Button();
            lb_AllPrice = new Label();
            dataGridView1 = new DataGridView();
            btn_StartScaner = new Button();
            FinallyPrice = new Label();
            lb_Position = new Label();
            lb_Name = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, структураToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(962, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // структураToolStripMenuItem
            // 
            структураToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { відкритиТаблицюПостачальниківToolStripMenuItem, відкритиТаблицюСкладToolStripMenuItem, відкритиТаблицюПоставкиToolStripMenuItem, відкритиТаблицюЗвітиToolStripMenuItem, відкритиТаблицюСтасистикаToolStripMenuItem });
            структураToolStripMenuItem.Name = "структураToolStripMenuItem";
            структураToolStripMenuItem.Size = new Size(91, 24);
            структураToolStripMenuItem.Text = "Структура";
            // 
            // відкритиТаблицюПостачальниківToolStripMenuItem
            // 
            відкритиТаблицюПостачальниківToolStripMenuItem.Name = "відкритиТаблицюПостачальниківToolStripMenuItem";
            відкритиТаблицюПостачальниківToolStripMenuItem.Size = new Size(329, 26);
            відкритиТаблицюПостачальниківToolStripMenuItem.Text = "Відкрити таблицю Постачальники";
            відкритиТаблицюПостачальниківToolStripMenuItem.Click += відкритиТаблицюПостачальниківToolStripMenuItem_Click;
            // 
            // відкритиТаблицюСкладToolStripMenuItem
            // 
            відкритиТаблицюСкладToolStripMenuItem.Name = "відкритиТаблицюСкладToolStripMenuItem";
            відкритиТаблицюСкладToolStripMenuItem.Size = new Size(329, 26);
            відкритиТаблицюСкладToolStripMenuItem.Text = "Відкрити таблицю Склад";
            відкритиТаблицюСкладToolStripMenuItem.Click += відкритиТаблицюСкладToolStripMenuItem_Click;
            // 
            // відкритиТаблицюПоставкиToolStripMenuItem
            // 
            відкритиТаблицюПоставкиToolStripMenuItem.Name = "відкритиТаблицюПоставкиToolStripMenuItem";
            відкритиТаблицюПоставкиToolStripMenuItem.Size = new Size(329, 26);
            відкритиТаблицюПоставкиToolStripMenuItem.Text = "Відкрити таблицю Поставки";
            відкритиТаблицюПоставкиToolStripMenuItem.Click += відкритиТаблицюПоставкиToolStripMenuItem_Click;
            // 
            // відкритиТаблицюЗвітиToolStripMenuItem
            // 
            відкритиТаблицюЗвітиToolStripMenuItem.Name = "відкритиТаблицюЗвітиToolStripMenuItem";
            відкритиТаблицюЗвітиToolStripMenuItem.Size = new Size(329, 26);
            відкритиТаблицюЗвітиToolStripMenuItem.Text = "Відкрити таблицю Звіти";
            відкритиТаблицюЗвітиToolStripMenuItem.Click += відкритиТаблицюЗвітиToolStripMenuItem_Click;
            // 
            // відкритиТаблицюСтасистикаToolStripMenuItem
            // 
            відкритиТаблицюСтасистикаToolStripMenuItem.Name = "відкритиТаблицюСтасистикаToolStripMenuItem";
            відкритиТаблицюСтасистикаToolStripMenuItem.Size = new Size(329, 26);
            відкритиТаблицюСтасистикаToolStripMenuItem.Text = "Відкрити таблицю Статистика";
            відкритиТаблицюСтасистикаToolStripMenuItem.Click += відкритиТаблицюСтасистикаToolStripMenuItem_Click;
            // 
            // btn_AddItems
            // 
            btn_AddItems.Font = new Font("Segoe UI", 14F);
            btn_AddItems.Location = new Point(12, 453);
            btn_AddItems.Name = "btn_AddItems";
            btn_AddItems.Size = new Size(209, 46);
            btn_AddItems.TabIndex = 1;
            btn_AddItems.Text = "Додати товар";
            btn_AddItems.UseVisualStyleBackColor = true;
            btn_AddItems.Click += btn_AddItems_Click;
            // 
            // btn_UpdateItems
            // 
            btn_UpdateItems.Font = new Font("Segoe UI", 14F);
            btn_UpdateItems.Location = new Point(485, 453);
            btn_UpdateItems.Name = "btn_UpdateItems";
            btn_UpdateItems.Size = new Size(213, 46);
            btn_UpdateItems.TabIndex = 2;
            btn_UpdateItems.Text = "Змінити товар";
            btn_UpdateItems.UseVisualStyleBackColor = true;
            btn_UpdateItems.Click += btn_UpdateItems_Click;
            // 
            // btn_CreateReceipt
            // 
            btn_CreateReceipt.Font = new Font("Segoe UI", 14F);
            btn_CreateReceipt.Location = new Point(740, 440);
            btn_CreateReceipt.Name = "btn_CreateReceipt";
            btn_CreateReceipt.Size = new Size(198, 69);
            btn_CreateReceipt.TabIndex = 4;
            btn_CreateReceipt.Text = "Зробити чек";
            btn_CreateReceipt.UseVisualStyleBackColor = true;
            btn_CreateReceipt.Click += btn_CreateReceipt_Click;
            // 
            // lb_AllPrice
            // 
            lb_AllPrice.AutoSize = true;
            lb_AllPrice.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lb_AllPrice.ForeColor = Color.FromArgb(192, 0, 0);
            lb_AllPrice.Location = new Point(740, 380);
            lb_AllPrice.Name = "lb_AllPrice";
            lb_AllPrice.Size = new Size(142, 32);
            lb_AllPrice.TabIndex = 5;
            lb_AllPrice.Text = "До сплати:";
            lb_AllPrice.Click += lb_AllPrice_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(705, 389);
            dataGridView1.TabIndex = 6;
            // 
            // btn_StartScaner
            // 
            btn_StartScaner.Font = new Font("Segoe UI", 14F);
            btn_StartScaner.Location = new Point(246, 453);
            btn_StartScaner.Name = "btn_StartScaner";
            btn_StartScaner.Size = new Size(215, 46);
            btn_StartScaner.TabIndex = 7;
            btn_StartScaner.Text = "Сканувати товар";
            btn_StartScaner.UseVisualStyleBackColor = true;
            btn_StartScaner.Click += btn_StartScaner_Click;
            // 
            // FinallyPrice
            // 
            FinallyPrice.AutoSize = true;
            FinallyPrice.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            FinallyPrice.ForeColor = Color.Red;
            FinallyPrice.Location = new Point(885, 380);
            FinallyPrice.Name = "FinallyPrice";
            FinallyPrice.Size = new Size(0, 32);
            FinallyPrice.TabIndex = 8;
            // 
            // lb_Position
            // 
            lb_Position.AutoSize = true;
            lb_Position.Font = new Font("Segoe UI", 14F);
            lb_Position.Location = new Point(725, 47);
            lb_Position.Name = "lb_Position";
            lb_Position.Size = new Size(0, 32);
            lb_Position.TabIndex = 9;
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Font = new Font("Segoe UI", 14F);
            lb_Name.Location = new Point(725, 88);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(0, 32);
            lb_Name.TabIndex = 10;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 528);
            Controls.Add(lb_Name);
            Controls.Add(lb_Position);
            Controls.Add(FinallyPrice);
            Controls.Add(btn_StartScaner);
            Controls.Add(dataGridView1);
            Controls.Add(lb_AllPrice);
            Controls.Add(btn_CreateReceipt);
            Controls.Add(btn_UpdateItems);
            Controls.Add(btn_AddItems);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Frm_Main";
            Text = "Store Account";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private Button btn_AddItems;
        private Button btn_UpdateItems;
        private Button btn_CreateReceipt;
        private Label lb_AllPrice;
        public DataGridView dataGridView1;
        private ToolStripMenuItem структураToolStripMenuItem;
        private ToolStripMenuItem відкритиТаблицюПостачальниківToolStripMenuItem;
        private ToolStripMenuItem відкритиТаблицюСкладToolStripMenuItem;
        private ToolStripMenuItem відкритиТаблицюПоставкиToolStripMenuItem;
        private Button btn_StartScaner;
        private ToolStripMenuItem відкритиТаблицюЗвітиToolStripMenuItem;
        private ToolStripMenuItem відкритиТаблицюСтасистикаToolStripMenuItem;
        public Label FinallyPrice;
        public Label lb_Position;
        public Label lb_Name;
    }
}