using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANGGKT_beadando
{
    public partial class UserControl1 : UserControl
    {
        CicaEntities context = new CicaEntities();
        public static string email;
        public static string password;
        public static int accountid;


        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Account account = new Account();

            account.email = emailtextbox.Text;
            account.password = passwordtextbox.Text;

            context.Accounts.Add(account);

            button2.Enabled = false;

            try
            {
                context.SaveChanges();
                accountid = account.Account_id;
                MessageBox.Show("Sikeresen regisztráltál! :)");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
