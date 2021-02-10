using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.ExceptionServices;

namespace KursPt2
{
    public partial class Form1 : Form
    {
        const string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = D:/Учёба/ОВП/Тест.mdb";
        public string s;

        private OleDbConnection myConnetction;

        int n = 0, a = 0, si = 0;

        public Form1()
        {
            InitializeComponent();

            myConnetction = new OleDbConnection(connectionString);
            myConnetction.Open();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "тестDataSet.Answers". При необходимости она может быть перемещена или удалена.
            this.answersTableAdapter.Fill(this.тестDataSet.Answers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "тестDataSet.Questions". При необходимости она может быть перемещена или удалена.
            this.questionsTableAdapter.Fill(this.тестDataSet.Questions);

        }

        private void button_True_Answers_Click(object sender, EventArgs e)
        {
            s = "";
            string iz;
            for (int i = 1; i < 21; i++)
            {
                iz = i.ToString();
                string q = "SELECT Вопрос FROM Questions WHERE Код = ";
                q += iz;
                OleDbCommand questcommand = new OleDbCommand(q, myConnetction);
                s += questcommand.ExecuteScalar().ToString();
                s += "\n                    ";
                string z = "SELECT Верный_ответ FROM Answers WHERE Код_вопроса = ";
                z += iz;
                OleDbCommand anscommand = new OleDbCommand(z, myConnetction);
                s += anscommand.ExecuteScalar().ToString();
                s += "\n\n";
            }
            richTextBox1.Text = s;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnetction.Close();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            s = "";
            richTextBox1.Text = s;
        }

        private void textBox_Questions_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Questions.Text == "") n = 0;
            else n = Convert.ToInt32(textBox_Questions.Text);
        }

