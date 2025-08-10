using ManageBookBus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageBookGUI
{
    public partial class FormDoanhThu : Form
    {
        public FormDoanhThu()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = dtpStartDate.Value.Date;
                DateTime endDate = dtpEndDate.Value.Date.AddDays(1).AddTicks(-1);

                if (startDate > endDate)
                {
                    MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable doanhThuData = HoaDonBus.LayDoanhThuTheoThoiGian(startDate, endDate);
                doanhThuData.Columns.Add("NgayBatDau", typeof(DateTime));
                doanhThuData.Columns.Add("NgayKetThuc", typeof(DateTime));

                foreach (DataRow row in doanhThuData.Rows)
                {
                    row["NgayBatDau"] = startDate;
                    row["NgayKetThuc"] = endDate;
                }


                if (doanhThuData.Rows.Count > 0)
                {

                    double tongDoanhThu = doanhThuData.AsEnumerable().Sum(row => row.Field<double?>("TongDoanhThu") ?? 0);

                    MessageBox.Show($"Tổng doanh thu trong khoảng thời gian từ {startDate.ToString("dd/MM/yyyy")} đến {endDate.ToString("dd/MM/yyyy")} là: {tongDoanhThu.ToString("C2")}",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvDoanhThu.DataSource = doanhThuData;
                    dgvDoanhThu.Columns["NgayBatDau"].HeaderText = "Ngày bắt đầu";
                    dgvDoanhThu.Columns["NgayKetThuc"].HeaderText = "Ngày kết thúc";
                    dgvDoanhThu.Columns["TongSoLuong"].HeaderText = "Tổng số lượng";
                    dgvDoanhThu.Columns["TongDoanhThu"].HeaderText = "Tổng doanh thu";

                    dgvDoanhThu.ColumnHeadersDefaultCellStyle.Font = new Font(dgvDoanhThu.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
                    dgvDoanhThu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgvDoanhThu.Columns["NgayBatDau"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvDoanhThu.Columns["NgayKetThuc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvDoanhThu.Columns["TongSoLuong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvDoanhThu.Columns["TongDoanhThu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
                else
                {
                    MessageBox.Show("Không có dữ liệu trong khoảng thời gian này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDoanhThu.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
