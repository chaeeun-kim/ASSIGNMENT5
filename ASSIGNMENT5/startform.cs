﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSIGNMENT5
{
    public partial class startform : Form
    {
        public startform()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
           
            Program.selectform.Show();
            this.Hide();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            
            Program.productInfoForm.Show();
            this.Hide();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
