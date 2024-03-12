using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dự_án_1.VIEWS
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }
        private Form currentFromChild;

        private void Open(Form child)
        {
            if (currentFromChild != null)
            {
                currentFromChild.Close();
            }
            currentFromChild = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            Pa_Body.Controls.Add(child);

            int x = Pa_Body.Location.X + (Pa_Body.Width - child.Width) / 2;
            int y = Pa_Body.Location.Y + (Pa_Body.Height - child.Height) / 2;

            child.Location = new Point(x, y);

            Pa_Body.Tag = child;
            child.BringToFront();
            child.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Open(new SanPham());
            label1.Text = button1.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFromChild != null)
            {
                currentFromChild.Close();
            }
            label1.Text = "Thời Trang RYo";
        }
    }
}
