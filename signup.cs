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
using System.Data.SqlServerCe;
using System.Net.Mail;

using System.Collections;

namespace GmailMail_Sender
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\abcd.mdf;Integrated Security=True;Connect Timeout=30");
            //con.ConnectionString = @"Data Source=abcd.mdf";
            SqlCommand cmd = new SqlCommand("INSERT INTO dd VALUES(@user,@pass,@email)", con);
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);
            cmd.Parameters.AddWithValue("@email", textBox3.Text);
           // cmd.Parameters.AddWithValue("@body", textBox2.Text);
           con.Open();
            
            
            if (cmd.ExecuteNonQuery() > 0)
            { 
            MessageBox.Show("signed up");

            }
            else
            {
                MessageBox.Show("not signed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
