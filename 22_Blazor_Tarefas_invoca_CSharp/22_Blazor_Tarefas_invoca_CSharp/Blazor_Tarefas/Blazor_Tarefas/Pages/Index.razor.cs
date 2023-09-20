using Blazor_Tarefas.Entidades;
using Blazor_Tarefas.Repositorios;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;

namespace Blazor_Tarefas.Pages
{
    public partial class Index
    {
        [Inject]
        protected IRepositorio repositorio {get; set;}
        [Inject]
        protected IJSRuntime js { get; set;}

        private List<Tarefa> tarefas = new List<Tarefa>();

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
