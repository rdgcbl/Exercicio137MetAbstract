using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio137Her_Poli_Final.Entities
{
    internal class PessoaJuridica : Pessoa
    {
        public int NumeroFunc { get; set; }
        public PessoaJuridica()
        {
        }
        public PessoaJuridica(int numeroFunc, string name, double rendaAnual)
            : base(name, rendaAnual)
        {
            NumeroFunc = numeroFunc;
        }

        public override double Tax()
        {
            if(NumeroFunc > 10)
            {
                return RendaAnual * 0.14;
            }
            else
            {
                return RendaAnual * 0.16;
            }
            
        }
    }
}
