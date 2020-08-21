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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            IdTextbox.Text = Program.products.Id.ToString();

            CostTextbox.Text = Program.products.Cost.ToString();
            ManufactTextbox.Text = Program.products.Manufacturer.ToString();
            ModelTextbox.Text = Program.products.Model.ToString();
            ScreensizeTextbox.Text = Program.products.Screensize.ToString();

            PriceTextbox.Text = Program.products.Cost.ToString();

            decimal a = Program.products.Cost;
            decimal tax = a * 0.13m;
            decimal total = a + tax;
            TaxTextbox.Text = tax.ToString();
            TotalTextbox.Text = total.ToString();



        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
          DialogResult result=  MessageBox.Show("thanks him for his business  and advises him that his order will be processed in 7 - 10 business days");
           if(result==DialogResult.OK)
            {
                Application.Exit();

            }
           

        }
        
        private void BackButton_Click(object sender, EventArgs e)
        {

            Program.productInfoForm.Show();
            this.Hide();

        }

        private void CancleButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("his message is printing");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutBoxform.ShowDialog();
        }
    }
}
