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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciBilgileri ogrenci=new OgrenciBilgileri();
            ogrenci.Show();
            ogrenci.lbAd.Items.Add(txtAd.Text);
            ogrenci.lbBolum.Items.Add(cmBolum.Text);
            ogrenci.lbNo.Items.Add(txtNo.Text);
            if(rb1.Checked)
            {
                ogrenci.lbSinif.Items.Add(rb1.Text);
            }
            else if(rb2.Checked)
            {
                ogrenci.lbSinif.Items.Add(rb2.Text);
            }
            else if (rb3.Checked)
            {
                ogrenci.lbSinif.Items.Add(rb3.Text);
            }
            else if (rb4.Checked)
            {
                ogrenci.lbSinif.Items.Add(rb4.Text);
            }
            else
            {
                MessageBox.Show("Sınıf Seçin");
            }

            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Text = txtNo.Text = " ";
            rb1.Checked=rb2.Checked=rb3.Checked=rb4.Checked=false;
            cmBolum.Text = " ";
        }
    }
}
