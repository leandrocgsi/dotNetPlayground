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
            MessageBox.Show("Hello C# - We are here!", "My Message Box");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You are hovering your mouse over the button", "My Message Box");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
