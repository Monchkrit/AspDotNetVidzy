#pragma checksum "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Movies/MovieForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea56824a5f89d6e95d886c3e2c420185605a8eeb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_MovieForm), @"mvc.1.0.view", @"/Views/Movies/MovieForm.cshtml")]
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
#line 1 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/_ViewImports.cshtml"
using Vidly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/_ViewImports.cshtml"
using Vidly.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea56824a5f89d6e95d886c3e2c420185605a8eeb", @"/Views/Movies/MovieForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5f1cd008877cdb7a8309a52d389048c655f591a", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_MovieForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vidly.ViewModels.MovieFormViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Movies/MovieForm.cshtml"
  
    ViewData["Title"] = "Customer Form";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>New Movie</h2>\n");
#nullable restore
#line 9 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Movies/MovieForm.cshtml"
 using (Html.BeginForm("Save", "Movies"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\n      ");
#nullable restore
#line 12 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Movies/MovieForm.cshtml"
 Write(Html.LabelFor(m => m.Movie.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      ");
#nullable restore
#line 13 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Movies/MovieForm.cshtml"
 Write(Html.TextBoxFor(m => m.Movie.Name, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      <br/>\n      ");
#nullable restore
#line 15 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Movies/MovieForm.cshtml"
 Write(Html.LabelFor(m => m.Movie.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      ");
#nullable restore
#line 16 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Movies/MovieForm.cshtml"
 Write(Html.TextBoxFor(m => m.Movie.ReleaseDate, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      <br/>\n      ");
#nullable restore
#line 18 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Movies/MovieForm.cshtml"
 Write(Html.LabelFor(m => m.Movie.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      ");
#nullable restore
#line 19 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Movies/MovieForm.cshtml"
 Write(Html.TextBoxFor(m => m.Movie.Stock, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      <br/>\n      ");
#nullable restore
#line 21 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Movies/MovieForm.cshtml"
 Write(Html.LabelFor(g => g.Genres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      ");
#nullable restore
#line 22 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Movies/MovieForm.cshtml"
 Write(Html.DropDownListFor(g => g.Movie.GenreId, new SelectList(Model.Genres, "GenreId", "Type"), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 24 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Movies/MovieForm.cshtml"
Write(Html.HiddenFor(m => m.Movie.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-primary\">Save</button>\n");
#nullable restore
#line 26 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Movies/MovieForm.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vidly.ViewModels.MovieFormViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
