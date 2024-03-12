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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            cb_chatLieuSP = new ComboBox();
            btn_them = new Button();
            btn_sua = new Button();
            btn_voHieu = new Button();
            txt_timKiem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label4.Location = new Point(344, 46);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 18);
            label4.TabIndex = 7;
            label4.Text = "Loại Sản Phẩm";
            // 
            // cb_loaiSP
            // 
            cb_loaiSP.FormattingEnabled = true;
            cb_loaiSP.Location = new Point(469, 37);
            cb_loaiSP.Name = "cb_loaiSP";
            cb_loaiSP.Size = new Size(151, 28);
            cb_loaiSP.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label3.Location = new Point(135, 128);
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
            label2.Location = new Point(135, 89);
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
            label1.Location = new Point(135, 47);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 18);
            label1.TabIndex = 4;
            label1.Text = "Mã Sản Phẩm";
            // 
            // txt_tenSP
            // 
            txt_tenSP.Location = new Point(344, 80);
            txt_tenSP.Margin = new Padding(2);
            txt_tenSP.Name = "txt_tenSP";
            txt_tenSP.Size = new Size(276, 27);
            txt_tenSP.TabIndex = 1;
            // 
            // txt_maSP
            // 
            txt_maSP.Location = new Point(257, 37);
            txt_maSP.Margin = new Padding(2);
            txt_maSP.Name = "txt_maSP";
            txt_maSP.Size = new Size(72, 27);
            txt_maSP.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 237);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(782, 241);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(cb_chatLieuSP);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_tenSP);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cb_loaiSP);
            groupBox1.Controls.Add(txt_maSP);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.Red;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(778, 189);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // cb_chatLieuSP
            // 
            cb_chatLieuSP.FormattingEnabled = true;
            cb_chatLieuSP.Location = new Point(344, 118);
            cb_chatLieuSP.Name = "cb_chatLieuSP";
            cb_chatLieuSP.Size = new Size(276, 28);
            cb_chatLieuSP.TabIndex = 9;
            // 
            // btn_them
            // 
            btn_them.Anchor = AnchorStyles.Top;
            btn_them.Location = new Point(186, 483);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(87, 29);
            btn_them.TabIndex = 10;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            btn_sua.Anchor = AnchorStyles.Top;
            btn_sua.Location = new Point(336, 483);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(87, 29);
            btn_sua.TabIndex = 10;
            btn_sua.Text = "Sửa ";
            btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_voHieu
            // 
            btn_voHieu.Anchor = AnchorStyles.Top;
            btn_voHieu.Location = new Point(491, 483);
            btn_voHieu.Name = "btn_voHieu";
            btn_voHieu.Size = new Size(87, 29);
            btn_voHieu.TabIndex = 10;
            btn_voHieu.Text = "Vô hiệu ";
            btn_voHieu.UseVisualStyleBackColor = true;
            // 
            // txt_timKiem
            // 
            txt_timKiem.Anchor = AnchorStyles.Top;
            txt_timKiem.Location = new Point(254, 206);
            txt_timKiem.Margin = new Padding(2);
            txt_timKiem.Name = "txt_timKiem";
            txt_timKiem.Size = new Size(276, 27);
            txt_timKiem.TabIndex = 1;
            // 
            // SanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 524);
            Controls.Add(btn_voHieu);
            Controls.Add(btn_sua);
            Controls.Add(txt_timKiem);
            Controls.Add(btn_them);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "SanPham";
            Text = "SanPham";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_tenSP;
        private TextBox txt_maSP;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cb_loaiSP;
        private GroupBox groupBox1;
        private ComboBox cb_chatLieuSP;
        private Button btn_them;
        private Button btn_sua;
        private Button btn_voHieu;
        private TextBox txt_timKiem;
    }
}