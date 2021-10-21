using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmRezultati : Form
    {
        int oznakaForma;
        public FrmRezultati()
        {
            InitializeComponent();
        }

        public FrmRezultati(int tagVal, string txt, string txt2)
        {
            InitializeComponent();
            oznakaForma = tagVal;
            LblRezultati.Text = txt;
            LblRezultatiDrugi.Text = txt2;
        }
        private void FrmRezultati_Load(object sender, EventArgs e)
        {
            LblNaslovRezultat.Parent = PicPozadinaRezultati;
            LblNaslovRezultat.BackColor = Color.Transparent;
            LblRezultati.Parent = PicPozadinaRezultati;
            LblRezultati.BackColor = Color.Transparent;
            LblRezultatiDrugi.Parent = PicPozadinaRezultati;
            LblRezultatiDrugi.BackColor = Color.Transparent;
            CbxPohraniRez.Parent = PicPozadinaRezultati;
            CbxPohraniRez.BackColor = Color.Transparent;
        }

        private void BtnRezultatiPohrana_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtRezultati.Text.Trim()))
            {
                MessageBox.Show("Polje je prazno, molimo vas da upišete rezultat.", "Greška unosa");
            }
            else
            {
                string pohraniRezultat = TxtRezultati.Text;
                MessageBox.Show("Rezultat je uspješno pohranjen", "Uspjeh");
            }
        }



        private void BtnRezultatiNastavak_Click(object sender, EventArgs e)
        {
            if (CbxPohraniRez.Checked)
            {
                if (String.IsNullOrEmpty(TxtRezultati.Text.Trim()))
                {
                    MessageBox.Show("Polje za unos rezultata je prazno, molimo vas da upišete rezultat.", "Greška unosa");
                    return;
                }
            }

            if (oznakaForma == 0)
            {
                FrmDrzave frmDrzave = new FrmDrzave();
                frmDrzave.Show();
                this.Hide();
            }

            else if (oznakaForma == 1)
            {
                FrmGradovi frmGradovi = new FrmGradovi();
                this.Hide();
                frmGradovi.Show();
            }

            else
            {
                FrmZnamenitosti frmZnamenitosti= new FrmZnamenitosti();
                this.Hide();
                frmZnamenitosti.Show();
            }

        }

        private void BtnNatrag_Click(object sender, EventArgs e)
        {
            FrmKategorije frmKat = new FrmKategorije();
            this.Hide();
            frmKat.Show();   
        }

        private void PicPozadinaRezultati_Click(object sender, EventArgs e)
        {

        }

    }
}
