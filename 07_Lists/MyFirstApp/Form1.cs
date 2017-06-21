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
            string[] names = { "Leandro", "Flávio" };
            int[] numbers = { 555, 666, 777 };
            //string[] names = new string[5];
            //names[0] = "Diego";
            string name = names[0];
            MessageBox.Show(name);
        }
    }
}
