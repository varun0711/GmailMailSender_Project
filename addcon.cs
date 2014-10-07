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

namespace GmailMail_Sender
{
    public partial class addcon : Form
    {
        public static string Employeeid; SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\abcd.mdf;Integrated Security=True;Connect Timeout=30");
        public addcon()
        {
             
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            // inbox1 a = new inbox1();
            // DataGridView inbox1;
            //a.dataGridView1.Rows.Add("1", "XX");
            // DataGridView d = new DataGridView();
            //d.Rows.Add("1", "XX", "1", "XX", "1");
            //string empupdateid = textBox1.Text;

            try
            {
                connect();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        public void connect()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\abcd.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("INSERT INTO Table VALUES(@Name,@Email,@Phone,@Address,@Country)", con);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Email", textBox2.Text);
            cmd.Parameters.AddWithValue("@Phone", textBox3.Text);
            cmd.Parameters.AddWithValue("@Address", textBox5.Text);
            cmd.Parameters.AddWithValue("@Country", textBox4.Text);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show("Data Inserted");
            //  MessageBox.Show(i.ToString());
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
