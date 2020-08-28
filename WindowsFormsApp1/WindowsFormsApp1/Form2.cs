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
using System.Linq.Expressions;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
              SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NEYMARuk07\Documents\data.mdf;Integrated Security=True;Connect Timeout=30;");
            string Query = "Insert into Login(USERNAME,PASSWORD) values('"+this.textBox1.Text+"','"+this.textBox2.Text+"')";
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader dr;
            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Singned up succesfully");
                while(dr.Read()) {}
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 openform = new Form1();
            openform.Show();
        }
    }
}
