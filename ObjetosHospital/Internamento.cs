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
    /// Classe que representa um Internamento
    /// </summary>
    public class Internamento
    {
        /// <summary>
        /// Campos privados para armazenar o estado do internamento
        /// </summary>
        #region ATRIBUTOS

        DateTime dataInicio;
        DateTime dataFim;
        int nus;
        int idCama;
        double precoInternamento;

        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrão da classe Internamento
        /// </summary>
        public Internamento()
        {
            nus = 0;
            idCama = 0;
            precoInternamento = 0.0;
        }

        /// <summary>
        /// Construtor parametrizado da classe Internamento
        /// </summary>
        /// <param name="dataInicio"></param>
        /// <param name="dataFim"></param>
        /// <param name="nus"></param>
        /// <param name="idCama"></param>
        public Internamento(DateTime dataInicio,DateTime dataFim, int nus,int idCama)
        {
            this.dataInicio = dataInicio;
            this.dataFim = dataFim;
            this.nus = nus;
            this.idCama = idCama;
        }

        #endregion

        /// <summary>
        /// Obtém ou define as caracteristicas do Internamento
        /// </summary>
        #region PROPRIEDADES

        public DateTime DataInicio
        {
            get { return dataInicio; }
            set { dataInicio = value; }
        }

        public DateTime DataFim
        {
            get { return dataFim; }
            set { dataInicio = value; }
        }

        public int Nus
        {
            get { return nus; }
            set { nus = value; }
        }

        public int IdCama
        {
            get { return idCama; }
            set { idCama = value; }
        }

        public double PrecoInternamento
        {
            get { return precoInternamento; }
            set { precoInternamento = value; }
        }

        #endregion

        #region OUTROS MÉTODOS

        // Método para calcular os dias que o paciente esteve internado

        // Método para ver a cama do paciente ???? 

        #endregion

        #region OVERRIDES

        /// <summary>
        /// Metodo para mostrar parametros do Internamento
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("dataInicio:{0} dataFim:{1} NUS:{2} IdCama:{3} preçoInternamento:{4}", DataInicio,DataFim,Nus,IdCama,PrecoInternamento);
        }

        #endregion

        #endregion
    }
}
