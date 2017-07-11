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
            /*
             for (int i = 0; i < 5; i++)
            {
                MessageBox.Show("Hello " + i.ToString());
            }
             */
            string[] names = { "Leandro", "Flávio", "Ana" };
            foreach (string s in names)
            {
                MessageBox.Show("Hello " + s);
            }
        }
    }
}
