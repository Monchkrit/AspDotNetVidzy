#pragma checksum "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Customers/CustomerForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d700729c6ccf42b0321ef1255a83008a1bd4a3b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_CustomerForm), @"mvc.1.0.view", @"/Views/Customers/CustomerForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d700729c6ccf42b0321ef1255a83008a1bd4a3b9", @"/Views/Customers/CustomerForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5f1cd008877cdb7a8309a52d389048c655f591a", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_CustomerForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vidly.ViewModels.CustomerFormViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Customers/CustomerForm.cshtml"
  
    ViewData["Title"] = "Customer Form";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Customer Form</h2>\n");
#nullable restore
#line 9 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Customers/CustomerForm.cshtml"
 using (Html.BeginForm("Save", "Customers"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\n        ");
#nullable restore
#line 12 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Customers/CustomerForm.cshtml"
   Write(Html.LabelFor(c => c.Customer.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 13 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Customers/CustomerForm.cshtml"
   Write(Html.TextBoxFor(c => c.Customer.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 14 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Customers/CustomerForm.cshtml"
   Write(Html.ValidationMessageFor(c => c.Customer.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <br/>\n        ");
#nullable restore
#line 16 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Customers/CustomerForm.cshtml"
   Write(Html.LabelFor(c => c.Customer.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 17 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Customers/CustomerForm.cshtml"
   Write(Html.TextBoxFor(c => c.Customer.BirthDate, "{0:MM/dd/yyyy}", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <br/>\n        ");
#nullable restore
#line 19 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Customers/CustomerForm.cshtml"
   Write(Html.LabelFor(m => m.MembershipTypes, "Membership Type"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 20 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Customers/CustomerForm.cshtml"
   Write(Html.DropDownListFor(m => m.Customer.MembershipTypeId, new SelectList(Model.MembershipTypes, "Id", "Name"), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div class=\"checkbox\">\n        <label>\n            ");
#nullable restore
#line 24 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Customers/CustomerForm.cshtml"
       Write(Html.CheckBoxFor(c => c.Customer.IsSubscribedToNewsletter));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Subscribe To Newsletter\n        </label>\n    </div>\n");
#nullable restore
#line 27 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Customers/CustomerForm.cshtml"
Write(Html.HiddenFor(c => c.Customer.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-primary\">Save</button>\n");
#nullable restore
#line 29 "/home/monchkrit/Code-House/AspDotNet/MVC5Course/Vidly/Views/Customers/CustomerForm.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vidly.ViewModels.CustomerFormViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
