using System.Windows.Forms;

namespace _5hetes
{
    public partial class Form1 : Form
    {
        List<K�rd�s> �sszesK�rd�s;
        List<K�rd�s> AktualisK�rd�sek;
        int Megjelen�tettK�rd�sSz�ma = 5;




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            �sszesK�rd�s = K�rd�sekBet�lt�se();
            AktualisK�rd�sek = new List<K�rd�s>();

            for (int i = 0; i < 7; i++)
            {
                AktualisK�rd�sek.Add(�sszesK�rd�s[0]);
                �sszesK�rd�s.RemoveAt(0);
            }

            dataGridView1.DataSource = AktualisK�rd�sek;
            K�rd�sMegjen�t�s(AktualisK�rd�sek[Megjelen�tettK�rd�sSz�ma]);
        }

        List<K�rd�s> K�rd�sekBet�lt�se()
        {
            List<K�rd�s> k�rd�sek = new List<K�rd�s>();
            StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine() ?? string.Empty;
                string[] t�mb = sor.Split("\t");

                if (t�mb.Length != 7) continue;


                K�rd�s k = new K�rd�s();
                k.K�rd�sSz�veg = t�mb[1].ToUpper();
                k.V�lasz1 = t�mb[2].Trim('"');
                k.V�lasz2 = t�mb[3].Trim('"');
                k.V�lasz3 = t�mb[4].Trim('"');
                k.URL = t�mb[5].Trim('"');
                int x = 0;
                int.TryParse(t�mb[6], out x);

                k.HelyesV�lasz = x;

                k�rd�sek.Add(k);

            }
            sr.Close();
            return k�rd�sek;
        }

        void K�rd�sMegjen�t�s(K�rd�s k�rd�s)
        {
            label1.Text = k�rd�s.K�rd�sSz�veg;
            textBox1.Text = k�rd�s.V�lasz1;
            textBox2.Text = k�rd�s.V�lasz2;
            textBox3.Text = k�rd�s.V�lasz3;

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;


            if (string.IsNullOrEmpty(k�rd�s.URL))
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + k�rd�s.URL);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Megjelen�tettK�rd�sSz�ma++;
            if (Megjelen�tettK�rd�sSz�ma == AktualisK�rd�sek.Count) Megjelen�tettK�rd�sSz�ma = 0;


            K�rd�sMegjen�t�s(AktualisK�rd�sek[Megjelen�tettK�rd�sSz�ma]);

        }



        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Fuchsia;
            Sz�nez�s();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Fuchsia;
            Sz�nez�s();
        }
        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Fuchsia;
            Sz�nez�s();
        }

        void Sz�nez�s()
        {
            int helyesV�lasz = AktualisK�rd�sek[Megjelen�tettK�rd�sSz�ma].HelyesV�lasz;

            if (helyesV�lasz == 1) textBox1.BackColor = Color.Green;
            if (helyesV�lasz == 2) textBox1.BackColor = Color.Green;
            if (helyesV�lasz == 3) textBox1.BackColor = Color.Green;



        }
    }
}
