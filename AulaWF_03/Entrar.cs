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
    public partial class Entrar : Form
    {
        public Entrar()
        {
            InitializeComponent();
        }

        private void Entrar_Load(object sender, EventArgs e)
        {
            string select = "SELECT idVaga from dbo.Vaga WHERE Ocupada = 0";
            SqlCommand cmd = new SqlCommand(select, BDConnection.Connection);
            BDConnection.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbvagas.Items.Add(dr[0].ToString());
            }
            dr.Close();
            BDConnection.Connection.Close();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            string update = $"UPDATE dbo.Vaga set PlacaVu = '{txtplaca.Text}', Ocupada = 1 WHERE idVaga = {cbvagas.Text}";
            SqlCommand cmd = new SqlCommand(update, BDConnection.Connection);
            BDConnection.Connection.Open();
            cmd.ExecuteNonQuery();
            BDConnection.Connection.Close();
            MessageBox.Show("ATUALIZADO");
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            new Exec02().Show();
            this.Hide();
        }
    }
}
