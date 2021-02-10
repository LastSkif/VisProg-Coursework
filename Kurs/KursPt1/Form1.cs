using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursPt1
{
    public partial class Form1 : Form
    {
        const string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = D:/Учёба/ОВП/Билеты.mdb";
        public string s;
        public string rzd;
        public int l;
        public int start = 0;

        private OleDbConnection myConnetction;

        public Form1()
        {
            InitializeComponent();

            myConnetction = new OleDbConnection(connectionString);
            myConnetction.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s = "";
            for(int i = 0; i < 10; i++) {
                string q = "SELECT Вопрос FROM Questions WHERE Код = ";
                q += (l * 10 + i + 1).ToString();
                OleDbCommand command = new OleDbCommand(q, myConnetction);
                s += command.ExecuteScalar().ToString();
                s += "\n\n";
            }
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "билетыDataSet.Questions". При необходимости она может быть перемещена или удалена.
            this.questionsTableAdapter.Fill(this.билетыDataSet.Questions);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString(s, new Font("Arial", 13), Brushes.Black, 20, 100); ;  

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnetction.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            rzd = textBox1.Text;
            if (rzd == "1") l = 0;
            else if (rzd == "2") l = 1;
            else if (rzd == "3") l = 2;
            else
            { 
                l = 0;
            }
        }
    }
}
