#pragma checksum "/Users/tunc/Documents/C#/Core2Identity/Views/AdminRole/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b157cb41abbdd5ecf0e05d5bbaa1bb30823ab28a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminRole_Edit), @"mvc.1.0.view", @"/Views/AdminRole/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminRole/Edit.cshtml", typeof(AspNetCore.Views_AdminRole_Edit))]
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
#line 1 "/Users/tunc/Documents/C#/Core2Identity/Views/_ViewImports.cshtml"
using Core2Identity.Models;

#line default
#line hidden
#line 2 "/Users/tunc/Documents/C#/Core2Identity/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b157cb41abbdd5ecf0e05d5bbaa1bb30823ab28a", @"/Views/AdminRole/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4814f919cb2526a79ed7d529d9fa0aece7e49b3", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminRole_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/tunc/Documents/C#/Core2Identity/Views/AdminRole/Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(56, 76, true);
            WriteLiteral("\n<div class=\"bg-primary text-white p-1 m-1\">\n    <h2>Edit Role</h2>\n</div>\n\n");
            EndContext();
            BeginContext(132, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b157cb41abbdd5ecf0e05d5bbaa1bb30823ab28a5371", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 10 "/Users/tunc/Documents/C#/Core2Identity/Views/AdminRole/Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(198, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(200, 1519, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b157cb41abbdd5ecf0e05d5bbaa1bb30823ab28a7043", async() => {
                BeginContext(238, 39, true);
                WriteLiteral("\n    <input type=\"hidden\" name=\"RoleId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 277, "\"", 299, 1);
#line 13 "/Users/tunc/Documents/C#/Core2Identity/Views/AdminRole/Edit.cshtml"
WriteAttributeValue("", 285, Model.Role.Id, 285, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(300, 42, true);
                WriteLiteral(">\n    <input type=\"hidden\" name=\"RoleName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 342, "\"", 366, 1);
#line 14 "/Users/tunc/Documents/C#/Core2Identity/Views/AdminRole/Edit.cshtml"
WriteAttributeValue("", 350, Model.Role.Name, 350, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(367, 58, true);
                WriteLiteral(">\n\n    <h6 class=\"bg-info p-1 text-white\">\n        Add to ");
                EndContext();
                BeginContext(426, 15, false);
#line 17 "/Users/tunc/Documents/C#/Core2Identity/Views/AdminRole/Edit.cshtml"
          Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(441, 62, true);
                WriteLiteral("\n    </h6>\n\n    <table class=\"table table-bordered table-sm\">\n");
                EndContext();
#line 21 "/Users/tunc/Documents/C#/Core2Identity/Views/AdminRole/Edit.cshtml"
         if (Model.NonMembers.Count() == 0)
        {

#line default
#line hidden
                BeginContext(557, 64, true);
                WriteLiteral("            <tr><td colspan=\"2\">All Users are members</td></tr>\n");
                EndContext();
#line 24 "/Users/tunc/Documents/C#/Core2Identity/Views/AdminRole/Edit.cshtml"
        }
        else
        {
            

#line default
#line hidden
#line 27 "/Users/tunc/Documents/C#/Core2Identity/Views/AdminRole/Edit.cshtml"
             foreach (var user in Model.NonMembers)
            {

#line default
#line hidden
                BeginContext(720, 45, true);
                WriteLiteral("                <tr>\n                    <td>");
                EndContext();
                BeginContext(766, 13, false);
#line 30 "/Users/tunc/Documents/C#/Core2Identity/Views/AdminRole/Edit.cshtml"
                   Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(779, 93, true);
                WriteLiteral("</td>\n                    <td>\n                        <input type=\"checkbox\" name=\"IdsToAdd\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 872, "\"", 888, 1);
#line 32 "/Users/tunc/Documents/C#/Core2Identity/Views/AdminRole/Edit.cshtml"
WriteAttributeValue("", 880, user.Id, 880, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(889, 50, true);
                WriteLiteral(">\n                    </td>\n                </tr>\n");
                EndContext();
#line 35 "/Users/tunc/Documents/C#/Core2Identity/Views/AdminRole/Edit.cshtml"
            }

#line default
#line hidden
#line 35 "/Users/tunc/Documents/C#/Core2Identity/Views/AdminRole/Edit.cshtml"
             
        }

#line default
#line hidden
                BeginContext(963, 74, true);
                WriteLiteral("    </table>\n\n    <h6 class=\"bg-info p-1 text-white\">\n        Delete from ");
                EndContext();
                BeginContext(1038, 15, false);
#line 40 "/Users/tunc/Documents/C#/Core2Identity/Views/AdminRole/Edit.cshtml"
               Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1053, 62, true);
                WriteLiteral("\n    </h6>\n\n    <table class=\"table table-bordered table-sm\">\n");
                EndContext();
#line 44 "/Users/tunc/Documents/C#/Core2Identity/Views/AdminRole/Edit.cshtml"
         if (Model.Members.Count() == 0)
        {

#line default
#line hidden
                BeginContext(1166, 63, true);
                WriteLiteral("            <tr><td colspan=\"2\">No Users are members</td></tr>\n");
                EndContext();
#line 47 "/Users/tunc/Documents/C#/Core2Identity/Views/AdminRole/Edit.cshtml"
        }
        else
        {
            

#line default
#line hidden
#line 50 "/Users/tunc/Documents/C#/Core2Identity/Views/AdminRole/Edit.cshtml"
             foreach (var user in Model.Members)
            {

#line default
#line hidden
                BeginContext(1325, 45, true);
                WriteLiteral("                <tr>\n                    <td>");
                EndContext();
                BeginContext(1371, 13, false);
#line 53 "/Users/tunc/Documents/C#/Core2Identity/Views/AdminRole/Edit.cshtml"
                   Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(1384, 96, true);
                WriteLiteral("</td>\n                    <td>\n                        <input type=\"checkbox\" name=\"IdsToDelete\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1480, "\"", 1496, 1);
#line 55 "/Users/tunc/Documents/C#/Core2Identity/Views/AdminRole/Edit.cshtml"
WriteAttributeValue("", 1488, user.Id, 1488, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1497, 50, true);
                WriteLiteral(">\n                    </td>\n                </tr>\n");
                EndContext();
#line 58 "/Users/tunc/Documents/C#/Core2Identity/Views/AdminRole/Edit.cshtml"
            }

#line default
#line hidden
#line 58 "/Users/tunc/Documents/C#/Core2Identity/Views/AdminRole/Edit.cshtml"
             
        }

#line default
#line hidden
                BeginContext(1571, 82, true);
                WriteLiteral("    </table>\n\n    <button type=\"submit\" class=\"btn btn-primary\">Save</button>\n    ");
                EndContext();
                BeginContext(1653, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b157cb41abbdd5ecf0e05d5bbaa1bb30823ab28a13406", async() => {
                    BeginContext(1701, 6, true);
                    WriteLiteral("Cancel");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1711, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
