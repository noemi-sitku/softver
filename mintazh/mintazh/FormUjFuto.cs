using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mintazh
{
    public partial class FormUjFuto : Form
    {
        public Futok ujFuto = new Futok();
        public FormUjFuto()
        {
            InitializeComponent();
        }

        private void FormUjFuto_Load(object sender, EventArgs e)
        {
            futokBindingSource.DataSource = ujFuto;
        }
    }
}
