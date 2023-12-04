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
        static int numCirurgias;

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
                numCirurgias = 0;
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

        public static int NumCirurgias
        {
            get { return numCirurgias; }
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
                cirurgias.Add(c);
                numCirurgias++;
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
                numCirurgias--;
                return true;
            }
            return false;
        }

        #endregion

        #endregion

    }
}
