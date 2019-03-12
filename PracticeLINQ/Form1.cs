using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeLINQ
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.ChangeBackGroundColorButton();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int txt = textBox1.TextBoxToInt();
            List<int> li = txt.ListOfPrimeRange();
            listBox1.DataSource = li;
        }
    }
    public static class ExtensioMethod
    {
        public static bool IsPrime(this int n)
        {
            if (n == 0 || n == 1)
                return false;

            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static List<int> ListOfPrimeRange(this int n)
        {
            List<int> li = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (i.IsPrime())
                {
                    li.Add(i);
                }
            }
            return li;
        }

        public static int TextBoxToInt(this TextBox t)
        {
            int gi;
            int.TryParse(t.Text, out gi);
            return gi;
        }

        public static void ChangeBackGroundColorButton(this Button b)
        {
            b.MouseHover += B_MouseHover;
            b.MouseLeave += B_MouseLeave;
            //A button can have more than one Event click
            b.MouseClick += B_MouseClick;

            
        }

        private static void B_MouseClick(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            MessageBox.Show("Event Of ExtensionMethod");
        }

        private static void B_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
        }

        private static void B_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.SkyBlue;
            btn.ForeColor = Color.Red;

        }
    }

}
