#pragma checksum "C:\Treinamentos\Udemy\Blazor\19_Blazor_Tarefas_Ref_Componentes\Blazor_Tarefas\Blazor_Tarefas\Shared\Alerta.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ff5553812d7977baa529d9705b6f613c66871b2"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_Tarefas.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Treinamentos\Udemy\Blazor\19_Blazor_Tarefas_Ref_Componentes\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Treinamentos\Udemy\Blazor\19_Blazor_Tarefas_Ref_Componentes\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Treinamentos\Udemy\Blazor\19_Blazor_Tarefas_Ref_Componentes\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Treinamentos\Udemy\Blazor\19_Blazor_Tarefas_Ref_Componentes\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Treinamentos\Udemy\Blazor\19_Blazor_Tarefas_Ref_Componentes\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Treinamentos\Udemy\Blazor\19_Blazor_Tarefas_Ref_Componentes\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Blazor_Tarefas;

#line default
#line hidden
#line 7 "C:\Treinamentos\Udemy\Blazor\19_Blazor_Tarefas_Ref_Componentes\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Blazor_Tarefas.Shared;

#line default
#line hidden
#line 8 "C:\Treinamentos\Udemy\Blazor\19_Blazor_Tarefas_Ref_Componentes\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Blazor_Tarefas.Entidades;

#line default
#line hidden
#line 9 "C:\Treinamentos\Udemy\Blazor\19_Blazor_Tarefas_Ref_Componentes\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Blazor_Tarefas.Repositorios;

#line default
#line hidden
    public partial class Alerta : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n");
#line 2 "C:\Treinamentos\Udemy\Blazor\19_Blazor_Tarefas_Ref_Componentes\Blazor_Tarefas\Blazor_Tarefas\Shared\Alerta.razor"
     if(Conteudo1 == null)
    {

#line default
#line hidden
            __builder.AddContent(2, "        ");
            __builder.AddMarkupContent(3, "<span style=\"color:black\">Texto Padrão</span>\r\n");
#line 5 "C:\Treinamentos\Udemy\Blazor\19_Blazor_Tarefas_Ref_Componentes\Blazor_Tarefas\Blazor_Tarefas\Shared\Alerta.razor"
    }
    else
    {
        

#line default
#line hidden
#line 8 "C:\Treinamentos\Udemy\Blazor\19_Blazor_Tarefas_Ref_Componentes\Blazor_Tarefas\Blazor_Tarefas\Shared\Alerta.razor"
__builder.AddContent(4, Conteudo1);

#line default
#line hidden
#line 8 "C:\Treinamentos\Udemy\Blazor\19_Blazor_Tarefas_Ref_Componentes\Blazor_Tarefas\Blazor_Tarefas\Shared\Alerta.razor"
                  
    }

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddMarkupContent(7, "\r\n");
#line 12 "C:\Treinamentos\Udemy\Blazor\19_Blazor_Tarefas_Ref_Componentes\Blazor_Tarefas\Blazor_Tarefas\Shared\Alerta.razor"
     if (Conteudo2 == null)
    {

#line default
#line hidden
            __builder.AddContent(8, "        ");
            __builder.AddMarkupContent(9, "<span style=\"color:black\">Texto Padrão</span>\r\n");
#line 15 "C:\Treinamentos\Udemy\Blazor\19_Blazor_Tarefas_Ref_Componentes\Blazor_Tarefas\Blazor_Tarefas\Shared\Alerta.razor"
    }
    else
    {
        

#line default
#line hidden
#line 18 "C:\Treinamentos\Udemy\Blazor\19_Blazor_Tarefas_Ref_Componentes\Blazor_Tarefas\Blazor_Tarefas\Shared\Alerta.razor"
__builder.AddContent(10, Conteudo2);

#line default
#line hidden
#line 18 "C:\Treinamentos\Udemy\Blazor\19_Blazor_Tarefas_Ref_Componentes\Blazor_Tarefas\Blazor_Tarefas\Shared\Alerta.razor"
                  
    }

#line default
#line hidden
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 22 "C:\Treinamentos\Udemy\Blazor\19_Blazor_Tarefas_Ref_Componentes\Blazor_Tarefas\Blazor_Tarefas\Shared\Alerta.razor"
       
    [Parameter] public RenderFragment Conteudo1 { get; set; }
    [Parameter] public RenderFragment Conteudo2 { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
