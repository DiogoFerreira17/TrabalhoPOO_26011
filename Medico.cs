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
    /// Representa um médico, derivado da classe Staff.
    /// </summary>
    public class Medico : Pessoa
    {

        /// <summary>
        /// Campos privados para armazenar o estado do médico
        /// </summary>
        #region Atributos

        static int numMedicos;
        int idMedico;
        string especialidade;

        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrao da classe médico
        /// </summary>
        public Medico()
        {
            Nome = string.Empty;
            DataNascimento = DateTime.Now;
            especialidade = string.Empty;
            idMedico = 0;
            ++numMedicos;
        }

        /// <summary>
        /// Construtor parametrizado da classe médico
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="data"></param>
        /// <param name="especialidade"></param>
        public Medico(string nome, DateTime data,string especialidade)
        {
            Nome = nome;
            DataNascimento = data;
            this.especialidade = especialidade;
            idMedico=++numMedicos;
        }
        #endregion

        /// <summary>
        /// Obtém ou define sa caracteristicas do médico
        /// </summary>
        #region PROPRIEDADES

        public string Especialidade
        {
            get { return especialidade; }
            set { especialidade = value; }
        }

        public int IdMedico
        {
            get { return idMedico; }
        }

        #endregion

        //#region Operadores

        ///// <summary>
        ///// Reesceita do operador de igualdade para comparar dois objetos do tipo médico
        ///// </summary>
        //public static bool operator ==(Medico m1, Medico m2)
        //{
        //    if ((m1.Nome == m2.Nome) && (m1.Idade == m2.Idade) && (m1.DataNascimento == m2.DataNascimento) && (m1.Especialidade == m2.Especialidade))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        ///// <summary>
        ///// Reescrita do operador de desigualdade para comparar dois objetos do tipo médico
        ///// </summary>
        //public static bool operator !=(Medico m1, Medico m2)
        //{
        //    if (m1 == m2)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        //#endregion

        #region OVERRIDES

        /// <summary>
        ///  Metodo para mostrar parametros do médico
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("Nome médico:{0} Idade:{1} Especialidade:{2} DataNascimento:{3} ", Nome,Idade, Especialidade, DataNascimento.ToShortDateString());
        }

        /// <summary>
        /// Verifica se o objeto Médico é igual a outro objeto Médico
        /// </summary>
        public override bool Equals(object obj) 
        {
            if (obj is Medico)
            {
                Medico m = (Medico)obj;
                if ((m.Nome == Nome) && (m.DataNascimento == DataNascimento)&&(m.Especialidade==Especialidade)) // &&(m.IdMedico==IdMedico)) (id nunca vai ser igual)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region MÉTODOS

        #endregion

        #endregion

    }
}
