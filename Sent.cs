﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GmailMail_Sender
{
    public partial class Sent : Form
    {
        public Sent()
        {
            InitializeComponent();
        }

        private void Sent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abcdDataSet.mail' table. You can move, or remove it, as needed.
            this.mailTableAdapter.Fill(this.abcdDataSet.mail);

        }
    }
}
