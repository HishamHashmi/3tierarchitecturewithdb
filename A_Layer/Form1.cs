﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using B_LAYER;
namespace A_Layer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Facade f = Facade.getcontroller();
            string n = textBox1.Text;
            int a = Convert.ToInt32(textBox2.Text);
            MessageBox.Show(f.my_message(n, a));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
