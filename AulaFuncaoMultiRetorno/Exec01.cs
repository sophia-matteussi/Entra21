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
    public partial class Exec01 : Form
    {
        public Exec01()
        {
            InitializeComponent();
        }

        private void btncalcula_Click(object sender, EventArgs e)
        {
            double tempSoma, tempSub, tempMulti, tempDivisao;
            CalculaValor(Converte(txtvalor1.Text), Converte(txtvalor2.Text), out tempSoma, out tempSub, out tempMulti, out tempDivisao);

            string[] resultados = { tempSoma.ToString(), tempSub.ToString(), tempMulti.ToString(), tempDivisao.ToString() };
            dgresultado.Rows.Add(resultados);
            txtvalor1.Clear();
            txtvalor2.Clear();
        }

        private double Converte(string txt)
        {
            return Convert.ToDouble(txt);
        }

        private void CalculaValor(double valor1, double valor2, out double soma, out double sub, out double multi, out double divisao)
        {
            soma = valor1 + valor2;
            sub = valor1 - valor2;
            multi = valor1 * valor2;
            divisao = valor1 / valor2;
        }

        private void btnencerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
