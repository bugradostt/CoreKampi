#pragma checksum "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreKampi\CoreKampi\Views\Shared\Components\ListLast3Blog\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "750b760bb510764aa00481c444602c8e1ae90384"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ListLast3Blog_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ListLast3Blog/Default.cshtml")]
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
#line 1 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreKampi\CoreKampi\Views\_ViewImports.cshtml"
using CoreKampi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreKampi\CoreKampi\Views\_ViewImports.cshtml"
using CoreKampi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreKampi\CoreKampi\Views\Shared\Components\ListLast3Blog\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"750b760bb510764aa00481c444602c8e1ae90384", @"/Views/Shared/Components/ListLast3Blog/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3de1325e3222c41617bc1a6f78f03d254ed8fb7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ListLast3Blog_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"tech-btm\">\r\n    <h3>Son Postlar</h3>\r\n");
#nullable restore
#line 6 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreKampi\CoreKampi\Views\Shared\Components\ListLast3Blog\Default.cshtml"
     foreach (var i in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-grids row mb-3\">\r\n            <div class=\"col-md-5 blog-grid-left\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 250, "\"", 283, 2);
            WriteAttributeValue("", 257, "/Blog/BlogDetail/", 257, 17, true);
#nullable restore
#line 10 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreKampi\CoreKampi\Views\Shared\Components\ListLast3Blog\Default.cshtml"
WriteAttributeValue("", 274, i.BlogId, 274, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 311, "\"", 329, 1);
#nullable restore
#line 11 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreKampi\CoreKampi\Views\Shared\Components\ListLast3Blog\Default.cshtml"
WriteAttributeValue("", 317, i.BlogImage, 317, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 361, "\"", 367, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n            <div class=\"col-md-7 blog-grid-right\">\r\n\r\n                <h5>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 511, "\"", 544, 2);
            WriteAttributeValue("", 518, "/Blog/BlogDetail/", 518, 17, true);
#nullable restore
#line 17 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreKampi\CoreKampi\Views\Shared\Components\ListLast3Blog\Default.cshtml"
WriteAttributeValue("", 535, i.BlogId, 535, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 18 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreKampi\CoreKampi\Views\Shared\Components\ListLast3Blog\Default.cshtml"
                         if (i.BlogContent.Length > 50)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreKampi\CoreKampi\Views\Shared\Components\ListLast3Blog\Default.cshtml"
                       Write(i.BlogContent.Substring(0, 50));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>...</span>\r\n");
#nullable restore
#line 21 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreKampi\CoreKampi\Views\Shared\Components\ListLast3Blog\Default.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreKampi\CoreKampi\Views\Shared\Components\ListLast3Blog\Default.cshtml"
                       Write(i.BlogContent);

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreKampi\CoreKampi\Views\Shared\Components\ListLast3Blog\Default.cshtml"
                                          
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </a>\r\n                </h5>\r\n                <div class=\"sub-meta\">\r\n                    <span>\r\n                        <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 30 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreKampi\CoreKampi\Views\Shared\Components\ListLast3Blog\Default.cshtml"
                                                Write(i.BlogCreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 36 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreKampi\CoreKampi\Views\Shared\Components\ListLast3Blog\Default.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591