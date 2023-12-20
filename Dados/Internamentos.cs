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
    /// Classe que gere um conjunto de Internamentos
    /// </summary>
    public class Internamentos
    {
        /// <summary>
        /// Campos privados para armazenar o estado dos Internamentos
        /// </summary>
        #region ATRIBUTOS

        static List<Internamento> internamentos;

        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrao da classe Internamentos
        /// </summary>
        static Internamentos()
        {
            if (internamentos == null)
            {   
                internamentos = new List<Internamento>();
            }
        }

        #endregion

        /// <summary>
        /// Obtém as caracteristicas dos Internamentos
        /// </summary>
        #region PROPRIEDADES

        /// <summary>
        /// Retorna a Lista
        /// </summary>
        public static List<Internamento> ListaInternamentos
        {
            get { return new List<Internamento>(internamentos); }
        }

        #endregion

        #region OUTROS MÉTODOS

        /// <summary>
        /// Metodo para inserir um internamento na Lista
        /// </summary>
        /// <param name="I"></param>
        /// <returns></returns>
        public static bool InserirInternamento(Internamento I)
        {
            if (I != null && !internamentos.Contains(I))
            {
                if (I.DataInicio > I.DataFim)
                {
                    throw new Exception();
                }
                internamentos.Add(I);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Metodo para remover um internamento da Lista
        /// </summary>
        /// <param name="I"></param>
        /// <returns></returns>
        public static bool RemoverInternametno(Internamento I)
        {
            if (I != null && internamentos.Contains(I))
            {
                internamentos.Add(I);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Calcula os dias que algum paciente esteve internado
        /// </summary>
        /// <param name="nus"></param>
        /// <param name="dataInicio"></param>
        /// <param name="dataFim"></param>
        /// <returns></returns>
        public static int DiasInternamentoPaciente(int nus,DateTime diaInternamento)
        {
            foreach(Internamento i in internamentos)
            {
                if (i.Nus == nus && i.DataInicio == diaInternamento)
                {
                    TimeSpan diferenca = i.DataFim - i.DataInicio; // Calcula a diferença em dias entre as duas datas
                    int diasInternamento = diferenca.Days;

                    return diasInternamento;
                }
            }
            return 0;
        }
        /// <summary>
        /// Método para calcular o custo 
        /// </summary>
        /// <param name="nus"></param>
        /// <returns></returns>
        public static double CalculaCustoInternamento(int nus,DateTime diaInternamento)
        {
            double precoDia = 1.50; // preço aleatório por cada dia internado
            foreach(Internamento i in internamentos)
            {
                if (i.Nus == nus && i.DataInicio==diaInternamento)
                {  
                    i.PrecoInternamento = DiasInternamentoPaciente(nus,diaInternamento) * precoDia;
                    return i.PrecoInternamento; // apenas para teste, a função poderia ser void )
                }
            }
            return 0;
        }

        /// <summary>
        /// Método para retornar a Lista de Internamentos
        /// </summary>
        /// <returns></returns>
        public static List<Internamento> TodosInternamentos()
        {
            return ListaInternamentos;
        }

        #endregion

        #endregion

    }
}
