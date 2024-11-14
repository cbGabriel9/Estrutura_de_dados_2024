using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtvBasicTree
{
    public class Tree<T>
    {
        public TreeNode<T> Root { get; set; }

        public void PrintTree(TreeNode<T> node)
        {
            System.Console.WriteLine($"Level: {node.GetHeight()}");
            System.Console.WriteLine($"Node: {node.Data}");
            System.Console.WriteLine();

            if(node.Children!.Count() > 0)
            {
                foreach(var i in node.Children!)
                {
                    PrintTree(i);               
                     }
            }
        }
    }
}