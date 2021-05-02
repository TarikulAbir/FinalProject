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
    public partial class AdminPanel : Form
    {
      //  SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-LV212KEA;Initial Catalog=PLogin;Persist Security Info=True;User ID=sa;Password=Az429948@");
         

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void btnAppruve_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Appruve apc = new Appruve();
            apc.Dock = DockStyle.Fill;
            apc.TopLevel = false;
            apc.TopMost = true;
            apc.AutoScroll = true;
            apc.FormBorderStyle = FormBorderStyle.None;
            this.panel3.Controls.Add(apc);
            apc.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Add a1 = new Add();
            a1.Dock = DockStyle.Fill;
            a1.TopLevel = false;
            a1.TopMost = true;
            a1.AutoScroll = true;
            a1.FormBorderStyle = FormBorderStyle.None;
            
            this.panel3.Controls.Add(a1);
            
            a1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Login l1 = new Login();
            Admin_Login al = new Admin_Login();
            al.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            AddTeacher at = new AddTeacher();
            at.Dock = DockStyle.Fill;
            at.TopLevel = false;
            at.TopMost = true;
            at.AutoScroll = true;
            at.FormBorderStyle = FormBorderStyle.None;
            // this.pCoin.Controls.Add(a1);
            // this.panel2_Paint.Controls.Add(a1);
            this.panel3.Controls.Add(at);

            at.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            TeacherList at3 = new TeacherList();
            at3.Dock = DockStyle.Fill;
            at3.TopLevel = false;
            at3.TopMost = true;
            at3.AutoScroll = true;
            at3.FormBorderStyle = FormBorderStyle.None;
            // this.pCoin.Controls.Add(a1);
            // this.panel2_Paint.Controls.Add(a1);
            this.panel3.Controls.Add(at3);

            at3.Show();
        }
    }
}
