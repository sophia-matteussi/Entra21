using MVCp1.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCp1.View
{
    public partial class Exec01 : Form
    {
        public Exec01()
        {
            InitializeComponent();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            int idConta = Controller01.ContaExistente(txtconta.Text);
            if (idConta != -1)
            {
                new SaqueOuDeposito(idConta).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Conta invalida");
            }
            txtconta.Clear();
        }
    }
}
