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
    /// Classe que gere um conjunto de Diagnosticos
    /// </summary>
    public class Diagnosticos
    {
        /// <summary>
        /// Campos privados para armazenar o estado dos Diagnosticos
        /// </summary>
        #region ATRIBUTOS

        const int MAXDIAGNOSTICOS = 10;
        static Diagnostico[] diagnosticos;
        static int numDiagnosticos;

        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrao da classe Diagnosticos
        /// </summary>
        public Diagnosticos()
        {
            numDiagnosticos = 0;
            if (diagnosticos == null)
            {
                diagnosticos = new Diagnostico[MAXDIAGNOSTICOS];
            }
        }

        #endregion

        /// <summary>
        /// Obtém as caracteristicas dos Diagnosticos
        /// </summary>
        #region PROPRIEDADES

        /// <summary>
        /// Faz clone do array Diagnosticos
        /// </summary>
        public static Diagnostico[] arrayDiagnosticos
        {
            get { return (Diagnostico[])diagnosticos.Clone(); }
        }

        public static int NumDiagnosticos
        {
            get { return numDiagnosticos; }
        }

        #endregion

        #region MÉTODOS

        #endregion

        #endregion

    }
}
