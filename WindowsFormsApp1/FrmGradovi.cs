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


    public partial class FrmGradovi : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public int oznakaForma = 1;
        List<Button> listaGumbova;
        List<string> listaGradova = new List<string>() { "Lyon", "Pariz", "Oslo", "Zagreb", "Barcelona", "Istanbul", "London", "Bruxelles", "Rim", "Milan", "Beograd", "Prag", "Thessaloniki", "Hamburg",
            "Tokyo", "Seoul", "Mexico City", "Mumbai", "Sao Paulo", "Manila", "Los Angeles", "Šangaj", "Osaka", "Kolkata", "Karachi", "Guangzhou", "Buenos Aires", "Moskva", "Peking", "Dhaka ", "San Francisco",
            "Rio de Janeiro", "Tehran", "Shenzhen", "Lagos", "Chungking", "Chicago", "Nagoya", "Vuhan", "Lima", "Bangkok", "Bogota", "Kinshasa", "Lahore", "Washington", "Tientsin", "Madras",
            "Dongguan", "Bangalore", "Hiderabad", "Johannesburg", "Essen", "Hong Kong", "Taipei", "Bagdad", "Madrid", "Philadelphia", "Santiago", "Belo Horizonte", "Toronto", "Ahmedabad"};

        Dictionary<string, string> dictGradovi = new Dictionary<string, string>()
        {
            { "Atena", "Atena" },
            { "berlin", "Berlin"},
            { "bukurešt", "Bukurešt" },
            { "Delhi", "Delhi"},
            { "Jakarta", "Jakarta" },
            { "Kairo", "Kairo"},
            { "kopenhagen", "Kopenhagen"},
            { "NY", "New York" },
            { "stockholm", "Stockholm" },
            { "birmingham", "Birmingham"}
        };

        public class tag
        {
            public int tagForma = 1;
        }

        public FrmGradovi()
        {
            InitializeComponent();
            askQuestion(questionNumber);

            totalQuestions = 10;

            LblProgressGradovi.Text = "(" + score + "/" + totalQuestions + ")";
            LblPitanjeGradovi.Text = "(" + questionNumber + "/" + totalQuestions + ")" + "Koji grad je prikazan na slici?";
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
                dictGradovi = dictGradovi.OrderBy(x => Guid.NewGuid()).ToDictionary(item => item.Key, item => item.Value);

            }
            listaGumbova[0].Tag = 0;
            PbrGradovi.Increment(1);
            questionNumber++;
            askQuestion(questionNumber);

        }

        public string getKey(int random)
        {
            return dictGradovi.ElementAt(random).Key;
        }

        public void funkcija_odluke(int broj)
        {
            listaGumbova = new List<Button>() { BtnGradoviPrvi, BtnGradoviDrugi, BtnGradoviTreci, BtnGradoviCetvrti };
            listaGumbova = listaGumbova.OrderBy(i => Guid.NewGuid()).ToList();

            PicGradovi.Image = (Image)Properties.Resources.ResourceManager.GetObject(getKey(broj - 1));
            LblProgressGradovi.Text = "(" + score + "/" + totalQuestions + ")";
            LblPitanjeGradovi.Text = "(" + questionNumber + "/" + totalQuestions + ")" + "Koji grad je prikazan na slici?";

            listaGumbova[0].Text = dictGradovi.ElementAt(broj - 1).Value;
            listaGumbova[1].Text = listaGradova[RandomNumber(0, listaGradova.Count/3)];
            listaGumbova[2].Text = listaGradova[RandomNumber(listaGradova.Count / 3 + 1, 2 * listaGradova.Count / 3)];
            listaGumbova[3].Text = listaGradova[RandomNumber(2 * listaGradova.Count / 3 + 1, 3 * listaGradova.Count / 3)];

            listaGumbova[0].Tag = 1;
            correctAnswer = 1;
        }

        private void askQuestion(int qnum)
        {
            if (qnum == 1)
            {
                dictGradovi = dictGradovi.OrderBy(x => Guid.NewGuid()).ToDictionary(item => item.Key, item => item.Value);
            }

            funkcija_odluke(qnum);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LblPitanjeGradovi.Parent = PicPozadinaGradovi;
            LblPitanjeGradovi.BackColor = Color.Transparent;
            LblProgressGradovi.Parent = PicPozadinaGradovi;
            LblProgressGradovi.BackColor = Color.Transparent;
        }

        private void BtnNazadGradovi_Click(object sender, EventArgs e)
        {
            score = 0;
            FrmKategorije frm = new FrmKategorije();
            frm.Show();
            this.Hide();
        }
    }
}
