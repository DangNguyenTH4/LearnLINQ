using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyntexLINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int[] arrData = { 2, 542, 234, 12, 3, 65, 76, 342 };
        private void button1_Click(object sender, EventArgs e)
        {
            var dsChan = from x in arrData
                         where x % 2 == 0
                         select x;
            LoadListBox(dsChan.ToArray());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dsLe = (from x in arrData
                        where x % 2 != 0
                        select x).OrderByDescending(x => x);
            LoadListBox(dsLe.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dsChan = arrData.Where(x => x % 2 == 0);
            LoadListBox(dsChan.ToArray());
        }

        private void LoadListBox(int[] arr)
        {
            listBox1.SelectedIndex = -1;
            listBox1.DataSource = arr;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
