using Blazor_Tarefas.Entidades;
using System.Collections.Generic;

namespace Blazor_Tarefas.Pages
{
    public partial class Index
    {
        List<Tarefa> tarefas = new List<Tarefa>();

        protected override void OnInitialized()
        {
            tarefas = repositorio.ObterTarefas();
        }

        private List<Tarefa> GetTarefas()
        {
            return tarefas;
        }
    }
}
