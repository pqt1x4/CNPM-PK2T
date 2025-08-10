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
    public partial class FormMenuQTV : Form
    {
        public FormMenuQTV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            FormPhanQuyen formPhanQuyen = new FormPhanQuyen();
            formPhanQuyen.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormQLKH formQLKH = new FormQLKH();
            formQLKH.Show();
        }
    }
}
