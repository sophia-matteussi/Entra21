using MVCp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCp1.Control
{
    public static class Controller02
    {
        public static List<string[]> AtualizaDG()
        {
            return DBConnection.AtualizaDG();
        }
        public static List<string> AtualizaCBPlacas()
        {
            List<string> lista = DBConnection.AtualizaCBPlaca();
            lista.Sort();
            return lista;

            //List<string> lista2 = DBConnection.GenericSelectUnit("Placa", "Estacionamento", "Placa is not null");
            //lista2.Sort();
            //return lista2;
        }
        
        public static double HoraEntrada(string placa, string hrsaida, bool lavou)
        {
            if (!String.IsNullOrEmpty(placa) && !String.IsNullOrEmpty(hrsaida))
            {
                double horadeEntrada = DBConnection.AtualizaVaga(placa);

                if (horadeEntrada != -1)
                {
                    double valorFinal = (Convert.ToDouble(hrsaida) - horadeEntrada) * 7;
                    if (lavou) //true
                    {
                        valorFinal += 60;
                    }
                    return valorFinal;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }
        public static List<string> AtualizaVagaLivre()
        {
            List<string> lista = DBConnection.GenericSelectUnit("idVaga", "Estacionamento", "Placa is null");
            lista.Sort();
            return lista;
        }

        public static bool Entrar(string placa, string horario, string vaga)
        {
            if (!string.IsNullOrEmpty(placa) && !string.IsNullOrEmpty(horario) && !string.IsNullOrEmpty(vaga))
            {
                if (DBConnection.Entrar(placa, horario,vaga))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
