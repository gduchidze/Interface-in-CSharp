﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int x1 = int.Parse(textBox1.Text);
            Inter obj = new Inter(x1);
            int square = obj.square();
            int cube = obj.cube();
            label1.Text = "რიცხვის კვადრატი = " + square.ToString();
            label2.Text = "რიცხვის კუბი = " + cube.ToString();


        }
    }
}
