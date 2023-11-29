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
    /// Classe que gere um conjunto de Medicos
    /// </summary>
    public class Medicos
    {
        /// <summary>
        /// Campos privados para armazenar o estado de Medicos
        /// </summary>
        #region ATRIBUTOS

        static int numMedicos;
        static List<Medico> medicos;

        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        static Medicos()
        {
            if(medicos==null)
            {   
                numMedicos = 0;
                medicos = new List<Medico> ();
            }
        }

        #endregion

        /// <summary>
        /// Obtém as caracteristicas da Lista
        /// </summary>
        #region PROPRIEDADES

        /// <summary>
        /// Faz #### da Lista Medicos
        /// </summary>
        public static List<Medico> ListaMedicos
        {
            get { return new List<Medico>(medicos); }
        }

        public static int NumMedicos
        {
            get { return numMedicos; }
        }

        #endregion

        #region OUTROS MÉTODOS

        /// <summary>
        /// Método para inserir um Medico na Lista
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool InserirMedico(Medico m)
        {
            if (m != null && !EncontrarMedicoLista(m))
            {
                medicos.Add(m);
                numMedicos++;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para remover um Medico da Lista
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool RemoverMedico(Medico m)
        {
           if(m!=null && EncontrarMedicoLista(m))
            {
                medicos.Remove(m);
                numMedicos--;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para obter um médico pelo seu id
        /// </summary>
        /// <param name="idMedico"></param>
        /// <returns></returns>
        public static Medico ObterMedicoPorNus(int idMedico)
        {
            return medicos.Find(m => m != null && m.IdMedico == idMedico);  // m => (declara variavel)  
        }

        /// <summary>
        /// Método para verificar se um médico está na Lista
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool EncontrarMedicoLista(Medico m)
        {
            if(m!=null)
            {
                foreach (Medico medico in medicos)
                {
                    if (medico.Equals(m))
                    {
                        return true;
                    }
                    
                }
            }
            return false;
        }

        #endregion

        #endregion

    }
}
