namespace ManageBookGUI
{
    partial class FormLichSuMuaHang
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
            txtTongTien=new TextBox();
            txtTenKH=new TextBox();
            txtEmail=new TextBox();
            txtSDT=new TextBox();
            txtMaKH=new TextBox();
            panel1=new Panel();
            label5=new Label();
            label4=new Label();
            label3=new Label();
            label2=new Label();
            label1=new Label();
            labelMaKH=new Label();
            dgvLichSu=new DataGridView();
            groupBox1=new GroupBox();
            label6=new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichSu).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTongTien
            // 
            txtTongTien.Anchor=AnchorStyles.Top|AnchorStyles.Bottom;
            txtTongTien.Enabled=false;
            txtTongTien.Font=new Font("Segoe UI Semibold",10.2F,FontStyle.Bold,GraphicsUnit.Point,163);
            txtTongTien.Location=new Point(875,206);
            txtTongTien.Name="txtTongTien";
            txtTongTien.Size=new Size(216,30);
            txtTongTien.TabIndex=23;
            // 
            // txtTenKH
            // 
            txtTenKH.Anchor=AnchorStyles.Top|AnchorStyles.Bottom;
            txtTenKH.Enabled=false;
            txtTenKH.Font=new Font("Segoe UI Semibold",10.2F,FontStyle.Bold);
            txtTenKH.Location=new Point(224,160);
            txtTenKH.Name="txtTenKH";
            txtTenKH.Size=new Size(310,30);
            txtTenKH.TabIndex=22;
            // 
            // txtEmail
            // 
            txtEmail.Anchor=AnchorStyles.Top|AnchorStyles.Bottom;
            txtEmail.Enabled=false;
            txtEmail.Font=new Font("Segoe UI Semibold",10.2F,FontStyle.Bold);
            txtEmail.Location=new Point(738,100);
            txtEmail.Name="txtEmail";
            txtEmail.Size=new Size(353,30);
            txtEmail.TabIndex=21;
            // 
            // txtSDT
            // 
            txtSDT.Anchor=AnchorStyles.Top|AnchorStyles.Bottom;
            txtSDT.Enabled=false;
            txtSDT.Font=new Font("Segoe UI Semibold",10.2F,FontStyle.Bold);
            txtSDT.Location=new Point(738,160);
            txtSDT.Name="txtSDT";
            txtSDT.Size=new Size(353,30);
            txtSDT.TabIndex=20;
            // 
            // txtMaKH
            // 
            txtMaKH.Anchor=AnchorStyles.Top|AnchorStyles.Bottom;
            txtMaKH.Enabled=false;
            txtMaKH.Font=new Font("Segoe UI Semibold",10.2F,FontStyle.Bold);
            txtMaKH.Location=new Point(224,100);
            txtMaKH.Name="txtMaKH";
            txtMaKH.Size=new Size(310,30);
            txtMaKH.TabIndex=19;
            // 
            // panel1
            // 
            panel1.BackColor=Color.FromArgb(4,51,94);
            panel1.Controls.Add(label5);
            panel1.Dock=DockStyle.Top;
            panel1.Location=new Point(0,0);
            panel1.Name="panel1";
            panel1.Size=new Size(1147,60);
            panel1.TabIndex=18;
            // 
            // label5
            // 
            label5.Anchor=AnchorStyles.Top;
            label5.AutoSize=true;
            label5.Font=new Font("Montserrat Black",16.2F,FontStyle.Bold,GraphicsUnit.Point,163);
            label5.ForeColor=SystemColors.ButtonHighlight;
            label5.Location=new Point(383,9);
            label5.Name="label5";
            label5.Size=new Size(316,39);
            label5.TabIndex=0;
            label5.Text="LỊCH SỬ MUA HÀNG";
            // 
            // label4
            // 
            label4.Anchor=AnchorStyles.Top|AnchorStyles.Bottom;
            label4.AutoSize=true;
            label4.Font=new Font("Montserrat",12F,FontStyle.Bold);
            label4.ForeColor=Color.FromArgb(4,51,94);
            label4.Location=new Point(738,205);
            label4.Name="label4";
            label4.Size=new Size(131,27);
            label4.TabIndex=17;
            label4.Text="TỔNG TIỀN:";
            // 
            // label3
            // 
            label3.Anchor=AnchorStyles.Top|AnchorStyles.Bottom;
            label3.AutoSize=true;
            label3.Font=new Font("Montserrat",12F,FontStyle.Bold);
            label3.ForeColor=Color.FromArgb(4,51,94);
            label3.Location=new Point(570,159);
            label3.Name="label3";
            label3.Size=new Size(156,27);
            label3.TabIndex=16;
            label3.Text="Số điện thoại:";
            // 
            // label2
            // 
            label2.Anchor=AnchorStyles.Top|AnchorStyles.Bottom;
            label2.AutoSize=true;
            label2.Font=new Font("Montserrat",12F,FontStyle.Bold);
            label2.ForeColor=Color.FromArgb(4,51,94);
            label2.Location=new Point(570,99);
            label2.Name="label2";
            label2.Size=new Size(75,27);
            label2.TabIndex=15;
            label2.Text="Email:";
            // 
            // label1
            // 
            label1.Anchor=AnchorStyles.Top|AnchorStyles.Bottom;
            label1.AutoSize=true;
            label1.Font=new Font("Montserrat",12F,FontStyle.Bold);
            label1.ForeColor=Color.FromArgb(4,51,94);
            label1.Location=new Point(39,159);
            label1.Name="label1";
            label1.Size=new Size(186,27);
            label1.TabIndex=14;
            label1.Text="Tên khách hàng:";
            // 
            // labelMaKH
            // 
            labelMaKH.Anchor=AnchorStyles.Top|AnchorStyles.Bottom;
            labelMaKH.AutoSize=true;
            labelMaKH.Font=new Font("Montserrat",12F,FontStyle.Bold);
            labelMaKH.ForeColor=Color.FromArgb(4,51,94);
            labelMaKH.Location=new Point(39,99);
            labelMaKH.Name="labelMaKH";
            labelMaKH.Size=new Size(179,27);
            labelMaKH.TabIndex=13;
            labelMaKH.Text="Mã khách hàng:";
            // 
            // dgvLichSu
            // 
            dgvLichSu.AllowUserToAddRows=false;
            dgvLichSu.AllowUserToDeleteRows=false;
            dgvLichSu.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
            dgvLichSu.BackgroundColor=Color.Gainsboro;
            dgvLichSu.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichSu.Location=new Point(24,46);
            dgvLichSu.Name="dgvLichSu";
            dgvLichSu.ReadOnly=true;
            dgvLichSu.RowHeadersWidth=51;
            dgvLichSu.Size=new Size(1095,232);
            dgvLichSu.TabIndex=12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvLichSu);
            groupBox1.Dock=DockStyle.Bottom;
            groupBox1.Font=new Font("Montserrat",12F,FontStyle.Bold,GraphicsUnit.Point,163);
            groupBox1.ForeColor=Color.FromArgb(4,51,94);
            groupBox1.Location=new Point(0,268);
            groupBox1.Name="groupBox1";
            groupBox1.Size=new Size(1147,308);
            groupBox1.TabIndex=24;
            groupBox1.TabStop=false;
            groupBox1.Text="LỊCH SỬ MUA HÀNG";
            // 
            // label6
            // 
            label6.Anchor=AnchorStyles.Top|AnchorStyles.Bottom;
            label6.AutoSize=true;
            label6.Font=new Font("Montserrat SemiBold",10.2F,FontStyle.Bold|FontStyle.Italic,GraphicsUnit.Point,163);
            label6.Location=new Point(975,239);
            label6.Name="label6";
            label6.Size=new Size(116,24);
            label6.TabIndex=25;
            label6.Text="Đơn vị: VNĐ";
            // 
            // FormLichSuMuaHang
            // 
            AutoScaleDimensions=new SizeF(8F,20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.WhiteSmoke;
            ClientSize=new Size(1147,576);
            Controls.Add(label6);
            Controls.Add(txtTongTien);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(txtTenKH);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtMaKH);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelMaKH);
            Name="FormLichSuMuaHang";
            Text="FormLichSuMuaHang";
            Load+=FormLichSuMuaHang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichSu).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTongTien;
        private TextBox txtTenKH;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtMaKH;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label labelMaKH;
        private DataGridView dgvLichSu;
        private Label label5;
        private GroupBox groupBox1;
        private Label label6;
    }
}