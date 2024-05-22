using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace labirintus_projekt
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        private int lepesekSzama = 0;
        private Label lepesekLabel;
        private Label idoLabel;
        private Timer idoTimer;
        private int elteltIdo = 0;

        public Form1()
        {
            InitializeComponent();
        }

        PictureBox jatekos = new PictureBox();
        PictureBox cel = new PictureBox();
        PictureBox start = new PictureBox();
        List<PictureBox> fal = new List<PictureBox>();

        private void Form1_Load(object sender, EventArgs e)
        {
            lepesekLabel = new Label();
            lepesekLabel.Location = new Point(1250, 10);
            lepesekLabel.AutoSize = true;
            lepesekLabel.Text = "Lépések száma: 0";
            Controls.Add(lepesekLabel);

            idoLabel = new Label();
            idoLabel.Location = new Point(1250, 40);
            idoLabel.AutoSize = true;
            idoLabel.Text = "Eltelt idõ: 0 s";
            Controls.Add(idoLabel);

            idoTimer = new Timer();
            idoTimer.Interval = 1000;
            idoTimer.Tick += IdoTimer_Tick_1;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = openFileDialog.FileName;
                        using (StreamReader sr = new StreamReader(filePath))
                        {
                            int s = 0;
                            while (!sr.EndOfStream)
                            {
                                string sor = sr.ReadLine();
                                for (int oszlop = 0; oszlop < sor.Length; oszlop++)
                                {
                                    if (sor[oszlop] == '#')
                                    {
                                        PictureBox pb = new PictureBox();
                                        pb.Location = new Point(oszlop * 20, s * 20);
                                        pb.Size = new Size(20, 20);
                                        pb.BackColor = Color.Black;
                                        this.Controls.Add(pb);
                                        fal.Add(pb);
                                    }
                                    else if (sor[oszlop] == 'S')
                                    {
                                        start.Location = new Point(oszlop * 20, s * 20);
                                        start.Size = new Size(20, 20);
                                        start.BackColor = Color.Fuchsia;
                                        Label startLabel = new Label();
                                        startLabel.Text = "S";
                                        startLabel.ForeColor = Color.White;
                                        startLabel.Location = new Point(2, 2);
                                        start.Controls.Add(startLabel);

                                        this.Controls.Add(start);
                                    }
                                    else if (sor[oszlop] == 'C')
                                    {
                                        cel.Location = new Point(oszlop * 20, s * 20);
                                        cel.Size = new Size(20, 20);
                                        cel.BackColor = Color.Green;
                                        Label celLabel = new Label();
                                        celLabel.Text = "C";
                                        celLabel.ForeColor = Color.White;
                                        celLabel.Location = new Point(2, 2);
                                        cel.Controls.Add(celLabel);
                                        this.Controls.Add(cel);
                                    }
                                }
                                s++;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hiba történt a fájl beolvasása közben: " + ex.Message);
                    }
                }
            }


            jatekos.Location = new Point(0, 0);
            jatekos.Size = new Size(20, 20);
            jatekos.BackColor = Color.Red;
            Controls.Add(jatekos);

            KeyDown += Form1_KeyDown;
            idoTimer.Start();
        }

        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = jatekos.Location.X;
            int y = jatekos.Location.Y;

            if (e.KeyCode == Keys.Right)
            {
                x += 20;
            }

            if (e.KeyCode == Keys.Left)
            {
                x -= 20;
            }

            if (e.KeyCode == Keys.Up)
            {
                y -= 20;
            }

            if (e.KeyCode == Keys.Down)
            {
                y += 20;
            }

            var wall = fal.FirstOrDefault(w => w.Location.X == x && w.Location.Y == y);
            if (wall == null)
            {
                jatekos.Location = new Point(x, y);
                lepesekSzama++;
                lepesekLabel.Text = "Lépések száma: " + lepesekSzama / 2;

                if (jatekos.Bounds.IntersectsWith(cel.Bounds))
                {
                    idoTimer.Stop();
                    using (Form2 form2 = new Form2())
                    {
                        if (form2.ShowDialog() == DialogResult.OK)
                        {
                            jatekos.Location = start.Location;
                            lepesekSzama = 0;
                            lepesekLabel.Text = "Lépések száma: 0";
                            elteltIdo = 0;
                            idoLabel.Text = "Eltelt idõ: 0 s";
                            idoTimer.Start();
                        }
                    }
                }

            }
        }

        private void IdoTimer_Tick_1(object sender, EventArgs e)
        {
            elteltIdo++;
            idoLabel.Text = "Eltelt idõ: " + elteltIdo + " s";
        }
    }
}
