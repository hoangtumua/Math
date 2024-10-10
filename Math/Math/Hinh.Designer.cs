namespace Math
{
    partial class Hinh
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
            Giai = new Button();
            Quit = new Button();
            txt5 = new TextBox();
            txt1 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt6 = new TextBox();
            label6 = new Label();
            txt2 = new TextBox();
            groupBox2 = new GroupBox();
            txt4 = new TextBox();
            txt3 = new TextBox();
            groupBox3 = new GroupBox();
            label3 = new Label();
            Ref = new Button();
            comboBox1 = new ComboBox();
            Back_Btn = new Button();
            groupBox4 = new GroupBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // Giai
            // 
            Giai.BackColor = Color.Honeydew;
            Giai.Font = new Font("Dongle", 18F, FontStyle.Bold);
            Giai.Location = new Point(213, 177);
            Giai.Margin = new Padding(4);
            Giai.Name = "Giai";
            Giai.Size = new Size(104, 57);
            Giai.TabIndex = 2;
            Giai.Text = "Giải";
            Giai.UseVisualStyleBackColor = false;
            Giai.Click += Giai_Click;
            // 
            // Quit
            // 
            Quit.BackColor = Color.Honeydew;
            Quit.Font = new Font("Dongle", 18F, FontStyle.Bold);
            Quit.Location = new Point(213, 251);
            Quit.Name = "Quit";
            Quit.Size = new Size(104, 59);
            Quit.TabIndex = 18;
            Quit.Text = "Thoát";
            Quit.UseVisualStyleBackColor = false;
            Quit.Click += Quit_Click;
            // 
            // txt5
            // 
            txt5.Location = new Point(125, 103);
            txt5.Name = "txt5";
            txt5.ReadOnly = true;
            txt5.Size = new Size(183, 51);
            txt5.TabIndex = 24;
            txt5.TextChanged += txt5_TextChanged;
            // 
            // txt1
            // 
            txt1.Location = new Point(125, 50);
            txt1.Name = "txt1";
            txt1.Size = new Size(183, 51);
            txt1.TabIndex = 26;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(23, -137);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(205, 51);
            textBox4.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 125);
            label2.Name = "label2";
            label2.Size = new Size(115, 43);
            label2.TabIndex = 28;
            label2.Text = "Chiều rộng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 58);
            label1.Name = "label1";
            label1.Size = new Size(101, 43);
            label1.TabIndex = 28;
            label1.Text = "Chiều dài";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 40);
            label4.Name = "label4";
            label4.Size = new Size(74, 43);
            label4.TabIndex = 28;
            label4.Text = "Chu vi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 111);
            label5.Name = "label5";
            label5.Size = new Size(98, 43);
            label5.TabIndex = 28;
            label5.Text = "Diện tích";
            // 
            // txt6
            // 
            txt6.Location = new Point(450, 32);
            txt6.Name = "txt6";
            txt6.ReadOnly = true;
            txt6.Size = new Size(183, 51);
            txt6.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(325, 40);
            label6.Name = "label6";
            label6.Size = new Size(90, 43);
            label6.TabIndex = 28;
            label6.Text = "Thể tích";
            // 
            // txt2
            // 
            txt2.Location = new Point(125, 117);
            txt2.Name = "txt2";
            txt2.Size = new Size(183, 51);
            txt2.TabIndex = 27;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.PapayaWhip;
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(txt6);
            groupBox2.Controls.Add(txt5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txt4);
            groupBox2.ForeColor = Color.IndianRed;
            groupBox2.Location = new Point(10, 349);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(657, 183);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả";
            groupBox2.UseCompatibleTextRendering = true;
            // 
            // txt4
            // 
            txt4.Location = new Point(125, 32);
            txt4.Name = "txt4";
            txt4.ReadOnly = true;
            txt4.Size = new Size(183, 51);
            txt4.TabIndex = 23;
            // 
            // txt3
            // 
            txt3.Location = new Point(125, 190);
            txt3.Name = "txt3";
            txt3.Size = new Size(183, 51);
            txt3.TabIndex = 30;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.PapayaWhip;
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txt2);
            groupBox3.Controls.Add(txt3);
            groupBox3.Controls.Add(txt1);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(10, 78);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(325, 259);
            groupBox3.TabIndex = 31;
            groupBox3.TabStop = false;
            groupBox3.Text = " Mời bạn nhập kích thước";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 193);
            label3.Name = "label3";
            label3.Size = new Size(106, 43);
            label3.TabIndex = 31;
            label3.Text = "Chiều cao";
            // 
            // Ref
            // 
            Ref.BackColor = Color.Honeydew;
            Ref.Font = new Font("Dongle", 18F, FontStyle.Bold);
            Ref.Location = new Point(213, 97);
            Ref.Name = "Ref";
            Ref.Size = new Size(104, 57);
            Ref.TabIndex = 7;
            Ref.Text = "Làm mới";
            Ref.UseVisualStyleBackColor = false;
            Ref.Click += Ref_Click;
            // 
            // comboBox1
            // 
            comboBox1.ForeColor = Color.OrangeRed;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Hình hộp chữ nhật", "Hình chữ nhật", "Hình tròn", "Hình cầu" });
            comboBox1.Location = new Point(6, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(199, 51);
            comboBox1.TabIndex = 22;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Back_Btn
            // 
            Back_Btn.BackColor = Color.Honeydew;
            Back_Btn.Font = new Font("Dongle", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back_Btn.Location = new Point(10, 12);
            Back_Btn.Margin = new Padding(4, 6, 4, 6);
            Back_Btn.Name = "Back_Btn";
            Back_Btn.Size = new Size(104, 57);
            Back_Btn.TabIndex = 1;
            Back_Btn.Text = "Trở về";
            Back_Btn.UseVisualStyleBackColor = false;
            Back_Btn.Click += Back_Btn_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.PapayaWhip;
            groupBox4.Controls.Add(comboBox1);
            groupBox4.Controls.Add(Ref);
            groupBox4.Controls.Add(Giai);
            groupBox4.Controls.Add(Quit);
            groupBox4.Location = new Point(344, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(323, 325);
            groupBox4.TabIndex = 32;
            groupBox4.TabStop = false;
            groupBox4.Text = "Mời bạn chọn dạng hình học";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // Hinh
            // 
            AutoScaleDimensions = new SizeF(11F, 43F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 542);
            Controls.Add(Back_Btn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Font = new Font("Dongle", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Highlight;
            KeyPreview = true;
            Margin = new Padding(4, 6, 4, 6);
            MaximumSize = new Size(695, 730);
            MinimumSize = new Size(695, 0);
            Name = "Hinh";
            Text = "Hình Học";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button Giai;
        private Button Quit;
        private TextBox txt5;
        private TextBox txt1;
        private TextBox textBox4;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox txt6;
        private Label label6;
        private TextBox txt2;
        private GroupBox groupBox2;
        private TextBox txt3;
        private GroupBox groupBox3;
        private Button Ref;
        private ComboBox comboBox1;
        private Button Back_Btn;
        private GroupBox groupBox4;
        private TextBox txt4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label3;
    }
}