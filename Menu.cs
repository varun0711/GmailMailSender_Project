using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using EAGetMail;

namespace GmailMail_Sender
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            compose a = new compose();

            a.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            LogIn b = new LogIn();
            b.Show();
            Sent c = new Sent();
            c.Close();
            compose a = new compose();
            a.Close();
            inbox1 d = new inbox1();
            d.Close();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sent c = new Sent();
            c.Show();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            inbox1 a = new inbox1();
            a.Show();
        }

    }
}