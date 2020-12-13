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
using System.Drawing;
using System.Drawing.Drawing2D;


namespace ANGGKT_beadando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            adminpasstext.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            UserControl1 userControl1 = new UserControl1();
            panel1.Controls.Add(userControl1);
            userControl1.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\lizal\Source\Repos\IRF_Project\ANGGKT_beadando\ANGGKT_beadando\Database1.mdf; Integrated Security = True");
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Count(*) From Account where email='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Mainpage mp = new Mainpage();
                mp.Show();
            }
            else
            {
                MessageBox.Show("Hibás e-mail vagy jelszó! Kérlek próbáld meg újra!");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ahhoz, hogy több információt láss a cicákról, először lépj be!");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ahhoz, hogy több információt láss a cicákról, először lépj be!");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ahhoz, hogy több információt láss a cicákról, először lépj be!");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ahhoz, hogy több információt láss a cicákról, először lépj be!");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ahhoz, hogy több információt láss a cicákról, először lépj be!");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ahhoz, hogy több információt láss a cicákról, először lépj be!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\lizal\Source\Repos\IRF_Project\ANGGKT_beadando\ANGGKT_beadando\Database1.mdf; Integrated Security = True");
            SqlDataAdapter da = new SqlDataAdapter("Select Count(*) From Admin where Admin='" + admintext.Text + "' and Password='" + adminpasstext.Text + "'", connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                panel1.Controls.Clear();
                UserControl4 uc4 = new UserControl4();
                panel1.Controls.Add(uc4);
            }
            else
            {
                MessageBox.Show("Hibás Admin-név vagy jelszó! Kérlek próbáld meg újra!");
            }
        }
    }
}
