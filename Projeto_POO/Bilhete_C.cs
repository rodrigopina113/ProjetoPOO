using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_POO
{
    public class Bilhete_C : Bilhete
    {
        public Bilhete_C(double preco, double distancia, int nif) 
            : base(preco, distancia, nif)
        {
        }

        // Implementação do método abstrato para Bilhete_C
        public override double CalcularPreco(double distancia)
        {

            preco = distancia * 1 * 0.5;
            return preco;
        }
    }
}
