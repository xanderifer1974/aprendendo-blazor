#pragma checksum "C:\Treinamentos\Udemy\Blazor\19_Blazor_Tarefas_Ref_Componentes\Blazor_Tarefas\Blazor_Tarefas\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd6d20d95fdaaf0db83a6a3154434357438fcf15"
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<global::Blazor_Tarefas.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<div class=\"top-row px-4\">\r\n        <a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\">About</a>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "content px-4");
            __builder.AddMarkupContent(12, "\r\n        ");
#line 13 "C:\Treinamentos\Udemy\Blazor\19_Blazor_Tarefas_Ref_Componentes\Blazor_Tarefas\Blazor_Tarefas\Shared\MainLayout.razor"
__builder.AddContent(13, Body);

#line default
#line hidden
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
