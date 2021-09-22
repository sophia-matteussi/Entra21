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
    public partial class exec02 : Form
    {
        public exec02()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //errado
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //errado
        }

        private void exec02_Load(object sender, EventArgs e)
        {
            dtvproduto.Columns.Add("FornecedorCol", "Fornecedor");
            dtvproduto.Columns[3].Width = 300;
            AtualizaDG();

        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnexecutar_Click(object sender, EventArgs e)
        {
            if (checkadd.Checked)
            {
                string insert = $"INSERT into dbo.Produto (Nome, Preco, Fornecedor) values ('{txtnome.Text}',{txtpreco.Text}, '{txtfornecedor.Text}')";
                SqlCommand cmd = new SqlCommand(insert, DBConnection.Connection);
                DBConnection.Executar(cmd);
                MessageBox.Show("PRODUTO ADICIONADO");
                AtualizaDG();

            }
            else if (checkremove.Checked)
            {
                string delete = $"DELETE from dbo.Produto WHERE idProduto = '{txtnome.Text}'";
                SqlCommand cmd = new SqlCommand(delete, DBConnection.Connection);
                DBConnection.Executar(cmd);
                MessageBox.Show("PRODUTO REMOVIDO!");
                AtualizaDG();
            }
            txtnome.Clear();
            txtpreco.Clear();
            txtfornecedor.Clear();
        }
        private void AtualizaDG()
        {
            dtvproduto.Rows.Clear();
            string select = "SELECT * from dbo.Produto";
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
                dtvproduto.Rows.Add(linha);
            }
            dr.Close();
            DBConnection.Connection.Close();
        }

        private void checkadd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkadd.Checked)
            {
                checkremove.Checked = false;
                txtfornecedor.Visible = true;
                txtpreco.Visible = true;
                lblnome.Text = "Nome";
                lblpreco.Visible = true;
                lblfornecedor.Visible = true;
            }
        }

        private void checkremove_CheckedChanged(object sender, EventArgs e)
        {
            if (checkremove.Checked)
            {
                checkadd.Checked = false;
                txtfornecedor.Visible = false;
                txtpreco.Visible = false;
                lblnome.Text = "ID";
                lblpreco.Visible = false;
                lblfornecedor.Visible = false;
            }
        }
    }
}
