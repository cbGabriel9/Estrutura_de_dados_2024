using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using RetirarSenhaPilha;

namespace RetirarSenhaPilha
{
    public class Pilha
    {
        int _counter = 0;

        public Details()
        {
            Name = name;
            Id = id;
        }

        public Details AddItem(string name)
        {
            Details product = new Details{
                Name = name,
                Id = ++_counter
            };

            return null;
        }

        public void StackAdd()
        {
            products.Push(1);
        }

        public void StackRemove()
        {
            products.Pop();
        }

        public void StackView()
        {
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
        }


}
}