/*
 * TrabalhoPOO_26011
 * Nome:Diogo Alves Ferreira
 * Email:a26011@alunos.ipca.pt
 * Engenharia de Sistemas Informáticos
 * Escola Superior de Técnologia
 * 7-11-2023
 */

using Dados;
using ObjetosHospital;
using System.Collections.Generic;

namespace Regras
{
    public class RegrasMedicos
    {
        /// <summary>
        /// Método para inserir um médico se ele existir
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool InserirMedico(Medico m)
        {
            return Medicos.InserirMedico(m);
        }

        /// <summary>
        /// Método para remover um médico da Lista
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool RemoverMedico(Medico m)
        {
            return Medicos.RemoverMedico(m);
        }

        /// <summary>
        /// Método para retornar a Lista de médicos
        /// </summary>
        /// <returns></returns>
        public static List<Medico> ListaMedicos()
        {
            return Medicos.TodosMedicos();
        }
    }
}
