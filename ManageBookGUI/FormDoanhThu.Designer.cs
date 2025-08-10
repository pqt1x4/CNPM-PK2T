namespace ManageBookGUI
{
    partial class FormDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoanhThu));
            tableLayoutPanel1=new TableLayoutPanel();
            label1=new Label();
            label2=new Label();
            dtpStartDate=new DateTimePicker();
            dtpEndDate=new DateTimePicker();
            btnThongKe=new Button();
            dgvDoanhThu=new DataGridView();
            panel1=new Panel();
            labelHome=new Label();
            pictureBoxHome=new PictureBox();
            label13=new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor=Color.WhiteSmoke;
            tableLayoutPanel1.ColumnCount=6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,7.03764343F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,13.993453F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,22.0130939F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,7.44680834F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,13.338789F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,36.08838F));
            tableLayoutPanel1.Controls.Add(label1,1,1);
            tableLayoutPanel1.Controls.Add(label2,4,1);
            tableLayoutPanel1.Controls.Add(dtpStartDate,2,1);
            tableLayoutPanel1.Controls.Add(dtpEndDate,5,1);
            tableLayoutPanel1.Controls.Add(btnThongKe,5,2);
            tableLayoutPanel1.Dock=DockStyle.Fill;
            tableLayoutPanel1.Location=new Point(0,0);
            tableLayoutPanel1.Name="tableLayoutPanel1";
            tableLayoutPanel1.RowCount=4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent,12.8249569F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent,12.8249569F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent,14.0381279F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent,60.13865F));
            tableLayoutPanel1.Size=new Size(1222,577);
            tableLayoutPanel1.TabIndex=0;
            // 
            // label1
            // 
            label1.Anchor=AnchorStyles.Left;
            label1.AutoSize=true;
            label1.Font=new Font("Montserrat",13.7999992F,FontStyle.Bold);
            label1.ForeColor=Color.FromArgb(4,51,94);
            label1.Location=new Point(89,95);
            label1.Name="label1";
            label1.Size=new Size(117,32);
            label1.TabIndex=0;
            label1.Text="Từ ngày:";
            // 
            // label2
            // 
            label2.Anchor=AnchorStyles.Left;
            label2.AutoSize=true;
            label2.Font=new Font("Montserrat",13.7999992F,FontStyle.Bold);
            label2.ForeColor=Color.FromArgb(4,51,94);
            label2.Location=new Point(620,95);
            label2.Name="label2";
            label2.Size=new Size(137,32);
            label2.TabIndex=1;
            label2.Text="Đến ngày:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Anchor=AnchorStyles.Left;
            dtpStartDate.Location=new Point(260,97);
            dtpStartDate.Name="dtpStartDate";
            dtpStartDate.Size=new Size(259,27);
            dtpStartDate.TabIndex=2;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Anchor=AnchorStyles.Left;
            dtpEndDate.Location=new Point(783,97);
            dtpEndDate.Name="dtpEndDate";
            dtpEndDate.Size=new Size(269,27);
            dtpEndDate.TabIndex=3;
            // 
            // btnThongKe
            // 
            btnThongKe.Anchor=AnchorStyles.Bottom|AnchorStyles.Left;
            btnThongKe.BackColor=Color.FromArgb(0,134,197);
            btnThongKe.Font=new Font("Montserrat Black",13.7999992F,FontStyle.Bold,GraphicsUnit.Point,0);
            btnThongKe.ForeColor=SystemColors.ButtonHighlight;
            btnThongKe.Location=new Point(783,158);
            btnThongKe.Name="btnThongKe";
            btnThongKe.Size=new Size(322,68);
            btnThongKe.TabIndex=5;
            btnThongKe.Text="THỐNG KÊ DOANH THU";
            btnThongKe.UseVisualStyleBackColor=false;
            btnThongKe.Click+=btnThongKe_Click;
            // 
            // dgvDoanhThu
            // 
            dgvDoanhThu.AllowUserToAddRows=false;
            dgvDoanhThu.AllowUserToDeleteRows=false;
            dgvDoanhThu.Anchor=AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
            dgvDoanhThu.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoanhThu.Location=new Point(0,250);
            dgvDoanhThu.Name="dgvDoanhThu";
            dgvDoanhThu.ReadOnly=true;
            dgvDoanhThu.RowHeadersWidth=51;
            dgvDoanhThu.Size=new Size(1225,327);
            dgvDoanhThu.TabIndex=56;
            // 
            // panel1
            // 
            panel1.BackColor=Color.FromArgb(4,51,94);
            panel1.Controls.Add(labelHome);
            panel1.Controls.Add(pictureBoxHome);
            panel1.Controls.Add(label13);
            panel1.Dock=DockStyle.Top;
            panel1.Location=new Point(0,0);
            panel1.Name="panel1";
            panel1.Size=new Size(1222,69);
            panel1.TabIndex=57;
            // 
            // labelHome
            // 
            labelHome.AutoSize=true;
            labelHome.Font=new Font("Montserrat Black",13.7999992F,FontStyle.Bold,GraphicsUnit.Point,163);
            labelHome.ForeColor=SystemColors.ControlLightLight;
            labelHome.Location=new Point(43,21);
            labelHome.Name="labelHome";
            labelHome.Size=new Size(235,32);
            labelHome.TabIndex=64;
            labelHome.Text="11PM BOOKSTORE";
            // 
            // pictureBoxHome
            // 
            pictureBoxHome.Image=(Image)resources.GetObject("pictureBoxHome.Image");
            pictureBoxHome.Location=new Point(3,13);
            pictureBoxHome.Name="pictureBoxHome";
            pictureBoxHome.Size=new Size(37,37);
            pictureBoxHome.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBoxHome.TabIndex=63;
            pictureBoxHome.TabStop=false;
            // 
            // label13
            // 
            label13.Anchor=AnchorStyles.Top;
            label13.AutoSize=true;
            label13.BackColor=Color.Transparent;
            label13.Font=new Font("Montserrat",18F,FontStyle.Bold,GraphicsUnit.Point,163);
            label13.ForeColor=SystemColors.ButtonHighlight;
            label13.Location=new Point(720,14);
            label13.Name="label13";
            label13.Size=new Size(467,41);
            label13.TabIndex=62;
            label13.Text="Quản lý doanh thu cửa hàng";
            // 
            // FormDoanhThu
            // 
            AutoScaleDimensions=new SizeF(8F,20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.LemonChiffon;
            ClientSize=new Size(1222,577);
            Controls.Add(panel1);
            Controls.Add(dgvDoanhThu);
            Controls.Add(tableLayoutPanel1);
            Name="FormDoanhThu";
            Text="FormDoanhThu";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private DataGridView dgvDoanhThu;
        private Button btnThongKe;
        private Panel panel1;
        private Label label13;
        private Label labelHome;
        private PictureBox pictureBoxHome;
    }
}