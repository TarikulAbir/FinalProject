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
    public partial class Login : Form
    {
         public Login()
        {
            InitializeComponent();
        }

         

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-LV212KEA;Initial Catalog=PLogin;Persist Security Info=True;User ID=sa;Password=Az429948@");
            string query = "Select *from Login Where username = '"+tbName.Text.Trim()+"' and password = '"+tbPassword.Text.Trim()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Home h3 = new Home();
                this.Hide();
                h3.Show();
            }
            else
            {
                // MessageBox.Show("Wrong password");
                PopupNotifier popup = new PopupNotifier();
                popup.TitleText = "Login";
                popup.ContentText = "Wrong User Name & Password";
                popup.Popup();


            }

        }
        private void Login_Load(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
