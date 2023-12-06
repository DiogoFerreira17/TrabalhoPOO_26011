/*
 * TrabalhoPOO_26011
 * Nome:Diogo Alves Ferreira
 * Email:a26011@alunos.ipca.pt
 * Engenharia de Sistemas Informáticos
 * Escola Superior de Técnologia
 * 7-11-2023
 */

using System;

// Externo
using ObjetosHospital;
using Regras;

namespace GereHospital
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Criar Pacientes
            Paciente p1 = new Paciente("Diogo", new DateTime(1974, 11, 12), 203432345, tipoSanguineo.OPositivo);
            Paciente p2 = new Paciente("Joao", new DateTime(1989, 11, 12), 203432346, tipoSanguineo.ONegativo);
            Paciente p3 = new Paciente("David", new DateTime(1954, 11, 12), 203432342, tipoSanguineo.APositivo);
            Paciente p4 = new Paciente("Miguel", new DateTime(1994, 11, 12), 203432315, tipoSanguineo.ABPositivo);

            // Inserir Pacientes na Lista
            RegrasHospital.InserirPaciente(p1);
            RegrasHospital.InserirPaciente(p2);
            RegrasHospital.InserirPaciente(p3);
            RegrasHospital.InserirPaciente(p4);

            // Mostrar Pacientes
            //RegrasHospital.MostrarPacientes();

            // Cirar Médicos
            Medico m1 = new Medico("Narciso", new DateTime(1984, 11, 12), "Cirurgiao");
            Medico m2 = new Medico("Daniel", new DateTime(1973, 11, 12), "Pediatria");
            Medico m3 = new Medico("Vasco", new DateTime(2000, 11, 12), "Genecologia");
            Medico m4 = new Medico("Pedro", new DateTime(2001, 09, 11), "Cardiologia");

            // Inserir Médicos na Lista
            RegrasHospital.InserirMedico(m1);
            RegrasHospital.InserirMedico(m2);
            RegrasHospital.InserirMedico(m3);
            RegrasHospital.InserirMedico(m4);

            // Mostrar Medicos
            //RegrasHospital.MostrarMedicos();

            //Criar Camas
            Cama c1 = new Cama();
            Cama c2 = new Cama();
            Cama c3 = new Cama();
            Cama c4 = new Cama();

            // Inserir Camas na Lista
            RegrasHospital.InserirCama(c1);
            RegrasHospital.InserirCama(c2);
            RegrasHospital.InserirCama(c3);
            RegrasHospital.InserirCama(c4);

            // Inserir Paciente na Cama
            RegrasHospital.InserirPacienteCama(203432345);
            RegrasHospital.InserirPacienteCama(203432346);

            // Mostrar Camas da Lista
            //RegrasHospital.MostrarCamas();

            // Criar Internamnetos
            Internamento i1=new Internamento(new DateTime(2023, 1, 1), new DateTime(2023, 1, 10), 203432345, RegrasHospital.IdCamaPaciente(203432345));
            Internamento i2=new Internamento(new DateTime(2023, 10, 5), new DateTime(2023,12,8), 203432346, RegrasHospital.IdCamaPaciente(203432346));

            // Inserir  Internamento na Lista
            RegrasHospital.InserirInternamento(i1);
            RegrasHospital.InserirInternamento(i2);

            // Mostrar Internamentos da Lista
            //RegrasHospital.MostrarInternamentos();

            //Criar Consultas
            Consulta consulta1= new Consulta("Consulta de cardiologia",new DateTime(2023,2,13), 203432342,4,12.34);
            Consulta consulta2 = new Consulta("Consulta de Pediatria", new DateTime(2023, 2, 20), 203432315, 2, 20.00);
            Consulta consulta3 = new Consulta("Consulta de cardiologia", new DateTime(2023, 2, 15), 203432342, 4, 12.00);


            // Inserir Consultas na Lista
            RegrasHospital.InserirConsulta(consulta1);
            RegrasHospital.InserirConsulta(consulta2);
            RegrasHospital.InserirConsulta(consulta3);

            // Mostrar Consultas da Lista
            //RegrasHospital.MostrarConsultas();

            // Criar Exames
            Exame e1 = new Exame(new DateTime(2023,2,13),"fraco batimento cardiaco","eletrocardiograma", 203432342,4,15.00);
            Exame e2 = new Exame(new DateTime(2023, 2, 20), "Algum resultado...", "tipo exame", 203432315, 2, 10.00);

            // Inserir Exames na Lista
            RegrasHospital.InserirExame(e1);
            RegrasHospital.InserirExame(e2);

            // Mostrar Exames da Lista
            //RegrasHospital.MostrarExames();

            // Criar Diagnosticos
            Diagnostico d1 = new Diagnostico(new DateTime(2023, 3, 1), 4, 203432342,RegrasHospital.VerificaExamePaciente(203432342,1),"descrição do diagnostico");
            Diagnostico d2 = new Diagnostico(new DateTime(2023, 3, 2), 4, 203432315, RegrasHospital.VerificaExamePaciente(203432315,2), "descrição do diagnostico");

            // Inserir Diagnosticos na Lista
            RegrasHospital.InserirDiagnostico(d1);
            RegrasHospital.InserirDiagnostico(d2);

            // Mostrar Diagnosticos da Lista
            //RegrasHospital.MostrarDiagnosticos();

            // Criar Cirurgias
            Cirurgia cirurgia1 = new Cirurgia(new DateTime(2023, 1, 1), 203432342, 1,100.00);
            Cirurgia cirurgia2 = new Cirurgia(new DateTime(2023, 5, 30), 203432342, 1,1500.00);

            // Inserir Cirurgias
            RegrasHospital.InserirCirurgia(cirurgia1);
            RegrasHospital.InserirCirurgia(cirurgia2);

            // Mostrar cirurgias
            //RegrasHospital.MostrarCirurgias();

            RegrasHospital.HistoricoPaciente(203432342);

        }
    }
}
