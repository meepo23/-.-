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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9RQCCEQ\MSSQLSERVER1;Initial Catalog=hhhh;Integrated Security=True");
            con.Open();
            int i = 0;
            SqlCommand command = new SqlCommand(" select Log, Pass from [dbo].[Users1] where Log = @Log and Pass = @Pass", con);
            command.Parameters.Add("@Log", SqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBox2.Text;
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dac = new SqlDataAdapter(command);
            dac.Fill(dt);
            DataSend.text = textBox2.Text;
            con.Close();


            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("Неверный логин или пароль", "Сайт", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                this.Hide();
                Client F2 = new Client();
                F2.Show();
                MessageBox.Show("Авторизация прошла успешно, чтобы дальше продолжить нужно подключится к серверу", "Сайт", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void namePnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
