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
    /// Classe que gere um conjunto de Diagnosticos
    /// </summary>
    public class Diagnosticos
    {
        /// <summary>
        /// Campos privados para armazenar o estado dos Diagnosticos
        /// </summary>
        #region ATRIBUTOS

        static List<Diagnostico> diagnosticos;
        static int numDiagnosticos;

        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrao da classe Diagnosticos
        /// </summary>
        static Diagnosticos()
        {
            if (diagnosticos == null)
            {
                numDiagnosticos = 0;
                diagnosticos = new List<Diagnostico>();
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
        public static List<Diagnostico> ListaDiagnosticos
        {
            get { return new List<Diagnostico>(diagnosticos); }
        }

        public static int NumDiagnosticos
        {
            get { return numDiagnosticos; }
        }

        #endregion

        #region OUTROS MÉTODOS

        /// <summary>
        /// Método para inserir um diagnostico na Lista
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool InserirDiagnostico(Diagnostico d)
        {
            if(d!=null && !diagnosticos.Contains(d))
            {
                diagnosticos.Add(d);
                numDiagnosticos++;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para remover um diagnostico da Lista
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool RemoverDiagnostico(Diagnostico d)
        {
            if (d != null && diagnosticos.Contains(d))
            {
                diagnosticos.Remove(d);
                numDiagnosticos--;
                return true;
            }
            return false;
        }

        #endregion

        #endregion

    }
}
