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

namespace AulaWF_03
{
    public partial class Sair : Form
    {
        public Sair()
        {
            InitializeComponent();
        }

        private void txtplaca_TextChanged(object sender, EventArgs e)
        {
            //errado!
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            string update = $"UPDATE dbo.Vaga set PlacaVu = 'NULL', Ocupada = 0 WHERE PlacaVu = '{txtplaca.Text}'";
            SqlCommand cmd = new SqlCommand(update, BDConnection.Connection);
            BDConnection.Connection.Open();
            cmd.ExecuteNonQuery();
            BDConnection.Connection.Close();
            MessageBox.Show("REMOVIDO");
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            new Exec02().Show();
            this.Hide();
        }
    }
}
