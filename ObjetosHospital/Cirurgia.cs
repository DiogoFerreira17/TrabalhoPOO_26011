/*
 * TrabalhoPOO_26011
 * Nome:Diogo Alves Ferreira
 * Email:a26011@alunos.ipca.pt
 * Engenharia de Sistemas Informáticos
 * Escola Superior de Técnologia
 * 7-11-2023
 */

using Excecoes;
using System;

namespace ObjetosHospital
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
        public Cirurgia(DateTime dataCirurgia,int nus, int idMedico,double precoCirurgia)
        {
            this.dataCirurgia = dataCirurgia;
            this.nus = nus;
            this.idMedico = idMedico;
            this.precoCirurgia= precoCirurgia;
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

        #region OUTROS MÉTODOS

        #endregion

        #region OVERRIDES

        /// <summary>
        /// Metodo para mostrar parametros da Cirurgia
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("dataCirurgia:{0} NUS:{1} IdMédico:{2} preçoCirurgia:{3}$", DataCirurgia.ToShortDateString(), Nus,IdMedico,PrecoCirurgia);
        }

        /// <summary>
        /// Verifica se o objeto Cirurgia é igual a outro objeto Cirurgia
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is Cirurgia)
            {
                Cirurgia c = (Cirurgia)obj;
                if (c.DataCirurgia==DataCirurgia && c.Nus==Nus && c.IdMedico==IdMedico && c.PrecoCirurgia==PrecoCirurgia)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #endregion
    }
}