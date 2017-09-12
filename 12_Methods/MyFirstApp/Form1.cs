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
            message("Hello Leandro", "Hello");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            message("Hello Flávio", "Hello");
        }

        void message(string message, string title)
        {
            MessageBox.Show(message, title);
        }
    }
}
