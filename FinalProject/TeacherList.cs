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
using System.Configuration;
namespace FinalProject
{
    public partial class TeacherList : Form
    {
    
        
        public TeacherList()
        {
            InitializeComponent();
        }
        
        private void TeacherList_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-LV212KEA;Initial Catalog=PLogin;Persist Security Info=True;User ID=sa;Password=Az429948@";
            string sql = "SELECT * FROM TeacherList";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();
            dataGridView2.DataSource = ds;
            dataGridView2.DataMember = "Authors_table";
        }

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }
    }
}
