using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_7
{
    internal class Horista : Empregado
    {
        public double PrecoHora { get; set; }

        public double HorasTrabalhadas { get; set; } 

        public override double Vencimento()
        {
            double PrecoTotalHoras = HorasTrabalhadas * PrecoHora;
            return PrecoTotalHoras;
        }
    }
}
