using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnGeneric
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> dsList = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            Random rd = new Random();
            for(int i = 0; i<n; i++)
            {
                int x = rd.Next(100);
                dsList.Add(x);
            }
            listView1.Items.Clear();
            for(int i = 0; i < dsList.Count; i++)
            {
                listView1.Items.Add(dsList[i].ToString());
            }
        }
    }
}
