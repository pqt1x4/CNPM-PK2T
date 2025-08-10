using ManageStuDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Words;
using System.Xml.Linq;
using DGVPrinterHelper;
using System.Drawing.Printing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using ManageBookBus;
using System.Data.SqlClient;
using ManageBookDTO;
using MangeBookDAO;

namespace ManageBookGUI
{
    public partial class FormHoaDon : Form
    {

        private DataTable dt2;
        private string maKH;

        public FormHoaDon(string maKH, DataTable dt2)
        {
            InitializeComponent();
            txtMaKH.Text = maKH;
            this.maKH = maKH;
            this.dt2 = dt2;
            this.MaximizeBox = true;
            this.FormClosing += FormHoaDon_FormClosing;
        }

        private void dgvHoaDonBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            GetDataGH();
            LoadTongSoLuong();
            LoadTongThanhTien();

            string newMaKH = KhachHangDAO.GetNewMaKH();
            txtMaKH.Text = newMaKH;
            this.WindowState = FormWindowState.Maximized;

        }
        private void GetDataGH()
        {
            dgvHoaDonBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDonBan.DataSource = dt2;
        }
        private void LoadTongSoLuong()
        {
            int tongSoLuong = 0;

            foreach (DataRow row in dt2.Rows)
            {
                if (row["SoLuong"] != DBNull.Value) 
                {
                    tongSoLuong += Convert.ToInt32(row["SoLuong"]);
                }
            }

            txtTongSoLuong.Text = tongSoLuong.ToString();
        }

        public void LoadTongThanhTien()
        {
            decimal tongThanhTien = 0;

            foreach (DataRow row in dt2.Rows)
            {
                if (row["SoLuong"] != DBNull.Value && row["GiaTien"] != DBNull.Value)
                {
                    int soLuong = Convert.ToInt32(row["SoLuong"]);
                    decimal giaTien = Convert.ToDecimal(row["GiaTien"]);
                    tongThanhTien += soLuong * giaTien;
                }
            }

            txtTongThanhTien.Text = tongThanhTien.ToString("C");
        }
        public static void InsertLSMuaHang(string maKH, DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                string query = "INSERT INTO LSMuaHang (MaKH, MaSach, SoLuong, MaDV) VALUES (@MaKH, @MaSach, @SoLuong, @MaDV)";
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@MaKH", maKH), 
            new SqlParameter("@MaSach", row["MaSach"]),
            new SqlParameter("@SoLuong", row["SoLuong"]),
            new SqlParameter("@MaDV", row["MaDV"])
                };

                bool result = DataProvider.TruyVan_XuLy(query, parameters);

