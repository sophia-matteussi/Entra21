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
    public partial class Contas : Form
    {
        public Contas()
        {
            InitializeComponent();
        }

        private void Contas_Load(object sender, EventArgs e)
        {
            string select = "SELECT * from dbo.Conta";
            SqlCommand cmd = new SqlCommand(select, BDConnection.conn);
            BDConnection.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string temp = $"{dr[0]}     {dr[1]}     {dr[2]:c}";
                listContas.Items.Add(temp);
            }
            dr.Close();
            BDConnection.conn.Close();
        }

        private void btvoltar_Click(object sender, EventArgs e)
        {
            new Exec02().Show();
            this.Hide();
        }
    }
}
