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
    public partial class Deposito : Form
    {
        public Deposito()
        {
            InitializeComponent();
        }

        private void btvoltardep_Click(object sender, EventArgs e)
        {
            new Exec02().Show();
            this.Hide();
        }

        private void btextratodep_Click(object sender, EventArgs e)
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
            string select = $"SELECT Saldo from dbo.Conta WHERE NumeroConta = '{txtcontadep.Text}'";
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

        private void btdeposito_Click(object sender, EventArgs e)
        {
            int depositar = RecebeSaldo();
            Convert.ToInt32(txtvalordep.Text);          
               
            string update = $"UPDATE dbo.Conta set Saldo += {txtvalordep.Text} WHERE NumeroConta = '{txtcontadep.Text}'";
            SqlCommand cmd = new SqlCommand(update, BDConnection.conn);
            BDConnection.conn.Open();
            cmd.ExecuteNonQuery();
            BDConnection.conn.Close();
            txtcontadep.Clear();
            txtvalordep.Clear();
            
        }
    }
}
