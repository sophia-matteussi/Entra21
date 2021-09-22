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

namespace Exec02_AulaWF03
{
    public partial class Exec04 : Form
    {
        public Exec04()
        {
            InitializeComponent();
        }
        private void Atualiza()
        {
            dgHistorico.Rows.Clear();
            string select = "SELECT * from dbo.Historico";
            SqlCommand cmd = new SqlCommand(select, DBConnection.Connection);
            DBConnection.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string[] linha = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    linha[i] = dr[i].ToString();
                }
                dgHistorico.Rows.Add(linha);
            }
            dr.Close();
            DBConnection.Connection.Close();
        }

        private void Exec04_Load(object sender, EventArgs e)
        {
            Atualiza();
        }

        int custos = 0;
        int ganhos = 0;
        int lucro = 0;
        string periodo = "";
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (rbcustos.Checked)
            {
                custos = Convert.ToInt32(txtinsert.Text);
                MessageBox.Show("ADICIONADO");
                txtinsert.Clear();              
            }
            else if (rbganhos.Checked)
            {
                ganhos = Convert.ToInt32(txtinsert.Text);
                MessageBox.Show("ADICIONADO");
                txtinsert.Clear();

            }
            else if (rblucro.Checked)
            {
                lucro = Convert.ToInt32(txtinsert.Text);
                MessageBox.Show("ADICIONADO");
                txtinsert.Clear();

            }
            else if (rbperiodo.Checked)
            {
                periodo = txtinsert.Text;
                MessageBox.Show("ADICIONADO");
                txtinsert.Clear();
            }
            else
            {
                MessageBox.Show("ERRO");
            }

        }


        private void lblaviso_Click(object sender, EventArgs e)
        {
            //errado
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insert = $"INSERT into dbo.Historico (Custos, Ganhos, Lucro, Periodo) values ({custos} , {ganhos} , {lucro} , '{periodo}')";
            SqlCommand cmd = new SqlCommand(insert, DBConnection.Connection);
            DBConnection.Connection.Open();
            cmd.ExecuteNonQuery();
            DBConnection.Connection.Close();
            Atualiza();
            insert = "";
        }
    }
}
