#pragma checksum "D:\Reuslt\HotelMVC\HotelManagent\HMS\Views\Shared\Components\AccomodationTypesMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9300b2d79e4a11c6fd96f82b5f6fa7377c80c9c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AccomodationTypesMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AccomodationTypesMenu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/AccomodationTypesMenu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_AccomodationTypesMenu_Default))]
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
#line 1 "D:\Reuslt\HotelMVC\HotelManagent\HMS\Views\_ViewImports.cshtml"
using HMS;

#line default
#line hidden
#line 2 "D:\Reuslt\HotelMVC\HotelManagent\HMS\Views\_ViewImports.cshtml"
using HMS.Models;

#line default
#line hidden
#line 3 "D:\Reuslt\HotelMVC\HotelManagent\HMS\Views\_ViewImports.cshtml"
using HMS.ViewModels;

#line default
#line hidden
#line 4 "D:\Reuslt\HotelMVC\HotelManagent\HMS\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 5 "D:\Reuslt\HotelMVC\HotelManagent\HMS\Views\_ViewImports.cshtml"
using HMS.Entities;

#line default
#line hidden
#line 6 "D:\Reuslt\HotelMVC\HotelManagent\HMS\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9300b2d79e4a11c6fd96f82b5f6fa7377c80c9c9", @"/Views/Shared/Components/AccomodationTypesMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6092ba151e2807b9131cac5b80bb532d7d1c0f5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AccomodationTypesMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AccomodationType>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AccomodationPackages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 273, true);
            WriteLiteral(@"
<li class=""dropdown"">
    <a class=""dropdown-toggle"" href=""#"" id=""navbarDropdownMenuLink""
       data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
        Rooms Type
    </a>
    <div class=""dropdown-menu"" aria-labelledby=""navbarDropdownMenuLink"">
");
            EndContext();
#line 9 "D:\Reuslt\HotelMVC\HotelManagent\HMS\Views\Shared\Components\AccomodationTypesMenu\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(360, 36, true);
            WriteLiteral("            <a class=\"dropdown-item\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 396, "\"", 476, 1);
#line 11 "D:\Reuslt\HotelMVC\HotelManagent\HMS\Views\Shared\Components\AccomodationTypesMenu\Default.cshtml"
WriteAttributeValue("", 403, Url.Action("AccomodationType","AccomodationTypes", new {@ID = item.ID }), 403, 73, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(477, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(479, 9, false);
#line 11 "D:\Reuslt\HotelMVC\HotelManagent\HMS\Views\Shared\Components\AccomodationTypesMenu\Default.cshtml"
                                                                                                                 Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(488, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 12 "D:\Reuslt\HotelMVC\HotelManagent\HMS\Views\Shared\Components\AccomodationTypesMenu\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(505, 45, true);
            WriteLiteral("        <div class=\"divider\"></div>\r\n        ");
            EndContext();
            BeginContext(550, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9300b2d79e4a11c6fd96f82b5f6fa7377c80c9c96735", async() => {
                BeginContext(631, 8, true);
                WriteLiteral("View all");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(643, 19, true);
            WriteLiteral("\r\n    </div>\r\n</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AccomodationType>> Html { get; private set; }
    }
}
#pragma warning restore 1591