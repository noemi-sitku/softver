using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jav1
{
    public partial class Form2 : Form
    {
        public Adatok ujAdat = new Adatok();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            adatokBindingSource.DataSource = ujAdat;
        }
    }
}
