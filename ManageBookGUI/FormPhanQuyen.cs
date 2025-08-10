using ManageBookBus;                    // Nhập namespace ManageBookBus để sử dụng các lớp liên quan đến nghiệp vụ (business logic).
using ManageBookDAO;                    // Nhập namespace ManageBookDAO để sử dụng các lớp truy cập dữ liệu (data access).
using ManageBookDTO;                    // Nhập namespace ManageBookDTO để sử dụng các lớp dữ liệu (data transfer objects).
using MangeBookDAO;                     // Lỗi chính tả: Có thể là nhầm với ManageBookDAO, nên xóa dòng này hoặc sửa thành ManageBookDAO.
using System;                           // Nhập namespace System để sử dụng các lớp cơ bản như Exception, DateTime, v.v.
using System.Collections.Generic;       // Nhập namespace để sử dụng danh sách (List<T>).
using System.ComponentModel;            // Nhập namespace để sử dụng các thuộc tính thành phần (component properties).
using System.Data;                      // Nhập namespace để sử dụng DataTable, DataSet, v.v. (liên quan đến dữ liệu).
using System.Drawing;                   // Nhập namespace để sử dụng các lớp vẽ giao diện (Color, Font, v.v.).
using System.Linq;                      // Nhập namespace để sử dụng các phương thức LINQ (query data).
using System.Text;                      // Nhập namespace để sử dụng StringBuilder, Encoding, v.v.
using System.Text.RegularExpressions;   // Nhập namespace để sử dụng biểu thức chính quy (regex) (dù chưa được sử dụng trong code này).
using System.Threading.Tasks;           // Nhập namespace để sử dụng các tác vụ bất đồng bộ (Task), nhưng chưa được áp dụng.
using System.Windows.Forms;

namespace ManageBookGUI
{
    public partial class FormPhanQuyen : Form
    {
        private NhanVienBus nvBus = new NhanVienBus();
        private void LoadDataNV()
        {
            try
            {
                var danhSachNV = NhanVienBus.GetListNV();
                Console.WriteLine($"Số lượng nhân viên: {danhSachNV?.Count ?? 0}");
                if (danhSachNV == null || danhSachNV.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu nhân viên để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvQLyNV.DataSource = null;
                    return;
                }
                dgvQLyNV.DataSource = danhSachNV;
                // Đặt tên cột rõ ràng (nếu cần)
                dgvQLyNV.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
                dgvQLyNV.Columns["TenNV"].HeaderText = "Tên Nhân Viên";
                dgvQLyNV.Columns["NgSinh"].HeaderText = "Ngày Sinh";
                dgvQLyNV.Columns["Phai"].HeaderText = "Giới Tính";
                dgvQLyNV.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgvQLyNV.Columns["SDT"].HeaderText = "Số Điện Thoại";
                dgvQLyNV.Columns["Email"].HeaderText = "Email";

                foreach (DataGridViewColumn column in dgvQLyNV.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.HeaderCell.Style.Font = new Font(dgvQLyNV.Font, FontStyle.Bold);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public FormPhanQuyen()
        {
            InitializeComponent();
            LoadDataNV();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Nhân Viên để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }

            try
            {
                // Tạo đối tượng DTO từ dữ liệu ô nhập liệu
                NhanVienDTO nv = new NhanVienDTO
                {
                    MaNV = txtMaNV.Text,
                    TenNV = txtTenNV.Text,
                    NgSinh = txtNgSinh.Text,
                    Phai = txtPhai.Text,
                    DiaChi = txtDiaChi.Text,
                    SDT = txtSDT.Text,
                    Email = txtEmail.Text
                };

                // Gọi BUS để cập nhật
                int result = NhanVienBus.CapNhatNhanVien(nv);

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataNV(); // Làm mới DataGridView
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu thất bại hoặc không tìm thấy Mã Nhân Viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNV.Text) || string.IsNullOrEmpty(txtNgSinh.Text) || string.IsNullOrEmpty(txtPhai.Text) ||
                string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NhanVienDTO newNV = new NhanVienDTO
            {
                MaNV = txtMaNV.Text,
                TenNV = txtTenNV.Text,
                NgSinh = txtNgSinh.Text,
                Phai = txtPhai.Text,
                DiaChi = txtDiaChi.Text,
                SDT = txtSDT.Text,
                Email = txtEmail.Text
            };

            try
            {
                bool themThanhCong = NhanVienBus.AddEmployee(newNV);
                if (themThanhCong)
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataNV();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ResetNV();
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (dgvQLyNV.SelectedRows.Count > 0)
            {
                string maNV = dgvQLyNV.SelectedRows[0].Cells["MaNV"].Value.ToString();

                NhanVienDTO xoaNV = new NhanVienDTO
                {
                    MaNV = maNV
                };

                if (NhanVienBus.xoaNV(xoaNV))
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataNV();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ResetNV();
        }
        private void ResetNV()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtNgSinh.Clear();
            txtPhai.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
        }
        private void btnTaiLaiKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Nhân Viên để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }

            try
            {
                // Tạo đối tượng DTO từ dữ liệu ô nhập liệu
                NhanVienDTO nv = new NhanVienDTO
                {
                    MaNV = txtMaNV.Text,
                    TenNV = txtTenNV.Text,
                    NgSinh = txtNgSinh.Text,
                    Phai = txtPhai.Text,
                    DiaChi = txtDiaChi.Text,
                    SDT = txtSDT.Text,
                    Email = txtEmail.Text
                };

                // Gọi BUS để cập nhật
                int result = NhanVienBus.CapNhatNhanVien(nv);

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataNV(); // Làm mới DataGridView
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu thất bại hoặc không tìm thấy Mã Nhân Viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }









        private void button5_Click(object sender, EventArgs e)
        {
            ResetNV();
        }
        private void dgvQLyNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo nhấp vào một hàng hợp lệ
            {
                var row = dgvQLyNV.Rows[e.RowIndex];
                txtPhai.Text = row.Cells["Phai"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                txtNgSinh.Text = row.Cells["NgSinh"].Value?.ToString() ?? "";
                txtTenNV.Text = row.Cells["TenNV"].Value?.ToString() ?? "";
                txtMaNV.Text = row.Cells["MaNV"].Value?.ToString() ?? "";
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString() ?? "";
                txtSDT.Text = row.Cells["SDT"].Value?.ToString() ?? "";
            }
        }

        private void dgvQLyNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms.Cast<Form>())
            {
                if (form != this && form.GetType() != typeof(FormSignInEmployee))
                {
                    form.Close();
                }
            }

            // Đóng form hiện tại
            this.Close();

            // Tìm và hiển thị lại FormSignInEmployee
            FormSignInEmployee signInForm = Application.OpenForms.OfType<FormSignInEmployee>().FirstOrDefault();
            if (signInForm == null)
            {
                signInForm = new FormSignInEmployee(); // Tạo mới nếu chưa tồn tại
            }
            signInForm.Show(); // Hiển thị form SignInEmployee
        }
    }
}
