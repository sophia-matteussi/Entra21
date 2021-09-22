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

namespace AulaWF_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=BUE205D96;Initial Catalog=BD_TurmaTarde;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
            string insert = $"INSERT into dbo.Pessoa (Nome, Idade, Cpf) values ('{txtNome.Text}', {txtIdade},'{txtCPF}')";
            SqlCommand cmd = new SqlCommand(insert, conn);
            string select = $"SELECT * from dbo.Pessoa WHERE Nome = '{txtNome}'";
        }
    }
}
