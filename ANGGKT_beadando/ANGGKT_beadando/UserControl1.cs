using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ANGGKT_beadando.Controllers;

namespace ANGGKT_beadando
{
    public partial class UserControl1 : UserControl
    {
        CicaEntities1 context = new CicaEntities1();
        public static string email;
        public static string password;
        public static int accountid;

        private AccountController _controller = new AccountController();

        private bool passwordCheckPassed;
        public bool PasswordCheckPassed
        {
            get { return passwordCheckPassed; }
            set
            {
                passwordCheckPassed = value;
                button2.Enabled = passwordCheckPassed;
                if (passwordCheckPassed)
                    ismetjelszotxt.BackColor = Color.White;
                else
                    ismetjelszotxt.BackColor = Color.Fuchsia;
            }
        }

        public UserControl1()
        {
            InitializeComponent();
            PasswordCheckPassed = true;
            dgwAccounts.DataSource = _controller.AccountManager.Accounts;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                _controller.Register(
                    emailtextbox.Text,
                    passwordtextbox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Account account = new Account();

            //account.email = emailtextbox.Text;
            //account.password = passwordtextbox.Text;

            //context.Accounts.Add(account);

            //button2.Enabled = false;

            //try
            //{
            //    context.SaveChanges();
            //    accountid = account.Account_id;
            //    MessageBox.Show("Sikeresen regisztráltál! :)");

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}

        }

        private void passwordtextbox_TextChanged(object sender, EventArgs e)
        {
            PasswordCheckPassed = passwordtextbox.Text.Equals(ismetjelszotxt.Text);
        }
    }
}
