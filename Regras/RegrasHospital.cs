/*
 * TrabalhoPOO_26011
 * Nome:Diogo Alves Ferreira
 * Email:a26011@alunos.ipca.pt
 * Engenharia de Sistemas Informáticos
 * Escola Superior de Técnologia
 * 7-11-2023
 */

// Externo
using ObjetosHospital;
using Dados;
using System;
using System.Collections.Generic;

namespace Regras
{
    public class RegrasHospital
    {
        #region INSERÇÕES

        /// <summary>
        /// Método para inserir um paciente se tiver idade > 0
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool InserirPaciente(Paciente p)
        {
            if (p.Idade > 0) // apenas para teste
            {
                Pacientes.InserirPaciente(p);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para inserir um médico se ele existir
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool InserirMedico(Medico m)
        {
            Medicos.InserirMedico(m);
            return true;
        }

        /// <summary>
        /// Método para inserir uma cama na Lista
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool InserirCama(Cama c)
        {
            Camas.InserirCama(c);
            return true;
        }

        /// <summary>
        /// Método para inserir um paciente numa cama 
        /// </summary>
        /// <param name="nus"></param>
        /// <returns></returns>
        public static bool InserirPacienteCama(int nus)
        {
            Camas.InserirPacienteCama(nus);
            return true;
        }

        /// <summary>
        /// Método para Inserir um internamento na Lista
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool InserirInternamento(Internamento i)
        {
            Internamentos.InserirInternamento(i);
            return true;
        }

        /// <summary>
        /// Método para inserir uma consulta na Lista
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool InserirConsulta(Consulta c)
        {
            Consultas.InserirConsulta(c);
            return true;
        }

        /// <summary>
        /// Método para inserir um exame na Lista
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool InserirExame(Exame e)
        {
            Exames.InserirExame(e);
                return true;
        }

        /// <summary>
        /// Método para inserir um diagnostico na Lista
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool InserirDiagnostico(Diagnostico d)
        {
            if (d.IdExame != 0) // se o diagnostico nao corresponder a uma consulta não é inserido
            {
                Diagnosticos.InserirDiagnostico(d);
                return true;
            }
            return false;
            
        }

        /// <summary>
        /// Método para inserir uma Cirurgia na Lista
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool InserirCirurgia(Cirurgia c)
        {
            Cirurgias.InserirCirurgia(c);
                return true;
        }

        #endregion

        #region REMOÇÕES

        /// <summary>
        /// Método para remover um paciente numa cama 
        /// </summary>
        /// <param name="nus"></param>
        /// <returns></returns>
        public static bool RemoverPacienteCama(int nus)
        {
            Camas.RemoverPacienteCama(nus);
            return true;
        }

        /// <summary>
        /// Método para remover um paciente da Lista
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool RemoverPaciente(Paciente p)
        {
            Pacientes.RemoverPaciente(p);
                return true;
        }

        /// <summary>
        /// Método para remover um médico da Lista
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool RemoverMedico(Medico m)
        {
            Medicos.RemoverMedico(m);
                return true;
        }

        #endregion

        #region OBTER

        /// <summary>
        /// Método para retornar o id da cama de um determinado paciente
        /// </summary>
        /// <param name="nus"></param>
        /// <returns></returns>
        public static int IdCamaPaciente(int nus)
        {
            return Camas.IdCamaPaciente(nus);
        }

        /// <summary>
        /// Método para retornar o id de um exame feito por um paciente
        /// </summary>
        /// <param name="nus"></param>
        /// <returns></returns>
        public static int VerificaExamePaciente(int nus,int idExame)
        {
            return Exames.VerificaExamePaciente(nus,idExame);
        }

        #endregion

        #region TESTES

        /// <summary>
        /// Método para retornar o numero de dias que um paciente esteve internado
        /// </summary>
        /// <param name="nus"></param>
        /// <returns></returns>
        public static int DiasInternamento(int nus)
        {
            return Internamentos.DiasInternamentoPaciente(nus);
        }

        /// <summary>
        /// Método para retornar o custo do internamento de um paciente
        /// </summary>
        /// <param name="nus"></param>
        /// <returns></returns>
        public static double CustoInternamento(int nus)
        {
            return Internamentos.CalculaCustoInternamento(nus);
        }

        #endregion

        #region MOSTRA DADOS

        public static void HistoricoPaciente(int nus)
        {
            InOut.ImprimirConsultasPorPaciente(Consultas.ListaConsultas, nus);
            InOut.ImprimirExamesPorPaciente(Exames.ListaExames, nus);
            InOut.ImprimirDiagnosticosPorPaciente(Diagnosticos.ListaDiagnosticos, nus);
            InOut.ImprimirCirurgiasPorPaciente(Cirurgias.ListaCirurgias, nus);
            InOut.ImprimirInternamentosPorPaciente(Internamentos.ListaInternamentos, nus);
        }

        /// <summary>
        /// Método para Listar os pacientes
        /// </summary>
        public static void MostrarPacientes()
        {
            InOut.ImprimirPacientes(Pacientes.ListaPacientes);
        }

        /// <summary>
        /// Método para Listar os médicos
        /// </summary>
        public static void MostrarMedicos()
        {
            InOut.ImprimirMedicos(Medicos.ListaMedicos);
        }

        /// <summary>
        /// Método para Listar as Camas
        /// </summary>
        public static void MostrarCamas()
        {
            InOut.ImprimirCamas(Camas.ListaCamas);
        }

        /// <summary>
        /// Método para Listar os Internamentos
        /// </summary>
        public static void MostrarInternamentos()
        {
            InOut.ImprimirInternamentos(Internamentos.ListaInternamentos);
        }

        /// <summary>
        /// Método para Listar as Consultas
        /// </summary>
        public static void MostrarConsultas()
        {
            InOut.ImprimirConsultas(Consultas.ListaConsultas);
        }

        /// <summary>
        /// Método para Listar os Exames
        /// </summary>
        public static void MostrarExames()
        {
            InOut.ImprimirExames(Exames.ListaExames);
        }

        /// <summary>
        /// Método para Listar os Diagnosticos
        /// </summary>
        public static void MostrarDiagnosticos()
        {
            InOut.ImprimirDiagnosticos(Diagnosticos.ListaDiagnosticos);
        }

        /// <summary>
        /// Método para Listar as Cirurgias
        /// </summary>
        public static void MostrarCirurgias()
        {
            InOut.ImprimirCirurgias(Cirurgias.ListaCirurgias);
        }

        #endregion

    }
}
