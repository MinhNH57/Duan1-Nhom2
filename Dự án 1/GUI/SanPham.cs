using Dự_án_1.BLL;
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
    public partial class SanPham : Form
    {
        SanPhamSer sp = new();
        public SanPham()
        {
            InitializeComponent();
        }

        public void Loaddata()
        {
            var q = from i in sp.getAllSanPhamSer()
                    select new
                    {
                        i.Masp,
                        i.Tensp,
                        i.Loaisp,
                        i.Chatlieu
                    };
            dgv_dataSP.DataSource = q.ToList();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                string mess = sp.CreateSpSer(txt_maSP.Text, txt_tenSP.Text, cb_loaiSP.Text, cb_chatLieuSP.Text);
                MessageBox.Show(mess, "Thong bao");
                Loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                string mess = sp.UpdateSpser(txt_maSP.Text, txt_tenSP.Text, cb_loaiSP.Text, cb_chatLieuSP.Text);
                MessageBox.Show(mess, "thong bao");
                Loaddata();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao");
            }
        }
    }
}
