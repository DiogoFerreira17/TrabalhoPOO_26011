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
    /// Interface Pessoa
    /// </summary>
    public interface IPessoa
    {
        string nome { get; set; }
        int idade { get; set; }
        DateTime dataNascimento { get; set; } 

        int CalculaIdade(DateTime dataNascimento);

    }
}
