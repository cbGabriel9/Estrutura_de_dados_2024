// Uma fila é a estrutura de dados que pode ser aplicada para representar a fila de atendimento da cantina (Os primeiros que chegam, saem por primeiro). A função ENQUEUE é responsável por adicionar novos elementos à fila. A função DEQUEUE remove elementos. Desta forma, obedece o princípio do FIFO, First In, First Out -> Primeiro que entra, primeiro que sai.

using System.Net.Mail;
using Filas;

Random random = new Random();

// Gerando ID
CallCenter center = new();
center.Call(1234);
center.Call(1369);
center.Call(422);
center.Call(12);

while (center.AreWaitingCalls())
{
    Thread.Sleep(3000);
    IncomingCall call = center.Answer("Baianinho de Mauá");
    Console.WriteLine(@$"{DateTime.Now:HH:mm:ss} Chamado: #{call.Id} De: {call.ClientId} Atendido por: {call.Consultant}"
    );

    Thread.Sleep(random.Next(1000, 10000));
    center.End(call);
    Console.WriteLine(@$"Chamado: {call.Id}
                        Encerrado às: {call.EndTime}"
    );
}