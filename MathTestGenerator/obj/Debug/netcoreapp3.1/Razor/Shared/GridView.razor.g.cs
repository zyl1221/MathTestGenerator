#pragma checksum "C:\GitHub\MathTestGenerator\MathTestGenerator\Shared\GridView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0a8f553373537c645109fa1c5e2f00446a28fa7"
// <auto-generated/>
#pragma warning disable 1591
namespace MathTestGenerator.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\GitHub\MathTestGenerator\MathTestGenerator\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\GitHub\MathTestGenerator\MathTestGenerator\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\GitHub\MathTestGenerator\MathTestGenerator\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\GitHub\MathTestGenerator\MathTestGenerator\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\GitHub\MathTestGenerator\MathTestGenerator\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\GitHub\MathTestGenerator\MathTestGenerator\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\GitHub\MathTestGenerator\MathTestGenerator\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\GitHub\MathTestGenerator\MathTestGenerator\_Imports.razor"
using MathTestGenerator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\GitHub\MathTestGenerator\MathTestGenerator\_Imports.razor"
using MathTestGenerator.Shared;

#line default
#line hidden
#nullable disable
    public partial class GridView<TableItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-striped");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "thead");
            __builder.AddAttribute(4, "class", "thead-dark");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "tr");
            __builder.AddContent(7, 
#nullable restore
#line 4 "C:\GitHub\MathTestGenerator\MathTestGenerator\Shared\GridView.razor"
             GridHeader

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "tbody");
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 7 "C:\GitHub\MathTestGenerator\MathTestGenerator\Shared\GridView.razor"
         foreach (var item in Items)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "            ");
            __builder.OpenElement(13, "tr");
            __builder.AddContent(14, 
#nullable restore
#line 9 "C:\GitHub\MathTestGenerator\MathTestGenerator\Shared\GridView.razor"
                 GridRow(item)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 10 "C:\GitHub\MathTestGenerator\MathTestGenerator\Shared\GridView.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "pagination");
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "disabled", 
#nullable restore
#line 15 "C:\GitHub\MathTestGenerator\MathTestGenerator\Shared\GridView.razor"
                        currentPage == 1

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "class", "btn pagebutton btn-secondary");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\GitHub\MathTestGenerator\MathTestGenerator\Shared\GridView.razor"
                                                                                          GoBack

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Previous");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "span");
            __builder.AddAttribute(29, "class", "pagebutton btn btn-link disabled");
            __builder.AddContent(30, "Page ");
            __builder.AddContent(31, 
#nullable restore
#line 16 "C:\GitHub\MathTestGenerator\MathTestGenerator\Shared\GridView.razor"
                                                         currentPage

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(32, " of ");
            __builder.AddContent(33, 
#nullable restore
#line 16 "C:\GitHub\MathTestGenerator\MathTestGenerator\Shared\GridView.razor"
                                                                         numberOfPages

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "disabled", 
#nullable restore
#line 17 "C:\GitHub\MathTestGenerator\MathTestGenerator\Shared\GridView.razor"
                        currentPage == numberOfPages

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(37, "class", "btn pagebutton btn-secondary");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\GitHub\MathTestGenerator\MathTestGenerator\Shared\GridView.razor"
                                                                                                     GoNext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Next");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\GitHub\MathTestGenerator\MathTestGenerator\Shared\GridView.razor"
 
    [Parameter]
    public RenderFragment GridHeader { get; set; }
    [Parameter]
    public RenderFragment<TableItem> GridRow { get; set; }
    [Parameter]
    public IEnumerable<TableItem> AllItems { get; set; }
    [Parameter]
    public int PageSize { get; set; }

    IEnumerable<TableItem> Items { get; set; }
    int currentPage = 1;
    int numberOfPages = 0;


    protected override void OnParametersSet()
    {
        numberOfPages = (int)Math.Ceiling(AllItems.Count() / (decimal)PageSize);
        if (numberOfPages == 0)
            numberOfPages++;

        UpdateList(1);
    }

    public void GoBack()
    {
        UpdateList(currentPage - 1);
    }

    public void GoNext()
    {
        UpdateList(currentPage + 1);
    }

    private void UpdateList(int currentPage)
    {
        Items = AllItems.Skip(PageSize * (currentPage - 1)).Take(PageSize);
        this.currentPage = currentPage;
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
