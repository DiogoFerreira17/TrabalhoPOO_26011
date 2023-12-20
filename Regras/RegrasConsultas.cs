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
using Dados;
using ObjetosHospital;


namespace Regras
{
    public class RegrasConsultas
    {
        /// <summary>
        /// Método para inserir uma consulta na Lista
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool InserirConsulta(Consulta c)
        {
            return Consultas.InserirConsulta(c);
        }

        /// <summary>
        /// Método que lista todas as consultas de um paciente
        /// </summary>
        /// <param name="nus"></param>
        /// <returns></returns>
        public static List<Consulta> ConsultasPaciente(int nus)
        {
            return Consultas.ConsultasPaciente(nus);
        }

        /// <summary>
        /// Método para retornar a Lista de consultas
        /// </summary>
        /// <returns></returns>
        public static List<Consulta> ListaConsultas()
        {
            return Consultas.TodasConsultas();
        }
    }
}
