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
    public partial class FormQLKH : Form
    {
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
        public FormQLKH()
        {
            InitializeComponent();
            LoadDataKH();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
        private void dgvQLyKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

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
        private void ResetKH()
        {
            txtMaKH.Text = KhachHangDAO.GetNewMaKH();
            txtTenKH.Clear();
            txtEmail.Clear();
            txtSDT.Clear();

        }

        private void btnTaiLaiKH_Click(object sender, EventArgs e)
        {
            ResetKH();
            LoadDataKH();
        }

        
    }
}
