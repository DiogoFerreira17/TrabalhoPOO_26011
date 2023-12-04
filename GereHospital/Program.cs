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

            // Inserir Pacientes
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

            // Inserir Médicos
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

            // Inserir Camas
            RegrasHospital.InserirCama(c1);
            RegrasHospital.InserirCama(c2);
            RegrasHospital.InserirCama(c3);
            RegrasHospital.InserirCama(c4);

            // Inserir Paciente na Cama
            RegrasHospital.InserirPacienteCama(203432345);

            // Mostrar Camas
            RegrasHospital.MostrarCamas();
        }
    }
}
