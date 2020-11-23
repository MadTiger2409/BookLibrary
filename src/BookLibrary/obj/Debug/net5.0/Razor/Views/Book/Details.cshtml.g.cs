#pragma checksum "C:\Projects\GitHub\BookLibrary\src\BookLibrary\Views\Book\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d0e7fc7826d1fe9b32ebb47d31de85bdc36a78a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Details), @"mvc.1.0.view", @"/Views/Book/Details.cshtml")]
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
#line 1 "C:\Projects\GitHub\BookLibrary\src\BookLibrary\Views\_ViewImports.cshtml"
using BookLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\GitHub\BookLibrary\src\BookLibrary\Views\_ViewImports.cshtml"
using BookLibrary.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d0e7fc7826d1fe9b32ebb47d31de85bdc36a78a", @"/Views/Book/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b74a20da30516801813781460676a58521fc3f21", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookLibrary.ViewModels.BookDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Projects\GitHub\BookLibrary\src\BookLibrary\Views\Book\Details.cshtml"
  
    ViewData["Title"] = Model.Book.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h2 class=\"display-4\">");
#nullable restore
#line 8 "C:\Projects\GitHub\BookLibrary\src\BookLibrary\Views\Book\Details.cshtml"
                     Write(Model.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <h5>by ");
#nullable restore
#line 9 "C:\Projects\GitHub\BookLibrary\src\BookLibrary\Views\Book\Details.cshtml"
      Write(Model.Book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n    <div class=\"card-body border\">\r\n\r\n        <div class=\"card mb-4\">\r\n            <div class=\"card-body\">\r\n                <h6 class=\"card-subtitle mb-2 text-muted\">First release: ");
#nullable restore
#line 15 "C:\Projects\GitHub\BookLibrary\src\BookLibrary\Views\Book\Details.cshtml"
                                                                    Write(Model.Book.ReleaseDate.Date.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <hr />\r\n                <p class=\"card-text\">");
#nullable restore
#line 17 "C:\Projects\GitHub\BookLibrary\src\BookLibrary\Views\Book\Details.cshtml"
                                Write(Model.Book.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
        </div>

        <div class=""card"">
            <div class=""card-body"">
                <h5 class=""card-title"">Reservations</h5>

                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th scope=""col"">#</th>
                            <th scope=""col"">User</th>
                            <th scope=""col"">Reservation date</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 34 "C:\Projects\GitHub\BookLibrary\src\BookLibrary\Views\Book\Details.cshtml"
                         for (int i = 1; i <= Model.Reservations.Count(); i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\">");
#nullable restore
#line 37 "C:\Projects\GitHub\BookLibrary\src\BookLibrary\Views\Book\Details.cshtml"
                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td>");
#nullable restore
#line 38 "C:\Projects\GitHub\BookLibrary\src\BookLibrary\Views\Book\Details.cshtml"
                               Write(Model.Reservations[i - 1].UserLogin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 39 "C:\Projects\GitHub\BookLibrary\src\BookLibrary\Views\Book\Details.cshtml"
                               Write(Model.Reservations[i - 1].ReservedAt.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 41 "C:\Projects\GitHub\BookLibrary\src\BookLibrary\Views\Book\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookLibrary.ViewModels.BookDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
