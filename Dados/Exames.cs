/*
 * TrabalhoPOO_26011
 * Nome:Diogo Alves Ferreira
 * Email:a26011@alunos.ipca.pt
 * Engenharia de Sistemas Informáticos
 * Escola Superior de Técnologia
 * 7-11-2023
 */

using System;
using System.Collections.Generic;

// Externo
using ObjetosHospital;

namespace Dados
{
    /// <summary>
    /// Classe que gere um conjunto de Exames
    /// </summary>
    public class Exames
    {
        /// <summary>
        /// Campos privados para armazenar o estado de Exames
        /// </summary>
        #region ATRIBUTOS

        static List<Exame> exames;
        static int numExames;

        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        static Exames()
        {
            if (exames == null)
            {
                numExames = 0;
                exames = new List<Exame> ();
            }
        }

        #endregion

        /// <summary>
        /// Obtém as caracteristicas dos Exames
        /// </summary>
        #region PROPRIEDADES

        /// <summary>
        /// Retorna a Lista
        /// </summary>
        public static List<Exame> ListaExames
        {
            get { return new List<Exame>(exames); }
        }

        public static int NumExames
        {
            get { return numExames; }
        }

        #endregion

        #region OUTROS MÉTODOS

        /// <summary>
        /// Método para inserir um exame na Lista
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool InserirExame(Exame e)
        {
            if (e != null && !exames.Contains(e))
            {
                exames.Add(e);
                numExames++;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para remover um exame da Lista
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool RemoverExame(Exame e)
        {
            if (e != null && exames.Contains(e))
            {
                exames.Remove(e);
                numExames--;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para retornar o id de um exame feito por um paciente com determinado NUS
        /// </summary>
        /// <param name="nus"></param>
        /// <returns></returns>
        public static int VerificaExamePaciente(int nus,int idExame)
        {
            foreach (Exame e in exames)
            {
                if (e.Nus == nus && e.IdExame==idExame)
                {
                    return e.IdExame;
                }
            }
            return 0;
        }

        #endregion

        #endregion
    }
}
