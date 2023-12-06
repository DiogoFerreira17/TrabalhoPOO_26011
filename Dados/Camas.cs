/*
 * TrabalhoPOO_26011
 * Nome:Diogo Alves Ferreira
 * Email:a26011@alunos.ipca.pt
 * Engenharia de Sistemas Informáticos
 * Escola Superior de Técnologia
 * 7-11-2023
 */

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
        static int numCamas;

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
                numCamas = 0;
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

        public static int NumCamas 
        { 
            get { return numCamas; }
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
                camas.Add(c);
                numCamas++;
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
                numCamas--;
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
            if (Pacientes.ExistePacienteLista(nus))
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
            if (Pacientes.ExistePacienteLista(nus))
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
            if (Pacientes.ExistePacienteLista(nus))
            {
                foreach(Cama c in camas)
                {
                    if (c.Nus == nus)
                    {
                        return c.IdCama; // retorna id para identificar a cama no internamento
                    }
                }
            }
            return 0;
        }

        #endregion

        #endregion

    }
}
