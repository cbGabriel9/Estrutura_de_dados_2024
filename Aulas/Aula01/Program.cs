// Declarando variável

using Aula01;

const int DAYS_IN_WEEK = 7;

//Declarando variável 

int number = 0;

//Imprimindo String com variável

Console.WriteLine("Temos {0} dias na semana", DAYS_IN_WEEK);

//Imprimindo String concatenada

Console.WriteLine($"A semana tem {DAYS_IN_WEEK} dias."); 

//Criando uma variável para receber um método. Vai ter o mesmo nome do tipo abstrato (TipoEnum) por conta do método construtor. Toda classe tem o seu construtor padrão implícito sem argumento/parâmetros, sendo possível sobreescrever esse método especificando argumentos, porém, se o fizermos, perdemos o original já posto e precisaremos defini-lo explicitamente.
TipoEnum tipoEnum = new TipoEnum(); 

TipoEnum.Classes enumGuerreiro = tipoEnum.GetClassesEnum("guerreiro");

Console.WriteLine($"O enum de guerreiro é {tipoEnum.GetClassesEnum("guerreiro")}");