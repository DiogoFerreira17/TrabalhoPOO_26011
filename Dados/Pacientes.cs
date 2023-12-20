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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

// Externo
using ObjetosHospital;

namespace Dados
{
    [Serializable]
    public class Pacientes
    {
        /// <summary>
        /// Campos privados para armazenar o estado de Pacientes
        /// </summary>
        #region ATRIBUTOS

        static List<Paciente> pacientes;

        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        static Pacientes() // se estiver static não precisa de inicializar na main (!!! Pacientes pacientes= new Pacientes() !!!) 
        {
            if (pacientes == null)
            {
                pacientes = new List<Paciente>();
            }
        }

        #endregion

        /// <summary>
        /// Obtém as caracteristicas da Lista
        /// </summary>
        #region PROPRIEDADES

        public static List<Paciente> listaPacientes
        {
            get { return new List<Paciente>(pacientes); }
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

        /// <summary>
        /// Método para retornar a Lista de pacientes
        /// </summary>
        /// <returns></returns>
        public static List<Paciente> ListaPacientes()
        {
            return pacientes;
        }

        /// <summary>
        /// Guarda Lista em ficheiro
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public static bool GuardarFicheiroPacientes(string nomeFicheiro)
        {
            if (!File.Exists(nomeFicheiro))
            {
                try
                {
                    Stream stream = File.Open(nomeFicheiro, FileMode.Create);
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, pacientes);
                    stream.Close();
                    return true;
                }
                catch (IOException e)
                {
                    throw e;
                }
            }
            return false;
        }

        /// <summary>
        /// Método para ler ficheiro 
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public static bool LerFicheiroPacientes(string nomeFicheiro)
        {
            if (File.Exists(nomeFicheiro))
            {
                try
                {
                    Stream stream = File.Open(nomeFicheiro, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    pacientes = (List<Paciente>)bin.Deserialize(stream);
                    stream.Close();
                    return true;
                }
                catch (IOException e)
                {
                    throw e;
                }
            }
            return false;
        }

        #endregion

        #endregion
    }

}
