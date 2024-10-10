using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste
{
    public class Métodos
    {
        static public void soma(int n1, int n2)
        {
            int soma = n1 + n2;

            System.Console.WriteLine("A soma de {0} e {1} é: {2}", n1,n2,soma);
        }
    }
}