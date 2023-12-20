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
using Excecoes;

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
                if (d.Data < new DateTime(2015, 1, 1))
                {
                    throw new DataInvalidaException("A base de dados não contem diagnósticos anteriores a 2015");
                }
                diagnosticos.Add(d);
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
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para retornar a Lista de diagnosticos
        /// </summary>
        /// <returns></returns>
        public static List<Diagnostico> TodosDiagnosticos()
        {
            return ListaDiagnosticos;
        }

        #endregion

        #endregion

    }
}
