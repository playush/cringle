﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PASSWORD_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NEYMARuk07\Documents\data.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From login where USERNAME='" + textBox1.Text + "' and PASSWORD='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString()=="1")
            {
                this.Hide();
                Form3 openform = new Form3();
                openform.Show();
            }
            else
            {
                MessageBox.Show("PLEASE CHECK THE DETAILS");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 openform = new Form2();
            openform.Show();
        }
    }
}
