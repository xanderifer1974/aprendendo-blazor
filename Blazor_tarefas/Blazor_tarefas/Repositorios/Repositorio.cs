using Blazor_tarefas.Models;
using System;
using System.Collections.Generic;

namespace Blazor_tarefas.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Tarefa> ObterTarefas()
        {
            return new List<Tarefa>()
           {
               new Tarefa()
               {
                   Id = Guid.NewGuid(),
                   Descricao = "Estudar Inglês",
                   Concluida = false,
                   DataCriacao = Convert.ToDateTime("2023-09-05")
               },
                new Tarefa()
               {
                   Id = Guid.NewGuid(),
                   Descricao = "Estudar .Net Core",
                   Concluida = false,
                   DataCriacao = Convert.ToDateTime("2023-09-04")
               },
                 new Tarefa()
               {
                   Id = Guid.NewGuid(),
                   Descricao = "Estudar Espanhol",
                   Concluida = false,
                   DataCriacao = Convert.ToDateTime("2023-09-03")
               },
                  new Tarefa()
               {
                   Id = Guid.NewGuid(),
                   Descricao = "Estudar Trilha de Arquitetura",
                   Concluida = false,
                   DataCriacao = Convert.ToDateTime("2023-09-02")
               },
                   new Tarefa()
               {
                   Id = Guid.NewGuid(),
                   Descricao = "Estudar Blazzor",
                   Concluida = false,
                   DataCriacao = Convert.ToDateTime("2023-09-01")
               },
                        new Tarefa()
               {
                   Id = Guid.NewGuid(),
                   Descricao = "Estudar SalesForce",
                   Concluida = false,
                   DataCriacao = Convert.ToDateTime("2023-08-31")
               }
           };
        }
    }
}
