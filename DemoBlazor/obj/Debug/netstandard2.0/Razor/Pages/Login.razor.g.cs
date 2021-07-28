#pragma checksum "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7e1252def975bdff3b31dcf5d3b63379e368896"
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
#line 2 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\Login.razor"
using Blazor.Extensions.Storage;

#line default
#line hidden
#line 3 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\Login.razor"
using DemoBlazor.Models;

#line default
#line hidden
#line 4 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\Login.razor"
using DemoBlazor.Services;

#line default
#line hidden
#line 5 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\Login.razor"
using DemoBlazor.Utilities;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Giriş</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 15 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\Login.razor"
                  loginModel

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 15 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\Login.razor"
                                              HandleLogin

#line default
#line hidden
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group");
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "Placeholder", "E-mail");
                __builder2.AddAttribute(13, "Class", "form-control");
                __builder2.AddAttribute(14, "Id", "email");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 19 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\Login.razor"
                                                                                      loginModel.Email

#line default
#line hidden
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginModel.Email = __value, loginModel.Email))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginModel.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __Blazor.DemoBlazor.Pages.Login.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#line 20 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\Login.razor"
                                  ()=>loginModel.Email

#line default
#line hidden
                );
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group");
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(26);
                __builder2.AddAttribute(27, "Placeholder", "Password");
                __builder2.AddAttribute(28, "Class", "form-control");
                __builder2.AddAttribute(29, "Id", "password");
                __builder2.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 23 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\Login.razor"
                                                                                           loginModel.Password

#line default
#line hidden
                ));
                __builder2.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginModel.Password = __value, loginModel.Password))));
                __builder2.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginModel.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __Blazor.DemoBlazor.Pages.Login.TypeInference.CreateValidationMessage_1(__builder2, 34, 35, 
#line 24 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\Login.razor"
                                  ()=>loginModel.Password

#line default
#line hidden
                );
                __builder2.AddMarkupContent(36, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n\r\n\r\n    ");
                __builder2.AddMarkupContent(38, "<button class=\"btn btn-primary\" type=\"submit\">Giriş</button>\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 33 "C:\Users\Lenovo\source\repos\DemoBlazor\DemoBlazor\Pages\Login.razor"
       

    LoginModel loginModel = new LoginModel();

    private async Task HandleLogin()
    {
       await AuthService.Login(loginModel);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LocalStorage LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.DemoBlazor.Pages.Login
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
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591