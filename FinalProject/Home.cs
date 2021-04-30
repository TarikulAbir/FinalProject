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

namespace FinalProject
{
    public partial class Home : Form
    {
        
         //SqlConnection sq = new SqlConnection("Data Source=LAPTOP-LV212KEA;Initial Catalog=PLogin;Persist Security Info=True;User ID=sa;Password=Az429948@");
         

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
             
             
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel3a_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnTution_Click(object sender, EventArgs e)
        {
            panel3a.Controls.Clear();
            TList ap2 = new TList();
            ap2.Dock = DockStyle.Fill;
            ap2.TopLevel = false;
            ap2.TopMost = true;
            ap2.AutoScroll = true;
            ap2.FormBorderStyle = FormBorderStyle.None;
            this.panel3a.Controls.Add(ap2);
            ap2.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l4 = new Login();
            l4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3a.Controls.Clear();
            TeacherList ap21 = new TeacherList();
            ap21.Dock = DockStyle.Fill;
            ap21.TopLevel = false;
            ap21.TopMost = true;
            ap21.AutoScroll = true;
            ap21.FormBorderStyle = FormBorderStyle.None;
            this.panel3a.Controls.Add(ap21);
            ap21.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3a.Controls.Clear();
            AboutUS ap22 = new AboutUS();
            ap22.Dock = DockStyle.Fill;
            ap22.TopLevel = false;
            ap22.TopMost = true;
            ap22.AutoScroll = true;
            ap22.FormBorderStyle = FormBorderStyle.None;
            this.panel3a.Controls.Add(ap22);
            ap22.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
