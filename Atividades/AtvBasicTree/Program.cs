using AtvBasicTree;

Tree<int> tree = new Tree<int>();
tree.Root = new TreeNode<int>() { Data = 100 };
tree.Root.Children = new List<TreeNode<int>>
{
    new TreeNode<int>() { Data = 50, Parent = tree.Root },
    new TreeNode<int>() { Data = 1, Parent = tree.Root },
    new TreeNode<int>() { Data = 150, Parent = tree.Root }
};
tree.Root.Children[2].Children = new List<TreeNode<int>>()
{
    new TreeNode<int>()
    { 
        Data = 30, 
        Parent = tree.Root.Children[2] 
    }
};

Tree<Person> company = new Tree<Person>();
company.Root = new TreeNode<Person>()
{
    Data = new Person(100, "Gabriel Gadeia", "CEO"),
    Parent = null
};
company.Root.Children = new List<TreeNode<Person>>()
{
    new TreeNode<Person>()
    {
        Data = new Person(1, "Thigas", "Head of Development"),
        Parent = company.Root
    },
    new TreeNode<Person>()
    {
        Data = new Person(50, "Igor Boxeador", "Head of Research"),
        Parent = company.Root
    },
    new TreeNode<Person>()
    {
        Data = new Person(150, "Vinizao Urso", "Head of Sales"),
        Parent = company.Root
    }
};
company.Root.Children[2].Children = new List<TreeNode<Person>>()
{
    new TreeNode<Person>()
    {
        Data = new Person(30, "Mayra Meiga", "Sales Specialist"),
        Parent = company.Root.Children[2]
    }
};

company.PrintTree(company.Root);