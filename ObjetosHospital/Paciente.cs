/*
 * TrabalhoPOO_26011
 * Nome:Diogo Alves Ferreira
 * Email:a26011@alunos.ipca.pt
 * Engenharia de Sistemas Informáticos
 * Escola Superior de Técnologia
 * 7-11-2023
 */

using System;

public enum tipoSanguineo { OPositivo, ONegativo, APositivo, ANegativo, BPositivo, BNegativo, ABPositivo, ABNegativo }

namespace ObjetosHospital
{
    /// <summary>
    /// Representa um paciente, derivado da classe Pessoa
    /// </summary>
    public class Paciente : Pessoa
    {

        /// <summary>
        /// Campos privados para armazenar o estado do paciente
        /// </summary>
        #region Atributos

        int nus; // numero utenete de saude
        tipoSanguineo sangue;
        static public int totalPacientes; // numero de pacientes criados

        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrao da classe Paciente
        /// </summary>
        public Paciente()
        {
            totalPacientes++;
            Nome = string.Empty;
            sangue = tipoSanguineo.OPositivo;
            nus = 000000000;
            DataNascimento = DateTime.Now;
        }

        /// <summary>
        /// Construtor parametrizado da classe Paciente
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="nus"></param>
        /// <param name="sangue"></param>
        public Paciente(string nome,DateTime dataNascimento, int nus, tipoSanguineo sangue)
        {
            totalPacientes++;
            Nome = nome;
            this.sangue = sangue;
            this.nus = nus;
            DataNascimento = dataNascimento;
        }

        #endregion

        /// <summary>
        /// Obtém ou define as caracteristicas do paciente
        /// </summary>
        #region PROPRIEDADES

        public int Nus
        {
            get { return nus; }
            set { nus = value; }
        }

        public tipoSanguineo Sangue
        {
            get { return sangue; }
            set { sangue = value; }
        }

        #endregion

        #region OUTROS Metodos

        #endregion

        #region OUTROS MÉTODOS

        #endregion

        #region OVERRIDES

        /// <summary>
        /// Metodo para mostrar parametros do paciente
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("Nome paciente:{0} Idade:{1} TipoSangue:{2} NUS:{3} DataNascimento:{4}", Nome, Idade, Sangue, Nus, DataNascimento.ToShortDateString());
        }

        /// <summary>
        /// Verifica se o objeto Paciente é igual a outro objeto Paciente
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is Paciente)
            {
                Paciente p = (Paciente)obj;
                if ((p.Nome == Nome) && (p.Idade == Idade) && (p.Sangue == Sangue) && (p.DataNascimento == DataNascimento) && (p.Nus == Nus))
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        //#region operadores

        ///// <summary>
        ///// reesceita do operador de igualdade para comparar dois objetos do tipo paciente.
        ///// </summary>
        //public static bool operator ==(Paciente p1, Paciente p2)
        //{
        //    if ((p1.Nome == p2.Nome) && (p1.Idade == p2.Idade) && (p1.sangue == p2.sangue) && (p1.DataNascimento == p2.DataNascimento) && (p1.Nus == p2.Nus))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        ///// <summary>
        ///// reescrita do operador de desigualdade para comparar dois objetos do tipo paciente.
        ///// </summary>
        //public static bool operator !=(Paciente p1, Paciente p2)
        //{
        //    if (p1 == p2)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        //#endregion

        #endregion

    }
}