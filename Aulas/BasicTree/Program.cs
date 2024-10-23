﻿using BasicTree;

Tree<int> tree = new ();

// Criou o nó raíz
tree.Root = new Node<int>(){Data = 100};


// Criou os três galhos: 50, 1, 150
tree.Root.Children = 
                new List<Node<int>>() 
                {
                    new Node<int>(){Data = 50, Parent = tree.Root},
                    new Node<int>(){Data = 1, Parent = tree.Root},
                    new Node<int>(){Data = 150, Parent = tree.Root}

                };

// Criou os nós
Node<int> node12 = new Node<int>(){Data = 12, Parent = tree.Root.Children[0]};
Node<int> node45 = new Node<int>(){Data = 45, Parent = node12};
Node<int> node21 = new Node<int>(){Data = 21, Parent = node12};


// Atribuiu os filhos ao node 12
node12.Children!.Add(node45!);
node12.Children!.Add(node21!);

tree.Root.Children[0].Children?.Add(node12);

tree.PrintTree(tree.Root);