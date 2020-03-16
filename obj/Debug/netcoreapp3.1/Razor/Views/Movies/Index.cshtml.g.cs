#pragma checksum "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Movies/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fac41969f429dd1429be783e694383fed973df66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fac41969f429dd1429be783e694383fed973df66", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5f1cd008877cdb7a8309a52d389048c655f591a", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vidly.ViewModels.MovieViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Movies/Index.cshtml"
 if (Model.Movies.Count == 0)
{
  

#line default
#line hidden
#nullable disable
            WriteLiteral("There aren\'t any movies.");
#nullable restore
#line 5 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Movies/Index.cshtml"
                                       
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\n<div class=\"row\">  \n  <button class=\"btn btn-outline-primary\" type=\"submit\">\n    ");
#nullable restore
#line 10 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Movies/Index.cshtml"
Write(Html.ActionLink("Add", "New", "Movies", null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n  </button>\n</div>\n<br/>\n<table id=\"movie-table\" class=\"table table-bordered table-hover\">\n  <thead>\n    <tr>\n      <th>Movies</th>\n      <th>Genre</th>\n      <th>Release Date</th>\n      <th>Delete</th>\n    </tr>\n  </thead>\n");
            WriteLiteral("</table>\n\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
  <script>
    $(document).ready(function() {
      let table = $('#movie-table').DataTable({
        ajax: {
          url: ""/api/movies"",
          dataSrc: """"
        },
        columns: [
        {
          data: ""id"",
          render: function(data, type, movie) {
            return ""<a href='/movies/edit/"" + data + ""'>"" + movie.name + ""</a>"";
          }
        },
        {
          data: ""genre.type""
        },
        {
          data: ""releaseDate""
        },
        {
          data: ""id"",
          render: function(data) {
            return ""<button class='btn-link js-delete' data-movie-id="" + data + "">Delete</button>"";
          }
        }
        ]
      });
      $(""#movie-table"").on(""click"", "".js-delete"", function () {
        var button = $(this);

        bootbox.confirm({
          title: ""Delete Customer?"",
          message: ""Are you sure you want to delete this movie?"",
          buttons: {
            cancel: {
              label: '<i class=""fa fa-times""></i> Cancel'
            ");
                WriteLiteral(@"},
            confirm: {
              label: '<i class=""fa fa-check""></i> Confirm'
            }
          },
          callback: function (result) {
            if (result){
            $.ajax({
              url: ""/api/movies/delete/"" + button.attr(""data-movie-id""),
              method: ""DELETE"",
              success: function () {
                table.row(button.parents(""tr"")).remove().draw();
              }
            });
          }
        }
      });

      });
    });
  </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vidly.ViewModels.MovieViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
