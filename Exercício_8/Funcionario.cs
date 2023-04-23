using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_8
{
    public class Funcionario
    {

        public string Nome;
        public string CPF;
        public DateTime DataNascimento;
        public string Cargo;
        public List<Dependente> Dependentes;

        public Funcionario(string nome, string cpf, DateTime dataNascimento, string cargo)
        {
            Nome = nome;
            CPF = cpf;
            DataNascimento = dataNascimento;
            Cargo = cargo;
            Dependentes = new List<Dependente>();
        }

        public void AdicionarDependente(Dependente dependente)
        {
            Dependentes.Add(dependente);
        }

        public void MostrarDependente()
        {
            Console.WriteLine();
            Console.WriteLine($"Dependente de {Nome}:");
            foreach (Dependente dependente in Dependentes)
            {
                Console.WriteLine($"- Nome: {dependente.Nome} | CPF: {dependente.CPF} | Data Nascimento: ({dependente.DataNascimento:d})");
            }
        }
    }
}
