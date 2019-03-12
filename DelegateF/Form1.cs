using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate int changeint(int x);
        public int Incre2(int x) { return x + 2; }
        public int DeIncre2(int x) { return x - 2; }

        private void button1_Click(object sender, EventArgs e)
        {
            changeint c = new changeint(Incre2);
            MessageBox.Show(c(20).ToString());
            c = new changeint(DeIncre2);
            MessageBox.Show(c(20).ToString());
        }
    }
}
