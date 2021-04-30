using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace FinalProject
{
    public partial class AboutUS : Form
    {
        public AboutUS()
        {
            InitializeComponent();
        }

        private void AboutUS_Load(object sender, EventArgs e)
        {
            string path = @"C:\Users\USER\source\repos\FinalProject\FinalProject\Resources\About1.txt";
            StreamReader stream = new StreamReader(path);
            string filedata = stream.ReadToEnd();
            richTextBox1.Text = filedata.ToString();
            stream.Close();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
