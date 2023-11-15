namespace TrabalhoPOO_26011
{
    /// <summary>
    /// Classe que gere um conjunto de Cirurgias
    /// </summary>
    public class Cirurgias
    {
        /// <summary>
        /// Campos privados para armazenar o estado das Cirurgias
        /// </summary>
        #region ATRIBUTOS

        const int MAXCIRURGIAS = 10;
        static Cirurgia[] cirurgias;
        static int numCirurgias;

        #endregion

        #region COMPORTAMENTOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrao da classe Cirurgias
        /// </summary>
        public Cirurgias()
        {
            numCirurgias = 0;
            if (cirurgias == null)
            {
                cirurgias = new Cirurgia[MAXCIRURGIAS];
            }
        }

        #endregion

        /// <summary>
        /// Obtém as caracteristicas das Cirurgias
        /// </summary>
        #region PROPRIEDADES

        /// <summary>
        /// Faz clone do array Cirurgias
        /// </summary>
        public static Cirurgia[] arrayCirurgias
        {
            get { return (Cirurgia[])cirurgias.Clone(); }
        }

        public static int NumCirurgias
        {
            get { return numCirurgias; }
        }

        #endregion

        #region MÉTODOS

        #endregion

        #endregion

    }
}
