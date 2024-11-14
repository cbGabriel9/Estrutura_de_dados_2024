using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtvBasicTree
{
    public class Tree<T>
    {
        public TreeNode<T> Root { get; set; }

        public void PrintTree(TreeNode<T> node, string indent = "")
        {
            if (node == null)
                return;

            Console.WriteLine(indent + node.Data);

            foreach (var child in node.Children)
            {
                PrintTree(child, indent + "  ");
            }
        }
    }

}