namespace Dự_án_1.VIEWS
{
    partial class SanPham
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
            label4 = new Label();
            cb_loaiSP = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_tenSP = new TextBox();
            txt_maSP = new TextBox();
            dgv_dataSP = new DataGridView();
            groupBox1 = new GroupBox();
            cb_chatLieuSP = new ComboBox();
            btn_sua = new Button();
            btn_them = new Button();
            txt_timKiem = new TextBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            txt_TenSPCT = new TextBox();
            label6 = new Label();
            txt_soLuong = new TextBox();
            btn_suaSPCT = new Button();
            btn_ThemSPCT = new Button();
            cb_thuongHieu = new ComboBox();
            txt_donGia = new TextBox();
            txt_maSPCT = new TextBox();
            cb_size = new ComboBox();
            cb_mauSac = new ComboBox();
            label11 = new Label();
            label7 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            pic_spct = new PictureBox();
            groupBox3 = new GroupBox();
            dgv_SP = new DataGridView();
            groupBox4 = new GroupBox();
            dgv_SPCT = new DataGridView();
            btn_chonAnh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_dataSP).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_spct).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_SP).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_SPCT).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label4.Location = new Point(227, 43);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 18);
            label4.TabIndex = 7;
            label4.Text = "Loại Sản Phẩm";
            // 
            // cb_loaiSP
            // 
            cb_loaiSP.FormattingEnabled = true;
            cb_loaiSP.Items.AddRange(new object[] { "Quần Jeans", "Áo Bommber", "Áo polo" });
            cb_loaiSP.Location = new Point(352, 34);
            cb_loaiSP.Name = "cb_loaiSP";
            cb_loaiSP.Size = new Size(97, 28);
            cb_loaiSP.TabIndex = 8;
            cb_loaiSP.SelectedIndexChanged += cb_loaiSP_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label3.Location = new Point(18, 125);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(155, 18);
            label3.TabIndex = 6;
            label3.Text = "Chất Liệu Sản Phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label2.Location = new Point(18, 86);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 18);
            label2.TabIndex = 5;
            label2.Text = "Tên Sản Phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label1.Location = new Point(18, 44);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 18);
            label1.TabIndex = 4;
            label1.Text = "Mã Sản Phẩm";
            // 
            // txt_tenSP
            // 
            txt_tenSP.Location = new Point(227, 77);
            txt_tenSP.Margin = new Padding(2);
            txt_tenSP.Name = "txt_tenSP";
            txt_tenSP.Size = new Size(222, 27);
            txt_tenSP.TabIndex = 1;
            // 
            // txt_maSP
            // 
            txt_maSP.Location = new Point(140, 34);
            txt_maSP.Margin = new Padding(2);
            txt_maSP.Name = "txt_maSP";
            txt_maSP.Size = new Size(72, 27);
            txt_maSP.TabIndex = 0;
            // 
            // dgv_dataSP
            // 
            dgv_dataSP.Anchor = AnchorStyles.Top;
            dgv_dataSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_dataSP.Location = new Point(13, 480);
            dgv_dataSP.Margin = new Padding(2);
            dgv_dataSP.Name = "dgv_dataSP";
            dgv_dataSP.RowHeadersWidth = 62;
            dgv_dataSP.Size = new Size(1086, 268);
            dgv_dataSP.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(cb_chatLieuSP);
            groupBox1.Controls.Add(btn_sua);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_tenSP);
            groupBox1.Controls.Add(btn_them);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cb_loaiSP);
            groupBox1.Controls.Add(txt_maSP);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.Red;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(469, 197);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // cb_chatLieuSP
            // 
            cb_chatLieuSP.FormattingEnabled = true;
            cb_chatLieuSP.Items.AddRange(new object[] { "Canvas", "Cotton'", "Polyme", "Sợi tổng hợp" });
            cb_chatLieuSP.Location = new Point(227, 115);
            cb_chatLieuSP.Name = "cb_chatLieuSP";
            cb_chatLieuSP.Size = new Size(222, 28);
            cb_chatLieuSP.TabIndex = 9;
            // 
            // btn_sua
            // 
            btn_sua.Anchor = AnchorStyles.Top;
            btn_sua.Location = new Point(257, 154);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(87, 29);
            btn_sua.TabIndex = 10;
            btn_sua.Text = "Sửa ";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_them
            // 
            btn_them.Anchor = AnchorStyles.Top;
            btn_them.Location = new Point(125, 154);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(87, 29);
            btn_them.TabIndex = 10;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // txt_timKiem
            // 
            txt_timKiem.Anchor = AnchorStyles.Top;
            txt_timKiem.Location = new Point(419, 449);
            txt_timKiem.Margin = new Padding(2);
            txt_timKiem.Name = "txt_timKiem";
            txt_timKiem.Size = new Size(289, 27);
            txt_timKiem.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txt_TenSPCT);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txt_soLuong);
            groupBox2.Controls.Add(btn_suaSPCT);
            groupBox2.Controls.Add(btn_ThemSPCT);
            groupBox2.Controls.Add(cb_thuongHieu);
            groupBox2.Controls.Add(txt_donGia);
            groupBox2.Controls.Add(txt_maSPCT);
            groupBox2.Controls.Add(cb_size);
            groupBox2.Controls.Add(cb_mauSac);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.ForeColor = Color.Red;
            groupBox2.Location = new Point(487, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(469, 197);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sản phẩm chi tiết";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label5.Location = new Point(186, 43);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(35, 18);
            label5.TabIndex = 7;
            label5.Text = "Tên";
            // 
            // txt_TenSPCT
            // 
            txt_TenSPCT.Location = new Point(225, 35);
            txt_TenSPCT.Margin = new Padding(2);
            txt_TenSPCT.Name = "txt_TenSPCT";
            txt_TenSPCT.Size = new Size(222, 27);
            txt_TenSPCT.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label6.Location = new Point(18, 44);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(73, 18);
            label6.TabIndex = 4;
            label6.Text = "Mã SPCT";
            // 
            // txt_soLuong
            // 
            txt_soLuong.Location = new Point(257, 121);
            txt_soLuong.Margin = new Padding(2);
            txt_soLuong.Name = "txt_soLuong";
            txt_soLuong.Size = new Size(72, 27);
            txt_soLuong.TabIndex = 0;
            // 
            // btn_suaSPCT
            // 
            btn_suaSPCT.Anchor = AnchorStyles.Top;
            btn_suaSPCT.Location = new Point(257, 160);
            btn_suaSPCT.Name = "btn_suaSPCT";
            btn_suaSPCT.Size = new Size(87, 29);
            btn_suaSPCT.TabIndex = 10;
            btn_suaSPCT.Text = "Sửa";
            btn_suaSPCT.UseVisualStyleBackColor = true;
            btn_suaSPCT.Click += btn_them_Click;
            // 
            // btn_ThemSPCT
            // 
            btn_ThemSPCT.Anchor = AnchorStyles.Top;
            btn_ThemSPCT.Location = new Point(123, 160);
            btn_ThemSPCT.Name = "btn_ThemSPCT";
            btn_ThemSPCT.Size = new Size(87, 29);
            btn_ThemSPCT.TabIndex = 10;
            btn_ThemSPCT.Text = "Thêm";
            btn_ThemSPCT.UseVisualStyleBackColor = true;
            btn_ThemSPCT.Click += btn_ThemSPCT_Click;
            // 
            // cb_thuongHieu
            // 
            cb_thuongHieu.FormattingEnabled = true;
            cb_thuongHieu.Location = new Point(334, 76);
            cb_thuongHieu.Name = "cb_thuongHieu";
            cb_thuongHieu.Size = new Size(113, 28);
            cb_thuongHieu.TabIndex = 8;
            cb_thuongHieu.SelectedIndexChanged += cb_loaiSP_SelectedIndexChanged;
            // 
            // txt_donGia
            // 
            txt_donGia.Location = new Point(89, 121);
            txt_donGia.Margin = new Padding(2);
            txt_donGia.Name = "txt_donGia";
            txt_donGia.Size = new Size(72, 27);
            txt_donGia.TabIndex = 0;
            // 
            // txt_maSPCT
            // 
            txt_maSPCT.Location = new Point(95, 34);
            txt_maSPCT.Margin = new Padding(2);
            txt_maSPCT.Name = "txt_maSPCT";
            txt_maSPCT.Size = new Size(72, 27);
            txt_maSPCT.TabIndex = 0;
            // 
            // cb_size
            // 
            cb_size.FormattingEnabled = true;
            cb_size.Location = new Point(395, 121);
            cb_size.Name = "cb_size";
            cb_size.Size = new Size(52, 28);
            cb_size.TabIndex = 8;
            // 
            // cb_mauSac
            // 
            cb_mauSac.FormattingEnabled = true;
            cb_mauSac.Items.AddRange(new object[] { "" });
            cb_mauSac.Location = new Point(95, 77);
            cb_mauSac.Name = "cb_mauSac";
            cb_mauSac.Size = new Size(126, 28);
            cb_mauSac.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label11.Location = new Point(180, 130);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(73, 18);
            label11.TabIndex = 6;
            label11.Text = "Số lượng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label7.Location = new Point(12, 130);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(65, 18);
            label7.TabIndex = 6;
            label7.Text = "Đơn giá";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label10.Location = new Point(350, 130);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(40, 18);
            label10.TabIndex = 5;
            label10.Text = "Size";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label9.Location = new Point(230, 86);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(99, 18);
            label9.TabIndex = 5;
            label9.Text = "Thương hiệu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label8.Location = new Point(18, 86);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(68, 18);
            label8.TabIndex = 5;
            label8.Text = "Màu sắc";
            // 
            // pic_spct
            // 
            pic_spct.Anchor = AnchorStyles.Top;
            pic_spct.Location = new Point(962, 23);
            pic_spct.Name = "pic_spct";
            pic_spct.Size = new Size(136, 178);
            pic_spct.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_spct.TabIndex = 11;
            pic_spct.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top;
            groupBox3.Controls.Add(dgv_SP);
            groupBox3.ForeColor = Color.Red;
            groupBox3.Location = new Point(12, 255);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(469, 189);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sản phẩm";
            // 
            // dgv_SP
            // 
            dgv_SP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_SP.Location = new Point(6, 26);
            dgv_SP.Name = "dgv_SP";
            dgv_SP.RowHeadersWidth = 51;
            dgv_SP.Size = new Size(457, 157);
            dgv_SP.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top;
            groupBox4.Controls.Add(dgv_SPCT);
            groupBox4.ForeColor = Color.Red;
            groupBox4.Location = new Point(488, 255);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(611, 189);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sản phẩm chi tiết";
            // 
            // dgv_SPCT
            // 
            dgv_SPCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_SPCT.Location = new Point(6, 26);
            dgv_SPCT.Name = "dgv_SPCT";
            dgv_SPCT.RowHeadersWidth = 51;
            dgv_SPCT.Size = new Size(599, 157);
            dgv_SPCT.TabIndex = 0;
            // 
            // btn_chonAnh
            // 
            btn_chonAnh.Anchor = AnchorStyles.Top;
            btn_chonAnh.Location = new Point(995, 220);
            btn_chonAnh.Name = "btn_chonAnh";
            btn_chonAnh.Size = new Size(87, 29);
            btn_chonAnh.TabIndex = 10;
            btn_chonAnh.Text = "Chọn Ảnh";
            btn_chonAnh.UseVisualStyleBackColor = true;
            btn_chonAnh.Click += btn_chonAnh_Click;
            // 
            // SanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 762);
            Controls.Add(pic_spct);
            Controls.Add(txt_timKiem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(btn_chonAnh);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(dgv_dataSP);
            Margin = new Padding(2);
            Name = "SanPham";
            Text = "SanPham";
            Load += SanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_dataSP).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_spct).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_SP).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_SPCT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_tenSP;
        private TextBox txt_maSP;
        private DataGridView dgv_dataSP;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cb_loaiSP;
        private GroupBox groupBox1;
        private ComboBox cb_chatLieuSP;
        private Button btn_them;
        private Button btn_sua;
        private TextBox txt_timKiem;
        private GroupBox groupBox2;
        private Label label5;
        private TextBox txt_TenSPCT;
        private Label label6;
        private TextBox txt_maSPCT;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label9;
        private TextBox txt_soLuong;
        private TextBox txt_donGia;
        private ComboBox cb_size;
        private ComboBox cb_mauSac;
        private Label label11;
        private ComboBox cb_thuongHieu;
        private PictureBox pic_spct;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DataGridView dgv_SP;
        private DataGridView dgv_SPCT;
        private Button btn_suaSPCT;
        private Button btn_ThemSPCT;
        private Button btn_chonAnh;
    }
}