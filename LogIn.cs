using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;


namespace GmailMail_Sender
{
    public partial class LogIn : Form
    {
        // System.Net.Mail.MailMessage message=new MailMessage();
        // System.Net.Mail.SmtpClient smtp=new SmtpClient();
        
         public LogIn()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "varun" && textBox2.Text == "hello")
            {
                Menu f = new Menu();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\abcd.mdf;Integrated Security=True;Connect Timeout=30");
            //con.Open();

          //  string txtuser = textBox1.Text;
            //string txtpass = txt_Password.Text;

         //   string query = "SELECT * FROM dd WHERE User=@user AND Pass=@pass";
            //SqlCommand cmd = new SqlCommand("SELECT *FROM dd where user=" + textBox1.Text + " and pass='" + txt_Password.Text + "'", con);
         //   cmd.Parameters.Add(new SqlParameter("@user",txtuser));
          //  cmd.Parameters.Add(new SqlParameter("@pass",txtpass));
            
            
            //SqlDataReader dr = cmd.ExecuteReader();
            
            //if (dr.HasRows == true)
            //{
            //    Menu f = new Menu();
            //        f.Show();
            //        this.Hide();
            //}
            //else {
            //    MessageBox.Show("Invalid username or password");
            //}
            //if (textBox1.Text != "" & textBox2.Text != "")
            //{
            //    string queryText = "SELECT Count(*) FROM dd " +
            //                       "WHERE user = @Username AND pass = @Password";
            //    using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\abcd.mdf;Integrated Security=True;Connect Timeout=30"))
            //    using (SqlCommand cmd = new SqlCommand(queryText, cn))
            //    {
            //        cn.Open();
            //        cmd.Parameters.AddWithValue("@Username", textBox1.Text);  // cmd is SqlCommand 
            //        cmd.Parameters.AddWithValue("@Password", textBox2.Text);
            //        int result = (int)cmd.ExecuteScalar();
            //        if (result > 0)
            //            MessageBox.Show("Loggen In!");
            //        else
            //            MessageBox.Show("User Not Found!");
            //    }
            //}  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            signup b = new signup();
            b.Show();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

      
    }
}


