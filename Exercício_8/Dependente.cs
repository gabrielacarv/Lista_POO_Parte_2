using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_8
{
    public class Dependente
    {
        public string Nome;
        public string CPF;
        public DateTime DataNascimento;

        public Dependente(string nome, string cpf, DateTime dataNascimento)
        {
            Nome = nome;
            CPF = cpf;
            DataNascimento = dataNascimento;
        }
    }
}
