#pragma checksum "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5d926ce577a8bce5678a46c389d9370987e3cbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegisterUser_Index), @"mvc.1.0.view", @"/Views/RegisterUser/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RegisterUser/Index.cshtml", typeof(AspNetCore.Views_RegisterUser_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\_ViewImports.cshtml"
using Lab18CoffeeShop;

#line default
#line hidden
#line 2 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\_ViewImports.cshtml"
using Lab18CoffeeShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5d926ce577a8bce5678a46c389d9370987e3cbd", @"/Views/RegisterUser/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe600a813aeb241e28f2cba4f76963bde4e3ff07", @"/Views/_ViewImports.cshtml")]
    public class Views_RegisterUser_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab18CoffeeShop.Register>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Index.cshtml"
  
    ViewData["Title"] = "Registration Form";

#line default
#line hidden
            BeginContext(55, 52, true);
            WriteLiteral("\r\n<h1 style=\"color:burlywood;\">Registration</h1>\r\n\r\n");
            EndContext();
            BeginContext(140, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Index.cshtml"
 using (var form = Html.BeginForm())
{

#line default
#line hidden
            BeginContext(183, 43, true);
            WriteLiteral("<div style=\"color:red; font-weight: bold;\">");
            EndContext();
            BeginContext(227, 24, false);
#line 12 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Index.cshtml"
                                      Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(251, 63, true);
            WriteLiteral("</div>\r\n    <div class=\"fields\">\r\n        <div>\r\n\r\n            ");
            EndContext();
            BeginContext(315, 43, false);
#line 16 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Index.cshtml"
       Write(Html.LabelFor(m => m.UserName, "User Name"));

#line default
#line hidden
            EndContext();
            BeginContext(358, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(373, 32, false);
#line 17 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Index.cshtml"
       Write(Html.TextBoxFor(m => m.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(405, 47, true);
            WriteLiteral("\r\n\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(453, 44, false);
#line 21 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Index.cshtml"
       Write(Html.LabelFor(m => m.Email, "Email Address"));

#line default
#line hidden
            EndContext();
            BeginContext(497, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(512, 29, false);
#line 22 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Index.cshtml"
       Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(541, 45, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(587, 42, false);
#line 25 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Index.cshtml"
       Write(Html.LabelFor(m => m.Password, "Password"));

#line default
#line hidden
            EndContext();
            BeginContext(629, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(644, 32, false);
#line 26 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Index.cshtml"
       Write(Html.TextBoxFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(676, 45, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(722, 45, false);
#line 29 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Index.cshtml"
       Write(Html.LabelFor(m => m.FirstName, "First Name"));

#line default
#line hidden
            EndContext();
            BeginContext(767, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(782, 33, false);
#line 30 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Index.cshtml"
       Write(Html.TextBoxFor(m => m.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(815, 45, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(861, 43, false);
#line 33 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Index.cshtml"
       Write(Html.LabelFor(m => m.LastName, "Last Name"));

#line default
#line hidden
            EndContext();
            BeginContext(904, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(919, 32, false);
#line 34 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Index.cshtml"
       Write(Html.TextBoxFor(m => m.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(951, 96, true);
            WriteLiteral("\r\n        </div>\r\n        <div style=\"width: 322px; background-color: burlywood;\">\r\n            ");
            EndContext();
            BeginContext(1048, 148, false);
#line 37 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Index.cshtml"
       Write(Html.DropDownListFor(m => m.FavoriteDrink, new SelectList(Enum.GetValues(typeof(FavoriteDrink))), "Favorite Drink", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1196, 80, true);
            WriteLiteral("\r\n\r\n        </div>\r\n        <input type=\"submit\" value=\"Submit\" />\r\n    </div>\r\n");
            EndContext();
#line 42 "C:\Users\tweed\source\repos\Lab18CoffeeShop\Lab18CoffeeShop\Views\RegisterUser\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1279, 2, true);
            WriteLiteral("\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab18CoffeeShop.Register> Html { get; private set; }
    }
}
#pragma warning restore 1591
