﻿using System;
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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        String conString = "Data Source=Qadis\\SQLEXPRESS;Initial Catalog=projectDAM_PC_Store;Integrated Security=True;Encrypt=False";
        SqlConnection con = null;
        SqlDataAdapter adapter = null;


        private void Customer_Load(object sender, EventArgs e)
        {
            con=new SqlConnection(conString);
            String query = $"GetCustomerData"; 
            adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            con.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource= dt;
            con.Close();        
        }

        private void Update_Click(object sender, EventArgs e)
        {
            con= new SqlConnection(conString);   
        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            SearchByIDForm searchByIDForm = new SearchByIDForm();
            searchByIDForm.ShowDialog();
        }
    }
}
