#pragma checksum "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "322264785d05bee560feb2ffe1215eeaf1697cb2"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\storage\SDCS\PersonalProject\BlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\storage\SDCS\PersonalProject\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\storage\SDCS\PersonalProject\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\storage\SDCS\PersonalProject\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\storage\SDCS\PersonalProject\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\storage\SDCS\PersonalProject\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\storage\SDCS\PersonalProject\BlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\storage\SDCS\PersonalProject\BlazorServer\_Imports.razor"
using BlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\storage\SDCS\PersonalProject\BlazorServer\_Imports.razor"
using BlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\storage\SDCS\PersonalProject\BlazorServer\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
using BlazorServer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
using BlazorServer.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/query")]
    public partial class Query : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Query</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
                  newInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
                                           Search

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatAutocompleteList<string>>(6);
                __builder2.AddAttribute(7, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<string>>(
#nullable restore
#line 11 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
                                 t0

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "ShowClearButton", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
                                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Label", "Base Resource");
                __builder2.AddAttribute(10, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 11 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
                                                                                                              newInput.baseResource

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newInput.baseResource = __value, newInput.baseResource))));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatAutocompleteList<string>>(13);
                __builder2.AddAttribute(14, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<string>>(
#nullable restore
#line 12 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
                                 t1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ShowClearButton", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
                                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "Label", "T1 Resource");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 12 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
                                                                                                            newInput.t1Resource

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newInput.t1Resource = __value, newInput.t1Resource))));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatAutocompleteList<string>>(20);
                __builder2.AddAttribute(21, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<string>>(
#nullable restore
#line 13 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
                                 t2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ShowClearButton", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
                                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "Label", "T2 Resource");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 13 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
                                                                                                            newInput.t2Resource

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newInput.t2Resource = __value, newInput.t2Resource))));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatAutocompleteList<string>>(27);
                __builder2.AddAttribute(28, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<string>>(
#nullable restore
#line 14 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
                                 loc1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ShowClearButton", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "Label", "Location 1");
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 14 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
                                                                                                             newInput.location1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newInput.location1 = __value, newInput.location1))));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatAutocompleteList<string>>(34);
                __builder2.AddAttribute(35, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<string>>(
#nullable restore
#line 15 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
                                 loc2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ShowClearButton", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "Label", "Location 2");
                __builder2.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 15 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
                                                                                                             newInput.location2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newInput.location2 = __value, newInput.location2))));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n    ");
                __builder2.AddMarkupContent(41, "<button type=\"submit\">Search</button>\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(42, "\r\n\r\n");
            __builder.OpenElement(43, "table");
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 25 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
     foreach (var route in distancePair)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "        ");
            __builder.OpenElement(46, "tr");
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.OpenElement(48, "th");
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.AddContent(50, 
#nullable restore
#line 29 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
             route.Item1.Chain

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.OpenElement(53, "th");
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.AddContent(55, 
#nullable restore
#line 32 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
                 route.Item2.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(56, ";\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
#nullable restore
#line 35 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(60, "<h3>Inputs</h3>\r\n\r\n");
            __builder.AddMarkupContent(61, "<p>Base Resource</p>\r\n");
            __builder.OpenElement(62, "p");
            __builder.AddMarkupContent(63, "\r\n    ");
            __builder.AddContent(64, 
#nullable restore
#line 43 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
     newInput.baseResource

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(65, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
            __builder.AddMarkupContent(67, "<p>T1 Resource</p>\r\n");
            __builder.OpenElement(68, "p");
            __builder.AddMarkupContent(69, "\r\n    ");
            __builder.AddContent(70, 
#nullable restore
#line 47 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
     newInput.t1Resource

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(71, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
            __builder.AddMarkupContent(73, "<p>T2 Resource</p>\r\n");
            __builder.OpenElement(74, "p");
            __builder.AddMarkupContent(75, "\r\n    ");
            __builder.AddContent(76, 
#nullable restore
#line 51 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
     newInput.t2Resource

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(77, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
            __builder.AddMarkupContent(79, "<p>T1 Location</p>\r\n");
            __builder.OpenElement(80, "p");
            __builder.AddMarkupContent(81, "\r\n    ");
            __builder.AddContent(82, 
#nullable restore
#line 55 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
     newInput.location1

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(83, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n");
            __builder.AddMarkupContent(85, "<p>T2 Location</p>\r\n");
            __builder.OpenElement(86, "p");
            __builder.AddMarkupContent(87, "\r\n    ");
            __builder.AddContent(88, 
#nullable restore
#line 59 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
     newInput.location2

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(89, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n");
            __builder.AddMarkupContent(91, "<p>Command</p>\r\n");
            __builder.OpenElement(92, "p");
            __builder.AddMarkupContent(93, "\r\n    ");
            __builder.AddContent(94, 
#nullable restore
#line 63 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
     sqlCommand

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(95, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "D:\storage\SDCS\PersonalProject\BlazorServer\Pages\Query.razor"
       
    private List<QueryInputModel> initialInputs = new List<QueryInputModel>();
    public QueryInputModel newInput = new QueryInputModel();
    List<TradeRoute> queriedRoutes = new List<TradeRoute>();
    List<Tuple<TradeRoute, float>> distancePair=new List<Tuple<TradeRoute, float>>();
    public string sqlCommand;
    string[] t0;
    string[] t1;
    string[] t2;
    string[] loc1;
    string[] loc2;




    protected override async Task OnInitializedAsync()
    {
        t0 = await data.GetUniqueValues("item0", config.GetConnectionString("default"));
        t1 = await data.GetUniqueValues("item1", config.GetConnectionString("default"));
        t2 = await data.GetUniqueValues("item2", config.GetConnectionString("default"));
        loc1 = await data.GetUniqueValues("location0", config.GetConnectionString("default"));
        loc2 = await data.GetUniqueValues("location1", config.GetConnectionString("default"));
    }

    private async void Search()
    {
        Console.WriteLine("searching");
        string sql = "SELECT chainID from itemroutes where Location0 LIKE '%" + newInput.location1 + "%' AND Location1 LIKE '%" + newInput.location2 +
            "%' AND Item0 LIKE '%" + newInput.baseResource + "%' AND Item1 LIKE '%" + newInput.t1Resource + "%' AND Item2 LIKE '%" + newInput.t2Resource + "%'";
        sqlCommand = await data.GetChainID(sql, config.GetConnectionString("default"));
        queriedRoutes=await data.LoadChain(sqlCommand,config.GetConnectionString("default"));
        Console.WriteLine(queriedRoutes.Count);
        foreach(TradeRoute subroute in queriedRoutes)
        {
            var adder=await service.GetTotalDistance(subroute, config.GetConnectionString("locations"));
            distancePair.Add(adder);
        }
        //queriedRoutes = await data.LoadData<TradeRoute, dynamic>(sql, new { }, config.GetConnectionString("default"));
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServices service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDatabaseAccess data { get; set; }
    }
}
#pragma warning restore 1591
