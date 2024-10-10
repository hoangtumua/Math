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
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
 
namespace Math
{
    public partial class PhuongTrinh : Form
    {
        public PhuongTrinh()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            radioButton3.Checked = true;
            txt1.KeyPress += new KeyPressEventHandler(txt_KeyPress);
            txt2.KeyPress += new KeyPressEventHandler(txt_KeyPress);
            txt3.KeyPress += new KeyPressEventHandler(txt_KeyPress);
            txt4.KeyPress += new KeyPressEventHandler(txt_KeyPress);
            txt1.KeyPress += new KeyPressEventHandler(NhanPhimEnter);
            txt2.KeyPress += new KeyPressEventHandler(NhanPhimEnter);
            txt3.KeyPress += new KeyPressEventHandler(NhanPhimEnter);
            txt4.KeyPress += new KeyPressEventHandler(NhanPhimEnter);
            radioButton1.KeyPress += new KeyPressEventHandler(NhanPhimEnter);
            radioButton2.KeyPress += new KeyPressEventHandler(NhanPhimEnter);
            radioButton3.KeyPress += new KeyPressEventHandler(NhanPhimEnter);
            Back_Btn.Cursor = Cursors.Hand;
            Quit.Cursor = Cursors.Hand;
            Giai.Cursor = Cursors.Hand;
            Ref.Cursor = Cursors.Hand;
            radioButton1.Cursor = Cursors.Hand;
            radioButton2.Cursor = Cursors.Hand;
            radioButton3.Cursor = Cursors.Hand;
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
            // Hàm kiểm tra tính hợp lệ của giá trị nhập
            bool IsValidInput(params double[] inputs)
            {
                foreach (var input in inputs)
                {
                    if (double.IsNaN(input) || double.IsInfinity(input))
                    {
                        return false;
                    }
                }
                return true;
            }

