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
    public partial class AddTeacher : Form
    {

        SqlConnection sq = new SqlConnection("Data Source=LAPTOP-LV212KEA;Initial Catalog=PLogin;Persist Security Info=True;User ID=sa;Password=Az429948@");

        public AddTeacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sq.Open();
            SqlCommand sC = new SqlCommand("insert into TeacherList values('" + tbName1.Text + "','" + tbInstitution.Text + "','" + tbInterested.Text + "','" + tbExp.Text + "')", sq);
            sC.ExecuteNonQuery();
            sq.Close();

            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Insert";
            popup.ContentText = "Data Inserted successfully.";
            popup.Popup();


            this.Hide();

        }
    }
}
