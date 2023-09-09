using Blazor_Tarefas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Tarefas.Repositorios
{
    public interface IRepositorio
    {
        List<Tarefa> ObterTarefas();
    }
}
