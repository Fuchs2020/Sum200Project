﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sum200Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;

            for(int i=0; i<=200; i++)
            {
                sum += i;
                if (i == 100) txtHalfWay.Text = Convert.ToString(sum);
            }
            txtSum.Text = Convert.ToString(sum);
        }
    }
}
