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
    public partial class Tabela01 : Form
    {
        public Tabela01()
        {
            InitializeComponent();
        }

        private void Tabela01_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnexecuta_Click(object sender, EventArgs e)
        {
            if (rbpessoa.Checked)
            {
                if(ControllerTabela.AdicionaPessoa(txtnome.Text, txtcpf.Text, txtrg.Text))
                {
                    MessageBox.Show("Deu bom");
                }
                else
                {
                    MessageBox.Show("Deu ruim");
                }
            }
            else if (rbfuncionario.Checked)
            {
                if (ControllerTabela.AdicionaFuncionario(txtnome.Text, txtcpf.Text, txtrg.Text, txtsalario.Text))
                {
                    MessageBox.Show("Correto!");
                }
                else
                {
                    MessageBox.Show("O processo falhou com êxito");
                }
            }
            else if (rbcliente.Checked)
            {
                if (ControllerTabela.AdicionaCliente(txtnome.Text, txtcpf.Text, txtrg.Text, Convert.ToInt32(cbvip.Checked)))
                {
                    MessageBox.Show("Correto!");
                }
                else
                {
                    MessageBox.Show("O processo falhou com êxito");
                }
            }
            LimpaTudo();

        }

        private void btnconfere_Click(object sender, EventArgs e)
        {
            if (rbpessoa.Checked)
            {
                List<string[]> lista = ControllerTabela.SelecionaPessoa();
                string acumuladora = "";

                foreach (var item in lista)
                {
                    foreach (var item1 in item)
                    {
                        acumuladora += item1 + "\t";
                    }
                    acumuladora += "\n";
                }
                MessageBox.Show(acumuladora);
            }
            else if (rbfuncionario.Checked)
            {
                List<string[]> lista = ControllerTabela.SelecionaFuncionarios();
                string acumuladora = "";

                foreach (var item in lista)
                {
                    foreach (var item1 in item)
                    {
                        acumuladora += item1 + "\t";
                    }
                    acumuladora += "\n";
                }
                MessageBox.Show(acumuladora);
            }
            else if (rbcliente.Checked)
            {
                List<string[]> lista = ControllerTabela.SelecionaCliente();
                string acumuladora = "";

                foreach (var item in lista)
                {
                    foreach (var item1 in item)
                    {
                        acumuladora += item1 + "\t";
                    }
                    acumuladora += "\n";
                }
                MessageBox.Show(acumuladora);
            }
        }

        private void LimpaTudo()
        {
            txtnome.Clear();
            txtcpf.Clear();
            txtrg.Clear();
            txtsalario.Clear();
            cbvip.Checked = false;
            rbcliente.Checked = false;
            rbfuncionario.Checked = false;
            rbpessoa.Checked = false;
        }
    }
}
