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
    public partial class Form5 : Form
    {
        public Form5()
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
        
        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 F4 = new Form6();
            F4.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 F4 = new Form7();
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
            this.Hide();
            Client F4 = new Client();
            F4.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mail = CodeeloMail.CreateMail(textBox6.Text, "codeelo0.test.smtp@gmail.com", textBox5.Text, textBox7.Text, textBox8.Text);
            CodeeloMail.SendMail("smtp.gmail.com", 587, "codeelo0.test.smtp@gmail.com", "vbroedudnefbhgzr", mail);
            MessageBox.Show("Сообщение успешно отправленно, в ближайшее время с вами свяжемся");
        }
    }
}
