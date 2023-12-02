using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

       async private void button1_Click(object sender, EventArgs e)
        {
            int qt = 100;
            ProgressBar1.Maximum = qt;

            for (int i = qt; i > 0; i--)
            {
                ProgressBar1.Value++;
                Percent.Text = ProgressBar1.Value + "%";
            }
            await Task.Delay(2000);
            timer1.Stop();
            Form1 log = new Form1();
            log.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
