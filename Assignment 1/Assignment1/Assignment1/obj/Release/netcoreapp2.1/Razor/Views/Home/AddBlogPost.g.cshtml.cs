#pragma checksum "C:\Users\Pat\Desktop\.Net Enterprise\Assignment\Assignment 1\Assignment1\Assignment1\Views\Home\AddBlogPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab0596bb37096fa582c0b1b2e21247fc78eb1eef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddBlogPost), @"mvc.1.0.view", @"/Views/Home/AddBlogPost.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AddBlogPost.cshtml", typeof(AspNetCore.Views_Home_AddBlogPost))]
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
#line 1 "C:\Users\Pat\Desktop\.Net Enterprise\Assignment\Assignment 1\Assignment1\Assignment1\Views\_ViewImports.cshtml"
using Assignment1;

#line default
#line hidden
#line 1 "C:\Users\Pat\Desktop\.Net Enterprise\Assignment\Assignment 1\Assignment1\Assignment1\Views\Home\AddBlogPost.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab0596bb37096fa582c0b1b2e21247fc78eb1eef", @"/Views/Home/AddBlogPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"965bb1241869d6115733232d12dfa4aeb5b85321", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddBlogPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Pat\Desktop\.Net Enterprise\Assignment\Assignment 1\Assignment1\Assignment1\Views\Home\AddBlogPost.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(66, 150, true);
            WriteLiteral("\r\n<div style=\"padding-bottom:9px; margin: 40px 0 20px; border-bottom: 1px solid #eee; box-sizing: border-box\">\r\n    <h3>Add Blog Post</h3>\r\n</div>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\Pat\Desktop\.Net Enterprise\Assignment\Assignment 1\Assignment1\Assignment1\Views\Home\AddBlogPost.cshtml"
 using (Html.BeginForm("CreateBlogPost", "Home"))
{

#line default
#line hidden
            BeginContext(270, 598, true);
            WriteLiteral(@"    <fieldset>
        <div class=""form-group"">
            <label for=""Title"">Title: </label>
            <input class=""form-control"" type=""text"" data-val=""true"" data-val-length=""200"" data-val-length-max=""200"" id=""Title"" name=""Title"" value="""" required />
        </div>
        <div class=""form-group"">
            <label for=""Content"">Content:</label><br/>
            <textarea class=""form-control"" type=""text"" data-val=""true"" data-val-length-max=""4000"" id=""Content"" name=""Content"" required>
            </textarea>
        </div>
        <input type=""hidden"" id=""UserId"" name=""UserId""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 868, "\"", 912, 1);
#line 22 "C:\Users\Pat\Desktop\.Net Enterprise\Assignment\Assignment 1\Assignment1\Assignment1\Views\Home\AddBlogPost.cshtml"
WriteAttributeValue("", 876, Context.Session.GetInt32("_userId"), 876, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(913, 59, true);
            WriteLiteral(" />\r\n        <input type=\"hidden\" ud=\"Posted\" name=\"Posted\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 972, "\"", 993, 1);
#line 23 "C:\Users\Pat\Desktop\.Net Enterprise\Assignment\Assignment 1\Assignment1\Assignment1\Views\Home\AddBlogPost.cshtml"
WriteAttributeValue("", 980, DateTime.Now, 980, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(994, 109, true);
            WriteLiteral(" />\r\n        <input type=\"submit\" value=\"Create Blog Post\" class=\"btn btn-outline-dark\" />\r\n    </fieldset>\r\n");
            EndContext();
#line 26 "C:\Users\Pat\Desktop\.Net Enterprise\Assignment\Assignment 1\Assignment1\Assignment1\Views\Home\AddBlogPost.cshtml"
}

#line default
#line hidden
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
