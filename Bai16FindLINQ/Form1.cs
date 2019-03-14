using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai16FindLINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<double> dsDouble = new List<double>();
        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            Random rd = new Random();
            dsDouble.Clear();
            for(int i = 0; i < n; i++)
            {
                double x = Math.Round(rd.NextDouble() * 100, 2);
                dsDouble.Add(x);
            }

            listBox1.Items.Clear();
            dsDouble.ForEach(x => listBox1.Items.Add(x));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double k = double.Parse(textBox2.Text);
            double kq = dsDouble.Find(x => x == k);
            MessageBox.Show(kq + "===");
        }

        List<SanPham> liSp = new List<SanPham>();
        private void btnGiaLapData_Click(object sender, EventArgs e)
        {
            liSp.Clear();

            liSp.Add(new SanPham() { Masp = "1", Gia = 1.1 });
            liSp.Add(new SanPham() { Masp = "2", Gia = 2.1 });
            liSp.Add(new SanPham() { Masp = "3", Gia = 32.1 });
            liSp.Add(new SanPham() { Masp = "4", Gia = 121 });
            liSp.Add(new SanPham() { Masp = "5", Gia = 51 });
            liSp.Add(new SanPham() { Masp = "6", Gia = 12.1 });
            liSp.Add(new SanPham() { Masp = "7", Gia = 1.21 });
            liSp.Add(new SanPham() { Masp = "8", Gia = 1.11 });
            liSp.Add(new SanPham() { Masp = "9", Gia = 1.14 });

            listView1.Items.Clear();

            liSp.ForEach(x =>
            {
                ListViewItem i = new ListViewItem((listView1.Items.Count + 1).ToString());
                i.SubItems.Add(x.Masp);
                i.SubItems.Add(x.Gia.ToString());
                listView1.Items.Add(i);
            });
        }

        private void btnTimSp_Click(object sender, EventArgs e)
        {
            int source = int.Parse(txtTimSp.Text);
            SanPham kq = liSp.Find(sp => sp.Gia > source);
            if (kq != null)
            {
                MessageBox.Show("Ten: " + kq.Masp + "  \nGia: " + kq.Gia);
            }
            else MessageBox.Show("Khong  co");
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            int source = int.Parse(txtTimSp.Text);

            List< SanPham > kq = liSp.FindAll(sp => sp.Gia > source);
            listView1.Items.Clear();
            kq.ForEach(x =>
            {
                ListViewItem i = new ListViewItem((listView1.Items.Count + 1).ToString());
                i.SubItems.Add(x.Masp);
                i.SubItems.Add(x.Gia.ToString());
                listView1.Items.Add(i);
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int source = int.Parse(txtTimSp.Text);
            int firstIndex = liSp.FindIndex(x => x.Gia > source);
            MessageBox.Show(firstIndex.ToString());
        }

        private void btnFindLast_Click(object sender, EventArgs e)
        {
            int source = int.Parse(txtTimSp.Text);
            var  itemLast = liSp.FindLast(x => x.Gia > source);
            MessageBox.Show(itemLast.Masp + "----" + itemLast.Gia);
        }

        private void btnRemoAll_Click(object sender, EventArgs e)
        {
            int source = int.Parse(txtTimSp.Text);
            liSp.RemoveAll(x => x.Gia > source);
            

            listView1.Items.Clear();

            liSp.ForEach(x =>
            {
                ListViewItem i = new ListViewItem((listView1.Items.Count + 1).ToString());
                i.SubItems.Add(x.Masp);
                i.SubItems.Add(x.Gia.ToString());
                listView1.Items.Add(i);
            });
        }
    }
    public class SanPham
    {
        public string Masp { get; set; }
        public double Gia { get; set; }
    }
}
