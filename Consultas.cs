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
    /// Classe que gere um conjunto de Consultas
    /// </summary>
    public class Consultas
    {
        /// <summary>
        /// Campos privados para armazenar o estado de Consultas
        /// </summary>
        #region ATRIBUTOS
        const int NUMCONSULTAS = 10;
        static Consulta[] consultas;
        static int numConsultas;
        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        public Consultas()
        {
            numConsultas = 0;
            if (consultas == null)
            {
                consultas = new Consulta[NUMCONSULTAS];
            }
        }

        #endregion

        /// <summary>
        /// Obtém as caracteristicas da consulta
        /// </summary>
        #region PROPRIEDADES

        /// <summary>
        /// Faz clone do array consultas
        /// </summary>
        public static Consulta[] arrayConsultas
        {
            get { return (Consulta[])consultas.Clone(); }
        }

        public static int NumConsultas
        {
            get { return numConsultas; }
        }

        #endregion

        #region MÉTODOS

        #endregion

        #endregion
    }
}
