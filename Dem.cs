using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Windows.Forms;

namespace Math
{
    public partial class Dem : Form
    {
        Stopwatch DongHo = new Stopwatch();  
        System.Windows.Forms.Timer BoDemThoiGian = new System.Windows.Forms.Timer();  
        bool TrangThaiTamDung = false;  
        private ToolTip ChiDan;  

        public Dem()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            BoDemThoiGian.Interval = 10; // tính mili giây
            BoDemThoiGian.Tick += Timer_Tick;

            Back.Cursor = Cursors.Hand;
            Flag.Cursor = Cursors.Hand;
            Ref.Cursor = Cursors.Hand;
            Quit.Cursor = Cursors.Hand;
            Run.Cursor = Cursors.Hand;
            DemNguoc.Cursor = Cursors.Hand;
            DanhSachKQ.Cursor = Cursors.Hand;
            Flag.Enabled = false;

            ChiDan = new ToolTip();
            ChiDan.SetToolTip(Back, "Trở về");
            ChiDan.SetToolTip(Run, "Chạy");
            ChiDan.SetToolTip(Flag, "Gắn cờ");
            ChiDan.SetToolTip(Ref, "Làm mới");
            ChiDan.SetToolTip(Quit, "Thoát");
            ChiDan.SetToolTip(DemNguoc, "Bộ đếm ngược");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DongHo.Elapsed;
            NhanThoiGian.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", 
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
        }

        private TimeSpan ThoiGianTongDaChay = TimeSpan.Zero;  
        private TimeSpan ThoiGianBamCoTruoc = TimeSpan.Zero;  
        private void Flag_Click(object sender, EventArgs e)
        {
            if (DongHo.IsRunning)  
            {
                int SoThuTu = DanhSachKQ.Rows.Add();
                DanhSachKQ.Rows[SoThuTu].Cells["STT"].Value = SoThuTu + 1;  

                TimeSpan ThoiGianHienTai = DongHo.Elapsed;
                TimeSpan ThoiGianDaTren = ThoiGianHienTai - ThoiGianBamCoTruoc;

                DanhSachKQ.Rows[SoThuTu].Cells["Time"].Value = ThoiGianDaTren.ToString(@"hh\:mm\:ss\.ff"); // Thời gian từ lần bấm cờ trước
                DanhSachKQ.Rows[SoThuTu].Cells["Total"].Value = ThoiGianHienTai.ToString(@"hh\:mm\:ss\.ff"); // Thời gian tổng
                ThoiGianBamCoTruoc = ThoiGianHienTai;  
            }
        }
        private void Run_Click(object sender, EventArgs e)
        {
            if (DongHo.IsRunning)
            {
                DongHo.Stop();
                BoDemThoiGian.Stop();
                Run.Text = "▶️";
                Flag.Enabled = false;
            }
            else
            {
                DongHo.Start();
                BoDemThoiGian.Start();
                Run.Text = "⏸";
                Flag.Enabled = true;
            }
        }
        private void Ref_Click(object sender, EventArgs e)
        {
            DongHo.Reset();
            BoDemThoiGian.Stop();
            NhanThoiGian.Text = "00:00:00:00";
            DanhSachKQ.Rows.Clear();
            Run.Text = "▶️";
            Flag.Enabled = false;
        }
        private void Dem_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in DanhSachKQ.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;   
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  
            }
        }
        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainF mainForm = new MainF();
            mainForm.Show();
        }
        private void Quit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void DemNguoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Form form in Application.OpenForms)
            {
                if (form is DemNguoc)
                {
                    form.Show();
                    form.BringToFront();
                    return;
                }
            }

            DemNguoc demNguocForm = new DemNguoc();
            demNguocForm.Show();
        }
    }
}
