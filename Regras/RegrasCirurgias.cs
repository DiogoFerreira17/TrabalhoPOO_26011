/*
 * TrabalhoPOO_26011
 * Nome:Diogo Alves Ferreira
 * Email:a26011@alunos.ipca.pt
 * Engenharia de Sistemas Informáticos
 * Escola Superior de Técnologia
 * 7-11-2023
 */

using System.Collections.Generic;

// Externo
using ObjetosHospital;
using Dados;

namespace Regras
{
    public class RegrasCirurgias
    {
        /// <summary>
        /// Método para inserir uma Cirurgia na Lista
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool InserirCirurgia(Cirurgia c)
        {
            return Cirurgias.InserirCirurgia(c);
        }

        /// <summary>
        /// Método para retornar a Lista de cirurgias
        /// </summary>
        /// <returns></returns>
        public static List<Cirurgia> ListaCirurgias()
        {
            return Cirurgias.TodasCirurgias();
        }
    }
}
