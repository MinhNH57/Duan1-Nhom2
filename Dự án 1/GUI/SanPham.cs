using Dự_án_1.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dự_án_1.VIEWS
{
    public partial class SanPham : Form
    {
        #region
        SanPhamSer sp = new();
        SPCTSer spct = new();
        Brandser thuongHieu = new();
        MauSer mauSac = new();
        SizeSer kichThuoc = new();
        string pathimg;
        #endregion

        public SanPham()
        {
            InitializeComponent();
        }
        #region
        public void loadcb_Brand()
        {
            var q = from i in thuongHieu.getAllBrandSer() select i;
            cb_thuongHieu.DataSource = q.ToList();
            cb_thuongHieu.DisplayMember = "Tenth";
            cb_thuongHieu.ValueMember = "Math";
        }

        public void loadcb_Color()
        {
            var q = from i in mauSac.getAllColorSer() select i;
            cb_mauSac.DataSource = q.ToList();
            cb_mauSac.DisplayMember = "Tenmau";
            cb_mauSac.ValueMember = "Mamau";
        }

        public void loadcb_KichThuoc()
        {
            var q = from i in kichThuoc.getAllSizeSer() select i;
            cb_size.DataSource = q.ToList();
            cb_size.DisplayMember = "Tensize";
            cb_size.ValueMember = "Masize";
        }
        public void Loaddata()
        {
            var q = from i in sp.getAllSanPhamSer()
                    join a in spct.getAllSPCTSer() on i.Masp equals a.Masp
                    join ms in mauSac.getAllColorSer() on a.Mamau equals ms.Mamau
                    join kt in kichThuoc.getAllSizeSer() on a.Masize equals kt.Masize
                    join br in thuongHieu.getAllBrandSer() on a.Math equals br.Math
                    select new
                    {
                        i.Masp,
                        i.Tensp,
                        i.Loaisp,
                        i.Chatlieu,
                        a.Maspct,
                        a.Tenspct,
                        ms.Tenmau,
                        kt.Tensize,
                        br.Tenth,
                        a.Dongia,
                        a.Soluong
                    };
            dgv_dataSP.DataSource = q.ToList();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void loadSP()
        {
            var q = from i in sp.getAllSanPhamSer()
                    select new
                    {
                        i.Masp,
                        i.Tensp,
                        i.Loaisp,
                        i.Chatlieu
                    };
            dgv_SP.DataSource = q.ToList();
        }

        public void loadSPCT()
        {
            var q = from i in spct.getAllSPCTSer()
                    select new
                    {
                        i.Maspct,
                        i.Tenspct,
                        i.Soluong,
                        i.Dongia
                    };
            dgv_SPCT.DataSource = q.ToList();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            Loaddata();
            loadSP();
            loadSPCT();
            loadcb_Brand();
            loadcb_Color();
            loadcb_KichThuoc();
        }
        #endregion

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if(sp.FindbyIDSer(txt_maSP.Text) != null)
                {
                    MessageBox.Show("Vui long chon ma san pham khac", "Thong bao");
                }
                else
                {
                    string mess = sp.CreateSpSer(txt_maSP.Text, txt_tenSP.Text, cb_loaiSP.Text, cb_chatLieuSP.Text);
                    MessageBox.Show(mess, "Thong bao");
                    loadSP();
                }
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
                loadSP();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao");
            }
        }

        private void cb_loaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_ThemSPCT_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pathimg))
            {
                try
                {
                    byte[] imageBytes = File.ReadAllBytes(pathimg);
                    string mess = spct.CreateSPCTSer(txt_maSPCT.Text, txt_TenSPCT.Text, cb_thuongHieu.SelectedValue.ToString(), cb_size.SelectedValue.ToString(), cb_mauSac.SelectedValue.ToString(), txt_maSP.Text, decimal.Parse(txt_donGia.Text), int.Parse(txt_soLuong.Text), imageBytes);
                    MessageBox.Show(mess, "Thong bao");
                    loadSPCT();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc dữ liệu hình ảnh: " + ex.Message, "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hình ảnh trước khi thêm sản phẩm.", "Thông báo");
            }
        }

        private void btn_chonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg; *.jpeg; *.png; *.gif";
            openFileDialog.Title = "Chọn ảnh";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    Image image = Image.FromFile(openFileDialog.FileName);


                    pic_spct.Image = image;

                    pathimg = openFileDialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải hình ảnh: " + ex.Message);
                }
            }
        }
    }
}
