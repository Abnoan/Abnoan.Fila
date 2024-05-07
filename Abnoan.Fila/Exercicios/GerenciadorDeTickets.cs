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
        private void Utilidade()
        {
            // Criar uma simulação de sistema de atendimento ao cliente onde os clientes são atendidos na ordem de chegada.
            Queue<string> filaAtendimento = new Queue<string>();
            filaAtendimento.Enqueue("Ana");
            filaAtendimento.Enqueue("João");
            Console.WriteLine(filaAtendimento.Dequeue() + " foi atendido.");

            // Implementar um sistema de gerenciamento de tarefas onde as tarefas devem ser executadas em uma sequência específica.

            Queue<string> filaTarefas = new Queue<string>();
            filaTarefas.Enqueue("Enviar email");
            filaTarefas.Enqueue("Preparar relatório");
            Console.WriteLine(filaTarefas.Dequeue() + " foi realizada.");

            // Desenvolva uma simulação de fila de atendimento em um banco, 
            // onde os clientes têm prioridades diferentes e podem chegar em momentos distintos.

            Queue<string> filaNormal = new Queue<string>();
            Queue<string> filaPrioritaria = new Queue<string>();
            filaPrioritaria.Enqueue("João");
            filaNormal.Enqueue("Ana");
            filaNormal.Enqueue("Luís");

            while (filaPrioritaria.Count > 0)
            {
                Console.WriteLine(filaPrioritaria.Dequeue() + " foi atendido.");
            }
            while (filaNormal.Count > 0)
            {
                Console.WriteLine(filaNormal.Dequeue() + " foi atendido.");
            }

            //Implementar um sistema de controle de processos de produção 
            //onde as máquinas executam tarefas em uma ordem específica, 
            //e novas tarefas são adicionadas dinamicamente.

            Queue<string> filaProducao = new Queue<string>();
            filaProducao.Enqueue("Cortar material");
            filaProducao.Enqueue("Montar peça");
            filaProducao.Enqueue("Inspeção de qualidade");

            Console.WriteLine("Próxima tarefa: " + filaProducao.Peek());
            while (filaProducao.Count > 0)
            {
                Console.WriteLine(filaProducao.Dequeue() + " completada.");
            }
        }
        #endregion
    }
}