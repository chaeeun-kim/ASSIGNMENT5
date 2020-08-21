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
        //load event handler
        private void OrderForm_Load(object sender, EventArgs e)
        {
            //assign the value of properties of product to the text properties of textbox

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
        //click event handler
        private void FinishButton_Click(object sender, EventArgs e)
        {
          DialogResult result=  MessageBox.Show("thanks him for his business  and advises him that his order will be processed in 7 - 10 business days");
           if(result==DialogResult.OK)
            {
                Application.Exit();

            }
           

        }
        //click event handler

        private void BackButton_Click(object sender, EventArgs e)
        {

            Program.productInfoForm.Show();
            this.Hide();

        }
        //click event handler

        private void CancleButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //click event handler
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("his message is printing");
        }
        //click event handler
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutBoxform.ShowDialog();
        }
    }
}
