namespace Math
{
    partial class Units
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
            ChuyenDoi = new Button();
            comboBox1 = new ComboBox();
            Quit = new Button();
            Back_Btn = new Button();
            Ref = new Button();
            label1 = new Label();
            colorDialog1 = new ColorDialog();
            comboBox2 = new ComboBox();
            txtResult = new TextBox();
            Type = new ComboBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            txtInput = new TextBox();
            DaoNguoc = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ChuyenDoi
            // 
            ChuyenDoi.BackColor = Color.Honeydew;
            ChuyenDoi.Font = new Font("Dongle", 18F, FontStyle.Bold);
            ChuyenDoi.Location = new Point(141, 249);
            ChuyenDoi.Margin = new Padding(4, 6, 4, 6);
            ChuyenDoi.Name = "ChuyenDoi";
            ChuyenDoi.Size = new Size(101, 51);
            ChuyenDoi.TabIndex = 0;
            ChuyenDoi.Text = "Đổi";
            ChuyenDoi.UseVisualStyleBackColor = false;
            ChuyenDoi.Click += ChuyenDoi_Click;
            // 
            // comboBox1
            // 
            comboBox1.ForeColor = SystemColors.HotTrack;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "mm", "cm", "dm", "m", "km", "feet", "inch" });
            comboBox1.Location = new Point(11, 87);
            comboBox1.Margin = new Padding(4, 6, 4, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(126, 51);
            comboBox1.TabIndex = 2;
            // 
            // Quit
            // 
            Quit.BackColor = Color.Honeydew;
            Quit.Font = new Font("Dongle", 18F, FontStyle.Bold);
            Quit.Location = new Point(270, 249);
            Quit.Margin = new Padding(6, 13, 6, 13);
            Quit.Name = "Quit";
            Quit.Size = new Size(104, 51);
            Quit.TabIndex = 20;
            Quit.Text = "Thoát";
            Quit.UseVisualStyleBackColor = false;
            Quit.Click += Quit_Click;
            // 
            // Back_Btn
            // 
            Back_Btn.BackColor = Color.Honeydew;
            Back_Btn.Font = new Font("Dongle", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back_Btn.Location = new Point(15, 22);
            Back_Btn.Margin = new Padding(6, 13, 6, 13);
            Back_Btn.Name = "Back_Btn";
            Back_Btn.Size = new Size(92, 53);
            Back_Btn.TabIndex = 33;
            Back_Btn.Text = "Trở về";
            Back_Btn.UseVisualStyleBackColor = false;
            Back_Btn.Click += Back_Btn_Click;
            // 
            // Ref
            // 
            Ref.BackColor = Color.Honeydew;
            Ref.Font = new Font("Dongle", 18F, FontStyle.Bold);
            Ref.Location = new Point(11, 249);
            Ref.Margin = new Padding(4, 6, 4, 6);
            Ref.Name = "Ref";
            Ref.Size = new Size(104, 51);
            Ref.TabIndex = 34;
            Ref.Text = "Làm mới";
            Ref.UseVisualStyleBackColor = false;
            Ref.Click += Ref_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Dongle", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(145, 140);
            label1.Name = "label1";
            label1.Size = new Size(97, 116);
            label1.TabIndex = 35;
            label1.Text = "→";
            // 
            // comboBox2
            // 
            comboBox2.ForeColor = SystemColors.HotTrack;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "mm", "cm", "dm", "m", "km", "feet", "inch" });
            comboBox2.Location = new Point(247, 87);
            comboBox2.Margin = new Padding(4, 6, 4, 6);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(126, 51);
            comboBox2.TabIndex = 3;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(247, 162);
            txtResult.Margin = new Padding(4, 6, 4, 6);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(127, 51);
            txtResult.TabIndex = 4;
            // 
            // Type
            // 
            Type.ForeColor = Color.IndianRed;
            Type.FormattingEnabled = true;
            Type.Items.AddRange(new object[] { "Độ dài", "Khối lượng", "Diện tích", "Thể tích", "Vận tốc", "Nhiệt độ" });
            Type.Location = new Point(247, 7);
            Type.Name = "Type";
            Type.Size = new Size(126, 51);
            Type.TabIndex = 36;
            Type.SelectedIndexChanged += Type_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(144, 7);
            label2.Name = "label2";
            label2.Size = new Size(103, 43);
            label2.TabIndex = 38;
            label2.Text = "Đại lượng";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PapayaWhip;
            groupBox1.Controls.Add(txtInput);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(txtResult);
            groupBox1.Controls.Add(DaoNguoc);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Ref);
            groupBox1.Controls.Add(Type);
            groupBox1.Controls.Add(ChuyenDoi);
            groupBox1.Controls.Add(Quit);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(4, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 329);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(11, 162);
            txtInput.Margin = new Padding(4, 6, 4, 6);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(127, 51);
            txtInput.TabIndex = 40;
            // 
            // DaoNguoc
            // 
            DaoNguoc.AutoSize = true;
            DaoNguoc.Font = new Font("Dongle", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DaoNguoc.ForeColor = Color.Red;
            DaoNguoc.Location = new Point(128, 61);
            DaoNguoc.Name = "DaoNguoc";
            DaoNguoc.Size = new Size(129, 116);
            DaoNguoc.TabIndex = 39;
            DaoNguoc.Text = " ↔ ";
            DaoNguoc.Click += DaoNguoc_Click;
            // 
            // Units
            // 
            AutoScaleDimensions = new SizeF(11F, 43F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 346);
            Controls.Add(Back_Btn);
            Controls.Add(groupBox1);
            Font = new Font("Dongle", 18F, FontStyle.Bold);
            Margin = new Padding(4, 6, 4, 6);
            MaximumSize = new Size(416, 393);
            MinimumSize = new Size(416, 393);
            Name = "Units";
            Text = "Bộ Chuyển Đổi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ChuyenDoi;
        private ComboBox comboBox1;
        private Button Quit;
        private Button Back_Btn;
        private Button Ref;
        private Label label1;
        private ColorDialog colorDialog1;
        private ComboBox comboBox2;
        private TextBox txtResult;
        private ComboBox Type;
        private Label label2;
        private GroupBox groupBox1;
        private Label DaoNguoc;
        private TextBox txtInput;
    }
}