using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Filas
{
    public class CallCenter
    {
        private int _counter = 0;
        public Stack<IncomingCall>? Calls { get; set; }
        public CallCenter()
        {
            Calls = [];
        }

        // Método para abertura de chamados
        public void Call(int clientId)
        {
            IncomingCall call = new IncomingCall()
            {
                Id = ++_counter,
                ClientId = clientId,
                CallTime = DateTime.Now
            };

            Calls!.Push(call);
        }


        public IncomingCall Answer(string consultant)
        {
            // Validação: Verificar se tem atendimentos na fila
            if (Calls!.Count > 0)
            {
                IncomingCall call = Calls.Pop();
                call.Consultant = consultant;
                call.StartTime = DateTime.Now;

                return call;
            }

            // Aqui estou esclarecendo que o null vai ser nulo
            return null!;
        }

        public void End(IncomingCall call)
        {
            call.EndTime = DateTime.Now;
        }

        public bool AreWaitingCalls()
        {
            return (Calls!.Count > 0);
        }
    };
}