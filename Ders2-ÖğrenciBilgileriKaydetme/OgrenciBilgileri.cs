using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders2_ÖğrenciBilgileriKaydetme
{
    public partial class OgrenciBilgileri : Form
    {
        public void aktsHesapla()
        {
            int akts = 0;
            if(cbAlgoritma.Checked) 
            {
                akts += 5;
            }
            if (cbGorselPrg.Checked)
            {
                akts += 6;
            }
            if(cbProg1.Checked)
            {
                akts += 5;
            }
            if (cbProg2.Checked)
            {
                akts += 7;
            }
            if (cbVTYS.Checked)
            {
                akts += 7;
            }
            if (cBVeriMaden.Checked)
            {
                akts += 4;
            }
            SecilenAkts.Text=akts.ToString();
        }

        public OgrenciBilgileri()
        {
            InitializeComponent();
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            if (cbAlgoritma.Checked)
            {
                lbSecilenDersler.Items.Add(cbAlgoritma.Text);
            }
            if (cbGorselPrg.Checked)
            {
                lbSecilenDersler.Items.Add(cbGorselPrg.Text);
            }
            if (cbProg1.Checked)
            {
                lbSecilenDersler.Items.Add(cbProg1.Text);
            }
            if (cbProg2.Checked)
            {
                lbSecilenDersler.Items.Add(cbProg2.Text);
            }
            if (cbVTYS.Checked)
            {
                lbSecilenDersler.Items.Add(cbVTYS.Text);
            }
            if (cBVeriMaden.Checked)
            {
                lbSecilenDersler.Items.Add(cBVeriMaden.Text);
            }
           

        }

        private void cbGorselPrg_CheckedChanged(object sender, EventArgs e)
        {
            aktsHesapla();
        }

        private void cbAlgoritma_CheckedChanged(object sender, EventArgs e)
        {
            aktsHesapla();
        }

        private void cbVTYS_CheckedChanged(object sender, EventArgs e)
        {
            aktsHesapla();
        }

        private void cbProg1_CheckedChanged(object sender, EventArgs e)
        {
            aktsHesapla();
        }

        private void cbProg2_CheckedChanged(object sender, EventArgs e)
        {
            aktsHesapla();
        }

        private void cBVeriMaden_CheckedChanged(object sender, EventArgs e)
        {
            aktsHesapla();
        }
    }
}
