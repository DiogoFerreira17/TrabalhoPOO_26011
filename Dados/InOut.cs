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

        #region IMPRIMIR

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
        /// Imprime os detalhes de todas as consultas dentro da Lista
        /// </summary>
        /// <param name="consultas"></param>
        public static void ImprimirConsultas(List<Consulta> consultas)
        {
            foreach (Consulta c in consultas)
            {
                Console.WriteLine(c.ToString());
            }
        }

        /// <summary>
        /// Imprime os detalhes de todos os exames dentro da Lista
        /// </summary>
        /// <param name="exames"></param>
        public static void ImprimirExames(List<Exame> exames)
        {
            foreach (Exame e in exames)
            {
                Console.WriteLine(e.ToString());
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
        /// Imprime os detalhes de todos os diagnosticos dentro da Lista
        /// </summary>
        /// <param name="diagnosticos"></param>
        public static void ImprimirDiagnosticos(List<Diagnostico> Diagnostico)
        {
            foreach (Diagnostico d in Diagnostico)
            {
                Console.WriteLine(d.ToString());
            }
        }

        /// <summary>
        /// Imprime os detalhes de todas as Cirurgias dentro da Lista
        /// </summary>
        /// <param name="cirurgias"></param>
        public static void ImprimirCirurgias(List<Cirurgia> cirurgias)
        {
            foreach (Cirurgia c in cirurgias)
            {
                Console.WriteLine(c.ToString());
            }
        }

        /// <summary>
        /// Imprime os detalhes de todos os internamentos dentro da Lista
        /// </summary>
        /// <param name="internamentos"></param>
        public static void ImprimirInternamentos(List<Internamento> internamentos)
        {
            foreach (Internamento i in internamentos)
            {
                Console.WriteLine(i.ToString());
            }
        }

        #endregion

        #region IMPRIMIR POR PACIENTE

        /// <summary>
        /// Método para mostrar as consultas de um paciente
        /// </summary>
        /// <param name="consultas"></param>
        /// <param name="nus"></param>
        public static void ImprimirConsultasPorPaciente(List<Consulta> consultas,int nus)
        {
            foreach (Consulta c in consultas)
            {
                if (c.Nus == nus)
                {
                    Console.WriteLine(c.ToString());
                }
            }
        }

        /// <summary>
        /// Método para mostrar os exames de um paciente
        /// </summary>
        /// <param name="exames"></param>
        /// <param name="nus"></param>
        public static void ImprimirExamesPorPaciente(List<Exame> exames,int nus)
        {
            foreach (Exame e in exames)
            {
                if (e.Nus == nus)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        /// <summary>
        /// Método para mostrar os diagnosticos de um paciente
        /// </summary>
        /// <param name="Diagnostico"></param>
        /// <param name="nus"></param>
        public static void ImprimirDiagnosticosPorPaciente(List<Diagnostico> Diagnostico,int nus)
        {
            foreach (Diagnostico d in Diagnostico)
            {
                if (d.Nus == nus) 
                { 
                    Console.WriteLine(d.ToString());
                }
            }
        }

        /// <summary>
        /// Método para mostrar as cirurgias de um paciente
        /// </summary>
        /// <param name="cirurgias"></param>
        /// <param name="nus"></param>
        public static void ImprimirCirurgiasPorPaciente(List<Cirurgia> cirurgias,int nus)
        {
            foreach (Cirurgia c in cirurgias)
            {
                if (c.Nus == nus)
                {
                    Console.WriteLine(c.ToString());
                }
            }
        }

        /// <summary>
        /// Método para mostrar os internamentos de um paciente
        /// </summary>
        /// <param name="internamentos"></param>
        /// <param name="nus"></param>
        public static void ImprimirInternamentosPorPaciente(List<Internamento> internamentos,int nus)
        {
            foreach (Internamento i in internamentos)
            {
                if (i.Nus == nus)
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }

        #endregion

    }
}
