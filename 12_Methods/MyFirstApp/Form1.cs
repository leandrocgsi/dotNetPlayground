using System;
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
            myMethod("Leandro");
        }

        string myMethod(string name)
        {
            return name;
        }
    }
}
