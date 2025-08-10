namespace ManageBookGUI
{
    partial class FormQLKH
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
            groupBox1 = new GroupBox();
            label21 = new Label();
            label15 = new Label();
            label17 = new Label();
            label16 = new Label();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            txtTenKH = new TextBox();
            txtMaKH = new TextBox();
            btnTaiLaiKH = new Button();
            btnLSMuaHang = new Button();
            btnXoaKH = new Button();
            btnSuaKH = new Button();
            btnThemKH = new Button();
            dgvQLyKH = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLyKH).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtTenKH);
            groupBox1.Controls.Add(txtMaKH);
            groupBox1.Controls.Add(btnTaiLaiKH);
            groupBox1.Controls.Add(btnLSMuaHang);
            groupBox1.Controls.Add(btnXoaKH);
            groupBox1.Controls.Add(btnSuaKH);
            groupBox1.Controls.Add(btnThemKH);
            groupBox1.Controls.Add(dgvQLyKH);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(798, 438);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "QUẢN LÍ KHÁCH HÀNG";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Left;
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label21.ForeColor = Color.FromArgb(4, 51, 94);
            label21.Location = new Point(6, 157);
            label21.Name = "label21";
            label21.Size = new Size(134, 22);
            label21.TabIndex = 13;
            label21.Text = "Số điện thoại:";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label15.ForeColor = Color.FromArgb(4, 51, 94);
            label15.Location = new Point(12, 112);
            label15.Name = "label15";
            label15.Size = new Size(65, 22);
            label15.TabIndex = 12;
            label15.Text = "Email:";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Left;
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label17.ForeColor = Color.FromArgb(4, 51, 94);
            label17.Location = new Point(9, 70);
            label17.Name = "label17";
            label17.Size = new Size(160, 22);
            label17.TabIndex = 11;
            label17.Text = "Tên khách hàng:";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Left;
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label16.ForeColor = Color.FromArgb(4, 51, 94);
            label16.Location = new Point(12, 26);
            label16.Name = "label16";
            label16.Size = new Size(151, 22);
            label16.TabIndex = 10;
            label16.Text = "Mã khách hàng:";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(255, 152);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(125, 27);
            txtSDT.TabIndex = 9;
            txtSDT.TextChanged += txtSDT_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(255, 107);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 8;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(255, 65);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(125, 27);
            txtTenKH.TabIndex = 7;
            txtTenKH.TextChanged += txtTenKH_TextChanged;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(255, 26);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(125, 27);
            txtMaKH.TabIndex = 6;
            txtMaKH.TextChanged += txtMaKH_TextChanged;
            // 
            // btnTaiLaiKH
            // 
            btnTaiLaiKH.Location = new Point(672, 166);
            btnTaiLaiKH.Name = "btnTaiLaiKH";
            btnTaiLaiKH.Size = new Size(94, 29);
            btnTaiLaiKH.TabIndex = 5;
            btnTaiLaiKH.Text = "CẬP NHẬT";
            btnTaiLaiKH.UseVisualStyleBackColor = true;
            btnTaiLaiKH.Click += btnTaiLaiKH_Click;
            // 
            // btnLSMuaHang
            // 
            btnLSMuaHang.Location = new Point(620, 131);
            btnLSMuaHang.Name = "btnLSMuaHang";
            btnLSMuaHang.Size = new Size(146, 29);
            btnLSMuaHang.TabIndex = 4;
            btnLSMuaHang.Text = "LỊCH SỬ MUA";
            btnLSMuaHang.UseVisualStyleBackColor = true;
            btnLSMuaHang.Click += btnLSMuaHang_Click;
            // 
            // btnXoaKH
            // 
            btnXoaKH.Location = new Point(672, 96);
            btnXoaKH.Name = "btnXoaKH";
            btnXoaKH.Size = new Size(94, 29);
            btnXoaKH.TabIndex = 3;
            btnXoaKH.Text = "XÓA";
            btnXoaKH.UseVisualStyleBackColor = true;
            btnXoaKH.Click += btnXoaKH_Click;
            // 
            // btnSuaKH
            // 
            btnSuaKH.Location = new Point(672, 61);
            btnSuaKH.Name = "btnSuaKH";
            btnSuaKH.Size = new Size(94, 29);
            btnSuaKH.TabIndex = 2;
            btnSuaKH.Text = "SỬA";
            btnSuaKH.UseVisualStyleBackColor = true;
            btnSuaKH.Click += btnSuaKH_Click;
            // 
            // btnThemKH
            // 
            btnThemKH.Location = new Point(672, 26);
            btnThemKH.Name = "btnThemKH";
            btnThemKH.Size = new Size(94, 29);
            btnThemKH.TabIndex = 1;
            btnThemKH.Text = "THÊM";
            btnThemKH.UseVisualStyleBackColor = true;
            btnThemKH.Click += btnThemKH_Click;
            // 
            // dgvQLyKH
            // 
            dgvQLyKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLyKH.Location = new Point(0, 225);
            dgvQLyKH.Name = "dgvQLyKH";
            dgvQLyKH.RowHeadersWidth = 51;
            dgvQLyKH.Size = new Size(798, 223);
            dgvQLyKH.TabIndex = 0;
            dgvQLyKH.CellContentClick += dgvQLyKH_CellContentClick;
            // 
            // FormQLKH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FormQLKH";
            Text = "FormQLKH";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLyKH).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvQLyKH;
        private Button btnTaiLaiKH;
        private Button btnLSMuaHang;
        private Button btnXoaKH;
        private Button btnSuaKH;
        private Button btnThemKH;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private TextBox txtTenKH;
        private TextBox txtMaKH;
        private Label label16;
        private Label label17;
        private Label label15;
        private Label label21;
        private Button button1;
    }
}