﻿using System;
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
            string[] names = new string[2];

            //Simulating IndexOutRangeexception
            //string name = names[2];
            try
            {
                string name = names[2];
            }
            /*catch
            {
                MessageBox.Show("There was an error");
            }*/
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Your code is done!");
            }
        }
    }
}
