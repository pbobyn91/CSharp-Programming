#pragma checksum "C:\Users\Pat\Desktop\.Net Enterprise\Assignment\Assignment 1\Assignment1\Assignment1\Views\Home\EditBlogPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9e454e0dbf3020d040f83999423c64da52ca33f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EditBlogPost), @"mvc.1.0.view", @"/Views/Home/EditBlogPost.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/EditBlogPost.cshtml", typeof(AspNetCore.Views_Home_EditBlogPost))]
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
#line 1 "C:\Users\Pat\Desktop\.Net Enterprise\Assignment\Assignment 1\Assignment1\Assignment1\Views\Home\EditBlogPost.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9e454e0dbf3020d040f83999423c64da52ca33f", @"/Views/Home/EditBlogPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"965bb1241869d6115733232d12dfa4aeb5b85321", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EditBlogPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Pat\Desktop\.Net Enterprise\Assignment\Assignment 1\Assignment1\Assignment1\Views\Home\EditBlogPost.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(66, 151, true);
            WriteLiteral("\r\n<div style=\"padding-bottom:9px; margin: 40px 0 20px; border-bottom: 1px solid #eee; box-sizing: border-box\">\r\n    <h3>Edit Blog Post</h3>\r\n</div>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\Pat\Desktop\.Net Enterprise\Assignment\Assignment 1\Assignment1\Assignment1\Views\Home\EditBlogPost.cshtml"
 using (Html.BeginForm("EditBlog", "Home"))
{

#line default
#line hidden
            BeginContext(265, 221, true);
            WriteLiteral("<fieldset>\r\n    <div class=\"form-group\">\r\n        <label for=\"Title\">Title: </label>\r\n        <input class=\"form-control\" type=\"text\" data-val=\"true\" data-val-length=\"200\" data-val-length-max=\"200\" id=\"Title\" name=\"Title\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 486, "\"", 506, 1);
#line 15 "C:\Users\Pat\Desktop\.Net Enterprise\Assignment\Assignment 1\Assignment1\Assignment1\Views\Home\EditBlogPost.cshtml"
WriteAttributeValue("", 494, Model.Title, 494, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(507, 258, true);
            WriteLiteral(@" required />
    </div>
    <div class=""form-group"">
        <label for=""Content"">Content:</label><br />
        <textarea class=""form-control"" type=""text"" data-val=""true"" data-val-length-max=""4000"" id=""Content"" name=""Content"" required>
                ");
            EndContext();
            BeginContext(766, 13, false);
#line 20 "C:\Users\Pat\Desktop\.Net Enterprise\Assignment\Assignment 1\Assignment1\Assignment1\Views\Home\EditBlogPost.cshtml"
           Write(Model.Content);

#line default
#line hidden
            EndContext();
            BeginContext(779, 89, true);
            WriteLiteral("\r\n            </textarea>\r\n    </div>\r\n    <input type=\"hidden\" id=\"UserId\" name=\"UserId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 868, "\"", 912, 1);
#line 23 "C:\Users\Pat\Desktop\.Net Enterprise\Assignment\Assignment 1\Assignment1\Assignment1\Views\Home\EditBlogPost.cshtml"
WriteAttributeValue("", 876, Context.Session.GetInt32("_userId"), 876, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(913, 55, true);
            WriteLiteral(" />\r\n    <input type=\"hidden\" ud=\"Posted\" name=\"Posted\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 968, "\"", 989, 1);
#line 24 "C:\Users\Pat\Desktop\.Net Enterprise\Assignment\Assignment 1\Assignment1\Assignment1\Views\Home\EditBlogPost.cshtml"
WriteAttributeValue("", 976, DateTime.Now, 976, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(990, 63, true);
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"BlogPostId\" name=\"BlogPostId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1053, "\"", 1078, 1);
#line 25 "C:\Users\Pat\Desktop\.Net Enterprise\Assignment\Assignment 1\Assignment1\Assignment1\Views\Home\EditBlogPost.cshtml"
WriteAttributeValue("", 1061, Model.BlogPostId, 1061, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1079, 99, true);
            WriteLiteral(" />\r\n    <input type=\"submit\" value=\"Edit Blog Post\" class=\"btn btn-outline-dark\" />\r\n</fieldset>\r\n");
            EndContext();
#line 28 "C:\Users\Pat\Desktop\.Net Enterprise\Assignment\Assignment 1\Assignment1\Assignment1\Views\Home\EditBlogPost.cshtml"
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
