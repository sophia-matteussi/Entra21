using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec02_AulaWF03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnexec02_Click(object sender, EventArgs e)
        {
            new exec02().Show();
            this.Hide();
        }

        private void btnexec01_Click(object sender, EventArgs e)
        {
            new Exec01().Show();
            this.Hide();
        }

        private void btnexec03_Click(object sender, EventArgs e)
        {
            new Exec03().Show();
            this.Hide();
        }

        private void btnexec04_Click(object sender, EventArgs e)
        {
            new Exec04().Show();
            this.Hide();
        }
    }
}
