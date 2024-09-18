using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace DamProject_PCStore
{
    public partial class PCType : Form
    {
        public static PCType Instance { get; private set; }

        public TextBox CustomerName;
        public TextBox Email;
        public TextBox PhoneNo;
        public TextBox Address;
        public TextBox City;
        public TextBox orderID;
        public DateTime Date;

        SqlConnection con;
        SqlCommand prebuilt;
        SqlCommand CustomerData;
        SqlCommand orders;
        String conString = $"Data Source=Qadis\\SQLEXPRESS;Initial Catalog=projectDAM_PC_Store;Integrated Security=True;Encrypt=False";

        public PCType()
        {
            InitializeComponent();
            Random random = new Random();
            int price = random.Next(5000, 30000) * 10;
            int orderid = random.Next(2, 2000);
            Instance=this;

        }
       
        private void PCType_Load(object sender, EventArgs e)
        {

            // First set
            CPUImage1.Text = "CPU: Ryzen 5 5600X";
            GPUImage1.Text = "GPU: RTX 2080TI";
            RAMImage1.Text = "RAM: 16GB DDR5";
            SrgImage1.Text = "Storage: EVO 1TB";

            // Second set
            CPUImage2.Text = "CPU: i7-11700K";
            GPUImage2.Text = "GPU: GTX 1080TI";
            RAMImage2.Text = "RAM: 32GB DDR4";
            SrgImage2.Text = "Storage: NVMe 512GB";

            // Third set
            CPUImage3.Text = "CPU: Ryzen 7 5800X";
            GPUImage3.Text = "GPU: RTX 3070";
            RAMImage3.Text = "RAM: 16GB DDR4";
            SrgImage3.Text = "Storage: HDD 2TB";

            // Fourth set
            CPUImage4.Text = "CPU: Ryzen 9 5900X";
            GPUImage4.Text = "GPU: RTX 3090";
            RAMImage4.Text = "RAM: 32GB DDR4";
            SrgImage4.Text = "Storage: SSD 1TB";

            // Fifth set
            CPUImage5.Text = "CPU: i9-11900K";
            GPUImage5.Text = "GPU: RTX 3080";
            RAMImage5.Text = "RAM: 64GB DDR4";
            SrgImage5.Text = "Storage: SSD 2TB";

            // Sixth set
            CPUImag6.Text = "CPU: Ryzen 5 3600";
            GPUImage6.Text = "GPU: GTX 1660";
            RAMImage6.Text = "RAM: 16GB DDR4";
            SrgImage6.Text = "Storage: HDD 1TB";

            // Seventh set
            CPUImage7.Text = "CPU: i5-10600K";
            GPUImage7.Text = "GPU: RTX 2060";
            RAMImage7.Text = "RAM: 16GB DDR4";
            SrgImage7.Text = "Storage: SSD 512GB";

            // Eighth set
            CPUImage8.Text = "CPU: Ryzen 7 3700X";
            GPUImage8.Text = "GPU: RTX 2080";
            RAMImage8.Text = "RAM: 32GB DDR4";
            SrgImage8.Text = "Storage: SSD 1TB";

            // Ninth set
            CPUImage9.Text = "CPU: i9-10900K";
            GPUImage9.Text = "GPU: RTX 3080TI";
            RAMImage9.Text = "RAM: 64GB DDR4";
            SrgImage9.Text = "Storage: NVMe 2TB";



        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            String cpu = CPUImage1.Text;
            String gpu = GPUImage1.Text;
            String ram= RAMImage1.Text;
            String Storage = SrgImage1.Text;
       
         

        }
        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            String cpu = CPUImage2.Text;
            String gpu = GPUImage2.Text;
            String ram = RAMImage2.Text;
            String Storage = SrgImage2.Text;
          

        }
        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            String cpu = CPUImage3.Text;
            String gpu = GPUImage3.Text;
            String ram = RAMImage3.Text;
            String Storage = SrgImage3.Text;
        
        }
        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            String cpu = CPUImage5.Text;
            String gpu = GPUImage5.Text;
            String ram = RAMImage5.Text;
            String Storage = SrgImage5.Text;
            

        }
        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            String cpu = CPUImag6.Text;
            String gpu = GPUImage6.Text;
            String ram = RAMImage6.Text;
            String Storage = SrgImage6.Text;
      
        }
        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {
            String cpu = CPUImage9.Text;
            String gpu = GPUImage9.Text;
            String ram = RAMImage9.Text;
            String Storage = SrgImage9.Text;
          

        }
        private void guna2PictureBox8_Click(object sender, EventArgs e)
        {
            String cpu = CPUImage8.Text;
            String gpu = GPUImage8.Text;
            String ram = RAMImage8.Text;
            String Storage = SrgImage8.Text;
         


        }
        private void guna2PictureBox9_Click(object sender, EventArgs e)
        {
            String cpu = CPUImage7.Text;
            String gpu = GPUImage7.Text;
            String ram = RAMImage7.Text;
            String Storage = SrgImage7.Text;
      
        }
        private void guna2PictureBox6_Click_1(object sender, EventArgs e)
        {
            String cpu = CPUImage4.Text;
            String gpu = GPUImage4.Text;
            String ram = RAMImage4.Text;
            String Storage = SrgImage4.Text;
       
        }


    }
}
