using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Media;
using System.Numerics;

namespace Math
{
    public partial class DemNguoc : Form
    {
        private System.Timers.Timer BoDemThoiGian;
        private bool DangChay = false;
        private bool TamDung = false;
        private int ThoiGianConLai;
        private SoundPlayer Nhac;
        private ToolTip ChiDan;
        public DemNguoc()
        {
            InitializeComponent();
 
            DanhSachNhac.Items.Add("Yên Lặng");
            DanhSachNhac.Items.Add("Hoa Cỏ Mùa Xuân");
            DanhSachNhac.Items.Add("Âm Thầm Bên Em Chill");
            DanhSachNhac.Items.Add("Một Mình Cô Đơn");
            DanhSachNhac.Items.Add("Chìuuu mưaaa pùnnn !!!...");
            DanhSachNhac.Items.Add("Chúng Ta Của Hiện Tại");
            DanhSachNhac.Items.Add("Muộn Rồi Mà Sao Còn Funny");
            DanhSachNhac.SelectedIndex = 2;
            DanhSachNhac.DropDownStyle = ComboBoxStyle.DropDownList;
            BoDemThoiGian = new System.Timers.Timer(1000); // Thiết lập khoảng thời gian là 1 giây
            BoDemThoiGian.Elapsed += DemNguocTG;
            BoDemThoiGian.AutoReset = true; // Đặt lại timer sau mỗi 1 giây
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeCountdownTimer();
            Gio.Text = "00";
            Gio.TextAlign = HorizontalAlignment.Center;  
            Phut.Text = "00";
            Phut.TextAlign = HorizontalAlignment.Center;  
            Giay.Text = "00";
            Giay.TextAlign = HorizontalAlignment.Center;  
            Gio.TextChanged += TextBox_TextChanged;
            Phut.TextChanged += TextBox_TextChanged;
            Giay.TextChanged += TextBox_TextChanged;
            Gio.KeyPress += TextBox_KeyPress;
            Phut.KeyPress += TextBox_KeyPress;
            Giay.KeyPress += TextBox_KeyPress;

            Back.Cursor = Cursors.Hand;
            AmThanh.Cursor = Cursors.Hand;
            Ref.Cursor = Cursors.Hand;
            Quit.Cursor = Cursors.Hand;
            Run.Cursor = Cursors.Hand;
            TangGio.Cursor = Cursors.Hand;
            GiamGio.Cursor = Cursors.Hand;
            TangPhut.Cursor = Cursors.Hand;
            GiamPhut.Cursor = Cursors.Hand;
            TangGiay.Cursor = Cursors.Hand;
            GiamGiay.Cursor = Cursors.Hand;
            DanhSachNhac.Cursor = Cursors.Hand;

            ChiDan = new ToolTip();
 
            ChiDan.SetToolTip(Run, "Chạy");
            ChiDan.SetToolTip(Ref, "Làm mới");
            ChiDan.SetToolTip(TangGio, "Tăng");
            ChiDan.SetToolTip(GiamGio, "Giảm");
            ChiDan.SetToolTip(TangPhut, "Tăng");
            ChiDan.SetToolTip(GiamPhut, "Giảm");
            ChiDan.SetToolTip(TangGiay, "Tăng");
            ChiDan.SetToolTip(GiamGiay, "Giảm");
            ChiDan.SetToolTip(Gio, "Giờ");
            ChiDan.SetToolTip(Phut, "Phút");
            ChiDan.SetToolTip(Giay, "Giây");
            ChiDan.SetToolTip(Back, "Trở về");
            ChiDan.SetToolTip(Quit, "Thoát");
            ChiDan.SetToolTip(DanhSachNhac, "Chọn nhạc chuông");
        }
        private void InitializeCountdownTimer()
        {
            BoDemThoiGian = new System.Timers.Timer(1000); // Cập nhật mỗi giây
            BoDemThoiGian.Elapsed += DemNguocTG;
        }
        private void ChonNhac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Nhac != null)
            {
                Nhac.Stop();
            }

