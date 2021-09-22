using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaWF_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnescolher_Click(object sender, EventArgs e)
        {
            if (rdbexec01.Checked)
            {
                new Exec01().Show();
                this.Hide();
            }
            else if (rdbexec02.Checked)
            {
                new Exec02().Show();
                this.Hide();
            }
        }
    }
}
