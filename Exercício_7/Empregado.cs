﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_7
{
    abstract class Empregado
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }

        public abstract double Vencimento();
    }
}
