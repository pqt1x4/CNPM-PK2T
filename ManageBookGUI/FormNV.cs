using ManageBookBus;
using ManageBookDAO;
using ManageBookDTO;
using MangeBookDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ManageBookBus.SachBus;

namespace ManageBookGUI
{
    public partial class FormNV : Form
    {
        string TenNV, maNV, ngSinh, phai, diaChi, email, sdt;
        private string placeholderTextSach = "Nhập sách cần tìm";
        private string placeholderTextKH = "Nhập khách hàng cần tìm";
        public FormNV(string TenNV = "Nguyễn Minh Hiền", string maNV = "NV001")
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;  // Đảm bảo có viền cửa sổ

            InitializeComponent();
            this.TenNV = TenNV;
            this.maNV = maNV;
            txtMaSach.ReadOnly = true;
            txtMaNV.ReadOnly = true;
            cboTheLoai.Items.AddRange(new string[]
            {
                "Khoa Học", "Tiểu Thuyết", "Văn Học", "Trinh Thám", "Giáo Dục", "Lịch Sử","Tùy Bút","Truyện Ngắn","Truyện Dài","Sách giáo khoa","Sử Thi"
            });
            cboTheLoai.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void labelAdmin_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = NhanVienDAO.GetListNV().FirstOrDefault(nv => nv.MaNV == maNV);

