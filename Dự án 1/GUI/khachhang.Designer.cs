namespace Dự_án_1.GUI
{
    partial class khachhang
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
            txtTimKiem = new TextBox();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            btnLammoi = new Button();
            btnSua = new Button();
            btnThem = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            panel3 = new Panel();
            textBox1 = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(363, 6);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(568, 46);
            txtTimKiem.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1382, 576);
            dataGridView1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(txtTimKiem);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(3, 36);
            panel4.Name = "panel4";
            panel4.Size = new Size(1382, 58);
            panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(888, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 39);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnLammoi
            // 
            btnLammoi.BackColor = Color.RosyBrown;
            btnLammoi.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            btnLammoi.Location = new Point(1118, 172);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.Size = new Size(139, 52);
            btnLammoi.TabIndex = 13;
            btnLammoi.Text = "Làm mới";
            btnLammoi.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.RosyBrown;
            btnSua.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            btnSua.Location = new Point(943, 172);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(139, 52);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.RosyBrown;
            btnThem.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            btnThem.Location = new Point(759, 172);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(139, 52);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(385, 143);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(61, 29);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(251, 145);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 29);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(839, 31);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(450, 83);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(251, 206);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(445, 31);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(251, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(445, 31);
            textBox2.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(panel4);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1388, 673);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách khách hàng";
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 279);
            panel3.Name = "panel3";
            panel3.Size = new Size(1388, 673);
            panel3.TabIndex = 46;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(251, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(445, 31);
            textBox1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F);
            label6.Location = new Point(740, 31);
            label6.Name = "label6";
            label6.Size = new Size(93, 27);
            label6.TabIndex = 4;
            label6.Text = "Địa chỉ :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(53, 145);
            label3.Name = "label3";
            label3.Size = new Size(109, 27);
            label3.TabIndex = 2;
            label3.Text = "Giới tính :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(53, 87);
            label2.Name = "label2";
            label2.Size = new Size(177, 27);
            label2.TabIndex = 1;
            label2.Text = "Tên khách hàng :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(53, 33);
            label1.Name = "label1";
            label1.Size = new Size(177, 27);
            label1.TabIndex = 0;
            label1.Text = "Mã Khách hàng :";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(btnLammoi);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1388, 279);
            panel2.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.Location = new Point(53, 206);
            label4.Name = "label4";
            label4.Size = new Size(149, 27);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại :";
            // 
            // khachhang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1388, 952);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "khachhang";
            Text = "khachhang";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtTimKiem;
        private DataGridView dataGridView1;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Button btnLammoi;
        private Button btnSua;
        private Button btnThem;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private Panel panel3;
        private TextBox textBox1;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label4;
    }
}