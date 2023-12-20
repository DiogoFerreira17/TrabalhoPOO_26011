/*
 * TrabalhoPOO_26011
 * Nome:Diogo Alves Ferreira
 * Email:a26011@alunos.ipca.pt
 * Engenharia de Sistemas Informáticos
 * Escola Superior de Técnologia
 * 7-11-2023
 */

using System.Collections.Generic;

// Externo
using ObjetosHospital;
using Dados;

namespace Regras
{
    public class RegrasDiagnosticos
    {
        /// <summary>
        /// Método para inserir um diagnostico na Lista
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool InserirDiagnostico(Diagnostico d)
        {
            if (d.IdExame != 0) // se o diagnostico nao corresponder a uma consulta não é inserido
            {
                return Diagnosticos.InserirDiagnostico(d);
            }
            return false;

        }

        /// <summary>
        /// Método para retornar a Lista de diagnosticos
        /// </summary>
        /// <returns></returns>
        public static List<Diagnostico> ListaDiagnosticos()
        {
            return Diagnosticos.TodosDiagnosticos();
        }
    }
}
