using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamProject_PCStore
{
    public partial class OrderDetails : Form
    {
        public OrderDetails Instance { get; set; }
        public TextBox Cname;
        public OrderDetails()
        {
            InitializeComponent();
        }
        String conString = "Data Source=Qadis\\SQLEXPRESS;Initial Catalog=projectDAM_PC_Store;Integrated Security=True;Encrypt=False";
        SqlConnection con = null;
        SqlDataAdapter adapter = null;

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);
            adapter = new SqlDataAdapter("GetAllData", con);
            DataTable dt = new DataTable();
            con.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
