using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LambdaExpressions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate int ChangeInt(int x);
        public int Tang2(int x) { return x + 2; }

        public delegate int Tong(int x, int y);
        private void button1_Click(object sender, EventArgs e)
        {
            ChangeInt d = new ChangeInt(Tang2);
            label1.Text = d(20).ToString();
            ChangeInt d2 = k => k + 2;
            label2.Text = d2(20).ToString();
            ChangeInt d2a = (int x) => x + 2;
            label3.Text = d2a(20).ToString();
            ChangeInt d3 = delegate (int x) { return (x + 2); };
            label4.Text = d3(20).ToString();
            Tong d5 = (x, y) => x + y;
            label5.Text = d5(20, 20).ToString();
            Tong d6 = new Tong((x, y) => x - y);
            label6.Text = d6(20, 10).ToString();
        }
    }
}
