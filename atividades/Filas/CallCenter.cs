using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Filas
{
    public class CallCenter{
        // Para variaveis ou atributos privados utilizamos o _snake_case
        private int _counter = 0;
        public Queue<IncomingCall>? calls { get; set; }
        public CallCenter() {
            calls = new Queue<IncomingCall>();
        }

        // Metodo para abertura de chamados
        public void Call(int clientId) {
            
            calls!.Enqueue(
                new IncomingCall() {
                    Id = ++_counter,
                    ClientId = clientId,
                    CallTime = DateTime.Now
                }
            );
        }

        public IncomingCall Answer(string consultant) {
            // Validaçã:  verificar se tem atendimentos na fila
            if (calls!.Count > 0) {
                IncomingCall call = calls.Dequeue();
                call.Consultant = consultant;
                call.StartTime = DateTime.Now;

                return call;
            }

            return null!;
        }

        public void End(IncomingCall call) {
            call.EndTime = DateTime.Now;
        }

        public bool AreWaitingCalls() {
            return calls!.Count > 0;
        }
    }
}