            // PT bậc 1
            if (radioButton1.Checked)
            {
                double a, b;
                if (double.TryParse(txt1.Text, out a) && double.TryParse(txt2.Text, out b))
                {
                    // Kiểm tra tính hợp lệ
                    if (!IsValidInput(a, b))
                    {
                        MessageBox.Show("Số nhập không hợp lệ! Bạn vui lòng kiểm tra lại!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;
                    }
                    // a khác 0
                    if (a != 0)
                    {
                        double x1 = -b / a;
                        txt5.Text = System.Math.Round(x1, 6).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Hệ số a phải khác 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Số bạn nhập không hợp lệ! Bạn vui lòng nhập số hợp lệ cho a và b!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            // PT bậc 2
            else if (radioButton2.Checked)
            {
                double a, b, c;
                if (double.TryParse(txt1.Text, out a) && double.TryParse(txt2.Text, out b) && double.TryParse(txt3.Text, out c))
                {
                    // Kiểm tra tính hợp lệ
                    if (!IsValidInput(a, b, c))
                    {
                        MessageBox.Show("Số bạn nhập không hợp lệ! Bạn vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    // nếu a = 0 thì phương trình thành bậc 1
                    if (a == 0)
                    {
                        // a = 0, b = 0 thì thông báo a và b phải khác 0
                        if (b == 0)
                        {
                            MessageBox.Show(" Hệ số a và b đồng thời phải khác 0! Bạn vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        // Giải phương trình bậc 1
                        else
                        {
                            double x = -c / b;
                            txt5.Text = System.Math.Round(x, 6).ToString();
                            txt6.Clear();
                            txt7.Clear();
                        }
                    }
                    else
                    {
                        // Tính delta
                        double delta = b * b - 4 * a * c;
                        // Hai nghiệm phân biệt
                        if (delta > 0)
                        {
                            double x1 = (-b - System.Math.Sqrt(delta)) / (2 * a);
                            double x2 = (-b + System.Math.Sqrt(delta)) / (2 * a);
                            txt5.Text =  System.Math.Round(x1, 6).ToString();
                            txt6.Text = System.Math.Round(x2, 6).ToString();
                            txt7.Clear();
                        }
                        // Nghiệm kép
                        else if (delta == 0)
                        {
                            double x = -b / (2 * a);
                            txt5.Text = System.Math.Round(x, 6).ToString();
                            txt6.Text = "Nghiệm kép";
                            txt7.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Phương trình vô nghiệm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Số bạn nhập không hợp lệ! Vui lòng nhập số hợp lệ cho a, b và c!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            // PT bậc 3
            else if (radioButton3.Checked)
            {
                double a, b, c, d;
                if (double.TryParse(txt1.Text, out a) && double.TryParse(txt2.Text, out b) &&
                    double.TryParse(txt3.Text, out c) && double.TryParse(txt4.Text, out d))
                {
                    // Kiểm tra tính hợp lệ
                    if (!IsValidInput(a, b, c, d))
                    {
                        MessageBox.Show("Số nhập không hợp lệ! Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    // a = 0 thành phương trình bậc 2
                    if (a == 0)
                    {
                        // a = 0, b = 0 thì thành phương trình bậc 1
                        if (b == 0)
                        {
                            if (c == 0)
                            {
                                MessageBox.Show(" Hệ số a, b và c đồng thời phải khác 0! Bạn vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            // Giải phương trình bậc 1
                            else
                            {
                                double x = -d / c;
                                txt5.Text = System.Math.Round(x, 6).ToString();
                                txt6.Clear();
                                txt7.Clear();
                            }
                        }
                        // Giải phương trình bậc 2
                        else
                        {
                            double delta = c * c - 4 * b * d;
                            if (delta > 0)
                            {
                                double x1 = (-c + System.Math.Sqrt(delta)) / (2 * b);
                                double x2 = (-c - System.Math.Sqrt(delta)) / (2 * b);
                                txt5.Text = System.Math.Round(x1, 6).ToString();
                                txt6.Text = System.Math.Round(x2, 6).ToString();
                                txt7.Clear();
                            }
                            else if (delta == 0)
                            {
                                double x = -c / (2 * b);
                                txt5.Text = System.Math.Round(x, 6).ToString();
                                txt6.Text = "Nghiệm kép";
                                txt7.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Phương trình vô nghiệm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    // Giải phương trình bậc 3 
                    else
                    {
                        var roots = SolveCubic(a, b, c, d);
                        txt5.Text = System.Math.Round(roots.Item1, 6).ToString();
                        txt6.Text = System.Math.Round(roots.Item2, 6).ToString();
                        txt7.Text = System.Math.Round(roots.Item3, 6).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Số bạn nhập không hợp lệ! Bạn vui lòng nhập số hợp lệ cho a, b, c và d.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Cho phép nhập các phím điều khiển (như Backspace)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Chỉ cho phép nhập số và dấu chấm (.)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // Chỉ cho phép một dấu chấm trong TextBox
            if (e.KeyChar == '.' && textBox.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            // Chỉ cho phép dấu trừ ở đầu chuỗi
            if (e.KeyChar == '-' && textBox.SelectionStart != 0)
            {
                e.Handled = true;
            }

            // Không cho phép nhập nhiều hơn một dấu trừ
            if (e.KeyChar == '-' && textBox.Text.IndexOf('-') > -1)
            {
                e.Handled = true;
            }
        }


        // Hàm giải phương trình bậc 3
        private (double, double, double) SolveCubic(double a, double b, double c, double d)
        {
            // Chuyển đổi về dạng chuẩn
            double f = ((3 * c / a) - (b * b) / (a * a)) / 3;
            double g = ((2 * b * b * b) / (a * a * a) - (9 * b * c) / (a * a) + (27 * d / a)) / 27;
            double h = (g * g / 4) + (f * f * f / 27);
            // Một nghiệm thực 
            if (h > 0)  
            {
                double r = -(g / 2) + System.Math.Sqrt(h);
                double s = System.Math.Sign(r) * System.Math.Pow(System.Math.Abs(r), 1.0 / 3.0);
                double t = -(g / 2) - System.Math.Sqrt(h);
                double u = System.Math.Sign(t) * System.Math.Pow(System.Math.Abs(t), 1.0 / 3.0);

                double x1 = (s + u) - (b / (3 * a));
                return (x1, double.NaN, double.NaN); // Chỉ trả nghiệm thực
            }
            // Tất cả các nghiệm thực
            else
            {
                double i = System.Math.Sqrt((g * g / 4) - h);
                double j = System.Math.Sign(i) * System.Math.Pow(System.Math.Abs(i), 1.0 / 3.0);
                double k = System.Math.Acos(-(g / (2 * i)));
                double l = -j;
                double m = System.Math.Cos(k / 3);
                double n = System.Math.Sqrt(3) * System.Math.Sin(k / 3);
                double p = -(b / (3 * a));

                double x1 = 2 * j * m + p;
                double x2 = l * (m + n) + p;
                double x3 = l * (m - n) + p;

                return (x1, x2, x3);
            }
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
            txt7.Clear();
        }
        // Bậc 1 được chọn
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            txt3.Visible = false;
            txt4.Visible = false;
            txt5.Visible = true;
            txt6.Visible = false;
            txt7.Visible = false;

            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label5.Visible = true;
            label7.Visible = false;
            label8.Text = "ax + b = 0";

            txt5.Clear();
            txt6.Clear();
            txt7.Clear();
        }
        // Bậc 2 được chọn
        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            txt3.Visible = true;
            txt4.Visible = false;
            txt5.Visible = true;
            txt6.Visible = true;
            txt7.Visible = false;

            label3.Visible = true;
            label4.Visible = false;
            label6.Visible = true;
            label5.Visible = true;
            label7.Visible = false;
            label8.Text = "ax² + bx + c = 0";

            txt5.Clear();
            txt6.Clear();
            txt7.Clear();
        }
        // Bậc 3 được chọn
        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            txt3.Visible = true;
            txt4.Visible = true;
            txt5.Visible = true;
            txt6.Visible = true;
            txt7.Visible = true;

            label3.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            label8.Text = "ax³ + bx² + cx + d = 0";

            txt5.Clear();
            txt6.Clear();
            txt7.Clear();

        }
    }
}
 
