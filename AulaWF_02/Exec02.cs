using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaWF_02
{
    public partial class Exec02 : Form
    {
        public Exec02()
        {
            InitializeComponent();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
            //Application.Exit();
        }

        private void btSacar_Click(object sender, EventArgs e)
        {
            Saque f = new Saque();
            this.FindForm().Hide();
            f.Show();

            //ou

            //new Saque().Show();
            //this.Hide();
        }

        private void btcontasativas_Click(object sender, EventArgs e)
        {
            new Contas().Show();
            this.Hide();
        }

        private void btdeposito_Click(object sender, EventArgs e)
        {
            new Deposito().Show();
            this.Hide();
        }
    }
}
