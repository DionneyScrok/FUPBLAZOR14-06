#pragma checksum "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36c680864981a1494c3fde4f11401f8b5ab1a6fd"
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
    public partial class PageFuncionario : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<br>\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 3 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                  Funcionario

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                                 OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group");
                __builder2.AddMarkupContent(8, "\n        ");
                __builder2.AddMarkupContent(9, "<label>Nome</label>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                 Funcionario.NomeFuncionario

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Funcionario.NomeFuncionario = __value, Funcionario.NomeFuncionario))));
                __builder2.AddAttribute(13, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Funcionario.NomeFuncionario));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\n    ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-group");
                __builder2.AddMarkupContent(18, "\n        ");
                __builder2.AddMarkupContent(19, "<label>RG</label>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                 Funcionario.Rg

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Funcionario.Rg = __value, Funcionario.Rg))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Funcionario.Rg));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\n    ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group");
                __builder2.AddMarkupContent(28, "\n        ");
                __builder2.AddMarkupContent(29, "<label>CPF</label>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                 Funcionario.Cpf

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Funcionario.Cpf = __value, Funcionario.Cpf))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Funcionario.Cpf));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\n    ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group");
                __builder2.AddMarkupContent(38, "\n        ");
                __builder2.AddMarkupContent(39, "<label>Data Nascimento</label>\n        ");
                __Blazor.Teste_Piloto.Client.Pages.Funcionarios.PageFuncionario.TypeInference.CreateInputDate_0(__builder2, 40, 41, 
#nullable restore
#line 18 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                 Funcionario.Datanascimento

#line default
#line hidden
#nullable disable
                , 42, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Funcionario.Datanascimento = __value, Funcionario.Datanascimento)), 43, () => Funcionario.Datanascimento);
                __builder2.AddMarkupContent(44, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\n    ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "form-group");
                __builder2.AddMarkupContent(48, "\n        ");
                __builder2.AddMarkupContent(49, "<label>Data Contratação</label>\n        ");
                __Blazor.Teste_Piloto.Client.Pages.Funcionarios.PageFuncionario.TypeInference.CreateInputDate_1(__builder2, 50, 51, 
#nullable restore
#line 22 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                 Funcionario.DataContratacao

#line default
#line hidden
#nullable disable
                , 52, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Funcionario.DataContratacao = __value, Funcionario.DataContratacao)), 53, () => Funcionario.DataContratacao);
                __builder2.AddMarkupContent(54, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\n    ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group");
                __builder2.AddMarkupContent(58, "\n        ");
                __builder2.AddMarkupContent(59, "<label>Data Demissão</label>\n        ");
                __Blazor.Teste_Piloto.Client.Pages.Funcionarios.PageFuncionario.TypeInference.CreateInputDate_2(__builder2, 60, 61, 
#nullable restore
#line 26 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                 Funcionario.DataDemissao

#line default
#line hidden
#nullable disable
                , 62, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Funcionario.DataDemissao = __value, Funcionario.DataDemissao)), 63, () => Funcionario.DataDemissao);
                __builder2.AddMarkupContent(64, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\n    ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "form-group");
                __builder2.AddMarkupContent(68, "\n        ");
                __builder2.AddMarkupContent(69, "<label>Gênero</label>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(70);
                __builder2.AddAttribute(71, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                 Funcionario.Genero

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Funcionario.Genero = __value, Funcionario.Genero))));
                __builder2.AddAttribute(73, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Funcionario.Genero));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\n    ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "form-group");
                __builder2.AddMarkupContent(78, "\n        ");
                __builder2.AddMarkupContent(79, "<label>Salário</label>\n        ");
                __Blazor.Teste_Piloto.Client.Pages.Funcionarios.PageFuncionario.TypeInference.CreateInputNumber_3(__builder2, 80, 81, 
#nullable restore
#line 34 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                   Funcionario.SalarioFuncionario

#line default
#line hidden
#nullable disable
                , 82, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Funcionario.SalarioFuncionario = __value, Funcionario.SalarioFuncionario)), 83, () => Funcionario.SalarioFuncionario);
                __builder2.AddMarkupContent(84, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\n    ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "form-group");
                __builder2.AddMarkupContent(88, "\n        ");
                __builder2.AddMarkupContent(89, "<label>Email</label>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(90);
                __builder2.AddAttribute(91, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                 Funcionario.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(92, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Funcionario.Email = __value, Funcionario.Email))));
                __builder2.AddAttribute(93, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Funcionario.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(94, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\n    ");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "form-group");
                __builder2.AddMarkupContent(98, "\n        ");
                __builder2.AddMarkupContent(99, "<label>Telefone</label>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(100);
                __builder2.AddAttribute(101, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                 Funcionario.Telefone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(102, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Funcionario.Telefone = __value, Funcionario.Telefone))));
                __builder2.AddAttribute(103, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Funcionario.Telefone));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(104, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\n   \n\n    ");
                __builder2.OpenElement(106, "div");
                __builder2.AddAttribute(107, "class", "form-group");
                __builder2.AddMarkupContent(108, "\n        ");
                __builder2.AddMarkupContent(109, "<label>Nome Chefe</label>\n        ");
                __Blazor.Teste_Piloto.Client.Pages.Funcionarios.PageFuncionario.TypeInference.CreateInputSelect_4(__builder2, 110, 111, "form-control", 112, 
#nullable restore
#line 48 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                   Funcionario.NomeChefe

#line default
#line hidden
#nullable disable
                , 113, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Funcionario.NomeChefe = __value, Funcionario.NomeChefe)), 114, () => Funcionario.NomeChefe, 115, (__builder3) => {
                    __builder3.AddMarkupContent(116, "\n");
#nullable restore
#line 49 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
             if (chefias != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                 foreach (var chefia in chefias)
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(117, "                    ");
                    __builder3.OpenElement(118, "option");
                    __builder3.AddAttribute(119, "value", 
#nullable restore
#line 53 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                    chefia.NomeChefia

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(120, 
#nullable restore
#line 53 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                                        chefia.NomeChefia

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(121, "\n");
#nullable restore
#line 54 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                 
            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(122, "        ");
                }
                );
                __builder2.AddMarkupContent(123, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\n\n    ");
                __builder2.OpenElement(125, "button");
                __builder2.AddAttribute(126, "type", "submit");
                __builder2.AddAttribute(127, "class", "btn btn-primary");
                __builder2.AddAttribute(128, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                                            OnValidSubmit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(129, 
#nullable restore
#line 69 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
                                                                            ButtonText

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\n\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Funcionarios\PageFuncionario.razor"
 
    public List<Chefia> chefias { get; set; }
    [Parameter] public Funcionario Funcionario { get; set; }
    [Parameter] public string ButtonText { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }
    protected override async Task OnInitializedAsync()
    {
        await LoadChefias();
    }
    async Task LoadChefias()
    {
        chefias = await http.GetFromJsonAsync<List<Chefia>>("api/chefias");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.Teste_Piloto.Client.Pages.Funcionarios.PageFuncionario
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
