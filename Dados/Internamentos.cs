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
    /// Classe que gere um conjunto de Internamentos
    /// </summary>
    public class Internamentos
    {
        /// <summary>
        /// Campos privados para armazenar o estado dos Internamentos
        /// </summary>
        #region ATRIBUTOS

        static List<Internamento> internamentos;
        static int numInternamentos;

        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrao da classe Internamentos
        /// </summary>
        static Internamentos()
        {
            
            if (internamentos == null)
            {   
                numInternamentos = 0;
                internamentos = new List<Internamento>();
            }
        }

        #endregion

        /// <summary>
        /// Obtém as caracteristicas dos Internamentos
        /// </summary>
        #region PROPRIEDADES

        /// <summary>
        /// Retorna a Lista
        /// </summary>
        public static List<Internamento> ListaInternamentos
        {
            get { return new List<Internamento>(internamentos); }
        }

        public static int NumInternamentos
        {
            get { return numInternamentos; }
        }

        #endregion

        #region OUTROS MÉTODOS

        /// <summary>
        /// Metodo para inserir um internamento na Lista
        /// </summary>
        /// <param name="I"></param>
        /// <returns></returns>
        public static bool InserirInternamento(Internamento I)
        {
            if (I != null && !EncontrarInternamentoLista(I))
            {
                internamentos.Add(I);
                numInternamentos++;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Metodo para remover um internamento da Lista
        /// </summary>
        /// <param name="I"></param>
        /// <returns></returns>
        public static bool RemoverInternametno(Internamento I)
        {
            if (I != null && EncontrarInternamentoLista(I))
            {
                internamentos.Add(I);
                numInternamentos++;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para verificar se um internamento já está na Lista
        /// </summary>
        /// <param name="I"></param>
        /// <returns></returns>
        public static bool EncontrarInternamentoLista(Internamento I)
        {
            if (I != null)
            {
                foreach (Internamento internamento in internamentos)
                {
                    if(internamento.Equals(I))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        #endregion

        #endregion

    }
}
