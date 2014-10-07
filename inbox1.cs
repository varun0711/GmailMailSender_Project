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
    public partial class inbox1 : Form
    {
        public inbox1()
        {
            InitializeComponent();
        }

        private void inbox1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abcdDataSet7.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.abcdDataSet7.Table);
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //addcon a = new addcon();
            //a.Show();
            //this.dataGridView1.Rows.Add(textBox1.Text, textBox2.Text,textBox3.Text,textBox5.Text,textBox4.Text);
            //DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            //row.Cells[0].Value = textBox1.Text;
            //row.Cells[1].Value = textBox2.Text;
            //row.Cells[2].Value = textBox3.Text;
            //row.Cells[3].Value = textBox5.Text;
            //row.Cells[4].Value = textBox4.Text;

            //dataGridView1.Rows.Add(row);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
