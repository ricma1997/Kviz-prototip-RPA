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
            Form2 forma2 = new Form2();
            forma2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblKategorije.Parent = PicPozadinaKategorije;
            LblKategorije.BackColor = Color.Transparent;

        }

        private void LblKategorije_Click(object sender, EventArgs e)
        {

        }
    }
}
