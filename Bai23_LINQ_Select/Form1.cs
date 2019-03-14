using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai23_LINQ_Select
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadSv();
            LoadListView();
        }
        List<SinhVien> lisSV = new List<SinhVien>();
        public void LoadSv()
        {
            lisSV.Add(new SinhVien()
            {
                MaSv = "1",
                TenSv = "1SDFSAD",
                SDT = "1FASDFASD",
                Email = "ASDFSADFSADF1",
                DiemTB = 12

            });
            lisSV.Add(new SinhVien()
            {
                MaSv = "2",
                TenSv = "132FDADSE",
                SDT = "1231",
                Email = "ASDFASDF1",
                DiemTB = 11

            });
            lisSV.Add(new SinhVien()
            {
                MaSv = "3",
                TenSv = "S1",
                SDT = "1FDF",
                Email = "1B",
                DiemTB = 11

            });
            lisSV.Add(new SinhVien()
            {
                MaSv = "4",
                TenSv = "1DFADS",
                SDT = "1SDFS",
                Email = "1SDFSD",
                DiemTB = 1.1

            });
            lisSV.Add(new SinhVien()
            {
                MaSv = "5",
                TenSv = "1DF",
                SDT = "B1",
                Email = "B A1",
                DiemTB = 18

            });
            lisSV.Add(new SinhVien()
            {
                MaSv = "6",
                TenSv = "1SDFA",
                SDT = "1231",
                Email = "ASD1",
                DiemTB = 1.0

            });


        }
        public void LoadListView()
        {
            lsv.Items.Clear();
            lisSV.ForEach(sv =>
            {
                ListViewItem i = new ListViewItem((lsv.Items.Count + 1).ToString());
                i.SubItems.Add(sv.MaSv);
                i.SubItems.Add(sv.TenSv);
                i.SubItems.Add(sv.SDT);
                i.SubItems.Add(sv.Email);
                i.SubItems.Add(sv.DiemTB.ToString());
                lsv.Items.Add(i);
            });
        }

        private void btnSelectMethod_Click(object sender, EventArgs e)
        {
            var ds = lisSV.Where(x=>x.DiemTB>5).Select(x => new { x.MaSv, x.TenSv });
            listBox1.DataSource = ds.ToList();
        }

        private void btnSelectQuery_Click(object sender, EventArgs e)
        {
            var ds = from c in lisSV
                     where c.DiemTB > 5
                     select new { c.MaSv, c.TenSv };
            listBox1.DataSource = ds.ToList();
        }
    }
}
