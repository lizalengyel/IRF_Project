using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ANGGKT_beadando
{
    public partial class UserControl1 : UserControl
    {
        CicaEntities1 context = new CicaEntities1();
        public static string email;
        public static string password;
        public static int accountid;

       

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
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!ValidateEmail(email))
                throw new ValidationException(
                    "A megadott e-mail cím nem megfelelő!");
            if (!ValidateEmail(email))
                throw new ValidationException(
                    "A megadottt jelszó nem megfelelő!\n" +
                    "A jelszó legalább 8 karakter hosszú kell legyen, csak az angol ABC betűiből és számokból állhat, és tartalmaznia kell legalább egy kisbetűt, egy nagybetűt és egy számot.");


            Account account = new Account();

            account.email = emailtextbox.Text;
            account.password = passwordtextbox.Text;

            context.Accounts.Add(account);
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

        //button2.Enabled = false;



        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(
                email,
                @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
        }

        public bool ValidatePassword(string password)
        {
            return true;
        }

        private void passwordtextbox_TextChanged(object sender, EventArgs e)
        {
            PasswordCheckPassed = passwordtextbox.Text.Equals(ismetjelszotxt.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
