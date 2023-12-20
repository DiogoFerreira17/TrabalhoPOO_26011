/*
 * TrabalhoPOO_26011
 * Nome:Diogo Alves Ferreira
 * Email:a26011@alunos.ipca.pt
 * Engenharia de Sistemas Informáticos
 * Escola Superior de Técnologia
 * 7-11-2023
 */

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// Externo
using Dados;
using ObjetosHospital;

namespace DadosTestes
{
    [TestClass]
    public class PacientesTestes
    {
        /// <summary>
        /// Teste para veririfcar se um paciente é inserido com sucesso
        /// </summary>
        [TestMethod]
        public void DeveInserirPacienteComSucesso()
        {
            Paciente paciente = new Paciente("Diogo", new DateTime(1974, 11, 12), 2034232345, tipoSanguineo.OPOSITIVO, "pago");

            bool resultado = Pacientes.InserirPaciente(paciente);

            Assert.IsTrue(resultado);
            Assert.IsTrue(Pacientes.listaPacientes.Contains(paciente));
        }

        /// <summary>
        /// Teste para verificar se um paciente é inserido duplicadamente
        /// </summary>
        [TestMethod]
        public void NaoDeveInserirPacienteDuplicado()
        {
            Paciente paciente = new Paciente("Diogo", new DateTime(1974, 11, 12), 2034232345, tipoSanguineo.OPOSITIVO, "pago");

            // Inserir o mesmo paciente duas vezes
            Pacientes.InserirPaciente(paciente);

            bool resultado = Pacientes.InserirPaciente(paciente);

            Assert.IsFalse(resultado);
            Assert.AreEqual(1, Pacientes.listaPacientes.Count); // A lista deve conter apenas uma instância do paciente
        }
    }
}
