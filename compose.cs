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
using System.Data.SqlClient;

namespace GmailMail_Sender
{
    public partial class compose : Form
    {
        public compose()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picpath = dlg.FileName.ToString();
                textBox6.Text = picpath;
            }
        }
        private void connect()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\abcd.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("INSERT INTO mail VALUES(@dates,@to,@sub,@body)", con);
            cmd.Parameters.AddWithValue("@dates", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@to", textBox3.Text);
            cmd.Parameters.AddWithValue("@sub", textBox4.Text);
            cmd.Parameters.AddWithValue("@body", textBox5.Text);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            //  MessageBox.Show(i.ToString());
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress(textBox1.Text);
                mail.To.Add(textBox3.Text);
                mail.Subject = textBox4.Text;
                mail.Body = textBox5.Text;
                if (textBox6.Text != "")
                {

                    System.Net.Mail.Attachment attachment;
                    attachment = new System.Net.Mail.Attachment(textBox6.Text);
                    mail.Attachments.Add(attachment);

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(textBox1.Text, textBox2.Text);
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    connect();
                    MessageBox.Show("mail Send");
                }
                else {
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(textBox1.Text, textBox2.Text);
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    connect();
                    MessageBox.Show("mail Send");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
