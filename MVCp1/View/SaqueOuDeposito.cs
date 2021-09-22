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
    public partial class SaqueOuDeposito : Form
    {
        private int _ID;
        public SaqueOuDeposito()
        {
            InitializeComponent();
        }

        public SaqueOuDeposito(int id)
        {
            InitializeComponent();
            _ID = id;
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            new Exec01().Show();
            this.Hide();
        }

        private void btnfinalizarop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnconfirma_Click(object sender, EventArgs e)
        {
            if (rbsaque.Checked)
            {
                bool efetuado = Controller01.Saque(txtvalor.Text, _ID);
                if (efetuado)
                {
                    MessageBox.Show("Saque efetuado!");
                }
                else
                {
                    MessageBox.Show("Saldo da conta inválido");
                }
                
            }
            else if (rbdeposito.Checked)
            {
                Controller01.Deposito(txtvalor.Text, _ID);
                MessageBox.Show("Efetuado");
            }
            else
            {
                MessageBox.Show("***ERRO***");
            }
            txtvalor.Clear();
        }
    }
}
