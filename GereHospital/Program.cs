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
using Regras;

namespace GereHospital
{
    public class Program
    {
        static void Main(string[] args)
        {
            Paciente p1 = new Paciente("Diogo", new DateTime(1974, 11, 12), 203432345, tipoSanguineo.OPOSITIVO,"pago");
            Paciente p2 = new Paciente("Claudio", new DateTime(1989, 11, 12), 203432346, tipoSanguineo.ONEGATIVO,"pago");
            Paciente p3 = new Paciente("David", new DateTime(1954, 11, 12), 203432342, tipoSanguineo.APOSITIVO,"pago");
            Paciente p4 = new Paciente("Miguel", new DateTime(1994, 11, 12), 203432315, tipoSanguineo.ABPOSITIVO,"atraso");
            Paciente p5 = new Paciente("Luis", new DateTime(1984, 11, 12), 203435467, tipoSanguineo.ABPOSITIVO,"atraso");

            // Inserir Pacientes na Lista
            RegrasPacientes.InserirPaciente(p1);
            RegrasPacientes.InserirPaciente(p2);
            RegrasPacientes.InserirPaciente(p3);
            RegrasPacientes.InserirPaciente(p4);
            RegrasPacientes.InserirPaciente(p5);

            // Mostrar Pacientes
            List<Paciente> listaPacientes = RegrasPacientes.ListaPacientes();
            //InOut.ImprimirPacientes(listaPacientes);

            // Cirar Médicos
            Medico m1 = new Medico("Narciso", new DateTime(1984, 11, 12), "Cirurgiao");
            Medico m2 = new Medico("Daniel", new DateTime(1973, 11, 12), "Pediatria");
            Medico m3 = new Medico("Vasco", new DateTime(2000, 11, 12), "Genecologia");
            Medico m4 = new Medico("Pedro", new DateTime(2001, 09, 11), "Cardiologia");

            // Inserir Médicos na Lista
            RegrasMedicos.InserirMedico(m1);
            RegrasMedicos.InserirMedico(m2);
            RegrasMedicos.InserirMedico(m3);
            RegrasMedicos.InserirMedico(m4);

            // Mostrar Medicos
            List<Medico> listaMedicos = RegrasMedicos.ListaMedicos();
            //InOut.ImprimirMedicos(listaMedicos);

            //Criar Camas
            Cama c1 = new Cama();
            Cama c2 = new Cama();
            Cama c3 = new Cama();
            Cama c4 = new Cama();
            Cama c5 = new Cama();
            Cama c6 = new Cama();
            Cama c7 = new Cama();

            // Inserir Camas na Lista
            RegrasCamas.InserirCama(c1);
            RegrasCamas.InserirCama(c2);
            RegrasCamas.InserirCama(c3);
            RegrasCamas.InserirCama(c4);
            RegrasCamas.InserirCama(c5);
            //RegrasCamas.InserirCama(c6);
            //RegrasCamas.InserirCama(c7);

            // Inserir Pacientes na Cama
            RegrasCamas.InserirPacienteCama(203432345);
            RegrasCamas.InserirPacienteCama(203432346);

            // Remover Pacientes da cama
            //RegrasCamas.RemoverPacienteCama(203432345);

            // Mostrar Camas da Lista
            List<Cama> listaCamas = RegrasCamas.ListaCamas();
            //InOut.ImprimirCamas(listaCamas);

            // Criar Internamnetos
            Internamento i1 = new Internamento(new DateTime(2023, 1, 1), new DateTime(2023, 1, 10), 203432345, RegrasCamas.IdCamaPaciente(203432345));
            Internamento i2 = new Internamento(new DateTime(2023, 10, 5), new DateTime(2023, 12, 8), 203432346, RegrasCamas.IdCamaPaciente(203432346));
            Internamento i3 = new Internamento(new DateTime(2023, 1, 15), new DateTime(2023, 1, 30), 203432345, RegrasCamas.IdCamaPaciente(203432345));


            // Inserir  Internamento na Lista
            RegrasInternamentos.InserirInternamento(i1);
            RegrasInternamentos.InserirInternamento(i2);
            RegrasInternamentos.InserirInternamento(i3);

            // Calcula custo Internamento
            RegrasInternamentos.CustoInternamento(203432345, new DateTime(2023, 1, 1));
            RegrasInternamentos.CustoInternamento(203432346, new DateTime(2023, 10, 5));
            RegrasInternamentos.CustoInternamento(203432345, new DateTime(2023, 1, 15));

            // Mostrar Internamentos da Lista
            List<Internamento> listaInternamentos = RegrasInternamentos.ListaInternamentos();
            //InOut.ImprimirInternamentos(listaInternamentos);

            //Criar Consultas
            Consulta consulta1 = new Consulta("Consulta de cardiologia",new DateTime(2023, 2, 13), 203432345, 4, 12.34);
            Consulta consulta2 = new Consulta("Consulta de Pediatria", new DateTime(2023, 2, 20), 203432315, 2, 20.00);
            Consulta consulta3 = new Consulta("Consulta de cardiologia", new DateTime(2023, 2, 15), 203432342, 4, 12.00);
            Consulta consulta4 = new Consulta("Consulta de cardiologia", new DateTime(2023, 2, 15), 203432345, 4, 12.00);

            // Inserir Consultas na Lista
            RegrasConsultas.InserirConsulta(consulta1);
            RegrasConsultas.InserirConsulta(consulta2);
            RegrasConsultas.InserirConsulta(consulta3);
            RegrasConsultas.InserirConsulta(consulta4);

            // Mostrar Consultas da Lista
            List<Consulta> listaConsultas = RegrasConsultas.ListaConsultas(); // a lista inteira 
            List<Consulta> listaConsultasPaciente = RegrasConsultas.ConsultasPaciente(203432345); // de um paciente
            //InOut.ImprimirConsultas(listaConsultas);
            //InOut.ImprimirConsultas(listaConsultasPaciente);

            // Criar Exames
            Exame e1 = new Exame(new DateTime(2023, 2, 13), "fraco batimento cardiaco", "eletrocardiograma", 203432345, 4, 15.00);
            Exame e2 = new Exame(new DateTime(2023, 2, 20), "Algum resultado...", "tipo exame", 203432315, 2, 10.00);
            Exame e3 = new Exame(new DateTime(2023, 4, 20), "Algum resultado...", "tipo exame", 203432345, 2, 20.00);

            // Inserir Exames na Lista
            RegrasExames.InserirExame(e1);
            RegrasExames.InserirExame(e2);
            RegrasExames.InserirExame(e3);

            // Mostrar Exames da Lista
            List<Exame> listaExames = RegrasExames.ListaExames();
            List<Exame> examesPaciente = RegrasExames.ExamesPaciente(203432345);
            //InOut.ImprimirExames(listaExames);
            //InOut.ImprimirExames(examesPaciente);

            // Custo exames de um paciente
            RegrasExames.CustoExamesPaciente(examesPaciente);

            // Criar Diagnosticos
            Diagnostico d1 = new Diagnostico(new DateTime(2023, 3, 1), 4, 203432345, RegrasExames.VerificaExamePaciente(203432345, 1), "problema de coração");
            Diagnostico d2 = new Diagnostico(new DateTime(2023, 3, 2), 4, 203432315, RegrasExames.VerificaExamePaciente(203432315, 2), "descrição do diagnostico");

            // Inserir Diagnosticos na Lista
            RegrasDiagnosticos.InserirDiagnostico(d1);
            RegrasDiagnosticos.InserirDiagnostico(d2);

            // Mostrar Diagnosticos da Lista
            List<Diagnostico> listaDiagnosticos = RegrasDiagnosticos.ListaDiagnosticos();
            //InOut.ImprimirDiagnosticos(listaDiagnosticos);

            // Criar Cirurgias
            Cirurgia cirurgia1 = new Cirurgia(new DateTime(2023, 1, 1), 203432345, 1, 100.00);
            Cirurgia cirurgia2 = new Cirurgia(new DateTime(2023, 5, 30), 203432342, 1, 1500.00);

            // Inserir Cirurgias
            RegrasCirurgias.InserirCirurgia(cirurgia1);
            RegrasCirurgias.InserirCirurgia(cirurgia2);

            // Mostrar cirurgias
            List<Cirurgia> listaCirurgias = RegrasCirurgias.ListaCirurgias();
            //InOut.ImprimirCirurgias(listaCirurgias);

            // Mostrar Histórico de um paciente
            //InOut.HistoricoPaciente(203432345, listaConsultas, listaExames, listaDiagnosticos, listaCirurgias, listaInternamentos);

            //Console.WriteLine(RegrasPacientes.GuardarFicheiroPacientes("Todos_Pacientes"));
            //Console.WriteLine(RegrasPacientes.LerFicheiroPacientes("Todos_Pacientes"));

        }
    }
}
