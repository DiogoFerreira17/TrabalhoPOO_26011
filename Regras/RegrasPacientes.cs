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
    public class RegrasPacientes
    {
        /// <summary>
        /// Método para inserir um paciente 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool InserirPaciente(Paciente p)
        {
            if (p.SegurancaSocial == "pago" && p.VerificaNus(p.Nus))
            {
                Pacientes.InserirPaciente(p);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para remover um paciente da Lista
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool RemoverPaciente(Paciente p)
        {
            return Pacientes.RemoverPaciente(p);
        }

        /// <summary>
        /// Método para retornar a Lista de pacientes
        /// </summary>
        /// <returns></returns>
        public static List<Paciente> ListaPacientes()
        {
            return Pacientes.ListaPacientes();
        }

        /// <summary>
        /// Guarda Lista pacientes em ficheiro
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        public static bool GuardarFicheiroPacientes(string nomeFicheiro)
        {
            return Pacientes.GuardarFicheiroPacientes(nomeFicheiro);
        }

        /// <summary>
        /// Método para ler um ficheiro
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public static bool LerFicheiroPacientes(string nomeFicheiro)
        {
            return Pacientes.LerFicheiroPacientes(nomeFicheiro);
        }

    }
}
