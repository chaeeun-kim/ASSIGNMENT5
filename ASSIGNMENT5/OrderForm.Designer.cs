namespace ASSIGNMENT5
{
    partial class OrderForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SystemgroupBox = new System.Windows.Forms.GroupBox();
            this.CostTextbox = new System.Windows.Forms.TextBox();
            this.ScreensizeTextbox = new System.Windows.Forms.TextBox();
            this.ModelTextbox = new System.Windows.Forms.TextBox();
            this.ManufactTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IdTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PricegroupBox = new System.Windows.Forms.GroupBox();
            this.PriceTextbox = new System.Windows.Forms.TextBox();
            this.TaxTextbox = new System.Windows.Forms.TextBox();
            this.TotalTextbox = new System.Windows.Forms.TextBox();
            this.TOTAL = new System.Windows.Forms.Label();
            this.TAX = new System.Windows.Forms.Label();
            this.PRICE = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComputerPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.SystemgroupBox.SuspendLayout();
            this.PricegroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SystemgroupBox
            // 
            this.SystemgroupBox.Controls.Add(this.CostTextbox);
            this.SystemgroupBox.Controls.Add(this.ScreensizeTextbox);
            this.SystemgroupBox.Controls.Add(this.ModelTextbox);
            this.SystemgroupBox.Controls.Add(this.ManufactTextbox);
            this.SystemgroupBox.Controls.Add(this.label5);
            this.SystemgroupBox.Controls.Add(this.label4);
            this.SystemgroupBox.Controls.Add(this.label3);
            this.SystemgroupBox.Controls.Add(this.label2);
            this.SystemgroupBox.Controls.Add(this.IdTextbox);
            this.SystemgroupBox.Controls.Add(this.label1);
            this.SystemgroupBox.Location = new System.Drawing.Point(12, 37);
            this.SystemgroupBox.Name = "SystemgroupBox";
            this.SystemgroupBox.Size = new System.Drawing.Size(345, 332);
            this.SystemgroupBox.TabIndex = 2;
            this.SystemgroupBox.TabStop = false;
            this.SystemgroupBox.Text = "System Component";
            // 
            // CostTextbox
            // 
            this.CostTextbox.Location = new System.Drawing.Point(133, 115);
            this.CostTextbox.Name = "CostTextbox";
            this.CostTextbox.ReadOnly = true;
            this.CostTextbox.Size = new System.Drawing.Size(170, 25);
            this.CostTextbox.TabIndex = 9;
            // 
            // ScreensizeTextbox
            // 
            this.ScreensizeTextbox.Location = new System.Drawing.Point(133, 281);
            this.ScreensizeTextbox.Name = "ScreensizeTextbox";
            this.ScreensizeTextbox.ReadOnly = true;
            this.ScreensizeTextbox.Size = new System.Drawing.Size(170, 25);
            this.ScreensizeTextbox.TabIndex = 8;
            // 
            // ModelTextbox
            // 
            this.ModelTextbox.Location = new System.Drawing.Point(133, 229);
            this.ModelTextbox.Name = "ModelTextbox";
            this.ModelTextbox.ReadOnly = true;
            this.ModelTextbox.Size = new System.Drawing.Size(170, 25);
            this.ModelTextbox.TabIndex = 7;
            // 
            // ManufactTextbox
            // 
            this.ManufactTextbox.Location = new System.Drawing.Point(133, 170);
            this.ManufactTextbox.Name = "ManufactTextbox";
            this.ManufactTextbox.ReadOnly = true;
            this.ManufactTextbox.Size = new System.Drawing.Size(170, 25);
            this.ManufactTextbox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "SCREEN SIZE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "MODEL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "MANUFACTURER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "COST";
            // 
            // IdTextbox
            // 
            this.IdTextbox.Location = new System.Drawing.Point(133, 55);
            this.IdTextbox.Name = "IdTextbox";
            this.IdTextbox.ReadOnly = true;
            this.IdTextbox.Size = new System.Drawing.Size(170, 25);
            this.IdTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCT ID";
            // 
            // PricegroupBox
            // 
            this.PricegroupBox.Controls.Add(this.PriceTextbox);
            this.PricegroupBox.Controls.Add(this.TaxTextbox);
            this.PricegroupBox.Controls.Add(this.TotalTextbox);
            this.PricegroupBox.Controls.Add(this.TOTAL);
            this.PricegroupBox.Controls.Add(this.TAX);
            this.PricegroupBox.Controls.Add(this.PRICE);
            this.PricegroupBox.Location = new System.Drawing.Point(437, 207);
            this.PricegroupBox.Name = "PricegroupBox";
            this.PricegroupBox.Size = new System.Drawing.Size(318, 162);
            this.PricegroupBox.TabIndex = 3;
            this.PricegroupBox.TabStop = false;
            this.PricegroupBox.Text = "Your Price";
            // 
            // PriceTextbox
            // 
            this.PriceTextbox.Location = new System.Drawing.Point(126, 18);
            this.PriceTextbox.Name = "PriceTextbox";
            this.PriceTextbox.ReadOnly = true;
            this.PriceTextbox.Size = new System.Drawing.Size(170, 25);
            this.PriceTextbox.TabIndex = 4;
            // 
            // TaxTextbox
            // 
            this.TaxTextbox.Location = new System.Drawing.Point(126, 62);
            this.TaxTextbox.Name = "TaxTextbox";
            this.TaxTextbox.ReadOnly = true;
            this.TaxTextbox.Size = new System.Drawing.Size(170, 25);
            this.TaxTextbox.TabIndex = 5;
            // 
            // TotalTextbox
            // 
            this.TotalTextbox.Location = new System.Drawing.Point(126, 122);
            this.TotalTextbox.Name = "TotalTextbox";
            this.TotalTextbox.ReadOnly = true;
            this.TotalTextbox.Size = new System.Drawing.Size(170, 25);
            this.TotalTextbox.TabIndex = 6;
            // 
            // TOTAL
            // 
            this.TOTAL.AutoSize = true;
            this.TOTAL.Location = new System.Drawing.Point(6, 129);
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Size = new System.Drawing.Size(52, 15);
            this.TOTAL.TabIndex = 2;
            this.TOTAL.Text = "TOTAL";
            // 
            // TAX
            // 
            this.TAX.AutoSize = true;
            this.TAX.Location = new System.Drawing.Point(-3, 65);
            this.TAX.Name = "TAX";
            this.TAX.Size = new System.Drawing.Size(128, 15);
            this.TAX.TabIndex = 1;
            this.TAX.Text = "SALES TAX (13%)";
            // 
            // PRICE
            // 
            this.PRICE.AutoSize = true;
            this.PRICE.Location = new System.Drawing.Point(3, 21);
            this.PRICE.Name = "PRICE";
            this.PRICE.Size = new System.Drawing.Size(49, 15);
            this.PRICE.TabIndex = 0;
            this.PRICE.Text = "PRICE";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(456, 396);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(542, 396);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(635, 396);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(75, 23);
            this.FinishButton.TabIndex = 6;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // BackToolStripMenuItem
            // 
            this.BackToolStripMenuItem.Name = "BackToolStripMenuItem";
            this.BackToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.BackToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.BackToolStripMenuItem.Text = "&Back";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(221, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ComputerPictureBox
            // 
            this.ComputerPictureBox.Image = global::ASSIGNMENT5.Properties.Resources.OIP1;
            this.ComputerPictureBox.Location = new System.Drawing.Point(542, 65);
            this.ComputerPictureBox.Name = "ComputerPictureBox";
            this.ComputerPictureBox.Size = new System.Drawing.Size(98, 102);
            this.ComputerPictureBox.TabIndex = 0;
            this.ComputerPictureBox.TabStop = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ComputerPictureBox);
            this.Controls.Add(this.PricegroupBox);
            this.Controls.Add(this.SystemgroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SystemgroupBox.ResumeLayout(false);
            this.SystemgroupBox.PerformLayout();
            this.PricegroupBox.ResumeLayout(false);
            this.PricegroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox SystemgroupBox;
        private System.Windows.Forms.GroupBox PricegroupBox;
        private System.Windows.Forms.TextBox CostTextbox;
        private System.Windows.Forms.TextBox ScreensizeTextbox;
        private System.Windows.Forms.TextBox ModelTextbox;
        private System.Windows.Forms.TextBox ManufactTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PriceTextbox;
        private System.Windows.Forms.TextBox TaxTextbox;
        private System.Windows.Forms.TextBox TotalTextbox;
        private System.Windows.Forms.Label TOTAL;
        private System.Windows.Forms.Label TAX;
        private System.Windows.Forms.Label PRICE;
        private System.Windows.Forms.PictureBox ComputerPictureBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}