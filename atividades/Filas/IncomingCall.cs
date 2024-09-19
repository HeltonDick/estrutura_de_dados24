using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filas
{
    // Esta classe representa a fila de chamados em um CallCenter
    public class IncomingCall{
        // Istp se chama isnepd (pertence a ferramenta do vs)
        // Para automatizar a digitação
        // Informações do atendimento em si
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime CallTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Consultant { get; set; }
    }
}