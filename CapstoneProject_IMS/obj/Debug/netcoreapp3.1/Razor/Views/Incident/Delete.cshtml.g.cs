#pragma checksum "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\Incident\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c498cefb83cd695191ab7f8696196f6a16807e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Incident_Delete), @"mvc.1.0.view", @"/Views/Incident/Delete.cshtml")]
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
#nullable restore
#line 1 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\_ViewImports.cshtml"
using CapstoneProject_IMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\_ViewImports.cshtml"
using CapstoneProject_IMS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c498cefb83cd695191ab7f8696196f6a16807e2", @"/Views/Incident/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c832851f227455c0c7ca8a824fe740e09e31647", @"/Views/_ViewImports.cshtml")]
    public class Views_Incident_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CapstoneProject_IMS.Models.Incident>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\Incident\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Incident</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\Incident\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IncidentTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\Incident\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IncidentTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\Incident\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IncidentDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\Incident\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IncidentDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\Incident\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IncidentStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\Incident\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IncidentStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\Incident\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IncidentEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\Incident\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IncidentEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\Incident\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IncidentResolved));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\Incident\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IncidentResolved));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\Incident\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ExternalTicket));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\Incident\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ExternalTicket));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\Incident\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ExternalTicketUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\Incident\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ExternalTicketUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\Incident\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LocationUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\Incident\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LocationUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\Incident\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\Incident\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Location.LocationEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\Incident\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Manager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\Incident\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Manager.ManagerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\Incident\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Severity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\Incident\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Severity.SeverityDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\Incident\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Team));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\Incident\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Team.TeamEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c498cefb83cd695191ab7f8696196f6a16807e213704", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4c498cefb83cd695191ab7f8696196f6a16807e213971", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 89 "C:\EmadFiles\CapeStoneProject\CapstoneProject\CapstoneProject_IMS\CapstoneProject_IMS\Views\Incident\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IncidentId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c498cefb83cd695191ab7f8696196f6a16807e215801", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CapstoneProject_IMS.Models.Incident> Html { get; private set; }
    }
}
#pragma warning restore 1591