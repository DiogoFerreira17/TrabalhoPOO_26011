/*
 * TrabalhoPOO_26011
 * Nome:Diogo Alves Ferreira
 * Email:a26011@alunos.ipca.pt
 * Engenharia de Sistemas Informáticos
 * Escola Superior de Técnologia
 * 7-11-2023
 */

using System;

namespace Excecoes
{
    // Exceções para datas inválidas
    #region DATAS

    public class DataInvalidaException : ApplicationException
    {
        public DataInvalidaException()
        {
            throw new DataInvalidaException("Não é permitida uma data final anterior à data inicial.");
        }

        public DataInvalidaException(string g) : base(g) 
        {

        }

        public DataInvalidaException(string g, Exception e)
        {
            throw new DataInvalidaException(g + e.Message);
        }

    }

    // Exceção para data futura não permitida
    public class DataFuturaException : ApplicationException
    {
        public DataFuturaException()
        {
            throw new DataFuturaException("Não é permitida uma data futura.");
        }

        public DataFuturaException(string s) : base(s)
        {
            
        }

        public DataFuturaException(string s, Exception e) 
        {
            throw new DataFuturaException(s + e.Message);
        }
    }

    #endregion

    // Exceções para nomes inválidos
    #region NOMES

    public class NomeInvalidoException : ApplicationException
    {
        public NomeInvalidoException()
        {
            throw new NomeInvalidoException("Não são permitidos numeros no nome.");
        }

        public NomeInvalidoException(string g) : base(g)
        {

        }

        public NomeInvalidoException(string g, Exception e)
        {
            throw new NomeInvalidoException(g + e.Message);
        }

    }

    #endregion
}
