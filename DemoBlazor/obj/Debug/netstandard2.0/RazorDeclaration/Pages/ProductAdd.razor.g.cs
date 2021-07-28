#pragma checksum "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b5a5cc94cba6794da28c5412bd8811d45804e2e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DemoBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\_Imports.razor"
using DemoBlazor;

#line default
#line hidden
#line 7 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\_Imports.razor"
using DemoBlazor.Shared;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
using DemoBlazor.Models;

#line default
#line hidden
#line 3 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
using DemoBlazor.Services;

#line default
#line hidden
#line 6 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
using DemoBlazor.Utilities;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/productadd")]
    public class ProductAdd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 57 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
       

    Product product = new Product();
    Category[] categories;

    protected override async Task OnInitializedAsync()
    {
        categories = await CategoryService.GetCategories();
    }

    private void HandleSave()
    {
        ProductService.Add(product);
        Console.WriteLine("Ürün eklendi");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryService CategoryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591