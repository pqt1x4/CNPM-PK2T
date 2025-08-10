using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ManageBookBus;
using ManageBookDTO;
using ManageStuDAO; // Thêm namespace cho DataProvider

namespace ManageBookGUI
{
    public partial class FormLichSuMuaHang : Form
    {
        private LichSuMuaHangBus bus = new LichSuMuaHangBus();
        private KhachHangBus khachHangBus = new KhachHangBus();
        public string MaKH { get; set; }

        public FormLichSuMuaHang(string maKH)
        {
            InitializeComponent();
            MaKH = maKH; // Gán giá trị cho MaKH
        }

        private void TinhTongTien()
        {
            decimal tongTien = 0;

            // Duyệt qua tất cả các hàng trong DataGridView
            foreach (DataGridViewRow row in dgvLichSu.Rows)
            {
                // Kiểm tra xem hàng có hợp lệ không
                if (row.Cells["ThanhTien"].Value != null)
                {
                    // Cố gắng chuyển đổi giá trị thành decimal
                    if (decimal.TryParse(row.Cells["ThanhTien"].Value.ToString(), out decimal thanhTien))
                    {
                        tongTien += thanhTien; // Cộng dồn vào tổng tiền
                    }
                }
            }

            // Gán tổng tiền vào txtTongTien với định dạng số
            txtTongTien.Text = tongTien.ToString("N2");
        }
        private void GetDataLS(string maKH)
        {
            try
            {
                string sql = "SELECT MaHD, MaKH, MaSach, MaDV, SoLuong, ThanhTien, NgayMua FROM HoaDon WHERE MaKH = @MaKH";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaKH", maKH)
                };

                DataTable dataTable = DataProvider.TruyVan_LayDuLieu(sql, CommandType.Text, parameters);

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Không có lịch sử mua hàng nào cho mã khách hàng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Đặt nguồn dữ liệu cho DataGridView
                dgvLichSu.DataSource = dataTable;

                // Cấu hình các cột nếu cần
                dgvLichSu.Columns["MaHD"].HeaderText = "Mã HD";
                dgvLichSu.Columns["MaKH"].HeaderText = "Mã KH";
                dgvLichSu.Columns["MaSach"].HeaderText = "Mã Sách";
                dgvLichSu.Columns["MaDV"].HeaderText = "Mã DV";
                dgvLichSu.Columns["SoLuong"].HeaderText = "Số Lượng";
                dgvLichSu.Columns["ThanhTien"].HeaderText = "Thành Tiền";
                dgvLichSu.Columns["NgayMua"].HeaderText = "Ngày Mua";
                dgvLichSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Tính tổng tiền từ lịch sử mua hàng
                TinhTongTien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLichSuMuaHang_Load(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(MaKH))
                {
                    // Hiển thị mã khách hàng vào txtMaKH
                    txtMaKH.Text = MaKH;

                    // Lấy thông tin khách hàng từ lớp KhachHangBus
                    var khachHang = khachHangBus.GetThongTinKhachHang(MaKH);
                    if (khachHang != null)
                    {
                        // Gán thông tin khách hàng vào các TextBox
                        txtTenKH.Text = khachHang.TenKH;
                        txtEmail.Text = khachHang.Email;
                        txtSDT.Text = khachHang.SDT;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Dừng lại nếu không tìm thấy khách hàng
                    }

                    GetDataLS(MaKH); // Gọi phương thức lấy dữ liệu lịch sử mua hàng từ bảng HoaDon
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
