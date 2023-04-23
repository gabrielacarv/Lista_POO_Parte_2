using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_8
{
    internal class Controle
    {
        private List<Funcionario> funcionarios;

        public Controle()
        {
            funcionarios = new List<Funcionario>();
        }

        public void AdicionarFuncionario()
        {
            Console.Write("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o CPF do funcionário: ");
            string cpf = Console.ReadLine();

            Console.Write("Digite a data de nascimento do funcionário (dd/mm/aaaa): ");
            DateTime dataNascimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Digite o cargo do funcionário: ");
            string cargo = Console.ReadLine();

            Funcionario funcionario = new Funcionario(nome, cpf, dataNascimento, cargo);

            Console.Write("Digite o número de dependentes: ");
            int numDependentes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numDependentes; i++)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"Dados do dependente #{i}:");
                Console.Write("Nome: ");
                string nomeDependente = Console.ReadLine();

                Console.Write("CPF: ");
                string cpfDependente = Console.ReadLine();

                Console.Write("Data de nascimento (dd/mm/aaaa): ");
                DateTime dataNascimentoDependente = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                Dependente dependente = new Dependente(nomeDependente, cpfDependente, dataNascimentoDependente);
                funcionario.AdicionarDependente(dependente);
            }

            funcionarios.Add(funcionario);
        }

        public void MostrarFuncionarios()
        {
            Console.WriteLine();          
            foreach (Funcionario funcionario in funcionarios)
            {
                Console.WriteLine("Funcionário:");
                Console.WriteLine($"- Nome: {funcionario.Nome} | CPF: {funcionario.CPF} | Data Nascimento: ({funcionario.DataNascimento:d}) | Cargo: {funcionario.Cargo} ");
                funcionario.MostrarDependente();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}