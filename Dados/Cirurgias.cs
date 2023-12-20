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
    /// Classe que gere um conjunto de Cirurgias
    /// </summary>
    public class Cirurgias
    {
        /// <summary>
        /// Campos privados para armazenar o estado das Cirurgias
        /// </summary>
        #region ATRIBUTOS

        static List<Cirurgia> cirurgias;

        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrao da classe Cirurgias
        /// </summary>
        static Cirurgias()
        {
            if (cirurgias == null)
            {
                cirurgias = new List<Cirurgia>();
            }
        }

        #endregion

        /// <summary>
        /// Obtém as caracteristicas das Cirurgias
        /// </summary>
        #region PROPRIEDADES

        /// <summary>
        /// Retorna a Lista
        /// </summary>
        public static List<Cirurgia> ListaCirurgias
        {
            get { return new List<Cirurgia>(cirurgias); }
        }

        #endregion

        #region MÉTODOS

        /// <summary>
        /// Método para inserir uma cirurgia na Lista
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool InserirCirurgia(Cirurgia c)
        {
            if (c != null && !cirurgias.Contains(c))
            {
                if (c.DataCirurgia < new DateTime(2015, 1, 1))
                {
                    throw new DataInvalidaException("A base de dados não contem cirurgias anteriores a 2015");
                }
                cirurgias.Add(c);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para remover uma cirurgia da Lista
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool RemoverCirurgia(Cirurgia c)
        {
            if (c != null && cirurgias.Contains(c))
            {
                cirurgias.Remove(c);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para retornar a Lista de Cirurgias
        /// </summary>
        /// <returns></returns>
        public static List<Cirurgia> TodasCirurgias()
        {
            return ListaCirurgias;
        }

        #endregion

        #endregion

    }
}
