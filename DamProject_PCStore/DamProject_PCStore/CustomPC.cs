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
    public partial class CustomPC : Form
    {
        SqlConnection con;
        SqlCommand CustomerData;
        SqlCommand Orders;
        SqlCommand PCParts;
        String conString = $"Data Source=Qadis\\SQLEXPRESS;Initial Catalog=projectDAM_PC_Store;Integrated Security=True;Encrypt=False";
        public CustomPC()
        {
            InitializeComponent();

        }

        private void CustomPC_Load(object sender, EventArgs e)
        {
            List<string> cpuList = new List<string>()
        {
            "Intel Core i9-13900K",
            "AMD Ryzen 9 7950X",
            "Intel Core i7-13700K",
            "AMD Ryzen 7 7800X",
            "Intel Core i5-13600K"
        };

            List<string> gpuList = new List<string>()
        {
            "NVIDIA GeForce RTX 4090",
            "AMD Radeon RX 7900 XTX",
            "NVIDIA GeForce RTX 4080",
            "AMD Radeon RX 6800 XT",
            "NVIDIA GeForce RTX 4070 Ti"
        };

            List<string> ramList = new List<string>()
        {
            "Corsair Vengeance RGB Pro 32GB DDR4",
            "G.Skill Trident Z Neo 32GB DDR5",
            "Kingston Fury Beast 32GB DDR5",
            "Crucial Ballistix 16GB DDR4",
            "Teamgroup T-Force Delta RGB 16GB DDR4"
        };

            List<string> storageList = new List<string>()
        {
            "Samsung 980 Pro 1TB NVMe SSD",
            "WD Black SN850X 1TB NVMe SSD",
            "Crucial P5 Plus 1TB NVMe SSD",
            "Kingston A2000 1TB NVMe SSD",
            "Seagate Barracuda 2TB HDD"
        };

            List<string> motherboardList = new List<string>()
        {
            "ASUS ROG Strix Z790-E",
            "MSI MPG X670E Carbon",
            "Gigabyte Z790 Aorus Elite",
            "ASRock X670E Taichi",
            "MSI MAG B660M Mortar"
        };

            List<string> psuList = new List<string>()
        {
            "Corsair RM850x 850W",
            "EVGA SuperNOVA 750 G5 750W",
            "Seasonic Focus GX 850W",
            "Cooler Master MWE Gold 750W",
            "Thermaltake Toughpower GF1 850W"
        };

            List<string> caseList = new List<string>()
        {
            "NZXT H510 Flow",
            "Corsair iCUE 4000X RGB",
            "Fractal Design Meshify C",
            "Lian Li PC-O11 Dynamic",
            "Phanteks Eclipse P500A"
        };
                        cmbxCPU.DataSource = cpuList;
            cmbxGPU.DataSource = gpuList;
            cmbxRAM.DataSource = ramList;
            cmbxStorage.DataSource = storageList;
            cmbxMB.DataSource = motherboardList;
            cmbxPSU.DataSource = psuList;
            cmbxCase.DataSource = caseList;


            Random r = new Random();
            int orderId = r.Next(1, 1000);
            Order_ID.Text= orderId.ToString();
            

        }

        private void PlaceOrder_Click(object sender, EventArgs e)
        {
            String cname = txtboxCname.Text;
            String email = txtboxEmail.Text;
            String phone = txtboxPhone.Text;
            String address = txtboxAddress.Text;
            String city = txtboxCiti.Text;
            DateTime date = DateTime.Parse(DateOrder.Text);

            String cpu = cmbxCPU.SelectedItem.ToString();
            String gpu = cmbxGPU.SelectedItem.ToString();
            String ram = cmbxRAM.SelectedItem.ToString();
            String Storage = cmbxStorage.SelectedItem.ToString();
            String MB = cmbxMB.SelectedItem.ToString();
            String PSU = cmbxPSU.SelectedItem.ToString();
            String cases = cmbxCase.SelectedItem.ToString();

            Random random = new Random();
            int price = random.Next(500, 3000)*100;

            if (string.IsNullOrEmpty(cname) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(address) || string.IsNullOrEmpty(city))
            {
                MessageBox.Show("Please Enter All Your Info");
            }

            con = new SqlConnection(conString);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    CustomerData = new SqlCommand("InsertCustomer", con, transaction);
                    CustomerData.CommandType = CommandType.StoredProcedure;
                    CustomerData.Parameters.AddWithValue("@Cname", cname);
                    CustomerData.Parameters.AddWithValue("@Email", email);
                    CustomerData.Parameters.AddWithValue("@PhoneNum", phone);
                    CustomerData.Parameters.AddWithValue("@Address", address);
                    CustomerData.Parameters.AddWithValue("@City", city);
                    CustomerData.ExecuteNonQuery();

                    SqlCommand getCidCmd = new SqlCommand("SELECT TOP 1 cid FROM Customer ORDER BY cid DESC", con, transaction);
                    int customerId = (int)getCidCmd.ExecuteScalar();

                    PCParts = new SqlCommand("InsertPCParts", con, transaction);
                    PCParts.CommandType = CommandType.StoredProcedure;
                    PCParts.Parameters.AddWithValue("@CustomerId", customerId);
                    PCParts.Parameters.AddWithValue("@Cpu", cpu);
                    PCParts.Parameters.AddWithValue("@GPU", gpu);
                    PCParts.Parameters.AddWithValue("@RAM", ram);
                    PCParts.Parameters.AddWithValue("@Storage", Storage);
                    PCParts.Parameters.AddWithValue("@MotherBoard", MB);
                    PCParts.Parameters.AddWithValue("@PSU", PSU);
                    PCParts.Parameters.AddWithValue("@Cases", cases);
                    PCParts.ExecuteNonQuery();


                    Orders=new SqlCommand("InsertOrder",con, transaction);
                    Orders.CommandType = CommandType.StoredProcedure;
                    Orders.Parameters.AddWithValue("@OrderID", Order_ID.Text);
                    Orders.Parameters.AddWithValue("@CustomerID", customerId);
                    Orders.Parameters.AddWithValue("@OrderDate", date);
                    Orders.Parameters.AddWithValue("@TotalAmount", price);
                    Orders.ExecuteNonQuery();
                        


                    transaction.Commit();
                    MessageBox.Show("Order Placed");
                    CustomPC close = new CustomPC();
                    close.Close();
                    
  
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
