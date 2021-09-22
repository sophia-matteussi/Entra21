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
    public partial class Exec03 : Form
    {
        public Exec03()
        {
            InitializeComponent();
        }

        public int preco;

        private void btnadd_Click(object sender, EventArgs e)
        {
            string select = $"SELECT * from dbo.Produto WHERE idProduto = {txtid.Text} ";
            SqlCommand cmd = new SqlCommand(select, DBConnection.Connection);
            DBConnection.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string[] linha = new string[4];
                for (int i = 0; i < 4; i++)
                {
                    linha[i] = dr[i].ToString();
                }
                dgCarrinho.Rows.Add(linha);
            }
            dr.Close();
            DBConnection.Connection.Close();
            string select2 = $"SELECT Preco from dbo.Produto WHERE idProduto = {txtid.Text}";
            SqlCommand cmmd = new SqlCommand(select2, DBConnection.Connection);
            DBConnection.Connection.Open();
            SqlDataReader dr2 = cmmd.ExecuteReader();
            while (dr2.Read())
            {
                string temp = dr2[0].ToString();
                preco += Convert.ToInt32(temp);
            }
            dr2.Close();
            DBConnection.Connection.Close();
        }

        private void Exec03_Load(object sender, EventArgs e)
        {
            string select = $"SELECT * from dbo.Produto";
            SqlCommand cmd = new SqlCommand(select, DBConnection.Connection);
            DBConnection.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string[] linha = new string[4];
                for (int i = 0; i < 4; i++)
                {
                    linha[i] = dr[i].ToString();
                }
                dgProdutos.Rows.Add(linha);
            }
            dr.Close();
            DBConnection.Connection.Close();
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O valor final da sua compra é R$" + preco);
            dgCarrinho.Rows.Clear();
            preco = 0;
        }
    }
}
