#pragma checksum "C:\Users\abdul\OneDrive\سطح المكتب\unitTest\mvc-unit-test\Blog-Website\Views\Articles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a140d5fe2337b706353d59214aa7d7fe722f1dbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articles_Index), @"mvc.1.0.view", @"/Views/Articles/Index.cshtml")]
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
#line 1 "C:\Users\abdul\OneDrive\سطح المكتب\unitTest\mvc-unit-test\Blog-Website\Views\_ViewImports.cshtml"
using Blog_Website;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdul\OneDrive\سطح المكتب\unitTest\mvc-unit-test\Blog-Website\Views\_ViewImports.cshtml"
using Blog_Website.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a140d5fe2337b706353d59214aa7d7fe722f1dbd", @"/Views/Articles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27ce68408b60501a57e44302d66da5f8e6f51ba7", @"/Views/_ViewImports.cshtml")]
    public class Views_Articles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\abdul\OneDrive\سطح المكتب\unitTest\mvc-unit-test\Blog-Website\Views\Articles\Index.cshtml"
  
    var Articles = (List<ArticlesModel>)ViewData["Articles"];
    var authors = (List<UserModel>) ViewData["authors"];
    var p2 = "";
    var id = (int)ViewData["id"];



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 12 "C:\Users\abdul\OneDrive\سطح المكتب\unitTest\mvc-unit-test\Blog-Website\Views\Articles\Index.cshtml"
 foreach (var Article in Articles)
{

    var p = Article.Article_content;
    if (id == -1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container Main-blog\">\r\n            <div class=\"row\">\r\n                <div class=\"col-sm\">\r\n                    <h2>\r\n                        ");
#nullable restore
#line 22 "C:\Users\abdul\OneDrive\سطح المكتب\unitTest\mvc-unit-test\Blog-Website\Views\Articles\Index.cshtml"
                   Write(Article.Article_title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h2>\r\n                    <br />\r\n");
#nullable restore
#line 25 "C:\Users\abdul\OneDrive\سطح المكتب\unitTest\mvc-unit-test\Blog-Website\Views\Articles\Index.cshtml"
                     foreach(var author  in authors)
                    {
                        if(Article.User_id == author.User_id)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"fw-light\">");
#nullable restore
#line 29 "C:\Users\abdul\OneDrive\سطح المكتب\unitTest\mvc-unit-test\Blog-Website\Views\Articles\Index.cshtml"
                                           Write(author.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 30 "C:\Users\abdul\OneDrive\سطح المكتب\unitTest\mvc-unit-test\Blog-Website\Views\Articles\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n                    <p style=\"color: #d0d1d0;font-size:15px\">");
#nullable restore
#line 33 "C:\Users\abdul\OneDrive\سطح المكتب\unitTest\mvc-unit-test\Blog-Website\Views\Articles\Index.cshtml"
                                                        Write(Article.Created_at);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                   \r\n\r\n                </div>\r\n                <div class=\"col-sm\">\r\n");
#nullable restore
#line 38 "C:\Users\abdul\OneDrive\سطح المكتب\unitTest\mvc-unit-test\Blog-Website\Views\Articles\Index.cshtml"
                     if (p.Length > 200)
                    {
                        p2 = p.Substring(0, 200) + " ...";
                    }
                    else
                    {
                        p2 = p;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <h6>");
#nullable restore
#line 47 "C:\Users\abdul\OneDrive\سطح المكتب\unitTest\mvc-unit-test\Blog-Website\Views\Articles\Index.cshtml"
                   Write(p2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <br />\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1356, "\"", 1400, 2);
            WriteAttributeValue("", 1363, "/Articles/Details/", 1363, 18, true);
#nullable restore
#line 49 "C:\Users\abdul\OneDrive\سطح المكتب\unitTest\mvc-unit-test\Blog-Website\Views\Articles\Index.cshtml"
WriteAttributeValue("", 1381, Article.Article_id, 1381, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button type=\"button\" class=\"btn btn-outline-secondary\">Read More</button></a>\r\n                </div>\r\n                <div class=\"col-sm\">\r\n                    <img");
            BeginWriteAttribute("src", " src=", 1568, "", 1595, 1);
#nullable restore
#line 52 "C:\Users\abdul\OneDrive\سطح المكتب\unitTest\mvc-unit-test\Blog-Website\Views\Articles\Index.cshtml"
WriteAttributeValue("", 1573, Article.Article_image, 1573, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"350\" height=\"200\"  />\r\n                </div>\r\n            </div>\r\n            <hr />\r\n        </div>\r\n");
#nullable restore
#line 57 "C:\Users\abdul\OneDrive\سطح المكتب\unitTest\mvc-unit-test\Blog-Website\Views\Articles\Index.cshtml"

    }
    else if (Article.User_id == id)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container Main-blog\">\r\n            <div class=\"row\">\r\n                <div class=\"col-sm\">\r\n                    <h2>\r\n                        ");
