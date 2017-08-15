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
            //message();
            //message("Hello Leandro");
            message("Hello Leandro", "Hello");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //message();
            //message("Hello Flávio");
            message("Hello Flávio", "Hello");
        }
        /*
        void message()
        {
            MessageBox.Show("Hello");
        }
        */
        /*void message(string message)
        {
            MessageBox.Show(message);
        }
        */
        void message(string message, string title)
        {
            MessageBox.Show(message);
        }
    }
}
