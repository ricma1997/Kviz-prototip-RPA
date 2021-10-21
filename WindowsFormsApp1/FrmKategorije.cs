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
    public partial class FrmKategorije : Form
    {
        public FrmKategorije()
        {
            InitializeComponent();
        }

        private void BtnDrzave_Click(object sender, EventArgs e)
        {
            FrmDrzave frmDrzave = new FrmDrzave();
            this.Close();
            frmDrzave.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblKategorije.Parent = PicPozadinaKategorije;
            LblKategorije.BackColor = Color.Transparent;

        }

        private void BtnGradovi_Click(object sender, EventArgs e)
        {
            FrmGradovi frmGradovi = new FrmGradovi();
            this.Close();
            frmGradovi.Show();
        }

        private void BtnZnamenitosti_Click(object sender, EventArgs e)
        {
            FrmZnamenitosti frmZnamenitosti = new FrmZnamenitosti();
            this.Close();
            frmZnamenitosti.Show();
        }

        private void BtnPovratakMeni_Click(object sender, EventArgs e)
        {
            FrmPocetna frmPocetna = new FrmPocetna();
            this.Close();
            frmPocetna.Show();
        }
    }
}
