using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace mintafeladat
{
    public partial class Form1 : Form
    {
        BindingList<Adat> adat = new();
        public Form1()
        {
            InitializeComponent();
            //dataGridView1.DataSource = adat; //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            adatBindingSource.DataSource = adat;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("gyakorlo.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var t = csv.GetRecords<Adat>();

                foreach (var item in t)
                {
                    adat.Add(item);
                }
                sr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
                    csv.WriteRecords(adat);

                    streamWriter.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (adatBindingSource.Current == null) return;

            if (MessageBox.Show("A", "B", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                adatBindingSource.RemoveCurrent();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormUjAdat formUjAdat = new FormUjAdat();

            if (formUjAdat.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
