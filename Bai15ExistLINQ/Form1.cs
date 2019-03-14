using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai15ExistLINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> dsInt = new List<int>();

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            Random rd = new Random();
            dsInt.Clear();
            for(int i = 0; i < n; i++)
            {
                int x = rd.Next(100);
                dsInt.Add(x);
            }
            //listBox1.DataSource = dsInt;

            listBox1.Items.Clear();
            dsInt.ForEach(x => listBox1.Items.Add(x));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k = int.Parse(textBox2.Text);
            bool kq = dsInt.Exists(s => s == k);
            if (kq)
                MessageBox.Show("Co");
            else MessageBox.Show("khong co");
        }
        List<SanPham> li = new List<SanPham>();
        private void btnGiaLapData_Click(object sender, EventArgs e)
        {
            li.Add(new SanPham() { MaSp = "1", TenSp = "1" });
            li.Add(new SanPham() { MaSp = "2", TenSp = "2" });
            li.Add(new SanPham() { MaSp = "3", TenSp = "3" });
            li.Add(new SanPham() { MaSp = "4", TenSp = "4" });
            li.Add(new SanPham() { MaSp = "5", TenSp = "5" });
            li.Add(new SanPham() { MaSp = "6", TenSp = "6" });
            li.Add(new SanPham() { MaSp = "7", TenSp = "7" });
            li.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem((listView1.Items.Count + 1).ToString());
                lvi.SubItems.Add(x.MaSp);
                lvi.SubItems.Add(x.TenSp);
                listView1.Items.Add(lvi);
            });
        }

        private void btnTimSp_Click(object sender, EventArgs e)
        {

            bool kq = li.Exists(x => x.TenSp==(txtTimSp.Text));
            if (kq)
                MessageBox.Show("Co");
            else MessageBox.Show("Khong co");

        }
    }
    public class SanPham
    {
        public string TenSp { get; set; }
        public string MaSp { get; set; }
    }
}
