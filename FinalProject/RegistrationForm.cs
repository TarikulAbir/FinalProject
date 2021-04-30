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
    public partial class RegistrationForm : Form
    {
        SqlConnection sq = new SqlConnection("Data Source=LAPTOP-LV212KEA;Initial Catalog=PLogin;Persist Security Info=True;User ID=sa;Password=Az429948@");
        private object dataGridView1;

        //void ShowMe()
        //{
        //    SqlCommand sC = new SqlCommand("select * from Information",sq);
        //    SqlDataAdapter sA = new SqlDataAdapter(sC);
        //    DataTable dT = new DataTable();
        //    sA.Fill(dT);
        //    dataGridView1 = dT;
        //  //  NewMethod(dT);
            
        
        //}
         
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sq.Open();
            SqlCommand sC = new SqlCommand("insert into Information values('" + tbName.Text + "','" + tbEmail.Text + "','" + tbAddress.Text + "','" + tbPhone.Text + "','" + tbExperience.Text + "')", sq);
            sC.ExecuteNonQuery();
            sq.Close();



            //MessageBox.Show("Successfully Registered");
            //Login l1 = new Login();
            //l1.Show();

            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "BE HAPPY";
            popup.ContentText = "Thank you";
            popup.Popup();


            //this.Hide();
            this.Hide();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f12 = new Form1();
            f12.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
