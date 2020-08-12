using System;
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
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {

            

                textBox1.Text = Program.products.Id.ToString();
                CostTextbox.Text = Program.products.Cost.ToString();
                ManyfacturerTextbox.Text = Program.products.Manufacturer.ToString();
                ModelTextbox.Text = Program.products.Model.ToString();
                ScreenTextbox.Text = Program.products.Screensize.ToString();
            
            

            NextButton.Enabled = false;
            

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            var saveFileDialogResult = saveFileDialog1.ShowDialog();

            if (saveFileDialogResult != DialogResult.Cancel)
            {
                // create new stream
                StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);

                // write to the file

                streamWriter.WriteLine(Program.products.Id);
                streamWriter.WriteLine(Program.products.Cost);
                streamWriter.WriteLine(Program.products.Manufacturer);
                streamWriter.WriteLine(Program.products.Model);
                streamWriter.WriteLine(Program.products.Screensize);

                // clean up
                streamWriter.Flush();
                streamWriter.Close();

            }
            NextButton.Enabled = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();

            // open the file dialog
            var openFileDialogResult = openFileDialog1.ShowDialog();

            if (openFileDialogResult != DialogResult.Cancel)
            {
                // create a new stream reader
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);

                // read in the list

                while (!streamReader.EndOfStream)
                {
                   
                    
                 Program.products.Id =Convert.ToInt32( streamReader.ReadLine());
                    Program.products.Cost = Convert.ToDecimal(streamReader.ReadLine());
                    Program.products.Manufacturer= streamReader.ReadLine();
                    Program.products.Model = streamReader.ReadLine();
                    Program.products.Screensize= streamReader.ReadLine();
               
                   
                }

                // cleanup
                streamReader.Close();

                //chage textbox
                textBox1.Text = Program.products.Id.ToString();
                CostTextbox.Text = Program.products.Cost.ToString();
                ManyfacturerTextbox.Text = Program.products.Manufacturer.ToString();
                ModelTextbox.Text = Program.products.Model.ToString();
                ScreenTextbox.Text = Program.products.Screensize.ToString();




            }

            NextButton.Enabled = true;

        }

       
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            this.Hide();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            Program.selectform.Show();
            this.Hide();
        }
    }
}
