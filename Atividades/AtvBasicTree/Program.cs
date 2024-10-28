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