using System.Collections;
using LivrariaListaGenerica;
 
List <Book> books = [];

books.Add(new Book (){
    Name = "Ladrão de Raios",
    Publisher = "Intrínseca",
    Author = "Rick Riordan",
    PagesNumber = 400,
});

books.Add(new Book (){
    Name = "Mar de Monstros",
    Publisher = "Intrínseca",
    Author = "Rick Riordan",
    PagesNumber = 304,
});

books.Add(new Book (){
    Name = "Maldição do Titã",
    Publisher = "Intrínseca",
    Author = "Rick Riordan",
    PagesNumber = 336,
});

books.Add(new Book (){
    Name = "A Batalha do Labirinto",
    Publisher = "Intrínseca",
    Author = "Rick Riordan",
    PagesNumber = 392,
});

books.Add(new Book (){
    Name = "O Último Olimpiano",
    Publisher = "Intrínseca",
    Author = "Rick Riordan",
    PagesNumber = 384,
});

int? maxpages = 0;
ArrayList longestBook = []; 

foreach (Book b in books)
 {
    Console.WriteLine($"Book: {b.Name}");
    Console.WriteLine($"Publisher: {b.Publisher}");
    Console.WriteLine($"Author: {b.Author}");
    Console.WriteLine($"Page's Number: {b.PagesNumber}\n");

    if (b.PagesNumber > maxpages)
    {
        maxpages = b.PagesNumber;
        longestBook.Insert(0, b.Name);
        longestBook.Insert(1, b.Publisher);
        longestBook.Insert(2, b.Author);
        longestBook.Insert(3, b.PagesNumber);
    }
 }

Console.WriteLine($"O livro com a maior quantidade de páginas é:\n Name: {longestBook[0]} \n Publisher: {longestBook[1]} \n Author: {longestBook[2]} \n Page's Number: {longestBook[3]}");