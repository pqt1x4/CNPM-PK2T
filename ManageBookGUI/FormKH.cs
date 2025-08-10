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
using System.Xml.Linq;
using ManageBookBus;
using ManageBookDAO;
using ManageBookDTO;
using ManageStuDAO;
using System.Data.SqlClient;
using MangeBookDAO;

namespace ManageBookGUI
{
    public partial class FormKH : Form
    {
        private int selectedRowIndex = -1;
        DataTable dt2;
        public FormKH()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.Sizable;  // Đảm bảo có viền cửa sổ
            this.MaximizeBox = true; // Cho phép tối đa hóa cửa sổ
            this.FormClosing += new FormClosingEventHandler(FormKH_FormClosing);
            cboTheLoai.Items.AddRange(new string[]
            {
                "Khoa Học", "Tiểu Thuyết", "Văn Học", "Trinh Thám", "Giáo Dục", "Lịch Sử","Tùy Bút","Truyện Ngắn","Truyện Dài","Sách giáo khoa","Sử Thi"
            });
            cboTheLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

       

        private void DinhDangCot_DataGridView1()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            dataGridView1.Columns["MaSach"].HeaderText = "Mã Sách";
            dataGridView1.Columns["TenSach"].HeaderText = "Tên Sách";
            dataGridView1.Columns["TacGia"].HeaderText = "Tác Giả";
            dataGridView1.Columns["SoLuong"].HeaderText = "Số Lượng";
            dataGridView1.Columns["GiaTien"].HeaderText = "Giá Tiền";
            dataGridView1.Columns["TenDV"].HeaderText = "Tên Dịch Vụ";
            dataGridView1.Columns["MaDV"].HeaderText = "Mã Dịch Vụ";
            dataGridView1.Columns["TheLoai"].HeaderText = "Thể Loại";
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            }
        }

        private void FormKH_Load(object sender, EventArgs e)
        {
            GetData();
            GetData2();
            this.WindowState = FormWindowState.Maximized;  // Mở Form ở chế độ toàn màn hình
        }
        private void GetData(string searchKeyword = "")
        {
            try
            {
                // Câu truy vấn mặc định
                string sql = @"SELECT Sach.MaSach, Sach.TenSach, Sach.TacGia, Sach.TheLoai, Sach.MaNV, Sach.SoLuong, 
                       DichVu.GiaTien, DichVu.TenDV, DichVu.MaDV 
                       FROM Sach 
                       LEFT JOIN DichVu ON Sach.MaSach = DichVu.MaSach";

                // Nếu có từ khóa tìm kiếm, thêm điều kiện WHERE vào câu truy vấn
                if (!string.IsNullOrEmpty(searchKeyword))
                {
                    sql += " WHERE Sach.TenSach LIKE @Keyword OR Sach.MaSach LIKE @Keyword OR Sach.TacGia LIKE @Keyword OR Sach.TheLoai LIKE @Keyword";
                }

                // Thực hiện truy vấn với các tham số
                List<SqlParameter> parameters = new List<SqlParameter>();
                if (!string.IsNullOrEmpty(searchKeyword))
                {
                    parameters.Add(new SqlParameter("@Keyword", "%" + searchKeyword + "%"));
                }

                DataTable dt = DataProvider.TruyVan_LayDuLieu(sql, CommandType.Text, parameters.ToArray());

                // Thiết lập các thuộc tính cho DataGridView
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dt != null && dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
            }
            DinhDangCot_DataGridView1();
            



        }

        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text; // Lấy từ khóa tìm kiếm từ TextBox
            GetData(searchText); // Gọi hàm GetData để lọc theo từ khóa
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //string searchText = txtSearch.Text; // Lấy từ khóa tìm kiếm
            //GetData(searchText); // Gọi lại hàm GetData để lọc theo từ khóa
        }
        private void ResetTT()
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtGia.Text = "";
            txtLoaiSach.Text = "";
            txtMaDV.Text = "";
            txtTenDV.Text = "";
            txtMaDV.Text = "";
            txtSoLuong.Text = "";
        }
        public void GetData2()
        {
            dt2 = new DataTable();
            dt2.Columns.Add("MaSach");
            dt2.Columns.Add("TenSach");
            dt2.Columns.Add("TacGia");
            dt2.Columns.Add("SoLuong");
            dt2.Columns.Add("GiaTien");
            dt2.Columns.Add("TenDV");
            dt2.Columns.Add("MaDV");
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.DataSource = dt2; // Gán DataTable cho DataGridView2
        }

        public void LoadTongSoLuong()
        {
            int tongSoLuong = 0;

            // Duyệt qua tất cả các dòng trong DataTable dt2
            foreach (DataRow row in dt2.Rows)
            {
                if (row["SoLuong"] != DBNull.Value) // Kiểm tra giá trị không null
                {
                    tongSoLuong += Convert.ToInt32(row["SoLuong"]);
                }
            }

            // Hiển thị tổng số lượng vào txtTongSoLuong
            txtTongSoLuong.Text = tongSoLuong.ToString();
        }
        public void LoadTongThanhTien()
        {
            decimal tongThanhTien = 0;

            // Duyệt qua tất cả các dòng trong DataTable dt2
            foreach (DataRow row in dt2.Rows)
            {
                if (row["SoLuong"] != DBNull.Value && row["GiaTien"] != DBNull.Value) // Kiểm tra giá trị không null
                {
                    int soLuong = Convert.ToInt32(row["SoLuong"]);
                    decimal giaTien = Convert.ToDecimal(row["GiaTien"]);
                    tongThanhTien += soLuong * giaTien; // Cộng dồn tổng thành tiền
                }
            }

            // Hiển thị tổng thành tiền vào txtTongThanhTien
            txtTongThanhTien.Text = tongThanhTien.ToString("C"); // Định dạng tiền tệ
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            txtMaSach.Text = dataGridView1.Rows[e.RowIndex].Cells["MaSach"].Value.ToString();
            txtTenSach.Text = dataGridView1.Rows[e.RowIndex].Cells["TenSach"].Value.ToString();
            txtLoaiSach.Text = dataGridView1.Rows[e.RowIndex].Cells["TheLoai"].Value.ToString();
            txtGia.Text = dataGridView1.Rows[e.RowIndex].Cells["GiaTien"].Value.ToString() + " đ ";
            txtTenDV.Text = dataGridView1.Rows[e.RowIndex].Cells["MaDV"].Value.ToString();
            txtMaDV.Text = dataGridView1.Rows[e.RowIndex].Cells["TenDV"].Value.ToString();

        }
        private void btnXemGH_Click(object sender, EventArgs e)
        {
            panelGH.Visible = !panelGH.Visible;
        }
        private void btnXoaGH_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong dataGridView2 không
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Lấy thông tin từ dòng được chọn
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                string maSach = selectedRow.Cells["MaSach"].Value.ToString();
                int soLuong = Convert.ToInt32(selectedRow.Cells["SoLuong"].Value);

                // Xóa dòng khỏi dataGridView2 và DataTable
                dt2.Rows.RemoveAt(selectedRow.Index);
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = dt2;

                // Lấy số lượng còn lại hiện tại từ cơ sở dữ liệu
                int soLuongCon = GetSoLuongCon(maSach);

                // Cập nhật lại số lượng trong cơ sở dữ liệu
                UpdateSoLuongSach(maSach, soLuongCon + soLuong);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sách để xóa khỏi giỏ hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Cập nhật tổng số lượng và tổng thành tiền
            txtTongSoLuong.Text = " ";
            txtTongThanhTien.Text = " ";
            GetData();
        }
        private void btnThemGH_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong dataGridView1 không
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy thông tin từ dòng được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string maSach = selectedRow.Cells["MaSach"].Value.ToString();
                string tenSach = selectedRow.Cells["TenSach"].Value.ToString();
                string tacGia = selectedRow.Cells["TacGia"].Value.ToString();
                string theLoai = selectedRow.Cells["TheLoai"].Value.ToString();
                string giaTien = selectedRow.Cells["GiaTien"].Value.ToString();
                string maDV = selectedRow.Cells["MaDV"].Value.ToString();  // Mã dịch vụ
                string tenDV = selectedRow.Cells["TenDV"].Value.ToString(); // Tên dịch vụ

                // Lấy số lượng từ TextBox
                int soLuong;
                if (int.TryParse(txtSoLuong.Text, out soLuong) && soLuong > 0)
                {
                    // Kiểm tra số lượng còn lại trong cơ sở dữ liệu
                    int soLuongCon = GetSoLuongCon(maSach); // Gọi hàm để lấy số lượng còn lại

                    // Kiểm tra xem số lượng đã được thêm vào dataGridView2 chưa
                    int soLuongDaThem = GetSoLuongDaThem(maSach); // Hàm để lấy tổng số lượng đã thêm

                    if (soLuong <= soLuongCon)
                    {
                        // Kiểm tra xem sách đã có trong giỏ hàng (dataGridView2) hay chưa
                        DataRow existingRow = dt2.Rows.Cast<DataRow>().FirstOrDefault(row => row["MaSach"].ToString() == maSach);

                        if (existingRow != null)
                        {
                            // Sách đã tồn tại trong giỏ hàng -> Cập nhật số lượng
                            // Kiểm tra xem mã dịch vụ đã có trong giỏ hàng chưa
                            DataRow existingRowWithDV = dt2.Rows.Cast<DataRow>().FirstOrDefault(row => row["MaSach"].ToString() == maSach && row["MaDV"].ToString() == maDV);

                            if (existingRowWithDV != null)
                            {
                                // Nếu mã dịch vụ trùng, cập nhật số lượng
                                int soLuongHienTai = Convert.ToInt32(existingRowWithDV["SoLuong"]);
                                existingRowWithDV["SoLuong"] = soLuongHienTai + soLuong;
                            }
                            else
                            {
                                // Nếu mã dịch vụ khác, thêm dòng mới
                                DataRow newRow = dt2.NewRow();

                                // Thêm thông tin vào dòng mới
                                newRow["MaSach"] = maSach;
                                newRow["TenSach"] = tenSach;
                                newRow["TacGia"] = tacGia;
                                newRow["GiaTien"] = giaTien;
                                newRow["SoLuong"] = soLuong;
                                newRow["MaDV"] = maDV;
                                newRow["TenDV"] = tenDV;

                                dt2.Rows.Add(newRow);
                            }
                        }
                        else
                        {
                            // Sách chưa có trong giỏ hàng -> Thêm dòng mới
                            DataRow newRow = dt2.NewRow();

                            // Thêm thông tin vào dòng mới
                            newRow["MaSach"] = maSach;
                            newRow["TenSach"] = tenSach;
                            newRow["TacGia"] = tacGia;
                            newRow["GiaTien"] = giaTien;
                            newRow["SoLuong"] = soLuong;
                            newRow["MaDV"] = maDV;
                            newRow["TenDV"] = tenDV;

                            dt2.Rows.Add(newRow);
                        }

                        // Cập nhật dataGridView2
                        dataGridView2.DataSource = null; // Đặt lại nguồn dữ liệu
                        dataGridView2.DataSource = dt2; // Gán lại nguồn dữ liệu mới

                        // Cập nhật số lượng còn lại trong cơ sở dữ liệu
                        UpdateSoLuongSach(maSach, soLuongCon - soLuong);
                    }
                    else
                    {
                        MessageBox.Show("Store chúng tôi không đủ sách rồi :< ");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lượng nhé!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sách để thêm!");
            }

            // Cập nhật thông tin tổng
            LoadTongSoLuong();
            LoadTongThanhTien();
            GetData();
            ResetTT();
        }
        private int GetSoLuongCon(string maSach)
        {
            string sql = "SELECT SoLuong FROM Sach WHERE MaSach = @MaSach";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaSach", maSach)
            };

            object result = DataProvider.ExecuteScalar(sql, CommandType.Text, parameters);

            return result != null ? Convert.ToInt32(result) : 0; // Trả về 0 nếu không tìm thấy
        }
        private int GetSoLuongDaThem(string maSach)
        {
            int totalQuantityAdded = 0;

            foreach (DataRow row in dt2.Rows)
            {
                if (row["MaSach"].ToString() == maSach)
                {
                    totalQuantityAdded += Convert.ToInt32(row["SoLuong"]);
                }
            }

            return totalQuantityAdded;
        }
        private void UpdateSoLuongSach(string maSach, int soLuongMoi)
        {
            string sql = "UPDATE Sach SET SoLuong = @SoLuong WHERE MaSach = @MaSach";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@SoLuong", soLuongMoi),
        new SqlParameter("@MaSach", maSach)
            };

            DataProvider.ExcuteNonQuery(sql, CommandType.Text, parameters);
        }
        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu FormMain chưa được mở, mới tạo và hiển thị
            if (Application.OpenForms["FormMain"] == null)
            {
                FormMain formMain = new FormMain();
                formMain.Show();
            }

            // Đóng form hiện tại
            this.Close();
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu FormMain chưa được mở, mới tạo và hiển thị
            if (Application.OpenForms["FormMain"] == null)
            {
                FormMain formMain = new FormMain();
                formMain.Show();
            }

            string maKH = "Mã khách hàng"; // Thay bằng giá trị thực tế
            string tenKH = "Tên khách hàng"; // Thay bằng giá trị thực tế
            FormHoaDon formHoaDon = new FormHoaDon(maKH, dt2);
            formHoaDon.Show();
            this.Hide();  // Ẩn FormKH, không đóng
        }
        private void labelHome_Click(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(FormKH_FormClosing);
            this.Close();
        }
        private void khoSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string searchKeyword = null;
            GetData(searchKeyword);
            //cboTheLoai.Items.Clear();
        }
        private void FormKH_FormClosing(object sender, FormClosingEventArgs e)
        {
            //// Lặp qua tất cả các dòng trong dt2 để cập nhật lại số lượng sách trong kho
            foreach (DataRow row in dt2.Rows)
            {
                string maSach = row["MaSach"].ToString();
                int soLuong = Convert.ToInt32(row["SoLuong"]);

                //    // Lấy số lượng còn lại trong cơ sở dữ liệu
                int soLuongCon = GetSoLuongCon(maSach);

                //    // Cập nhật lại số lượng trong kho
                UpdateSoLuongSach(maSach, soLuongCon + soLuong);
            }

            //// Xóa toàn bộ dữ liệu trong DataTable
            dt2.Clear();

            // Cập nhật lại dataGridView2 để phản ánh sự thay đổi
            dataGridView2.DataSource = null; // Đặt lại nguồn dữ liệu
            dataGridView2.DataSource = dt2;  // Gán lại DataTable đã bị xóa hết dữ liệu

            //// Cập nhật lại tổng số lượng và tổng thành tiền nếu cần
            txtTongSoLuong.Text = "0";
            txtTongThanhTien.Text = "0";

            // Thực hiện thêm thao tác cần thiết trước khi form đóng
            // Ví dụ: Lưu lại các thay đổi vào cơ sở dữ liệu nếu cần
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HenryBook tự hào là một trong những nhà sách hiện đại và thân thiện nhất, với sứ mệnh mang đến cho cộng đồng không gian đọc sách và học tập lý tưởng. Tại đây, chúng tôi không chỉ cung cấp sách mà còn lan tỏa niềm đam mê tri thức đến mọi người, từ trẻ em đến người lớn.",
                            "Giới thiệu về HenryBook",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void cboTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy giá trị mục được chọn
            string selectedCategory = cboTheLoai.SelectedItem.ToString();

            // Gọi hàm GetData với từ khóa là thể loại được chọn
            GetData(selectedCategory);
        }

    }
}
