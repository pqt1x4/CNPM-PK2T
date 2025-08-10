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
using ManageBookBus;
using ManageBookDAO;
using ManageBookDTO;
using MangeBookDAO;

namespace ManageBookGUI
{
    public partial class FormThongTinCaNhan : Form
    {
        public FormThongTinCaNhan(string maTK, string tenTK, string ngSinh, string phai, string diachi, string email, string sdt, string role)
        {
            InitializeComponent();
            labelTaiKhoan.Text = tenTK;
            txtMaTK.ReadOnly = true;
            txtTenTK.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            dateTimePickerNgaySinh.Enabled = false;
            rdbtnNam.Enabled = false;
            rdbtnNu.Enabled = false;
            if (role == "Employee")
            {
                labelMaTK.Text = "Mã nhân viên:";
                labelTenTK.Text = "Tên nhân viên:";
            }
            txtMaTK.Text = maTK;
            txtTenTK.Text = tenTK;
            txtEmail.Text = email;
            txtSDT.Text = sdt;
            txtDiaChi.Text = diachi;
            if (DateTime.TryParse(ngSinh, out DateTime parsedDate))
            {
                dateTimePickerNgaySinh.Value = parsedDate;
            }
            else
            {
                dateTimePickerNgaySinh.Value = DateTime.Now;
            }

            if (phai == "Nam")
            {
                rdbtnNam.Checked = true;
                rdbtnNu.Checked = false;
            }
            else
            {
                rdbtnNam.Checked = false;
                rdbtnNu.Checked = true;
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            txtTenTK.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            dateTimePickerNgaySinh.Enabled = true;
            rdbtnNam.Enabled = true;
            rdbtnNu.Enabled = true;

            btnChinhSua.Text = "Lưu";
            btnChinhSua.ImageIndex = 1;
            btnChinhSua.ImageAlign = ContentAlignment.MiddleRight;
            btnChinhSua.TextAlign = ContentAlignment.MiddleCenter;
            btnChinhSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChinhSua.Size = new Size(140, 60);
            btnChinhSua.Click -= btnChinhSua_Click;
            btnChinhSua.Click += btnLuu_Click;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenTK = txtTenTK.Text;
            string email = txtEmail.Text;
            string sdt = txtSDT.Text;
            string diachi = txtDiaChi.Text;
            string phai = rdbtnNam.Checked ? "Nam" : "Nữ";
            string ngSinh = dateTimePickerNgaySinh.Value.ToString("yyyy-MM-dd");

            if (labelMaTK.Text == "Mã nhân viên:")
            {
                NhanVienDTO nvDTO = new NhanVienDTO
                {
                    MaNV = txtMaTK.Text,
                    TenNV = tenTK,
                    NgSinh = ngSinh,
                    Phai = phai,
                    DiaChi = diachi,
                    Email = email,
                    SDT = sdt
                };

                bool success = NhanVienBus.updateNV(nvDTO);
                if (success)
                {
                    MessageBox.Show("Thông tin nhân viên đã được cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi cập nhật thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

            txtTenTK.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            dateTimePickerNgaySinh.Enabled = false;
            rdbtnNam.Enabled = false;
            rdbtnNu.Enabled = false;

            btnChinhSua.Text = "Cập nhật";
            btnChinhSua.ImageIndex = 0;
            btnChinhSua.ImageAlign = ContentAlignment.MiddleRight;
            btnChinhSua.TextAlign = ContentAlignment.MiddleCenter;
            btnChinhSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChinhSua.Size = new Size(160, 60);
            btnChinhSua.Click -= btnLuu_Click;
            btnChinhSua.Click += btnChinhSua_Click;
        }

        private void labelHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
