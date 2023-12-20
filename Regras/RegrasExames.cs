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
    public class RegrasExames
    {
        /// <summary>
        /// Método para inserir um exame na Lista
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool InserirExame(Exame e)
        {
            return Exames.InserirExame(e);
        }

        /// <summary>
        /// Método para retornar o id de um exame feito por um paciente
        /// </summary>
        /// <param name="nus"></param>
        /// <returns></returns>
        public static int VerificaExamePaciente(int nus, int idExame)
        {
            return Exames.VerificaExamePaciente(nus, idExame);
        }

        /// <summary>
        /// Método para retornar a Lista de exames
        /// </summary>
        /// <returns></returns>
        public static List<Exame> ListaExames()
        {
            return Exames.TodosExames();
        }

        /// <summary>
        /// Método para retornar a lista de exames de um paciente
        /// </summary>
        /// <param name="nus"></param>
        /// <returns></returns>
        public static List<Exame> ExamesPaciente(int nus)
        {
            return Exames.ExamesPaciente(nus);
        }

        /// <summary>
        /// Método para calcular o custo dos exames de um paciente
        /// </summary>
        /// <param name="examesPaciente"></param>
        /// <returns></returns>
        public static double CustoExamesPaciente(List<Exame> examesPaciente)
        {
            return Exames.CustoExamesPaciente(examesPaciente);
        }
    }
}
