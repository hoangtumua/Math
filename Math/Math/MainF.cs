using System.Data;
using System.Diagnostics;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Math
{
    public partial class MainF : Form
    {
        private string currentOperation = string.Empty;
        public MainF()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txtInput.Focus();
            this.Focus();
            this.KeyDown += MainF_KeyDown;
            this.KeyPreview = true;


            Quit.Cursor = Cursors.Hand;
            Bang.Cursor = Cursors.Hand;
            CanBac2.Cursor = Cursors.Hand;
            GiaiThua.Cursor = Cursors.Hand;
            BinhPhuong.Cursor = Cursors.Hand;
            DoiDau.Cursor = Cursors.Hand;
            PhanSo.Cursor = Cursors.Hand;
            Clear.Cursor = Cursors.Hand; 
            Tru.Cursor = Cursors.Hand;
            Chia.Cursor = Cursors.Hand;
            Cong.Cursor = Cursors.Hand;
            Nhan.Cursor = Cursors.Hand;
            DauCham.Cursor = Cursors.Hand;
            FB_Btn.Cursor = Cursors.Hand;
            Pt_Btn.Cursor = Cursors.Hand;
            Hinh_Btn.Cursor = Cursors.Hand;
            Chuyen.Cursor = Cursors.Hand;
            Xoa.Cursor = Cursors.Hand;
            num0.Cursor = Cursors.Hand;
            num1.Cursor = Cursors.Hand;
            num2.Cursor = Cursors.Hand;
            num3.Cursor = Cursors.Hand;
            num4.Cursor = Cursors.Hand;
            num5.Cursor = Cursors.Hand;
            num6.Cursor = Cursors.Hand;
            num7.Cursor = Cursors.Hand;
            num8.Cursor = Cursors.Hand;
            num9.Cursor = Cursors.Hand;

        }
        // Hàm nhập phép toán từ bàn phím
        private void MainF_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra các phím số
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                // Chuyển đổi mã phím sang số
                int number = e.KeyCode - Keys.NumPad0;
                currentOperation += number.ToString();
                txtInput.Text = currentOperation;
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.NumPad0:
                    case Keys.D0:
                        currentOperation += "0";
                        txtInput.Text = currentOperation;
                        break;
                    case Keys.NumPad1:
                    case Keys.D1:
                        currentOperation += "1";
                        txtInput.Text = currentOperation;
                        break;
                    case Keys.NumPad2:
                    case Keys.D2:
                        currentOperation += "2";
                        txtInput.Text = currentOperation;
                        break;
                    case Keys.NumPad3:
                    case Keys.D3:
                        currentOperation += "3";
                        txtInput.Text = currentOperation;
                        break;
                    case Keys.NumPad4:
                    case Keys.D4:
                        currentOperation += "4";
                        txtInput.Text = currentOperation;
                        break;
                    case Keys.NumPad5:
                    case Keys.D5:
                        currentOperation += "5";
                        txtInput.Text = currentOperation;
                        break;
                    case Keys.NumPad6:
                    case Keys.D6:
                        currentOperation += "6";
                        txtInput.Text = currentOperation;
                        break;
                    case Keys.NumPad7:
                    case Keys.D7:
                        currentOperation += "7";
                        txtInput.Text = currentOperation;
                        break;
                    case Keys.NumPad8:
                    case Keys.D8:
                        currentOperation += "8";
                        txtInput.Text = currentOperation;
                        break;
                    case Keys.NumPad9:
                    case Keys.D9:
                        currentOperation += "9";
                        txtInput.Text = currentOperation;
                        break;
                    case Keys.Add:
                        ThemToanTu("+");
                        break;
                    case Keys.Subtract:
                        ThemToanTu("-");
                        break;
                    case Keys.Multiply:
                        ThemToanTu("*");
                        break;
                    case Keys.Divide:
                        ThemToanTu("/");
                        break;
                    case Keys.Enter:
                        Bang_Click(sender, e);
                        break;
                    case Keys.Back:
                        Xoa_Click(sender, e);
                        break;
                    case Keys.C:
                        Clear_Click(sender, e);
                        break;
                    default:
                        break;
                }
            }

        }
        // Hàm nhập phép toán từ nút trên màn hình
        private void NhapSoTuBanPhim_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                currentOperation += button.Text;
                txtInput.Text = currentOperation;
                this.ActiveControl = null;
            }
        }
        // Thập phân
        private void DauCham_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                if (string.IsNullOrEmpty(currentOperation) || PhepTinh(currentOperation[^1]))
                {
                    currentOperation += "0."; // Thêm "0." nếu bắt đầu bằng dấu chấm
                }
                else if (!currentOperation.Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries).Last().Contains("."))
                {
                    currentOperation += ".";
                }
                txtInput.Text = currentOperation;
                this.ActiveControl = null;
            }
        }
        // Hàm Phép toán cơ bản
        private void ThemToanTu(string operatorSymbol)
        {
            if (!string.IsNullOrEmpty(currentOperation))
            {
                // Nếu ký tự cuối cùng là phép toán, thay thế bằng phép toán mới
                if (PhepTinh(currentOperation[^1]))
                {
                    currentOperation = currentOperation.Remove(currentOperation.Length - 1) + operatorSymbol;
                }
                else
                {
                    // Kiểm tra nếu là phép toán đầu tiên
                    if (currentOperation.Length == 0)
                    {
                        currentOperation += operatorSymbol; // Thêm phép toán
                    }
                    else
                    {
                        currentOperation += operatorSymbol; // Thêm phép toán
                    }
                }

                txtInput.Text = currentOperation; // Cập nhật TextBox
            }
        }
        private bool PhepTinh(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }
        private void Cong_Click(object sender, EventArgs e)
        {
            ThemToanTu("+");
            this.ActiveControl = null;
        }
        private void Tru_Click(object sender, EventArgs e)
        {
            ThemToanTu("-");
            this.ActiveControl = null;
        }
        private void Nhan_Click(object sender, EventArgs e)
        {
            ThemToanTu("*");
            this.ActiveControl = null;
        }
        private void Chia_Click(object sender, EventArgs e)
        {
            ThemToanTu("/");
            this.ActiveControl = null;
        }
        private void Bang_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra có phép chia cho 0 không
                if (currentOperation.Contains("/") && currentOperation.Split('/').Last().Trim() == "0")
                {
                    txtInput.Text = "Không thể chia cho 0";
                    return;
                }

                // Gọi hàm XuLyPhepTinh để tính toán
                var result = XuLyPhepTinh(currentOperation);
                txtInput.Text = $"{currentOperation} = \r\n{result}";
                currentOperation = result.ToString();
                this.ActiveControl = null;
            }
            catch (DivideByZeroException ex)
            {
                txtInput.Text = ex.Message; // Hiển thị lỗi chia cho 0
            }
            catch (Exception)
            {
                txtInput.Text = "Lỗi: Biểu thức không hợp lệ";
            }
        }

        // Xử lý phép tính
        private double XuLyPhepTinh(string expression)
        {
            Stack<double> values = new Stack<double>(); // Stack để lưu trữ các toán hạng
            Stack<char> ops = new Stack<char>();        // Stack để lưu trữ các toán tử

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == ' ')
                    continue;

                // Nếu gặp số, đọc và đưa vào Stack values
                if (char.IsDigit(expression[i]) || (expression[i] == '-' && (i == 0 || PhepTinh(expression[i - 1]))))
                {
                    StringBuilder sb = new StringBuilder();
                    // Nếu là số âm, ta bắt đầu từ vị trí hiện tại
                    if (expression[i] == '-')
                    {
                        sb.Append(expression[i++]);
                    }
                    while (i < expression.Length && (char.IsDigit(expression[i]) || expression[i] == '.'))
                    {
                        sb.Append(expression[i++]);
                    }
                    values.Push(double.Parse(sb.ToString()));
                    i--; // Để không bị bỏ qua ký tự tiếp theo
                }
                // Nếu gặp toán tử, xử lý
                else if (PhepTinh(expression[i]))
                {
                    while (ops.Count > 0 && UuTienToanTu(ops.Peek()) >= UuTienToanTu(expression[i]))
                    {
                        values.Push(ThucHienPhepTinh(ops.Pop(), values.Pop(), values.Pop()));
                    }
                    ops.Push(expression[i]);
                }
            }

            while (ops.Count > 0)
            {
                values.Push(ThucHienPhepTinh(ops.Pop(), values.Pop(), values.Pop()));
            }

            return values.Pop();
        }
        // Hàm Ưu tiên tt
        private int UuTienToanTu(char op)
        {
            switch (op)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
            }
            return 0;
        }
        // Thực hiện phép tính
        private double ThucHienPhepTinh(char op, double b, double a)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/':
                    if (b == 0)
                    {
                        throw new DivideByZeroException("Không thể chia cho 0");
                    }
                    return a / b;
            }
            return 0;
        }


        // Hàm chức năng đặc biệt của MTBT
     
        // Hàm căn bậc 2
        private void CanBac2_Click(object sender, EventArgs e)
        {
            try
            {
                // Tách các phần của phép toán
                string[] parts = currentOperation.Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);
                string lastNumberStr = parts[^1].Trim(); // Lấy số cuối cùng

                // Chuyển đổi thành double và kiểm tra
                if (double.TryParse(lastNumberStr, out double lastNumber))
                {
                    // Tính căn bậc hai
                    double sqrtResult = System.Math.Sqrt(lastNumber);

                    // Cập nhật phép toán để hiển thị số và giá trị căn bậc hai
                    currentOperation = currentOperation.Remove(currentOperation.LastIndexOf(lastNumberStr), lastNumberStr.Length);
                    currentOperation += $"√{lastNumber}"; ;

                    // Tính toán kết quả của phép toán
                    double finalResult = XuLyPhepTinh(currentOperation.Replace($"√{lastNumber}", System.Math.Sqrt(lastNumber).ToString()));

                    // Cập nhật hiển thị
                    txtInput.Text = $"{currentOperation}\r\n{finalResult}";
                    currentOperation = finalResult.ToString();
                    this.ActiveControl = null;
                }
                else
                {
                    txtInput.Text = "Lỗi";
                    return;
                }
            }
            catch (Exception)
            {
                txtInput.Text = "Lỗi";
            }
        }
        // Hàm tính giai thừa
        private void GiaiThua_Click(object sender, EventArgs e)
        {
            try
            {
                // Sử dụng Regex để tách các phần t của phép toán
                string[] parts = Regex.Split(currentOperation, @"(?<=[-+*/])|(?=[-+*/])");
                string lastNumberStr = parts[^1].Trim(); // Lấy số cuối cùng

                // Chuyển đổi thành double
                if (double.TryParse(lastNumberStr, out double lastNumber))
                {
                    // Kiểm tra phải nguyên hay k
                    if (lastNumber % 1 != 0)
                    {
                        txtInput.Text = "Lỗi: Không thể tính giai thừa cho số thập phân";
                        return;
                    }

                    // Chuyển đổi sang int
                    int intNumber = (int)lastNumber;

                    // Tính giai thừa
                    long factorialResult = TinhGiaiThua(intNumber);

                    // Cập nhật hiển thị và kết quả
                    currentOperation = currentOperation.Remove(currentOperation.LastIndexOf(lastNumberStr), lastNumberStr.Length);
                    currentOperation += $"{intNumber}!";

                    // Hiển thị kq
                    double finalResult = XuLyPhepTinh(currentOperation.Replace($"{intNumber}!", factorialResult.ToString()));
                    txtInput.Text = $"{currentOperation}\r\n{finalResult}";
                    currentOperation = finalResult.ToString();
                    this.ActiveControl = null;
                }
                else
                {
                    txtInput.Text = "Lỗi: Số không hợp lệ";
                    return;
                }
            }
            catch (Exception)
            {
                txtInput.Text = "Lỗi";
            }
        }
        private long TinhGiaiThua(int n)
        {
            if (n == 0 || n == 1) return 1;
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        // Hàm tính x bình
        private void BinhPhuong_Click(object sender, EventArgs e)
        {
            try
            {
                string[] parts = currentOperation.Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);
                string lastNumberStr = parts[^1].Trim();

                if (double.TryParse(lastNumberStr, out double lastNumber))
                {
                    currentOperation = currentOperation.Remove(currentOperation.LastIndexOf(lastNumberStr), lastNumberStr.Length);
                    currentOperation += $"{lastNumber}²";

                    double finalResult = XuLyPhepTinh(currentOperation.Replace($"{lastNumber}²", (lastNumber * lastNumber).ToString()));

                    txtInput.Text = $"{currentOperation}\r\n{finalResult}";
                    currentOperation = finalResult.ToString();
                    this.ActiveControl = null;
                }
                else
                {
                    txtInput.Text = "Lỗi";
                    return;
                }
            }
            catch (Exception)
            {
                txtInput.Text = "Lỗi nha!";
            }
        }
        private void DoiDau_Click(object sender, EventArgs e)
        {
            try
            {
                // Tìm vị trí của ký tự phép toán cuối cùng trong biểu thức
                int lastOperatorIndex = currentOperation.LastIndexOfAny(new char[] { '+', '-', '*', '/' });

                // Nếu không có phép toán nào thì toàn bộ biểu thức là một số
                string lastNumberStr;
                if (lastOperatorIndex == -1)
                {
                    lastNumberStr = currentOperation;
                }
                else
                {
                    // Tách lấy phần sau phép toán cuối cùng
                    lastNumberStr = currentOperation.Substring(lastOperatorIndex + 1).Trim();
                }

                if (double.TryParse(lastNumberStr, out double lastNumber))
                {
                    double newNumber = -lastNumber;  // Đảo dấu số cuối cùng

                    // Xóa số cuối cùng trong biểu thức hiện tại
                    currentOperation = currentOperation.Remove(lastOperatorIndex + 1, lastNumberStr.Length);
                    // Thêm số mới với dấu đã đảo
                    currentOperation += newNumber.ToString();
                    currentOperation = currentOperation.Replace("--", "+")
                                                       .Replace("-+", "-")
                                                       .Replace("+-", "-")
                                                       .Replace("++", "+");
                    if (currentOperation.Contains("*+") || currentOperation.Contains("/+") || currentOperation.Contains("+*") || currentOperation.Contains("-*"))
                    {
                        currentOperation = currentOperation.Replace("*+", "*").Replace("/+", "/").Replace("+*", "").Replace("-*", "-");
                    }

                    txtInput.Text = currentOperation;
                    this.ActiveControl = null;

                }
                else
                {
                    txtInput.Text = "Lỗi: Số không hợp lệ";
                }
            }
            catch (Exception)
            {
                txtInput.Text = "Lỗi";
            }
        }
        // Hàm 1/x
        private void PhanSo_Click(object sender, EventArgs e)
        {
            try
            {
                string[] parts = currentOperation.Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);
                string lastNumberStr = parts[^1].Trim();

                if (double.TryParse(lastNumberStr, out double lastNumber) && lastNumber != 0)
                {
                    currentOperation = currentOperation.Remove(currentOperation.LastIndexOf(lastNumberStr), lastNumberStr.Length);
                    currentOperation += $"1/{lastNumber}";

                    double finalResult = XuLyPhepTinh(currentOperation.Replace($"1/{lastNumber}", (1 / lastNumber).ToString()));

                    txtInput.Text = $"{currentOperation}\r\n{finalResult}";
                    currentOperation = finalResult.ToString();
                    this.ActiveControl = null;
                }
                else
                {
                    txtInput.Text = "Lỗi: Số không hợp lệ hoặc không thể chia cho 0";
                    return;
                }
            }
            catch (Exception)
            {
                txtInput.Text = "Lỗi";
            }
        }
       // Nút xóa kí tự cuối
        private void Xoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentOperation))
            {
                currentOperation = currentOperation.Remove(currentOperation.Length - 1);
                txtInput.Text = currentOperation;
                this.ActiveControl = null;
            }
        }
        // Nút làm mới
        private void Clear_Click(object sender, EventArgs e)
        {
            currentOperation = string.Empty;
            txtInput.Text = string.Empty;
            this.ActiveControl = null;
        }

        // Hàm chuyển sang tính năng khác của app
        // Hàm Phương Trình
        private void PT_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhuongTrinh phuongTrinhForm = new PhuongTrinh();
            phuongTrinhForm.Show();
        }
        // Hàm Feedback liên hệ Facebook của tuii
        private void FB_Btn_Click(object sender, EventArgs e)
        {
            string fbLink = "https://www.facebook.com/hoangtumua.vn/";

            Process.Start(new ProcessStartInfo // mở trang web
            {
                FileName = fbLink,
                UseShellExecute = true // mở URL
            });
        }
        // Hàm Hình
        private void Hinh_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hinh HinhForm = new Hinh();
            HinhForm.Show();
        }
        // Bye
        private void Quit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        // Hàm Chuyển
        private void Chuyen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Units ChuyenDoiForm = new Units();
            ChuyenDoiForm.Show();
        }
   
    }
}
// Htm