#pragma checksum "C:\Users\Pat\Desktop\.Net Enterprise\Lab\Lab 3\lab3\lab3\Views\Home\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "041395192daaa54c346f656999a4c9cc4b2c1f38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_index), @"mvc.1.0.view", @"/Views/Home/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/index.cshtml", typeof(AspNetCore.Views_Home_index))]
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
#line 1 "C:\Users\Pat\Desktop\.Net Enterprise\Lab\Lab 3\lab3\lab3\Views\Home\_ViewImports.cshtml"
using lab3;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"041395192daaa54c346f656999a4c9cc4b2c1f38", @"/Views/Home/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0d443b56b14c7d52c2f885665f66a692adb3616", @"/Views/Home/_ViewImports.cshtml")]
    public class Views_Home_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 81, true);
            WriteLiteral("<h1>Lab 3</h1>\r\n\r\n<br/>\r\n\r\nPatrick Bobyn<br/><br/>\r\n\r\n040-889-706<br/><br/>\r\n\r\n\r\n");
            EndContext();
            BeginContext(82, 41, false);
#line 10 "C:\Users\Pat\Desktop\.Net Enterprise\Lab\Lab 3\lab3\lab3\Views\Home\index.cshtml"
Write(Html.ActionLink("Razor", "Razor", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(123, 11, true);
            WriteLiteral(" &emsp;\r\n\r\n");
            EndContext();
            BeginContext(135, 56, false);
#line 12 "C:\Users\Pat\Desktop\.Net Enterprise\Lab\Lab 3\lab3\lab3\Views\Home\index.cshtml"
Write(Html.ActionLink("Create Person", "CreatePerson", "Home"));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
