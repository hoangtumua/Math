namespace Math
{
    partial class Dem
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
            NhanThoiGian = new Label();
            DanhSachKQ = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Flag = new Button();
            Run = new Button();
            Ref = new Button();
            Back = new Button();
            Quit = new Button();
            DemNguoc = new Button();
            ((System.ComponentModel.ISupportInitialize)DanhSachKQ).BeginInit();
            SuspendLayout();
            // 
            // NhanThoiGian
            // 
            NhanThoiGian.AutoSize = true;
            NhanThoiGian.BackColor = Color.PapayaWhip;
            NhanThoiGian.Font = new Font("Dongle", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NhanThoiGian.ForeColor = Color.IndianRed;
            NhanThoiGian.Location = new Point(145, 16);
            NhanThoiGian.Margin = new Padding(4, 0, 4, 0);
            NhanThoiGian.Name = "NhanThoiGian";
            NhanThoiGian.Size = new Size(195, 68);
            NhanThoiGian.TabIndex = 0;
            NhanThoiGian.Text = "00:00:00:00";
            // 
            // DanhSachKQ
            // 
            DanhSachKQ.BackgroundColor = SystemColors.ButtonHighlight;
            DanhSachKQ.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DanhSachKQ.Columns.AddRange(new DataGridViewColumn[] { STT, Time, Total });
            DanhSachKQ.Location = new Point(13, 91);
            DanhSachKQ.Margin = new Padding(4, 7, 4, 7);
            DanhSachKQ.Name = "DanhSachKQ";
            DanhSachKQ.RowHeadersWidth = 51;
            DanhSachKQ.Size = new Size(457, 290);
            DanhSachKQ.TabIndex = 1;
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.ReadOnly = true;
            STT.Resizable = DataGridViewTriState.False;
            STT.Width = 71;
            // 
            // Time
            // 
            Time.HeaderText = "Thời gian";
            Time.MinimumWidth = 6;
            Time.Name = "Time";
            Time.ReadOnly = true;
            Time.Resizable = DataGridViewTriState.False;
            Time.Width = 181;
            // 
            // Total
            // 
            Total.HeaderText = "Tổng";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Resizable = DataGridViewTriState.False;
            Total.Width = 152;
            // 
            // Flag
            // 
            Flag.ForeColor = Color.IndianRed;
            Flag.Location = new Point(480, 91);
            Flag.Margin = new Padding(4, 7, 4, 7);
            Flag.Name = "Flag";
            Flag.Size = new Size(129, 62);
            Flag.TabIndex = 2;
            Flag.Text = "🚩";
            Flag.UseVisualStyleBackColor = true;
            Flag.Click += Flag_Click;
            // 
            // Run
            // 
            Run.ForeColor = Color.IndianRed;
            Run.Location = new Point(480, 167);
            Run.Margin = new Padding(4, 7, 4, 7);
            Run.Name = "Run";
            Run.Size = new Size(129, 62);
            Run.TabIndex = 3;
            Run.Text = "▶️";
            Run.UseVisualStyleBackColor = true;
            Run.Click += Run_Click;
            // 
            // Ref
            // 
            Ref.ForeColor = Color.IndianRed;
            Ref.Location = new Point(480, 243);
            Ref.Margin = new Padding(4, 7, 4, 7);
            Ref.Name = "Ref";
            Ref.Size = new Size(129, 62);
            Ref.TabIndex = 4;
            Ref.Text = "↺";
            Ref.UseVisualStyleBackColor = true;
            Ref.Click += Ref_Click;
            // 
            // Back
            // 
            Back.BackColor = Color.Cornsilk;
            Back.Font = new Font("Dongle", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.IndianRed;
            Back.Location = new Point(13, 16);
            Back.Margin = new Padding(4, 7, 4, 7);
            Back.Name = "Back";
            Back.Size = new Size(75, 61);
            Back.TabIndex = 5;
            Back.Text = "↩️";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Quit
            // 
            Quit.ForeColor = Color.IndianRed;
            Quit.Location = new Point(480, 319);
            Quit.Margin = new Padding(4, 7, 4, 7);
            Quit.Name = "Quit";
            Quit.Size = new Size(129, 62);
            Quit.TabIndex = 6;
            Quit.Text = "👋";
            Quit.UseVisualStyleBackColor = true;
            Quit.Click += Quit_Click;
            // 
            // DemNguoc
            // 
            DemNguoc.ForeColor = Color.IndianRed;
            DemNguoc.Location = new Point(480, 16);
            DemNguoc.Name = "DemNguoc";
            DemNguoc.Size = new Size(128, 61);
            DemNguoc.TabIndex = 7;
            DemNguoc.Text = "⏳";
            DemNguoc.UseVisualStyleBackColor = true;
            DemNguoc.Click += DemNguoc_Click;
            // 
            // Dem
            // 
            AutoScaleDimensions = new SizeF(11F, 43F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(618, 391);
            Controls.Add(DemNguoc);
            Controls.Add(Quit);
            Controls.Add(Back);
            Controls.Add(Ref);
            Controls.Add(Run);
            Controls.Add(Flag);
            Controls.Add(DanhSachKQ);
            Controls.Add(NhanThoiGian);
            Font = new Font("Dongle", 18F, FontStyle.Bold);
            Margin = new Padding(4, 7, 4, 7);
            MaximumSize = new Size(636, 438);
            MinimumSize = new Size(636, 438);
            Name = "Dem";
            Text = "Bộ Đếm Giờ";
            Load += Dem_Load;
            ((System.ComponentModel.ISupportInitialize)DanhSachKQ).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NhanThoiGian;
        private DataGridView DanhSachKQ;
        private Button Flag;
        private Button Run;
        private Button Ref;
        private Button Back;
        private Button Quit;
        private Button DemNguoc;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Total;
    }
}