using ArvoreBinariaCargos;

Tree<Person> tree = new Tree<Person>();
tree.Root = new Node<Person>()
{
	Data = new Person
	{
		Name = "Gabriel Ceron Bianchi",
		Role = "CEO"
	}
};

<<<<<<< HEAD
// Criou o nó raíz
tree.Root = new Node<string>(){Data = "Marcin Jamro"};


// Criou os três galhos: 50, 1, 150
tree.Root.Children = 
                new List<Node<string>>() 
                {
                    new Node<string>(){Data = "John Smith", Parent = tree.Root},
                    new Node<string>(){Data = "Mary Fox", Parent = tree.Root},
                    new Node<string>(){Data = "Lily Smith", Parent = tree.Root}

                };

// Criou os nós
Node<string> node12 = new Node<string>(){Data = "Chris Morris", Parent = tree.Root.Children[0]};
Node<string> node45 = new Node<string>(){Data = "Jimmy Stewart", Parent = node12};
Node<string> node21 = new Node<string>(){Data = "Andy Wood", Parent = node12};


// Atribuiu os filhos ao node 12
node12.Children!.Add(node45!);
node12.Children!.Add(node21!);

tree.Root.Children[0].Children?.Add(node12);

tree.PrintTree(tree.Root);
=======
tree.Root.Children = new List<Node<Person>>()
{
	new Node<Person>
	{
		Data = new Person
		{
			Name = "Thiago Cabeludo",
			Role = "Gerente de Desenvolvimento"
		}
	},
	new Node<Person>
	{
		Data = new Person
		{
			Name = "Vinizao",
			Role = "Gerente de Engenharia"
		}
	},
	new Node<Person>
	{
		Data = new Person
		{
			Name = "Marcola",
			Role = "Gerente de Segurança"
		}
	}
};
>>>>>>> 4bc12f437642a09048ea11894ee55e400c84c164
