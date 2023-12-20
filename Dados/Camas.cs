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
    /// <summary>
    /// Classe que gere um conjunto de Camas
    /// </summary>
    public class Camas
    {
        /// <summary>
        /// Campos privados para armazenar o estado das camas
        /// </summary>
        #region ATRIBUTOS

        static List<Cama> camas;

        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrao da classe Camas
        /// </summary>
        static Camas()
        {
            if (camas == null)
            {
                camas = new List<Cama>();
            }
        }

        #endregion

        /// <summary>
        /// Obtém as caracteristicas dos Camas
        /// </summary>
        #region PROPRIEDADES

        /// <summary>
        /// Retorna a Lista
        /// </summary>
        public static List<Cama> ListaCamas
        {
            get { return new List<Cama>(camas); }
        }

        #endregion

        #region OUTROS MÉTODOS

        /// <summary>
        /// Método para inserir uma cama na Lista
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool InserirCama(Cama c)
        {
            if(c!=null && !camas.Contains(c))
            {
                if (camas.Count >= 5) // VERIFICAR COM O PROF   (5 -> NUMERO DE CAMAS QUE O HOSPITAL SUPORTA)
                {
                    throw new Exception("O hospital não suporta mais camas.");
                }
                camas.Add(c);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para remover uma cama da Lista 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool RemoverCama(Cama c)
        {
            if (c != null && camas.Contains(c))
            {
                camas.Remove(c);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para inserir um paciente numa cama
        /// </summary>
        /// <param name="nus"></param>
        /// <returns></returns>
        public static bool InserirPacienteCama(int nus)
        {
            foreach (Cama c in camas)
            {
                if (c.Status == "livre")
                {
                    c.Nus = nus;
                    c.Status = "ocupada";
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Método para remover um paciente de uma cama
        /// </summary>
        /// <param name="nus"></param>
        /// <returns></returns>
        public static bool RemoverPacienteCama(int nus)
        {
            foreach (Cama c in camas)
            {
                if (c.Nus==nus)
                {
                    c.Nus = 0;
                    c.Status = "livre";
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Método para retornar o id da cama de um determinado paciente
        /// </summary>
        /// <param name="nus"></param>
        /// <returns></returns>
        public static int IdCamaPaciente(int nus)
        {
            foreach(Cama c in camas)
            {
                if (c.Nus == nus)
                {
                    return c.IdCama; // retorna id para identificar a cama no internamento
                }
            }
            return 0; 
        }

        /// <summary>
        /// Método para verificar se um paciente ja está numa cama
        /// </summary>
        /// <param name="nus"></param>
        /// <returns></returns>
        public static bool VerificaPacienteCama(int nus)
        {
            if (Pacientes.ExistePacienteLista(nus))
            {
                foreach (Cama c in camas)
                {
                    if (c.Nus == nus)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Método para retornar a Lista de camas
        /// </summary>
        /// <returns></returns>
        public static List<Cama> TodasCamas()
        {
            return ListaCamas;
        }

        #endregion

        #endregion

    }
}
