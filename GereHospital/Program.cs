using System;
using System.Threading;

// Externo
using ObjetosHospital;
using Regras;

namespace GereHospital
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
            RegrasHospital.InserirPaciente(p1);
            Console.WriteLine(RegrasHospital.InserirPaciente(p1));
            RegrasHospital.InserirPaciente(p2);
            RegrasHospital.InserirPaciente(p3);
            RegrasHospital.InserirPaciente(p4);

        }
    }
}
