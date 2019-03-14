using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai38_BaiTapTongQuat_QuanLiSP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<SanPham> dsSPGoc = new List<SanPham>();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SanPham sp = new SanPham()
                {
                    Ma = txtMa.Text,
                    Ten = txtTen.Text,
                    Soluong = int.Parse(txtSoluong.Text),
                    DonGia = int.Parse(txtDonGia.Text),
                    XuatSu = txtXuatXu.Text,
                    HSD = dtpkHSD.Value
                };
                dsSPGoc.Add(sp);
                XoaDuLieuVuaNhap();
                AddToListView(sp, lsvSanPhamKho);
            }
            catch { return; }
        }
        void XoaDuLieuVuaNhap()
        {
            txtMa.Focus();
            txtMa.Clear();
            txtTen.Clear();
            txtSoluong.Clear();
            txtDonGia.Clear();
            txtXuatXu.Clear();

        }
        void AddToListView(SanPham sp,ListView lsv)
        {
            ListViewItem item = new ListViewItem(sp.Ma);
            item.SubItems.Add(sp.Ten);
            item.SubItems.Add(sp.Soluong.ToString());
            item.SubItems.Add(sp.DonGia.ToString());
            item.SubItems.Add(sp.XuatSu);
            item.SubItems.Add(sp.HSD.ToString("dd/MM/yyyy"));
            lsv.Items.Add(item);
        }
        void HienThiSp(List<SanPham> sps,ListView lsv)
        {
            lsv.Items.Clear();
            sps.ForEach(sp => AddToListView(sp, lsv));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvSanPhamKho.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                int vtXoa = lsvSanPhamKho.SelectedIndices[0];
                dsSPGoc.RemoveAt(vtXoa);
                lsvSanPhamKho.Items.RemoveAt(vtXoa);
                
            }
        }

        private void btnXoaTheoXuatXu_Click(object sender, EventArgs e)
        {
            for(int i = dsSPGoc.Count - 1; i >= 0; i--)
            {
                if (dsSPGoc[i].XuatSu.Equals(txtXoaTheoXuatXu.Text))
                {
                    dsSPGoc.RemoveAt(i);
                    lsvSanPhamKho.Items.RemoveAt(i);
                }
            }
            
        }

        private void btnKiemTraHSD_Click(object sender, EventArgs e)
        {
            if (dsSPGoc.Any(x => x.HSD < DateTime.Now))
            {
                MessageBox.Show("Co");
            }
            else
                MessageBox.Show("Khong co");

        }

        private void btnXoaAllSP_Click(object sender, EventArgs e)
        {
            dsSPGoc.Clear();
            lsvSanPhamKho.Items.Clear();
        }

        private void btmXoaSPHetHSD_Click(object sender, EventArgs e)
        {
            dsSPGoc.RemoveAll(x => x.HSD < DateTime.Now);
        }

        private void btn1SPMAX_Click(object sender, EventArgs e)
        {
            lsvSPTimKiem.Items.Clear();
            //SanPham sp2 = dsSPGoc.Max(x=>x);
            //AddToListView(sp2, lsvSPTimKiem);
            int giaMax = dsSPGoc.Max(sp => sp.DonGia);
            AddToListView(dsSPGoc.Find(x => x.DonGia == giaMax), lsvSPTimKiem);
        }

        private void btnSPHetHan_Click(object sender, EventArgs e)
        {
            var ds = dsSPGoc.FindAll(x => x.HSD < DateTime.Now).ToList();
            HienThiSp(ds, lsvSPTimKiem);
        }

        private void bntLocTheoGia_Click(object sender, EventArgs e)
        {
            var ds = dsSPGoc.Where(x => x.DonGia < int.Parse(txtGiaMax.Text) &&
            x.DonGia > int.Parse(txtGiaMin.Text));
            HienThiSp(ds.ToList(), lsvSPTimKiem);
        }
    }
}
