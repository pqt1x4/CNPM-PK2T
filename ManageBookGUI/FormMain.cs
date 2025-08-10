using System.Diagnostics;

namespace ManageBookGUI
{
    public partial class FormMain:Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnDangNhapNhanVien_Click(object sender,EventArgs e)
        {
            FormSignInEmployee FSIE = new FormSignInEmployee();
            FSIE.ShowDialog();
        }

        private void btnMuaSach_Click(object sender,EventArgs e)
        {
            FormKH FKH = new FormKH();
            FKH.Show();
        }

        private void btnCSKH_Click(object sender,EventArgs e)
        {
            MessageBox.Show("Mọi thắc mắc hay thiếu nại về sản phẩm, xin vui lòng liên hệ qua địa chỉ email: "+
                "pqt1x4@gmail.com để được tư vấn và giải đáp thắc mắc. 11PM's Book xin cảm ơn quý khách!");
        }

        private void btnThoat_Click(object sender,EventArgs e)
        {
            this.Close();
        }
    }
}
