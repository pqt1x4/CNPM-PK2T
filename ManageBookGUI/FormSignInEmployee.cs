using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageBookDTO;
using ManageBookBus;

namespace ManageBookGUI
{
    public partial class FormSignInEmployee : Form
    {
        public FormSignInEmployee()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ TextBox
            string taiKhoan = textBoxTaiKhoan.Text.Trim();
            string matKhau = textBoxMatKhau.Text.Trim();

            // Kiểm tra thông tin đầu vào
            if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra loại người dùng dựa trên RadioButton
            if (radioButtonQTV.Checked)
            {
                // Xác thực đăng nhập cho quản trị viên
                QTVDTO emp = new QTVDTO
                {
                    Email = taiKhoan,
                    SDT = matKhau
                };
                bool success = QTVBus.SignInEmployee(emp);
                if (success)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide(); // Ẩn form đăng nhập
                    FormSignInEmployee mainForm = Application.OpenForms["FormSignInEmployee"] as FormSignInEmployee;
                    if (mainForm != null)
                        mainForm.Hide();

                    FormQTV formQTV = new FormQTV();
                    formQTV.FormClosed += (s, args) =>
                    {
                        if (mainForm != null)
                            mainForm.Show();
                        this.Show(); // Hiển thị lại form đăng nhập
                    };
                    formQTV.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxTaiKhoan.Clear();
                    textBoxMatKhau.Clear();
                }
            }
            else if (radioButtonNV.Checked)
            {
                // Xác thực đăng nhập cho nhân viên
                NhanVienDTO emp = new NhanVienDTO
                {
                    Email = taiKhoan,
                    SDT = matKhau
                };
                bool success = NhanVienBus.SignInEmployee(emp);
                if (success)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide(); // Ẩn form đăng nhập
                    FormSignInEmployee mainForm = Application.OpenForms["FormSignInEmployee"] as FormSignInEmployee;
                    if (mainForm != null)
                        mainForm.Hide();

                    FormMenuNV formNV = new FormMenuNV();
                    formNV.FormClosed += (s, args) =>
                    {
                        if (mainForm != null)
                            mainForm.Show();
                        this.Show(); // Hiển thị lại form đăng nhập
                    };
                    formNV.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxTaiKhoan.Clear();
                    textBoxMatKhau.Clear();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại người dùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormSignInEmployee_Load(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private bool isPasswordVisible = false;
        private void btnTogglePW_Click(object sender, EventArgs e)
        {

            if (isPasswordVisible)
            {
                // Đang hiện → chuyển sang ẩn
                textBoxMatKhau.UseSystemPasswordChar = true;
                btnTogglePW.Text = "👁️";  // Icon ẩn
                isPasswordVisible = false;
            }
            else
            {
                // Đang ẩn → chuyển sang hiện
                textBoxMatKhau.UseSystemPasswordChar = false;
                btnTogglePW.Text = "🙈";  // Icon hiện
                isPasswordVisible = true;
            }
        }
    }
}
