﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
            
		}

        private void comboBoxOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string operation = comboBoxOperation.Text;
        }

        public void TextBox3_TextChanged(object sender, EventArgs e)
		{
            string path = textBox3.Text;
		}

        private void ButtonDo_Click(object sender, EventArgs e)
        {
            
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
