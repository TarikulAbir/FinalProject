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
    public partial class TList : Form
    {
        public string ConfigurationMenager { get; private set; }

        public TList()
        {
            InitializeComponent();
        }

        private void TList1(object sender, EventArgs e)
        {

        }

        private void TList_Load(object sender, EventArgs e)
        {
            // dataGridView1.DataSource = GetEmployeesList();
            string connectionString = "Data Source=LAPTOP-LV212KEA;Initial Catalog=PLogin;Persist Security Info=True;User ID=sa;Password=Az429948@";
            string sql = "SELECT * FROM AddInfo";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Authors_table";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
