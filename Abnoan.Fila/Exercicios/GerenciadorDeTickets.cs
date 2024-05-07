using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Fila.Exercicios
{
    public class GerenciadorDeTickets
    {
        public Queue<Ticket> filaAlta = new Queue<Ticket>();
        public Queue<Ticket> filaMedia = new Queue<Ticket>();
        public Queue<Ticket> filaBaixa = new Queue<Ticket>();

        public void AdicionarTicket(Ticket ticket)
        {
            switch (ticket.Prioridade)
            {
                case "Alta":
                    filaAlta.Enqueue(ticket);
                    break;
                case "Media":
                    filaMedia.Enqueue(ticket);
                    break;
                case "Baixa":
                    filaBaixa.Enqueue(ticket);
                    break;
            }
        }

        public void ResolverTicket()
        {
            if (filaAlta.Count > 0)
            {
                var ticket = filaAlta.Dequeue();
                Console.WriteLine("Resolvendo Ticket Alta Prioridade: " + ticket.Descricao);
            }
            else if (filaMedia.Count > 0)
            {
                var ticket = filaMedia.Dequeue();
                Console.WriteLine("Resolvendo Ticket Média Prioridade: " + ticket.Descricao);
            }
            else if (filaBaixa.Count > 0)
            {
                var ticket = filaBaixa.Dequeue();
                Console.WriteLine("Resolvendo Ticket Baixa Prioridade: " + ticket.Descricao);
            }
            else
            {
                Console.WriteLine("Não há tickets para resolver.");
            }
        }

        public void ImprimirTickets()
        {
            Console.WriteLine("Tickets Alta: " + filaAlta.Count);
            Console.WriteLine("Tickets Média: " + filaMedia.Count);
            Console.WriteLine("Tickets Baixa: " + filaBaixa.Count);
        }

        #region Não Usado
        private void Utilidade(){
            
        }
        #endregion
    }
}