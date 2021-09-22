using MVCp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCp1.Control
{
    public static class ControllerTabela
    {
        public static bool AdicionaPessoa(string nome, string cpf, string rg)
        {
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(cpf) && !string.IsNullOrEmpty(rg))
            {
                return ModelTabela.AdicionaPessoa(nome, cpf, rg);
            }
            else
            {
                return false;
            }
            return true;
        }

        public static List<string[]> SelecionaPessoa()
        {
            return ModelTabela.SelecionaPessoa();
        }

        public static bool AdicionaFuncionario(string nome, string cpf, string rg, string salario)
        {
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(cpf) && !string.IsNullOrEmpty(rg) && !string.IsNullOrEmpty(salario))
            {
                return ModelTabela.AdicionaFuncionario(nome, cpf, rg, salario);
            }
            else
            {
                return false;
            }
            return true;
        }
        
        public static List<string[]> SelecionaFuncionarios()
        {
            return ModelTabela.SelecionaFuncionarios();
        }

        public static bool AdicionaCliente(string nome, string cpf, string rg, int vip)
        {
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(cpf) && !string.IsNullOrEmpty(rg))
            {           
                    return ModelTabela.AdicionaCliente(nome, cpf, rg, vip);             
            }
            else
            {
                return false;
            }
            return true;
        }
        public static List<string[]> SelecionaCliente()
        {
            return ModelTabela.SelecionaCliente();
        }

    }
}
