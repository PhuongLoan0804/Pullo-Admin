#pragma checksum "D:\HK1\framework\Pullo-Admin\Pullo-Admin\Views\Sach\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8b947eb010da057ee9e5eb8ed1f0919bda23462"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sach_Index), @"mvc.1.0.view", @"/Views/Sach/Index.cshtml")]
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
#line 1 "D:\HK1\framework\Pullo-Admin\Pullo-Admin\Views\_ViewImports.cshtml"
using Pullo_Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HK1\framework\Pullo-Admin\Pullo-Admin\Views\_ViewImports.cshtml"
using Pullo_Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8b947eb010da057ee9e5eb8ed1f0919bda23462", @"/Views/Sach/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1efea93e13d36cbb2cc97fa93fef105b4bb2e1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Sach_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pullo_Admin.Models.Sach>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Sach", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateSach", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\HK1\framework\Pullo-Admin\Pullo-Admin\Views\Sach\Index.cshtml"
  
    ViewBag.Title = "Danh mục sách";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8b947eb010da057ee9e5eb8ed1f0919bda234624486", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8b947eb010da057ee9e5eb8ed1f0919bda234624748", async() => {
                    WriteLiteral("<i class=\"btn btn-success btn-sm\">Thêm</i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
                WriteLiteral(@"

    <br />
    <br />

    <table class=""table"">
        <tr>
            <th>
                #ISBN
            </th>
            <th>
                IMG
            </th>
            <th>
                Chi tiết
            </th>
            <th>
                Thể loại
            </th>
            <th>
                Giá bán
            </th>
            <th style=""width: 120px"">
                Hành động
            </th>
        </tr>

");
#nullable restore
#line 35 "D:\HK1\framework\Pullo-Admin\Pullo-Admin\Views\Sach\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <tr>\r\n        <td style=\"text-align: center\">\r\n            ");
#nullable restore
#line 39 "D:\HK1\framework\Pullo-Admin\Pullo-Admin\Views\Sach\Index.cshtml"
       Write(item.ISBN);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </td>\r\n        <td>\r\n            <img style=\"width: 120px; height: 160px\"");
                BeginWriteAttribute("src", " src=\"", 942, "\"", 957, 1);
#nullable restore
#line 42 "D:\HK1\framework\Pullo-Admin\Pullo-Admin\Views\Sach\Index.cshtml"
WriteAttributeValue("", 948, item.URL, 948, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n        </td>\r\n        <td>\r\n            <p>Tiêu đề: <b>");
#nullable restore
#line 45 "D:\HK1\framework\Pullo-Admin\Pullo-Admin\Views\Sach\Index.cshtml"
                      Write(item.TENSACH);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></p>\r\n            <p>Tác giả: <b>");
#nullable restore
#line 46 "D:\HK1\framework\Pullo-Admin\Pullo-Admin\Views\Sach\Index.cshtml"
                      Write(item.TACGIA);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></p>\r\n            <p><small>Mô tả: <b>");
#nullable restore
#line 47 "D:\HK1\framework\Pullo-Admin\Pullo-Admin\Views\Sach\Index.cshtml"
                           Write(item.MOTA);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></small></p>\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 50 "D:\HK1\framework\Pullo-Admin\Pullo-Admin\Views\Sach\Index.cshtml"
       Write(item.MADM);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </td>\r\n        <td style=\"text-align: center\">\r\n            ");
#nullable restore
#line 53 "D:\HK1\framework\Pullo-Admin\Pullo-Admin\Views\Sach\Index.cshtml"
       Write(item.GIATIEN);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </td>\r\n        <td >\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8b947eb010da057ee9e5eb8ed1f0919bda234629289", async() => {
                    WriteLiteral("\r\n                <i class=\"fa fa-edit btn btn-info btn-sm\"></i>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1337, "~/Sach/ViewSach?isbn=", 1337, 21, true);
#nullable restore
#line 56 "D:\HK1\framework\Pullo-Admin\Pullo-Admin\Views\Sach\Index.cshtml"
AddHtmlAttributeValue("", 1358, item.ISBN, 1358, 10, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" |\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8b947eb010da057ee9e5eb8ed1f0919bda2346210971", async() => {
                    WriteLiteral("\r\n                <i class=\"btn btn-danger btn-sm\">Xóa</i>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1477, "~/Sach/DeleteSach?isbn=", 1477, 23, true);
#nullable restore
#line 59 "D:\HK1\framework\Pullo-Admin\Pullo-Admin\Views\Sach\Index.cshtml"
AddHtmlAttributeValue("", 1500, item.ISBN, 1500, 10, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 64 "D:\HK1\framework\Pullo-Admin\Pullo-Admin\Views\Sach\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pullo_Admin.Models.Sach>> Html { get; private set; }
    }
}
#pragma warning restore 1591