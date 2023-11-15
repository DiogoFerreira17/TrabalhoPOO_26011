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
    /// Classe que representa uma cirurgia
    /// </summary>
    public class Cirurgia
    {
        /// <summary>
        /// Campos privados para armazenar o estado da Cirurgia
        /// </summary>
        #region ATRIBUTOS

        DateTime dataCirurgia;
        int nus;
        int idMedico;
        double precoCirurgia;

        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrão da classe Cirurgia
        /// </summary>
        public Cirurgia()
        {
            dataCirurgia = DateTime.Now;
            nus = 0;
            idMedico = 0;
            precoCirurgia = 0.0;
        }

        /// <summary>
        /// Construtor parametrizado da classe Cirurgia
        /// </summary>
        /// <param name="nus"></param>
        /// <param name="idMedico"></param>
        public Cirurgia(DateTime dataCirurgia,int nus, int idMedico)
        {
            this.dataCirurgia = dataCirurgia;
            this.nus = nus;
            this.idMedico = idMedico;
        }

        #endregion

        /// <summary>
        /// Obtém ou define as caracteristicas da Cirurgia
        /// </summary>
        #region PROPRIEDADES

        public DateTime DataCirurgia
        {
            get { return dataCirurgia; }
            set { dataCirurgia = value; }
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

        public double PrecoCirurgia
        {
            get { return precoCirurgia; }
            set { precoCirurgia = value; }
        }
        #endregion

        #region MÉTODOS

        // Método para calcular os dias que o paciente esteve internado

        // Método para ver a cama do paciente ???? 

        #endregion

        #region OVERRIDES

        /// <summary>
        /// Metodo para mostrar parametros da Cirurgia
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("dataCirurgia:{0} NUS:{1} IdMédico:{2} preçoCirurgia:{3}", DataCirurgia,Nus,IdMedico,PrecoCirurgia);
        }

        #endregion

        #endregion
    }
}