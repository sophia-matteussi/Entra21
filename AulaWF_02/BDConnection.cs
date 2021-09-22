using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaWF_02
{
    class BDConnection
    {
        //public static SqlConnection connection = new SqlConnection("Data Source=BUE205D96;Initial Catalog=BD_TurmaTarde;Persist Security Info=True;User ID=guest01;Password=@Senac2021");

        public static SqlConnection conn { get; set; } = new SqlConnection("Data Source=BUE205D96;Initial Catalog=BD_TurmaTarde;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
    }
}
