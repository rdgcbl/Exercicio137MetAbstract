using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio137Her_Poli_Final.Entities
{
    internal class PessoaFisica : Pessoa
    {
        public double GastosSaude { get; set; }
        public PessoaFisica()
        {
        }

        public PessoaFisica(double gastosSaude, string name, double rendaAnual)
            : base(name, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }

        public override double Tax()
        {
            if(RendaAnual >= 20000)
            {
                return RendaAnual * 0.25 - (GastosSaude * 0.50);
            }
            else
            {
                return RendaAnual * 0.15 - (GastosSaude * 0.50);
            }
            
        }
    }
}
