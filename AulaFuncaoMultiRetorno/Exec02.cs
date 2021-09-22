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

namespace AulaFuncaoMultiRetorno
{
    public partial class Exec02 : Form
    {
        public Exec02()
        {
            InitializeComponent();
        }

        private void Exec02_Load(object sender, EventArgs e)
        {
            List<string> id = new List<string>();
            List<string> nome = new List<string>();
            List<string> idade = new List<string>();
            List<string> cpf = new List<string>();
            List<string> rg = new List<string>();

            BuscaNoBD(out id, out nome, out idade, out cpf, out rg);

            for (int i = 0; i < id.Count; i++)
            {
                string[] vetor = { id[i], nome[i], idade[i], cpf[i], rg[i] };
                dgpessoas.Rows.Add(vetor);
            }
           
        }
        private void BuscaNoBD(out List<string> id, out List<string> nome, out List<string> idade, out List<string> cpf, out List<string> rg)
        {
            id = new List<string>();
            nome = new List<string>();
            idade = new List<string>();
            cpf = new List<string>();
            rg = new List<string>();
            string select = "SELECT * from dbo.Pessoa";
            SqlCommand cmd = new SqlCommand(select, BDConnection.conn);
            BDConnection.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id.Add(dr[0].ToString());
                nome.Add(dr[1].ToString());
                idade.Add(dr[2].ToString());
                cpf.Add(dr[3].ToString());
                rg.Add(dr[4].ToString());
            }
            dr.Close();
            BDConnection.conn.Close();

        }
        
      
    }

}