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
    public partial class SelectForm : Form
    {
       


        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputerDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputerDataSet.Products);
            NextButton.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
            Program.productInfoForm.Show();
           
        }

        private void ProductDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
       
            
            
            Program.products.Id = Convert.ToInt32(ProductDataGridView.CurrentRow.Cells[0].Value);
            Program.products.Cost = Convert.ToDecimal(ProductDataGridView.CurrentRow.Cells[1].Value);
            Program.products.Manufacturer = Convert.ToString(ProductDataGridView.CurrentRow.Cells[2].Value);
            Program.products.Model = Convert.ToString(ProductDataGridView.CurrentRow.Cells[3].Value);
            Program.products.Screensize = Convert.ToString(ProductDataGridView.CurrentRow.Cells[4].Value);

            

            textBox1.Text = ProductDataGridView.CurrentRow.Cells[2].Value.ToString()
           +" "+ ProductDataGridView.CurrentRow.Cells[3].Value.ToString() + " price at:"+ ProductDataGridView.CurrentRow.Cells[1].Value.ToString();

            NextButton.Enabled = true;




        }

    }
}
