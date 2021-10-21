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

    public partial class FrmDrzave : Form 
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        int oznakaForma = 0;
        List<Button> listaGumbova;
        List<string> listaDrzava = new List<string>()
        { 
            "Afganistan", "Albanija", "Alžir", "Američka Samoa", "Andora", "Angola", "Angvila", "Antigva i Barbuda", "Argentina", "Armenija", "Aruba", "Australija","Austrija", "Azerbejdžan", "Bahami", "Bahrein",
            "Bangladeš", "Barbados", "Bjelorusija", "Belgija", "Belize", "Benin", "Bermuda", "Butan", "Bolivija", "Bosna i Hercegovina", "Bocvana", "Brunej Darussalam", "Bugarska", "Burkina Faso", "Burundi", "Kambodža",
            "Kamerun", "Kanada", "Centralna Afrička Republika", "Čad", "Čile", "Kina", "Kolumbija", "Komori", "Kongo", "Kostarika", "Hrvatska", "Kuba", "Cipar", "Češka", "Danska", "Džibuti", "Dominikanska Republika","Ekvador",
            "Egipat", "El Salvador", "Ekvatorijalna Gvineja", "Eritreja", "Estonija", "Etiopija", "Farski otoci", "Fidži", "Finska", "Francuska", "Gabon","Gambija", "Gruzija", "Njemačka", "Gana","Gibraltar", "Grčka", "Grenada",
            "Gvatemala", "Gvineja", "Gvineja Bisau", "Gvajana", "Haiti", "Vatikan", "Honduras", "Mađarska","Island", "Indija", "Indonezija", "Iran", "Irak", "Irska", "Izrael", "Italija", "Jamajka", "Japan", "Jordan", "Kazahstan",
            "Kenija", "Kiribati", "Sjeverna Koreja", "Južna Koreja", "Kuvajt", "Kirgistan", "Libanon", "Lesoto", "Liberija", "Lihtenštajn", "Litva", "Luksemburg", "Sjeverna Makedonija", "Madagaskar", "Malavi", "Malezija", "Maldivi",
            "Mali", "Malta", "Mauritanija", "Mauricijus", "Meksiko", "Moldavija", "Monako", "Mongolija", "Maroko", "Mozambik", "Mjanmar", "Namibija", "Nauru", "Nepal", "Nizozemska", "Novi Zeland", "Nikaragva", "Niger", "Nigerija",
            "Norveška", "Oman", "Pakistan", "Palau", "Panama", "Papua Nova Gvineja", "Peru", "Filipini", "Poljska", "Portoriko", "Katar", "Rumunjska", "Ruanda", "Sveta Helena", "Sveti Kitts i Nevis", "Sveti Vincent i Grenadini",
            "Samoa", "San Marino", "Sao Tome i Principe", "Saudijska Arabija", "Senegal", "Sejšeli", "Sijera Leone", "Singapur", "Slovačka", "Slovenija", "Salomonovi otoci", "Somalija", "JAR","Španjolska", "Šri Lanka", "Sudan",
            "Surinam", "Svaziland", "Švedska", "Sirija", "Tajvan", "Tadžikistan", "Tanzanija", "Tajland", "Timor-Leste", "Tokelau", "Trinidad i Tobago", "Turska", "Turkmenistan", "Tuvalu", "Uganda", "Ukrajina", "UAE", "UK",
            "SAD", "Urugvaj", "Uzbekistan", "Vanuatu", "Venezuela", "Vijetnam", "Zapadna Sahara", "Jemen", "Zambija","Zimbabve",
        };

        Dictionary<string, string> dictDrzave = new Dictionary<string, string>()
        {
            { "drkongo", "DR Kongo" },
            { "latvia", "Latvia"},
            { "brazil", "Brazil" },
            { "portugal", "Portugal"},
            { "tunis", "Tunis" },
            { "mne", "Crna Gora"},
            { "švicarska", "Švicarska"},
            { "fragv", "Francuska Gvajana" },
            { "paragvaj", "Paragvaj" },       
            { "obj", "Obala Bjelokosti"}
        };

        public FrmDrzave()
        {
            InitializeComponent();
            askQuestion(questionNumber);

            totalQuestions = 10;
            LblPitanjeDrzave.Text = "(" + questionNumber + "/" + totalQuestions + ")" + "Koja država je prikazana na slici?";
            LblProgressDrzave.Text = "(" + score + "/" + totalQuestions + ")";
        }

        // Instantiate random number generator.  
        private readonly Random _random = new Random();

        public List<Button> ListaGumbova => listaGumbova;

        // Generates a random number within a range.      
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        private void FrmDrzave_Load(object sender, EventArgs e)
        {
            LblPitanjeDrzave.Parent = PicPozadinaDrzave;
            LblPitanjeDrzave.BackColor = Color.Transparent;
            LblProgressDrzave.Parent = PicPozadinaDrzave;
            LblProgressDrzave.BackColor = Color.Transparent;
        }


        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
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
                dictDrzave = dictDrzave.OrderBy(x => Guid.NewGuid()).ToDictionary(item => item.Key, item => item.Value);
            }
            listaGumbova[0].Tag = 0;
            PbrDrzave.Increment(1);
            questionNumber++;
            askQuestion(questionNumber);
        }

        public string getKey(int random)
        {
            return dictDrzave.ElementAt(random).Key;
        }

        public void funkcija_odluke(int broj)
        {
            listaGumbova = new List<Button>() { BtnDrzavePrvi, BtnDrzaveDrugi, BtnDrzaveTreci, BtnDrzaveCetvrti };
            listaGumbova = listaGumbova.OrderBy(i => Guid.NewGuid()).ToList();

            PbxDrzave.Image = (Image)Properties.Resources.ResourceManager.GetObject(getKey(broj-1));
            LblProgressDrzave.Text = "(" + score + "/" + totalQuestions + ")";
            LblPitanjeDrzave.Text = "(" + questionNumber + "/" + totalQuestions + ")" + "Koja država je prikazana na slici?";

            listaGumbova[0].Text = dictDrzave.ElementAt(broj-1).Value;
            listaGumbova[1].Text = listaDrzava[RandomNumber(0, 4)];
            listaGumbova[2].Text = listaDrzava[RandomNumber(5, 9)];
            listaGumbova[3].Text = listaDrzava[RandomNumber(10, 14)];

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
                dictDrzave = dictDrzave.OrderBy(x => Guid.NewGuid()).ToDictionary(item => item.Key, item => item.Value);
            }

            listaDrzava = listaDrzava.OrderBy(i => Guid.NewGuid()).ToList();
            funkcija_odluke(qnum); 
        }

        private void BtnNazadDrzave_Click(object sender, EventArgs e)
        {
            score = 0;
            FrmKategorije frm = new FrmKategorije();
            frm.Show();
            this.Hide();
        }

    }
}
