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
    public partial class Exec02 : Form
    {
        public Exec02()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            new Entrar().Show();
            this.Hide();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            new Sair().Show();
            this.Hide();
        }

        private void btnencerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