        private void textBox_Answers_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Answers.Text == "") a = 0;
            else
                a = Convert.ToInt32(textBox_Answers.Text); 
        }

        private void button_Test_Create_Manual_Click(object sender, EventArgs e)
        {
            si = 0;
            s = "";
            if (checkBox1.Checked)
            {
                string q = "SELECT Вопрос FROM Questions WHERE Код = 1";
                OleDbCommand questcommand = new OleDbCommand(q, myConnetction);
                s += questcommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string A = "SELECT Ответ_А FROM Answers WHERE Код_вопроса = 1";
                OleDbCommand Acommand = new OleDbCommand(A, myConnetction);
                s += Acommand.ExecuteScalar().ToString();
                s += "                       ";

                string C = "SELECT Ответ_В FROM Answers WHERE Код_вопроса = 1";
                OleDbCommand Ccommand = new OleDbCommand(C, myConnetction);
                s += Ccommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string B = "SELECT Ответ_Б FROM Answers WHERE Код_вопроса = 1";
                OleDbCommand Bcommand = new OleDbCommand(B, myConnetction);
                s += Bcommand.ExecuteScalar().ToString();
                s += "                       ";

                string D = "SELECT Ответ_Г FROM Answers WHERE Код_вопроса = 1";
                OleDbCommand Dcommand = new OleDbCommand(D, myConnetction);
                s += Dcommand.ExecuteScalar().ToString();
                s += "\n\n";
            }
            if (checkBox2.Checked)
            {
                string q = "SELECT Вопрос FROM Questions WHERE Код = 2";
                OleDbCommand questcommand = new OleDbCommand(q, myConnetction);
                s += questcommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string A = "SELECT Ответ_А FROM Answers WHERE Код_вопроса = 2";
                OleDbCommand Acommand = new OleDbCommand(A, myConnetction);
                s += Acommand.ExecuteScalar().ToString();
                s += "                       ";

                string C = "SELECT Ответ_В FROM Answers WHERE Код_вопроса = 2";
                OleDbCommand Ccommand = new OleDbCommand(C, myConnetction);
                s += Ccommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string B = "SELECT Ответ_Б FROM Answers WHERE Код_вопроса = 2";
                OleDbCommand Bcommand = new OleDbCommand(B, myConnetction);
                s += Bcommand.ExecuteScalar().ToString();
                s += "                       ";

                string D = "SELECT Ответ_Г FROM Answers WHERE Код_вопроса = 2";
                OleDbCommand Dcommand = new OleDbCommand(D, myConnetction);
                s += Dcommand.ExecuteScalar().ToString();
                s += "\n\n";
            }
            if (checkBox3.Checked)
            {
                string q = "SELECT Вопрос FROM Questions WHERE Код = 3";
                OleDbCommand questcommand = new OleDbCommand(q, myConnetction);
                s += questcommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string A = "SELECT Ответ_А FROM Answers WHERE Код_вопроса = 3";
                OleDbCommand Acommand = new OleDbCommand(A, myConnetction);
                s += Acommand.ExecuteScalar().ToString();
                s += "                       ";

                string C = "SELECT Ответ_В FROM Answers WHERE Код_вопроса = 3";
                OleDbCommand Ccommand = new OleDbCommand(C, myConnetction);
                s += Ccommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string B = "SELECT Ответ_Б FROM Answers WHERE Код_вопроса = 3";
                OleDbCommand Bcommand = new OleDbCommand(B, myConnetction);
                s += Bcommand.ExecuteScalar().ToString();
                s += "                       ";

                string D = "SELECT Ответ_Г FROM Answers WHERE Код_вопроса = 3";
                OleDbCommand Dcommand = new OleDbCommand(D, myConnetction);
                s += Dcommand.ExecuteScalar().ToString();
                s += "\n\n";
            }
            if (checkBox4.Checked)
            {
                string q = "SELECT Вопрос FROM Questions WHERE Код = 4";
                OleDbCommand questcommand = new OleDbCommand(q, myConnetction);
                s += questcommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string A = "SELECT Ответ_А FROM Answers WHERE Код_вопроса = 4";
                OleDbCommand Acommand = new OleDbCommand(A, myConnetction);
                s += Acommand.ExecuteScalar().ToString();
                s += "                       ";

                string C = "SELECT Ответ_В FROM Answers WHERE Код_вопроса = 4";
                OleDbCommand Ccommand = new OleDbCommand(C, myConnetction);
                s += Ccommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string B = "SELECT Ответ_Б FROM Answers WHERE Код_вопроса = 4";
                OleDbCommand Bcommand = new OleDbCommand(B, myConnetction);
                s += Bcommand.ExecuteScalar().ToString();
                s += "                       ";

                string D = "SELECT Ответ_Г FROM Answers WHERE Код_вопроса = 4";
                OleDbCommand Dcommand = new OleDbCommand(D, myConnetction);
                s += Dcommand.ExecuteScalar().ToString();
                s += "\n\n";
            }
            if (checkBox5.Checked)
            {
                string q = "SELECT Вопрос FROM Questions WHERE Код = 5";
                OleDbCommand questcommand = new OleDbCommand(q, myConnetction);
                s += questcommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string A = "SELECT Ответ_А FROM Answers WHERE Код_вопроса = 5";
                OleDbCommand Acommand = new OleDbCommand(A, myConnetction);
                s += Acommand.ExecuteScalar().ToString();
                s += "                       ";

                string C = "SELECT Ответ_В FROM Answers WHERE Код_вопроса = 5";
                OleDbCommand Ccommand = new OleDbCommand(C, myConnetction);
                s += Ccommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string B = "SELECT Ответ_Б FROM Answers WHERE Код_вопроса = 5";
                OleDbCommand Bcommand = new OleDbCommand(B, myConnetction);
                s += Bcommand.ExecuteScalar().ToString();
                s += "                       ";

                string D = "SELECT Ответ_Г FROM Answers WHERE Код_вопроса = 5";
                OleDbCommand Dcommand = new OleDbCommand(D, myConnetction);
                s += Dcommand.ExecuteScalar().ToString();
                s += "\n\n";
            }
            if (checkBox6.Checked)
            {
                string q = "SELECT Вопрос FROM Questions WHERE Код = 6";
                OleDbCommand questcommand = new OleDbCommand(q, myConnetction);
                s += questcommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string A = "SELECT Ответ_А FROM Answers WHERE Код_вопроса = 6";
                OleDbCommand Acommand = new OleDbCommand(A, myConnetction);
                s += Acommand.ExecuteScalar().ToString();
                s += "                       ";

                string C = "SELECT Ответ_В FROM Answers WHERE Код_вопроса = 6";
                OleDbCommand Ccommand = new OleDbCommand(C, myConnetction);
                s += Ccommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string B = "SELECT Ответ_Б FROM Answers WHERE Код_вопроса = 6";
                OleDbCommand Bcommand = new OleDbCommand(B, myConnetction);
                s += Bcommand.ExecuteScalar().ToString();
                s += "                       ";

                string D = "SELECT Ответ_Г FROM Answers WHERE Код_вопроса = 6";
                OleDbCommand Dcommand = new OleDbCommand(D, myConnetction);
                s += Dcommand.ExecuteScalar().ToString();
                s += "\n\n";
            }
            if (checkBox7.Checked)
            {
                string q = "SELECT Вопрос FROM Questions WHERE Код = 7";
                OleDbCommand questcommand = new OleDbCommand(q, myConnetction);
                s += questcommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string A = "SELECT Ответ_А FROM Answers WHERE Код_вопроса = 7";
                OleDbCommand Acommand = new OleDbCommand(A, myConnetction);
                s += Acommand.ExecuteScalar().ToString();
                s += "                       ";

                string C = "SELECT Ответ_В FROM Answers WHERE Код_вопроса = 7";
                OleDbCommand Ccommand = new OleDbCommand(C, myConnetction);
                s += Ccommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string B = "SELECT Ответ_Б FROM Answers WHERE Код_вопроса = 7";
                OleDbCommand Bcommand = new OleDbCommand(B, myConnetction);
                s += Bcommand.ExecuteScalar().ToString();
                s += "                       ";

                string D = "SELECT Ответ_Г FROM Answers WHERE Код_вопроса = 7";
                OleDbCommand Dcommand = new OleDbCommand(D, myConnetction);
                s += Dcommand.ExecuteScalar().ToString();
                s += "\n\n";
            }
            if (checkBox8.Checked)
            {
                string q = "SELECT Вопрос FROM Questions WHERE Код = 8";
                OleDbCommand questcommand = new OleDbCommand(q, myConnetction);
                s += questcommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string A = "SELECT Ответ_А FROM Answers WHERE Код_вопроса = 8";
                OleDbCommand Acommand = new OleDbCommand(A, myConnetction);
                s += Acommand.ExecuteScalar().ToString();
                s += "                       ";

                string C = "SELECT Ответ_В FROM Answers WHERE Код_вопроса = 8";
                OleDbCommand Ccommand = new OleDbCommand(C, myConnetction);
                s += Ccommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string B = "SELECT Ответ_Б FROM Answers WHERE Код_вопроса = 8";
                OleDbCommand Bcommand = new OleDbCommand(B, myConnetction);
                s += Bcommand.ExecuteScalar().ToString();
                s += "                       ";

                string D = "SELECT Ответ_Г FROM Answers WHERE Код_вопроса = 8";
                OleDbCommand Dcommand = new OleDbCommand(D, myConnetction);
                s += Dcommand.ExecuteScalar().ToString();
                s += "\n\n";
            }
            if (checkBox9.Checked)
            {
                string q = "SELECT Вопрос FROM Questions WHERE Код = 9";
                OleDbCommand questcommand = new OleDbCommand(q, myConnetction);
                s += questcommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string A = "SELECT Ответ_А FROM Answers WHERE Код_вопроса = 9";
                OleDbCommand Acommand = new OleDbCommand(A, myConnetction);
                s += Acommand.ExecuteScalar().ToString();
                s += "                       ";

                string C = "SELECT Ответ_В FROM Answers WHERE Код_вопроса = 9";
                OleDbCommand Ccommand = new OleDbCommand(C, myConnetction);
                s += Ccommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string B = "SELECT Ответ_Б FROM Answers WHERE Код_вопроса = 9";
                OleDbCommand Bcommand = new OleDbCommand(B, myConnetction);
                s += Bcommand.ExecuteScalar().ToString();
                s += "                       ";

                string D = "SELECT Ответ_Г FROM Answers WHERE Код_вопроса = 9";
                OleDbCommand Dcommand = new OleDbCommand(D, myConnetction);
                s += Dcommand.ExecuteScalar().ToString();
                s += "\n\n";
            }
            if (checkBox10.Checked)
            {
                string q = "SELECT Вопрос FROM Questions WHERE Код = 10";
                OleDbCommand questcommand = new OleDbCommand(q, myConnetction);
                s += questcommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string A = "SELECT Ответ_А FROM Answers WHERE Код_вопроса = 10";
                OleDbCommand Acommand = new OleDbCommand(A, myConnetction);
                s += Acommand.ExecuteScalar().ToString();
                s += "                       ";

                string C = "SELECT Ответ_В FROM Answers WHERE Код_вопроса = 10";
                OleDbCommand Ccommand = new OleDbCommand(C, myConnetction);
                s += Ccommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string B = "SELECT Ответ_Б FROM Answers WHERE Код_вопроса = 10";
                OleDbCommand Bcommand = new OleDbCommand(B, myConnetction);
                s += Bcommand.ExecuteScalar().ToString();
                s += "                       ";

                string D = "SELECT Ответ_Г FROM Answers WHERE Код_вопроса = 10";
                OleDbCommand Dcommand = new OleDbCommand(D, myConnetction);
                s += Dcommand.ExecuteScalar().ToString();
                s += "\n\n";
            }
            if (checkBox11.Checked)
            {
                string q = "SELECT Вопрос FROM Questions WHERE Код = 11";
                OleDbCommand questcommand = new OleDbCommand(q, myConnetction);
                s += questcommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string A = "SELECT Ответ_А FROM Answers WHERE Код_вопроса = 11";
                OleDbCommand Acommand = new OleDbCommand(A, myConnetction);
                s += Acommand.ExecuteScalar().ToString();
                s += "                       ";

                string C = "SELECT Ответ_В FROM Answers WHERE Код_вопроса = 11";
                OleDbCommand Ccommand = new OleDbCommand(C, myConnetction);
                s += Ccommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string B = "SELECT Ответ_Б FROM Answers WHERE Код_вопроса = 11";
                OleDbCommand Bcommand = new OleDbCommand(B, myConnetction);
                s += Bcommand.ExecuteScalar().ToString();
                s += "                       ";

                string D = "SELECT Ответ_Г FROM Answers WHERE Код_вопроса = 11";
                OleDbCommand Dcommand = new OleDbCommand(D, myConnetction);
                s += Dcommand.ExecuteScalar().ToString();
                s += "\n\n";
            }
            if (checkBox12.Checked)
            {
                string q = "SELECT Вопрос FROM Questions WHERE Код = 12";
                OleDbCommand questcommand = new OleDbCommand(q, myConnetction);
                s += questcommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string A = "SELECT Ответ_А FROM Answers WHERE Код_вопроса = 12";
                OleDbCommand Acommand = new OleDbCommand(A, myConnetction);
                s += Acommand.ExecuteScalar().ToString();
                s += "                       ";

                string C = "SELECT Ответ_В FROM Answers WHERE Код_вопроса = 12";
                OleDbCommand Ccommand = new OleDbCommand(C, myConnetction);
                s += Ccommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string B = "SELECT Ответ_Б FROM Answers WHERE Код_вопроса = 12";
                OleDbCommand Bcommand = new OleDbCommand(B, myConnetction);
                s += Bcommand.ExecuteScalar().ToString();
                s += "                       ";

                string D = "SELECT Ответ_Г FROM Answers WHERE Код_вопроса = 12";
                OleDbCommand Dcommand = new OleDbCommand(D, myConnetction);
                s += Dcommand.ExecuteScalar().ToString();
                s += "\n\n";
            }
            if (checkBox13.Checked)
            {
                string q = "SELECT Вопрос FROM Questions WHERE Код = 13";
                OleDbCommand questcommand = new OleDbCommand(q, myConnetction);
                s += questcommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string A = "SELECT Ответ_А FROM Answers WHERE Код_вопроса = 13";
                OleDbCommand Acommand = new OleDbCommand(A, myConnetction);
                s += Acommand.ExecuteScalar().ToString();
                s += "                       ";

                string C = "SELECT Ответ_В FROM Answers WHERE Код_вопроса = 13";
                OleDbCommand Ccommand = new OleDbCommand(C, myConnetction);
                s += Ccommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string B = "SELECT Ответ_Б FROM Answers WHERE Код_вопроса = 13";
                OleDbCommand Bcommand = new OleDbCommand(B, myConnetction);
                s += Bcommand.ExecuteScalar().ToString();
                s += "                       ";

                string D = "SELECT Ответ_Г FROM Answers WHERE Код_вопроса = 13";
                OleDbCommand Dcommand = new OleDbCommand(D, myConnetction);
                s += Dcommand.ExecuteScalar().ToString();
                s += "\n\n";
            }
            if (checkBox14.Checked)
            {
                string q = "SELECT Вопрос FROM Questions WHERE Код = 14";
                OleDbCommand questcommand = new OleDbCommand(q, myConnetction);
                s += questcommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string A = "SELECT Ответ_А FROM Answers WHERE Код_вопроса = 14";
                OleDbCommand Acommand = new OleDbCommand(A, myConnetction);
                s += Acommand.ExecuteScalar().ToString();
                s += "                       ";

                string C = "SELECT Ответ_В FROM Answers WHERE Код_вопроса = 14";
                OleDbCommand Ccommand = new OleDbCommand(C, myConnetction);
                s += Ccommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string B = "SELECT Ответ_Б FROM Answers WHERE Код_вопроса = 14";
                OleDbCommand Bcommand = new OleDbCommand(B, myConnetction);
                s += Bcommand.ExecuteScalar().ToString();
                s += "                       ";

                string D = "SELECT Ответ_Г FROM Answers WHERE Код_вопроса = 14";
                OleDbCommand Dcommand = new OleDbCommand(D, myConnetction);
                s += Dcommand.ExecuteScalar().ToString();
                s += "\n\n";
            }
            if (checkBox15.Checked)
            {
                string q = "SELECT Вопрос FROM Questions WHERE Код = 14";
                OleDbCommand questcommand = new OleDbCommand(q, myConnetction);
                s += questcommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string A = "SELECT Ответ_А FROM Answers WHERE Код_вопроса = 15";
                OleDbCommand Acommand = new OleDbCommand(A, myConnetction);
                s += Acommand.ExecuteScalar().ToString();
                s += "                       ";

                string C = "SELECT Ответ_В FROM Answers WHERE Код_вопроса = 15";
                OleDbCommand Ccommand = new OleDbCommand(C, myConnetction);
                s += Ccommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string B = "SELECT Ответ_Б FROM Answers WHERE Код_вопроса = 15";
                OleDbCommand Bcommand = new OleDbCommand(B, myConnetction);
                s += Bcommand.ExecuteScalar().ToString();
                s += "                       ";

                string D = "SELECT Ответ_Г FROM Answers WHERE Код_вопроса = 15";
                OleDbCommand Dcommand = new OleDbCommand(D, myConnetction);
                s += Dcommand.ExecuteScalar().ToString();
                s += "\n\n";
            }
            if (checkBox16.Checked)
            {
                string q = "SELECT Вопрос FROM Questions WHERE Код = 16";
                OleDbCommand questcommand = new OleDbCommand(q, myConnetction);
                s += questcommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string A = "SELECT Ответ_А FROM Answers WHERE Код_вопроса = 16";
                OleDbCommand Acommand = new OleDbCommand(A, myConnetction);
                s += Acommand.ExecuteScalar().ToString();
                s += "                       ";

                string C = "SELECT Ответ_В FROM Answers WHERE Код_вопроса = 16";
                OleDbCommand Ccommand = new OleDbCommand(C, myConnetction);
                s += Ccommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string B = "SELECT Ответ_Б FROM Answers WHERE Код_вопроса = 16";
                OleDbCommand Bcommand = new OleDbCommand(B, myConnetction);
                s += Bcommand.ExecuteScalar().ToString();
                s += "                       ";

                string D = "SELECT Ответ_Г FROM Answers WHERE Код_вопроса = 16";
                OleDbCommand Dcommand = new OleDbCommand(D, myConnetction);
                s += Dcommand.ExecuteScalar().ToString();
                s += "\n\n";
            }
            if (checkBox17.Checked)
            {
                string q = "SELECT Вопрос FROM Questions WHERE Код = 17";
                OleDbCommand questcommand = new OleDbCommand(q, myConnetction);
                s += questcommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string A = "SELECT Ответ_А FROM Answers WHERE Код_вопроса = 17";
                OleDbCommand Acommand = new OleDbCommand(A, myConnetction);
                s += Acommand.ExecuteScalar().ToString();
                s += "                       ";

                string C = "SELECT Ответ_В FROM Answers WHERE Код_вопроса = 17";
                OleDbCommand Ccommand = new OleDbCommand(C, myConnetction);
                s += Ccommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string B = "SELECT Ответ_Б FROM Answers WHERE Код_вопроса = 17";
                OleDbCommand Bcommand = new OleDbCommand(B, myConnetction);
                s += Bcommand.ExecuteScalar().ToString();
                s += "                       ";

                string D = "SELECT Ответ_Г FROM Answers WHERE Код_вопроса = 17";
                OleDbCommand Dcommand = new OleDbCommand(D, myConnetction);
                s += Dcommand.ExecuteScalar().ToString();
                s += "\n\n";
            }
            if (checkBox18.Checked)
            {
                string q = "SELECT Вопрос FROM Questions WHERE Код = 18";
                OleDbCommand questcommand = new OleDbCommand(q, myConnetction);
                s += questcommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string A = "SELECT Ответ_А FROM Answers WHERE Код_вопроса = 18";
                OleDbCommand Acommand = new OleDbCommand(A, myConnetction);
                s += Acommand.ExecuteScalar().ToString();
                s += "                       ";

                string C = "SELECT Ответ_В FROM Answers WHERE Код_вопроса = 18";
                OleDbCommand Ccommand = new OleDbCommand(C, myConnetction);
                s += Ccommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string B = "SELECT Ответ_Б FROM Answers WHERE Код_вопроса = 18";
                OleDbCommand Bcommand = new OleDbCommand(B, myConnetction);
                s += Bcommand.ExecuteScalar().ToString();
                s += "                       ";

                string D = "SELECT Ответ_Г FROM Answers WHERE Код_вопроса = 18";
                OleDbCommand Dcommand = new OleDbCommand(D, myConnetction);
                s += Dcommand.ExecuteScalar().ToString();
                s += "\n\n";
            }
            if (checkBox19.Checked)
            {
                string q = "SELECT Вопрос FROM Questions WHERE Код = 19";
                OleDbCommand questcommand = new OleDbCommand(q, myConnetction);
                s += questcommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string A = "SELECT Ответ_А FROM Answers WHERE Код_вопроса = 19";
                OleDbCommand Acommand = new OleDbCommand(A, myConnetction);
                s += Acommand.ExecuteScalar().ToString();
                s += "                       ";

                string C = "SELECT Ответ_В FROM Answers WHERE Код_вопроса = 19";
                OleDbCommand Ccommand = new OleDbCommand(C, myConnetction);
                s += Ccommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string B = "SELECT Ответ_Б FROM Answers WHERE Код_вопроса = 19";
                OleDbCommand Bcommand = new OleDbCommand(B, myConnetction);
                s += Bcommand.ExecuteScalar().ToString();
                s += "                       ";

                string D = "SELECT Ответ_Г FROM Answers WHERE Код_вопроса = 19";
                OleDbCommand Dcommand = new OleDbCommand(D, myConnetction);
                s += Dcommand.ExecuteScalar().ToString();
                s += "\n\n";
            }
            if (checkBox20.Checked)
            {
                string q = "SELECT Вопрос FROM Questions WHERE Код = 20";
                OleDbCommand questcommand = new OleDbCommand(q, myConnetction);
                s += questcommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string A = "SELECT Ответ_А FROM Answers WHERE Код_вопроса = 20";
                OleDbCommand Acommand = new OleDbCommand(A, myConnetction);
                s += Acommand.ExecuteScalar().ToString();
                s += "                       ";

                string C = "SELECT Ответ_В FROM Answers WHERE Код_вопроса = 20";
                OleDbCommand Ccommand = new OleDbCommand(C, myConnetction);
                s += Ccommand.ExecuteScalar().ToString();
                s += "\n                       ";

                string B = "SELECT Ответ_Б FROM Answers WHERE Код_вопроса = 20";
                OleDbCommand Bcommand = new OleDbCommand(B, myConnetction);
                s += Bcommand.ExecuteScalar().ToString();
                s += "                       ";

                string D = "SELECT Ответ_Г FROM Answers WHERE Код_вопроса = 20";
                OleDbCommand Dcommand = new OleDbCommand(D, myConnetction);
                s += Dcommand.ExecuteScalar().ToString();
                s += "\n\n";
            }
            richTextBox1.Text = s;
        }

        private void button_Test_Create_Click(object sender, EventArgs e)
        {
            if (n <= 0) n = 10;
            else if (n > 20) n = 10; 
            if (a == 0) a = 4;
            else if (a > 4) a = 4;
            s = "";
            string iz;
            int rndm;
            Random rnd = new Random((int) DateTime.Now.Ticks & 0x0000FFFF);
            for (int i = 0; i < n; i++)
            {
                rndm = rnd.Next(1, 20);
                iz = rndm.ToString();
                string q = "SELECT Вопрос FROM Questions WHERE Код = ";
                q += iz;
                OleDbCommand questcommand = new OleDbCommand(q, myConnetction);
                s += questcommand.ExecuteScalar().ToString();
                s += "\n                       ";

                if(a == 1) { 
                    string A = "SELECT Ответ_А FROM Answers WHERE Код_вопроса = ";
                    A += iz;
                    OleDbCommand Acommand = new OleDbCommand(A, myConnetction);
                    s += Acommand.ExecuteScalar().ToString();
                    s += "                       ";
                    s += "\n\n";
                }
                else if(a == 2)
                {
                    string A = "SELECT Ответ_А FROM Answers WHERE Код_вопроса = ";
                    A += iz;
                    OleDbCommand Acommand = new OleDbCommand(A, myConnetction);
                    s += Acommand.ExecuteScalar().ToString();
                    s += "                       ";

                    string C = "SELECT Ответ_В FROM Answers WHERE Код_вопроса = ";
                    C += iz;
                    OleDbCommand Ccommand = new OleDbCommand(C, myConnetction);
                    s += Ccommand.ExecuteScalar().ToString();
                    s += "\n                       ";
                    s += "\n";
                }
                else if(a == 3)
                {
                    string A = "SELECT Ответ_А FROM Answers WHERE Код_вопроса = ";
                    A += iz;
                    OleDbCommand Acommand = new OleDbCommand(A, myConnetction);
                    s += Acommand.ExecuteScalar().ToString();
                    s += "                       ";

                    string C = "SELECT Ответ_В FROM Answers WHERE Код_вопроса = ";
                    C += iz;
                    OleDbCommand Ccommand = new OleDbCommand(C, myConnetction);
                    s += Ccommand.ExecuteScalar().ToString();
                    s += "\n                       ";

                    string B = "SELECT Ответ_Б FROM Answers WHERE Код_вопроса = ";
                    B += iz;
                    OleDbCommand Bcommand = new OleDbCommand(B, myConnetction);
                    s += Bcommand.ExecuteScalar().ToString();
                    s += "                       ";
                    s += "\n\n";
                }
                else if(a == 4)
                {
                    string A = "SELECT Ответ_А FROM Answers WHERE Код_вопроса = ";
                    A += iz;
                    OleDbCommand Acommand = new OleDbCommand(A, myConnetction);
                    s += Acommand.ExecuteScalar().ToString();
                    s += "                       ";

                    string C = "SELECT Ответ_В FROM Answers WHERE Код_вопроса = ";
                    C += iz;
                    OleDbCommand Ccommand = new OleDbCommand(C, myConnetction);
                    s += Ccommand.ExecuteScalar().ToString();
                    s += "\n                       ";

                    string B = "SELECT Ответ_Б FROM Answers WHERE Код_вопроса = ";
                    B += iz;
                    OleDbCommand Bcommand = new OleDbCommand(B, myConnetction);
                    s += Bcommand.ExecuteScalar().ToString();
                    s += "                       ";

                    string D = "SELECT Ответ_Г FROM Answers WHERE Код_вопроса = ";
                    D += iz;
                    OleDbCommand Dcommand = new OleDbCommand(D, myConnetction);
                    s += Dcommand.ExecuteScalar().ToString();
                    s += "\n\n";
                }
                
            }
            richTextBox1.Text = s;

        }
    }
}
