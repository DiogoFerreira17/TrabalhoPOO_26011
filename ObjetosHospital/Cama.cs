/*
 * TrabalhoPOO_26011
 * Nome:Diogo Alves Ferreira
 * Email:a26011@alunos.ipca.pt
 * Engenharia de Sistemas Informáticos
 * Escola Superior de Técnologia
 * 7-11-2023
 */

using System;

namespace ObjetosHospital
{
    /// <summary>
    /// Classe que representa uma Cama
    /// </summary>
    public class Cama
    {

        /// <summary>
        /// Campos privados para armazenar o estado da cama
        /// </summary>
        #region Atributos

        string status; // info: cama ocupada ou livre
        int nus;
        static int numCamas;
        int idCama;
        
        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrao da classe Cama
        /// </summary>
        public Cama()
        {
            status = "livre";
            this.idCama = ++numCamas;
            nus = 0;
        }

        #endregion

        /// <summary>
        /// Obtém ou define as caracteristicas da Cama
        /// </summary>
        #region PROPRIEDADES

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public int Nus
        {
            get { return nus; }
            set { nus = value; }
        }

        public int IdCama
        {
            get { return idCama; }
        }

        #endregion

        #region OUTROS MÉTODOS

        // Método para inserir um paciente numa cama

        // Método para remover um paciente de uma cama 

        // Método para mostrar todas as camas com os devidos pacientes

        // Método para mostrar em que cama está determinado paciente

        #endregion

        #region OVERRIDES

        /// <summary>
        /// Metodo para mostrar parametros da Cama
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("idCama:{0} Ocupação:{1} NUS:{2}",idCama,Status,Nus);
        }
        #endregion

        #endregion
    }
}
