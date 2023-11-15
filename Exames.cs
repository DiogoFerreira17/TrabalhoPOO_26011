/*
 * TrabalhoPOO_26011
 * Nome:Diogo Alves Ferreira
 * Email:a26011@alunos.ipca.pt
 * Engenharia de Sistemas Informáticos
 * Escola Superior de Técnologia
 * 7-11-2023
 */

using System;

namespace TrabalhoPOO_26011
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
        const int NUMEXAMES = 10;
        static Exame[] exames;
        static int numExames;
        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        public Exames()
        {
            numExames = 0;
            if (exames == null)
            {
                exames = new Exame[NUMEXAMES];
            }
        }

        #endregion

        /// <summary>
        /// Obtém as caracteristicas dos Exames
        /// </summary>
        #region PROPRIEDADES

        /// <summary>
        /// Faz clone do array Exames
        /// </summary>
        public static Exame[] arrayExames
        {
            get { return (Exame[])exames.Clone(); }
        }

        public static int NumExames
        {
            get { return numExames; }
        }

        #endregion

        #region MÉTODOS

        #endregion

        #endregion
    }
}
