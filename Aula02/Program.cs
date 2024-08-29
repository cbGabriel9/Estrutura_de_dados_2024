
using Aula02;

Person person = new Person();
Console.WriteLine(person.Name);

Person person1 = new Person("Maurício Gonzatto", 40);
Console.WriteLine(person1.Name);

Person person2 = new Person();
person2.Name = "Gabriel Ceron Bianchi";
person2.Age = 70;
Console.WriteLine(person2.Name);

Person person3 = new Person()
{
    Name = "Jordan da Silva",
    Age = 80
};
Console.WriteLine(person3.Name);