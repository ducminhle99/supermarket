#pragma checksum "C:\Users\ASUS\Desktop\LEDUCMINH102170102\Drugstore\Views\Drug\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "120f36aa040006d6cbed809d098298a02866e11a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Drug_Index), @"mvc.1.0.view", @"/Views/Drug/Index.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\LEDUCMINH102170102\Drugstore\Views\_ViewImports.cshtml"
using Drugstor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\LEDUCMINH102170102\Drugstore\Views\_ViewImports.cshtml"
using Drugstor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ASUS\Desktop\LEDUCMINH102170102\Drugstore\Views\Drug\Index.cshtml"
using Drugstore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"120f36aa040006d6cbed809d098298a02866e11a", @"/Views/Drug/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f556afdaa32f0f96307837f36e827b51c4e078b", @"/Views/_ViewImports.cshtml")]
    public class Views_Drug_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/drug/SearchDrug"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\LEDUCMINH102170102\Drugstore\Views\Drug\Index.cshtml"
  
    ViewData["Title"] = "Drug Page";
    List<Drug> drugs = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Welcome to Drugs Page</h1>\r\n<p>danh sach cac loai thuoc</p>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "120f36aa040006d6cbed809d098298a02866e11a4326", async() => {
                WriteLiteral(@"
<div class=""input-group"">
  <input type=""search"" class=""form-control rounded"" placeholder=""Search"" aria-label=""Search"" id=""name"" name =""name""
    aria-describedby=""search-addon"" />
  <button type=""submit"" class=""btn btn-outline-primary"">search</button>
</div>
    
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<table class=""table table-hover"">
    <thead>
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>so luong</th>
            <th> nha san xuat</th>
            <th><a href=""/drug/AddDrug"" class=""btn btn-primary"">them thuoc moi</a></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 29 "C:\Users\ASUS\Desktop\LEDUCMINH102170102\Drugstore\Views\Drug\Index.cshtml"
         foreach (var drug in drugs)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\ASUS\Desktop\LEDUCMINH102170102\Drugstore\Views\Drug\Index.cshtml"
               Write(drug.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\ASUS\Desktop\LEDUCMINH102170102\Drugstore\Views\Drug\Index.cshtml"
               Write(drug.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\ASUS\Desktop\LEDUCMINH102170102\Drugstore\Views\Drug\Index.cshtml"
               Write(drug.soLuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\ASUS\Desktop\LEDUCMINH102170102\Drugstore\Views\Drug\Index.cshtml"
               Write(drug.nhaSX);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1070, "\"", 1103, 2);
            WriteAttributeValue("", 1077, "/drug/EditDrug?Id=", 1077, 18, true);
#nullable restore
#line 37 "C:\Users\ASUS\Desktop\LEDUCMINH102170102\Drugstore\Views\Drug\Index.cshtml"
WriteAttributeValue("", 1095, drug.Id, 1095, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Edit</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1161, "\"", 1192, 2);
            WriteAttributeValue("", 1168, "/drug/Delete?Id=", 1168, 16, true);
#nullable restore
#line 38 "C:\Users\ASUS\Desktop\LEDUCMINH102170102\Drugstore\Views\Drug\Index.cshtml"
WriteAttributeValue("", 1184, drug.Id, 1184, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n                </td>\r\n                <td></td>\r\n            </tr>\r\n");
#nullable restore
#line 42 "C:\Users\ASUS\Desktop\LEDUCMINH102170102\Drugstore\Views\Drug\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591