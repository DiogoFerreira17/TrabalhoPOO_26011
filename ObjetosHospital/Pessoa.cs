/*
 * TrabalhoPOO_26011
 * Nome:Diogo Alves Ferreira
 * Email:a26011@alunos.ipca.pt
 * Engenharia de Sistemas Informáticos
 * Escola Superior de Técnologia
 * 7-11-2023
 */
using System;

// Externo
using Excecoes;

namespace ObjetosHospital
{
    /// <summary>
    /// Classe que representa uma pessoa com algumas informações como nome, idade e data de nascimento
    /// </summary>
    [Serializable]
    public class Pessoa : PessoaBase
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
            if (dataNascimento > DateTime.Now)
            {
                throw new DataFuturaException();
            }
            this.dataNascimento = dataNascimento;
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
            get { return idade = CalculaIdade(dataNascimento); }
            set { idade=value; }
        }

        #endregion

        #region OVERRIDES

        /// <summary>
        /// Metodo para mostrar parametros da Pessoa
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("Nome:{0} Idade:{1} DataNascimento:{2}", Nome, Idade, DataNascimento.ToShortDateString());
        }

        /// <summary>
        /// Verifica se o objeto Pessoa é igual a outro objeto Pessoa
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Pessoa)
            {
                Pessoa p = (Pessoa)obj;
                if ((p.Nome == Nome) && (p.Idade == Idade) && (p.DataNascimento == DataNascimento))
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region OUTROS MÉTODOS

        #endregion

        #endregion
    }
}
