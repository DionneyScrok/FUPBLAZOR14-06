#pragma checksum "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bf0fe71641025a2afd43b37b2e763a3025d02e0"
// <auto-generated/>
#pragma warning disable 1591
namespace Teste_Piloto.Client.Pages.Funcionarios
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
#line 11 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\_Imports.razor"
using Teste_Piloto.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\Index.razor"
using Faculdade_FUP_Project.Server.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Funcionarios")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\Index.razor"
 if (funcionarios == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "Carregando!!!");
#nullable restore
#line 7 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\Index.razor"
                              
}
else if (funcionarios.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<h3>Ninguem cadastrado.   </h3>\r\n    ");
            __builder.AddMarkupContent(3, "<div>\r\n        <a href=\"funcionarios/criar\" class=\"btn btn-sucess\" value=\"Criar\">Criar</a>\r\n    </div>\r\n");
#nullable restore
#line 15 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.AddMarkupContent(5, "<div>\r\n        <a href=\"funcionarios/criar\" class=\"btn btn-sucess\" value=\"Criar\">Criar</a>\r\n    </div>\r\n");
            __builder.AddContent(6, "    ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.AddMarkupContent(10, @"<thead>
            <tr>                
                <th>Nome</th>               
                <th>Data Nascimento</th>
                <th>Data Contratação</th>               
                <th>Genero</th>
                <th>Salario</th>              
                <th>Nome Chefe</th>

            </tr>
        </thead>
        ");
            __builder.OpenElement(11, "tbody");
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 35 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\Index.razor"
             foreach (var funcionario in funcionarios)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "                ");
            __builder.OpenElement(14, "tr");
            __builder.AddMarkupContent(15, "              \r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 38 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\Index.razor"
                         funcionario.NomeFuncionario

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "               \r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 39 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\Index.razor"
                         funcionario.Datanascimento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 40 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\Index.razor"
                         funcionario.DataContratacao

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "                   \r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 41 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\Index.razor"
                         funcionario.Genero

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 42 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\Index.razor"
                         funcionario.SalarioFuncionario

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "                  \r\n                    ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 43 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\Index.razor"
                         funcionario.NomeChefe

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n                    ");
            __builder.OpenElement(34, "td");
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.OpenElement(36, "a");
            __builder.AddAttribute(37, "class", "btn btn-sucess");
            __builder.AddAttribute(38, "href", "funcionarios/edit/" + (
#nullable restore
#line 46 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\Index.razor"
                                                                           funcionario.FuncionarioId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "td");
            __builder.AddMarkupContent(43, "\r\n                        ");
            __builder.OpenElement(44, "a");
            __builder.AddAttribute(45, "class", "btn btn-sucess");
            __builder.AddAttribute(46, "href", "funcionarios/details/" + (
#nullable restore
#line 49 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\Index.razor"
                                                                              funcionario.FuncionarioId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(47, "Detalhes");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "td");
            __builder.AddMarkupContent(51, "\r\n                        ");
            __builder.OpenElement(52, "button");
            __builder.AddAttribute(53, "class", "=");
            __builder.AddAttribute(54, "btn", true);
            __builder.AddAttribute(55, "btn-danger", true);
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\Index.razor"
                                                                     () => ExcluirFuncionario(funcionario.FuncionarioId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(57, " Delete ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n");
#nullable restore
#line 55 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(61, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
#nullable restore
#line 58 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\Index.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\Index.razor"
       
    public List<Funcionario> funcionarios;
    protected override async Task OnInitializedAsync()
    {
        await LoadFuncionarios();
    }
    async Task LoadFuncionarios()
    {
        funcionarios = await http.GetFromJsonAsync<List<Funcionario>>("api/funcionarios");
    }
    async Task ExcluirFuncionario(int id)
    {
        await http.DeleteAsync($"api/funcionarios/{id}");
        await LoadFuncionarios();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591