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

namespace Dados
{
    /// <summary>
    /// Classe Input Output
    /// </summary>
    public class InOut
    {
        /// <summary>
        /// Imprime os detalhes de todos os pacientes dentro da Lista
        /// </summary>
        /// <param name="pacientes"></param>
        public static void ImprimirPacientes(List<Paciente> pacientes)
        {
            foreach(Paciente p in pacientes)
            {
                Console.WriteLine(p.ToString());
            }
        }

        /// <summary>
        /// Imprime os detalhes de todos os médicos dentro da Lista
        /// </summary>
        /// <param name="medicos"></param>
        public static void ImprimirMedicos(List<Medico> medicos)
        {
            foreach (Medico m in medicos)
            {
                Console.WriteLine(m.ToString());
            }
        }

        /// <summary>
        /// Imprime os detalhes de todas as consultas dentro do array
        /// </summary>
        /// <param name="consultas"></param>
        public static void ImprimirConsultas(Consultas[] consultas)
        {
            for (int i = 0; i < consultas.Length; i++)
            {
                if (consultas[i] != null)
                    Console.WriteLine(consultas[i]);
            }
        }

        /// <summary>
        /// Imprime os detalhes de todos os exames dentro do array
        /// </summary>
        /// <param name="exames"></param>
        public static void ImprimirExames(Exames[] exames)
        {
            for (int i = 0; i < exames.Length; i++)
            {
                if (exames[i] != null)
                    Console.WriteLine(exames[i]);
            }
        }

        /// <summary>
        /// Imprime os detalhes de todas as Camas dentro da Lista
        /// </summary>
        /// <param name="camas"></param>
        public static void ImprimirCamas(List<Cama> camas)
        {
            foreach (Cama c in camas)
            {
                Console.WriteLine(c.ToString());
            }
        }

        /// <summary>
        /// Imprime os detalhes de todos os diagnosticos dentro do array
        /// </summary>
        /// <param name="diagnosticos"></param>
        public static void ImprimirDiagnosticos(Diagnosticos[] diagnosticos)
        {
            for (int i = 0; i < diagnosticos.Length; i++)
            {
                if (diagnosticos[i] != null)
                    Console.WriteLine(diagnosticos[i]);
            }
        }

        /// <summary>
        /// Imprime os detalhes de todas as Cirurgias dentro do array
        /// </summary>
        /// <param name="cirurgias"></param>
        public static void ImprimirCirurgias(Cirurgias[] cirurgias)
        {
            for (int i = 0; i < cirurgias.Length; i++)
            {
                if (cirurgias[i] != null)
                    Console.WriteLine(cirurgias[i]);
            }
        }

        /// <summary>
        /// Imprime os detalhes de todos os internamentos dentro do array
        /// </summary>
        /// <param name="internamentos"></param>
        public static void ImprimirInternamentos(Internamentos[] internamentos)
        {
            for (int i = 0; i < internamentos.Length; i++)
            {
                if (internamentos[i] != null)
                    Console.WriteLine(internamentos[i]);
            }
        }

    }
}
