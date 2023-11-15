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
    /// Classe que gere um conjunto de Medicos
    /// </summary>
    public class Medicos
    {
        /// <summary>
        /// Campos privados para armazenar o estado de Medicos
        /// </summary>
        #region ATRIBUTOS
        const int MAXMEDICOS = 10;
        static int numMedicos;
        static Medico[] medicos;
        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        public Medicos()
        {
            numMedicos = 0;
            if(medicos==null)
            {
                medicos = new Medico[MAXMEDICOS];
            }
        }

        #endregion

        /// <summary>
        /// Obtém as caracteristicas do médico
        /// </summary>
        #region PROPRIEDADES

        /// <summary>
        /// Faz clone do array medicos
        /// </summary>
        public static Medico[] arrayMedicos
        {
            get { return (Medico[])medicos.Clone(); }
        }

        public static int NumMedicos
        {
            get { return numMedicos; }
        }

        #endregion

        #region MÉTODOS

        /// <summary>
        /// Método para inserir um Medico num Array 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool InserirMedico(Medico m)
        {
            if (m != null && numMedicos<MAXMEDICOS)
            {
                medicos[numMedicos] = m;
                numMedicos++;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para remover um Medico de um Array
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool RemoverMedico(Medico m)
        {
            if (m != null)
            {
                for (int i = 0; i < medicos.Length; i++)
                {
                    if (medicos[i] == m)
                    {
                        for (int j = i; j < medicos.Length - 1; j++)
                        {
                            medicos[j] = medicos[j + 1];
                        }
                        numMedicos--;
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Método para Obter um médico pelo seu id
        /// </summary>
        /// <param name="idMedico"></param>
        /// <returns></returns>
        public static Medico ObterMedicoPorId(int idMedico)
        {
            for (int i = 0; i < numMedicos; i++)
            {
                if (medicos[i] != null && medicos[i].IdMedico == idMedico)
                {
                    return medicos[i];
                }
            }
            return null;
        }

        #endregion

        #endregion

    }
}
