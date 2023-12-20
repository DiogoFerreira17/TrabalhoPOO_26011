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
using Excecoes;

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

        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        static Exames()
        {
            if (exames == null)
            {
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
                if (e.Data < new DateTime(2015, 1, 1))
                {
                    throw new DataInvalidaException("A base de dados não contem exames anteriores a 2015");
                }
                exames.Add(e);
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

        /// <summary>
        /// Método para retornar a Lista de exames
        /// </summary>
        /// <returns></returns>
        public static List<Exame> TodosExames()
        {
            return ListaExames;
        }

        /// <summary>
        /// Método que retorna uma lista de exames feitos por um pacientes
        /// </summary>
        /// <param name="nus"></param>
        /// <returns></returns>
        public static List<Exame> ExamesPaciente(int nus)
        {
            List<Exame> aux = new List<Exame>();

            foreach(Exame e in exames)
            {
                if (e.Nus == nus)
                {
                    aux.Add(e);
                }
            }
            return aux;
        }

        /// <summary>
        /// Método que devolve o custo total dos exames feitos por um paciente
        /// </summary>
        /// <param name="aux"></param>
        /// <returns></returns>
        public static double CustoExamesPaciente(List<Exame> aux)
        {
            double custoTotal = 0;
            foreach(Exame e in aux)
            {
                custoTotal += e.PrecoExame;
            }
            return custoTotal;
        }

        #endregion

        #endregion
    }
}
