using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Math;
namespace Math
{
    public partial class Hinh : Form
    {

        public Hinh()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            comboBox1.SelectedItem = "Hình hộp chữ nhật";
            txt1.KeyPress += new KeyPressEventHandler(ChiDuocNhapSo);
            txt2.KeyPress += new KeyPressEventHandler(ChiDuocNhapSo);
            txt3.KeyPress += new KeyPressEventHandler(ChiDuocNhapSo);
            txt1.KeyPress += new KeyPressEventHandler(NhanPhimEnter);
            txt2.KeyPress += new KeyPressEventHandler(NhanPhimEnter);
            txt3.KeyPress += new KeyPressEventHandler(NhanPhimEnter);
            comboBox1.KeyPress += new KeyPressEventHandler(NhanPhimEnter);
            Back_Btn.Cursor = Cursors.Hand;
            Ref.Cursor = Cursors.Hand;
            Quit.Cursor = Cursors.Hand;
            Giai.Cursor = Cursors.Hand;
            comboBox1.Cursor = Cursors.Hand;

        }

        string CalTotal;
        double number1;
        double number2;
        string option;
        double result;
        double spi = 3.141592653;
        private void ChiDuocNhapSo(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.')
                && (textBox.Text.Contains('.')))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && textBox.Text.Length == 0)
            {
                textBox.Text = "0";
                textBox.SelectionStart = textBox.Text.Length;
            }
        }
        private void NhanPhimEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Giai_Click(sender, e);
            }
        }

        // Nút quay về
        private void Back_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainF mainForm = new MainF();
            mainForm.Show();
        }
        // Nút làm mới
        private void Ref_Click(object sender, EventArgs e)
        {

            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            txt5.Clear();
            txt6.Clear();
        }
        // Nút thoát
        private void Quit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Nút Giải
        private void Giai_Click(object sender, EventArgs e)
        {

            // Hình chữ nhật
            if (comboBox1.SelectedItem.ToString() == "Hình chữ nhật")
            {
                if (decimal.TryParse(txt1.Text, out decimal dai) && dai > 0 &&
                    decimal.TryParse(txt2.Text, out decimal rong) && rong > 0)
                {
                    txt4.Text = (2 * (dai + rong)).ToString(); // Chu vi
                    txt5.Text = (dai * rong).ToString();       // Diện tích
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập chiều dài và chiều rộng lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            // Hình hộp chữ nhật
            else if (comboBox1.SelectedItem.ToString() == "Hình hộp chữ nhật")
            {
                if (decimal.TryParse(txt1.Text, out decimal dai) && dai > 0 &&
                    decimal.TryParse(txt2.Text, out decimal rong) && rong > 0 &&
                    decimal.TryParse(txt3.Text, out decimal cao) && cao > 0)
                {
                    txt4.Text = (((dai + rong) * 2 * cao)).ToString(); // Tính dtxq                
                    txt5.Text = (((dai + rong) * 2 * cao) + dai * rong * 2).ToString(); // DTTP
                    txt6.Text = (dai * rong * cao).ToString(); // Tính thể tích
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập các giá trị lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            // Hình tròn
            else if (comboBox1.SelectedItem.ToString() == "Hình tròn")
            {
                if (decimal.TryParse(txt1.Text, out decimal banKinh) && banKinh > 0)
                {
                    decimal dienTich = (decimal)spi * banKinh * banKinh;
                    txt4.Text = (2 * (decimal)spi * banKinh).ToString(); // Tính chu vi
                    txt5.Text = dienTich.ToString();                     // Diện tích hình tròn
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập bán kính lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            // Hình cầu
            else if (comboBox1.SelectedItem.ToString() == "Hình cầu")
            {
                if (decimal.TryParse(txt1.Text, out decimal banKinh) && banKinh > 0)
                {
                    txt4.Text = (4 * (decimal)spi * banKinh * banKinh).ToString(); // Tính Diện tích
                    txt5.Text = (((4 * (decimal)spi * banKinh * banKinh * banKinh) / 3)).ToString(); // Thể tích
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập bán kính lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("Vui lòng chọn dạng hình học hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        // Lựa chọn dạng hình học
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Hình chữ nhật")
            {
                txt4.Clear();
                txt5.Clear();
                txt6.Clear();

                txt2.Visible = true;
                txt3.Visible = false;
                txt4.Visible = true;
                txt6.Visible = false;

                label2.Visible = true;
                //labelDv.Visible = true;
                label3.Visible = false;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = false;

                label1.Text = "Chiều dài";
                label2.Text = "Chiều rộng";
                label4.Text = "Chu vi";
                label5.Text = "Diện tích";
            }
            else if (comboBox1.SelectedItem.ToString() == "Hình hộp chữ nhật")
            {
                txt4.Clear();
                txt5.Clear();
                txt6.Clear();

                txt2.Visible = true;
                txt3.Visible = true;
                txt4.Visible = true;
                txt6.Visible = true;

                label2.Visible = true;
                //   labelDv.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;

                label1.Text = "Chiều dài";
                label2.Text = "Chiều rộng";
                label3.Text = "Chiều cao";
                label4.Text = "Diện tích XQ";
                label5.Text = "Diện tích TP";
            }
            else if (comboBox1.SelectedItem.ToString() == "Hình tròn")
            {
                txt4.Clear();
                txt5.Clear();
                txt6.Clear();

                txt3.Visible = false;
                txt2.Visible = false;
                txt6.Visible = false;

                label2.Visible = false;
                //labelDv.Visible = true;
                label3.Visible = false;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = false;

                label1.Text = "Bán kính";
                label4.Text = "Chu vi";
                label5.Text = "Diện tích";
                label6.Text = "Thể tích";
            }
            else if (comboBox1.SelectedItem.ToString() == "Hình cầu")
            {
                txt4.Clear();
                txt5.Clear();
                txt6.Clear();

                txt3.Visible = false;
                txt2.Visible = false;
                txt6.Visible = false;

                label3.Visible = false;
                label2.Visible = false;
                //   labelDv.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = false;

                label1.Text = "Bán kính";
                label4.Text = "Diện tích";
                label5.Text = "Thể tích";

            }
            else
            {
                txt3.Visible = false;
            }
        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