#nullable restore
#line 65 "C:\Users\abdul\OneDrive\سطح المكتب\unitTest\mvc-unit-test\Blog-Website\Views\Articles\Index.cshtml"
                   Write(Article.Article_title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h2>\r\n                    <br />\r\n\r\n");
#nullable restore
#line 69 "C:\Users\abdul\OneDrive\سطح المكتب\unitTest\mvc-unit-test\Blog-Website\Views\Articles\Index.cshtml"
                     foreach (var author in authors)
                    {
                        if (Article.User_id == author.User_id)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"fw-light\">");
#nullable restore
#line 73 "C:\Users\abdul\OneDrive\سطح المكتب\unitTest\mvc-unit-test\Blog-Website\Views\Articles\Index.cshtml"
                                           Write(author.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 74 "C:\Users\abdul\OneDrive\سطح المكتب\unitTest\mvc-unit-test\Blog-Website\Views\Articles\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <p style=\"color: #d0d1d0;font-size:15px\">");
#nullable restore
#line 77 "C:\Users\abdul\OneDrive\سطح المكتب\unitTest\mvc-unit-test\Blog-Website\Views\Articles\Index.cshtml"
                                                        Write(Article.Created_at);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                </div>\r\n                <div class=\"col-sm\">\r\n");
#nullable restore
#line 81 "C:\Users\abdul\OneDrive\سطح المكتب\unitTest\mvc-unit-test\Blog-Website\Views\Articles\Index.cshtml"
                     if (p.Length > 200)
                    {
                        p2 = p.Substring(0, 200) + " ...";
                    }
                    else
                    {
                        p2 = p;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <h6>");
#nullable restore
#line 90 "C:\Users\abdul\OneDrive\سطح المكتب\unitTest\mvc-unit-test\Blog-Website\Views\Articles\Index.cshtml"
                   Write(p2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <br />\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2781, "\"", 2825, 2);
            WriteAttributeValue("", 2788, "/Articles/Details/", 2788, 18, true);
#nullable restore
#line 92 "C:\Users\abdul\OneDrive\سطح المكتب\unitTest\mvc-unit-test\Blog-Website\Views\Articles\Index.cshtml"
WriteAttributeValue("", 2806, Article.Article_id, 2806, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button type=\"button\" class=\"btn btn-outline-secondary\">Read More</button></a>\r\n                </div>\r\n                <div class=\"col-sm\">\r\n                    <img");
            BeginWriteAttribute("src", " src=", 2993, "", 3020, 1);
#nullable restore
#line 95 "C:\Users\abdul\OneDrive\سطح المكتب\unitTest\mvc-unit-test\Blog-Website\Views\Articles\Index.cshtml"
WriteAttributeValue("", 2998, Article.Article_image, 2998, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"350\" height=\"200\" />\r\n                </div>\r\n            </div>\r\n            <hr />\r\n                      \r\n        </div>\r\n");
#nullable restore
#line 101 "C:\Users\abdul\OneDrive\سطح المكتب\unitTest\mvc-unit-test\Blog-Website\Views\Articles\Index.cshtml"

    }



}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
