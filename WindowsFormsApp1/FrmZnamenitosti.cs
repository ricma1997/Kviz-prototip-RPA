using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class FrmZnamenitosti : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score = 0;
        int percentage;
        int totalQuestions;
        public int oznakaForma = 2;
        List<Button> listaGumbova;
        List<string> listaZnamenitosti = new List<string>() { "Kip Krista Otkupitelja", "Stonehenge", "Koloseum u Rimu", "Bazilika Sv. Petra", "Milanska katedrala", "Golden Gate Bridge",
            "Velika palača u Bangkoku", "Big Ben", "Katedrala Notre-Dame", "Sydney Opera House", "Zid plača", "Petra u Jordanu", "Viktorijini slapovi", "Burj Khalifa"
        };

        Dictionary<string, string> dictZnamenitosti = new Dictionary<string, string>() {
            { "Akropola", "Akropola" },
            { "Katedrala Svetog Bazilija", "Katedrala Svetog Bazilija"},
            { "Kineski zid", "Kineski zid" },
            { "Kip Slobode", "Kip Slobode"},
            { "Kosi Toranj u Pisi", "Kosi Toranj u Pisi" },
            { "Machu Picchu", "Machu Picchu"},
            { "Moai", "Moai"},
            { "Planina Svetog Mihovila", "Planina Svetog Mihovila" },
            { "Sfinga", "Sfinga" },
            { "Velika Piramida u Gizi", "Velika Piramida u Gizi"}
        };

        public FrmZnamenitosti()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 10;

            LblPitanjeZnamenitosti.Text = "(" + questionNumber + "/" + totalQuestions + ")" + "Koji je naziv znamenitosti prikazane na slici?";
            LblProgressZnamenitosti.Text = "Rezultat: (" + score + "/" + totalQuestions + ")";
        }
        // Instantiate random number generator.  
        private readonly Random _random = new Random();

        // Generates a random number within a range.      
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObjectGradovi = (Button)sender;

            int buttonTagGradovi = Convert.ToInt32(senderObjectGradovi.Tag);

            if (buttonTagGradovi == correctAnswer)
            {
                score++;
                listaGumbova[0].Tag = 0;
            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                string txtRezultati = "Kraj Kviza!" + Environment.NewLine +
                    "Broj točnih odgovora je " + score + "/" + totalQuestions + " .";

                string txtRezultati2 = "Kako biste nastavili s rješavanjem kviza kliknite na gumb \"Nastavi\"." +
                   Environment.NewLine + "Za povratak na kategorije kliknite na \"Natrag\".";

                FrmRezultati frmRez = new FrmRezultati(oznakaForma, txtRezultati, txtRezultati2);
                frmRez.Show();
                this.Hide();

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber + 1);
                dictZnamenitosti = dictZnamenitosti.OrderBy(x => Guid.NewGuid()).ToDictionary(item => item.Key, item => item.Value);
            }
            PbrZnamenitosti.Increment(1);
            listaGumbova[0].Tag = 0;
            questionNumber++;
            askQuestion(questionNumber);

        }

        public string getKey(int random)
        {
            return dictZnamenitosti.ElementAt(random).Key;
        }

        public void funkcija_odluke(int broj)
        {
            listaGumbova = new List<Button>() { BtnZnamenitostiPrvi, BtnZnamenitostiDrugi, BtnZnamenitostiTreci, BtnZnamenitostiCetvrti };
            listaGumbova = listaGumbova.OrderBy(i => Guid.NewGuid()).ToList();

            PicZnamenitosti.Image = (Image)Properties.Resources.ResourceManager.GetObject(getKey(broj - 1));
            LblProgressZnamenitosti.Text = "Rezultat: (" + score + "/" + totalQuestions + ")";
            LblPitanjeZnamenitosti.Text = "(" + questionNumber + "/" + totalQuestions + ")" + "Koji je naziv znamenitosti prikazane na slici?";

            listaGumbova[0].Text = dictZnamenitosti.ElementAt(broj - 1).Value;
            listaGumbova[1].Text = listaZnamenitosti[RandomNumber(0, listaZnamenitosti.Count / 3)];
            listaGumbova[2].Text = listaZnamenitosti[RandomNumber(listaZnamenitosti.Count / 3 + 1, 2 * listaZnamenitosti.Count / 3)];
            listaGumbova[3].Text = listaZnamenitosti[RandomNumber(2 * listaZnamenitosti.Count / 3 + 1, 3 * listaZnamenitosti.Count / 3)];

            listaGumbova[0].Tag = 1;
            correctAnswer = 1;

            for (int i = 0; i < 4; i++)
            {
                Debug.WriteLine("Ovo je tag", Convert.ToString(listaGumbova[i].Tag));
            }
        }

        private void askQuestion(int qnum)
        {
            if (qnum == 1)
            {
                dictZnamenitosti = dictZnamenitosti.OrderBy(x => Guid.NewGuid()).ToDictionary(item => item.Key, item => item.Value);
            }

            funkcija_odluke(qnum);
        }

        private void FrmZnamenitosti_Load(object sender, EventArgs e)
        {
            LblPitanjeZnamenitosti.Parent = PicPozadinaZnamenitosti;
            LblPitanjeZnamenitosti.BackColor = Color.Transparent;
            LblProgressZnamenitosti.Parent = PicPozadinaZnamenitosti;
            LblProgressZnamenitosti.BackColor = Color.Transparent;
        }



        private void BtnNazadZnamenitosti_Click(object sender, EventArgs e)
        {
            score = 0;
            FrmKategorije frm = new FrmKategorije();
            frm.Show();
            this.Hide();
        }
    }
}
