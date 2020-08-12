namespace ASSIGNMENT5
{
    partial class ProductInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IDlabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ProductinfoGropubox = new System.Windows.Forms.GroupBox();
            this.ManyfacturerTextbox = new System.Windows.Forms.TextBox();
            this.Manufacturerlabel = new System.Windows.Forms.Label();
            this.CostTextbox = new System.Windows.Forms.TextBox();
            this.ModelTextbox = new System.Windows.Forms.TextBox();
            this.ScreenTextbox = new System.Windows.Forms.TextBox();
            this.Costlabel = new System.Windows.Forms.Label();
            this.Modellabel = new System.Windows.Forms.Label();
            this.Screensizelabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.ProductinfoGropubox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.undoToolStripMenuItem.Text = "Select Another Product";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(6, 48);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(76, 15);
            this.IDlabel.TabIndex = 1;
            this.IDlabel.Text = "Product ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 2;
            // 
            // ProductinfoGropubox
            // 
            this.ProductinfoGropubox.Controls.Add(this.ManyfacturerTextbox);
            this.ProductinfoGropubox.Controls.Add(this.Manufacturerlabel);
            this.ProductinfoGropubox.Controls.Add(this.CostTextbox);
            this.ProductinfoGropubox.Controls.Add(this.ModelTextbox);
            this.ProductinfoGropubox.Controls.Add(this.ScreenTextbox);
            this.ProductinfoGropubox.Controls.Add(this.Costlabel);
            this.ProductinfoGropubox.Controls.Add(this.Modellabel);
            this.ProductinfoGropubox.Controls.Add(this.Screensizelabel);
            this.ProductinfoGropubox.Controls.Add(this.IDlabel);
            this.ProductinfoGropubox.Controls.Add(this.textBox1);
            this.ProductinfoGropubox.Location = new System.Drawing.Point(39, 27);
            this.ProductinfoGropubox.Name = "ProductinfoGropubox";
            this.ProductinfoGropubox.Size = new System.Drawing.Size(713, 354);
            this.ProductinfoGropubox.TabIndex = 3;
            this.ProductinfoGropubox.TabStop = false;
            this.ProductinfoGropubox.Text = "Product Info";
            // 
            // ManyfacturerTextbox
            // 
            this.ManyfacturerTextbox.Location = new System.Drawing.Point(573, 109);
            this.ManyfacturerTextbox.Name = "ManyfacturerTextbox";
            this.ManyfacturerTextbox.ReadOnly = true;
            this.ManyfacturerTextbox.Size = new System.Drawing.Size(100, 25);
            this.ManyfacturerTextbox.TabIndex = 10;
            // 
            // Manufacturerlabel
            // 
            this.Manufacturerlabel.AutoSize = true;
            this.Manufacturerlabel.Location = new System.Drawing.Point(467, 112);
            this.Manufacturerlabel.Name = "Manufacturerlabel";
            this.Manufacturerlabel.Size = new System.Drawing.Size(91, 15);
            this.Manufacturerlabel.TabIndex = 9;
            this.Manufacturerlabel.Text = "Manufacturer";
            // 
            // CostTextbox
            // 
            this.CostTextbox.Location = new System.Drawing.Point(329, 48);
            this.CostTextbox.Name = "CostTextbox";
            this.CostTextbox.ReadOnly = true;
            this.CostTextbox.Size = new System.Drawing.Size(100, 25);
            this.CostTextbox.TabIndex = 8;
            // 
            // ModelTextbox
            // 
            this.ModelTextbox.Location = new System.Drawing.Point(99, 112);
            this.ModelTextbox.Name = "ModelTextbox";
            this.ModelTextbox.ReadOnly = true;
            this.ModelTextbox.Size = new System.Drawing.Size(100, 25);
            this.ModelTextbox.TabIndex = 7;
            // 
            // ScreenTextbox
            // 
            this.ScreenTextbox.Location = new System.Drawing.Point(329, 112);
            this.ScreenTextbox.Name = "ScreenTextbox";
            this.ScreenTextbox.ReadOnly = true;
            this.ScreenTextbox.Size = new System.Drawing.Size(100, 25);
            this.ScreenTextbox.TabIndex = 6;
            // 
            // Costlabel
            // 
            this.Costlabel.AutoSize = true;
            this.Costlabel.Location = new System.Drawing.Point(262, 51);
            this.Costlabel.Name = "Costlabel";
            this.Costlabel.Size = new System.Drawing.Size(38, 15);
            this.Costlabel.TabIndex = 5;
            this.Costlabel.Text = "Cost";
            // 
            // Modellabel
            // 
            this.Modellabel.AutoSize = true;
            this.Modellabel.Location = new System.Drawing.Point(6, 115);
            this.Modellabel.Name = "Modellabel";
            this.Modellabel.Size = new System.Drawing.Size(47, 15);
            this.Modellabel.TabIndex = 4;
            this.Modellabel.Text = "Model";
            // 
            // Screensizelabel
            // 
            this.Screensizelabel.AutoSize = true;
            this.Screensizelabel.Location = new System.Drawing.Point(241, 115);
            this.Screensizelabel.Name = "Screensizelabel";
            this.Screensizelabel.Size = new System.Drawing.Size(82, 15);
            this.Screensizelabel.TabIndex = 3;
            this.Screensizelabel.Text = "ScreenSize";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "Product";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "text files|*.txt|All Files|*.*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Click next to Confirm your selection";
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(509, 401);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(123, 37);
            this.Cancelbutton.TabIndex = 8;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(304, 401);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(181, 37);
            this.SelectButton.TabIndex = 9;
            this.SelectButton.Text = "Select Another Product";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(655, 401);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(97, 37);
            this.NextButton.TabIndex = 10;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProductinfoGropubox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductInfoForm";
            this.Activated += new System.EventHandler(this.ProductInfoForm_Load);
            this.Load += new System.EventHandler(this.ProductInfoForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ProductinfoGropubox.ResumeLayout(false);
            this.ProductinfoGropubox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox ProductinfoGropubox;
        private System.Windows.Forms.TextBox CostTextbox;
        private System.Windows.Forms.TextBox ModelTextbox;
        private System.Windows.Forms.TextBox ScreenTextbox;
        private System.Windows.Forms.Label Costlabel;
        private System.Windows.Forms.Label Modellabel;
        private System.Windows.Forms.Label Screensizelabel;
        private System.Windows.Forms.TextBox ManyfacturerTextbox;
        private System.Windows.Forms.Label Manufacturerlabel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}