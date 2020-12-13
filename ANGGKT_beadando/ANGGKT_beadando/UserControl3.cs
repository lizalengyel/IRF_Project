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

namespace ANGGKT_beadando
{
    public partial class UserControl3 : UserControl
    {

        CicaEntities contect = new CicaEntities();
              private object cicaDataset;

        public UserControl3()
        {
            InitializeComponent();
            label7.Text = DateTime.Now.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mentés, új gazda felvétele

            Gazda gazda = new Gazda();
            contect.Gazdas.Load();

            //adatok feltöltése

            gazda.nev = nevtext.Text;
            gazda.telefonszam = telotext.Text;
            gazda.kor = Convert.ToInt16(korText.Text);
            gazda.orokbefogdatum = DateTime.Now;
            gazda.account_fk = 104;

            //cica van-e gazdáját átírni 1-re

            CicaDataSet.CICARow cr = cicaDataSet1.CICA.FindBycica_id(112);
            cr.van_egazdi = true;
            cr.gazda_fk = gazda.gazda_id;
        }

        private void cICABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cICABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cicaDataSet1);

        }
    }
}
