using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kevin
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Messages", typeof(String));

            dataGridView1.DataSource = table;
            dataGridView1.Columns["Messages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 315;
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            TitleTxt.Clear();
            MessageTxt.Clear();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            table.Rows.Add(TitleTxt.Text, MessageTxt.Text);
            TitleTxt.Clear();
            MessageTxt.Clear();
        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1);
            {
                TitleTxt.Text = table.Rows[index].ItemArray[0].ToString();
                MessageTxt.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }

        private void NewBtn_Click_1(object sender, EventArgs e)
        {
            TitleTxt.Clear();
            MessageTxt.Clear();
        }

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {
            table.Rows.Add(TitleTxt.Text, MessageTxt.Text);
            TitleTxt.Clear();
            MessageTxt.Clear();
        }

        private void ReadBtn_Click_1(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1) ;
            {
                TitleTxt.Text = table.Rows[index].ItemArray[0].ToString();
                MessageTxt.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }
    }
}
