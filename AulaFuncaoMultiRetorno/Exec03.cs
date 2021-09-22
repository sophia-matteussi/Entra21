using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaFuncaoMultiRetorno
{
    public partial class Exec03 : Form
    {
        public Exec03()
        {
            InitializeComponent();
        }

        private double valorEmCaixa;
        private void btncalcula_Click(object sender, EventArgs e)
        {
            double tempLiquido, tempNovoValor;
            bool tempLucro;
            CalculaMes(Converte(lblvaloremcaixalabel.Text), Converte(txtdespesas.Text), Converte(txtganhos.Text), out tempLiquido, out tempNovoValor, out tempLucro);

            string[] valores = { txtganhos.Text, txtdespesas.Text, tempLiquido.ToString(), tempLucro.ToString() };
            dgfaturamento.Rows.Add(valores);

            if (tempLiquido <= 0)
            {
                dgfaturamento.Rows[dgfaturamento.Rows.Count - 1].Cells[3].Style.ForeColor = Color.DarkRed;
            }

            lblvaloremcaixalabel.Text = tempNovoValor.ToString();
            txtdespesas.Clear();
            txtganhos.Clear();
        }

        private void Exec03_Load(object sender, EventArgs e)
        {
            valorEmCaixa = 1800;
            lblvaloremcaixalabel.Text = valorEmCaixa.ToString(); 
        }
        private double Converte(string txt)
        {
            return Convert.ToDouble(txt);
        }

        private void CalculaMes(double valorEmCaixa, double despesasDoMes, double ganhosDoMes, out double valorLiquido, out double novoValorEmCaixa, out bool DeuLucro)
        {
            valorLiquido = ganhosDoMes - despesasDoMes;
            novoValorEmCaixa = valorEmCaixa + valorLiquido;
            if (valorLiquido > 0)
            {
                DeuLucro = true;
            }
            else
            {
                DeuLucro = false;
            }
        }

        private void btmsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
