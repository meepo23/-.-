using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 F4 = new Form4();
            F4.Show();
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9RQCCEQ\MSSQLSERVER1;Initial Catalog=hhhh;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Users1] (Log, pass) VALUES (@log, @pass)", con);
            command.Parameters.Add("@log", SqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = textBox2.Text;            
            command.ExecuteNonQuery();          
            con.Close();
            MessageBox.Show("Новый пользователь добавлен", "Сайт", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Hide();
            Client F2 = new Client();
            F2.Show();
        }
    }
}
