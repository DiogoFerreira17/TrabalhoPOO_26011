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
    /// <summary>
    /// Classe que gere um conjunto de Pacientes
    /// </summary>
    //public class Pacientes
    //{
    //    /// <summary>
    //    /// Campos privados para armazenar o estado de Pacientes
    //    /// </summary>
    //    #region ATRIBUTOS

    //    const int MAXPACIENTES = 10;
    //    static Paciente[] pacientes;
    //    static int numPacientes; // numero de pacientes inseridos no array

    //    #endregion

    //    #region COMPORTAMENTOS

    //    #region CONSTRUTORES

    //    /// <summary>
    //    /// Construtor da classe Pacientes
    //    /// </summary>
    //    static Pacientes() // se estiver static não precisa de inicializar na main (!!! Pacientes pacientes= new Pacientes() !!!) 
    //    {
    //        numPacientes = 0;
    //        if (pacientes == null)
    //        {
    //            pacientes = new Paciente[MAXPACIENTES];
    //        }
    //    }

    //    #endregion

    //    #region PROPRIEDADES

    //    /// <summary>
    //    /// Devolve o conjunto de pacientes existentes
    //    /// </summary>
    //    public static Paciente[] arrayPacientes 
    //    {
    //        get { return (Paciente[])pacientes.Clone(); }
    //    }

    //    public static int NumPacientes
    //    {
    //        get { return numPacientes; }
    //    }

    //    #endregion

    //    #region MÉTODOS

    //    /// <summary>
    //    /// Método para inserir um paciente no array pacientes
    //    /// </summary>
    //    /// <param name="p"></param>
    //    /// <returns></returns>
    //    public static bool InserirPaciente(Paciente p)
    //    {
    //        if (p != null) //  && numPacientes < MAXPACIENTES
    //        {
    //            pacientes[numPacientes] = p;
    //            numPacientes++;
    //            return true;
    //        }
    //        return false;
    //    }

    //    /// <summary>
    //    /// Método para remover um paciente de um Array
    //    /// </summary>
    //    /// <param name="p"></param>
    //    /// <returns></returns>
    //    public static bool RemoverPaciente(Paciente p)
    //    {
    //        if (p != null)
    //        {
    //            for (int i = 0; i < pacientes.Length; i++)
    //            {
    //                if (pacientes[i] == p)
    //                {
    //                    for (int j = i; j < pacientes.Length - 1; j++)
    //                    {
    //                        pacientes[j] = pacientes[j + 1];
    //                    }
    //                    numPacientes--;
    //                    return true;
    //                }
    //            }
    //        }
    //        return false;
    //    }

    //    /// <summary>
    //    /// Método para obter um Paciente pelo seu numero de utente
    //    /// </summary>
    //    /// <param name="nus"></param>
    //    /// <returns></returns>
    //    public static Paciente ObterPacientePorNus(int nus)
    //    {
    //        for (int i = 0; i < numPacientes; i++)
    //        {
    //            if (pacientes[i] != null && pacientes[i].Nus == nus)
    //            {
    //                return pacientes[i];
    //            }
    //        }
    //        return null;
    //    }

    //    #endregion

    //    #endregion
    //}         

    public class Pacientes
    {
        /// <summary>
        /// Campos privados para armazenar o estado de Pacientes
        /// </summary>
        #region ATRIBUTOS

        static List<Paciente> pacientes = new List<Paciente>();
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
            get { return new List<Paciente>(pacientes); }
        }

        public static int NumPacientes
        {
            get { return numPacientes; }
        }

        #endregion

        #region OUTROS MÉTODOS

        /// <summary>
        /// Método para inserir um paciente na Lista pacientes
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool InserirPaciente(Paciente p)
        {
            if (p != null && EncontrarPacienteLista(p))
            {
                pacientes.Add(p);
                numPacientes++;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para remover um paciente de uma Lista
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool RemoverPaciente(Paciente p)
        {
            if (p != null && EncontrarPacienteLista(p))
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
        /// Método para verificar se um paciente está na Lista
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool EncontrarPacienteLista(Paciente p)
        {
            if (p != null)
            {
                foreach (Paciente paciente in pacientes)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #endregion
    }

}
