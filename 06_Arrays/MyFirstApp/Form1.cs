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
            //int a = 5;
            //int b = 3;
            //MessageBox.Show((a + b).ToString());

            //int a = 5;
            //int b = 3;
            //MessageBox.Show((a - b).ToString());

            //int a = 5;
            //int b = 3;
            //MessageBox.Show((a * b).ToString());

            //int a = 5;
            //int b = 3;
            //MessageBox.Show((a / b).ToString());

            int a = 5;
            
            //add
            //a = a + 4;
            a += 4;
            MessageBox.Show(a.ToString());
        }
    }
}
