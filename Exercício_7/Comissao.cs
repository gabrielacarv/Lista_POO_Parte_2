using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_7
{
    internal class Comissionado : Empregado
    {
        public double TotalVenda { get; set; }
        public double TaxaComissao { get; set; }  

        public override double Vencimento()
        {
            double remuneracao = TotalVenda * (TaxaComissao / 100);
            return remuneracao;
        }
    }
}
