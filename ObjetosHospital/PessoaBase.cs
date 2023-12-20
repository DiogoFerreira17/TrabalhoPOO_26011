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
    /// Classe abstrata 
    /// </summary>
    [Serializable]
    public abstract class PessoaBase : IPessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public DateTime dataNascimento { get; set; }

        public int CalculaIdade(DateTime dataNascimento)
        {
            DateTime dataAtual = DateTime.Now;

            int idade = dataAtual.Year - dataNascimento.Year;

            if (dataNascimento.Date > dataAtual.AddYears(-idade))
            {
                idade--;   // No caso da pessoa ainda não ter feito anos
            }

            return idade;
        }

        public override abstract string ToString();

        public override abstract bool Equals(object obj);
    }
}
