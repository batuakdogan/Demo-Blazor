#pragma checksum "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b5a5cc94cba6794da28c5412bd8811d45804e2e"
// <auto-generated/>
#pragma warning disable 1591
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
#line 8 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
 if (product != null)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "h3");
            __builder.AddContent(2, "ProductDetail for ");
            __builder.AddContent(3, 
#line 10 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
                           product.ProductName

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 11 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
                      product

#line default
#line hidden
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 11 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
                                               HandleSave

#line default
#line hidden
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group");
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "Placeholder", "Ürün adı");
                __builder2.AddAttribute(17, "Class", "form-control");
                __builder2.AddAttribute(18, "Id", "productName");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 15 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
                                                                                                  product.ProductName

#line default
#line hidden
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.ProductName = __value, product.ProductName))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => product.ProductName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n            ");
                __Blazor.DemoBlazor.Pages.ProductAdd.TypeInference.CreateValidationMessage_0(__builder2, 23, 24, 
#line 16 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
                                      ()=>product.ProductName

#line default
#line hidden
                );
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.AddMarkupContent(29, "\r\n            ");
                __Blazor.DemoBlazor.Pages.ProductAdd.TypeInference.CreateInputNumber_1(__builder2, 30, 31, "Fiyat", 32, "form-control", 33, "description", 34, 
#line 19 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
                                                                                                 product.UnitPrice

#line default
#line hidden
                , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.UnitPrice = __value, product.UnitPrice)), 36, () => product.UnitPrice);
                __builder2.AddMarkupContent(37, "\r\n            ");
                __Blazor.DemoBlazor.Pages.ProductAdd.TypeInference.CreateValidationMessage_2(__builder2, 38, 39, 
#line 20 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
                                      ()=>product.UnitPrice

#line default
#line hidden
                );
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n\r\n        ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group");
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(45);
                __builder2.AddAttribute(46, "Placeholder", "Ürün açıklaması");
                __builder2.AddAttribute(47, "Class", "form-control");
                __builder2.AddAttribute(48, "Id", "description");
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 24 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
                                                                                                             product.QuantityPerUnit

#line default
#line hidden
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.QuantityPerUnit = __value, product.QuantityPerUnit))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => product.QuantityPerUnit));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n            ");
                __Blazor.DemoBlazor.Pages.ProductAdd.TypeInference.CreateValidationMessage_3(__builder2, 53, 54, 
#line 25 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
                                      ()=>product.QuantityPerUnit

#line default
#line hidden
                );
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n\r\n        ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group");
                __builder2.AddMarkupContent(59, "\r\n");
#line 29 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
             if (categories != null)
            {

#line default
#line hidden
                __builder2.AddContent(60, "                ");
                __Blazor.DemoBlazor.Pages.ProductAdd.TypeInference.CreateInputSelectNumber_4(__builder2, 61, 62, "form-control", 63, "categoryId", 64, 
#line 31 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
                                                                                      product.CategoryId

#line default
#line hidden
                , 65, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.CategoryId = __value, product.CategoryId)), 66, () => product.CategoryId, 67, (__builder3) => {
                    __builder3.AddMarkupContent(68, "\r\n");
#line 32 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
                     foreach (var category in categories)
                            {

#line default
#line hidden
                    __builder3.AddContent(69, "                        ");
                    __builder3.OpenElement(70, "option");
                    __builder3.AddAttribute(71, "value", 
#line 34 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
                                       category.CategoryId

#line default
#line hidden
                    );
                    __builder3.AddContent(72, 
#line 34 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
                                                            category.CategoryName

#line default
#line hidden
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(73, "\r\n");
#line 35 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
                            }

#line default
#line hidden
                    __builder3.AddMarkupContent(74, "                    /**/\r\n                    /**/\r\n                    /**/\r\n                    /**/\r\n                    /**/\r\n                ");
                }
                );
                __builder2.AddMarkupContent(75, "\r\n");
#line 42 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
            }

#line default
#line hidden
                __builder2.AddMarkupContent(76, "\r\n            ");
                __Blazor.DemoBlazor.Pages.ProductAdd.TypeInference.CreateValidationMessage_5(__builder2, 77, 78, 
#line 44 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
                                      ()=>product.CategoryId

#line default
#line hidden
                );
                __builder2.AddMarkupContent(79, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n\r\n        ");
                __builder2.AddMarkupContent(81, "<button class=\"btn btn-primary\" type=\"submit\">Kaydet</button>\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(82, "\r\n");
#line 50 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
}
else
{

#line default
#line hidden
            __builder.AddContent(83, "    ");
            __builder.AddMarkupContent(84, "<h4>Geliyor...</h4>\r\n");
#line 54 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\ProductAdd.razor"
}

#line default
#line hidden
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
namespace __Blazor.DemoBlazor.Pages.ProductAdd
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Placeholder", __arg0);
        __builder.AddAttribute(__seq1, "Class", __arg1);
        __builder.AddAttribute(__seq2, "Id", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelectNumber_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::DemoBlazor.Utilities.InputSelectNumber<T>>(seq);
        __builder.AddAttribute(__seq0, "Class", __arg0);
        __builder.AddAttribute(__seq1, "Id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591