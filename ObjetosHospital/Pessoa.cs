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
    /// Classe que representa uma pessoa com algumas informações como nome, idade e data de nascimento
    /// </summary>
    public class Pessoa 
    {
        #region Atributos

        string nome;
        int idade;
        DateTime dataNascimento;

        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrao da classe Pessoa
        /// </summary>
        public Pessoa()
        {
            idade = 0;
            nome = string.Empty;
            DateTime dataNascimento = DateTime.Now;
        }

        /// <summary>
        /// Construtor parametrizado da classe Pessoa
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="dataNascimento"></param>
        public Pessoa(string nome,DateTime dataNascimento)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            idade = Idade;
        }

        #endregion

        /// <summary>
        /// Obtém ou define as caracteristicas da Pessoa
        /// </summary>
        #region PROPRIEDADES

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        public int Idade
        {
            get { return GetIdade; }
            set { idade= value; }
        }

        #endregion

        #region MÉTODOS

        /// <summary>
        /// Método para devolver a idade da pessoa
        /// </summary>
        public int GetIdade
        {
            get
            {
                DateTime dataAtual = DateTime.Now;

                int idade = dataAtual.Year - dataNascimento.Year;

                if (dataNascimento.Date > dataAtual.AddYears(-idade))
                {
                    //No caso da pessoa ainda não ter feito anos
                    idade--;
                }

                return idade;
            }
        }

        #endregion

        #endregion
    }
}
