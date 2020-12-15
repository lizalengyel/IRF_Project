using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Text.RegularExpressions;

namespace ANGGKT_beadando
{
    public partial class UserControl3 : UserControl
    {

        CicaEntities1 context = new CicaEntities1();
   

        public UserControl3()
        {
            InitializeComponent();
            label7.Text = DateTime.Now.ToShortDateString();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            nevtext.Clear();
            korText.Clear();
            telotext.Clear();

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            //mentés, új gazda felvétele

            Gazda gazda = new Gazda();
            context.Gazdas.Load();

            //adatok feltöltése

            gazda.nev = nevtext.Text;
            gazda.telefonszam = telotext.Text;
            gazda.kor = Convert.ToInt16(korText.Text);
            gazda.orokbefogdatum = DateTime.Now;
            gazda.account_fk = 104;
            gazda.cica_fk = Mainpage.cicaid;


            try
            {
                context.SaveChanges();
                MessageBox.Show("Gratulálunk! Boldoggá teheted egy kiscica életét!");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void nevtext_Validating(object sender, CancelEventArgs e)
        {

            Regex r = new Regex(@"^[A-Z-ÁÉÓÖŐÜŰÚ]{1}[a-z-áéóöőúüű]+[ ]{1}([A-Z-ÁÉÓÖŐÜŰÚ]{1}[a-z-áéóöőúüű]+|[A-Z-ÁÉÓÖŐÜŰÚ]{1}[a-z-áéóöőúüű]+[ ]{1}[A-Z-ÁÉÓÖŐÜŰÚ]{1}[a-z-áéóöőúüű]+)$");

            if (r.IsMatch(nevtext.Text))
            {
                nevtext.BackColor = Color.PaleGreen;
                button1.Enabled = true;
            }
            else
            {
                nevtext.BackColor = Color.Red;
                e.Cancel = true;
                nevlabel.Visible = true;
                button1.Enabled = false;

            }
        }

        private void nevtext_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void korText_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex(@"^[0-9]{1,2}$");


            if (r.IsMatch(korText.Text))
            {
                korText.BackColor = Color.PaleGreen;
            }
            else
            {
                korText.BackColor = Color.Red;
                e.Cancel = true;
                korlabel.Visible = true;
            }
        }

        private void korText_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void telotext_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex(@"^(\+36|06)(-|/)[0-9]{1,2}-[0-9]{3}-?[0-9]{3,4}$");


            if (r.IsMatch(telotext.Text))
            {
                telotext.BackColor = Color.PaleGreen;
            }
            else
            {
                telotext.BackColor = Color.Red;
                e.Cancel = true;
                telefonszamlabel.Visible = true;
            }


        }

        private void telotext_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }
    }
}
