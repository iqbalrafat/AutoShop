#pragma checksum "D:\AutoShop\AutoShop\Views\Make\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81f1afa03ebed52aa6fd18c56049a7a2688f3d0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Make_Index), @"mvc.1.0.view", @"/Views/Make/Index.cshtml")]
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
#line 1 "D:\AutoShop\AutoShop\Views\_ViewImports.cshtml"
using AutoShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AutoShop\AutoShop\Views\_ViewImports.cshtml"
using AutoShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81f1afa03ebed52aa6fd18c56049a7a2688f3d0d", @"/Views/Make/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93eab5d1e5be94b68db1541a0ab4674fad8df3b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Make_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AutoShop.Models.Make>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\AutoShop\AutoShop\Views\Make\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Hello World</h1>\r\n\r\n<p> This is home </p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AutoShop.Models.Make>> Html { get; private set; }
    }
}
#pragma warning restore 1591
