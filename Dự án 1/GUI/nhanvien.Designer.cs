namespace Dự_án_1.GUI
{
    partial class nhanvien
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
            rdoNghilam = new RadioButton();
            rdoDangLam = new RadioButton();
            label3 = new Label();
            label2 = new Label();
            txtsđt = new TextBox();
            label1 = new Label();
            txtMaNV = new TextBox();
            txtdiachi = new TextBox();
            txtmatkhau = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            dgvDanhSach = new DataGridView();
            groupBox1 = new GroupBox();
            btnThem = new Button();
            rdoquanly = new RadioButton();
            rdoNhanvien = new RadioButton();
            label10 = new Label();
            rdonu = new RadioButton();
            dtpNgaySinh = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            txttaikhoan = new TextBox();
            label14 = new Label();
            rdoNam = new RadioButton();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            groupBox2 = new GroupBox();
            txtcccd = new TextBox();
            label6 = new Label();
            txtTen = new TextBox();
            label4 = new Label();
            txtemail = new TextBox();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            txtLammoi = new Button();
            txtTimKiem = new TextBox();
            txtSua = new Button();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // rdoNghilam
            // 
            rdoNghilam.AutoSize = true;
            rdoNghilam.Location = new Point(743, 287);
            rdoNghilam.Name = "rdoNghilam";
            rdoNghilam.Size = new Size(130, 30);
            rdoNghilam.TabIndex = 31;
            rdoNghilam.TabStop = true;
            rdoNghilam.Text = "Nghỉ làm";
            rdoNghilam.UseVisualStyleBackColor = true;
            // 
            // rdoDangLam
            // 
            rdoDangLam.AutoSize = true;
            rdoDangLam.Location = new Point(593, 286);
            rdoDangLam.Name = "rdoDangLam";
            rdoDangLam.Size = new Size(141, 30);
            rdoDangLam.TabIndex = 30;
            rdoDangLam.TabStop = true;
            rdoDangLam.Text = "Đang làm ";
            rdoDangLam.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label3.Location = new Point(464, 286);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 29;
            label3.Text = "Trạng thái :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label2.Location = new Point(26, 332);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 28;
            label2.Text = "SDT :";
            // 
            // txtsđt
            // 
            txtsđt.Location = new Point(192, 329);
            txtsđt.Name = "txtsđt";
            txtsđt.Size = new Size(260, 35);
            txtsđt.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label1.Location = new Point(26, 90);
            label1.Name = "label1";
            label1.Size = new Size(165, 25);
            label1.TabIndex = 26;
            label1.Text = "Tên Nhân viên :";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(192, 41);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(260, 35);
            txtMaNV.TabIndex = 25;
            // 
            // txtdiachi
            // 
            txtdiachi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtdiachi.Location = new Point(592, 195);
            txtdiachi.Multiline = true;
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(1187, 71);
            txtdiachi.TabIndex = 24;
            // 
            // txtmatkhau
            // 
            txtmatkhau.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtmatkhau.Location = new Point(592, 141);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(1187, 35);
            txtmatkhau.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label13.Location = new Point(464, 141);
            label13.Name = "label13";
            label13.Size = new Size(116, 25);
            label13.TabIndex = 22;
            label13.Text = "Mật khẩu :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label12.Location = new Point(464, 87);
            label12.Name = "label12";
            label12.Size = new Size(121, 25);
            label12.TabIndex = 21;
            label12.Text = "Tài khoản :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label11.Location = new Point(464, 195);
            label11.Name = "label11";
            label11.Size = new Size(98, 25);
            label11.TabIndex = 21;
            label11.Text = "Địa Chỉ :";
            // 
            // dgvDanhSach
            // 
            dgvDanhSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDanhSach.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSach.Location = new Point(6, 31);
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.RowHeadersWidth = 62;
            dgvDanhSach.Size = new Size(1004, 409);
            dgvDanhSach.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDanhSach);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Microsoft Sans Serif", 9F);
            groupBox1.Location = new Point(10, 476);
            groupBox1.Margin = new Padding(10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1016, 446);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Nhân Viên";
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.BackColor = Color.DarkCyan;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnThem.Location = new Point(53, 129);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(240, 52);
            btnThem.TabIndex = 28;
            btnThem.Text = "Thêm Nhân Viên";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // rdoquanly
            // 
            rdoquanly.AutoSize = true;
            rdoquanly.Location = new Point(721, 34);
            rdoquanly.Name = "rdoquanly";
            rdoquanly.Size = new Size(128, 30);
            rdoquanly.TabIndex = 20;
            rdoquanly.TabStop = true;
            rdoquanly.Text = "Quản Lý";
            rdoquanly.UseVisualStyleBackColor = true;
            // 
            // rdoNhanvien
            // 
            rdoNhanvien.AutoSize = true;
            rdoNhanvien.Location = new Point(577, 34);
            rdoNhanvien.Name = "rdoNhanvien";
            rdoNhanvien.Size = new Size(145, 30);
            rdoNhanvien.TabIndex = 19;
            rdoNhanvien.TabStop = true;
            rdoNhanvien.Text = "Nhân Viên";
            rdoNhanvien.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label10.Location = new Point(468, 37);
            label10.Name = "label10";
            label10.Size = new Size(94, 25);
            label10.TabIndex = 18;
            label10.Text = "Vai Trò :";
            // 
            // rdonu
            // 
            rdonu.AutoSize = true;
            rdonu.Location = new Point(304, 236);
            rdonu.Name = "rdonu";
            rdonu.Size = new Size(68, 30);
            rdonu.TabIndex = 17;
            rdonu.TabStop = true;
            rdonu.Text = "Nữ";
            rdonu.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(192, 183);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(260, 35);
            dtpNgaySinh.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label9.Location = new Point(26, 233);
            label9.Name = "label9";
            label9.Size = new Size(117, 25);
            label9.TabIndex = 14;
            label9.Text = "Giới Tính :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label8.Location = new Point(26, 185);
            label8.Name = "label8";
            label8.Size = new Size(121, 25);
            label8.TabIndex = 13;
            label8.Text = "Ngày Sinh :";
            // 
            // txttaikhoan
            // 
            txttaikhoan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txttaikhoan.Location = new Point(592, 90);
            txttaikhoan.Name = "txttaikhoan";
            txttaikhoan.Size = new Size(1187, 35);
            txttaikhoan.TabIndex = 12;
            txttaikhoan.UseSystemPasswordChar = true;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label14.Location = new Point(27, 30);
            label14.Name = "label14";
            label14.Size = new Size(0, 22);
            label14.TabIndex = 26;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(192, 235);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(85, 30);
            rdoNam.TabIndex = 16;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(10, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(313, 450);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label7.Location = new Point(26, 137);
            label7.Name = "label7";
            label7.Size = new Size(122, 25);
            label7.TabIndex = 11;
            label7.Text = "Số CMND :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdoNghilam);
            groupBox2.Controls.Add(rdoDangLam);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtsđt);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtMaNV);
            groupBox2.Controls.Add(txtdiachi);
            groupBox2.Controls.Add(txtmatkhau);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(rdoquanly);
            groupBox2.Controls.Add(rdoNhanvien);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(rdonu);
            groupBox2.Controls.Add(rdoNam);
            groupBox2.Controls.Add(dtpNgaySinh);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txttaikhoan);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtcccd);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtTen);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtemail);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1030, 460);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Nhân Viên";
            // 
            // txtcccd
            // 
            txtcccd.Location = new Point(192, 133);
            txtcccd.Name = "txtcccd";
            txtcccd.Size = new Size(260, 35);
            txtcccd.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label6.Location = new Point(26, 283);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 9;
            label6.Text = "Email :";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(192, 87);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(260, 35);
            txtTen.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label4.Location = new Point(26, 39);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 7;
            label4.Text = "Mã Nhân viên :";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(192, 280);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(260, 35);
            txtemail.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.GhostWhite;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(1388, 952);
            panel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.GhostWhite;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.8001556F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.1998444F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel5, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1368, 932);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Lavender;
            panel3.Controls.Add(groupBox2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1030, 460);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Lavender;
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(txtLammoi);
            panel4.Controls.Add(txtTimKiem);
            panel4.Controls.Add(txtSua);
            panel4.Controls.Add(btnThem);
            panel4.Controls.Add(label14);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(1039, 469);
            panel4.Name = "panel4";
            panel4.Size = new Size(326, 460);
            panel4.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(253, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 39);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // txtLammoi
            // 
            txtLammoi.Anchor = AnchorStyles.None;
            txtLammoi.BackColor = Color.DarkCyan;
            txtLammoi.FlatStyle = FlatStyle.Flat;
            txtLammoi.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            txtLammoi.Location = new Point(53, 299);
            txtLammoi.Name = "txtLammoi";
            txtLammoi.Size = new Size(240, 52);
            txtLammoi.TabIndex = 30;
            txtLammoi.Text = "làm mới";
            txtLammoi.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(10, 35);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(287, 46);
            txtTimKiem.TabIndex = 4;
            // 
            // txtSua
            // 
            txtSua.Anchor = AnchorStyles.None;
            txtSua.BackColor = Color.DarkCyan;
            txtSua.FlatStyle = FlatStyle.Flat;
            txtSua.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            txtSua.Location = new Point(53, 213);
            txtSua.Name = "txtSua";
            txtSua.Size = new Size(240, 52);
            txtSua.TabIndex = 29;
            txtSua.Text = "Cập Nhập Thông Tin";
            txtSua.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(1039, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(326, 460);
            panel5.TabIndex = 3;
            // 
            // nhanvien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1388, 952);
            Controls.Add(panel2);
            Name = "nhanvien";
            Text = "nhanvien";
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RadioButton rdoNghilam;
        private RadioButton rdoDangLam;
        private Label label3;
        private Label label2;
        private TextBox txtsđt;
        private Label label1;
        private TextBox txtMaNV;
        private TextBox txtdiachi;
        private TextBox txtmatkhau;
        private Label label13;
        private Label label12;
        private Label label11;
        private DataGridView dgvDanhSach;
        private GroupBox groupBox1;
        private Button btnThem;
        private RadioButton rdoquanly;
        private RadioButton rdoNhanvien;
        private Label label10;
        private RadioButton rdonu;
        private DateTimePicker dtpNgaySinh;
        private Label label9;
        private Label label8;
        private TextBox txttaikhoan;
        private Label label14;
        private RadioButton rdoNam;
        private PictureBox pictureBox1;
        private Label label7;
        private GroupBox groupBox2;
        private TextBox txtcccd;
        private Label label6;
        private TextBox txtTen;
        private Label label4;
        private TextBox txtemail;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Button txtLammoi;
        private TextBox txtTimKiem;
        private Button txtSua;
        private Panel panel5;
    }
}