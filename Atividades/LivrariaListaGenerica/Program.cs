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

foreach (Book b in books)
 {
    Console.WriteLine($"Book: {b.Name}");
    Console.WriteLine($"Publisher: {b.Publisher}");
    Console.WriteLine($"Author: {b.Author}");
    Console.WriteLine($"Page's Number: {b.PagesNumber}\n");
 }


