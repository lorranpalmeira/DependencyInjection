#pragma checksum "C:\Users\lalvespa\Documents\Projetos\NetCore\InjecaoDep\Views\Operations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cd33651afcfcabfb307198465fa94cda12504aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Operations_Index), @"mvc.1.0.view", @"/Views/Operations/Index.cshtml")]
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
#line 1 "C:\Users\lalvespa\Documents\Projetos\NetCore\InjecaoDep\Views\_ViewImports.cshtml"
using InjecaoDep;

#line default
#line hidden
#line 2 "C:\Users\lalvespa\Documents\Projetos\NetCore\InjecaoDep\Views\_ViewImports.cshtml"
using InjecaoDep.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cd33651afcfcabfb307198465fa94cda12504aa", @"/Views/Operations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b44f07d61800090bf38a4a3fe0ff5750d0bee2b", @"/Views/_ViewImports.cshtml")]
    public class Views_Operations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#line 2 "C:\Users\lalvespa\Documents\Projetos\NetCore\InjecaoDep\Views\Operations\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Dependency Injection.</h1>\r\n    <p>Difference between Transient, Scoped and Singleton</p>\r\n</div>\r\n\r\n<div>\r\n    <dt>Transient:</dt> ");
#line 12 "C:\Users\lalvespa\Documents\Projetos\NetCore\InjecaoDep\Views\Operations\Index.cshtml"
                   Write(ViewBag.Transient);

#line default
#line hidden
            WriteLiteral("\r\n    <br/>\r\n\r\n    <dt>Scoped:</dt> ");
#line 15 "C:\Users\lalvespa\Documents\Projetos\NetCore\InjecaoDep\Views\Operations\Index.cshtml"
                Write(ViewBag.Scoped);

#line default
#line hidden
            WriteLiteral("\r\n    <br/>\r\n\r\n    <dt>SingleTon:</dt> ");
#line 18 "C:\Users\lalvespa\Documents\Projetos\NetCore\InjecaoDep\Views\Operations\Index.cshtml"
                   Write(ViewBag.SingleTon);

#line default
#line hidden
            WriteLiteral("\r\n    <br/>\r\n\r\n    <dt>SingleTon Instance ShouldBeEmpty (Guid.Empty):</dt> ");
#line 21 "C:\Users\lalvespa\Documents\Projetos\NetCore\InjecaoDep\Views\Operations\Index.cshtml"
                                                       Write(ViewBag.SingletonInstance);

#line default
#line hidden
            WriteLiteral("\r\n    <br/>\r\n\r\n    ---------------------------------------------\r\n    <h3>Service</h3>\r\n\r\n    <dt>Transient:</dt> ");
#line 27 "C:\Users\lalvespa\Documents\Projetos\NetCore\InjecaoDep\Views\Operations\Index.cshtml"
                   Write(ViewBag.ServiceTransient);

#line default
#line hidden
            WriteLiteral("\r\n    <br/>\r\n\r\n    <dt>Scoped:</dt> ");
#line 30 "C:\Users\lalvespa\Documents\Projetos\NetCore\InjecaoDep\Views\Operations\Index.cshtml"
                Write(ViewBag.ServiceScoped);

#line default
#line hidden
            WriteLiteral("\r\n    <br/>\r\n    \r\n    <dt>SingleTon:</dt> ");
#line 33 "C:\Users\lalvespa\Documents\Projetos\NetCore\InjecaoDep\Views\Operations\Index.cshtml"
                   Write(ViewBag.ServiceSingleTon);

#line default
#line hidden
            WriteLiteral("\r\n    <br/>\r\n\r\n    <dt>SingleTon Instance ShouldBeEmpty (Guid.Empty):</dt> ");
#line 36 "C:\Users\lalvespa\Documents\Projetos\NetCore\InjecaoDep\Views\Operations\Index.cshtml"
                                                       Write(ViewBag.ServiceSingletonInstanceOperation);

#line default
#line hidden
            WriteLiteral("\r\n    <br/>  \r\n\r\n</div>\r\n\r\n\r\n");
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
