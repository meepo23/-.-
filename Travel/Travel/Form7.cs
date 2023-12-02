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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-9RQCCEQ\MSSQLSERVER1;Initial Catalog=hhhh;Integrated Security=True");
        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 F4 = new Form2();
            F4.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 F4 = new Form5();
            F4.Show();
        }
        public void populateGrid()
        {
            Con.Open();
            string query = "select * from [dbo].Туристы";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 F4 = new Form6();
            F4.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 F4 = new Form8();
            F4.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand(" insert into [dbo].Туристы values ( '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "') ", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Добавлено");
            Con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