                if (!result)
                {
                    Console.WriteLine($"Lỗi khi thêm dòng: MaSach = {row["MaSach"]}, MaDV = {row["MaDV"]}");
                }
            }
        }

        private void InsertHoaDon(string maKH, DataTable dtHoaDon)
        {
            try
            {
                foreach (DataRow row in dtHoaDon.Rows)
                {
                    string maSach = row["MaSach"].ToString();
                    int soLuong = int.Parse(row["SoLuong"].ToString());
                    float giaTien = float.Parse(row["GiaTien"].ToString());
                    string maDV = row["MaDV"].ToString();

                    float thanhTien = soLuong * giaTien;

                    string query = "INSERT INTO HoaDon (MaKH, MaSach, MaDV, SoLuong, ThanhTien, NgayMua) " +
                                   "VALUES (@MaKH, @MaSach, @MaDV, @SoLuong, @ThanhTien, @NgayMua)";

                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@MaKH", SqlDbType.NVarChar) { Value = maKH },
                        new SqlParameter("@MaSach", SqlDbType.NVarChar) { Value = maSach },
                        new SqlParameter("@MaDV", SqlDbType.NVarChar) { Value = maDV },
                        new SqlParameter("@SoLuong", SqlDbType.Int) { Value = soLuong },
                        new SqlParameter("@ThanhTien", SqlDbType.Float) { Value = thanhTien },
                        new SqlParameter("@NgayMua", SqlDbType.DateTime) { Value = DateTime.Now }
                    };

                    bool result = DataProvider.TruyVan_XuLy(query, parameters);
                }

                MessageBox.Show("Hóa đơn đã được lưu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
        private void FormHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormKH formKH = (FormKH)Application.OpenForms["FormKH"];
            if (formKH != null)
            {
                formKH.Show();
            }
        }
        private void SearchCustomerByPhoneNumber(string phoneNumber)
        {
            string query = "SELECT MaKH, TenKH, SDT, Email FROM KhachHang WHERE SDT = @SDT";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@SDT", phoneNumber)
            };

            DataTable result = DataProvider.SelectData(query, CommandType.Text, parameters);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                txtMaKH.Text = row["MaKH"].ToString();
                txtTenKH.Text = row["TenKH"].ToString();
                txtSdt.Text = row["SDT"].ToString();
                txtEmail.Text = row["Email"].ToString();
            }
            else
            {
                MessageBox.Show("Khách hàng không tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text;

            DataTable dtHoaDon = new DataTable();
            dtHoaDon.Columns.Add("MaSach");
            dtHoaDon.Columns.Add("TenSach");
            dtHoaDon.Columns.Add("SoLuong");
            dtHoaDon.Columns.Add("GiaTien");
            dtHoaDon.Columns.Add("TenDV");
            dtHoaDon.Columns.Add("MaDV");

            foreach (DataGridViewRow row in dgvHoaDonBan.Rows)
            {
                if (row.Cells["MaSach"].Value != null)
                {
                    DataRow newRow = dtHoaDon.NewRow();
                    newRow["MaSach"] = row.Cells["MaSach"].Value;
                    newRow["TenSach"] = row.Cells["TenSach"].Value;
                    newRow["SoLuong"] = row.Cells["SoLuong"].Value;
                    newRow["GiaTien"] = row.Cells["GiaTien"].Value;
                    newRow["TenDV"] = row.Cells["TenDV"].Value;
                    newRow["MaDV"] = row.Cells["MaDV"].Value;

                    dtHoaDon.Rows.Add(newRow);
                }
            }

            InsertHoaDon(maKH, dtHoaDon);

            DGVPrinter print = new DGVPrinter();
            print.Title = "HÓA ĐƠN BÁN SÁCH";
            print.TitleFont = new System.Drawing.Font("Arial", 16, FontStyle.Bold);
            print.TitleColor = Color.Black;

            string tenKhachHang = txtTenKH.Text;
            if(tenKhachHang != "")
            {
                print.SubTitle = $"Tên Khách Hàng: {tenKhachHang}    Mã KH: {maKH}\nNgày: {DateTime.Now:dd/MM/yyyy}";
                print.SubTitleFont = new System.Drawing.Font("Arial", 12, FontStyle.Regular);
                print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            }
            else
            {
                print.SubTitle = $"Ngày: {DateTime.Now:dd/MM/yyyy}";
                print.SubTitleFont = new System.Drawing.Font("Arial", 12, FontStyle.Regular);
                print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            }
            
            print.PageNumbers = true;
            print.PageNumberInHeader = true;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Số Lượng: " + txtTongSoLuong.Text;
            print.Footer += "\nThành Tiền: " + txtTongThanhTien.Text;
            print.FooterFont = new System.Drawing.Font("Arial", 10, FontStyle.Italic);
            print.FooterSpacing = 15;
            print.PrintMargins = new System.Drawing.Printing.Margins(20, 20, 20, 20);
            print.PageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1170);

            foreach (DataGridViewColumn col in dgvHoaDonBan.Columns)
            {
                col.Width = 100;
            }

            dgvHoaDonBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            print.PrintDataGridView(dgvHoaDonBan);

            dgvHoaDonBan.DataSource = null;

            if (true)
            {
                FormKH formKH = (FormKH)Application.OpenForms["FormKH"];
                if (formKH != null)
                {
                    txtTongSoLuong.Text = " ";
                    txtTongThanhTien.Text = " ";
                    formKH.GetData2();
                    formKH.LoadTongSoLuong();
                    formKH.LoadTongThanhTien();
                }
            }
        }

        private void labelHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text;
            string tenKH = txtTenKH.Text;
            string email = txtEmail.Text;
            string sdt = txtSdt.Text;

            if (string.IsNullOrWhiteSpace(tenKH) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KhachHangDTO khachHang = new KhachHangDTO
            {
                MaKH = maKH,
                TenKH = tenKH,
                Email = email,
                SDT = sdt
            };

            try
            {
                KhachHangDAO.AddCustomer(khachHang);
                MessageBox.Show("Wow, chúng ta đã có hội viên mới nè!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtMaKH.Text = KhachHangDAO.GetNewMaKH();
                txtTenKH.Text = "";
                txtEmail.Text = "";
                txtSdt.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string phoneNumber = txtSearchSDT.Text.Trim();
            if (!string.IsNullOrEmpty(phoneNumber))
                SearchCustomerByPhoneNumber(phoneNumber);
            else
                MessageBox.Show("Vui lòng nhập số điện thoại để tìm kiếm!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                string maKH = txtMaKH.Text;
                if (string.IsNullOrEmpty(maKH))
                    return;
                FormLichSuMuaHang formLichSu = new FormLichSuMuaHang(maKH)
                {
                    MaKH = maKH,
                };
                formLichSu.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
