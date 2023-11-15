/*
 * TrabalhoPOO_26011
 * Nome:Diogo Alves Ferreira
 * Email:a26011@alunos.ipca.pt
 * Engenharia de Sistemas Informáticos
 * Escola Superior de Técnologia
 * 7-11-2023
 */

namespace TrabalhoPOO_26011
{
    /// <summary>
    /// Classe que gere um conjunto de Internamentos
    /// </summary>
    public class Internamentos
    {
        /// <summary>
        /// Campos privados para armazenar o estado dos Internamentos
        /// </summary>
        #region ATRIBUTOS

        const int MAXINTERNAMENTOS = 10;
        static Internamento[] internamentos;
        static int numInternamentos;

        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrao da classe Internamentos
        /// </summary>
        public Internamentos()
        {
            numInternamentos = 0;
            if (internamentos == null)
            {
                internamentos = new Internamento[MAXINTERNAMENTOS];
            }
        }

        #endregion

        /// <summary>
        /// Obtém as caracteristicas dos Internamentos
        /// </summary>
        #region PROPRIEDADES

        /// <summary>
        /// Faz clone do array Internamentos
        /// </summary>
        public static Cama[] arrayInternamentos
        {
            get { return (Cama[])internamentos.Clone(); }
        }

        public static int NumInternamentos
        {
            get { return numInternamentos; }
        }

        #endregion

        #region MÉTODOS

        #endregion

        #endregion

    }
}
