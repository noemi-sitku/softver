namespace a_kigyok_kigyoznak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        int fejx = 100;
        int fejy = 100;
        int iranyx = 1;
        int iranyy = 0;
        int lepesszam;
        int hossz = 7;

        List<KigyoElem> kigyo = new List<KigyoElem>();
        Alma a = new Alma();
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            a.Top = 40;
            a.Left = 40;
            Controls.Add(a);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lepesszam++;

            fejx += iranyx * KigyoElem.Méret;
            fejy += iranyy * KigyoElem.Méret;

            foreach (object item in Controls)
            {
                if (item is KigyoElem)
                {
                    KigyoElem k = (KigyoElem)item;

                    if (k.Top == fejy && k.Left == fejx)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }

            KigyoElem ke = new KigyoElem();
            ke.Top = fejy;
            ke.Left = fejx;
            kigyo.Add(ke);
            Controls.Add(ke);

            
            

            if (lepesszam % 2 == 0) ke.BackColor = Color.LawnGreen;

            if (kigyo.Count > hossz)
            {
                KigyoElem levágandó = kigyo[0];
                kigyo.RemoveAt(0);
                Controls.Remove(levágandó);
            }

            if (a.Top ==  fejy && a.Left == fejx)
            {
                hossz++;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                iranyy = -1;
                iranyx = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                iranyy = 1;
                iranyx = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                iranyy = 0;
                iranyx = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                iranyy = 0;
                iranyx = 1;
            }
        }
    }
}