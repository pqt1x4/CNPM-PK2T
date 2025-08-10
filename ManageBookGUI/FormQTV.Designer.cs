namespace ManageBookGUI
{
    partial class FormQTV
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQTV));
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            TenSach = new DataGridViewTextBoxColumn();
            btnThemSach = new Button();
            imageListBook = new ImageList(components);
            btnXoaSach = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnTaiLaiSach = new Button();
            label6 = new Label();
            label9 = new Label();
            txtSoLuong = new TextBox();
            label5 = new Label();
            txtTacGia = new TextBox();
            label2 = new Label();
            txtTenSach = new TextBox();
            label1 = new Label();
            txtMaSach = new TextBox();
            label10 = new Label();
            txtMaNV = new TextBox();
            label4 = new Label();
            cboTheLoai = new ComboBox();
            label3 = new Label();
            dateTimePickerNXB = new DateTimePicker();
            txtGiaBan = new TextBox();
            btnXemDoanhThu = new Button();
            btnSuaSach = new Button();
            groupBox = new GroupBox();
            label11 = new Label();
            GiaBan = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            TheLoai = new DataGridViewTextBoxColumn();
            NXB = new DataGridViewTextBoxColumn();
            labelBackHome = new Label();
            pictureBox1 = new PictureBox();
            btnTimKiemSach = new Button();
            labelAdmin = new Label();
            txtTimKiemSach = new TextBox();
            label8 = new Label();
            TacGia = new DataGridViewTextBoxColumn();
            MaSach = new DataGridViewTextBoxColumn();
            txtTimKHTheoTen = new TextBox();
            pictureBoxNV = new PictureBox();
            tabControlQLySach = new TabControl();
            tabPageQLyKH = new TabPage();
            groupBox4 = new GroupBox();
            dgvQLyKH = new DataGridView();
            MaKH = new DataGridViewTextBoxColumn();
            TenKH = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            SDT = new DataGridViewTextBoxColumn();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtMaKH = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label21 = new Label();
            btnXoaKH = new Button();
            btnSuaKH = new Button();
            btnThemKH = new Button();
            txtTenKH = new TextBox();
            btnTaiLaiKH = new Button();
            label12 = new Label();
            label17 = new Label();
            btnLSMuaHang = new Button();
            tabPageQLySach = new TabPage();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            dgvQLSach = new DataGridView();
            tabPage1 = new TabPage();
            groupBox3 = new GroupBox();
            button3 = new Button();
            btnTaiLaiNV = new Button();
            btnXoaNV = new Button();
            btnThemNV = new Button();
            dgvQLyNV = new DataGridView();
            groupBox2 = new GroupBox();
            txtEmai = new TextBox();
            label7 = new Label();
            txtPhai = new TextBox();
            label13 = new Label();
            btnTaiLaiKH1 = new Button();
            button5 = new Button();
            textBox2 = new TextBox();
            label14 = new Label();
            txtDiaChi = new TextBox();
            label18 = new Label();
            txtNgSinh = new TextBox();
            label19 = new Label();
            txtTenNV = new TextBox();
            label20 = new Label();
            textBox3 = new TextBox();
            label22 = new Label();
            pictureBox2 = new PictureBox();
            lblTenNhanVien = new Label();
            statusStrip.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNV).BeginInit();
            tabControlQLySach.SuspendLayout();
            tabPageQLyKH.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLyKH).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tabPageQLySach.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLSach).BeginInit();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLyNV).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 671);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 19, 0);
            statusStrip.Size = new Size(1681, 26);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(49, 20);
            toolStripStatusLabel.Text = "Status";
            // 
            // TenSach
            // 
            TenSach.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            TenSach.DataPropertyName = "TenSach";
            TenSach.FillWeight = 128.342224F;
            TenSach.Frozen = true;
            TenSach.HeaderText = "Tên sách";
            TenSach.MinimumWidth = 6;
            TenSach.Name = "TenSach";
            TenSach.ReadOnly = true;
            TenSach.Width = 228;
            // 
            // btnThemSach
            // 
            btnThemSach.Anchor = AnchorStyles.Bottom;
            btnThemSach.BackColor = Color.White;
            btnThemSach.BackgroundImageLayout = ImageLayout.Stretch;
            btnThemSach.Font = new Font("Microsoft Sans Serif", 10.8F);
            btnThemSach.ForeColor = SystemColors.ActiveCaptionText;
            btnThemSach.ImageIndex = 4;
            btnThemSach.ImageList = imageListBook;
            btnThemSach.Location = new Point(695, 289);
            btnThemSach.Name = "btnThemSach";
            btnThemSach.Size = new Size(95, 42);
            btnThemSach.TabIndex = 34;
            btnThemSach.Text = "Thêm";
            btnThemSach.TextAlign = ContentAlignment.MiddleRight;
            btnThemSach.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThemSach.UseVisualStyleBackColor = false;
            btnThemSach.Click += btnThemSach_Click;
            // 
            // imageListBook
            // 
            imageListBook.ColorDepth = ColorDepth.Depth32Bit;
            imageListBook.ImageStream = (ImageListStreamer)resources.GetObject("imageListBook.ImageStream");
            imageListBook.TransparentColor = Color.Transparent;
            imageListBook.Images.SetKeyName(0, "books.jpg");
            imageListBook.Images.SetKeyName(1, "customer.png");
            imageListBook.Images.SetKeyName(2, "Recycle-Bin.png");
            imageListBook.Images.SetKeyName(3, "fix.png");
            imageListBook.Images.SetKeyName(4, "add.jpg");
            // 
            // btnXoaSach
            // 
            btnXoaSach.Anchor = AnchorStyles.Bottom;
            btnXoaSach.BackColor = Color.White;
            btnXoaSach.Font = new Font("Microsoft Sans Serif", 10.8F);
            btnXoaSach.ForeColor = SystemColors.ControlText;
            btnXoaSach.ImageIndex = 2;
            btnXoaSach.ImageList = imageListBook;
            btnXoaSach.Location = new Point(1152, 289);
            btnXoaSach.Name = "btnXoaSach";
            btnXoaSach.Size = new Size(102, 42);
            btnXoaSach.TabIndex = 36;
            btnXoaSach.Text = "Xóa";
            btnXoaSach.TextAlign = ContentAlignment.MiddleRight;
            btnXoaSach.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoaSach.UseVisualStyleBackColor = false;
            btnXoaSach.Click += btnXoaSach_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.WhiteSmoke;
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.9242425F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.69697F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.136364F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.9545455F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.469697F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.564743F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.51676F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Controls.Add(btnThemSach, 3, 7);
            tableLayoutPanel1.Controls.Add(btnXoaSach, 5, 7);
            tableLayoutPanel1.Controls.Add(btnTaiLaiSach, 6, 7);
            tableLayoutPanel1.Controls.Add(label6, 1, 5);
            tableLayoutPanel1.Controls.Add(label9, 1, 4);
            tableLayoutPanel1.Controls.Add(txtSoLuong, 2, 4);
            tableLayoutPanel1.Controls.Add(label5, 1, 3);
            tableLayoutPanel1.Controls.Add(txtTacGia, 2, 3);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(txtTenSach, 2, 2);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(txtMaSach, 2, 1);
            tableLayoutPanel1.Controls.Add(label10, 4, 3);
            tableLayoutPanel1.Controls.Add(txtMaNV, 5, 3);
            tableLayoutPanel1.Controls.Add(label4, 4, 2);
            tableLayoutPanel1.Controls.Add(cboTheLoai, 5, 2);
            tableLayoutPanel1.Controls.Add(label3, 4, 1);
            tableLayoutPanel1.Controls.Add(dateTimePickerNXB, 5, 1);
            tableLayoutPanel1.Controls.Add(txtGiaBan, 2, 5);
            tableLayoutPanel1.Controls.Add(btnXemDoanhThu, 7, 7);
            tableLayoutPanel1.Controls.Add(btnSuaSach, 4, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.68841743F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.809135F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.298003F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.14439344F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.19902134F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.36215353F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.38336039F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.4404564F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3.99361014F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 39.9361038F));
            tableLayoutPanel1.Size = new Size(1661, 600);
            tableLayoutPanel1.TabIndex = 27;
            // 
            // btnTaiLaiSach
            // 
            btnTaiLaiSach.Anchor = AnchorStyles.Bottom;
            btnTaiLaiSach.BackgroundImage = (Image)resources.GetObject("btnTaiLaiSach.BackgroundImage");
            btnTaiLaiSach.BackgroundImageLayout = ImageLayout.Stretch;
            btnTaiLaiSach.Location = new Point(1380, 289);
            btnTaiLaiSach.Name = "btnTaiLaiSach";
            btnTaiLaiSach.Size = new Size(47, 42);
            btnTaiLaiSach.TabIndex = 21;
            btnTaiLaiSach.UseVisualStyleBackColor = true;
            btnTaiLaiSach.Click += btnTaiLaiSach_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(4, 51, 94);
            label6.Location = new Point(84, 208);
            label6.Name = "label6";
            label6.Size = new Size(94, 25);
            label6.TabIndex = 5;
            label6.Text = "Giá bán:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(4, 51, 94);
            label9.Location = new Point(84, 167);
            label9.Name = "label9";
            label9.Size = new Size(122, 33);
            label9.TabIndex = 20;
            label9.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Anchor = AnchorStyles.Left;
            txtSoLuong.Font = new Font("Segoe UI", 12F);
            txtSoLuong.Location = new Point(245, 168);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(339, 34);
            txtSoLuong.TabIndex = 22;
            txtSoLuong.KeyPress += txtSoLuong_KeyPress;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(4, 51, 94);
            label5.Location = new Point(84, 134);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 4;
            label5.Text = "Tác giả:";
            // 
            // txtTacGia
            // 
            txtTacGia.Anchor = AnchorStyles.Left;
            txtTacGia.Font = new Font("Segoe UI", 12F);
            txtTacGia.Location = new Point(245, 132);
            txtTacGia.Name = "txtTacGia";
            txtTacGia.Size = new Size(339, 34);
            txtTacGia.TabIndex = 11;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(4, 51, 94);
            label2.Location = new Point(84, 98);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên sách:";
            // 
            // txtTenSach
            // 
            txtTenSach.Anchor = AnchorStyles.Left;
            txtTenSach.Font = new Font("Segoe UI", 12F);
            txtTenSach.Location = new Point(245, 95);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(339, 34);
            txtTenSach.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(4, 51, 94);
            label1.Location = new Point(84, 53);
            label1.Name = "label1";
            label1.Size = new Size(122, 39);
            label1.TabIndex = 0;
            label1.Text = "Mã sách:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMaSach
            // 
            txtMaSach.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtMaSach.Enabled = false;
            txtMaSach.Font = new Font("Segoe UI", 12F);
            txtMaSach.Location = new Point(245, 55);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(339, 34);
            txtMaSach.TabIndex = 9;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(4, 51, 94);
            label10.Location = new Point(812, 134);
            label10.Name = "label10";
            label10.Size = new Size(85, 25);
            label10.TabIndex = 24;
            label10.Text = "Mã NV:";
            // 
            // txtMaNV
            // 
            txtMaNV.Anchor = AnchorStyles.Left;
            txtMaNV.Font = new Font("Segoe UI", 12F);
            txtMaNV.Location = new Point(1052, 132);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(237, 34);
            txtMaNV.TabIndex = 23;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(4, 51, 94);
            label4.Location = new Point(812, 98);
            label4.Name = "label4";
            label4.Size = new Size(234, 25);
            label4.TabIndex = 3;
            label4.Text = "Thể loại:";
            // 
            // cboTheLoai
            // 
            cboTheLoai.Anchor = AnchorStyles.Left;
            cboTheLoai.FormattingEnabled = true;
            cboTheLoai.Location = new Point(1052, 96);
            cboTheLoai.Name = "cboTheLoai";
            cboTheLoai.Size = new Size(237, 30);
            cboTheLoai.TabIndex = 25;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(4, 51, 94);
            label3.Location = new Point(812, 67);
            label3.Name = "label3";
            label3.Size = new Size(158, 25);
            label3.TabIndex = 2;
            label3.Text = "Ngày xuất bản:";
            // 
            // dateTimePickerNXB
            // 
            dateTimePickerNXB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dateTimePickerNXB.Font = new Font("Segoe UI", 12F);
            dateTimePickerNXB.Location = new Point(1052, 55);
            dateTimePickerNXB.Name = "dateTimePickerNXB";
            dateTimePickerNXB.Size = new Size(237, 34);
            dateTimePickerNXB.TabIndex = 18;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Anchor = AnchorStyles.Left;
            txtGiaBan.Font = new Font("Segoe UI", 12F);
            txtGiaBan.Location = new Point(245, 205);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(339, 34);
            txtGiaBan.TabIndex = 7;
            txtGiaBan.KeyPress += txtGiaBan_KeyPress;
            // 
            // btnXemDoanhThu
            // 
            btnXemDoanhThu.Anchor = AnchorStyles.Bottom;
            btnXemDoanhThu.Location = new Point(1473, 289);
            btnXemDoanhThu.Name = "btnXemDoanhThu";
            btnXemDoanhThu.Size = new Size(163, 42);
            btnXemDoanhThu.TabIndex = 37;
            btnXemDoanhThu.Text = "Xem doanh thu";
            btnXemDoanhThu.UseVisualStyleBackColor = true;
            btnXemDoanhThu.Click += btnXemDoanhThu_Click;
            // 
            // btnSuaSach
            // 
            btnSuaSach.Anchor = AnchorStyles.Bottom;
            btnSuaSach.BackColor = Color.White;
            btnSuaSach.Font = new Font("Microsoft Sans Serif", 10.8F);
            btnSuaSach.ForeColor = SystemColors.ControlText;
            btnSuaSach.ImageIndex = 3;
            btnSuaSach.ImageList = imageListBook;
            btnSuaSach.Location = new Point(874, 289);
            btnSuaSach.Name = "btnSuaSach";
            btnSuaSach.RightToLeft = RightToLeft.No;
            btnSuaSach.Size = new Size(110, 42);
            btnSuaSach.TabIndex = 35;
            btnSuaSach.Text = "Sửa";
            btnSuaSach.TextAlign = ContentAlignment.MiddleRight;
            btnSuaSach.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSuaSach.UseVisualStyleBackColor = false;
            btnSuaSach.Click += btnSuaSach_Click;
            // 
            // groupBox
            // 
            groupBox.BackColor = Color.Transparent;
            groupBox.Controls.Add(tableLayoutPanel1);
            groupBox.Controls.Add(label11);
            groupBox.Dock = DockStyle.Fill;
            groupBox.Font = new Font("Microsoft Sans Serif", 10.8F);
            groupBox.ForeColor = Color.Black;
            groupBox.Location = new Point(3, 3);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(1667, 627);
            groupBox.TabIndex = 37;
            groupBox.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 69);
            label11.Name = "label11";
            label11.Size = new Size(129, 22);
            label11.TabIndex = 26;
            label11.Text = "Thông tin sách";
            // 
            // GiaBan
            // 
            GiaBan.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            GiaBan.DataPropertyName = "GiaBan";
            GiaBan.FillWeight = 98.12461F;
            GiaBan.Frozen = true;
            GiaBan.HeaderText = "Giá bán";
            GiaBan.MinimumWidth = 6;
            GiaBan.Name = "GiaBan";
            GiaBan.ReadOnly = true;
            GiaBan.Width = 174;
            // 
            // SoLuong
            // 
            SoLuong.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.Frozen = true;
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            SoLuong.Width = 177;
            // 
            // TheLoai
            // 
            TheLoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            TheLoai.DataPropertyName = "TheLoai";
            TheLoai.FillWeight = 98.12461F;
            TheLoai.Frozen = true;
            TheLoai.HeaderText = "Thể loại";
            TheLoai.MinimumWidth = 6;
            TheLoai.Name = "TheLoai";
            TheLoai.ReadOnly = true;
            TheLoai.Width = 174;
            // 
            // NXB
            // 
            NXB.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            NXB.DataPropertyName = "NXB";
            NXB.FillWeight = 98.12461F;
            NXB.Frozen = true;
            NXB.HeaderText = "Ngày xuất bản";
            NXB.MinimumWidth = 6;
            NXB.Name = "NXB";
            NXB.ReadOnly = true;
            NXB.Width = 174;
            // 
            // labelBackHome
            // 
            labelBackHome.AutoSize = true;
            labelBackHome.Font = new Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelBackHome.ForeColor = SystemColors.ControlLightLight;
            labelBackHome.Location = new Point(58, 13);
            labelBackHome.Name = "labelBackHome";
            labelBackHome.Size = new Size(258, 29);
            labelBackHome.TabIndex = 61;
            labelBackHome.Text = "11PM BOOKSTORE";
            labelBackHome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            // 
            // btnTimKiemSach
            // 
            btnTimKiemSach.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiemSach.BackColor = Color.FromArgb(192, 255, 192);
            btnTimKiemSach.BackgroundImage = (Image)resources.GetObject("btnTimKiemSach.BackgroundImage");
            btnTimKiemSach.BackgroundImageLayout = ImageLayout.Stretch;
            btnTimKiemSach.ForeColor = SystemColors.ControlText;
            btnTimKiemSach.Location = new Point(2945, 12);
            btnTimKiemSach.Name = "btnTimKiemSach";
            btnTimKiemSach.Size = new Size(33, 33);
            btnTimKiemSach.TabIndex = 31;
            btnTimKiemSach.UseVisualStyleBackColor = false;
            // 
            // labelAdmin
            // 
            labelAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelAdmin.AutoSize = true;
            labelAdmin.BackColor = Color.Transparent;
            labelAdmin.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelAdmin.ForeColor = SystemColors.ControlLightLight;
            labelAdmin.Location = new Point(3012, 41);
            labelAdmin.Name = "labelAdmin";
            labelAdmin.Size = new Size(46, 17);
            labelAdmin.TabIndex = 42;
            labelAdmin.Text = "TenNV";
            // 
            // txtTimKiemSach
            // 
            txtTimKiemSach.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimKiemSach.Location = new Point(2501, 11);
            txtTimKiemSach.Multiline = true;
            txtTimKiemSach.Name = "txtTimKiemSach";
            txtTimKiemSach.Size = new Size(477, 35);
            txtTimKiemSach.TabIndex = 30;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(1221, 8);
            label8.Name = "label8";
            label8.Size = new Size(334, 36);
            label8.TabIndex = 38;
            label8.Text = "Quản lý thông tin sách";
            // 
            // TacGia
            // 
            TacGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            TacGia.DataPropertyName = "TacGia";
            TacGia.FillWeight = 98.12461F;
            TacGia.Frozen = true;
            TacGia.HeaderText = "Tác giả";
            TacGia.MinimumWidth = 6;
            TacGia.Name = "TacGia";
            TacGia.ReadOnly = true;
            TacGia.Width = 174;
            // 
            // MaSach
            // 
            MaSach.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MaSach.DataPropertyName = "MaSach";
            MaSach.FillWeight = 82.90998F;
            MaSach.Frozen = true;
            MaSach.HeaderText = "Mã sách";
            MaSach.MinimumWidth = 6;
            MaSach.Name = "MaSach";
            MaSach.ReadOnly = true;
            MaSach.Width = 147;
            // 
            // txtTimKHTheoTen
            // 
            txtTimKHTheoTen.Location = new Point(0, 0);
            txtTimKHTheoTen.Name = "txtTimKHTheoTen";
            txtTimKHTheoTen.Size = new Size(100, 27);
            txtTimKHTheoTen.TabIndex = 35;
            // 
            // pictureBoxNV
            // 
            pictureBoxNV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxNV.BackColor = Color.Transparent;
            pictureBoxNV.Image = (Image)resources.GetObject("pictureBoxNV.Image");
            pictureBoxNV.Location = new Point(3026, 3);
            pictureBoxNV.Name = "pictureBoxNV";
            pictureBoxNV.Size = new Size(38, 35);
            pictureBoxNV.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxNV.TabIndex = 40;
            pictureBoxNV.TabStop = false;
            // 
            // tabControlQLySach
            // 
            tabControlQLySach.Controls.Add(tabPageQLyKH);
            tabControlQLySach.Controls.Add(tabPageQLySach);
            tabControlQLySach.Controls.Add(tabPage1);
            tabControlQLySach.Dock = DockStyle.Fill;
            tabControlQLySach.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tabControlQLySach.ImageList = imageListBook;
            tabControlQLySach.Location = new Point(0, 0);
            tabControlQLySach.Name = "tabControlQLySach";
            tabControlQLySach.SelectedIndex = 0;
            tabControlQLySach.Size = new Size(1681, 671);
            tabControlQLySach.TabIndex = 37;
            // 
            // tabPageQLyKH
            // 
            tabPageQLyKH.BackColor = Color.LightCyan;
            tabPageQLyKH.Controls.Add(groupBox4);
            tabPageQLyKH.Controls.Add(tableLayoutPanel2);
            tabPageQLyKH.ForeColor = Color.FromArgb(224, 224, 224);
            tabPageQLyKH.ImageIndex = 1;
            tabPageQLyKH.Location = new Point(4, 34);
            tabPageQLyKH.Name = "tabPageQLyKH";
            tabPageQLyKH.Padding = new Padding(3);
            tabPageQLyKH.Size = new Size(1673, 633);
            tabPageQLyKH.TabIndex = 1;
            tabPageQLyKH.Text = "Quản lý khách hàng";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.WhiteSmoke;
            groupBox4.Controls.Add(dgvQLyKH);
            groupBox4.Controls.Add(flowLayoutPanel1);
            groupBox4.Dock = DockStyle.Left;
            groupBox4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.FromArgb(4, 51, 94);
            groupBox4.Location = new Point(3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(724, 627);
            groupBox4.TabIndex = 51;
            groupBox4.TabStop = false;
            groupBox4.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // dgvQLyKH
            // 
            dgvQLyKH.AllowUserToAddRows = false;
            dgvQLyKH.AllowUserToDeleteRows = false;
            dgvQLyKH.BackgroundColor = Color.White;
            dgvQLyKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLyKH.Columns.AddRange(new DataGridViewColumn[] { MaKH, TenKH, Email, SDT });
            dgvQLyKH.Dock = DockStyle.Fill;
            dgvQLyKH.Location = new Point(3, 24);
            dgvQLyKH.Name = "dgvQLyKH";
            dgvQLyKH.ReadOnly = true;
            dgvQLyKH.RowHeadersWidth = 51;
            dgvQLyKH.Size = new Size(718, 600);
            dgvQLyKH.TabIndex = 14;
            dgvQLyKH.CellClick += dgvQLyKH_CellClick;
            dgvQLyKH.CellContentClick += dgvQLyKH_CellContentClick;
            // 
            // MaKH
            // 
            MaKH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaKH.DataPropertyName = "MaKH";
            MaKH.FillWeight = 82.90998F;
            MaKH.HeaderText = "Mã khách hàng";
            MaKH.MinimumWidth = 6;
            MaKH.Name = "MaKH";
            MaKH.ReadOnly = true;
            // 
            // TenKH
            // 
            TenKH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenKH.DataPropertyName = "TenKH";
            TenKH.FillWeight = 128.342224F;
            TenKH.HeaderText = "Tên khách hàng";
            TenKH.MinimumWidth = 6;
            TenKH.Name = "TenKH";
            TenKH.ReadOnly = true;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // SDT
            // 
            SDT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SDT.DataPropertyName = "SDT";
            SDT.HeaderText = "Số điện thoại";
            SDT.MinimumWidth = 6;
            SDT.Name = "SDT";
            SDT.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 24);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(718, 600);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.WhiteSmoke;
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.9475651F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.0935249F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.9713421F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.0769234F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.898944F));
            tableLayoutPanel2.Controls.Add(txtMaKH, 3, 1);
            tableLayoutPanel2.Controls.Add(txtEmail, 3, 3);
            tableLayoutPanel2.Controls.Add(txtSDT, 3, 4);
            tableLayoutPanel2.Controls.Add(label16, 2, 1);
            tableLayoutPanel2.Controls.Add(label15, 2, 3);
            tableLayoutPanel2.Controls.Add(label21, 2, 4);
            tableLayoutPanel2.Controls.Add(btnXoaKH, 4, 6);
            tableLayoutPanel2.Controls.Add(btnSuaKH, 3, 6);
            tableLayoutPanel2.Controls.Add(btnThemKH, 2, 6);
            tableLayoutPanel2.Controls.Add(txtTenKH, 3, 2);
            tableLayoutPanel2.Controls.Add(btnTaiLaiKH, 4, 7);
            tableLayoutPanel2.Controls.Add(label12, 3, 0);
            tableLayoutPanel2.Controls.Add(label17, 2, 2);
            tableLayoutPanel2.Controls.Add(btnLSMuaHang, 3, 7);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 9;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 19.7986584F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.214765F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.214765F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.543624F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.38255024F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9127522F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.90604F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.7718124F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.8899374F));
            tableLayoutPanel2.Size = new Size(1667, 627);
            tableLayoutPanel2.TabIndex = 56;
            // 
            // txtMaKH
            // 
            txtMaKH.Anchor = AnchorStyles.Left;
            txtMaKH.Enabled = false;
            txtMaKH.Font = new Font("Segoe UI", 12F);
            txtMaKH.Location = new Point(1135, 129);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(268, 34);
            txtMaKH.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(1135, 217);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(378, 34);
            txtEmail.TabIndex = 13;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // txtSDT
            // 
            txtSDT.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSDT.Font = new Font("Segoe UI", 12F);
            txtSDT.Location = new Point(1135, 261);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(378, 34);
            txtSDT.TabIndex = 8;
            txtSDT.KeyPress += txtSDT_KeyPress;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Left;
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label16.ForeColor = Color.FromArgb(4, 51, 94);
            label16.Location = new Point(919, 135);
            label16.Name = "label16";
            label16.Size = new Size(151, 22);
            label16.TabIndex = 0;
            label16.Text = "Mã khách hàng:";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label15.ForeColor = Color.FromArgb(4, 51, 94);
            label15.Location = new Point(919, 223);
            label15.Name = "label15";
            label15.Size = new Size(65, 22);
            label15.TabIndex = 3;
            label15.Text = "Email:";
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Left;
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label21.ForeColor = Color.FromArgb(4, 51, 94);
            label21.Location = new Point(919, 267);
            label21.Name = "label21";
            label21.Size = new Size(134, 22);
            label21.TabIndex = 6;
            label21.Text = "Số điện thoại:";
            // 
            // btnXoaKH
            // 
            btnXoaKH.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnXoaKH.BackColor = Color.White;
            btnXoaKH.Font = new Font("Microsoft Sans Serif", 10.8F);
            btnXoaKH.ForeColor = SystemColors.ControlText;
            btnXoaKH.ImageIndex = 2;
            btnXoaKH.ImageList = imageListBook;
            btnXoaKH.Location = new Point(1519, 388);
            btnXoaKH.Name = "btnXoaKH";
            btnXoaKH.Size = new Size(113, 52);
            btnXoaKH.TabIndex = 46;
            btnXoaKH.Text = "Xóa";
            btnXoaKH.TextAlign = ContentAlignment.MiddleRight;
            btnXoaKH.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoaKH.UseVisualStyleBackColor = false;
            btnXoaKH.Click += btnXoaKH_Click;
            // 
            // btnSuaKH
            // 
            btnSuaKH.Anchor = AnchorStyles.Bottom;
            btnSuaKH.BackColor = Color.White;
            btnSuaKH.Font = new Font("Microsoft Sans Serif", 10.8F);
            btnSuaKH.ForeColor = SystemColors.ControlText;
            btnSuaKH.ImageIndex = 3;
            btnSuaKH.ImageList = imageListBook;
            btnSuaKH.Location = new Point(1263, 388);
            btnSuaKH.Name = "btnSuaKH";
            btnSuaKH.Size = new Size(122, 52);
            btnSuaKH.TabIndex = 45;
            btnSuaKH.Text = "Sửa";
            btnSuaKH.TextAlign = ContentAlignment.MiddleRight;
            btnSuaKH.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSuaKH.UseVisualStyleBackColor = false;
            btnSuaKH.Click += btnSuaKH_Click;
            // 
            // btnThemKH
            // 
            btnThemKH.Anchor = AnchorStyles.Bottom;
            btnThemKH.BackColor = Color.White;
            btnThemKH.BackgroundImageLayout = ImageLayout.Stretch;
            btnThemKH.Font = new Font("Microsoft Sans Serif", 10.8F);
            btnThemKH.ForeColor = SystemColors.ActiveCaptionText;
            btnThemKH.ImageIndex = 4;
            btnThemKH.ImageList = imageListBook;
            btnThemKH.Location = new Point(968, 388);
            btnThemKH.Name = "btnThemKH";
            btnThemKH.Size = new Size(112, 52);
            btnThemKH.TabIndex = 44;
            btnThemKH.Text = "Thêm";
            btnThemKH.TextAlign = ContentAlignment.MiddleRight;
            btnThemKH.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThemKH.UseVisualStyleBackColor = false;
            btnThemKH.Click += btnThemKH_Click;
            // 
            // txtTenKH
            // 
            txtTenKH.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTenKH.Font = new Font("Segoe UI", 12F);
            txtTenKH.Location = new Point(1135, 174);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(378, 34);
            txtTenKH.TabIndex = 10;
            // 
            // btnTaiLaiKH
            // 
            btnTaiLaiKH.Anchor = AnchorStyles.Bottom;
            btnTaiLaiKH.BackgroundImage = (Image)resources.GetObject("btnTaiLaiKH.BackgroundImage");
            btnTaiLaiKH.BackgroundImageLayout = ImageLayout.Stretch;
            btnTaiLaiKH.Location = new Point(1564, 497);
            btnTaiLaiKH.Name = "btnTaiLaiKH";
            btnTaiLaiKH.Size = new Size(54, 42);
            btnTaiLaiKH.TabIndex = 21;
            btnTaiLaiKH.UseVisualStyleBackColor = true;
            btnTaiLaiKH.Click += btnTaiLaiKH_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(4, 51, 94);
            label12.Location = new Point(1135, 102);
            label12.Name = "label12";
            label12.Size = new Size(378, 22);
            label12.TabIndex = 48;
            label12.Text = "THÔNG TIN KHÁCH HÀNG";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Left;
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label17.ForeColor = Color.FromArgb(4, 51, 94);
            label17.Location = new Point(919, 180);
            label17.Name = "label17";
            label17.Size = new Size(160, 22);
            label17.TabIndex = 1;
            label17.Text = "Tên khách hàng:";
            // 
            // btnLSMuaHang
            // 
            btnLSMuaHang.Anchor = AnchorStyles.Bottom;
            btnLSMuaHang.BackColor = Color.FromArgb(4, 51, 94);
            btnLSMuaHang.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLSMuaHang.ForeColor = SystemColors.ButtonHighlight;
            btnLSMuaHang.Location = new Point(1196, 488);
            btnLSMuaHang.Name = "btnLSMuaHang";
            btnLSMuaHang.Size = new Size(255, 51);
            btnLSMuaHang.TabIndex = 47;
            btnLSMuaHang.Text = "Lịch sử mua hàng";
            btnLSMuaHang.UseVisualStyleBackColor = false;
            btnLSMuaHang.Click += btnLSMuaHang_Click;
            // 
            // tabPageQLySach
            // 
            tabPageQLySach.BackColor = Color.WhiteSmoke;
            tabPageQLySach.Controls.Add(panel1);
            tabPageQLySach.Controls.Add(groupBox1);
            tabPageQLySach.Controls.Add(groupBox);
            tabPageQLySach.ImageIndex = 0;
            tabPageQLySach.Location = new Point(4, 34);
            tabPageQLySach.Name = "tabPageQLySach";
            tabPageQLySach.Padding = new Padding(3);
            tabPageQLySach.Size = new Size(1673, 633);
            tabPageQLySach.TabIndex = 0;
            tabPageQLySach.Text = "Quản lý sách";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(4, 51, 94);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(labelBackHome);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnTimKiemSach);
            panel1.Controls.Add(labelAdmin);
            panel1.Controls.Add(txtTimKiemSach);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBoxNV);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1667, 66);
            panel1.TabIndex = 43;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(dgvQLSach);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(4, 51, 94);
            groupBox1.Location = new Point(3, 339);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1667, 291);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh mục sách";
            // 
            // dgvQLSach
            // 
            dgvQLSach.AllowUserToAddRows = false;
            dgvQLSach.AllowUserToDeleteRows = false;
            dgvQLSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLSach.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvQLSach.BackgroundColor = Color.White;
            dgvQLSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLSach.Columns.AddRange(new DataGridViewColumn[] { MaSach, TenSach, TacGia, NXB, TheLoai, SoLuong, GiaBan });
            dgvQLSach.Dock = DockStyle.Bottom;
            dgvQLSach.Location = new Point(3, 30);
            dgvQLSach.Name = "dgvQLSach";
            dgvQLSach.ReadOnly = true;
            dgvQLSach.RowHeadersWidth = 51;
            dgvQLSach.Size = new Size(1661, 258);
            dgvQLSach.TabIndex = 15;
            dgvQLSach.CellClick += dgvQLSach_CellClick;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(dgvQLyNV);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1673, 633);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Quản lí nhân viên";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(btnTaiLaiNV);
            groupBox3.Controls.Add(btnXoaNV);
            groupBox3.Controls.Add(btnThemNV);
            groupBox3.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.FromArgb(4, 51, 94);
            groupBox3.Location = new Point(148, 95);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1122, 123);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "CHỨC NĂNG";
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
            button3.Click += button3_Click_1;
            // 
            // btnTaiLaiNV
            // 
            btnTaiLaiNV.BackColor = Color.FromArgb(4, 51, 94);
            btnTaiLaiNV.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold);
            btnTaiLaiNV.ForeColor = SystemColors.ButtonHighlight;
            btnTaiLaiNV.Location = new Point(608, 54);
            btnTaiLaiNV.Name = "btnTaiLaiNV";
            btnTaiLaiNV.RightToLeft = RightToLeft.No;
            btnTaiLaiNV.Size = new Size(181, 60);
            btnTaiLaiNV.TabIndex = 2;
            btnTaiLaiNV.Text = "CẬP NHẬT";
            btnTaiLaiNV.UseVisualStyleBackColor = false;
            btnTaiLaiNV.Click += btnTaiLaiNV_Click;
            // 
            // btnXoaNV
            // 
            btnXoaNV.BackColor = Color.FromArgb(4, 51, 94);
            btnXoaNV.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold);
            btnXoaNV.ForeColor = SystemColors.ButtonHighlight;
            btnXoaNV.Location = new Point(352, 54);
            btnXoaNV.Name = "btnXoaNV";
            btnXoaNV.RightToLeft = RightToLeft.No;
            btnXoaNV.Size = new Size(181, 60);
            btnXoaNV.TabIndex = 1;
            btnXoaNV.Text = "XÓA";
            btnXoaNV.UseVisualStyleBackColor = false;
            btnXoaNV.Click += btnXoaNV_Click;
            // 
            // btnThemNV
            // 
            btnThemNV.BackColor = Color.FromArgb(4, 51, 94);
            btnThemNV.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold);
            btnThemNV.ForeColor = SystemColors.ButtonHighlight;
            btnThemNV.Location = new Point(88, 54);
            btnThemNV.Name = "btnThemNV";
            btnThemNV.RightToLeft = RightToLeft.No;
            btnThemNV.Size = new Size(181, 60);
            btnThemNV.TabIndex = 0;
            btnThemNV.Text = "THÊM";
            btnThemNV.UseVisualStyleBackColor = false;
            btnThemNV.Click += btnThemNV_Click;
            // 
            // dgvQLyNV
            // 
            dgvQLyNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLyNV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvQLyNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLyNV.Location = new Point(20, 489);
            dgvQLyNV.Name = "dgvQLyNV";
            dgvQLyNV.RowHeadersWidth = 51;
            dgvQLyNV.Size = new Size(1381, 247);
            dgvQLyNV.TabIndex = 7;
            dgvQLyNV.CellClick += dgvQLyNV_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(4, 51, 94);
            groupBox2.Controls.Add(txtEmai);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtPhai);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(btnTaiLaiKH1);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(txtDiaChi);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(txtNgSinh);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(txtTenNV);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label22);
            groupBox2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(20, 224);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1381, 259);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "THÔNG TIN";
            // 
            // txtEmai
            // 
            txtEmai.Location = new Point(878, 148);
            txtEmai.Name = "txtEmai";
            txtEmai.Size = new Size(395, 38);
            txtEmai.TabIndex = 14;
            txtEmai.KeyPress += txtEmai_KeyPress;
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
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(40, 196);
            label13.Name = "label13";
            label13.Size = new Size(113, 25);
            label13.TabIndex = 11;
            label13.Text = "GIỚI TÍNH";
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
            button5.Click += button5_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(878, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(395, 38);
            textBox2.TabIndex = 9;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(689, 104);
            label14.Name = "label14";
            label14.Size = new Size(173, 25);
            label14.TabIndex = 8;
            label14.Text = "SỐ ĐIỆN THOẠI";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(878, 58);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(395, 38);
            txtDiaChi.TabIndex = 7;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = SystemColors.ButtonHighlight;
            label18.Location = new Point(689, 58);
            label18.Name = "label18";
            label18.Size = new Size(91, 25);
            label18.TabIndex = 6;
            label18.Text = "ĐỊA CHỈ";
            // 
            // txtNgSinh
            // 
            txtNgSinh.Location = new Point(229, 150);
            txtNgSinh.Name = "txtNgSinh";
            txtNgSinh.Size = new Size(395, 38);
            txtNgSinh.TabIndex = 5;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = SystemColors.ButtonHighlight;
            label19.Location = new Point(40, 150);
            label19.Name = "label19";
            label19.Size = new Size(129, 25);
            label19.TabIndex = 4;
            label19.Text = "NGÀY SINH";
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(229, 104);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(395, 38);
            txtTenNV.TabIndex = 3;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = SystemColors.ButtonHighlight;
            label20.Location = new Point(40, 104);
            label20.Name = "label20";
            label20.Size = new Size(177, 25);
            label20.TabIndex = 2;
            label20.Text = "TÊN NHÂN VIÊN";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(229, 58);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(395, 38);
            textBox3.TabIndex = 1;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = SystemColors.ButtonHighlight;
            label22.Location = new Point(40, 58);
            label22.Name = "label22";
            label22.Size = new Size(167, 25);
            label22.TabIndex = 0;
            label22.Text = "MÃ NHÂN VIÊN";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.FormPhanQuyen1;
            pictureBox2.Location = new Point(-4, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1428, 868);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // lblTenNhanVien
            // 
            lblTenNhanVien.Location = new Point(0, 0);
            lblTenNhanVien.Name = "lblTenNhanVien";
            lblTenNhanVien.Size = new Size(100, 23);
            lblTenNhanVien.TabIndex = 36;
            // 
            // FormQTV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1681, 697);
            Controls.Add(tabControlQLySach);
            Controls.Add(lblTenNhanVien);
            Controls.Add(statusStrip);
            Controls.Add(txtTimKHTheoTen);
            IsMdiContainer = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormQTV";
            Text = "FormQTV";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNV).EndInit();
            tabControlQLySach.ResumeLayout(false);
            tabPageQLyKH.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQLyKH).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tabPageQLySach.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQLSach).EndInit();
            tabPage1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQLyNV).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private DataGridViewTextBoxColumn TenSach;
        private Button btnThemSach;
        private ImageList imageListBook;
        private Button btnXoaSach;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnTaiLaiSach;
        private Label label6;
        private Label label9;
        private TextBox txtSoLuong;
        private Label label5;
        private TextBox txtTacGia;
        private Label label2;
        private TextBox txtTenSach;
        private Label label1;
        private TextBox txtMaSach;
        private Label label10;
        private TextBox txtMaNV;
        private Label label4;
        private ComboBox cboTheLoai;
        private Label label3;
        private DateTimePicker dateTimePickerNXB;
        private TextBox txtGiaBan;
        private Button btnXemDoanhThu;
        private Button btnSuaSach;
        private GroupBox groupBox;
        private Label label11;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn TheLoai;
        private DataGridViewTextBoxColumn NXB;
        private Label labelBackHome;
        private PictureBox pictureBox1;
        private Button btnTimKiemSach;
        private Label labelAdmin;
        private TextBox txtTimKiemSach;
        private Label label8;
        private DataGridViewTextBoxColumn TacGia;
        private DataGridViewTextBoxColumn MaSach;
        private TextBox txtTimKHTheoTen;
        private PictureBox pictureBoxNV;
        private TabControl tabControlQLySach;
        private TabPage tabPageQLyKH;
        private GroupBox groupBox4;
        private DataGridView dgvQLyKH;
        private DataGridViewTextBoxColumn MaKH;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn SDT;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtMaKH;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private Label label16;
        private Label label15;
        private Label label21;
        private Button btnXoaKH;
        private Button btnSuaKH;
        private Button btnThemKH;
        private TextBox txtTenKH;
        private Button btnTaiLaiKH;
        private Label label12;
        private Label label17;
        private Button btnLSMuaHang;
        private TabPage tabPageQLySach;
        private Panel panel1;
        private GroupBox groupBox1;
        private DataGridView dgvQLSach;
        private Label lblTenNhanVien;
        private TabPage tabPage1;
        private DataGridView dgvQLyNV;
        private GroupBox groupBox2;
        private TextBox txtEmai;
        private Label label7;
        private TextBox txtPhai;
        private Label label13;
        private Button btnTaiLaiKH1;
        private Button button5;
        private TextBox textBox2;
        private Label label14;
        private TextBox txtDiaChi;
        private Label label18;
        private TextBox txtNgSinh;
        private Label label19;
        private TextBox txtTenNV;
        private Label label20;
        private TextBox textBox3;
        private Label label22;
        private PictureBox pictureBox2;
        private GroupBox groupBox3;
        private Button button3;
        private Button btnTaiLaiNV;
        private Button btnXoaNV;
        private Button btnThemNV;
    }
}



