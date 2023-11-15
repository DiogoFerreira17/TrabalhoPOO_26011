/*
 * TrabalhoPOO_26011
 * Nome:Diogo Alves Ferreira
 * Email:a26011@alunos.ipca.pt
 * Engenharia de Sistemas Informáticos
 * Escola Superior de Técnologia
 * 7-11-2023
 */

using System;

namespace TrabalhoPOO_26011
{
    public class IO
    {
        /// <summary>
        /// Imprime os detalhes de todos os pacientes dentro do array
        /// </summary>
        /// <param name="pacientes"></param>
        public static void ImprimirPacientes(Paciente[] pacientes)
        {
            for (int i = 0; i < pacientes.Length; i++)
            {
                if (pacientes[i] != null) // Para nao mostrar o array caso nao tenha nenhum paciente dentro
                    Console.WriteLine(pacientes[i].ToString());
            }
        }

        /// <summary>
        /// Imprime os detalhes de todos os médicos dentro do array
        /// </summary>
        /// <param name="medicos"></param>
        public static void ImprimirMedicos(Medico[] medicos)
        {
            for (int i = 0; i < medicos.Length; i++)
            {
                if (medicos[i] != null)
                    Console.WriteLine(medicos[i].ToString());
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
        /// Imprime os detalhes de todas as camas dentro do array
        /// </summary>
        /// <param name="camas"></param>
        public static void ImprimirCamas(Camas[] camas)
        {
            for (int i = 0; i < camas.Length; i++)
            {
                if (camas[i] != null)
                    Console.WriteLine(camas[i]);
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
