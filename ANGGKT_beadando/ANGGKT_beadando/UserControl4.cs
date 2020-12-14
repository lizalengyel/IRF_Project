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
using System.IO;

namespace ANGGKT_beadando
{
    public partial class UserControl4 : UserControl
    {
        CicaEntities1 context = new CicaEntities1();
        // public static int kor;
        public static bool neme;
        public static string datum;


        public UserControl4()
        {
            InitializeComponent();
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            neme = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            neme = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            datum = dateTimePicker1.Value.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CICA macska = new CICA();
            context.CICAs.Load();

            macska.nev = macskanev.Text;
            macska.kor = Convert.ToInt16(macskakor.Value);
            macska.szin = macskaszin.Text;
            macska.fajta = macskafajta.Text;
            macska.van_egazdi = false;
            macska.felvetel = Convert.ToDateTime(datum);
            macska.neme = neme;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "csv";

            if (sfd.ShowDialog() != DialogResult.OK) return;
            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                foreach (var s in context.CICAs)
                {
                    sw.Write(s.cica_id);
                    sw.Write(";");
                    sw.Write(s.nev);
                    sw.Write(";");
                    sw.Write(s.kor);
                    sw.Write(";");
                    sw.Write(s.szin);
                    sw.Write(s.fajta);
                    sw.Write(";");
                    sw.Write(s.felvetel);
                    sw.Write(";");
                    sw.Write(s.van_egazdi);
                    sw.Write(";");
                    sw.Write(s.gazda_fk);
                    sw.Write(";");
                    sw.Write(s.neme);
                    sw.Write(";");
                    sw.WriteLine();
                }



            }
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {
          
        }
    }
}
