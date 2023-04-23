using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_7
{
    internal class Menu
    {
        public void info()
        {

            Console.WriteLine("================ CONSULTA DE SALÁRIO ================");
            Console.WriteLine("Preencha com a suas informações:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Sobrenome: ");
            string sobrenome = Console.ReadLine();
            Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("Qual o seu tipo de remuneração?");
            Console.WriteLine("1  -  Salário fixo");
            Console.WriteLine("2  -  Por Comissão");
            Console.WriteLine("3  -  Por Horas trabalhadas");
            int opcaoTipoSalario = int.Parse(Console.ReadLine());

            Empregado empregado = null;

            switch (opcaoTipoSalario)
            {
                    case 1:
                    Console.Write("Digite o valor da sua remuneração: ");
                    double salario = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    empregado = new Assalariado
                    {
                        Nome = nome,
                        Sobrenome = sobrenome,
                        CPF = cpf,
                        Salario = salario
                    };
                    break;

                    case 2:
                    Console.WriteLine("Digite o valor ganhador por hora trabalhada: ");
                    double precoHora = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a quantidades de total mensal de horas trabalhas: ");
                    double horasTrabalhadas = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    empregado = new Horista
                    {
                        Nome = nome,
                        Sobrenome = sobrenome,
                        CPF = cpf,
                        PrecoHora = precoHora,
                        HorasTrabalhadas = horasTrabalhadas
                    };
                    break;

                    case 3:
                    Console.WriteLine("Digite o valor total de vendas mensal: ");
                    double totalVenda = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a taxa de comissão (%): ");
                    double taxaComissao = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    empregado = new Comissionado
                    {
                        Nome = nome,
                        Sobrenome = sobrenome,
                        CPF = cpf,
                        TotalVenda = totalVenda,
                        TaxaComissao = taxaComissao
                    };
                    break;

                default:
                    Console.WriteLine("Opção inválida, tente novamente!");
                    break;
                  
            }

            Console.WriteLine("Nome: " + empregado.Nome);
            Console.WriteLine("Sobrenome: " + empregado.Sobrenome);
            Console.WriteLine("CPF: " + empregado.CPF);
            Console.WriteLine("Salário: " + empregado.Vencimento());
        }

    }
}
