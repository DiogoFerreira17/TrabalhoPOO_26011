/*
 * TrabalhoPOO_26011
 * Nome:Diogo Alves Ferreira
 * Email:a26011@alunos.ipca.pt
 * Engenharia de Sistemas Informáticos
 * Escola Superior de Técnologia
 * 7-11-2023
 */

using System;
using System.Collections.Generic;

// Externo
using ObjetosHospital;
using Dados;

namespace Regras
{
    public class RegrasInternamentos
    {
        /// <summary>
        /// Método para Inserir um internamento na Lista
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool InserirInternamento(Internamento i)
        {
            if (i.IdCama != 0)
            {
                Internamentos.InserirInternamento(i);
                return true;
            }
            return false;
        }

        #region TESTES

        /// <summary>
        /// Método para retornar o numero de dias que um paciente esteve internado
        /// </summary>
        /// <param name="nus"></param>
        /// <returns></returns>
        public static int DiasInternamentoPaciente(int nus, DateTime dataInternamento)
        {
            return Internamentos.DiasInternamentoPaciente(nus, dataInternamento);
        }

        #endregion

        /// <summary>
        /// Método para retornar o custo do internamento de um paciente
        /// </summary>
        /// <param name="nus"></param>
        /// <returns></returns>
        public static double CustoInternamento(int nus, DateTime dataInternamento)
        {
            return Internamentos.CalculaCustoInternamento(nus, dataInternamento);
        }

        /// <summary>
        /// Método para retornar a Lista de internamentos
        /// </summary>
        /// <returns></returns>
        public static List<Internamento> ListaInternamentos()
        {
            return Internamentos.TodosInternamentos();
        }
    }
}
