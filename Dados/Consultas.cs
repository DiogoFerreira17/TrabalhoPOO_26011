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
    /// Classe que gere um conjunto de Consultas
    /// </summary>
    public class Consultas
    {
        /// <summary>
        /// Campos privados para armazenar o estado de Consultas
        /// </summary>
        #region ATRIBUTOS

        static List<Consulta> consultas;

        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        static Consultas()
        {
            if (consultas == null)
            {
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
                if (c.Data < new DateTime(2023, 1, 1) || c.Data > new DateTime(2030, 1, 1))
                {
                    throw new DataInvalidaException("A base de dados não contem consultas anteriores a 2023/1/1 e posteriores a 2030/1/1");
                }
                consultas.Add(c);
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
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para retornar a Lista de consultas
        /// </summary>
        /// <returns></returns>
        public static List<Consulta> TodasConsultas()
        {
            return ListaConsultas;
        }

        /// <summary>
        /// Método que lista todas as consultas de um paciente
        /// </summary>
        /// <param name="nus"></param>
        /// <returns></returns>
        public static  List<Consulta> ConsultasPaciente(int nus)
        {
            List<Consulta> aux = new List<Consulta>();

            foreach(Consulta c in consultas)
            {
                if (c.Nus == nus)
                {
                    aux.Add(c);
                }
            }
            return aux;
        }

        #endregion

        #endregion
    }
}
