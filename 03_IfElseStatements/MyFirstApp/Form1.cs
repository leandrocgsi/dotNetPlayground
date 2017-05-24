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
            if (!textBox1.Text.Equals("Leandro"))
            {
                MessageBox.Show("Hello");
            } else if (!textBox1.Text.Equals("Flávio"))
            {
                MessageBox.Show("Hello Flávio");
            } else 
            {
                MessageBox.Show("Hello Leandro");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
