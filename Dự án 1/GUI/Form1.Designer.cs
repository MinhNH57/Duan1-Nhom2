namespace Dự_án_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            checkBox1 = new CheckBox();
            txt_matKhau = new TextBox();
            txt_takKhoan = new TextBox();
            btn_Login = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.ErrorImage = Properties.Resources.R;
            pictureBox1.Image = Properties.Resources.R;
            pictureBox1.Location = new Point(-4, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(408, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(txt_matKhau);
            panel1.Controls.Add(txt_takKhoan);
            panel1.Location = new Point(10, 171);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 216);
            panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top;
            pictureBox3.Image = Properties.Resources._5582931;
            pictureBox3.Location = new Point(13, 93);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(58, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.Image = Properties.Resources.user_icon_2048x2048_ihoxz4vq;
            pictureBox2.Location = new Point(13, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(87, 165);
            checkBox1.Margin = new Padding(2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(127, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Hiện mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txt_matKhau
            // 
            txt_matKhau.Anchor = AnchorStyles.Top;
            txt_matKhau.Location = new Point(87, 112);
            txt_matKhau.Margin = new Padding(2);
            txt_matKhau.Name = "txt_matKhau";
            txt_matKhau.PlaceholderText = "**********";
            txt_matKhau.Size = new Size(251, 27);
            txt_matKhau.TabIndex = 3;
            txt_matKhau.UseSystemPasswordChar = true;
            // 
            // txt_takKhoan
            // 
            txt_takKhoan.Anchor = AnchorStyles.Top;
            txt_takKhoan.ImeMode = ImeMode.On;
            txt_takKhoan.Location = new Point(87, 23);
            txt_takKhoan.Margin = new Padding(2);
            txt_takKhoan.Name = "txt_takKhoan";
            txt_takKhoan.PlaceholderText = "Nhập Tài Khoản";
            txt_takKhoan.Size = new Size(251, 27);
            txt_takKhoan.TabIndex = 2;
            txt_takKhoan.WordWrap = false;
            // 
            // btn_Login
            // 
            btn_Login.Anchor = AnchorStyles.Top;
            btn_Login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Login.Location = new Point(130, 412);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(110, 41);
            btn_Login.TabIndex = 6;
            btn_Login.Text = "Đăng nhập";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScrollMargin = new Size(100, 110);
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(404, 478);
            Controls.Add(btn_Login);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Đăng nhập - Ryo";
            TopMost = true;
            WindowState = FormWindowState.Minimized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private CheckBox checkBox1;
        private TextBox txt_matKhau;
        private TextBox txt_takKhoan;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button btn_Login;
    }
}
