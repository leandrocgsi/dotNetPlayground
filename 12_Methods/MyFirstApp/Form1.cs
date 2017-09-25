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
            //MessageBox.Show(myMethod("Leandro"));
            //MessageBox.Show(myMethod(1).ToString());
            MessageBox.Show(myMethod(true).ToString());
        }

        string myMethod(string name)
        {
            return "Hello " + name;
        }

        int myMethod(int number)
        {
            return number;
        }

        bool myMethod(bool value)
        {
            return value;
        }
    }
}
