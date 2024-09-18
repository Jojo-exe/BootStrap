using Guna.UI2.Designer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamProject_PCStore
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private PCType prebuiltForm;
        private CustomPC customPC;
        private OrderDetails orderdDetails;
        private SearchByIDForm searchByIDForm;
        private Customer Customer;
        private Orders orders;
        private DisplayCustomerData display;

        private void preBuiltToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (prebuiltForm == null || prebuiltForm.IsDisposed)
            {
                prebuiltForm = new PCType();
                prebuiltForm.FormClosed += (object s, FormClosedEventArgs args) =>
                {
                    guna2PictureBox1.BringToFront();
                };
            }
            guna2PictureBox1.SendToBack();
            prebuiltForm.BringToFront();
            prebuiltForm.MdiParent = this;
            prebuiltForm.Show();
        }

        private void customBuiltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (customPC == null || customPC.IsDisposed)
            {
                customPC = new CustomPC();
                customPC.FormClosed += (object s, FormClosedEventArgs args) =>
                {
                    guna2PictureBox1.BringToFront();
                };
                guna2PictureBox1.SendToBack();
                customPC.BringToFront();
                customPC.MdiParent = this;
                customPC.Show();

            }
        }



        private void viewAllDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (orderdDetails == null || orderdDetails.IsDisposed)
            {
                orderdDetails = new OrderDetails();
                orderdDetails.FormClosed += (object s, FormClosedEventArgs args) =>
                {
                    guna2PictureBox1.BringToFront();
                };
                guna2PictureBox1.SendToBack();
                orderdDetails.BringToFront();
                orderdDetails.MdiParent = this;
                orderdDetails.Show();
            }

        }

        private void searchByIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (searchByIDForm == null || searchByIDForm.IsDisposed)
            {
                searchByIDForm = new SearchByIDForm(); ;
                searchByIDForm.Show();
            }

        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Customer == null || Customer.IsDisposed)
            {
                Customer = new Customer();
                Customer.FormClosed += (object s, FormClosedEventArgs args) =>
                {
                    guna2PictureBox1.BringToFront();
                };
                guna2PictureBox1.SendToBack();
                Customer.BringToFront();
                Customer.MdiParent = this;
                Customer.Show();
            }

        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Customer == null || Customer.IsDisposed)
            {
                Customer = new Customer();
                Customer.FormClosed += (object s, FormClosedEventArgs args) =>
                {
                    guna2PictureBox1.BringToFront();
                };
                guna2PictureBox1.SendToBack();
                Customer.BringToFront();
                Customer.MdiParent = this;
                Customer.Show();
            }
        }

        private void searchCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Customer == null || Customer.IsDisposed)
            {
                Customer = new Customer();
                Customer.FormClosed += (object s, FormClosedEventArgs args) =>
                {
                    guna2PictureBox1.BringToFront();
                };
                guna2PictureBox1.SendToBack();
                Customer.BringToFront();
                Customer.MdiParent = this;
                Customer.Show();
            }
        }

        private void updateOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (orders == null || orders.IsDisposed)
            {
                orders = new Orders();
                orders.FormClosed += (object s, FormClosedEventArgs args) =>
                {
                    guna2PictureBox1.BringToFront();
                };
                guna2PictureBox1.SendToBack();
                orders.BringToFront();
                orders.MdiParent = this;
                orders.Show();
            }
        }

        private void deleteOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (orders == null || orders.IsDisposed)
            {
                orders = new Orders();
                orders.FormClosed += (object s, FormClosedEventArgs args) =>
                {
                    guna2PictureBox1.BringToFront();
                };
                guna2PictureBox1.SendToBack();
                orders.BringToFront();
                orders.MdiParent = this;
                orders.Show();

            }
        }

        private void searchOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (orders == null || orders.IsDisposed)
            {
                orders = new Orders();
                orders.FormClosed += (object s, FormClosedEventArgs args) =>
                {
                    guna2PictureBox1.BringToFront();
                };
                guna2PictureBox1.SendToBack();
                orders.BringToFront();
                orders.MdiParent = this;
                orders.Show();

            }
        }

        private void displayDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (display == null || display.IsDisposed)
            {
                display = new DisplayCustomerData();
                display.FormClosed += (object s, FormClosedEventArgs args) =>
                {
                    guna2PictureBox1.BringToFront();
                };
                guna2PictureBox1.SendToBack();
                display.BringToFront();
                display.MdiParent = this;
                display.Show();

            }
        }
    }
}
