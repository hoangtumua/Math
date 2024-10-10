using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Math
{
    public partial class Units : Form
    {
        public Units()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Type.SelectedItem = "Độ dài";
            txtInput.Focus();
            ChuyenDoi.Cursor = Cursors.Hand;
            Quit.Cursor = Cursors.Hand;
            Back_Btn.Cursor = Cursors.Hand;
            Ref.Cursor = Cursors.Hand;
            DaoNguoc.Cursor = Cursors.Hand;
            Type.Cursor = Cursors.Hand;
            comboBox1.Cursor = Cursors.Hand;
            comboBox2.Cursor = Cursors.Hand;
            txtInput.KeyPress += new KeyPressEventHandler(txtInput_KeyPress);
            txtInput.KeyPress += new KeyPressEventHandler(NhanPhimEnter);
            Type.KeyPress += new KeyPressEventHandler(NhanPhimEnter);
            comboBox1.KeyPress += new KeyPressEventHandler(NhanPhimEnter);
            comboBox2.KeyPress += new KeyPressEventHandler(NhanPhimEnter);
        }

        // Nút Đổi
        private void ChuyenDoi_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtInput.Text, out double input))
            {
                // Kiểm tra giá trị âm cho các loại không phải nhiệt độ
                if (Type.SelectedItem.ToString() != "Nhiệt độ" && input < 0)
                {
                    MessageBox.Show("Đại lượng này không thể là giá trị âm!\r\nBạn hãy vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Ngừng xử lý nếu giá trị âm
                }

                string fromUnit = comboBox1.SelectedItem.ToString();
                string toUnit = comboBox2.SelectedItem.ToString();
                double result = ChuyenDoiDonVi(input, fromUnit, toUnit);
                txtResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Số không hợp lệ!\nBạn hãy vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Enter
        private void NhanPhimEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ChuyenDoi_Click(sender, e);
            }
        }
        // Hàm đổi
        private double ChuyenDoiDonVi(double value, string fromUnit, string toUnit)
        {
            double valueInMetersOrGrams = value;
            double valueInGrams = value;

            // độ dài
            if (Type.SelectedItem.ToString() == "Độ dài")
            {
                // Chuyển về mét
                switch (fromUnit)
                {
                    case "cm": valueInMetersOrGrams = value / 100; break;
                    case "dm": valueInMetersOrGrams = value / 10; break;
                    case "m": valueInMetersOrGrams = value; break;
                    case "km": valueInMetersOrGrams = value * 1000; break;
                    case "feet": valueInMetersOrGrams = value * 0.3048; break;
                    case "inch": valueInMetersOrGrams = value * 0.0254; break;
                    case "mm": valueInMetersOrGrams = value / 1000; break;
                }
                switch (toUnit)
                {
                    case "cm": return valueInMetersOrGrams * 100;
                    case "dm": return valueInMetersOrGrams * 10;
                    case "m": return valueInMetersOrGrams;
                    case "km": return valueInMetersOrGrams / 1000;
                    case "feet": return valueInMetersOrGrams / 0.3048;
                    case "inch": return valueInMetersOrGrams / 0.0254;
                    case "mm": return valueInMetersOrGrams * 1000;
                }
            }

            //  khối lượng
            else if (Type.SelectedItem.ToString() == "Khối lượng")
            {
                // Chuyển về gram
                switch (fromUnit)
                {
                    case "Gram": valueInGrams = value; break;
                    case "Kilogram": valueInGrams = value * 1000; break;
                    case "Pound": valueInGrams = value * 453.59237; break;
                    case "Ounce": valueInGrams = value * 28.3495231; break;
                    case "Tấn": valueInGrams = value * 1000000; break;
                    case "Tạ": valueInGrams = value * 100000; break;
                    case "Yến": valueInGrams = value * 10000; break;
                }
                switch (toUnit)
                {
                    case "Gram": return valueInGrams;
                    case "Kilogram": return valueInGrams / 1000;
                    case "Pound": return valueInGrams / 453.59237;
                    case "Ounce": return valueInGrams / 28.3495231;
                    case "Tấn": return valueInGrams / 1000000;
                    case "Tạ": return valueInGrams / 100000;
                    case "Yến": return valueInGrams / 10000;
                }
            }
            // 1 Pound = 453.59237 gam; 1 Ounce  28.3495231 gam

            //   vận tốc
            if (Type.SelectedItem.ToString() == "Vận tốc")
            {
                double valueInMetersPerSecond = value;

                // Chuyển về m/s
                switch (fromUnit)
                {
                    case "m/s": valueInMetersPerSecond = value; break;
                    case "km/h": valueInMetersPerSecond = value / 3.6; break;
                    case "mph": valueInMetersPerSecond = value * 0.44704; break;
                    case "ft/s": valueInMetersPerSecond = value * 0.3048; break;
                    case "kn": valueInMetersPerSecond = value * 0.514444; break;
                }
                switch (toUnit)
                {
                    case "m/s": return valueInMetersPerSecond;
                    case "km/h": return valueInMetersPerSecond * 3.6;
                    case "mph": return valueInMetersPerSecond / 0.44704;
                    case "ft/s": return valueInMetersPerSecond / 0.3048;
                    case "kn": return valueInMetersPerSecond / 0.514444;
                }
            }

            //   thể tích
            else if (Type.SelectedItem.ToString() == "Thể tích")
            {
                double valueInLiters = value;

                // Chuyển về lít
                switch (fromUnit)
                {
                    case "ml": valueInLiters = value / 1000; break;
                    case "l": valueInLiters = value; break;
                    case "m³": valueInLiters = value * 1000; break;
                    case "cm³": valueInLiters = value / 1000; break;
                    case "ft³": valueInLiters = value * 28.3168466; break;
                    case "in³": valueInLiters = value * 0.016387064; break;
                }
                switch (toUnit)
                {
                    case "ml": return valueInLiters * 1000;
                    case "l": return valueInLiters;
                    case "m³": return valueInLiters / 1000;
                    case "cm³": return valueInLiters * 1000;
                    case "ft³": return valueInLiters / 28.3168466;
                    case "in³": return valueInLiters / 0.016387064;
                }
            }

            // Nhiệt độ
            else if (Type.SelectedItem.ToString() == "Nhiệt độ")
            {
                double tempInCelsius = value; // Khởi tạo nhiệt độ ở °C

                // Chuyển về C 
                switch (fromUnit)
                {
                    case "Độ C": tempInCelsius = value; break;
                    case "Độ F": tempInCelsius = (value - 32) / 1.8; break;
                    case "Độ K": tempInCelsius = value - 273.15; break;
                }
                switch (toUnit)
                {
                    case "Độ C": return tempInCelsius;
                    case "Độ F": return tempInCelsius * 9 / 5 + 32;
                    case "Độ K": return tempInCelsius + 273.15;
                }
            }
            else if (Type.SelectedItem.ToString() == "Diện tích")
            {
                double valueInSquareMeters = value;

                // Chuyển về m²
                switch (fromUnit)
                {
                    case "cm²": valueInSquareMeters = value / 10000; break;
                    case "m²": valueInSquareMeters = value; break;
                    case "km²": valueInSquareMeters = value * 1000000; break;
                    case "ft²": valueInSquareMeters = value * 0.092903; break;
                    case "in²": valueInSquareMeters = value * 0.00064516; break;
                }
                switch (toUnit)
                {
                    case "cm²": return valueInSquareMeters * 10000;
                    case "m²": return valueInSquareMeters;
                    case "km²": return valueInSquareMeters / 1000000;
                    case "ft²": return valueInSquareMeters / 0.092903;
                    case "in²": return valueInSquareMeters / 0.00064516;
                }
            }


            return value;
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
            txtInput.Clear();
            txtResult.Clear();

        }
        // Hàm chọn loại đại lượng
        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            //  Độ dài 
            if (Type.SelectedItem.ToString() == "Độ dài")
            {
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox1.Items.AddRange(new string[] { "mm", "cm", "dm", "m", "km", "feet", "inch"  });
                comboBox2.Items.AddRange(new string[] { "mm",  "cm", "dm", "m", "km", "feet", "inch" });
                comboBox1.SelectedItem = "cm";
                comboBox2.SelectedItem = "m";
            }
            //  Khối lượng 
            else if (Type.SelectedItem.ToString() == "Khối lượng")
            {
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox1.Items.AddRange(new string[] { "Gram", "Kilogram", "Yến", "Tạ", "Tấn", "Pound", "Ounce" });
                comboBox2.Items.AddRange(new string[] { "Gram", "Kilogram", "Yến", "Tạ", "Tấn", "Pound", "Ounce" });
                comboBox1.SelectedItem = "Gram";
                comboBox2.SelectedItem = "Kilogram";
            }
            // Vận tốc
            else if (Type.SelectedItem.ToString() == "Vận tốc")
            {
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox1.Items.AddRange(new string[] { "m/s", "km/h", "mph", "ft/s", "kn" });
                comboBox2.Items.AddRange(new string[] { "m/s", "km/h", "mph", "ft/s", "kn" });
                comboBox1.SelectedItem = "m/s";
                comboBox2.SelectedItem = "km/h";
            }
            //   Thể tích 
            else if (Type.SelectedItem.ToString() == "Thể tích")
            {
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox1.Items.AddRange(new string[] { "ml", "l", "m³", "cm³", "ft³", "in³" });
                comboBox2.Items.AddRange(new string[] { "ml", "l", "m³", "cm³", "ft³", "in³" });
                comboBox1.SelectedItem = "ml";
                comboBox2.SelectedItem = "l";
            }
            // Nhiệt 
            else if (Type.SelectedItem.ToString() == "Nhiệt độ")
            {
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox1.Items.AddRange(new string[] { "Độ C", "Độ F", "Độ K" });
                comboBox2.Items.AddRange(new string[] { "Độ C", "Độ F", "Độ K" });
                comboBox1.SelectedItem = "Độ C";
                comboBox2.SelectedItem = "Độ F";
            }
            // diện t
            else if (Type.SelectedItem.ToString() == "Diện tích")
            {
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox1.Items.AddRange(new string[] { "cm²", "m²", "km²", "ft²", "in²" });
                comboBox2.Items.AddRange(new string[] { "cm²", "m²", "km²", "ft²", "in²" });
                comboBox1.SelectedItem = "cm²";
                comboBox2.SelectedItem = "m²";
            }
        }
        // Nút đổi đơn vị đo
        private void DaoNguoc_Click(object sender, EventArgs e)
        {
            var temp = comboBox1.SelectedItem;
            comboBox1.SelectedItem = comboBox2.SelectedItem;
            comboBox2.SelectedItem = temp;
            ChuyenDoi_Click(sender, e);
        }
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Type.SelectedItem.ToString() == "Nhiệt độ")
            {
                 if (e.KeyChar == '-' && txtInput.Text.Length == 0)
                {
                    e.Handled = false;
                    return;  
                }
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled =true;  
           
            }

             if (e.KeyChar == '.' && txtInput.Text.Contains('.'))
            {
                e.Handled = true;  
            }
            if (e.KeyChar == '.' && txtInput.Text.Length == 0)
            {
                txtInput.Text = "0";
                txtInput.SelectionStart = txtInput.Text.Length;
            }
        }
 
    }
}
