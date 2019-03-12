using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtensionMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int n = 2;
            //MessageBox.Show(n.Sum1ToN("n"));

            //string n = "hahaha";
            //int z = n.HashStringTo(10);
            //MessageBox.Show(z.Sum1ToN(n).ToString());

            //string s1 = "hahaha";
            //string s2 = "hehehe";
            //MessageBox.Show(s1.JoinString(s2));

            Student s1 = new Student { Name = "Dang", ID = "123" };
            MessageBox.Show(s1.ReturnStudentString("15"));

        }
    }
    public class Student
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public override string ToString()
        {
            return "Sinh vien " + Name + " co ma sinh vien la: " + ID;
        }
    }
    public static class ExtensionMT
    {
        public static string Sum1ToN(this int n,string a)
        {
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return a+"======="+sum;
        }
        public static int Sum1ToNReturnINT(this int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
        public static int HashStringTo(this string a,int n)
        {
            return n;
        }
        public static string JoinString(this string s1,string s2)
        {
            return s1 + "---" + s2;
        }
        public static string ReturnStudentString(this Student a, string classmate)
        {
            string z = a.ToString();
            return z + " hien nay dang hoc lop: " + classmate;
        }
        public static int GetINTvalueFromTxtBox(this TextBox a)
        {
            //return int.Parse(a.Text);

            int x = 0;
            int.TryParse(a.Text, out x);
            return x;
        }
    }
}
