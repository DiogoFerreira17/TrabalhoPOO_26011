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
    public class RegrasCamas
    {
        /// <summary>
        /// Método para inserir uma cama na Lista
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool InserirCama(Cama c)
        {
            return Camas.InserirCama(c);
        }

        /// <summary>
        /// Método para inserir um paciente numa cama 
        /// </summary>
        /// <param name="nus"></param>
        /// <returns></returns>
        public static bool InserirPacienteCama(int nus)
        {
            if (Pacientes.ExistePacienteLista(nus) && !Camas.VerificaPacienteCama(nus)) // Impede que um paciente que ja esteja numa cama seja inserido noutra
            {
                Camas.InserirPacienteCama(nus); 
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para remover um paciente de uma cama 
        /// </summary>
        /// <param name="nus"></param>
        /// <returns></returns>
        public static bool RemoverPacienteCama(int nus)
        {
            if (Pacientes.ExistePacienteLista(nus) && Camas.VerificaPacienteCama(nus))
            {
                Camas.RemoverPacienteCama(nus);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para retornar o id da cama de um determinado paciente
        /// </summary>
        /// <param name="nus"></param>
        /// <returns></returns>
        public static int IdCamaPaciente(int nus)
        {
            if (Pacientes.ExistePacienteLista(nus))
            {
                return Camas.IdCamaPaciente(nus);
            }
            return 0;
        }

        /// <summary>
        /// Método para retornar a Lista de camas
        /// </summary>
        /// <returns></returns>
        public static List<Cama> ListaCamas()
        {
            return Camas.TodasCamas();
        }
    }
}
