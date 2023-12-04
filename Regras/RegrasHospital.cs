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

namespace Regras
{
    public class RegrasHospital
    {
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
            if(m!=null) // apenas para teste
            {
                Medicos.InserirMedico(m);
                return true;
            }
            return false;
        }

        public static bool InserirCama(Cama c)
        {
            if(c!=null) // apenas para teste
            {
                Camas.InserirCama(c);
                return true;
            }
            return false;
        }

        public static bool InserirPacienteCama(int nus)
        {
            Camas.InserirPacienteCama(nus);
                return true;
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

        public static void MostrarCamas()
        {
            InOut.ImprimirCamas(Camas.ListaCamas);
        }
    }
}
