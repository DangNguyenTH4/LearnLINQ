using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Khoi tao doi tuong, khong can khoi tao Contructor.
namespace ObjectInitializers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student s = new Student() { Name = "Dang", ID = "ID1" };
            MessageBox.Show("Name " + s.Name + "\nID " + s.ID);
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public string ID { get; set; }
    }
}
