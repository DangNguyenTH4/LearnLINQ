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
        }
    }
}
