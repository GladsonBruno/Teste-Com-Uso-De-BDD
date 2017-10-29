using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeDesconto
{
    public static class CalculorDeDesconto
    {
        public static double calcularDesconto(double preco, double desconto)
        {
            return preco - (preco / 100 * desconto);
        }
    }
}
