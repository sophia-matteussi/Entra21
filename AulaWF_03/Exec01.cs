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
    public partial class Exec01 : Form
    {
        public Exec01()
        {
            InitializeComponent();
        }

        private void btnconfere_Click(object sender, EventArgs e)
        {
            dgpessoa.Rows.Clear();
            string select = $"SELECT * from dbo.Pessoa WHERE Nome = '{cbnomes.Text}'";
            SqlCommand cmd = new SqlCommand(select, BDConnection.Connection);
            BDConnection.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string[] vetor = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString() };
                dgpessoa.Rows.Add(vetor);

            }
            dr.Close();
            BDConnection.Connection.Close();


        }

        private void Exec01_Load(object sender, EventArgs e)
        {
            dgpessoa.RowTemplate.Height = 50;
            string select =  "SELECT Nome from dbo.Pessoa";
            SqlCommand cmd = new SqlCommand(select, BDConnection.Connection);
            BDConnection.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbnomes.Items.Add(dr[0].ToString());
            }
            dr.Close();
            BDConnection.Connection.Close();

        }
    }
}
