using Blazor_tarefas.Models;
using System.Collections.Generic;

namespace Blazor_tarefas.Repositorios
{
    public interface IRepositorio
    {
        List<Tarefa> ObterTarefas();
    }
}
