using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai14ForeachLINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> dsInt = new List<int>();
            Random rd = new Random();
            int n = textBox1.ToInt();
            for(int i = 0; i < n; i++)
            {
                dsInt.Add(rd.Next(100));
            }

            //Method 1
            //listBox1.DataSource = dsInt;

            listBox1.Items.Clear();

            //Method 2
            //foreach(int i in dsInt)
            //{
            //    listBox1.Items.Add(i);
            //}

            //Method 3 //Anonymous Method
            //dsInt.ForEach(x => 
            //{
            //    listBox1.Items.Add(x*100);
            //});

            //Method 4: Expixit Method
            dsInt.ForEach(x => AddItem(x));
        }
        public void AddItem(int x)
        {
            listBox1.Items.Add(x);
        }

        List<SanPham> dsSP = new List<SanPham>();
        private void btnLuu_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            //dsSP.Add(new SanPham() { TenSp = txtTenSp.Text, MaSp = txtMaSP.Text });
            SanPham sp = new SanPham() { TenSp = txtTenSp.Text, MaSp = txtMaSP.Text };
            dsSP.Add(sp);
            DisplaySanPham();


        }
        public void DisplaySanPham()
        {
            dsSP.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.MaSp);
                lvi.SubItems.Add(x.TenSp);
                listView1.Items.Add(lvi);
            });
        }
    }

    public class SanPham
    {
        public string TenSp { get; set; }
        public string MaSp { get; set; }
    }
    public static class ExtensionMethod
    {
        public static int ToInt(this TextBox t)
        {
            int x;
            int.TryParse(t.Text, out x);
            return x;
        }
    }
}
