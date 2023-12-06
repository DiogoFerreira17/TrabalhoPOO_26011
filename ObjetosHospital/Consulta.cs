/*
 * TrabalhoPOO_26011
 * Nome:Diogo Alves Ferreira
 * Email:a26011@alunos.ipca.pt
 * Engenharia de Sistemas Informáticos
 * Escola Superior de Técnologia
 * 7-11-2023
 */

using System;

namespace ObjetosHospital
{
    /// <summary>
    /// Classe que representa uma Consulta
    /// </summary>
    public class Consulta
    {
        /// <summary>
        /// Campos privados para armazenar o estado da consulta
        /// </summary>
        #region Atributos

        static int numConsultas;
        int idConsulta;
        string descricao;
        DateTime data;
        int nus;
        int idMedico;
        double precoConsulta;

        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrão da classe Consulta
        /// </summary>
        public Consulta()
        {
            descricao = string.Empty;
            data = DateTime.Now;
            nus = 0;
            idMedico = 0;
            precoConsulta = 0.0;
            idConsulta = 0;
            ++numConsultas;
        }

        /// <summary>
        /// Construtor parametrizado da classe Consulta
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="data"></param>
        /// <param name="nus"></param>
        /// <param name="idMedico"></param>
        /// <param name="preco"></param>
        public Consulta(string descricao, DateTime data, int nus, int idMedico,double preco)
        {
            this.descricao = descricao;
            this.data = data;
            this.nus = nus;
            this.idMedico = idMedico;
            this.precoConsulta = preco;
            idConsulta = ++numConsultas;
        }

        #endregion

        /// <summary>
        /// Obtém ou define as caracteristicas da Consulta
        /// </summary>
        #region PROPRIEDADES

        public int IdConsulta
        {
            get { return idConsulta; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        public int Nus
        {
            get { return nus; }
            set { nus = value; }
        }
        public int IdMedico
        {
            get { return idMedico; }
            set { idMedico = value; }
        }

        public double PrecoConsulta
        {
            get { return precoConsulta; }
            set { precoConsulta = value; }
        }

        #endregion

        #region OUTROS MÉTODOS

        #endregion

        #region OVERRIDES

        /// <summary>
        /// Metodo para mostrar parametros da Consulta
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("IdConsulta:{0} dataConsulta:{1} Descrição:{2} NUS:{3} IdMédico:{4} preçoConsulta:{5}$",IdConsulta,Data,Descricao,Nus,IdMedico,PrecoConsulta);
        }

        #endregion

        #endregion
    }
}
