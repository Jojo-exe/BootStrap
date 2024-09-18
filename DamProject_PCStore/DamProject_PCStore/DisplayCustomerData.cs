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
using TheArtOfDevHtmlRenderer.Adapters;

namespace DamProject_PCStore
{
    
    public partial class DisplayCustomerData : Form
    {
        String conString = "Data Source=Qadis\\SQLEXPRESS;Initial Catalog=projectDAM_PC_Store;Integrated Security=True;Encrypt=False";
        SqlConnection con = null;
        SqlDataAdapter adapter = null;
        public DisplayCustomerData()
        {
            InitializeComponent();
        }

        private void DisplayCustomerData_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);
            String query = $"Select * from customer";
            adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            con.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
