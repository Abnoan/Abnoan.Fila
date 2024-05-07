using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Fila.Exercicios
{
    public class Ticket
    {
        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public string Prioridade { get; private set; }

        public Ticket(int id, string descricao, string prioridade)
        {
            Id = id;
            Descricao = descricao;
            Prioridade = prioridade;
        }
    }
}