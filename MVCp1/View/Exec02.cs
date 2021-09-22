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
    public partial class Exec02 : Form
    {
        public Exec02()
        {
            InitializeComponent();
        }

        private void Exec02_Load(object sender, EventArgs e)
        {
            AtualizaTudo();
        }

        private void AtualizaCB()
        {
            List<string> lista = Controller02.AtualizaCBPlacas();
            cbplacas.Items.Clear();
            foreach (var item in lista)
            {
                cbplacas.Items.Add(item);
            }
        }

        private void AtualizaDG()
        {
            List<string[]> elementos = Controller02.AtualizaDG();
            dgestacionamento.Rows.Clear();
            foreach (var item in elementos)
            {
                dgestacionamento.Rows.Add(item);
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Controller02.HoraEntrada(cbplacas.Text, txthorasaida.Text, rbsim.Checked).ToString());
            AtualizaDG();
            AtualizaCB();
            AtualizaVagaLivre();
            txthorasaida.Clear();
        }
        private void AtualizaTudo()
        {
            AtualizaDG();
            AtualizaCB();
            AtualizaVagaLivre();
            txthorasaida.Clear();
            txthoraentrada.Clear();
            txtplaca.Clear();
            cbvagas.Text = null;
            cbplacas.Text = null;
        }

        private void btnencerra_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            if (Controller02.Entrar(txtplaca.Text, txthoraentrada.Text, cbvagas.Text))
            {
                MessageBox.Show("Carro estacionado!");
            }
            else
            {
                MessageBox.Show("Faltou informações");
            }
            AtualizaTudo();
        }
        private void AtualizaVagaLivre()
        {
            List<string> lista = Controller02.AtualizaVagaLivre();
            cbvagas.Items.Clear();
            foreach (var item in lista)
            {
                cbvagas.Items.Add(item);
            }
            //AtualizaTudo();

        }
    }
}
