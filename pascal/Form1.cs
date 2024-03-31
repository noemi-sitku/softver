namespace pascal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    if (sor >= oszlop)
                    {
                        Button b = new Button();
                        b.Top = sor * 60;
                        b.Left = oszlop * 60;
                        b.Height = 60;
                        b.Width = 60;
                        this.Controls.Add(b);
                        int p = Faktorialis(sor) / (Faktorialis(oszlop) * (Faktorialis(sor - oszlop)));
                        b.Text = p.ToString();
                    }

                }
            }
        }

        int Faktorialis(int sor)
        {
            int eredm�ny = 1;
            for (int oszlop = 1; oszlop <= sor; oszlop++) eredm�ny *= oszlop;

            return eredm�ny;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}