using MVCp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCp1.Control
{
    class Controller01
    {
        
        public static int ContaExistente(string conta)
        {          
            int idConta = DBConnection01.ContaExistente(conta);         
            return idConta;
        }
        public static bool Saque(string valor, int idConta)
        {
            bool efetuado = DBConnection01.AtualizaSaque(Convert.ToInt32(valor), idConta);
            return efetuado;
        }

        public static void Deposito(string valor, int idConta)
        {
            DBConnection01.AtualizaDeposito(Convert.ToInt32(valor), idConta);
        }
    }
}
