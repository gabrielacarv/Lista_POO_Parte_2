using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controle controle = new Controle();

            Console.Write("Digite o número de funcionários: ");
            int numFuncionarios = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numFuncionarios; i++)
            {
                Console.WriteLine($"Dados do funcionário #{i}:");
                controle.AdicionarFuncionario();
                Console.WriteLine();
            }

            Console.Clear();
            controle.MostrarFuncionarios();

            Console.ReadLine();
        }
    }
}
