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
using Tulpep.NotificationWindow;

namespace FinalProject
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-LV212KEA;Initial Catalog=PLogin;Persist Security Info=True;User ID=sa;Password=Az429948@");
            string query = "Select *from Login Where username = '" + textBox1.Text.Trim() + "' and password = '" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                AdminPanel a3 = new AdminPanel();
                this.Hide();
                a3.Show();
            }
            else
            {
                //MessageBox.Show("Wrong password");
                PopupNotifier popup = new PopupNotifier();
                popup.TitleText = "Login";
                popup.ContentText = "Wrong User Name & Password";
                popup.Popup();

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void Admin_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
