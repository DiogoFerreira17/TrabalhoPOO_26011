
// Externo
using ObjetosHospital;
using Dados;

namespace Regras
{
    public class RegrasHospital
    {
        public static bool InserirPaciente(Paciente p)
        {
            if (p.Idade > 0)
            {
                Pacientes.InserirPaciente(p);
                return true;
            }
            return false;
        }
    }
}
