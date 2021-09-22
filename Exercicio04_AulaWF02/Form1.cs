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

namespace Exercicio04_AulaWF02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=BUE205D96;Initial Catalog = BD_TurmaTarde; Persist Security Info=True;User ID = guest01; Password=@Senac2021");

        private void btninserir_Click(object sender, EventArgs e)
        {
            bool add = false;
            string select = $"SELECT * from dbo.Nome WHERE Nome = '{txtnome.Text}'";
            SqlCommand cmd = new SqlCommand(select,conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Este nome já existe na lista!\nInsira um nome válido.");
            }
            else
            {
               
                add = true;
            }
            dr.Close();
            conn.Close();

            if (add)
            {
                string insert = $"INSERT into dbo.Nome (Nome) values ('{txtnome.Text}')";
                cmd = new SqlCommand(insert, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Nome inserido!");
            }

        }

        private void listnomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            listnomes.Items.Clear();
            string select = "SELECT * from dbo.Nome";
            SqlCommand cmd = new SqlCommand(select,conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listnomes.Items.Add(dr[1].ToString());
            }
            dr.Close();
            conn.Close();
        }
    }
}
