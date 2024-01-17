/*
 * TrabalhoPOO_26011
 * Nome:Diogo Alves Ferreira
 * Email:a26011@alunos.ipca.pt
 * Engenharia de Sistemas Informáticos
 * Escola Superior de Técnologia
 * 7-11-2023
 */

using System;
using System.Linq;

// Externo
using Excecoes;

public enum tipoSanguineo { OPOSITIVO, ONEGATIVO, APOSITIVO, ANEGATIVO, BPOSITIVO, BNEGATIVO, ABPOSITIVO, ABNEGATIVO }

namespace ObjetosHospital
{
    /// <summary>
    /// Representa um paciente, derivado da classe Pessoa
    /// </summary>
    [Serializable]
    public class Paciente : Pessoa,IComparable<Paciente>
    {

        /// <summary>
        /// Campos privados para armazenar o estado do paciente
        /// </summary>
        #region Atributos

        int nus; // numero utente de saude
        tipoSanguineo sangue;
        string segurancaSocial; // para usar nas regras 

        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrao da classe Paciente
        /// </summary>
        public Paciente()
        {
            Nome = string.Empty;
            sangue = tipoSanguineo.OPOSITIVO;
            nus = 000000000;
            DataNascimento = DateTime.Now;
            segurancaSocial = "atraso";
        }

        /// <summary>
        /// Construtor parametrizado da classe Paciente
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="nus"></param>
        /// <param name="sangue"></param>
        public Paciente(string nome, DateTime dataNascimento, int nus, tipoSanguineo sangue,string segurancaSocial)
        {
            if(nome.Any(char.IsDigit))
            {
                throw new NomeInvalidoException();
            }
            Nome = nome;
            this.sangue = sangue;
            this.nus = nus;
            this.segurancaSocial = segurancaSocial;
            if (dataNascimento > DateTime.Now)
            {
                throw new DataFuturaException();
            }
            DataNascimento = dataNascimento;
        }

        #endregion

        /// <summary>
        /// Obtém ou define as caracteristicas do paciente
        /// </summary>
        #region PROPRIEDADES

        public int Nus
        {
            get { return nus; }
            set { nus = value; }
        }

        public tipoSanguineo Sangue
        {
            get { return sangue; }
            set { sangue = value; }
        }

        public string SegurancaSocial
        {
            get { return segurancaSocial; }
            set { segurancaSocial = value; }
        }

        #endregion

        #region OUTROS METODOS

        /// <summary>
        /// Método  para verificar se o NUS tem 9 algarismos
        /// </summary>
        /// <param name="nus"></param>
        /// <returns></returns>
        public bool VerificaNus(int nus)
        {
            int aux,count=0;
            while (nus != 0)
            {
                aux=nus / 10;
                nus = aux;
                count++;
            }
            return count == 9;
        }

        //public int CompareTo(Paciente p)
        //{
        //    if (p == null)
        //    {
        //        return 1; // um objeto nulo é "maior" que qualquer objeto não nulo
        //    }
        //    // Comparar NUS
        //    return Nus.CompareTo(p.Nus);
        //}

        /// <summary>
        /// Compara dois Objetos pelo seu Nus
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int CompareTo(Paciente p)
        {
            if (Nus > p.Nus)
            {
                return 1;
            }
            else if (Nus < p.Nus)
            {
                return -1;
            }
            return 0;
        }

        #endregion

        #region OVERRIDES

        /// <summary>
        /// Metodo para mostrar parametros do paciente
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("Nome paciente:{0} Idade:{1} TipoSangue:{2} NUS:{3} DataNascimento:{4}", Nome, Idade, Sangue, Nus, DataNascimento.ToShortDateString());
        }

        /// <summary>
        /// Verifica se o objeto Paciente é igual a outro objeto Paciente
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is Paciente)
            {
                Paciente p = (Paciente)obj;
                if (this==p)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region OPERADORES

        /// <summary>
        /// reesceita do operador de igualdade para comparar dois objetos do tipo paciente.
        /// </summary>
        public static bool operator ==(Paciente p1, Paciente p2)
        {
            if (ReferenceEquals(p1, null) && ReferenceEquals(p2, null)) return true;
            if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null)) return false;
            if ((p1.Nome == p2.Nome) && (p1.Idade == p2.Idade) && (p1.sangue == p2.sangue) && (p1.DataNascimento == p2.DataNascimento) && (p1.Nus == p2.Nus) && (p1.SegurancaSocial==p2.SegurancaSocial))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// reescrita do operador de desigualdade para comparar dois objetos do tipo paciente.
        /// </summary>
        public static bool operator !=(Paciente p1, Paciente p2)
        {
            if (p1 == p2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion

        #endregion

    }
}