            if (nv != null)
            {
                this.Hide();

                FormThongTinCaNhan per_Infoform = Application.OpenForms.OfType<FormThongTinCaNhan>().FirstOrDefault();
                if (per_Infoform == null)
                {
                    per_Infoform = new FormThongTinCaNhan(
                        nv.MaNV, nv.TenNV, nv.NgSinh, nv.Phai, nv.DiaChi, nv.Email, nv.SDT, "Employee");
                    per_Infoform.FormClosed += (s, args) =>
                    {
                        this.Show();
                    };

                    per_Infoform.Show();
                }
            }
        }
        private void FormNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain mainForm = Application.OpenForms.OfType<FormMain>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.Show();
            }
        }
        private void FormNV_Load(object sender, EventArgs e)
        {
            txtMaSach.Text = SachDAO.GetNewMaSach();
            txtMaKH.Text = KhachHangDAO.GetNewMaKH();
            labelAdmin.Text = $"{TenNV}";
            lblTenNhanVien.Text = $"{TenNV}";
            txtMaNV.Text = maNV;
            txtTimKiemSach.Text = placeholderTextSach;
            txtTimKHTheoTen.Text = placeholderTextKH;
            txtTimKHTheoTen.ForeColor = Color.Gray;
            txtTimKiemSach.ForeColor = Color.Gray;
            LoadDataSach();
            LoadDataKH();
        }

        //================QUẢN LÝ SÁCH================//
        private void LoadDataSach()
        {
            try
            {
                var danhSachSach = SachBus.GetListBook();
                dgvQLSach.DataSource = danhSachSach;

                if (dgvQLSach.Columns.Contains("GiaTien"))
                {
                    dgvQLSach.Columns["GiaTien"].Visible = false;
                }


                foreach (DataGridViewColumn column in dgvQLSach.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.HeaderCell.Style.Font = new Font(dgvQLSach.Font, FontStyle.Bold);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh mục sách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenSach.Text) || string.IsNullOrEmpty(txtTacGia.Text) || string.IsNullOrEmpty(txtSoLuong.Text) || string.IsNullOrEmpty(txtGiaBan.Text))

            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sách.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DichVuDAO.GetNewMaDV();

            if (!float.TryParse(txtGiaBan.Text, out float giaBan))
            {
                MessageBox.Show("Giá bán không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int soLuong = 0;
            if (!int.TryParse(txtSoLuong.Text, out soLuong))
            {
                MessageBox.Show("Số lượng phải là số hợp lệ.");
                return;
            }

            SachDTO sachMoi = new SachDTO
            {
                MaSach = txtMaSach.Text,
                TenSach = txtTenSach.Text,
                TacGia = txtTacGia.Text,
                NXB = dateTimePickerNXB.Value.ToString("yyyy-MM-dd"),
                TheLoai = cboTheLoai.SelectedItem?.ToString(),
                SoLuong = soLuong,
                MaNV = txtMaNV.Text,
                GiaBan = giaBan,

            };

            if (SachBus.KiemTraSachTonTai(sachMoi.MaSach, sachMoi.TenSach))
            {
                MessageBox.Show("Mã sách hoặc tên sách đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {

                bool themThanhCong = SachBus.themSach(sachMoi);
                if (themThanhCong)
                {

                    DichVuBus.themDV(new DichVuDTO
                    {
                        MaDV = DichVuDAO.GetNewMaDV(),
                        MaSach = sachMoi.MaSach,
                        TenDV = "Bán",
                        GiaTien = sachMoi.GiaBan.ToString(),
                    });

                    MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataSach();
                }
                else
                {
                    MessageBox.Show("Thêm sách thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm sách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ResetSach();
        }
        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            if (dgvQLSach.SelectedRows.Count > 0)
            {
                if (!float.TryParse(txtGiaBan.Text, out float giaBan))
                {
                    MessageBox.Show("Giá bán không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int soLuong = 0;
                if (!int.TryParse(txtSoLuong.Text, out soLuong))
                {
                    MessageBox.Show("Số lượng phải là số hợp lệ.");
                    return;
                }
                SachDTO sachSua = new SachDTO
                {
                    MaSach = dgvQLSach.SelectedRows[0].Cells["MaSach"].Value.ToString(),
                    TenSach = txtTenSach.Text,
                    TacGia = txtTacGia.Text,
                    NXB = dateTimePickerNXB.Value.ToString("yyyy-MM-dd"),
                    TheLoai = cboTheLoai.SelectedItem?.ToString(),
                    MaNV = txtMaNV.Text,
                    SoLuong = soLuong,
                    GiaBan = giaBan,

                };

                try
                {
                    string maDVBan = DichVuDAO.GetMaDVByMaSach(sachSua.MaSach, "Bán");


                    if (SachBus.suaSach(sachSua))
                    {
                        if (maDVBan != null)
                        {
                            DichVuBus.suaDV(new DichVuDTO
                            {
                                MaDV = maDVBan,
                                MaSach = sachSua.MaSach,
                                TenDV = "Bán",
                                GiaTien = sachSua.GiaBan.ToString(),
                            });
                        }

                        MessageBox.Show("Sửa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataSach();
                    }
                    else
                    {
                        MessageBox.Show("Sửa sách thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi sửa sách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ResetSach();
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (dgvQLSach.SelectedRows.Count > 0)
            {
                string maSach = dgvQLSach.SelectedRows[0].Cells["MaSach"].Value.ToString();

                SachDTO xoaSach = new SachDTO
                {
                    MaSach = maSach
                };

                if (SachBus.xoaSach(xoaSach))
                {
                    MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataSach();
                }
                else
                {
                    MessageBox.Show("Xóa sách thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ResetSach();
        }
        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {
            string tenSach = txtTimKiemSach.Text.Trim();
            if (!string.IsNullOrEmpty(tenSach))
            {
                // Tách từ khóa tìm kiếm
                string[] keywords = tenSach.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // Gọi phương thức tìm kiếm theo từ khóa
                List<SachDTO> dsSach = SachDAO.TimKiemSachTheoTuKhoa(keywords);

                if (dsSach != null && dsSach.Count > 0)
                {
                    // Hiển thị kết quả tìm kiếm lên DataGridView
                    dgvQLSach.DataSource = dsSach;
                    dgvQLSach.Refresh();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sách với tên '" + tenSach + "'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên sách cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvQLSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvQLSach.Rows[e.RowIndex];

                txtMaSach.Text = row.Cells["MaSach"].Value.ToString();
                txtTenSach.Text = row.Cells["TenSach"].Value.ToString();
                txtTacGia.Text = row.Cells["TacGia"].Value.ToString();
                string theLoai = row.Cells["TheLoai"].Value.ToString();
                cboTheLoai.SelectedItem = cboTheLoai.Items.Contains(theLoai) ? theLoai : null;
                dateTimePickerNXB.Value = Convert.ToDateTime(row.Cells["NXB"].Value);
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                txtGiaBan.Text = row.Cells["GiaBan"].Value.ToString();

            }
        }

        private void btnTaiLaiSach_Click(object sender, EventArgs e)
        {
            ResetSach();
            LoadDataSach();
        }

        private void ResetSach()
        {
            txtMaSach.Text = SachDAO.GetNewMaSach();
            txtTimKiemSach.Text = placeholderTextSach;
            txtTenSach.Clear();
            txtTacGia.Clear();
            cboTheLoai.SelectedIndex = -1;
            txtSoLuong.Clear();
            txtMaNV.Text = maNV;
            txtGiaBan.Clear();

            dateTimePickerNXB.Value = DateTime.Now;
        }


        //================QUẢN LÝ KHÁCH HÀNG================//
        private void LoadDataKH()
        {
            try
            {
                var danhSachKH = KhachHangBus.GetListKH();
                dgvQLyKH.DataSource = danhSachKH;

                foreach (DataGridViewColumn column in dgvQLyKH.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.HeaderCell.Style.Font = new Font(dgvQLyKH.Font, FontStyle.Bold);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtTenKH.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KhachHangDTO newKH = new KhachHangDTO
            {
                MaKH = txtMaKH.Text,
                TenKH = txtTenKH.Text,
                Email = txtEmail.Text,
                SDT = txtSDT.Text,
            };

            try
            {
                bool themThanhCong = KhachHangBus.AddCustomer(newKH);
                if (themThanhCong)
                {
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataKH();
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ResetKH();
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            if (dgvQLyKH.SelectedRows.Count > 0)
            {
                KhachHangDTO khSua = new KhachHangDTO
                {
                    MaKH = dgvQLyKH.SelectedRows[0].Cells["MaKH"].Value.ToString(),
                    TenKH = txtTenKH.Text,
                    Email = txtEmail.Text,
                    SDT = txtSDT.Text,
                };

                try
                {
                    if (KhachHangBus.suaKH(khSua))
                    {
                        MessageBox.Show("Sửa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataKH();
                    }
                    else
                    {
                        MessageBox.Show("Sửa khách hàng thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi sửa khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để sửa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ResetKH();
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (dgvQLyKH.SelectedRows.Count > 0)
            {
                string maKH = dgvQLyKH.SelectedRows[0].Cells["MaKH"].Value.ToString();

                KhachHangDTO xoaKH = new KhachHangDTO
                {
                    MaKH = maKH
                };

                if (KhachHangBus.xoaKH(xoaKH))
                {
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataKH();
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ResetKH();

        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            string tenKH = txtTimKHTheoTen.Text;
            if (!string.IsNullOrEmpty(tenKH))
            {
                List<KhachHangDTO> listKH = KhachHangBus.TimKiemKHTheoTen(tenKH);

                if (listKH.Count > 0)
                {
                    dgvQLyKH.DataSource = listKH;
                    dgvQLyKH.Refresh();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng với tên '" + tenKH + "'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng cần tìm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvQLyKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvQLyKH.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                txtTenKH.Text = row.Cells["TenKH"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
            }
        }

        private void btnTaiLaiKH_Click(object sender, EventArgs e)
        {
            ResetKH();
            LoadDataKH();
        }
        private void ResetKH()
        {
            txtMaKH.Text = KhachHangDAO.GetNewMaKH();
            txtTenKH.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            txtTimKHTheoTen.Text = placeholderTextKH;
        }

        private void txtTimKHTheoTen_Enter(object sender, EventArgs e)
        {
            if (txtTimKHTheoTen.Text == placeholderTextKH)
            {
                txtTimKHTheoTen.Text = "";
                txtTimKHTheoTen.ForeColor = Color.Black;
            }
        }

        private void txtTimKHTheoTen_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKHTheoTen.Text))
            {
                txtTimKHTheoTen.Text = placeholderTextKH;
                txtTimKHTheoTen.ForeColor = Color.Gray;
            }
        }

        private void txtTimKiemSach_Enter(object sender, EventArgs e)
        {
            if (txtTimKiemSach.Text == placeholderTextSach)
            {
                txtTimKiemSach.Text = "";
                txtTimKiemSach.ForeColor = Color.Black;
            }
        }

        private void txtTimKiemSach_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiemSach.Text))
            {
                txtTimKiemSach.Text = placeholderTextSach;
                txtTimKiemSach.ForeColor = Color.Gray;
            }
        }

        private void labelHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLSMuaHang_Click(object sender, EventArgs e)
        {
            if (dgvQLyKH.SelectedRows.Count > 0)
            {

                string maKH = dgvQLyKH.SelectedRows[0].Cells["MaKH"].Value.ToString();
                string tenKH = dgvQLyKH.SelectedRows[0].Cells["TenKH"].Value.ToString();
                string email = dgvQLyKH.SelectedRows[0].Cells["Email"].Value.ToString();
                string sdt = dgvQLyKH.SelectedRows[0].Cells["SDT"].Value.ToString();

                FormLichSuMuaHang formLichSu = new FormLichSuMuaHang(maKH);

                formLichSu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng trước khi xem lịch sử mua hàng!", "Thông báo");
            }
        }

        private void btnXemDoanhThu_Click(object sender, EventArgs e)
        {
            FormDoanhThu formDoanhThu = new FormDoanhThu();
            this.Hide();
            formDoanhThu.ShowDialog();
            this.Show();
        }

        private void dgvQLyKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerNXB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvQLSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cboTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            // Regex đơn giản để kiểm tra có dạng bất kỳ*@*bất kỳ
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ! Vui lòng nhập theo định dạng name@domain.extension",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
        }
    }
}
