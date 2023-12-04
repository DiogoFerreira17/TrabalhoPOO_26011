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
    /// Classe que representa um Exame
    /// </summary>
    public class Exame
    {
        /// <summary>
        /// Campos privados para armazenar o estado do Exame
        /// </summary>
        #region Atributos

        DateTime data;
        string nome;
        static int numExames; // para criar o id do exame automatico
        int idExame;
        int nus;
        int idMedico;
        string resultado;
        double precoExame;

        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrão da classe Exame
        /// </summary>
        public Exame()
        {
            data = DateTime.Now;
            idExame=0;
            nome=string.Empty;
            resultado = string.Empty;
            nus = 0;
            idMedico=0;
            precoExame = 0.0;
            ++numExames;
        }

        /// <summary>
        /// Construtor parametrizado da classe Exame
        /// </summary>
        /// <param name="data"></param>
        /// <param name="resultado"></param>
        /// <param name="nome"></param>
        /// <param name="nus"></param>
        /// <param name="idMedico"></param>
        /// <param name="preco"></param>
        public Exame(DateTime data, string resultado,string nome,int nus,int idMedico,double precoExame)
        {
            this.data = data;
            this.nome = nome;
            this.resultado = resultado;
            this.nus = nus;
            this.idMedico = idMedico;
            this.precoExame = precoExame;
            idExame = ++numExames;
        }

        #endregion

        /// <summary>
        /// Obtém ou define as caracteristicas do Exame
        /// </summary>
        #region PROPRIEDADES

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public int IdExame
        {
            get { return idExame; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }
        public int Nus
        {
            get { return nus; }
            set { nus = value; }
        }

        public int IdMedico
        {
            get { return idMedico; }
            set { idMedico = value; }
        }

        public double PrecoExame
        {
            get { return precoExame; }
            set { precoExame = value; }
        }

        #endregion

        #endregion

        #region OUTROS MÉTODOS

        /// <summary>
        /// Metodo para mostrar parametros do Exame
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("IdExame:{0} DataExame:{1} NomeExame:{2} NUS:{3} idMédico:{4} Resultado:{5} Preço:{6}",IdExame,Data,Nome,Nus,IdMedico,Resultado,PrecoExame);
        }

        #endregion
    }
}
