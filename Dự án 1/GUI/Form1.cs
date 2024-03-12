using Dự_án_1.BLL;
using Dự_án_1.VIEWS;
using System.Drawing.Drawing2D;

namespace Dự_án_1
{
    public partial class Form1 : Form
    {
        static string loaiTK;
        NhanVienSer nv = new();
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            /*base.OnPaint(e);
            GraphicsPath formPath = new GraphicsPath();
            int cornerRadius = 50; // Độ bo tròn góc, bạn có thể tùy chỉnh
            formPath.StartFigure();
            formPath.AddArc(new Rectangle(0, 0, cornerRadius, cornerRadius), 180, 90);
            formPath.AddLine(cornerRadius, 0, this.Width - cornerRadius, 0);
            formPath.AddArc(new Rectangle(this.Width - cornerRadius, 0, cornerRadius, cornerRadius), -90, 90);
            formPath.AddLine(this.Width, cornerRadius, this.Width, this.Height - cornerRadius);
            formPath.AddArc(new Rectangle(this.Width - cornerRadius, this.Height - cornerRadius, cornerRadius, cornerRadius), 0, 90);
            formPath.AddLine(cornerRadius, this.Height, this.Width - cornerRadius, this.Height);
            formPath.AddArc(new Rectangle(0, this.Height - cornerRadius, cornerRadius, cornerRadius), 90, 90);
            formPath.CloseFigure();
            this.Region = new Region(formPath);*/
        }

        private bool checkUser(string tk , string mk)
        {
            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            TrangChu trangChu = new TrangChu();
            this.Hide();
            trangChu.ShowDialog();
            this.Show();
        }
    }
}
