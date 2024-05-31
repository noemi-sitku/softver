using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace mintazh
{
    public partial class Form1 : Form
    {
        BindingList<Futok> futok = new();
        public Form1()
        {
            InitializeComponent();
            //dataGridView1.DataSource = futok; //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            futokBindingSource.DataSource = futok;
        }

        private void buttonBetoltes_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("futoversenyzok.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var t = csv.GetRecords<Futok>();

                foreach (var item in t)
                {
                    futok.Add(item);
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
                    csv.WriteRecords(futok);

                    streamWriter.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (futokBindingSource.Current == null) return;
            if (MessageBox.Show("A", "B", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                futokBindingSource.RemoveCurrent();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormUjFuto formUjFuto = new FormUjFuto();
            if (formUjFuto.ShowDialog() == DialogResult.OK)
            {
                futokBindingSource.Add(formUjFuto.ujFuto);
            }
        }
    }
}
