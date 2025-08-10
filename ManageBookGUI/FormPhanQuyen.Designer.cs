namespace ManageBookGUI
{
    partial class FormPhanQuyen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            button3 = new Button();
            btnTaiLaiKH = new Button();
            btnXoaKH = new Button();
            btnThemKH = new Button();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            txtEmail = new TextBox();
            label7 = new Label();
            txtPhai = new TextBox();
            label6 = new Label();
            btnTaiLaiKH1 = new Button();
            button5 = new Button();
            txtSDT = new TextBox();
            label5 = new Label();
            txtDiaChi = new TextBox();
            label4 = new Label();
            txtNgSinh = new TextBox();
            label3 = new Label();
            txtTenNV = new TextBox();
            label2 = new Label();
            txtMaNV = new TextBox();
            label1 = new Label();
            dgvQLyNV = new DataGridView();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLyNV).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýToolStripMenuItem, đăngXuấtToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1427, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(73, 24);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(91, 24);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(btnTaiLaiKH);
            groupBox1.Controls.Add(btnXoaKH);
            groupBox1.Controls.Add(btnThemKH);
            groupBox1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(4, 51, 94);
            groupBox1.Location = new Point(150, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1124, 137);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "CHỨC NĂNG";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(4, 51, 94);
            button3.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(872, 54);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(181, 60);
            button3.TabIndex = 3;
            button3.Text = "THOÁT";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnTaiLaiKH
            // 
            btnTaiLaiKH.BackColor = Color.FromArgb(4, 51, 94);
            btnTaiLaiKH.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold);
            btnTaiLaiKH.ForeColor = SystemColors.ButtonHighlight;
            btnTaiLaiKH.Location = new Point(608, 54);
            btnTaiLaiKH.Name = "btnTaiLaiKH";
            btnTaiLaiKH.RightToLeft = RightToLeft.No;
            btnTaiLaiKH.Size = new Size(181, 60);
            btnTaiLaiKH.TabIndex = 2;
            btnTaiLaiKH.Text = "CẬP NHẬT";
            btnTaiLaiKH.UseVisualStyleBackColor = false;
            btnTaiLaiKH.Click += btnTaiLaiKH_Click;
            // 
            // btnXoaKH
            // 
            btnXoaKH.BackColor = Color.FromArgb(4, 51, 94);
            btnXoaKH.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold);
            btnXoaKH.ForeColor = SystemColors.ButtonHighlight;
            btnXoaKH.Location = new Point(352, 54);
            btnXoaKH.Name = "btnXoaKH";
            btnXoaKH.RightToLeft = RightToLeft.No;
            btnXoaKH.Size = new Size(181, 60);
            btnXoaKH.TabIndex = 1;
            btnXoaKH.Text = "XÓA";
            btnXoaKH.UseVisualStyleBackColor = false;
            btnXoaKH.Click += btnXoaKH_Click;
            // 
            // btnThemKH
            // 
            btnThemKH.BackColor = Color.FromArgb(4, 51, 94);
            btnThemKH.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold);
            btnThemKH.ForeColor = SystemColors.ButtonHighlight;
            btnThemKH.Location = new Point(88, 54);
            btnThemKH.Name = "btnThemKH";
            btnThemKH.RightToLeft = RightToLeft.No;
            btnThemKH.Size = new Size(181, 60);
            btnThemKH.TabIndex = 0;
            btnThemKH.Text = "THÊM";
            btnThemKH.UseVisualStyleBackColor = false;
            btnThemKH.Click += btnThemKH_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.FormPhanQuyen1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1428, 868);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(4, 51, 94);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtPhai);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnTaiLaiKH1);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(txtSDT);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtDiaChi);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtNgSinh);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtTenNV);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtMaNV);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(24, 318);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1381, 259);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "THÔNG TIN";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(878, 150);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(395, 38);
            txtEmail.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(689, 150);
            label7.Name = "label7";
            label7.Size = new Size(77, 25);
            label7.TabIndex = 13;
            label7.Text = "EMAIL";
            // 
            // txtPhai
            // 
            txtPhai.Location = new Point(229, 196);
            txtPhai.Name = "txtPhai";
            txtPhai.Size = new Size(395, 38);
            txtPhai.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(40, 196);
            label6.Name = "label6";
            label6.Size = new Size(113, 25);
            label6.TabIndex = 11;
            label6.Text = "GIỚI TÍNH";
            // 
            // btnTaiLaiKH1
            // 
            btnTaiLaiKH1.BackColor = Color.FromArgb(0, 66, 116);
            btnTaiLaiKH1.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold);
            btnTaiLaiKH1.ForeColor = SystemColors.ButtonHighlight;
            btnTaiLaiKH1.Location = new Point(1081, 199);
            btnTaiLaiKH1.Name = "btnTaiLaiKH1";
            btnTaiLaiKH1.RightToLeft = RightToLeft.No;
            btnTaiLaiKH1.Size = new Size(169, 44);
            btnTaiLaiKH1.TabIndex = 10;
            btnTaiLaiKH1.Text = "LƯU";
            btnTaiLaiKH1.UseVisualStyleBackColor = false;
            btnTaiLaiKH1.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonHighlight;
            button5.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(4, 51, 94);
            button5.Location = new Point(898, 199);
            button5.Name = "button5";
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(169, 44);
            button5.TabIndex = 4;
            button5.Text = "LÀM MỚI";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(878, 104);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(395, 38);
            txtSDT.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(689, 104);
            label5.Name = "label5";
            label5.Size = new Size(173, 25);
            label5.TabIndex = 8;
            label5.Text = "SỐ ĐIỆN THOẠI";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(878, 58);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(395, 38);
            txtDiaChi.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(689, 58);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 6;
            label4.Text = "ĐỊA CHỈ";
            // 
            // txtNgSinh
            // 
            txtNgSinh.Location = new Point(229, 150);
            txtNgSinh.Name = "txtNgSinh";
            txtNgSinh.Size = new Size(395, 38);
            txtNgSinh.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(40, 150);
            label3.Name = "label3";
            label3.Size = new Size(129, 25);
            label3.TabIndex = 4;
            label3.Text = "NGÀY SINH";
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(229, 104);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(395, 38);
            txtTenNV.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(40, 104);
            label2.Name = "label2";
            label2.Size = new Size(177, 25);
            label2.TabIndex = 2;
            label2.Text = "TÊN NHÂN VIÊN";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(229, 58);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(395, 38);
            txtMaNV.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(40, 58);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 0;
            label1.Text = "MÃ NHÂN VIÊN";
            // 
            // dgvQLyNV
            // 
            dgvQLyNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLyNV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvQLyNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLyNV.Location = new Point(24, 583);
            dgvQLyNV.Name = "dgvQLyNV";
            dgvQLyNV.RowHeadersWidth = 51;
            dgvQLyNV.Size = new Size(1381, 247);
            dgvQLyNV.TabIndex = 4;
            dgvQLyNV.CellContentClick += dgvQLyNV_CellContentClick;
            dgvQLyNV.CellClick += dgvQLyNV_CellClick;
            // 
            // FormPhanQuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1427, 865);
            Controls.Add(dgvQLyNV);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            MainMenuStrip = menuStrip1;
            Name = "FormPhanQuyen";
            Text = "FormPhanQuyen";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLyNV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button button3;
        private Button btnTaiLaiKH;
        private Button btnXoaKH;
        private Button btnThemKH;
        private GroupBox groupBox2;
        private Button btnTaiLaiKH1;
        private Button button5;
        private TextBox txtSDT;
        private Label label5;
        private TextBox txtDiaChi;
        private Label label4;
        private TextBox txtNgSinh;
        private Label label3;
        private TextBox txtTenNV;
        private Label label2;
        private TextBox txtMaNV;
        private Label label1;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtPhai;
        private Label label6;
        private DataGridView dgvQLyNV;
    }
}