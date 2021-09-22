using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec02_AulaWF03
{
    public static class DBConnection
    {
        public static SqlConnection Connection { get; set; } = new SqlConnection("Data Source=BUE205D96;Initial Catalog=BD_TurmaTarde;Persist Security Info=True;User ID=guest01;Password=@Senac2021");

        public static void Executar(SqlCommand cmd)
        {
            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
    }

}
