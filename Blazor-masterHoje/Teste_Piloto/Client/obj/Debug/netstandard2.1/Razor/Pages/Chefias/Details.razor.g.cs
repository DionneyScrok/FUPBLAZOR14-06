#pragma checksum "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Chefias\Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "110911bea6729f28d680f02434d51231a95cfe77"
// <auto-generated/>
#pragma warning disable 1591
namespace Teste_Piloto.Client.Pages.Chefias
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\_Imports.razor"
using Teste_Piloto.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\_Imports.razor"
using Teste_Piloto.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\_Imports.razor"
using Faculdade_FUP_Project.Server.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\_Imports.razor"
using Teste_Piloto.Client.Repository;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chefias/details/{id:int}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Detalhes</h3>\n");
            __builder.OpenComponent<Teste_Piloto.Client.Pages.Chefias.PageDetails>(1);
            __builder.AddAttribute(2, "Chefia", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Faculdade_FUP_Project.Server.Models.Chefia>(
#nullable restore
#line 7 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Chefias\Details.razor"
                     Chefia

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ButtonText", "Voltar");
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 7 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Chefias\Details.razor"
                                                                 DetalhesChefias

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Chefias\Details.razor"
       
    private Chefia Chefia = new Chefia();
    [Parameter] public int id { get; set; }
    protected override async Task OnParametersSetAsync() // é chamado qd o roteamento passar o valor para a propriedade
    {
        Chefia = await http.GetFromJsonAsync<Chefia>($"api/chefias/{id}");
    }

    async Task DetalhesChefias()
    {
        await http.PutAsJsonAsync("api/chefias", Chefia);
        navigation.NavigateTo("chefias");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
