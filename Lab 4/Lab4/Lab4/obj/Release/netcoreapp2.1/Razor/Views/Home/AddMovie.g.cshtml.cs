#pragma checksum "C:\Users\Pat\Desktop\.Net Enterprise\Lab\Lab 4\Lab4\Lab4\Views\Home\AddMovie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b74161a1a65b95c270a7f0688e8a6082db0ca3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddMovie), @"mvc.1.0.view", @"/Views/Home/AddMovie.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AddMovie.cshtml", typeof(AspNetCore.Views_Home_AddMovie))]
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
#line 1 "C:\Users\Pat\Desktop\.Net Enterprise\Lab\Lab 4\Lab4\Lab4\Views\_ViewImports.cshtml"
using Lab4;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b74161a1a65b95c270a7f0688e8a6082db0ca3f", @"/Views/Home/AddMovie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1ab9bd03e093e081fcba543b6fa9c1fdee09ff8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddMovie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab4.Models.Movies>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Pat\Desktop\.Net Enterprise\Lab\Lab 4\Lab4\Lab4\Views\Home\AddMovie.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(59, 26, true);
            WriteLiteral("\r\n<h2>Add Movie</h2>\r\n\r\n\r\n");
            EndContext();
#line 9 "C:\Users\Pat\Desktop\.Net Enterprise\Lab\Lab 4\Lab4\Lab4\Views\Home\AddMovie.cshtml"
 using (Html.BeginForm("CreateMovie", "Home", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(153, 1554, true);
            WriteLiteral(@"<fieldset>
    <div>
        <label for=""Title"">Title</label>
        <input type=""text"" data-val=""true"" data-val-length=""The field Title must be a string with a maximum length of 1000."" data-val-length-max=""1000"" data-val-required=""The Title field is required."" id=""Title"" name=""Title"" value="""" />
    </div>
    <div>
        <label for=""SubTitle"">SubTitle</label>
        <input type=""text"" data-val=""true"" data-val-length=""The field SubTitle must be a string with a maximum length of 1000."" data-val-length-max=""1000"" data-val-required=""The SubTitle field is required."" id=""SubTitle"" name=""SubTitle"" value="""" />
    </div>
    <div>
        <label for=""Description"">Description</label>
        <input type=""text"" data-val=""true"" data-val-length=""The field Description must be a string with a maximum length of 1000."" data-val-length-max=""1000"" data-val-required=""The Description field is required."" id=""Description"" name=""Description"" value="""" />
    </div>
    <div>
        <label for=""Year"">Year</label>");
            WriteLiteral(@"
        <input type=""date"" data-val=""true"" data-val-required=""The Year field is required."" id=""Year"" name=""Year"" value="""" />
    </div>
    <div>
        <label for=""Rating"">Rating</label>
        <input type=""number"" data-val=""true"" data-val-range=""The field Rating must be between 1 and 5."" data-val-range-max=""5"" data-val-range-min=""1"" data-val-required=""The Rating field is required."" id=""Rating"" name=""Rating"" value="""" />
    </div>
    <br />
    <br />
    <input type=""submit"" value=""Add Movie"" />
</fieldset>
");
            EndContext();
#line 36 "C:\Users\Pat\Desktop\.Net Enterprise\Lab\Lab 4\Lab4\Lab4\Views\Home\AddMovie.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab4.Models.Movies> Html { get; private set; }
    }
}
#pragma warning restore 1591