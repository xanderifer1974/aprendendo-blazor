using BlazzorApp_Injecao_Dependencia.Servicos;
using Microsoft.AspNetCore.Components;

namespace BlazzorApp_Injecao_Dependencia.Pages
{
    public class CounterBase: ComponentBase
    {
        protected int currentCount = 0;

       [Inject] protected ServicoSingleton singleton { get; set; }
       [Inject] protected ServicoScoped scoped { get; set; }
       [Inject] protected ServicoTransient transient { get; set; }

        protected void IncrementCount()
        {
            currentCount++;
            singleton.Valor = currentCount;
            scoped.Valor = currentCount;
            transient.Valor = currentCount;
        }
    }
}
