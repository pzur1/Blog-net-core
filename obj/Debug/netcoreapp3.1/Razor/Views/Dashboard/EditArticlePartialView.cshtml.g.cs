#pragma checksum "C:\Users\patryk\source\repos\Blog\Views\Dashboard\EditArticlePartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3ae413d6012f3fbe7526efd84957914ab1857f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_EditArticlePartialView), @"mvc.1.0.view", @"/Views/Dashboard/EditArticlePartialView.cshtml")]
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
#line 1 "C:\Users\patryk\source\repos\Blog\Views\_ViewImports.cshtml"
using Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\patryk\source\repos\Blog\Views\_ViewImports.cshtml"
using Blog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3ae413d6012f3fbe7526efd84957914ab1857f3", @"/Views/Dashboard/EditArticlePartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60de8826b8954e9153bb5ddebbd8520bddd0a921", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_EditArticlePartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog.Models.Article>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 7 "C:\Users\patryk\source\repos\Blog\Views\Dashboard\EditArticlePartialView.cshtml"
         using (Html.BeginForm("MyEdit", "Article"))

        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col\">\r\n                <div>Title</div>\r\n                ");
#nullable restore
#line 11 "C:\Users\patryk\source\repos\Blog\Views\Dashboard\EditArticlePartialView.cshtml"
           Write(Html.TextBoxFor(item => item.Title, new { style = "width: 15em;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"w-100\"></div>\r\n            <div class=\"col\">\r\n                <div>Content</div>\r\n                ");
#nullable restore
#line 16 "C:\Users\patryk\source\repos\Blog\Views\Dashboard\EditArticlePartialView.cshtml"
           Write(Html.TextBoxFor(item => item.Content, new { style = "width: 30em; height:17em;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                <div class=\"w-100\"></div>\r\n            </div>\r\n            <div class=\"col\">\r\n                <div>Category Id</div>\r\n                ");
#nullable restore
#line 22 "C:\Users\patryk\source\repos\Blog\Views\Dashboard\EditArticlePartialView.cshtml"
           Write(Html.TextBoxFor(item => item.CategoryId, new { style = "width: 1em;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"w-100\"></div>\r\n            <br />\r\n            <div class=\"col\">\r\n                <input type=\"submit\" class=\"btn btn-primary btn-sm\" value=\"Click\" />\r\n            </div>\r\n");
#nullable restore
#line 29 "C:\Users\patryk\source\repos\Blog\Views\Dashboard\EditArticlePartialView.cshtml"
       Write(Html.Hidden("id", Model.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\patryk\source\repos\Blog\Views\Dashboard\EditArticlePartialView.cshtml"
                                        
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog.Models.Article> Html { get; private set; }
    }
}
#pragma warning restore 1591