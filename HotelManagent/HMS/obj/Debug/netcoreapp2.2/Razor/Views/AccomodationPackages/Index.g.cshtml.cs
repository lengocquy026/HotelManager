#pragma checksum "D:\Reuslt\HotelMVC\HotelManagent\HMS\Views\AccomodationPackages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef8987197816017fd0bb020074c1c74fe03086d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AccomodationPackages_Index), @"mvc.1.0.view", @"/Views/AccomodationPackages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AccomodationPackages/Index.cshtml", typeof(AspNetCore.Views_AccomodationPackages_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef8987197816017fd0bb020074c1c74fe03086d5", @"/Views/AccomodationPackages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6092ba151e2807b9131cac5b80bb532d7d1c0f5f", @"/Views/_ViewImports.cshtml")]
    public class Views_AccomodationPackages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AccomodationPackagesListingModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AccomodationPackages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("data-btn btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Reuslt\HotelMVC\HotelManagent\HMS\Views\AccomodationPackages\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(84, 85, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<div class=\"row mb-3\">\r\n    <div class=\"col col-lg-12\">\r\n        ");
            EndContext();
            BeginContext(169, 1480, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef8987197816017fd0bb020074c1c74fe03086d55846", async() => {
                BeginContext(175, 138, true);
                WriteLiteral("\r\n            <div class=\"input-group\">\r\n                <input type=\"text\" name=\"searchterm\" class=\"form-control\" placeholder=\"Search...\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 313, "\"", 338, 1);
#line 13 "D:\Reuslt\HotelMVC\HotelManagent\HMS\Views\AccomodationPackages\Index.cshtml"
WriteAttributeValue("", 321, Model.SearchTerm, 321, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(339, 5, true);
                WriteLiteral(">\r\n\r\n");
                EndContext();
#line 15 "D:\Reuslt\HotelMVC\HotelManagent\HMS\Views\AccomodationPackages\Index.cshtml"
                 if (Model.AccomodationTypes != null && Model.AccomodationTypes.Count() > 0)
                {

#line default
#line hidden
                BeginContext(457, 101, true);
                WriteLiteral("                    <select name=\"AccomodationTypeID\" class=\"form-control\">\r\n                        ");
                EndContext();
                BeginContext(558, 94, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef8987197816017fd0bb020074c1c74fe03086d57252", async() => {
                    BeginContext(576, 67, true);
                    WriteLiteral("\r\n                            Select Type\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(652, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 21 "D:\Reuslt\HotelMVC\HotelManagent\HMS\Views\AccomodationPackages\Index.cshtml"
                         foreach (var accomodationType in Model.AccomodationTypes)
                        {

#line default
#line hidden
                BeginContext(765, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(793, 211, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef8987197816017fd0bb020074c1c74fe03086d59151", async() => {
                    BeginContext(909, 34, true);
                    WriteLiteral("\r\n                                ");
                    EndContext();
                    BeginContext(944, 21, false);
#line 24 "D:\Reuslt\HotelMVC\HotelManagent\HMS\Views\AccomodationPackages\Index.cshtml"
                           Write(accomodationType.Name);

#line default
#line hidden
                    EndContext();
                    BeginContext(965, 30, true);
                    WriteLiteral("\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 23 "D:\Reuslt\HotelMVC\HotelManagent\HMS\Views\AccomodationPackages\Index.cshtml"
                               WriteLiteral(accomodationType.ID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1004, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 26 "D:\Reuslt\HotelMVC\HotelManagent\HMS\Views\AccomodationPackages\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(1033, 31, true);
                WriteLiteral("                    </select>\r\n");
                EndContext();
#line 28 "D:\Reuslt\HotelMVC\HotelManagent\HMS\Views\AccomodationPackages\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(1083, 231, true);
                WriteLiteral("                <div class=\"input-group-append\">\r\n                    <button class=\"btn btn-outline-primary\" type=\"submit\"><i class=\"fas fa-search mr-1\"></i>Search</button>\r\n                    <a class=\"btn btn-outline-secondary\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1314, "\"", 1365, 1);
#line 31 "D:\Reuslt\HotelMVC\HotelManagent\HMS\Views\AccomodationPackages\Index.cshtml"
WriteAttributeValue("", 1321, Url.Action("Index", "AccomodationPackages"), 1321, 44, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1366, 68, true);
                WriteLiteral("><i class=\"fas fa-redo-alt mr-1\"></i>Reset</a>\r\n                    ");
                EndContext();
                BeginContext(1434, 154, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef8987197816017fd0bb020074c1c74fe03086d512809", async() => {
                    BeginContext(1541, 38, true);
                    WriteLiteral("<i class=\"fas fa-plus mr-1\"></i>Create");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1588, 54, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1649, 76, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col col-lg-12\">\r\n");
            EndContext();
#line 41 "D:\Reuslt\HotelMVC\HotelManagent\HMS\Views\AccomodationPackages\Index.cshtml"
          
            Html.RenderPartial("_Listing", Model);
        

#line default
#line hidden
            BeginContext(1800, 18, true);
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccomodationPackagesListingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
