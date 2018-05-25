﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello World. Modified in Master";
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new SecondaryForm();
            f.Show();
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form3();
            f.Show();
        }
    }
}
