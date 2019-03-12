using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai12_LazyLoading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var source = new List<string>() { "a", "b", "c", "d" };
            //Lazy loading, don't install really.
            var value = from c in source
                        select c;
            source.Add("F");
            //Really,query was executed here.
            foreach (var c in value)
                listBox1.Items.Add(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var source = new List<int>() { 1, 23, 4, 56, 6, 7, 8, 3, 345, 83 };
            var value = from c in source
                        where c % 2 == 0
                        select c;

            var value2 = (from c in source
                        where c % 2 == 0
                        select c).ToArray();

            source.Add(123);
            source.Add(124);
            source.Add(126);
            source.Add(128);
            //Let's see, what happening :) in 2 listbox
            listBox2.DataSource = value.ToArray();
            listBox3.DataSource = value2;


        }
    }
}
