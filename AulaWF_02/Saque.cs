using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaWF_02
{
    public partial class Saque : Form
    {
        public Saque()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            new Exec02().Show();
            this.Hide();
        }

        private void btextrato_Click(object sender, EventArgs e)
        {
            int valor = RecebeSaldo();
            if (valor != -1)
            {
                MessageBox.Show($"Saldo : {valor:c}");
            }
        }
        
        private int RecebeSaldo()
        {
            int retorno = -1;
            string select = $"SELECT Saldo from dbo.Conta WHERE NumeroConta = '{txtconta.Text}'";
            SqlCommand cmd = new SqlCommand(select, BDConnection.conn);
            BDConnection.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                retorno = Convert.ToInt32(dr[0]);
            }
            else
            {
                MessageBox.Show("Numero da conta não encontrado");
            }
            dr.Close();
            BDConnection.conn.Close();

            return retorno;
        }

        private void btsaque_Click(object sender, EventArgs e)
        {
            int saldo = RecebeSaldo();
            if (saldo >= Convert.ToInt32(txtqnt.Text))
            {
                //saque
                string update = $"UPDATE dbo.Conta set Saldo -= {txtqnt.Text} WHERE NumeroConta = '{txtconta.Text}'";
                SqlCommand cmd = new SqlCommand(update, BDConnection.conn);
                BDConnection.conn.Open();
                cmd.ExecuteNonQuery();
                BDConnection.conn.Close();
                txtconta.Clear();
                txtqnt.Clear();
            }
            else
            {
                MessageBox.Show($"Saldo : {saldo:c}\nSaldo insuficiente em sua conta bancária.\nPor que você não faz um depósito?");
            }
        }
    }
}
