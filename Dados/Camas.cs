/*
 * TrabalhoPOO_26011
 * Nome:Diogo Alves Ferreira
 * Email:a26011@alunos.ipca.pt
 * Engenharia de Sistemas Informáticos
 * Escola Superior de Técnologia
 * 7-11-2023
 */

// Externo
using ObjetosHospital;

namespace Dados
{
    /// <summary>
    /// Classe que gere um conjunto de Camas
    /// </summary>
    public class Camas
    {
        /// <summary>
        /// Campos privados para armazenar o estado das camas
        /// </summary>
        #region ATRIBUTOS
        const int MAXCAMAS = 10;
        static Cama[] camas;
        static int numCamas;
        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrao da classe Camas
        /// </summary>
        public Camas()
        {
            numCamas = 0;
            if (camas == null)
            {
                camas = new Cama[MAXCAMAS];
            }
        }

        #endregion

        /// <summary>
        /// Obtém as caracteristicas dos Camas
        /// </summary>
        #region PROPRIEDADES

        /// <summary>
        /// Faz clone do array Camas
        /// </summary>
        public static Cama[] arrayCamas
        {
            get { return (Cama[])camas.Clone(); }
        }

        public static int NumCamas 
        { 
            get { return numCamas; }
        }

        #endregion

        #region MÉTODOS

        #endregion

        #endregion

    }
}
