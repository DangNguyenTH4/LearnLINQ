using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnonymousTypes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Student = new { Name = "Dang", ID = 1 };
            label1.Text = "Name: " + Student.Name;
            label2.Text = "ID " + Student.ID + "\nType: " + Student.GetType();
        }
    }
}
