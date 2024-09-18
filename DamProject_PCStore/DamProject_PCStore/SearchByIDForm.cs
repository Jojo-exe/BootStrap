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
    public partial class SearchByIDForm : Form
    {
        public static SearchByIDForm Instance { get; set; }
        public TextBox Cname;
        public SearchByIDForm()
        {
            InitializeComponent();
        }

        private void X_Click(object sender, EventArgs e)
        {
            SearchByIDForm searchByIDForm = new SearchByIDForm();
            this.Close();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Instance.Cname = Cname;
        }
    }
}
