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

namespace TrabalhoPOO_26011
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Criar Paciente
            Paciente p1 = new Paciente("Diogo", new DateTime(1974, 11, 12), 203432345, tipoSanguineo.OPositivo);
            Paciente p2 = new Paciente("Joao", new DateTime(1989, 11, 12), 203432346, tipoSanguineo.ONegativo);
            Paciente p3 = new Paciente("David", new DateTime(1954, 11, 12), 203432342, tipoSanguineo.APositivo);
            Paciente p4 = new Paciente("Miguel", new DateTime(1994, 11, 12), 203432315, tipoSanguineo.ABPositivo);

            // Inserir Pacientes
            Pacientes.InserirPaciente(p1);
            Pacientes.InserirPaciente(p2);
            Pacientes.InserirPaciente(p3);
            Pacientes.InserirPaciente(p4);


            InOut.ImprimirPacientes(Pacientes.ListaPacientes);
            //Console.WriteLine(Pacientes.ObterPacientePorNus(203432346)); // Joao 

            // Remover Pacientes
            Pacientes.RemoverPaciente(p1);
            Pacientes.RemoverPaciente(p2);
            Pacientes.RemoverPaciente(p3);

            //InOut.ImprimirPacientes(Pacientes.ListaPacientes);
            
            // Criar Médico
            Medico m1 = new Medico("Narciso", new DateTime(1984, 11, 12), "Cirurgiao");
            Medico m2 = new Medico("Daniel", new DateTime(1973, 11, 12), "Pediatria");
            Medico m3 = new Medico("Vasco", new DateTime(2000, 11, 12), "Genecologia");

            Medicos.InserirMedico(m1);

            //Cama c1 = new Cama(p1);
            //Cama c2 = new Cama(p2);
            //Cama c3 = new Cama(p3);

            //Console.WriteLine(m1.IdFuncionario);
            //Console.WriteLine(m2.IdFuncionario);
            //Console.WriteLine(m3.IdFuncionario);

            //Console.WriteLine(p1.Equals(p1)); // testar funcionamento do Equals em Paciente

            //Console.WriteLine(di);  // Redundancia do nome do paciente porque recebe o paciente do exame (que está definido no seu ToString)


            //Pacientes pacientes = new Pacientes();// INICIALIZA ARRAY PACIENTES

            Medicos medicos = new Medicos();
            Medicos.InserirMedico(m1);
            Medicos.InserirMedico(m2);
            //Console.WriteLine(Pacientes.NumPacientes);
            //Consultas consultas = new Consultas(); // INICIALIZA ARRAY CONSULTAS
            //Consulta c1 = new Consulta("Optometria", DateTime.Now, 203432345, 2, 20.0);
            //Consulta c2 = new Consulta("Optometria", DateTime.Now, 20343234, 2, 20.0);


            Exames exames = new Exames();
            Exame ex = new Exame(DateTime.Now, "Teste", "Topografia", 203432345, 1, 12.90);

            
        }
    }
}
