using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Delegate_ExtensionMethod.ExtenstionMethod;

namespace Delegate_ExtensionMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region Just use Extension Method
            //listBox1.SelectedIndex = -1;
            //for (int i = 0; i < listBox1.Items.Count; i++)
            //{
            //    //method 1 : use extension method:
            //    int x = int.Parse(listBox1.Items[i].ToString());
            //    if (x.IsOddNumber())
            //    {
            //        listBox1.SelectedIndex = i;
            //    }
            //}
            #endregion
            #region Use Extension Method With Delegate In Anonymous Method
            listBox1.SelectItemsInListBox(x => x % 2 == 1);
            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            #region Just use Extension Method
            //listBox1.SelectedIndex = -1;
            //for (int i = 0; i < listBox1.Items.Count; i++)
            //{
            //    //method 1 : use extension method:
            //    int x = int.Parse(listBox1.Items[i].ToString());
            //    if (x.IsPrimeNumber())
            //    {
            //        listBox1.SelectedIndex = i;
            //    }
            //}
            #endregion
            #region Use Extension Method With Delegate In Anonymous Method (Lamda Epression)
            listBox1.SelectItemsInListBox(x => x.IsPrimeNumber());
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Just use Extension Method
            //listBox1.SelectedIndex = -1;
            //for(int i = 0; i < listBox1.Items.Count; i++)
            //{
            //    //method 1 : use extension method:
            //    int x = int.Parse(listBox1.Items[i].ToString());
            //    if (x.IsEvenNumber())
            //    {
            //        listBox1.SelectedIndex = i;
            //    }
            //}
            #endregion

            #region Use Extension Method With Delegate In Anonymous Method
            listBox1.SelectItemsInListBox(x => x % 2 == 0);
            #endregion
        }
        List<int> lis = new List<int>();
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            int n = 15;
            int m = 50;
            Random rd = new Random();
            for(int i = 0; i < n; i++)
            {
                //Use m.RandomINT() =>> Very much x result same as.
                //int x = m.RandomINT();
                int x = rd.Next(m);
                lis.Add(x);
            }
            listBox1.Items.Clear();
            listBox1.DataSource = lis;
        }
    }
    public static class ExtenstionMethod
    {
        public static int RandomINT(this int n)
        {
            Random x = new Random();
            return new Random().Next(n);
        }

        #region Just Use Extension Method
        public static bool IsEvenNumber(this int n)
        {
            return n % 2 == 0;
        }
        public static bool IsOddNumber(this int n)
        {
            return n % 2 == 1;
        }
        public static bool IsPrimeNumber(this int n)
        {
            bool ok = true;
            for(int i = 2; i < Math.Sqrt(n); i++)
            {
                if(n%i==0)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        #endregion
        public static void ChangeColorListBoxItem(this ListBox a,int indexed)
        {
        }

        public delegate bool WhatTypeNumber(int n);

        public static void SelectItemsInListBox(this ListBox lst, WhatTypeNumber whattype)
        {
            lst.SelectedIndex = -1;
            for(int i = 0;i < lst.Items.Count; i++)
            {
                int x = int.Parse(lst.Items[i].ToString());
                if (whattype(x))
                    lst.SelectedIndex = i;
            }
        }

    }
}
