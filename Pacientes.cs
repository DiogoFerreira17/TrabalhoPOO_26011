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
    /// <summary>
    /// Classe que gere um conjunto de Pacientes
    /// </summary>
    public class Pacientes
    {
        /// <summary>
        /// Campos privados para armazenar o estado de Pacientes
        /// </summary>
        #region ATRIBUTOS

        const int MAXPACIENTES = 10;
        static Paciente[] pacientes;
        static int numPacientes; // numero de pacientes inseridos no array

        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor da classe Pacientes
        /// </summary>
        public Pacientes()
        {
            numPacientes = 0;
            if (pacientes == null)
            {
                pacientes = new Paciente[MAXPACIENTES];
            }
        }

        #endregion

        #region PROPRIEDADES

        /// <summary>
        /// Devolve o conjunto de pacientes existentes
        /// </summary>
        public static Paciente[] arrayPacientes 
        {
            get { return (Paciente[])pacientes.Clone(); }
        }

        public static int NumPacientes
        {
            get { return numPacientes; }
        }

        #endregion

        #region MÉTODOS

        public static bool InserirPaciente(Paciente p)
        {
            if (p != null && numPacientes<MAXPACIENTES)
            {
                pacientes[numPacientes] = p;
                numPacientes++;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para remover um paciente de um Array
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool RemoverPaciente(Paciente p)
        {
            if (p != null)
            {
                for (int i = 0; i < pacientes.Length; i++)
                {
                    if (pacientes[i] == p)
                    {
                        for (int j = i; j < pacientes.Length - 1; j++)
                        {
                            pacientes[j] = pacientes[j + 1];
                        }
                        numPacientes--;
                        return true;
                    }
                }
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
            for (int i = 0; i < numPacientes; i++)
            {
                if (pacientes[i] != null && pacientes[i].Nus == nus)
                {
                    return pacientes[i];
                }
            }
            return null;
        }

        #endregion

        #endregion
    }         
}
