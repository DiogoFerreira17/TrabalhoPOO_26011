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
    public class Pacientes
    {
        /// <summary>
        /// Campos privados para armazenar o estado de Pacientes
        /// </summary>
        #region ATRIBUTOS

        static List<Paciente> pacientes;
        static int numPacientes; // numero de pacientes inseridos na Lista

        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        static Pacientes() // se estiver static não precisa de inicializar na main (!!! Pacientes pacientes= new Pacientes() !!!) 
        {
            if (pacientes == null)
            {
                numPacientes = 0;
                pacientes = new List<Paciente>();
            }
        }

        #endregion

        /// <summary>
        /// Obtém as caracteristicas da Lista
        /// </summary>
        #region PROPRIEDADES

        public static List<Paciente> ListaPacientes
        {
            get { 
                return new List<Paciente>(pacientes); 
            }
        }

        public static int NumPacientes
        {
            get { return numPacientes; }
        }

        #endregion

        #region OUTROS MÉTODOS

        /// <summary>
        /// Método para inserir um paciente na Lista 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool InserirPaciente(Paciente p)
        {
            if (p != null && !pacientes.Contains(p)) 
            {
                pacientes.Add(p);
                numPacientes++;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para remover um paciente da Lista
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool RemoverPaciente(Paciente p)
        {
            if (p != null && pacientes.Contains(p))
            {
                pacientes.Remove(p);
                numPacientes--;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para obter um Paciente pelo seu numero de utente
        /// </summary>
        /// <param name="nus"></param>
        /// <returns></returns>
        public static Paciente ObterPacientePorNus(int nus)
        {
            return pacientes.Find(p => p != null && p.Nus == nus);
        }

        /// <summary>
        /// Método para verificar se existe um paciente na Lista através do seu NUS
        /// </summary>
        /// <param name="nus"></param>
        /// <returns></returns>
        public static bool ExistePacienteLista(int nus)
        {
            return ObterPacientePorNus(nus) != null;
        }

        #endregion

        #endregion
    }

}
