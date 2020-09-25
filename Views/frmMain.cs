using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace colegio2020media.Views
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            TimeStatusLabel.Text = DateTime.Now.ToLongTimeString().ToString();
        }

        private void frmMainClose(object sender, System.Windows.Forms.FormClosedEventArgs) 
        {
            try 
            {
                SqlConnection conn = new SqlConnection(@"Data Source=FAMILIAGARCAR\SQLEXPRESS;Initial Catalog=College;Integrated Security=True");
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();

                SqlDataReader dr1 = null;
                SqlCommand com = new SqlCommand();

                if (Program.frmState == "User") 
                {
                    com.CommandText = "select [UserId], [UserName] from ULogin where UserId = '" + Program.UserName + "'";
                    com.Connection = conn;
                }
            
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
