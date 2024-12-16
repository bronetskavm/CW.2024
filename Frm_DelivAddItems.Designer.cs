namespace course_DB
{
    partial class Frm_DelivAddItems
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
            btn_Add = new Button();
            tBox_ID = new TextBox();
            tBox_ProdId = new TextBox();
            label2 = new Label();
            tBox_Name = new TextBox();
            label3 = new Label();
            tBox_Number = new TextBox();
            label4 = new Label();
            tBox_Price = new TextBox();
            label5 = new Label();
            tBox_Arrival = new TextBox();
            label7 = new Label();
            tBox_ProvId = new TextBox();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 0;
            label1.Text = "ID поставки";
            // 
            // btn_Add
            // 
            btn_Add.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Add.Location = new Point(219, 321);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(289, 52);
            btn_Add.TabIndex = 1;
            btn_Add.Text = "Добавити";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // tBox_ID
            // 
            tBox_ID.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tBox_ID.Location = new Point(219, 6);
            tBox_ID.Name = "tBox_ID";
            tBox_ID.Size = new Size(289, 39);
            tBox_ID.TabIndex = 2;
            // 
            // tBox_ProdId
            // 
            tBox_ProdId.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tBox_ProdId.Location = new Point(219, 51);
            tBox_ProdId.Name = "tBox_ProdId";
            tBox_ProdId.Size = new Size(289, 39);
            tBox_ProdId.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 3;
            label2.Text = "ID товару ";
            // 
            // tBox_Name
            // 
            tBox_Name.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tBox_Name.Location = new Point(219, 96);
            tBox_Name.Name = "tBox_Name";
            tBox_Name.Size = new Size(289, 39);
            tBox_Name.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(161, 32);
            label3.TabIndex = 5;
            label3.Text = "Назва товару";
            // 
            // tBox_Number
            // 
            tBox_Number.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tBox_Number.Location = new Point(219, 141);
            tBox_Number.Name = "tBox_Number";
            tBox_Number.Size = new Size(289, 39);
            tBox_Number.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 144);
            label4.Name = "label4";
            label4.Size = new Size(110, 32);
            label4.TabIndex = 7;
            label4.Text = "Кількість";
            // 
            // tBox_Price
            // 
            tBox_Price.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tBox_Price.Location = new Point(219, 186);
            tBox_Price.Name = "tBox_Price";
            tBox_Price.Size = new Size(289, 39);
            tBox_Price.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 189);
            label5.Name = "label5";
            label5.Size = new Size(102, 32);
            label5.TabIndex = 9;
            label5.Text = "Ціна/шт";
            // 
            // tBox_Arrival
            // 
            tBox_Arrival.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tBox_Arrival.Location = new Point(219, 231);
            tBox_Arrival.MaxLength = 10;
            tBox_Arrival.Name = "tBox_Arrival";
            tBox_Arrival.Size = new Size(289, 39);
            tBox_Arrival.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 234);
            label7.Name = "label7";
            label7.Size = new Size(172, 32);
            label7.TabIndex = 13;
            label7.Text = "Дата прибуття";
            // 
            // tBox_ProvId
            // 
            tBox_ProvId.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tBox_ProvId.Location = new Point(219, 276);
            tBox_ProvId.Name = "tBox_ProvId";
            tBox_ProvId.Size = new Size(289, 39);
            tBox_ProvId.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 279);
            label6.Name = "label6";
            label6.Size = new Size(208, 32);
            label6.TabIndex = 15;
            label6.Text = "ID постачальника";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(22, 321);
            button1.Name = "button1";
            button1.Size = new Size(182, 52);
            button1.TabIndex = 17;
            button1.Text = "Знайти по ID";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Frm_DelivAddItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 379);
            Controls.Add(button1);
            Controls.Add(tBox_ProvId);
            Controls.Add(label6);
            Controls.Add(tBox_Arrival);
            Controls.Add(label7);
            Controls.Add(tBox_Price);
            Controls.Add(label5);
            Controls.Add(tBox_Number);
            Controls.Add(label4);
            Controls.Add(tBox_Name);
            Controls.Add(label3);
            Controls.Add(tBox_ProdId);
            Controls.Add(label2);
            Controls.Add(tBox_ID);
            Controls.Add(btn_Add);
            Controls.Add(label1);
            Name = "Frm_DelivAddItems";
            Text = "Frm_DelivAddItems";
            Load += Frm_DelivAddItems_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Add;
        private TextBox tBox_ID;
        private TextBox tBox_ProdId;
        private Label label2;
        private TextBox tBox_Name;
        private Label label3;
        private TextBox tBox_Number;
        private Label label4;
        private TextBox tBox_Price;
        private Label label5;
        private TextBox tBox_Arrival;
        private Label label7;
        private TextBox tBox_ProvId;
        private Label label6;
        private Button button1;
    }
}