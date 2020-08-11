using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSIGNMENT5
{
    public partial class Splashform : Form
    {
        public Splashform()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Program.startform.Show();
            this.Hide();

            timer1.Enabled = false;
        }
    }
}
