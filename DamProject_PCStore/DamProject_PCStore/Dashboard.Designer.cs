namespace DamProject_PCStore
{
    partial class Dashboard
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
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAllDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pCTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preBuiltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customBuiltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.viewAToolStripMenuItem,
            this.pCTypeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(904, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateCustomerToolStripMenuItem,
            this.deleteCustomerToolStripMenuItem,
            this.searchCustomerToolStripMenuItem,
            this.displayDataToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // updateCustomerToolStripMenuItem
            // 
            this.updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            this.updateCustomerToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.updateCustomerToolStripMenuItem.Text = "Update Customer";
            this.updateCustomerToolStripMenuItem.Click += new System.EventHandler(this.updateCustomerToolStripMenuItem_Click);
            // 
            // deleteCustomerToolStripMenuItem
            // 
            this.deleteCustomerToolStripMenuItem.Name = "deleteCustomerToolStripMenuItem";
            this.deleteCustomerToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.deleteCustomerToolStripMenuItem.Text = "Delete Customer";
            this.deleteCustomerToolStripMenuItem.Click += new System.EventHandler(this.deleteCustomerToolStripMenuItem_Click);
            // 
            // searchCustomerToolStripMenuItem
            // 
            this.searchCustomerToolStripMenuItem.Name = "searchCustomerToolStripMenuItem";
            this.searchCustomerToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.searchCustomerToolStripMenuItem.Text = "Search Customer";
            this.searchCustomerToolStripMenuItem.Click += new System.EventHandler(this.searchCustomerToolStripMenuItem_Click);
            // 
            // displayDataToolStripMenuItem
            // 
            this.displayDataToolStripMenuItem.Name = "displayDataToolStripMenuItem";
            this.displayDataToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.displayDataToolStripMenuItem.Text = "Display Data ";
            this.displayDataToolStripMenuItem.Click += new System.EventHandler(this.displayDataToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateOrdersToolStripMenuItem,
            this.deleteOrdersToolStripMenuItem,
            this.searchOrdersToolStripMenuItem,
            this.displayAllDataToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // updateOrdersToolStripMenuItem
            // 
            this.updateOrdersToolStripMenuItem.Name = "updateOrdersToolStripMenuItem";
            this.updateOrdersToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.updateOrdersToolStripMenuItem.Text = "Update Orders";
            this.updateOrdersToolStripMenuItem.Click += new System.EventHandler(this.updateOrdersToolStripMenuItem_Click);
            // 
            // deleteOrdersToolStripMenuItem
            // 
            this.deleteOrdersToolStripMenuItem.Name = "deleteOrdersToolStripMenuItem";
            this.deleteOrdersToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.deleteOrdersToolStripMenuItem.Text = "Delete Orders";
            this.deleteOrdersToolStripMenuItem.Click += new System.EventHandler(this.deleteOrdersToolStripMenuItem_Click);
            // 
            // searchOrdersToolStripMenuItem
            // 
            this.searchOrdersToolStripMenuItem.Name = "searchOrdersToolStripMenuItem";
            this.searchOrdersToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.searchOrdersToolStripMenuItem.Text = "Search Orders";
            this.searchOrdersToolStripMenuItem.Click += new System.EventHandler(this.searchOrdersToolStripMenuItem_Click);
            // 
            // displayAllDataToolStripMenuItem
            // 
            this.displayAllDataToolStripMenuItem.Name = "displayAllDataToolStripMenuItem";
            this.displayAllDataToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.displayAllDataToolStripMenuItem.Text = "Display All Data";
            // 
            // viewAToolStripMenuItem
            // 
            this.viewAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllDetailsToolStripMenuItem,
            this.searchByIDToolStripMenuItem});
            this.viewAToolStripMenuItem.Name = "viewAToolStripMenuItem";
            this.viewAToolStripMenuItem.Size = new System.Drawing.Size(132, 29);
            this.viewAToolStripMenuItem.Text = "Order Details";
            // 
            // viewAllDetailsToolStripMenuItem
            // 
            this.viewAllDetailsToolStripMenuItem.Name = "viewAllDetailsToolStripMenuItem";
            this.viewAllDetailsToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            this.viewAllDetailsToolStripMenuItem.Text = "View All Details";
            this.viewAllDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewAllDetailsToolStripMenuItem_Click);
            // 
            // searchByIDToolStripMenuItem
            // 
            this.searchByIDToolStripMenuItem.Name = "searchByIDToolStripMenuItem";
            this.searchByIDToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            this.searchByIDToolStripMenuItem.Text = "Search By ID";
            this.searchByIDToolStripMenuItem.Click += new System.EventHandler(this.searchByIDToolStripMenuItem_Click);
            // 
            // pCTypeToolStripMenuItem
            // 
            this.pCTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preBuiltToolStripMenuItem,
            this.customBuiltToolStripMenuItem});
            this.pCTypeToolStripMenuItem.Name = "pCTypeToolStripMenuItem";
            this.pCTypeToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.pCTypeToolStripMenuItem.Text = "PC Type";
            // 
            // preBuiltToolStripMenuItem
            // 
            this.preBuiltToolStripMenuItem.Name = "preBuiltToolStripMenuItem";
            this.preBuiltToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.preBuiltToolStripMenuItem.Text = "Pre-Built";
            this.preBuiltToolStripMenuItem.Click += new System.EventHandler(this.preBuiltToolStripMenuItem_Click);
            // 
            // customBuiltToolStripMenuItem
            // 
            this.customBuiltToolStripMenuItem.Name = "customBuiltToolStripMenuItem";
            this.customBuiltToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.customBuiltToolStripMenuItem.Text = "Custom Built";
            this.customBuiltToolStripMenuItem.Click += new System.EventHandler(this.customBuiltToolStripMenuItem_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = global::DamProject_PCStore.Properties.Resources.pc_gaming_setup_rgb_4k_ft1ym37yjyb7lp19;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 33);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(904, 487);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 520);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAllDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pCTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preBuiltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customBuiltToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}