            string LuaChonNhac = DanhSachNhac.SelectedItem.ToString();
            string DuongDanNhac = System.IO.Path.Combine(Application.StartupPath, LuaChonNhac + ".wav");

            if (System.IO.File.Exists(DuongDanNhac))
            {
                Nhac = new SoundPlayer(DuongDanNhac);
            }
            else
            {
                //        MessageBox.Show("Nhạc không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   
        int LanDem = 0;
        private void DemNguocTG(Object source, ElapsedEventArgs e)
        {
            if (ThoiGianConLai > 0)
            {
                ThoiGianConLai--;
                CapNhatHienThi();
            }
            else
            {
                BoDemThoiGian.Stop();
                Ref.Text = "🎶";
                ChiDan.SetToolTip(Ref, "Tắt nhạc");
                NhanHetGio.Text = "Hết giờ rồi !!!";
                Run.Enabled = false;
                DanhSachNhac.Enabled = false;
                DangPhatNhac = false;   
                LanDem += 1;

         
                if (!TatTieng)
                {
                    try
                    {
                        Nhac.PlayLooping();   
                        DangPhatNhac = true;   
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Không thể phát nhạc: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            //      DialogResult result = MessageBox.Show("Thời gian đã hết!\nBạn có muốn tắt nhạc không?", "Thông báo", MessageBoxButtons.YesNo);

            //       if (result == DialogResult.Yes)
            //      {
            //          Nhac.Stop();
            //       }

            //      Ref_Click(null, EventArgs.Empty);

        }
        private bool TatTieng = false;
        private bool DangPhatNhac = true;
        private void AmThanh_Click(object sender, EventArgs e)
        {
            if (!TatTieng)  
            {
                if (DangPhatNhac)   
                {
                    Nhac.Stop();
                    DangPhatNhac = false;
                }
                TatTieng = true;  
                AmThanh.Text = "🔕";
                ChiDan.SetToolTip(AmThanh, "Chuông");
            }
            else   
            {
                TatTieng = false;   
                AmThanh.Text = "🔔";
                ChiDan.SetToolTip(AmThanh, "Yên lặng");

                if (ThoiGianConLai == 0 && !DangPhatNhac && LanDem > 0)   
                {
                    Nhac.PlayLooping();
                    DangPhatNhac = true;
                }
            }
        }
 
        private void CapNhatHienThi()
        {
            this.Invoke((MethodInvoker)delegate
           {
               Gio.Text = (ThoiGianConLai / 3600).ToString("00");
               Phut.Text = ((ThoiGianConLai % 3600) / 60).ToString("00");
               Giay.Text = (ThoiGianConLai % 60).ToString("00");
               DateTime currentTime = DateTime.Now;
               DateTime endTime = currentTime.AddSeconds(ThoiGianConLai);
               NhanHetGio.Text = $"⏰ {endTime:HH:mm}";
           });
        }
        private void Quit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();

            foreach (Form form in Application.OpenForms)
            {
                if (form is Dem)
                {
                    form.Show();
                    break;
                }
            }

        }
        private void TangGio_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Gio.Text, out int hours))
            {
                if (hours < 99)
                {
                    hours++;
                }
                else
                {
                    hours = 0;
                }
                Gio.Text = hours.ToString();
            }
        }
        private void TangPhut_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Phut.Text, out int minutes))
            {
                if (minutes < 59)
                {
                    minutes++;
                }
                else
                {
                    minutes = 0;
                }
                Phut.Text = minutes.ToString();
            }
        }
        private void TangGiay_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Giay.Text, out int seconds))
            {
                if (seconds < 59)
                {
                    seconds++;
                }
                else
                {
                    seconds = 0;
                }
                Giay.Text = seconds.ToString();
            }
        }
        private void GiamGio_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Gio.Text, out int hours) && hours > 0)
            {
                hours--;
                Gio.Text = hours.ToString();
            }
            else if (hours == 0)
            {
                hours = 99;
                Gio.Text = hours.ToString();
            }
        }
        private void GiamPhut_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Phut.Text, out int minutes) && minutes > 0)
            {
                minutes--;
                Phut.Text = minutes.ToString();
            }
            else if (minutes == 0)
            {
                minutes = 59;
                Phut.Text = minutes.ToString();
            }
        }
        private void GiamGiay_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Giay.Text, out int seconds) && seconds > 0)
            {
                seconds--;
                Giay.Text = seconds.ToString();
            }
            else if (seconds == 0)
            {
                seconds = 59;
                Giay.Text = seconds.ToString();
            }
        }
        private void FormatTextBox(TextBox textBox)
        {
            if (textBox != null)
            {
                if (int.TryParse(textBox.Text, out int value))
                {
                    textBox.Text = value.ToString("00");
                    textBox.SelectionStart = textBox.Text.Length;
                }
            }
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                if (textBox.SelectionLength == 0)
                {
                    ChiNhapHaiSo(textBox);
                }
                if (int.TryParse(textBox.Text, out int value))
                {
                    textBox.Text = value.ToString("00");
                }
                textBox.SelectionStart = textBox.Text.Length;
            }
        }
        private void ChiNhapHaiSo(TextBox textBox)
        {
            if (textBox != null && textBox.Text.Length > 2)
            {
                textBox.Text = textBox.Text.Substring(0, 2);
            }
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Run_Click(object sender, EventArgs e)
        {
            if (!DangChay)
            {
                // Chạy bộ đếm
                int hours = int.Parse(Gio.Text);
                int minutes = int.Parse(Phut.Text);
                int seconds = int.Parse(Giay.Text);
                ThoiGianConLai = hours * 3600 + minutes * 60 + seconds;

                BoDemThoiGian.Start();
                DangChay = true;
                Run.Text = "⏸";
                ChiDan.SetToolTip(Run, "Dừng");
                Gio.Enabled = false;
                Phut.Enabled = false;
                Giay.Enabled = false;
                TangGio.Enabled = false;
                GiamGio.Enabled = false;
                TangPhut.Enabled = false;
                GiamPhut.Enabled = false;
                TangGiay.Enabled = false;
                GiamGiay.Enabled = false;
            }
            else
            {
                // Tạm dừng bộ đếm
                if (!TamDung)
                {
                    BoDemThoiGian.Stop();
                    TamDung = true;
                    Run.Text = "▶️";
                    ChiDan.SetToolTip(Run, "Chạy");
                }
                else
                {
                    BoDemThoiGian.Start();
                    TamDung = false;
                    Run.Text = "⏸";
                    ChiDan.SetToolTip(Run, "Dừng");
                }
            }
        }
        private void Ref_Click(object sender, EventArgs e)
        {
            Ref.Text = "↺";
            Nhac.Stop();
            BoDemThoiGian.Stop();
            DangChay = false;
            TamDung = false;
            Run.Text = "▶️";
            ChiDan.SetToolTip(Run, "Chạy");
            ChiDan.SetToolTip(Ref, "Làm mới");
        //    TatTieng = false;
       //     AmThanh.Text = "🔔";
      //      ChiDan.SetToolTip(AmThanh, "Yên lặng");
            LanDem = 0;
            Gio.Text = "00";
            Phut.Text = "00";
            Giay.Text = "00";
            NhanHetGio.Text = "⏰00:00";
            Gio.Enabled = true;
            Run.Enabled = true;
            DanhSachNhac.Enabled = true;
          
            Phut.Enabled = true;
            Giay.Enabled = true;
            TangGio.Enabled = true;
            GiamGio.Enabled = true;
            TangPhut.Enabled = true;
            GiamPhut.Enabled = true;
            TangGiay.Enabled = true;
            GiamGiay.Enabled = true;
        }
 
     }
}