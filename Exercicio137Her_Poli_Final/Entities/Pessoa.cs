using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio137Her_Poli_Final.Entities
{
    internal abstract class Pessoa
    {
        public string Name { get; set; }
        public double RendaAnual { get; set; }
                
        public Pessoa()
        {
        }

        public Pessoa(string name, double rendaAnual)
        {
            Name = name;
            RendaAnual = rendaAnual;
        }
        public abstract double Tax();
        
    }
}
