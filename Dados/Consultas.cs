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

namespace Dados
{
    /// <summary>
    /// Classe que gere um conjunto de Consultas
    /// </summary>
    public class Consultas
    {
        /// <summary>
        /// Campos privados para armazenar o estado de Consultas
        /// </summary>
        #region ATRIBUTOS

        static List<Consulta> consultas;
        static int numConsultas;

        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        static Consultas()
        {
            if (consultas == null)
            {
                numConsultas = 0;
                consultas = new List<Consulta>();
            }
        }

        #endregion

        /// <summary>
        /// Obtém as caracteristicas da consulta
        /// </summary>
        #region PROPRIEDADES

        /// <summary>
        /// Retorna a Lista
        /// </summary>
        public static List<Consulta> ListaConsultas
        {
            get { return new List<Consulta>(consultas); }
        }

        public static int NumConsultas
        {
            get { return numConsultas; }
        }

        #endregion

        #region MÉTODOS

        /// <summary>
        /// Método para inserir uma Consulta na Lista 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool InserirConsulta(Consulta c)
        {
            if(c!=null && !consultas.Contains(c))
            {
                consultas.Add(c);
                numConsultas++;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para remover uma consulta da Lista
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool RemoverConsulta(Consulta c)
        {
            if (c != null && consultas.Contains(c))
            {
                consultas.Remove(c);
                numConsultas--;
                return true;
            }
            return false;
        }

        #endregion

        #endregion
    }
}
