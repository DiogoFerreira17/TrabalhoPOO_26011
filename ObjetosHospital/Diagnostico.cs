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
    /// Classe que representa um Diagóstico
    /// </summary>
    public class Diagnostico
    {
        /// <summary>
        /// Campos privados para armazenar o estado do diagnostico
        /// </summary>
        #region Atributos

        DateTime data;
        int idMedico;
        int nus;
        int idExame; 
        string descricao;

        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrao da classe Diagnostico
        /// </summary>
        public Diagnostico() 
        {
            data = new DateTime();
            descricao = string.Empty;
            idExame = 0;
            idMedico = 0;
            nus = 0;
        }

        /// <summary>
        /// Construtor parametrizado da classe Paciente
        /// </summary>
        /// <param name="data"></param>
        /// <param name="medico"></param>
        /// <param name="paciente"></param>
        /// <param name="exame"></param>
        /// <param name="descricao"></param>
        public Diagnostico(DateTime data, int idMedico,int nus,int idExame, string descricao)
        {
            this.data = data;
            this.descricao = descricao;
            this.idMedico = idMedico;
            this.nus = nus;
            this.idExame =idExame;
        }

        #endregion

        /// <summary>
        /// Obtém ou define as caracteristicas do diagnostico
        /// </summary>
        #region PROPRIEDADES

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public int IdMedico
        {
            get { return idMedico; }
            set { idMedico = value; }
        }

        public int Nus
        {
            get { return nus; }
            set { nus = value; }
        }

        public int IdExame
        {
            get { return idExame; }
            set { idExame = value; }
        }

        #endregion

        #region OUTROS MÉTODOS

        #endregion

        #region OVERRIDE

        /// <summary>
        /// Metodo para mostrar parametros do diagnostico
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("DataDiagnóstico:{0} idExame:{1} NUS:{2} IdMédico:{3} Descrição:{4}", Data.ToShortDateString(), IdExame, Nus, idMedico, Descricao);
        }

        /// <summary>
        /// Verifica se o objeto Diagnostico é igual a outro objeto Diagnostico
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is Diagnostico)
            {
                Diagnostico d = (Diagnostico)obj;
                if (d.Data==Data && d.IdMedico==IdMedico && d.Nus==Nus && d.IdExame==IdExame && d.Descricao==Descricao)
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
