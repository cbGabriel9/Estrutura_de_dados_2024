using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste
{
    public class Person
    {
        public string ?Name { get; set; }
        public int Age { get; set; }


        public void Talk()
        {
            System.Console.WriteLine($"Seu nome é: {Name}");
        }
    }
}