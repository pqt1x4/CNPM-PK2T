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
    public partial class FormMenuNV : Form
    {
        public FormMenuNV()
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

        private void button3_Click(object sender, EventArgs e)
        {
            FormNV formQLKH = new FormNV();
            formQLKH.Show(); // Or use formQLKH.ShowDialog() if you want a modal form
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormKH formKH = new FormKH();
            formKH.Show(); // Or use formKH.ShowDialog() if you want a modal form
        }
    }
}
