using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string name = "Leandro da Costa";
            //MessageBox.Show("Hello C# - We are here! " + name, "Name Message Box");
            //int number = 5;
            //MessageBox.Show("Working with int! " + number.ToString(), "Number Message Box");
            //bool redHair = false;
            //MessageBox.Show("Working with bool! " + redHair.ToString(), "Bool Message Box");
            object myObject = true;
            MessageBox.Show("Working with object! " + myObject.ToString(), "Object Message Box");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
